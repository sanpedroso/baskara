double a, b, c, delta, x1, x2;
Console.WriteLine("Equação de segundo grau");

Console.Write("(a): ");

a = Convert.ToDouble(Console.ReadLine());
 
Console.Write("(b): ");

b = Convert.ToDouble(Console.ReadLine());

Console.Write("(c): ");

c = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();    

if (a == 0 )    
{
    Console.WriteLine("Não é equação de segundo grau!");
}  
else
{
    delta = b * b - 4 * a * c;
    if (delta < 0)
    {
        Console.WriteLine($"Como delta =  {delta:n2}, a equaçao não possui raízes reais!");
    }
    else
    {
        x1 = (-b + Math.Sqrt(delta)) / (2 * a); 
        x2 = (-b - Math.Sqrt(delta)) / (2 * a);

    Console.WriteLine($"x1 = {x1:n2} e x2 = {x2:n2}");
    }

}