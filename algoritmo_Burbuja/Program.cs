void MethodBurbuja()
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine(@"
 $$$$$$\  $$\                               $$\   $$\                                         $$\                 $$$$$$$\                      $$\                                     
$$  __$$\ $$ |                              \__|  $$ |                                        $$ |                $$  __$$\                     $$ |                                    
$$ /  $$ |$$ | $$$$$$\   $$$$$$\   $$$$$$\  $$\ $$$$$$\   $$$$$$\$$$$\   $$$$$$\         $$$$$$$ | $$$$$$\        $$ |  $$ |$$\   $$\  $$$$$$\  $$$$$$$\  $$\   $$\       $$\  $$$$$$\  
$$$$$$$$ |$$ |$$  __$$\ $$  __$$\ $$  __$$\ $$ |\_$$  _|  $$  _$$  _$$\ $$  __$$\       $$  __$$ |$$  __$$\       $$$$$$$\ |$$ |  $$ |$$  __$$\ $$  __$$\ $$ |  $$ |      \__| \____$$\ 
$$  __$$ |$$ |$$ /  $$ |$$ /  $$ |$$ |  \__|$$ |  $$ |    $$ / $$ / $$ |$$ /  $$ |      $$ /  $$ |$$$$$$$$ |      $$  __$$\ $$ |  $$ |$$ |  \__|$$ |  $$ |$$ |  $$ |      $$\  $$$$$$$ |
$$ |  $$ |$$ |$$ |  $$ |$$ |  $$ |$$ |      $$ |  $$ |$$\ $$ | $$ | $$ |$$ |  $$ |      $$ |  $$ |$$   ____|      $$ |  $$ |$$ |  $$ |$$ |      $$ |  $$ |$$ |  $$ |      $$ |$$  __$$ |
$$ |  $$ |$$ |\$$$$$$$ |\$$$$$$  |$$ |      $$ |  \$$$$  |$$ | $$ | $$ |\$$$$$$  |      \$$$$$$$ |\$$$$$$$\       $$$$$$$  |\$$$$$$  |$$ |      $$$$$$$  |\$$$$$$  |      $$ |\$$$$$$$ |
\__|  \__|\__| \____$$ | \______/ \__|      \__|   \____/ \__| \__| \__| \______/        \_______| \_______|      \_______/  \______/ \__|      \_______/  \______/       $$ | \_______|
              $$\   $$ |                                                                                                                                            $$\   $$ |          
              \$$$$$$  |                                                                                                                                            \$$$$$$  |          
               \______/                                                                                                                                              \______/           
");
    Console.ForegroundColor = ConsoleColor.White;

    Console.ForegroundColor = ConsoleColor.White;
    //Definimos el arreglo desordenado
    int[] arregloDesordenado = { 2, 4, 1, 2, 10, 100, 20, 1002, 200, 11, 23, 43, 3 };

    //Definimos y asignamos el tamaño del arreglo desordenado
    int lenArregloDesordenado = arregloDesordenado.Length;

    //Mostramos por pantalla el arreglo desordenado
    Console.WriteLine("\nArreglo Desordenado\n");
    //Cambiamos de color de fuente de la consola en Rojo
    Console.ForegroundColor = ConsoleColor.Red;
    //Recorremos el arreglo usando "linq" o "lamda"
    arregloDesordenado.ToList().ForEach((elemento) => Console.Write($"[{elemento}]"));
    //Hacemos un salto de linea
    Console.WriteLine();
    //Configuramos el color de fuente en Verde
    Console.ForegroundColor = ConsoleColor.Green;

    int positionInicial = -1;
    int positionFinal = -1;

    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("\nArreglos modificados\n");

    //Definimos una estructura de datos para recorrer cada elemento del arreglo
    for (int i = lenArregloDesordenado - 1; i > 0; i--)
    {
        //Definimos una segunda estructura de recorrido para realizar evaluación en cada elemento de la matriz
        for (int j = 0; j < i; j++)
        {
            //Evaluamos los elementos del arreglo para compararlos y asi intercambiarlos de posición.
            if (arregloDesordenado[j] > arregloDesordenado[i])
            {
                //Almaceno las posiones de cada elemento.
                positionInicial = j;
                positionFinal = i;

                //Almaceno el valor de la iteración en "j" del elemento del arreglo
                int tempIntercambio = arregloDesordenado[j];

                //Asigno a la matriz desordenada en la posicion del valor comparado en j y le asigno el valor de la posicion del elemento i al arreglo desordenado.
                arregloDesordenado[j] = arregloDesordenado[i];

                //Asigno a la matrix desordenada en la posicion de i del valor comparado y le asigno el valor de la posicion del elemento de la variable temporal.
                arregloDesordenado[i] = tempIntercambio;

                //Evaluamos si hay posiciones obtenidas del cambio
                if (positionInicial != -1 && positionFinal != -1)
                {
                    //Recorremos las posiones del arreglo cambiado.
                    for (int k = 0; k < lenArregloDesordenado; k++)
                    {
                        //Evaluamos las posiones obtenidas para decidir que color ira con cada elemento mostrado en pantalla.
                        if (k == positionInicial || k == positionFinal)
                        {
                            //Mostramos y cambiamos el color de fuente del elemento intercambiado en el arreglo.
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write($"[{arregloDesordenado[k]}]");

                        }
                        else
                        {
                            //Mostramos los elementos que no sufrieron intercambios en el arreglo.
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write($"[{arregloDesordenado[k]}]");
                        }
                    }
                    //Reseteamos las posiciones
                    positionInicial = 0; positionFinal = 0;
                }
                //Reseteo para que todo sea verde
                Console.ForegroundColor = ConsoleColor.DarkBlue;

                //Mostramos por pantalla los valores de comparación
                Console.WriteLine($" | {arregloDesordenado[j]} > {arregloDesordenado[i]}");
                
                Console.WriteLine();

                //Detenemos el ciclo para que ya no siga buscando
                break;
            }
        }
    }
    //Dejamos un espacio de linea
    Console.WriteLine();
    Console.WriteLine();

    //Indicamos que se detenga la app para cuando demos clic
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Presione una tecla para finalizar...");
    Console.ReadKey();
}

//Ejecutamos el método
MethodBurbuja();