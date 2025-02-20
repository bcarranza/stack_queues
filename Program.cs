using System;
using System.Collections.Generic;

class Program
{
    static Stack<int> stack = new Stack<int>();
    static Queue<int> queue = new Queue<int>();

    static void Main()
    {
        int option;
        do
        {
            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Push (Agregar a la pila)");
            Console.WriteLine("2. Pop (Eliminar de la pila)");
            Console.WriteLine("3. Peek Pila (Ver el último elemento sin eliminar)");
            Console.WriteLine("4. Mostrar Pila");
            Console.WriteLine("5. Enqueue (Agregar a la cola)");
            Console.WriteLine("6. Dequeue (Eliminar de la cola)");
            Console.WriteLine("7. Peek Cola (Ver el primer elemento sin eliminar)");
            Console.WriteLine("8. Mostrar Cola");
            Console.WriteLine("9. Salir");
            Console.Write("Seleccione una opción: ");
            
            if (int.TryParse(Console.ReadLine(), out option))
            {
                switch (option)
                {
                    case 1:
                        PushStack();
                        break;
                    case 2:
                        PopStack();
                        break;
                    case 3:
                        PeekStack();
                        break;
                    case 4:
                        ShowStack();
                        break;
                    case 5:
                        EnqueueQueue();
                        break;
                    case 6:
                        DequeueQueue();
                        break;
                    case 7:
                        PeekQueue();
                        break;
                    case 8:
                        ShowQueue();
                        break;
                    case 9:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida, intente de nuevo.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida, intente de nuevo.");
            }
            
            Console.WriteLine("Presione Enter para continuar...");
            Console.ReadLine();
        } while (option != 9);
    }

    static void PushStack()
    {
        Console.Write("Ingrese un número para agregar a la pila: ");
        if (int.TryParse(Console.ReadLine(), out int num))
        {
            stack.Push(num);
            Console.WriteLine("Número agregado a la pila.");
        }
        else
        {
            Console.WriteLine("Entrada inválida.");
        }
    }

    static void PopStack()
    {
        if (stack.Count > 0)
        {
            Console.WriteLine($"Elemento eliminado: {stack.Pop()}");
        }
        else
        {
            Console.WriteLine("La pila está vacía.");
        }
    }

    static void PeekStack()
    {
        if (stack.Count > 0)
        {
            Console.WriteLine($"Elemento en la cima: {stack.Peek()}");
        }
        else
        {
            Console.WriteLine("La pila está vacía.");
        }
    }

    static void ShowStack()
    {
        if (stack.Count > 0)
        {
            Console.WriteLine("Elementos en la pila:");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
        else
        {
            Console.WriteLine("La pila está vacía.");
        }
    }

    static void EnqueueQueue()
    {
        Console.Write("Ingrese un número para agregar a la cola: ");
        if (int.TryParse(Console.ReadLine(), out int num))
        {
            queue.Enqueue(num);
            Console.WriteLine("Número agregado a la cola.");
        }
        else
        {
            Console.WriteLine("Entrada inválida.");
        }
    }

    static void DequeueQueue()
    {
        if (queue.Count > 0)
        {
            Console.WriteLine($"Elemento eliminado: {queue.Dequeue()}");
        }
        else
        {
            Console.WriteLine("La cola está vacía.");
        }
    }

    static void PeekQueue()
    {
        if (queue.Count > 0)
        {
            Console.WriteLine($"Primer elemento en la cola: {queue.Peek()}");
        }
        else
        {
            Console.WriteLine("La cola está vacía.");
        }
    }

    static void ShowQueue()
    {
        if (queue.Count > 0)
        {
            Console.WriteLine("Elementos en la cola:");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
        else
        {
            Console.WriteLine("La cola está vacía.");
        }
    }
}
