using static Raschet.Utils.InteractionsWithWindows;
using Raschet.Utils;

namespace Raschet;

public partial class ResistanceSelectionForm : Form {

    Form entryForm;
    Resistor[] resistors;
    public ResistanceSelectionForm(Form entryForm, Resistor[] resistors) {
        InitializeComponent();
        this.FormClosed += (s, e) => Application.Exit();
        this.resistors = resistors;
        this.entryForm = entryForm;

        //"Сопротивление квадрата(ρ)";
        double sumResistor = resistors.Aggregate(0, (double sumResistor, Resistor resistor) => sumResistor += resistor.nominal);
        double reverseSumResistor = resistors.Aggregate(0, (double sumResistor, Resistor resistor) => sumResistor += 1 / resistor.nominal);
        double squareResistance = Math.Sqrt(sumResistor / reverseSumResistor);

        squareResistanceLabel.Text = "Сопротивление квадрата(ρ): " + Math.Round(squareResistance);
    }

    private void InputNumbers(object sender, EventArgs e) {
        TextBox tb = (TextBox)sender;
        int currentCursor = tb.SelectionStart;
        tb.Text = tb.Text.Replace(',', '.');
        tb.SelectionStart = tb.Text.Length - 1 >= currentCursor ? currentCursor : tb.Text.Length;
    }

    private void anew_Click(object sender, EventArgs e) => SwapWindow(this, entryForm);

    private void next_Click(object sender, EventArgs e) {
        PropertiesResistors prop = new PropertiesResistors();

        bool correctSpecificSurfaceResistance = Double.TryParse(specificSurfaceResistanceTextbox.Text.Replace('.', ','), out double specificSurfaceResistance);           //Номинал
        bool correctTKS = Double.TryParse(TKSTextbox.Text.Replace('.', ','), out double TKS);
        bool correctAgingFactor = Double.TryParse(agingFactorTextbox.Text.Replace('.', ','), out double agingFactor);
        bool correctSpecificPowerDissipation = Double.TryParse(specificPowerDissipationTextbox.Text.Replace('.', ','), out double specificPowerDissipation);

        string err = "";
        if (!correctSpecificSurfaceResistance) err += "Введено неверное удельное поверхостное сопростиление!\n";
        if (!correctTKS) err += "Введён неверный ТКС!\n";
        if (!correctAgingFactor) err += $"Введён неверно коэффициент старения";
        if (!correctSpecificPowerDissipation) err += $"Введёна неверно удельная мощность рассеяния";

        if (err != "") {
            MessageBox.Show(err, "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        prop.SpecificPowerDissipation = specificPowerDissipation;
        prop.TKS = TKS * 0.0001;
        prop.AgingFactor = agingFactor * 0.000001;
        prop.SpecificSurfaceResistance = specificSurfaceResistance;
        SwapWindow(this, new StepForm(resistors, entryForm, prop));

    }

    private void Enter_KeyDown(object sender, KeyEventArgs e) {
        if (e.KeyData == Keys.Enter) next_Click(sender, null);
    }
}