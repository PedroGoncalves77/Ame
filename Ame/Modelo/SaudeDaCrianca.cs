using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ame.Modelo
{
    public class SaudeDaCrianca
    {
        public virtual FichaBebeTresMeses? FichaBebeTresMeses { get; set; }
        
        public int Id { get; set; }
        public DateTime? Pergunta1 { get; set; }
        public string? Pergunta2 { get; set; }
        public string? Pergunta3 { get;  set; }  
        public string? Pergunta4 { get; set; }
        public string? Pergunta5 { get; set; }
        public string? Pergunta6 { get;  set; }
        public string? Pergunta7 { get; set; }
        public string? Pergunta8 { get; set; }
        public string? Pergunta9 { get; set; }
        public string? Pergunta10 { get; set; }
        public string? Pergunta11 { get; set; }
        public string? Pergunta12 { get; set; }
        public string? Pergunta13 { get; set; }

        public List<String> Listar()
        {
            var lista = new List<String>() { Pergunta1.ToString(), Pergunta2, Pergunta3, Pergunta4, Pergunta5, Pergunta6, Pergunta7, Pergunta8,
            Pergunta9,Pergunta10, Pergunta11, Pergunta12, Pergunta13};
            return lista;

        }
    }
}
