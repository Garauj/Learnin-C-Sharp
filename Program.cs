
using System.Globalization;
Retangulo x, y;
x = new Retangulo();
y = new Retangulo();

Console.WriteLine("Entre com as medidas do retângulo X:");
x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Entre com as medidas do retângulo Y:");
y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);



double areaX = x.A * x.B;


double areaY = y.A*y.B;

Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

if (areaX > areaY)
{
    Console.WriteLine("Maior área: X");
}
else
{
    Console.WriteLine("Maior área: Y");
}
