using System;
using health_calc_pack_dotnet.Enums;
using health_calc_pack_dotnet.Interfaces;
using health_calc_pack_dotnet.Models;

namespace health_calc_pack_dotnet.MacroNutrientesStrategies;

public class PerderPesoStrategy : IMacroNutrientesStrategy
{
    public MacroNutrientesModel CalcularMacroNutrientes(double peso)
    {
        return new MacroNutrientesModel(carboidratos: 3.0 * peso, proteinas: 4.0 * peso, gorduras: 3.0 * peso);
    }
}

