using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ame.Modelo
{
    public class FichaBebeTresMeses
    {
        public FichaBebeTresMeses(string nome_Mae, 
            string profissao_Mae, string nome_Pai, string profissao_Pai, 
            string endereco, string nome_Crianca, double idade_Crianca,string nome_Pediatra)
        {
            
            Nome_Mae = nome_Mae;
            Profissao_Mae = profissao_Mae;
            Nome_Pai = nome_Pai;
            Profissao_Pai = profissao_Pai;
            Endereco = endereco;
            Nome_Crianca = nome_Crianca;
            Idade_Crianca = idade_Crianca;
            Nome_Pediatra = nome_Pediatra;
        }
        public virtual ICollection<SaudeDaCrianca> SaudeCrianca { get; set; } = new List<SaudeDaCrianca>();
        public virtual ICollection<NivelDeAtividade> NivelAtividade { get; set; } = new List<NivelDeAtividade>();
        public virtual ICollection<AlimentacaoCrianca> AlimentacaoCrianca { get; set; } = new List<AlimentacaoCrianca>();
        public virtual ICollection<TemperamentoCrianca> TemperamentoCrianca { get; set; } = new List<TemperamentoCrianca>();
        public virtual ICollection<SobrePais> SobrePais { get; set; } = new List<SobrePais>();
        public virtual ICollection<DinamicaFamiliar> DinamicaFamiliar { get; set; } = new List<DinamicaFamiliar>();
        public virtual ICollection<ProblemaSono> ProblemaSono { get; set; } = new List<ProblemaSono>();
        public virtual ICollection<AmbienteSono> AmbienteSono { get; set; } = new List<AmbienteSono>();
        public virtual ICollection<SobreConsultoria> SobreConsultoria { get; set; } = new List<SobreConsultoria>();
        public int Id { get; set; }
        public int Contrato { get; set; }
        public DateTime Data { get; set; }
        public string Nome_Mae { get; set; }
        public string Profissao_Mae { get; set; }
        public string Nome_Pai { get; set; }
        public string Profissao_Pai { get; set; }
        public string Endereco { get; set; }
        public string Nome_Crianca { get; set; }
        public double Idade_Crianca { get; set; }
        public DateTime Data_Nascimento { get; set; }
        public string Nome_Pediatra { get; set; }

        public void AdicionarSaude(SaudeDaCrianca saudeDaCrianca) 
        {
            this.SaudeCrianca.Add(saudeDaCrianca);
        }
        public void AdicionarNivelAtividade(NivelDeAtividade nivelDeAtividade)
        {
            this.NivelAtividade.Add(nivelDeAtividade);
        }
        public void AdicionarAlimentacaoCrianaca(AlimentacaoCrianca alimentacaoCrianca)
        {
            this.AlimentacaoCrianca.Add(alimentacaoCrianca);
        }
        public void AdicionarTemperamentoCrianaca(TemperamentoCrianca temperamentoCrianca)
        {
            this.TemperamentoCrianca.Add(temperamentoCrianca);
        }
        public void AdicionarSobrePais(SobrePais sobre)
        {
            this.SobrePais.Add(sobre);
        }
        public void AdicionarDinamica(DinamicaFamiliar dinamica)
        {
            this.DinamicaFamiliar.Add(dinamica);
        }
        public void AdicionarProblemaSono(ProblemaSono problema)
        {
            this.ProblemaSono.Add(problema);
        }
        public void AdicionarAmbienteSono(AmbienteSono ambiente)
        {
            this.AmbienteSono.Add(ambiente);
        }
        public void AdicionarSobreConsultoria(SobreConsultoria sobre)
        {
            this.SobreConsultoria.Add(sobre);
        }


    }
}
