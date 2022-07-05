using BookManagementSystem.Data;
using BookManagementSystem.Models;
namespace BookManagementSystem.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly ApplicationDbContext context;
        public GenericRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public void Add(T entity)
        {
            context.Set<T>().Add(entity);

        }


        public IEnumerable<T> GetAll()
        {
            return context.Set<T>().ToList();

        }
        public T GetById(int id)
        {
            return context.Set<T>().Find(id);
        }
        public void Remove(int id)
        {
            var data = this.GetById(id);
            context.Set<T>().Remove(data);
        }
    }
}
