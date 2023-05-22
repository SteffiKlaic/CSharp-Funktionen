using System.Reflection.Emit;
using System;
using System.Globalization;

namespace Bsp2MethodePreise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Eine Methode schreiben, die die angegebene Werte wie folgt(untereinander) ausgibt:
            // Produktname: USB - C Kabel
            // Anzahl: 16

            // Einzelpreis: 12.90
            // Bitte passende Datentypen auswählen.




            // Hinweis: Formatierungsoption $"{0:F2}" gerundet auf zwei Dezimalstellen.

            string produkt = "USB - C Kabel";
            int anzahl = 16;
            double preis = 12.90;

            PreisAusgeben(produkt, anzahl, preis);
        }

        public static void PreisAusgeben(string produkt, int anzahl, double preis)
        {
            Console.WriteLine("Produktname: " + produkt);
            Console.WriteLine("Anzahl: " + anzahl);
            Console.WriteLine("Einzelpreis: " + "{0:F2}", preis);
        }
    }
}