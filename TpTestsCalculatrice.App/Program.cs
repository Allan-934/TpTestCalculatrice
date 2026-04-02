namespace TpTestsCalculatrice.App;

class Program
{
    static void Main(string[] args)
    {
        Calculatrice calc = new Calculatrice();

        Console.WriteLine(calc.Addition(2, 3));
        Console.WriteLine(calc.Division(10, 2));

        //Pourquoi ce test manuel n'est-il pas suffisant ?

        // Ce test manuel n'est pas suffisant pour plusieurs raisons :
        // 1. Absence d'automatisation : Il oblige un humain à vérifier visuellement le résultat dans la console à chaque modification du code, ce qui est source d'erreurs.
        // 2. Non-régression : Il ne garantit pas que les futurs changements ne casseront pas ces fonctionnalités, car personne ne relancera manuellement tous les scénarios à chaque fois.
        // 3. Couverture limitée : Il ne teste que des cas simples (nominaux) et ignore les cas critiques, comme la division par zéro ou les nombres très grands.
        // 4. Manque de preuve : Le test ne génère aucun rapport formel de succès ou d'échec exploitable par une équipe de développement ou un outil d'intégration continue.
        //  

    }
}
