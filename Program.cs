using System;

namespace Tag04_mini
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Deklaration und Initialisierung
            int eingabe, aktGroesste, aktKleinste, zaehler = 6;                      //Integer-Variablen anlegen
            Console.Write($"Bitte gebe die {7 - zaehler}. Zahl ein: ");  //Einladung zur Eingabe
            
                aktKleinste = Convert.ToInt32(Console.ReadLine());          //aktKleinste Variable bekommt einen Wert
            aktGroesste = aktKleinste;
            while (zaehler > 0)                                         //Start der while/kopfgesteuerten Schleife
            {
                Console.Write($"Bitte gebe die {8 - zaehler}. Zahl ein: ");// Einladung zur Eingabe
                eingabe = Convert.ToInt32(Console.ReadLine());          //Eingabevariable bekommt einen Wert

                if (eingabe < aktKleinste)                              //Vergleich der neuen Eingabe mit der aktKleinste
                {
                    aktKleinste = eingabe;                              //aktKleinste wird geändert
                }
                zaehler--;                                              //zaehler = zaehler - 1 (zähler wird dekrementiert)
            }
            Console.Write($"Die kleinste Zahl war {aktKleinste}\nDie größte Zahl war {aktGroesste}");      //Ausgabe der groessten eingegebenen Zahl
            Console.ReadKey();                                          //Warten auf Tastendruck
        }
    }
}

