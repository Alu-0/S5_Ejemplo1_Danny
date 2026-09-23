//Funcion de Imprimir Notas

static void ImprimirNotas(int[] notas)
{
    for(int i=0; i < notas.Length; i++)
    {
        System.Console.WriteLine(notas[i]);
    }
}
int[]notas={15,14,13,16,17};

//Imprimir Notas
ImprimirNotas(notas);