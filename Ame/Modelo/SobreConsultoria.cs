using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ame.Modelo
{
    public class SobreConsultoria
    {
        public virtual FichaBebeTresMeses? FichaBebeTresMeses { get; set; }
        public int Id { get; set; }
        public string? Pergunta90 { get; set; }
        public string? Pergunta91 { get; set; }
        public string? Pergunta92 { get; set; }
    }
}
