namespace Raschet;
public class Resistor {
    public double nominal { get; set; }     //R сопротиление
    public double power { get; set; }
    public double admittance { get; set; }
    public double Kf { get; set; }
    public double Square { get; set; }
    public double Width { get; set; }
    public double Len { get; set; }
    public bool erroneous { get; set; } = false;
}

