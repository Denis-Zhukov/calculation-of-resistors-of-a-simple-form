using static Raschet.Utils.InteractionsWithWindows;
using Raschet.Utils;

namespace Raschet;
public partial class StepForm : Form {
    Resistor[] resistors;
    Form entryForm;
    PropertiesResistors prop;

    public StepForm(Resistor[] resistors, Form entryForm, PropertiesResistors prop) {
        InitializeComponent();
        this.FormClosed += (s, e) => Application.Exit();
        (this.resistors, this.entryForm, this.prop) = (resistors, entryForm, prop);
    }

    private void InputNumbers(object sender, EventArgs e) {
        TextBox tb = (TextBox)sender;
        int currentCursor = tb.SelectionStart;
        tb.Text = tb.Text.Replace(',', '.');
        tb.SelectionStart = tb.Text.Length - 1 >= currentCursor ? currentCursor : tb.Text.Length;
    }

    private void anew_Click(object sender, EventArgs e) => SwapWindow(this, entryForm);
    private void next_Click(object sender, EventArgs e) {
        string err = "";

        if (!Double.TryParse(stepBox.Text.Replace(".", ","), out double step))
            err += "Не выбран шаг.\n";
        if (!Int32.TryParse(scaleTextbox.Text.Replace(".", ","), out int scale))
            err += "Неверно введён масштаб.\n";
        if (!Int32.TryParse(TmaxTextbox.Text.Replace(".", ","), out int Tmax))
            err += "Неверно введена максимальная температура.\n";
        if (!Int32.TryParse(TminTextbox.Text.Replace(".", ","), out int Tmin))
            err += "Неверно введена минимальная температура.\n";
        if (!Int32.TryParse(lifeTimeTextbox.Text.Replace(".", ","), out int lifeTime))
            err += "Неверно введён срок службы.\n";

        if (err != "") {
            MessageBox.Show(err, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        double rounding = step / scale;
        prop.Rounding = rounding;
        prop.Scale = scale;
        prop.Tmax = Tmax;
        prop.Tmin = Tmin;
        prop.LifeTime = lifeTime * 100000;
        SwapWindow(this, new resistivityErrorForm(resistors, prop, entryForm));
    }

    private void Enter_KeyDown(object sender, KeyEventArgs e) {
        if (e.KeyData == Keys.Enter) next_Click(sender, null);
    }
}

