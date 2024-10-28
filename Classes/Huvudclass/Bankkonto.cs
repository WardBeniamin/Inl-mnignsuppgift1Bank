namespace ConsoleApp1.Classes.Huvudclass
{
    public class BankKonto
    {
        public string KontoNamn { get; set; }

        public int KontoNummer { get; set; }

        public double Saldo { get; set; }

        public BankKonto(string kontonamn, int kontonummer, double saldo) 
        {
            KontoNamn = kontonamn;
            KontoNummer = kontonummer;
            Saldo = saldo;
        }

        public void SättaInPengar(int BeloppInsätting)
        {
            Saldo = Saldo + BeloppInsätting;
            Console.WriteLine($"Din saldo är {Saldo}");
        }
        public void TaUtPengar(int BeloppUttag)
        {
            Saldo = Saldo - BeloppUttag;
            Console.WriteLine($"Din saldo är {Saldo}");
        }
        public void CheckaSaldo()
        {
            Console.WriteLine($"Din saldo är {Saldo}");
        }
    }
}
