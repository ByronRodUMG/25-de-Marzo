
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
        Console.WriteLine($"Correcto, el número en el que pensaba era {NumeroCPU}.\n");
    }
    else
    {
        Console.WriteLine("Intentos terminados.\n");
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

void catcher()
{
    int cantidad = 0;
    Console.WriteLine("Ingrese una cantidad: ");
    try
    {
        cantidad = int.Parse(Console.ReadLine());
        //cantidad = cantidad / 0;
    }
    catch (FormatException fex)
    {
        Console.WriteLine("Ingresó mal el número: " + fex.Message);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Hay un error de otro tipo: " + ex.Message);
    }
    
    if (cantidad > 0 )
    {
        Console.WriteLine("Cantidad ingresada: " + cantidad);
    }
}

void ejemploArreglo()
{
    int[] numero = new int[7]; // Definimos y creamos el arreglo
    int suma = 0;
    int elementos = numero.Length;
    numero[0] = 45;
    numero[1] = 50;
    numero[2] = 68;
    numero[3] = 70;
    numero[4] = 86;
    numero[5] = 92;
    numero[6] = 69;

    for (int i = 0; i < elementos; i++)
    {
        suma += numero[i];
        Console.WriteLine(numero[i]);
    }
    Console.WriteLine("Sumatoria: " + suma);
    Console.WriteLine("Promedio: " + suma / elementos);
    Console.WriteLine("El numero mayor es " + numero.Max());
    Console.WriteLine("El numero menor es " + numero.Min());

    int personas = 10;
    int primerpremio = 0;
    int segundopremio = 0;

    String[] nombres = new string[personas];
    nombres[0] = "Maria";
    nombres[1] = "Juan";
    nombres[2] = "Pedro";
    nombres[3] = "Julio";
    nombres[4] = "Fernando";
    nombres[5] = "Paola";
    nombres[6] = "Jefferson";
    nombres[7] = "Brandon";
    nombres[8] = "Byron";
    nombres[9] = "Daniela";

    Random ran1 = new();
    primerpremio = ran1.Next(personas);

    Console.WriteLine("\nEl ganador del primer premio es " + nombres[primerpremio]);

    do
    {
        Random ran2 = new();
        segundopremio = ran2.Next(personas);
    } while (segundopremio == primerpremio);

    Console.WriteLine("El ganador del segundo premio es " + nombres[segundopremio]);
}

//adivinar();
//mayor_menor();
//catcher();
ejemploArreglo();
