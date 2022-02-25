using static Raschet.Utils.InteractionsWithWindows;

namespace Raschet;
public partial class FillingResistorsForm : Form {
    int MAXDELTA = 30;

    int currentResistor = 1;
    int countResistors;
    Resistor[] resistors;

    Form EntryForm;
    public FillingResistorsForm(int countResistors, Form EntryForm) {
        InitializeComponent();
        this.FormClosed += (s, e) => Application.Exit();
        this.countResistors = countResistors;
        resistors = new Resistor[countResistors];
        this.EntryForm = EntryForm;
    }

    private void InputNumbers(object sender, EventArgs e) {
        TextBox tb = (TextBox)sender;
        int currentCursor = tb.SelectionStart;
        tb.Text = tb.Text.Replace(',', '.');
        tb.SelectionStart = tb.Text.Length - 1 >= currentCursor ? currentCursor : tb.Text.Length;
    }

    private void next_Click(object sender, EventArgs e) {
        bool correctNominal = Double.TryParse(nominalTextbox.Text.Replace('.', ','), out double R);           //Номинал
        bool correctPower = Double.TryParse(powerTextbox.Text.Replace('.', ','), out double P);               //Мощность
        bool correctAdmittance = Double.TryParse(admittanceTextbox.Text.Replace('.', ','), out double Delta); //Допуск

        string err = "";
        if (!correctNominal || R <= 0) err += "Введён неверное номинал!\n";
        if (!correctPower || P <= 0) err += "Введена неверная мощность!\n";
        if (!correctAdmittance || Delta > MAXDELTA) err += $"Введён неверный допуск!(от 0 до {MAXDELTA })";

        if (err != "") {
            MessageBox.Show(err, "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        resistors[currentResistor - 1] = new Resistor();
        resistors[currentResistor - 1].nominal = R;
        resistors[currentResistor - 1].power = P;
        resistors[currentResistor - 1].admittance = Delta;

        if (currentResistor == countResistors) {
            SwapWindow(this, new ResistanceSelectionForm(EntryForm, resistors));
            return;
        }

        currentResistor++;
        resistorNumberTextbox.Text = $"{currentResistor} резистор:";

        fillTextbox();

        nominalTextbox.Focus();
    }

    private void back_Click(object sender, EventArgs e) {
        currentResistor--;

        if (currentResistor == 0) {
            SwapWindow(this, EntryForm);
            return;
        }

        fillTextbox();

        resistorNumberTextbox.Text = $"{currentResistor} резистор:";
    }

    private void fillTextbox() {
        string nominal = resistors[currentResistor - 1]?.nominal.ToString().Replace('.', ',');
        string power = resistors[currentResistor - 1]?.power.ToString().Replace('.', ',');
        string admittance = resistors[currentResistor - 1]?.admittance.ToString().Replace('.', ',');

        nominalTextbox.Text = nominal == "0" ? "" : nominal;
        powerTextbox.Text = power == "0" ? "" : power;
        admittanceTextbox.Text = admittance == "0" ? "" : admittance;
    }

    private void Enter_KeyDown(object sender, KeyEventArgs e) {
        if (e.KeyData == Keys.Enter) next_Click(sender, null);
    }
}

