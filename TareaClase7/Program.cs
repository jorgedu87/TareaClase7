
Console.Clear();

int[] numero = new int[10];
int contador = 0;
int sumatoria = 0;
decimal promedio = 0M;
int mayor = 0;
int menor = 0;

for (int i = 0; i < 10; i++)
{
    contador++;
    Console.WriteLine($"Ingrese el numero {contador}");
    numero[i] = int.Parse(Console.ReadLine());
    sumatoria = sumatoria + numero[i];
}

menor = numero[0];
for (int i = 0; i < 10; i++)
{
    if (numero[i] > mayor)
    { mayor = numero[i]; }
    if (numero[i] < menor)
    { menor = numero[i]; }
    Console.WriteLine($"Los numeros ingresados fueron:  { numero[i]}");
}

Console.WriteLine($"La sumatoria de los numeros ingresados es igual a  { sumatoria}");
promedio = sumatoria / 10;
Console.WriteLine($"El promedio de los numeros ingresados es igual a  { promedio}");
Console.WriteLine($"El numero mayor ingresado es igual a  { mayor}");
Console.WriteLine($"El numero menor ingresado es igual a  { menor}");




