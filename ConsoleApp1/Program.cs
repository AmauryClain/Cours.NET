class Program
{
    static void  Square(int a, int b)
    {
        a = a + 1;
        b++;
        Console.WriteLine(a + " " + b);
    }

    static void Main(string[] args)
    {
        int ann;
        int taux;

        Console.WriteLine("Entrez votre salaire brut annuel : ");
        if (int.TryParse(Console.ReadLine(), out ann))  
        {
        } else
        {
            Console.WriteLine("Entrez autre chose");
        };

        Console.WriteLine("Entrez le taux d'imposition : ");
        if  (int.TryParse(Console.ReadLine(), out taux)) {
            double net;
            // Calcul du salaire annuel net
            double salaireAnnuelNet = ann - (ann * taux / 100);
            // Calcul du salaire mensuel net
            net = salaireAnnuelNet / 12;

            Console.WriteLine("Salaire Mensuel net : " + net);
        } else
        {
            Console.WriteLine("Entrez autre chose");
        }



    }
}