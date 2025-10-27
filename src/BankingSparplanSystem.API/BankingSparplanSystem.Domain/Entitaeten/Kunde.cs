namespace BankingSparplanSystem.Domain.Entitaeten
{
    public class Kunde
    {
        public int KundeId { get; set; }

        public string Vorname { get; set; } = string.Empty;

        public string Nachname { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Telefonnummer { get; set; } = string.Empty;

        public string IBAN { get; set; } = string.Empty;

        public ICollection<Sparplan>? Sparplaene { get; set; }
    }
}
