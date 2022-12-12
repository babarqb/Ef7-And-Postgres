using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using MM.DataAccess.Context;
using MM.Domain.Repositories;

namespace MM.DataAccess.Implementation;

public class GenericRepository<T>: IGenericRepository<T> where T:class
{
    private readonly MovieManagementDbContext _context;

    public GenericRepository(MovieManagementDbContext context)
    {
        _context = context;
    }
    public T GetById(int id)
    {
        return _context.Set<T>().Find(id) ?? throw new InvalidOperationException(); 
    }

    public IEnumerable<T> GetAll()
    {
        return _context.Set<T>().ToList();
    }

    public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
    {
        return _context.Set<T>().Where(predicate);
    }

    public void Add(T entity)
    {
        _context.Set<T>().Add(entity);
    }

    public void AddRange(IEnumerable<T> entities)
    {
        _context.Set<T>().AddRange(entities);
    }

    public void Remove(T entity)
    {
        _context.Set<T>().Remove(entity);
    }

    public void RemoveRange(IEnumerable<T> entities)
    {
        _context.Set<T>().RemoveRange(entities);
    }
}