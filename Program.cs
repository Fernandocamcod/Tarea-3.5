using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese el nombre de una fruta:");
        string fruta = Console.ReadLine().ToLower(); // Convertir a minúsculas para facilitar la comparación

        // Variable para almacenar el mensaje de resultado
        string mensaje;

        // Clasificación de la fruta
        switch (fruta)
        {
            case "naranja":
            case "limón":
            case "lima":
            case "mandarina":
            case "pomelo":
            case "clementina":
                mensaje = $"{fruta} es una fruta cítrica.";
                break;
            case "manzana":
            case "plátano":
            case "pera":
            case "uva":
            case "fresa":
                mensaje = $"{fruta} no es una fruta cítrica.";
                break;
            default:
                mensaje = "No se reconoce la fruta ingresada. Por favor, ingrese una fruta válida.";
                break;
        }

        // Mostrar el resultado
        Console.WriteLine(mensaje);

        // Esperar a que el usuario presione una tecla antes de cerrar
        Console.WriteLine("Presione cualquier tecla para continuar...");
        Console.ReadKey();
    }
}
