using System;
using health_calc_pack_dotnet.Interfaces;
using health_calc_pack_dotnet.Models;

namespace health_calc_pack_dotnet.MacroNutrientesStrategies
{
	public class GanharMassaMuscularStrategy : 
        IMacroNutrientesStrategy
    {

        public MacroNutrientesModel CalcularMacroNutrientes(double peso)
        {
            return new MacroNutrientesModel(carboidratos: 4.0 * peso, proteinas: 2.0 * peso, gorduras: 1.0 * peso);
        }
    }
}

