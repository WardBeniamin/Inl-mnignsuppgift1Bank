using ConsoleApp1.Classes.Huvudclass;

namespace ConsoleApp1.Classes.Subclasses.Användareclass
{
    public class Användare
    {
        public string Name { get; set; }

        public Personkonto Personkonto { get; set; }

        public SparKonto SparKonto { get; set; }

        public InvesteringsKonto InvesteringsKonto { get; set;}

        public Användare(string name) 
        {
            Name = name;
            Personkonto = new Personkonto(name, 1111, 5000);
            SparKonto = new SparKonto(name, 2222, 6000);
            InvesteringsKonto = new InvesteringsKonto(name, 3333, 7000);
        }

        public void ÖverföraPengar(int BeloppÖverföra)
        {
            Console.WriteLine("Från vilket konto vill du skicka pengar?");
            BankKonto valKontoFrån = väljBankkonto();
            valKontoFrån.TaUtPengar(BeloppÖverföra);

            
            Console.WriteLine("Till vilket konto vill du skicka pengar?");
            BankKonto valKontoTill = väljBankkonto();
            valKontoTill.SättaInPengar(BeloppÖverföra);
            


        }

        public BankKonto väljBankkonto ()
        {
            Console.WriteLine("Välj gärna ett konto");
            Console.WriteLine("1- Personkoknto, 2- Sparkonto, 3- Investeringskonto");
            string kontoValet = Console.ReadLine();

            switch (kontoValet) 
            {
                case "1":
                    return Personkonto;
                case "2":
                    return SparKonto;
                case "3":
                    return InvesteringsKonto;
                    default:
                    Console.WriteLine("Fel inmatning!");
                    return null;
            }
        }


    }
}
