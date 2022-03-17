Pessoa a, b;
a = new Pessoa();
b = new Pessoa();      
a.Name = Console.ReadLine();
a.salario = int.Parse(Console.ReadLine());

b.Name = Console.ReadLine();
b.salario = int.Parse(Console.ReadLine());

if (a.salario > b.salario)
{
    Console.WriteLine("Salário " + a.Name+" maior");
}
else { Console.WriteLine("Salário " + b.Name + " maior"); }