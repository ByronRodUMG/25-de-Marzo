
void adivinar()
{
    const int oportunidades = 4;
    int NumeroCPU, NumeroUsuario;
    byte Intentos, BanderaControl;
    string linea;

    // Generar números del 1 al 20 únicamente.
    Random ran = new();
    NumeroCPU = ran.Next(1, 20);

    // Proceso
    Intentos = 1;
    BanderaControl = 0;

    do
    {
        Console.WriteLine("Estoy pensando en un número entre el 1 y 20, cual será?");
        linea = Console.ReadLine();
        NumeroUsuario = Convert.ToInt32(linea);
        if (NumeroCPU == NumeroUsuario)
        {
            Console.WriteLine("Adivinaste!!!");
            BanderaControl = 1;
        }
        else
        {
            if (NumeroUsuario > NumeroCPU)
            {
                Console.WriteLine($"El número en el que estoy pensando es menor que {NumeroUsuario}.");
            }
            else
            {
                Console.WriteLine($"El número en el que estoy pensando es mayor que {NumeroUsuario}.");
            }
            Intentos++;
        }
    } while ((Intentos <= oportunidades) & (BanderaControl == 0));

    if (BanderaControl == 1)
    {
        Console.WriteLine($"Correcto, el número en el que pensaba era {NumeroCPU}.");
    }
}

void mayor_menor()
{
    int mayor = 0;
    int menor = 10;
    int numero = 0;
    Random random = new();
    for(int i=0; i<5; i++)
    {
        numero = random.Next(10);
        Console.WriteLine(numero);
        if (numero > mayor)
        {
            mayor = numero;
        }
        if (numero < menor)
        {
            menor = numero;
        }
    }
    Console.WriteLine("El mayor es " + mayor);
    Console.WriteLine("El menor es " + menor);
}

mayor_menor();