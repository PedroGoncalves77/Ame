
namespace Ame.BD
{
    internal class DAL<T> where T : class
    {
        private readonly BD_Context context;
        public DAL(BD_Context context)
        {
            this.context = context;
        }
        public IEnumerable<T> Listar()
        {
            return context.Set<T>().ToList();
        }
        public void Adicionar(T item)
        {
            context.Set<T>().Add(item);
            context.SaveChanges();
        }
        public void Alterar(T item)
        {
            context.Set<T>().Update(item);
            context.SaveChanges();
        }
        public void Deletar(T item)
        {
            context.Set<T>().Remove(item);
            context.SaveChanges();
        }
        public T? Retornar(Func<T, bool> func)
        {
            return context.Set<T>().FirstOrDefault(func);
        }
    }
        
}
