using System;

namespace Week1Day3.Esercizio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Analizza Numeri

            Si scriva un programma per poter analizzare una sequenza di numeri.
            Dati N numeri interi letti da tastiera(alternativa generati in maniera Random)
            si vogliono calcolare e stampare su schermo diversi risultati:

            1.quanti sono i numeri positivi, nulli e negativi
            2.quanti sono i numeri pari e dispari
            3.se la sequenza dei numeri inseriti è crescente, decrescente oppure né crescente né decrescente.

            Suggerimento.
            Una sequenza è crescente se ogni numero è maggiore del precedente, 
            decrescente se ogni numero è minore del precedente,
            né crescente né decrescente in tutti gli altri casi.
            */
            do
            {
                Console.WriteLine("\nQuanti numeri vuoi inserire?");
                int n = int.Parse(Console.ReadLine());

                int countNulli = 0, countPositivi = 0, countNegativi = 0, countPari = 0, countDispari = 0;

                //Introduco delle variabili che mi servono a contare il numero di confronti crescenti e decrescenti.
                int countConfrontiCrescenti = 0, countConfrontiDecrescenti = 0;
                bool isCrescente = false, isDecrescente = false;

                Console.WriteLine($"Dovrai inserire {n} numeri");
                int[] numeriInseriti = new int[n];

                for (int i = 0; i < n; i++)
                {
                    Console.Write($"\nInserisci il {i + 1}° numero:  ");
                    numeriInseriti[i] = int.Parse(Console.ReadLine());

                    if (numeriInseriti[i] == 0)
                    {
                        countNulli++;
                    }
                    else if (numeriInseriti[i] > 0)
                    {
                        countPositivi++;
                    }
                    else
                    {
                        countNegativi++;
                    }


                    if (numeriInseriti[i] % 2 == 0)
                    {
                        countPari++;
                    }
                    else
                    {
                        countDispari++;
                    }


                    if (i >= 1) //dal secondo in poi posso verificare la crescenza/decrescenza
                    {
                        if (numeriInseriti[i] >= numeriInseriti[i - 1])
                        {
                            countConfrontiCrescenti++;
                            //incremento il contatore quando la condizione di crescenza tra l'elemento e suo precedente è verificata.
                        }
                        else
                        {
                            countConfrontiDecrescenti++;
                        }
                    }
                }

                Console.WriteLine($"Ci sono {countNulli} numeri nulli");
                Console.WriteLine($"Ci sono {countPositivi} numeri positivi");
                Console.WriteLine($"Ci sono {countNegativi} numeri negativi");
                Console.WriteLine($"Ci sono {countPari} numeri pari");
                Console.WriteLine($"Ci sono {countDispari} numeri dispari");

                //se il conteggio dei confrontiCrescenti è uguale al numero massimo di confronti assegno true alla variabile booleana is Crescente  
                if (countConfrontiCrescenti == numeriInseriti.Length - 1)
                {
                    isCrescente = true;
                }
                else if (countConfrontiDecrescenti == numeriInseriti.Length - 1)
                {
                    isDecrescente = true;
                }


                if (isCrescente == true)
                {
                    Console.WriteLine("I numeri sono in ordine crescente");
                }
                else if (isDecrescente == true)
                {
                    Console.WriteLine("I numeri sono in ordine decrescente");
                }
                else
                {
                    Console.WriteLine("Nè crescente, nè decrescente");
                }

                //do la possibilità all'utente di continuare utilizzando un do-while in questo caso
                Console.WriteLine("Vuoi continuare? S/N"); 
            } while(Console.ReadLine()== "S");


        }
    }
}
