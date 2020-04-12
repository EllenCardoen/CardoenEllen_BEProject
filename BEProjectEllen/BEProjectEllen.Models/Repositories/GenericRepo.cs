using BEProjectEllen.Core.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BEProjectEllen.Core.Repositories
{
    public class GenericRepo<TEntity> : IGenericRepo<TEntity> where TEntity : class
    {
        private readonly QuizDBContext _context;

        public GenericRepo(QuizDBContext context)
        {
            this._context = context;
        }

        //interface implementatie:
        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public virtual async Task<IEnumerable<TEntity>> GetByExpressionAsync(Expression<Func<TEntity, bool>> expression)
        {
            //vb. zoekopdracht: expression = "u => u.UserID == id"
            //Je kent de Id property niet
            //returnt collectie
            return await _context.Set<TEntity>().Where(expression).ToListAsync();
        }

        public virtual async Task<TEntity> GetAsync(Guid Id)
        {
            return await _context.Set<TEntity>().FindAsync(Id);
        }

        public virtual async Task<TEntity> GetAsync(int Id)
        {
            return await _context.Set<TEntity>().FindAsync(Id);
        }

        public void Create(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
        }


        public void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
