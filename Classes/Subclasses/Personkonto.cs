using ConsoleApp1.Classes.Huvudclass;

namespace ConsoleApp1.Classes.Subclasses
{
    public class Personkonto : BankKonto
    {
        public Personkonto(string kontonamn, int kontonummer, double saldo) : base(kontonamn, kontonummer, saldo)
        {
        }
    }
}    



