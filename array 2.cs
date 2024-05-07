// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string[] estudiantes = new string[] { "Vale", "Ivan", "Marcos" };
string[] materias = new string[] { "CALCULO", "ALGEBRA", "POTENCIA" };
decimal[,] notas = new decimal[estudiantes.Length, materias.Length];
decimal[,] promedio= new decimal[estudiantes.Length, materias.Length];
for (int i = 0; i < estudiantes.Length; i++)
{
    Console.WriteLine($"{estudiantes[i]} ingrese sus notas");
    for (int l = 0; l < materias.Length; l++)
    {
        Console.WriteLine($"Por favor ingrese las 3 notas que usted obtuvo en  {materias[l]}");
        int sum = 0;
        for (int ñ = 0; ñ < 3; ñ++)
        {
            notas[i, l] += Convert.ToDecimal(Console.ReadLine());
        }
        promedio[i, l] = (decimal)notas[i, l] / 3;
    }
}
for (int i = 0; i < estudiantes.Length; i++)
{
    Console.WriteLine($"Promedio de notas para {estudiantes[i]}:");
    for (int l = 0; l < materias.Length; l++)
    {
        Console.WriteLine($"Promedio en {materias[l]}: {promedio[i, l]}");
    }
    Console.WriteLine();
}
