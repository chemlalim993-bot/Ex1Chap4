namespace Ex1Chap4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quel est le prix de votre arme ?");
            int prixArme = int.Parse(Console.ReadLine());

            decimal taxeRoyaleStandard = 1.20m;
            decimal taxeMinièreIntermédiaire = 1.10m;
            decimal taxeReduiteImportation = 1.055m;
            decimal taxeArtisanatbeni = 1.021m;



            Console.WriteLine("choisir une option (1,2,3,4)");
            int choix = int.Parse(Console.ReadLine());


            switch (choix)
            {
                case 1:
                    decimal prixFinal1 = prixArme * taxeRoyaleStandard;
                    Console.WriteLine($"Le prix final de votre arme est : {prixFinal1}");
                    break;
                case 2:
                    decimal prixFinal2 = prixArme * taxeMinièreIntermédiaire;
                    Console.WriteLine($"Le prix final de votre arme est : {prixFinal2}");
                    break;
                case 3:
                    decimal prixFinal3 = prixArme * taxeReduiteImportation;
                    Console.WriteLine($"Le prix final de votre arme est : {prixFinal3}");
                    break;
                default:
                    decimal prixFinal4 = prixArme * taxeArtisanatbeni;
                    Console.WriteLine($"Le prix final de votre arme est : {prixFinal4}");
                    break;
            }
        }
    }
}
