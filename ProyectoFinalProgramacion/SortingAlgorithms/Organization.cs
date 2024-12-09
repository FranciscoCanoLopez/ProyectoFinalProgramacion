using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgramacion.SortingAlgorithms
{
    internal class Organization
    {
        public event Action<int[]> OnSwap;

        public bool swapped;


        public void BubbleSort(int[] array)
        {
            int size = array.Length;

            // Bucle externo para las pasadas sobre el arreglo
            for (int quantity = 0; quantity < size - 1; quantity++)
            {
                swapped = false;
                // Bucle interno para comparar e intercambiar elementos adyacentes
                for (int current = 0; current < size - quantity - 1; current++)
                {
                    //if (array[current] < array[current + 1])
                    if (array[current] > array[current + 1])
                    {
                        // Intercambiar elementos
                        int temporal = array[current];
                        array[current] = array[current + 1];
                        array[current + 1] = temporal;
                        swapped = true;
                        OnSwap?.Invoke(array);
                    }
                }
                if (!swapped)
                {
                    break;
                }
            }
        }




        public void Cocktail_Sort(int[] array)
        {
            int end = array.Length - 1;
            swapped = true;

            // Bucle externo que sigue ejecutándose mientras se hagan intercambios
            for (int start = 0; start < end && swapped; start++, end--)
            {
                swapped = false;

                // Bucle para la pasada de izquierda a derecha
                for (int current = start; current < end; current++)
                {
                    //if (array[current] < array[current + 1])
                    if (array[current] > array[current + 1])
                    {
                        int temporal = array[current];
                        array[current] = array[current + 1];
                        array[current + 1] = temporal;
                        swapped = true;
                        OnSwap?.Invoke(array); // Llamada al evento después de cada intercambio
                    }
                }


                // Si no hubo intercambios en la pasada, el arreglo ya está ordenado
                if (!swapped) break;

                swapped = false;

                // Bucle para la pasada de derecha a izquierda
                for (int i = end - 1; i >= start; i--)
                {
                    //if(array[i] < array[i + 1])
                    if (array[i] > array[i + 1])
                    {
                        int temporal = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temporal;
                        swapped = true;
                        OnSwap?.Invoke(array); // Llamada al evento después de cada intercambio
                    }
                }
            }
        }


        public void Insertionsort(int[] array)
        {
            int largo = array.Length;

            for (int i = 1; i < largo; i++)
            {
                int elemento = array[i];
                int j = i - 1;

                // Mover elementos mayores a una posición adelante
                //array[j] < elemento
                while (j >= 0 && array[j] > elemento)
                {
                    array[j + 1] = array[j];
                    j--;
                    OnSwap?.Invoke(array);
                }
                array[j + 1] = elemento;
                OnSwap?.Invoke(array);
            }
        }



        public int[] DesordenarArreglo(int[] array)
        {
            Random random = new Random();


            for (int i = 0; i < array.Length; i++)
            {
                int j = random.Next(i, array.Length); // Índice aleatorio desde i hasta el final
                                                      // Intercambiar elementos en las posiciones i y j
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }

            return array;
        }

    }
}
