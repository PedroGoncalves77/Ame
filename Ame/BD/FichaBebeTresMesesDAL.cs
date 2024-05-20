using Ame.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ame.BD
{
    internal class FichaBebeTresMesesDAL
    {
        private readonly BD_Context context;
        public FichaBebeTresMesesDAL(BD_Context context)
        {
            this.context = context;
        }
        public IEnumerable<FichaBebeTresMeses> Listar()
        {
            return context.FichaBebeTresMeses.ToList();
        }
        public void Adicionar(FichaBebeTresMeses fichaBebeTresMeses) 
        {
            context.FichaBebeTresMeses.Add(fichaBebeTresMeses);
            context.SaveChanges();
        }
        public void Alterar(FichaBebeTresMeses fichaBebeTresMeses)
        {
            context.FichaBebeTresMeses.Update(fichaBebeTresMeses);
            context.SaveChanges();
        }
        public void Deletar(FichaBebeTresMeses fichaBebeTresMeses)
        {
            context.FichaBebeTresMeses.Remove(fichaBebeTresMeses);
            context.SaveChanges();
        }
    }
}
