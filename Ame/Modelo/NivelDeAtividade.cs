

namespace Ame.Modelo
{
    public class NivelDeAtividade
    {
        public virtual FichaBebeTresMeses? FichaBebeTresMeses { get; set; }

        public int Id { get; set; }
        public string? Pergunta14 { get; set; }
        public string? Pergunta15 { get; set; }
        public string? Pergunta16 { get; set; }
        public string? Pergunta17 { get; set; }
        public string? Pergunta18 { get; set; }
        public string? Pergunta19 { get; set; }

        public string? Pergunta20 { get; set; }
        public string? Pergunta21 { get; set; }


        public List<String> Listar()
        {
            var lista = new List<String>() { Pergunta14, Pergunta15, Pergunta16, Pergunta17, Pergunta18 , Pergunta19, Pergunta20, Pergunta21 };
            return lista;

        }
    }
}
