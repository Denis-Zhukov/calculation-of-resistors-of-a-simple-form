namespace Raschet.Utils;

internal class InteractionsWithWindows {
    static public void SwapWindow(Form formToBeClosed, Form formToBeOpened) {
        formToBeOpened.Show();
        formToBeOpened.Location = formToBeClosed.Location;
        formToBeClosed.Dispose();
    }

    static public void AdoptWindow(Form formToBeClosed, Form formToBeOpened) {
        formToBeOpened.Show();
        formToBeOpened.Location = formToBeClosed.Location;
        formToBeClosed.Hide();
    }
}