using ConsoleApp1.Classes.Huvudclass;

namespace ConsoleApp1.Classes.Subclasses
{
    public class SparKonto : BankKonto
    {
        public SparKonto(string kontonamn, int kontonummer, double saldo) : base(kontonamn, kontonummer, saldo)
        {
        }
    }
}
