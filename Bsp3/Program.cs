namespace Bsp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produkt p1 = new Produkt() { ProduktNr = 1, Name = "Smart-Tv Samsung QLED 55", Preis = 999.99 };
            Produkt p2 = new Produkt() { ProduktNr = 2, Name = "Apple iPhone 13 Pro Max 128GB ", Preis = 1199.00 };
            Produkt p3 = new Produkt() { ProduktNr = 3, Name = "Bose Noise Cancelling Headphones 700 ", Preis = 379.95 };
           

            List<Produkt> produkte =  new List<Produkt>(){ p1, p2, p3};

            Ausgeben(produkte);
        }

        public static void Ausgeben(List<Produkt> produkte)
        {
            for(int i = 0; i < produkte.Count; i++) 
            { 
                Produkt aktuell = produkte[i];
                if(aktuell.Preis<500)
                {
                    Console.WriteLine($"{aktuell.ProduktNr} {aktuell.Name} {aktuell.Preis}");
                }
            }
        }
    }
}