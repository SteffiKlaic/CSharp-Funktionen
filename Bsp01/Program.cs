using System.Threading.Channels;

namespace Bsp01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Gegeben sind folgende OrtsNamen:
            //    "Marburg an der Lahn",
            //    "Weimar",
            //    "Markt Taschendorf",
            //    "Ulm",
            //    "Baden-Baden",
            //    "Freiburg im Breisgau",
            //    "Kirchheim unter Teck",
            //    "Görlitz"
            // Eine Methode schreiben, die alle OrtsNamen übernimmt und
            //  nur die Ortsnamen ausgeben, die Länger als 6 Zeichen sind.  

            string[] orte = {"Marburg an der Lahn", "Weimar", "Markt Taschendorf", "Ulm", "Baden-Baden", "Freiburg im Breisgau", "Kirchheim unter Teck", "Görlitz"};
            Ausgeben(orte);
        }

        public static void Ausgeben(string[] orte) 
        {
            for (int i = 0; i < orte.Length; i++)
            {
                string aktuell = orte[i];
                if (aktuell.Length > 6)
                {
                    Console.WriteLine(aktuell);
                }

                //if (orte[i].Length > 0)

                // 2. Variante
                //foreach (string aktuell in orte)
                //{
                //    if(aktuell.Length > 6 )
                //    {
                //        Console.WriteLine(aktuell);
                //    }
                //}
            }

        }
    }
}