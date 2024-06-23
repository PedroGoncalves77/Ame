
namespace Ame.Modelo
{
    public class AlimentacaoCrianca
    {
        public virtual FichaBebeTresMeses? FichaBebeTresMeses { get; set; }

        public int Id { get; set; }
        public string? Pergunta22 { get; set; }
        public string? Pergunta23 { get; set; }
        public string? Pergunta24 { get; set; }
        public string? Pergunta25 { get; set; }
        public string? Pergunta26 { get; set; }
        public string? Pergunta27 { get; set; }

        public string? Pergunta28 { get; set; }
        public string? Pergunta29 { get; set; }
        public string? Pergunta30 { get; set; }


        public List<String> Listar()
        {
            var lista = new List<String>() { Pergunta22, Pergunta23, Pergunta24, Pergunta25, Pergunta26, Pergunta27, Pergunta28, Pergunta29, Pergunta30 };
            return lista;

        }
    }
}
