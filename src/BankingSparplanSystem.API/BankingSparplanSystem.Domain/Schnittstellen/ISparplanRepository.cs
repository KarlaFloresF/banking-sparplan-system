using BankingSparplanSystem.Domain.Entitaeten;

namespace BankingSparplanSystem.Domain.Schnittstellen
{
    public interface ISparplanRepository
    {
        void Save(Sparplan sparplan);
    }
}
