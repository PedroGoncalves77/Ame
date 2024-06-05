using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ame
{
    internal static class Consulta
    {
        public static bool Consultar(List<String> lista) 
        {
            Func <String, bool> consultaFunc = x => string.IsNullOrEmpty(x);
            return lista.Any(consultaFunc);

        }

        public static string Empty = "-"; 
    }
}
