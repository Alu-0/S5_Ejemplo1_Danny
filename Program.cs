//Función de Imprimir notas
static void ImprimirNotas(int[] notas)
{
    for (int i = 0; i < notas.Length; i++)
    {
        Console.WriteLine(notas[i]);
    }
}

//Función para calcular el promedio
static double CalcularPromedio(int[] notas)
{
    int suma = 0;

    for (int i = 0; i < notas.Length; i++)
    {
        suma += notas[i];
    }

    double promedio = (double)suma / notas.Length;

    return promedio;
}

int[] notas = { 15, 18, 12, 17, 20 };

//Imprimir las notas
ImprimirNotas(notas);

//Calcular el promedio
double promedio = CalcularPromedio(notas);

Console.WriteLine("El promedio es: {0}", promedio);