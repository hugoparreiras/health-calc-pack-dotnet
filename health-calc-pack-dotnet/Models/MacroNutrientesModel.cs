namespace health_calc_pack_dotnet.Models;

public class MacroNutrientesModel
{
    private int CASAS_DECIMAIS = 1;

    public double Carboidratos { get => Math.Round(_carboidratos, CASAS_DECIMAIS); }
    private double _carboidratos { get; set; }

    public double Proteinas { get => Math.Round(_proteinas, CASAS_DECIMAIS); }
    private double _proteinas { get; set; }

    public double Gorduras { get => Math.Round(_gorduras, CASAS_DECIMAIS); }
    private double _gorduras { get; set; }

    public MacroNutrientesModel(double carboidratos, double proteinas, double gorduras)
    {
        _carboidratos = carboidratos;
        _proteinas = proteinas;
        _gorduras = gorduras;
    }
}