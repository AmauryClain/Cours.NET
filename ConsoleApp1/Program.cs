using System;
class User
{
    public int Id;
    public string FirstName;
    public string LastName;
    public int Old;
    public int Salary;
    public int Tax;
} 
class Program
{

    static void Main(string[] args)
    {
        int ann;
        int taux;
        double december = 0; // Initialisation de la prime de décembre
        string[] mois = new string[12];
        mois[0] = "Janvier";
        mois[1] = "Février";
        mois[2] = "Mars";
        mois[3] = "Avril";
        mois[4] = "Mai";
        mois[5] = "Juin";
        mois[6] = "Juillet";
        mois[7] = "Août";
        mois[8] = "Septembre";
        mois[9] = "Octobre";
        mois[10] = "Novembre";
        mois[11] = "Décembre";

        User user1 = new User();
        user1.Id = 1;
        user1.FirstName = "John";
        user1.LastName = "Doe";
        user1.Old = 30;
        user1.Salary = 50000;
        user1.Tax = 20;



        Console.WriteLine("Entrez votre salaire brut annuel : ");
        if (int.TryParse(Console.ReadLine(), out ann))
        {
            if (ann > 50000)
            {
                Console.WriteLine("Fais des dons");
            }
            else if (ann >= 30000 && ann <= 40000)
            {
                Console.WriteLine("Viens à CESI");
            }
        }
        else
        {
            Console.WriteLine("Entrez autre chose");
            return; // Sortir du programme en cas de saisie invalide
        }

        Console.WriteLine("Entrez le taux d'imposition : ");
        if (int.TryParse(Console.ReadLine(), out taux))
        {
            double net;
            // Calcul du salaire annuel net
            double salaireAnnuelNet = ann - (ann * taux / 100);
            // Calcul du salaire mensuel net
            net = salaireAnnuelNet / 12;
            december = ann * 0.10; // Calcul de la prime de décembre
            if (net < 1500)
            {
                Console.WriteLine("C'est normal pour un alternant");
            }
            for (int i = 0; i < 12; i++)
            {
                if (i == 11)
                {
                    Console.WriteLine("Salaire du mois de " + mois[i] + ": " + (net + december));
                }
                else if (i != 7)
                {
                    Console.WriteLine("Salaire du mois de " + mois[i] + ": " + net);
                }
            }
        }
        else
        {
            Console.WriteLine("Entrez un taux d'imposition valide.");
        }
    }
}
