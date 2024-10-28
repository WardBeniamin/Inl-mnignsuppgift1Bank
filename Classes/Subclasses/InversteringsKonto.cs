using ConsoleApp1.Classes.Huvudclass;

namespace ConsoleApp1.Classes.Subclasses
{
    public class InvesteringsKonto : BankKonto
    {
        public InvesteringsKonto(string kontonamn, int kontonummer, double saldo) : base(kontonamn, kontonummer, saldo)
        {
        }
    }
}
