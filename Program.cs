Pessoa a, b;
a = new Pessoa();
b = new Pessoa();
a.dias = int.Parse(Console.ReadLine());
a.salario = int.Parse(Console.ReadLine());

b.dias = int.Parse(Console.ReadLine());
b.salario = int.Parse(Console.ReadLine());

double aremu = a.Remu();
double bremu = b.Remu();

if (aremu > bremu)
{
    Console.WriteLine("Salário " + aremu+" maior");
}
else { Console.WriteLine("Salário " + bremu + " maior"); }