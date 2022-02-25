using static Raschet.Utils.InteractionsWithWindows;

namespace Raschet;
public partial class EntryForm : Form {
    int MAXNUMBERRESISTORS = 12;    //ÌÀÊÑÈÌÀËÜÍÎÅ ÊÎËÈ×ÅÑÒÂÎ ÐÅÇÈÑÒÎÐÎÂ
    int MINNUMBERRESISTORS = 1;     //ÌÈÍÈÌÀËÜÍÎÅ ÊÎËÈ×ÅÑÒÂÎ ÐÅÇÈÑÒÎÐÎÂ

    public EntryForm() {
        InitializeComponent();
    }

    private void next_Click(object sender, EventArgs e) {
        if (!( Int32.TryParse(numberResistorsTextbox.Text, out int numberResistors)
            && numberResistors >= MINNUMBERRESISTORS
            && numberResistors <= MAXNUMBERRESISTORS )) {
            MessageBox.Show($"Íåâåðíîå êîëè÷åñòâî ðåçèñòîðîâ:\nÌèíèìàëüíîå êîëè÷åñòâî: {MAXNUMBERRESISTORS}\nÌàêñèìàëüíîå êîëè÷åñòâî: {MINNUMBERRESISTORS}", "Îøèáêà ââîäà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        numberResistorsTextbox.Text = "";
        AdoptWindow(this, new FillingResistorsForm(numberResistors, this));
    }

    private void numberResistorsTextbox_KeyDown(object sender, KeyEventArgs e) {
        if (e.KeyData == Keys.Enter) next_Click(sender, null);
    }
}
