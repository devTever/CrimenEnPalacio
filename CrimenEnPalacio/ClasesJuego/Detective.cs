namespace CrimenEnPalacio
{
    // Clase Detective
    class Detective
    {
        public List<string> Libreta { get; set; } = new List<string>();

        public void Apuntar(string pista)
        {
            Libreta.Add(pista);
            Console.WriteLine($"Pista anotada: {pista}");
        }

        public void MostrarLibreta()
        {
            Console.WriteLine("\nLibreta del detective:");
            if (Libreta.Count == 0)
            {
                Console.WriteLine("(La libreta está vacía)");
            }
            else
            {
                foreach (var pista in Libreta)
                {
                    Console.WriteLine("- " + pista);
                }
            }
            Console.WriteLine();
        }
    }
}
