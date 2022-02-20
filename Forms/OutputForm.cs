using static Raschet.Utils.InteractionsWithWindows;
using Raschet.Utils;

namespace Raschet;
public partial class OutputForm : Form {
    Resistor[] resistors;
    PropertiesResistors prop;
    Form entryForm;

    public OutputForm(Form form, Resistor[] resistors, PropertiesResistors prop) {
        InitializeComponent();
        this.FormClosed += (s, e) => Application.Exit();
        (this.entryForm, this.resistors, this.prop) = (form, resistors, prop);

        foreach (DataGridViewColumn column in table.Columns)
            column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

        string nominal, len, width, square;
        for (int i = 0; i < resistors.Length; i++) {
            bool hardRes = resistors[i].Len == 0;
            if (hardRes)
                (nominal, len, width, square) = ("Резистор сложной формы", "Резистор сложной формы", "Резистор сложной формы", "Резистор сложной формы");
            else if (resistors[i].erroneous)
                (nominal, len, width, square) = ("Данный резистор существовать не может", "Данный резистор существовать не может", "Данный резистор существовать не может", "Данный резистор существовать не может");
            else (nominal, len, width, square) = (resistors[i].nominal.ToString(), resistors[i].Len.ToString(), resistors[i].Width.ToString(), resistors[i].Square.ToString());
            table.Rows.Add(new string[] { $"{ i + 1 }", nominal, len, width, square });
        }
    }

    private void anew_Click(object sender, EventArgs e) => SwapWindow(this, entryForm);
    private void exit_Click(object sender, EventArgs e) => Application.Exit();
}

