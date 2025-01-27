using System.ComponentModel;

namespace Demos
{
    internal class Program
    {
        static void Main(string[] args) { 
       Console.WriteLine("Bienvenue au convertisseur Celsius,Kelvin, Fahrenheit");
            string unite;
        bool uniteOK = false;
            do
            {
                Console.Write("Choisir l'unité de votre température (C, K, F): ");
                unite = Console.ReadLine();
                if (unite != "C" && unite != "K" && unite != "F")
                {
                    Console.WriteLine("Unité invalide");
                }
                else
                {
                    uniteOK = true;
                }
            } while (!uniteOK) ;

//Entrez Temperature
string temperatureString;
bool estDouble;
double temperature;
do
{
    Console.Write("Entrez la température: ");
    temperatureString = Console.ReadLine();
    estDouble = double.TryParse(temperatureString, out temperature);
} while (!estDouble);

TemperatureUtil temperatureUtil = new TemperatureUtil();

switch (unite)
{
    case "C":
        Console.WriteLine("La température en Celsius est " + temperature);
        Console.WriteLine("La température en Fahrenheit est " + temperatureUtil.CelsiusVersFahrenheit(temperature));
        Console.WriteLine("La température en Kelvin est " + temperatureUtil.CelsiusVersKelvin(temperature));
        break;

    case "F":
        Console.WriteLine("La température en Fahrenheit est " + temperature);
        Console.WriteLine("La température en Celsius est " + temperatureUtil.FahrenheitVersCelsius(temperature));
        Console.WriteLine("La température en Kelvin est " + temperatureUtil.FahrenheitVersKelvin(temperature));
        break;
    case "K":
        Console.WriteLine("La température en Kelvin est " + temperature);
        Console.WriteLine("La température en Celsius est " + temperatureUtil.KelvinVersCelsius(temperature));
        Console.WriteLine("La température en Fahrenheit est " + temperatureUtil.KelvinVersFahreinheit(temperature));
        break;
}

        }
    }
}
