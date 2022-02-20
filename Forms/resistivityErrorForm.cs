using static Raschet.Utils.InteractionsWithWindows;
using Raschet.Utils;

namespace Raschet;
public partial class resistivityErrorForm : Form {
    Resistor[] resistors;
    Form entryForm;
    PropertiesResistors prop;

    public resistivityErrorForm(Resistor[] resistors, PropertiesResistors prop, Form entryForm) {
        InitializeComponent();
        this.FormClosing += (s, e) => Application.Exit();
        (this.resistors, this.entryForm, this.prop) = (resistors, entryForm, prop);
    }
    const int MAXYPS = 5;
    const int MAXYRK = 3;

    private void InputNumbers(object sender, EventArgs e) {
        TextBox tb = (TextBox)sender;
        int currentCursor = tb.SelectionStart;
        tb.Text = tb.Text.Replace(',', '.');
        tb.SelectionStart = tb.Text.Length - 1 >= currentCursor ? currentCursor : tb.Text.Length;
    }

    private void anew_Click(object sender, EventArgs e) => SwapWindow(this, entryForm);

    private void next_Click(object sender, EventArgs e) {
        string err = "";
        if (!( Double.TryParse(YPSTextbox.Text.Replace(".", ","), out double YPS) && YPS <= MAXYPS && YPS > 0 ))
            err += "Неверно введена погрешность воспроизведения удельного поверхностного сопротивления. (до 5%)\n";

        if (!( Double.TryParse(YRKTextbox.Text.Replace(".", ","), out double YRK) && YRK <= MAXYRK && YRK > 0 ))
            err += "Неверно введена погрешность обусловленная старением пленки в пределах. (до 3%)\n";

        if (err != "") {
            MessageBox.Show(err, "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        double Yrt = prop.TKS * ( Math.Abs(prop.Tmax) - 20 );
        double Yrst = prop.AgingFactor * prop.LifeTime;

        Resistor[] firstGroup = resistors.Where((res) => ( res.nominal / prop.SpecificSurfaceResistance ) > 10).ToArray();
        Resistor[] secondGroup = resistors.Where((res) => {
            var kf = res.nominal / prop.SpecificSurfaceResistance;
            res.Kf = kf;
            return kf <= 10 && kf >= 1;
        }).ToArray();
        Resistor[] thirdGroup = resistors.Where((res) => {
            double kf = res.nominal / prop.SpecificSurfaceResistance;
            res.Kf = kf;
            return kf < 1 && kf >= 0.1;
        }).ToArray();

        double deltaB = 0.01;
        double deltaL = 0.01;

        //Вторая группа
        foreach (var res in secondGroup) {
            double bteh = 0.15;
            double YKFdop = res.admittance - YPS - Yrst - Yrt - YRK;
            double btoch = ( deltaB + deltaL / res.Kf ) / ( YKFdop / 100 );
            double bp = Math.Sqrt(res.power / ( prop.SpecificPowerDissipation * res.Kf ));
            double max = Math.Max(Math.Max(bteh, btoch), bp);
            res.Width = Math.Ceiling(max / prop.Rounding) * prop.Rounding;
            res.Len = res.Width * res.Kf + 0.4;
            res.Square = res.Width * res.Len;

            double p0 = res.power / res.Square;
            double YKF = deltaL / res.Len + deltaB / res.Width;
            double Yr = YPS + YKF + Yrt + YRK + Yrst;
            if (!( p0 <= prop.SpecificPowerDissipation && YKF < YKFdop / 100 && Yr < res.admittance ))
                res.erroneous = true;
        };

        //Третья группа
        foreach (var res in thirdGroup) {
            double YKFdop = res.admittance - YPS - Yrst - Yrt - YRK;
            double lp = Math.Sqrt(( res.power * res.Kf ) / prop.SpecificPowerDissipation);
            double ltoch = ( deltaL + deltaB * res.Kf ) / ( YKFdop / 100 );
            double ltech = 0.3;
            double max = Math.Max(Math.Max(lp, ltoch), ltech);
            double Lras = Math.Ceiling(max / prop.Rounding) * prop.Rounding;
            res.Len = Math.Ceiling(max / prop.Rounding) * prop.Rounding + 0.4;
            res.Width = Lras / res.Kf;
            res.Square = res.Len * res.Width;

            double p0 = res.power / res.Square;
            double YKF = deltaL / res.Len + deltaB / res.Width;
            double Yr = YPS + YKF + Yrt + YRK + Yrst;
            if (!( p0 <= prop.SpecificPowerDissipation && YKF < YKFdop / 100 && Yr < res.admittance ))
                res.erroneous = true;
        }

        SwapWindow(this, new OutputForm(entryForm, resistors, prop));
    }

    private void Enter_KeyDown(object sender, KeyEventArgs e) {
        if (e.KeyData == Keys.Enter) next_Click(sender, null);
    }
}


