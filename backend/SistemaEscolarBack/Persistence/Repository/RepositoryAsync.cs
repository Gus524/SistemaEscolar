using Application.Interfaces;
using Ardalis.Specification.EntityFrameworkCore;
using Persistence.Contexts;

namespace Persistence.Repository;

public class RepositoryAsync<T>(ApplicationDbContext context) : RepositoryBase<T>(context), IRepositoryAsync<T>
    where T : class
{
    private readonly ApplicationDbContext _context = context;
}