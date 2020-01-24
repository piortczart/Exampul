using System.Threading.Tasks;
using ConsoleApp5.Oink;
using ConsoleApp5.Quenk;
using ConsoleApp5.Uiuaa;

namespace ConsoleApp5
{
    class Program
    {
        // Jak przeprocesowac plik tekstowy 1 GB linijka po linijce agregując kilku-linijkowe
        // logi w obiekty i wysyłając je w grupach do bazy?
        static async Task Main(string[] args)
        {
            new Abc().Process();
            new Bbc().Process();
            await new Cbc().Process();
        }
    }
}