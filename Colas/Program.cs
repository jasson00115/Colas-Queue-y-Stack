using Colas.clases.ColaArreglo;
using Colas.clases.Pila_Lista;
using System;
using System.Collections;

namespace Colas
{
    class Program
    {

        public void extra()
        {
            Queue qt = new Queue();
            qt.Enqueue("hola");
            qt.Enqueue("estas");
            qt.Enqueue("es");
            qt.Enqueue("una");
            qt.Enqueue("prueba");

            Console.WriteLine($"la Cola tiene {qt.Count} elementos");
            Console.WriteLine($"Desencolando {qt.Dequeue()}");
            Console.WriteLine($"la Cola tiene {qt.Count} elementos");
        }

        private static bool valido(String numero)
        {
            bool sw = true;
            int i = 0;
            while (sw && (i < numero.Length))
            {
                char c;
                c = numero[i++];
                sw = (c >= '0' && c <= '9');
            }
            return sw;
        }

        public static void CapicuaStack()
        {
            bool capicua;
            string numero;
            PilaLineal pila = new PilaLineal();
            ColaCircular circula_Cola = new ColaCircular();
            try
            {
                capicua = false;
                while (!capicua)
                {
                    do
                    {
                        Console.WriteLine("\n Teclea un numero: ");
                        numero = Console.ReadLine();
                    } while (!valido(numero));
                    //pone en la cola y en la capicua cada digito
                    for (int i = 0; i < numero.Length; i++)
                    {
                        int c;
                        c = numero[i];
                        circula_Cola.insertar(c);
                        pila.insertar(c);
                    }
                    //se retira de la cola y pila para comparar
                    do
                    {
                        int d;
                        d = (int)circula_Cola.quitar();
                        capicua = d.Equals(pila.quitar()); //compara la igualdad
                    } while (capicua && !circula_Cola.colaVacia());
                    if (capicua)
                    {
                        Console.WriteLine($"Numero {numero} es capicua");
                    }
                    else
                    {
                        Console.WriteLine($"Numero {numero} no es capicua");
                        Console.WriteLine("intente otro");
                    }
                }
            }
            catch (Exception errores)
            {
                Console.WriteLine($"Error en {errores.Message} ");
            }
            Console.ReadKey();
        }

        public static void programa1()
        {
            bool capicua;
            string numero;
            PilaLista Pila = new PilaLista();
            ColaCircular circula_Cola = new ColaCircular();

            try
            {

                capicua = false;
                while (!capicua)
                {
                    do
                    {
                        Console.WriteLine("\nTeclea un numero: ");
                        numero = Console.ReadLine();
                    } while (!valido(numero));

                    //PONE EN LA COLA Y EN LA PILA CADA DIGITO
                    for (int i = 0; 0 < numero.Length; i++)
                    {
                        Char c;
                        c = numero[i];
                        circula_Cola.insertar(c);
                        Pila.insertar(c);
                    }

                    //SE RETIRA DE LA COLA Y PILA PARA COMPARAR
                    do
                    {
                        Char d;
                        d = (Char)circula_Cola.quitar();
                        capicua = d.Equals(Pila.quitar());
                    } while (capicua && !circula_Cola.colaVacia());

                    if (capicua)
                    {
                        Console.WriteLine($"Numero {numero} es capicua");
                    }
                    else
                    {
                        Console.WriteLine($"njmero {numero} no es capicua");
                        Console.WriteLine("intente otro");
                    }
                    // vaciar estructuras

                    circula_Cola.borrarcola();
                    Pila.limpiarPila();
                }

            }
            catch (Exception errores)
            {
                Console.WriteLine($"Error en {errores.Message}");
            }
        }

        static Queue qt = new Queue();
        public static void CapicuaQueue()
        {
            bool capicua;
            string numero;
            PilaLista pila = new PilaLista();
            ColaCircular circula_Cola = new ColaCircular();
            try
            {
                capicua = false;
                while (!capicua)
                {
                    do
                    {
                        Console.WriteLine("\n Teclea un numero: ");
                        numero = Console.ReadLine();
                    } while (!valido(numero));
                    //pone en la cola y en la capicua cada digito
                    for (int i = 0; i < numero.Length; i++)
                    {
                        Char c;
                        c = numero[i];
                        circula_Cola.insertar(c);
                        qt.Enqueue(c);
                        //pila.insertar(c);
                    }
                    //se retira de la cola y pila para comparar
                    do
                    {
                        Char d;
                        d = (char)qt.Dequeue();
                        //d = (Char)circula_Cola.quitar();
                        //capicua = d.Equals(pila.quitar()); 
                        capicua = d.Equals(qt.Dequeue()); //compara la igualdad
                    } while (capicua && !IsEmpty());   /*circula_Cola.colaVacia());*/
                    if (capicua)
                    {
                        Console.WriteLine($"Numero {numero} es capicua");
                    }
                    else
                    {
                        Console.WriteLine($"Numero {numero} no es capicua");
                        Console.WriteLine("intente otro");
                    }
                }
            }
            catch (Exception errores)
            {
                Console.WriteLine($"Error en {errores.Message} ");
            }
            Console.ReadKey();
        }
        public static bool IsEmpty()
        {
            return qt.Count == 0;
        }

        static void Main(string[] args)
        {

            //CapicuaStack();
            CapicuaQueue();


        }
    }
}
