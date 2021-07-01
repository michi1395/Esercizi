using System;

namespace esercizio2
{
    class Program
    {
        static void Main(string[] args)
        {
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
            for (int i=0;i<7;i++)
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

            //int choice = 1;

            //while (choice==1)
            //{ 
            //    Console.WriteLine("Vuoi giocare al gioco dei dadi? \nClicca 1: per giocare\nClicca 2:per uscire!");
            //    choice = CheckChoice();
                
            //    switch (choice)
            //    {
            //        case 1:
            //            int choiceNum = InsertNew();
            //            int[] newDrawn = DrawNumbers(2);
            //            bool result = CheckNumbers(newDrawn, choiceNum);


            //            if (result == true)
            //            {
            //                Console.WriteLine("Hai vinto!");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Hai perso!");
            //                Console.WriteLine("I numeri estratti sono:{0} e {1}", newDrawm[0], newDrawn[1]);
            //            }
            //            break;

            //        case 2:
            //            break;

            //        default:
            //            break;

            //    }

           


            //int InsertNew ()
            //{
            //    Console.WriteLine("Inserisci un nuovo numero compreso tra 2 e 12 ");
            //    int N = CheckIns();
            //    return N;
            //}
            //}
            //int CheckChoice()
            //{
            //    int num;
            //    while (!int.TryParse(Console.ReadLine(), out num) || num < 1 || num > 2)
            //    {
            //        Console.WriteLine("Puoi inserire solo inserire 1 o 2! Riprova:");
            //    }

            //    return num;
            //}

            //int CheckIns()
            //{
            //    int num;
            //    while (!int.TryParse(Console.ReadLine(), out num) || num <2 ||num>12)
            //    {
            //        Console.WriteLine("Puoi inserire solo numeri interi compresi tra 2 e 12! Riprova:");
            //    }

            //    return num;
            //}

            //int[] DrawNumbers(int N)
            //{
            //    int[] numbers = new int[N];
            //    Random random = new Random();
            //    for(int i=0;i<N;i++)
            //    {
            //        int dad = random.Next(2, 13);
            //        numbers[i] = dad;

            //    }
            //    return numbers;      
            //}

            //bool CheckNumbers (int [] a,int b)
            //{
            //    bool result = false;
            //    int sum = 0;
            //    for (int i=0;i<a.Length;i++)
            //    {
            //        sum = sum + a[i];
                    
            //    }
            //    if(sum==b)
            //    {
            //        result = true;
            //    }
            //        return result;
            //}


        }
    }
}
