using System;

namespace Eserci_preparazione_prova
{
    class Program
    {

        static void Main(string[] args)
        {
            //Scrivere una routine che, dati due array, verifichi quali sono gli elementi in comune,
            //ovvero presenti in entrambi gli array, e stampare solo gli elementi in comune. 
            //Se non ci sono elementi in comune, stampare 'Non ci sono elementi in comune'.

            //Es. array1 = {1,2,4}, array2 = {1,2,3} --> output 1,2
            Console.WriteLine("Inserisci quanti elementi vuoi inserire nel primo vettore:");
            int N = CheckIns();
            //Console.WriteLine("Inserisci quanti elementi vuoi inserire nel secondo vettore:");
            //int M= CheckIns();
            Console.WriteLine("Inserisci elementi del primo vettore:");
            int[] myArray1 = NewArray(N);
            Console.WriteLine("Inserisci elementi del secondo vettore:");
            int[] myArray2 = NewArray(N);

            int[] equalValue = new int[N];
            equalValue = Find(myArray1, myArray2, equalValue, N);


            //for (int i = 0; i < N; i++)
            //{
            //    //int count = 1;
            //    for (int j = 0; j < N; j++)
            //    {
            //        if (myArray1[i] == myArray2[j])
            //        {
            //            equalValue[i] = myArray1[i];
            //            //count++;
            //            break;

            //        }
            //    }
            //}

            //int count2 = 0;
            //for (int i = 0; i < N; i++)
            //{
            //    if (equalValue[i] != 0)
            //    {
            //        count2++;
            //    }
            //}

            //if (count2 == 0)
            //{
            //    Console.WriteLine("Nessun valore comune trovato!!");
            //}
            //else
            //    Console.WriteLine("I valori trovati sono:");

            //for (int i = 0; i < N; i++)
            //{
            //    if (equalValue[i] != 0)
            //    {
            //        Console.WriteLine(equalValue[i]);
            //    }
            //}

            int CheckIns()
            {
                int num;
                while (!int.TryParse(Console.ReadLine(), out num) || num == 0)
                {
                    Console.WriteLine("Puoi inserire solo interi diversi da 0! Riprova:");
                }

                return num;
            }

            int[] NewArray(int N)
            {
                int[] myArray = new int[N];
                for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Inserisci il {i + 1}° numero");

                myArray[i] = CheckIns();
            }
                return myArray;
            }

            int [] Find(int [] a,int[] b, int [] c,int N)
            {
                
                for (int i = 0; i < N; i++)
                {
                    int found = -1;
                    found = Array.IndexOf(a, b);
                    if (found > -1 && Array.IndexOf(c, a[i]) != -1)
                    {
                        c[i] = a[i];
                        }
                    }
                return c;
                    
                }
            }



        }
    }




