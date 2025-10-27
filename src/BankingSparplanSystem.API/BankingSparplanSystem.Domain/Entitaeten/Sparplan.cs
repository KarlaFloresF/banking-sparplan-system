using BankingSparplanSystem.Domain.Konstanten;

namespace BankingSparplanSystem.Domain.Entitaeten
{
    public class Sparplan
    {
        public int SparplanId { get; set; }

        public string Name { get; set; } = string.Empty;
        public SparplanTyp Typ { get; set; }
        public decimal Zielbetrag { get; set; } // Meta de ahorro
        public int KundeId { get; set; }

        public Kunde Kunde { get; set; } = new Kunde();

        public int MonatlicheZahlung { get; set; } 

        public DateTime Vertragsdatum { get; set; }

        public DateTime Stornierungsdatum { get; set; }

        public bool IstAktiviert { get; set; }

        public decimal BarrenMenge { get; set; }

        public decimal GewünschteSpargrenze { get; set; }
    }
}
