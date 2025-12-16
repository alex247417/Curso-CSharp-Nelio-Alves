using Exercício_de_fixação_Vetores;

class Program
{
    static void Main(string[] args)
    {
        BedRooms[] rent = new BedRooms[10];
        
        Console.Write("Quantos quartos serão alugados? ");
        int Number = int.Parse(Console.ReadLine());
       
        for (int i = 0; i < Number; i++)
        {
            Console.WriteLine();
            Console.WriteLine($"Aluguel #{i}:");
            Console.WriteLine("Qual Nome  do aluno?");
            string name = Console.ReadLine();
            Console.WriteLine("Qual Email  do aluno?");
            string email = Console.ReadLine();
            Console.WriteLine("Qual Quarto Deseja alugar:");
            int room = int.Parse(Console.ReadLine());
            rent[room] = new BedRooms(name, email);
            
        }

        Console.WriteLine("Busy rooms:");

        for (int i = 0; i < 10; i++)
        {
            if (rent[i] != null)
            {
                Console.WriteLine(i + ": " + rent[i]);
            }
        }
    }
}