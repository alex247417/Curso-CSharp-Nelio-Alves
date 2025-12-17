using Exercício_de_fixação_listas;
class Program
{
    static void Main(string[] args)
    {
        // criando lista:
        List<Employeer> lista = new List<Employeer>();
        
        // ler os dados do funcionarios 
        Console.Write("Digite Quantidade de funcionarios: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Id:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Salario:");
            decimal salary = decimal.Parse(Console.ReadLine());
            Employeer funcionario = new Employeer(id, nome, salary);
            lista.Add(funcionario);
        }
        foreach (var VARIABLE in lista)
        {
            Console.WriteLine($"Employee#{lista}:");
            Console.WriteLine(VARIABLE);
        }
        Console.WriteLine("Enter the employee Id that will have salary increase : ");
        int searchId = int.Parse(Console.ReadLine());
        Employeer emp = lista.Find(x => x.Id == searchId);
        if (emp != null)
        {
            Console.WriteLine("Enter the percentage:");
            int percentage = int.Parse(Console.ReadLine());
            emp.Increase(percentage);
        }
        else
        {
            Console.WriteLine("Employee ID not found");
        }
        Console.WriteLine("\n Updated List of employees:");
        foreach (Employeer e in lista)
        {
            Console.WriteLine(e);
        }
        
        Console.ReadKey();

    }
}