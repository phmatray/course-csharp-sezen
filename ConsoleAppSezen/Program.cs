using System;

namespace ConsoleAppSezen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            // Appel de la première fonction
            GenerateRandomNumbers();
            
            // Appel de la seconde fonction et affichage du résultat
            var (binary, hex) = GetBinaryAndHexadecimalNumber(42);
            Console.WriteLine($"Binary number: {binary}, Hexadecimal number: {hex}");
            
            // Appel de la troisième fonction
            WriteUsernameLength();
        }

        /// <summary>
        /// Remplit un tableau dynamique de 1500 nombres entiers "pseudo-aléatoire"
        /// et affiche les indices pairs.
        /// </summary>
        /// <param name="maxValue">La valeur maximale d'un nombre géréré. Par défaut 100</param>
        private static void GenerateRandomNumbers(int maxValue = 100)
        {
            // Déclare une constante contenant la taille du tableau
            const int arraySize = 1500; 
            
            // Déclare et initialise le générateur de nombre aléatoires
            var rng = new Random();
            // Déclare et initialise un tableau d'entier dynamique
            var array = new int[arraySize];
            
            // Crée une boucle qui sera itérée 1500 fois
            for (int i = 0; i < arraySize; i++)
                // Appelle le générateur de nombre aléatoire et affecte la valeur de retour
                // à la cellule du tableau.
                array[i] = rng.Next(maxValue);

            // Crée une seconde boucle qui sera itérée 1500 fois
            for (int i = 0; i < arraySize; i++)
                // Si le reste d'une division entière par 2 est égale à 0...
                if (i % 2 == 0)
                    // On affiche dans la console l
                    Console.WriteLine($"Index: {i}, Number: {array[i]}");
        }

        /// <summary>
        /// Retourne la valeur binaire et héxadécimale d'un nombre
        /// </summary>
        /// <param name="number">Le nombre à convertir</param>
        /// <returns>Un Tuple contenant les représentation binaire et héxadécimale</returns>
        private static Tuple<string, string> GetBinaryAndHexadecimalNumber(int number)
        {
            // Représentation binaire d'un nombre à l'aide de la méthode ToString
            var binaryString = Convert.ToString(number, 2);
            // Représentation hexadécimale d'un nombre à l'aide de la méthode ToString
            var hexString = Convert.ToString(number, 16);
            
            // Retourne un Tuple contenant ces 2 valeurs
            // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-tuples
            return new Tuple<string, string>(binaryString, hexString);
        }

        /// <summary>
        /// Demande l'introduction du nom de l'utilisateur et affiche la longueur totale du nom
        /// sans compter les espaces et les traits d'union.
        /// </summary>
        private static void WriteUsernameLength()
        {
            // Déclare une chaine de caractère qui contiendra le nom de l'utilisateur
            string username;
            // Utilise une boucle qui va s'exécuter tant que le nom entré est null ou complétement blanc
            do
            {
                // Lit le résultat de la ligne entrée par l'utilisateur dans la console
                username = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(username));

            // Efface les espaces en début et en fin de notre chaine de caractère 
            username = username.Trim();
            // Efface les espaces
            username = username.Replace(" ", "");
            // Efface les traits d'union
            username = username.Replace("-", "");

            // Obtient la longueur de la chaine de caractère transformée
            int lenght = username.Length;
            // Affiche la longueur de cette chaine dans la console.
            Console.WriteLine($"Username length: {lenght}");
        }
    }
}