do
{
    Console.Write("Introduzca un numero entero o Control + C para salir : ");
    var n = 0;
    if (int.TryParse(Console.ReadLine(), out n))
    {
        if (n % 2 == 0)
        {
        Console.WriteLine("El numero {0} es Par :)", n);
        }
         else
         {
             Console.WriteLine("El numero {0} es Impar :", n);
         }
    
    }
    else
    {
        Console.WriteLine("Debe ingresar un valor numerico entero ");
    }

} while (true);
