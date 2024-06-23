

namespace Ame.Modelo
{
    public class TemperamentoCrianca
    {
        public virtual FichaBebeTresMeses? FichaBebeTresMeses { get; set; }

        public int Id { get; set; }
        public string? Pergunta31 { get; set; }
        public string? Pergunta32 { get; set; }
        public string? Pergunta33 { get; set; }

    }
}
