/*ETAPE 2 : 
Ajoutez une boucle pour permettre de continuer le
jeu en cas d’erreur et un tableau pour afficher les choix déjà
faits.
 */
int valATrouver = 5;
int nbTours = 5;
int nbr;
int[] tab= new int[nbTours];
Console.WriteLine("Vous avez "+nbTours+" à jouer");
    for(int essai = 1; essai <= nbTours; essai++)
{
    Console.WriteLine("Essai "+ essai);
    string chaineInt = Console.ReadLine();
    if(int.TryParse(chaineInt,out nbr))
    {
        tab[essai] = nbr;
        Console.WriteLine("les valeurs déja choisis :" + tab[essai]);
        if (nbr < 1 && nbr > 10)
        {
            Console.WriteLine("Entrez un nombre compris entre 1 et 10");
        }else if(nbr < valATrouver)
        {
            Console.WriteLine("Entrez un nombre plus grand");
        }
        else if(nbr > valATrouver)
        {
            Console.WriteLine("Entrez un nombre plus petit");
        }
        else if(nbr == valATrouver)
        {
            Console.WriteLine("Génial, Vous avez gagné");
            break;
        }
    }
    else
    {
        Console.WriteLine("Veuillez entrez un bon nombre");
    }
}