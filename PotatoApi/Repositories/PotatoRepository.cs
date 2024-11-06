using Microsoft.EntityFrameworkCore;
using PotatoApi.Database;
using PotatoApi.Entities;

namespace PotatoApi.Repositories
{
    public interface IPotatoRepository
    {
        List<Potato> GetAll();
        Potato GetById(int id);
    }

    public class PotatoRepository : IPotatoRepository
    {
        private readonly ApplicationDbContext _context;

        public PotatoRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<Potato> GetAll()
        {
            return _context.Potatoes.ToList();

        }
        public Potato GetById(int id)
        {
            return _context.Potatoes.Find(id);
        }
    }
}
