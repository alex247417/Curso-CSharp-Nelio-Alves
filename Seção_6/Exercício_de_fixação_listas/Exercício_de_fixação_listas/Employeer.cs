namespace Exercício_de_fixação_listas;

public class Employeer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Salary { get;  private set; }
    
    public Employeer(int id, string name, decimal salary)
    {
        Id = id;
        Name = name;
        Salary = salary;
    }

    public void Increase(int percentage)
    {
        Salary += Salary * percentage / 100m;
    }

    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, Salary: {Salary.ToString("F2")}";
    }
}