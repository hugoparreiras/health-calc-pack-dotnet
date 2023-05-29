using System;
using health_calc_pack_dotnet.Enums;
using health_calc_pack_dotnet.Interfaces;
using health_calc_pack_dotnet.Models;

namespace health_calc_pack_dotnet;

public class MacroNutrientesConext
{
    private IMacroNutrientesStrategy? strategy { get; set; }

    public void SetStrategy(IMacroNutrientesStrategy macroNutrientesStrategy)
    {
        strategy = macroNutrientesStrategy;
    }

    public MacroNutrientesModel? ExecuteStratery(double peso)
    {
        return strategy?.CalcularMacroNutrientes(peso) ?? null;
    }
}

