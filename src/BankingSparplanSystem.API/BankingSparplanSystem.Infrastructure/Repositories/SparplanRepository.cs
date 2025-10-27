using BankingSparplanSystem.Domain.Entitaeten;
using BankingSparplanSystem.Domain.Schnittstellen;
using BankingSparplanSystem.Infrastructure.Persistence;

namespace BankingSparplanSystem.Infrastructure.Repositories
{
    public class SparplanRepository : ISparplanRepository
    {
        private readonly SparplanDbContext _context;

        public SparplanRepository(SparplanDbContext context)
        {
            _context = context;
        }
        public void Save(Sparplan sparplan)
        {
            _context.Sparplaene.Add(sparplan);
            _context.SaveChanges();
        }

        public Sparplan? GetById(int id)
        {
            return _context.Sparplaene.Find(id);
        }
    }
}
