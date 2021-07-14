using System;

namespace Week1Day3.Esercizio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Indovina valore: Creare e inizializzare un array di interi dimensione N=4;
            //Chiedere all'utente di provare ad indovinare un numero. Verificare se il numero inserito dall'utente c'è nell'array
            //Se c'è stampa "hai vinto", se non c'è stampa "Hai perso".

            int[] a = { 1, 3, 6, 8 };
            Console.WriteLine("Inserisci un numero.");
            int numeroUtente = int.Parse(Console.ReadLine());
            bool vittoria = false;
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i]== numeroUtente)
                {
                    vittoria = true;
                }
            }
            if (vittoria == true)
            {
                Console.WriteLine("Bravo! Hai vinto");
            }
            else
            {
                Console.WriteLine("Peccato! Hai perso ...");
            }
        }
    }
}
