using System;

namespace Esercizi_corretti
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
            int count = 0;
            Stamp(count,equalValue,N);


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


            void Stamp(int count,int [] array, int N)
            {

                for (int i = 0; i < N; i++)
                {
                    if (array[i] != 0)
                    {
                        count++;
                    }
                }

                if (count == 0)
                {
                    Console.WriteLine("Nessun valore comune trovato!!");
                }
                else
                    Console.WriteLine("I valori trovati sono:");

                for (int i = 0; i < N; i++)
                {
                    if (array[i] != 0)
                    {
                        Console.WriteLine(array[i]);
                    }
                }
            }

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

            int[] Find(int[] a, int[] b, int[] c, int N)
            {

                for (int i = 0; i < N; i++)
                {   
                        int found = -1;
                        found = Array.IndexOf(a, b[i]);

                            if (found > -1)
                            {
                                c[i] = a[i];

                            }
                }
                return c;



            }

            //Scrivere una routine che chiede all'utente di scrivere i giorni della settimana (Es. Lun Mar Mer Gio Ven Sab Dom).
            //Se l'utente ha già inserito un giorno, stampare 'Hai già inserito questo giorno' e far inserire  nuovo.
            //Infine, stampare i giorni nell'ordine in cui l'utente li ha inseriti. 

            //string[] dayWeek = new string[] { "Lun", "Mar", "Mer", "Gio", "Ven", "Sab", "Dom" };
            string[] day = new string[7];
            string dayWeekUser = null;

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Inserisci un giorno della settimana:");
                dayWeekUser = CheckIns();
                int found = -1;
                found = Array.IndexOf(day, dayWeekUser);
                if (found > -1)
                {
                    i--;
                }
                else
                {
                    day[i] = dayWeekUser;
                }

            }
            Console.WriteLine($"I giorni scelti dall'utente sono:");
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"{day[i]}\n");
            }

            string CheckIns()
            {
                string s = Console.ReadLine();


                if (int.TryParse(s, out int a) == true)
                {
                    Console.WriteLine("Puoi inserire solo stringhe! Riprova:");
                    s = null;
                }

                return s;
            }


            //Scrivere un programma completo. L'utente inserisce un numero tra 2 e 12
            //Il computer lancia 2 dadi, quindi sorteggia 2 numeri random tra 1 e 6.
            //Se la somma dei due numeri random è pari al numero scelto dall'utente, l'utente vince
            //Se l'utente vince, stampare 'hai vinto', altrimenti 'hai perso'.
            //Finita la partita l'utente deve poter rigiocare.
            //Requisiti:
            //verificare che l'utente inserisca un intero e che sia compreso tra 2 e 12.
            //se la verifica non va a buon fine, l'utente deve potere inserire nuovamente qualcosa.
            //Creare un metodo per l'inserimento dei numeri e la verifica,
            //uno per il controllo della vittoria(da chiamare nel main)

            int choice = 1;

            while (choice == 1)
            {
                Console.WriteLine("Vuoi giocare al gioco dei dadi? \nClicca 1: per giocare\nClicca 2:per uscire!");
                choice = CheckChoice();

                switch (choice)
                {
                    case 1:
                        int choiceNum = InsertNew();
                        int[] newDrawn = DrawNumbers(2);
                        bool result = CheckNumbers(newDrawn, choiceNum);


                        if (result == true)
                        {
                            Console.WriteLine("Hai vinto!");
                        }
                        else
                        {
                            Console.WriteLine("Hai perso!");
                            Console.WriteLine("I numeri estratti sono:{0} e {1}", newDrawm[0], newDrawn[1]);
                        }
                        break;

                    case 2:
                        break;

                    default:
                        break;

                }




                int InsertNew()
                {
                    Console.WriteLine("Inserisci un nuovo numero compreso tra 2 e 12 ");
                    int N = CheckIns();
                    return N;
                }
            }
            int CheckChoice()
            {
                int num;
                while (!int.TryParse(Console.ReadLine(), out num) || num < 1 || num > 2)
                {
                    Console.WriteLine("Puoi inserire solo inserire 1 o 2! Riprova:");
                }

                return num;
            }

            int CheckIns()
            {
                int num;
                while (!int.TryParse(Console.ReadLine(), out num) || num < 2 || num > 12)
                {
                    Console.WriteLine("Puoi inserire solo numeri interi compresi tra 2 e 12! Riprova:");
                }

                return num;
            }

            int[] DrawNumbers(int N)
            {
                int[] numbers = new int[N];
                Random random = new Random();
                for (int i = 0; i < N; i++)
                {
                    int dad = random.Next(2, 13);
                    numbers[i] = dad;

                }
                return numbers;
            }

            bool CheckNumbers(int[] a, int b)
            {
                bool result = false;
                int sum = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    sum = sum + a[i];

                }
                if (sum == b)
                {
                    result = true;
                }
                return result;
            }


            //Scrivere una routine, che dato un array di numeri interi e un numero intero N, verifichi che N sia contenuto nell'array
            //var myArray = new[] { 4, 7, 1, 10, 3 };

            Console.WriteLine("Quanti elementi vuoi inserire:");
            int v = int.Parse(Console.ReadLine());
            int[] myArray = new int[v];

            for (int i = 0; i < v; i++)
            {
                Console.WriteLine("Inserisci elemento:");
                myArray[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Inserisci il numero da cercare:");
            int N = int.Parse(Console.ReadLine());
            IsInArray(N, myArray);


            void IsInArray(int N, int[] array)
            {

                for (int i = 0; i < myArray.Length; i++)
                {
                    if (myArray[i] == N)
                    {
                        Console.WriteLine("{0} è contenuto nell'array in posizione {1}", N, myArray[i]);
                        break;
                    }
                }
                Console.WriteLine("Nessun valore trovato!");

            }

            void FindNumber(int[] array, int n)
            {
                int found = -1;
                /*int found=Array.IndexOf(array, n); *///restituisce indice del primo elemento che trova.
                                                       //Restituisce indice >=0 se lo trova, indice =-1 non lo trova
                if (found > -1) //oppure found !=-1, oppure found>=0
                {
                    Console.WriteLine($"Il numero {n} è presente nell'array!");
                }
                else
                {
                    Console.WriteLine("Nessun valore trovato!");
                }
            }

                //Chiamate 
                InsertNumbers();

                /*---------------------------*/

                //Esercizio 1

                //Scrivere una routine InsertNumbers che chiede all'utente di inserire 3 numeri interi diversi da 0 e li salva in un array e me lo restituisce.
                //Verificare che i numeri aggiunti dall'utente siano del formato corretto e verificare che siano diversi da 0 con un'altra routine CheckIns, da chiamare in InsertNumbers.

                int[] InsertNumbers()
                {
                    int[] numbers = new int[3];

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        Console.WriteLine($"Inserisci il {i + 1}° numero");

                        numbers[i] = CheckIns();
                    }
                    return numbers;

                }

                int CheckIns()
                {
                    int num;
                    while (!int.TryParse(Console.ReadLine(), out num) || num == 0)
                    {
                        Console.WriteLine("Puoi inserire solo interi diversi da 0! Riprova:");
                    }

                    return num;
                }



                //classe implementata in .Net: classe random, per numeri casuali:
                Random random = new Random();

                //sorteggiare in un intervallo 10-20
                int randomNum = random.Next(10, 21);

            }
        }
    }

