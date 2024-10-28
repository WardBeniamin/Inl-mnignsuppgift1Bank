using ConsoleApp1.Classes.Huvudclass;
using ConsoleApp1.Classes.Subclasses.Användareclass;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Användare Mario = new Användare("Mario");

            bool programmetIsRunning = true;
            while (programmetIsRunning)
            {
                SkrivUtMeny();
                Console.WriteLine("Välj gärna ett val");
                string AnvändareVal = Console.ReadLine();

                switch (AnvändareVal)
                {
                    case "1":

                        int summanÖverföring = PengarUttag();

                        Mario.ÖverföraPengar(summanÖverföring);

                        break;

                    case "2":
                        BankKonto väljBankkonto = Mario.väljBankkonto();
                        KontoValetStegTvå();
                        string kontoFörstaVal = Console.ReadLine();

                        switch (kontoFörstaVal)
                        {
                            case "1":
                                väljBankkonto.CheckaSaldo();
                                break;
                            case "2":
                                int summanÖverföringTaut = PengarUttag();

                                väljBankkonto.TaUtPengar(summanÖverföringTaut);
                                break;
                                case "3":

                        
                    case "3":
                        programmetIsRunning = false;
                        break;
                        default:
                        Console.WriteLine("Fel inmatning!");
                        break;
                }


            }

        }

        private static void KontoValetStegTvå()
        {
            Console.WriteLine("Välj gärna ett alterantiv");
            Console.WriteLine("1- Se Saldot");
            Console.WriteLine("2- Ta ut Pengar");
            Console.WriteLine("3- Sätta in pengar");
        }

        private static void SkrivUtMeny()
        {
            Console.WriteLine("Välkommen till BETA MarioBanken");
            Console.WriteLine("1- Överföra pengar");
            Console.WriteLine("2- Välj gärna ett konto");
            Console.WriteLine("3- Stäng av appen");
        }
    }

        private static int PengarUttag()
        {
            Console.WriteLine("Hur mycket vill du överföra?");
            int summanÖverföring = Convert.ToInt32(Console.ReadLine());
            return summanÖverföring;
        }
    }
