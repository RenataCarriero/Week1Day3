using System;
using System.Collections.Generic;

namespace Week1Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Routine();
            //EsempioArray();

            //Random per generare numeri casuali.
            Random random = new Random();
            int numeroRandom=random.Next(10, 21);
            Console.WriteLine($"E' stato generato casualmente il numero {numeroRandom} ");

        }

        private static void EsempioArray()
        {
            //Array
            int[] primoArray = new int[5];
            primoArray[0] = 3;
            primoArray[1] = 10;
            primoArray[2] = 13;
            primoArray[3] = 55;
            primoArray[4] = 8;

            //cerco la posizione in base al valore.
            int indice = Array.IndexOf(primoArray, 10);
            Console.WriteLine($"Il numero 10 si trova alla posizione {indice}");

            Console.WriteLine("Stampa del mio primoArray:\n");
            for (int i = 0; i < primoArray.Length; i++)
            {
                Console.Write($"{primoArray[i]} \t");
            }


            int[] numeri = { 1, 2, 45, 67, 70 };

            string[] nomi = { "Renata", "Alessandra", "Arianna" };

            //Collection Liste
            List<int> listaNumeri = new List<int>();
            listaNumeri.Add(23);
            listaNumeri.Add(45);
            int elementi = listaNumeri.Count;
            Console.WriteLine($"\nLa mia lista contiene {elementi} elementi");
            listaNumeri.Add(5);
            Console.WriteLine($"La mia lista contiene {listaNumeri.Count} elementi");

            //Matrici
            int[,] matrice = new int[2, 3]; //2 è il numero di righe. 3 è il numero di colonne.
            int[,] matrice2 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrice2[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }

        }

        private static void Routine()
        {
            Console.WriteLine("Hello!");
            Menu();

            int a = 1;
            int b = 2;
            int somma = Sum(a, b);
            Console.WriteLine(somma);

            int c = 40;
            int d = 4;

            int sommaCD = Sum(c, d);
            Console.WriteLine(sommaCD);

            int e = 45;
            int f = 2;
            StampaSomma(e, f);

            int g = 32;
            int h = 1;
            StampaSommaConRichiamoFunzioneSum(g, h);

            int var1 = 10;
            CambioValore(var1);
            Console.WriteLine($"Il valore di var1 dopo la chiamata a CambioValore è {var1}");

            int var2 = 20;
            CambioValorePerRif(ref var2);
            Console.WriteLine($"Il valore di var1 dopo la chiamata a CambioValore è {var2}");

            int n = 2;
            int m = 10;
            int sommaNM = SommaDopoIncremento(ref n, m);
            Console.WriteLine($"La variabile n vale: {n} "); //3
            Console.WriteLine($"La variabile m vale: {m} "); //10
            Console.WriteLine($"La somma è: {sommaNM} "); //14


            //out
            int x1 = 2;
            int x2 = 3;
            int diffX1X2 = DifferenzaEProdotto(x1, x2, out int prodotto);
            Console.WriteLine($"Il prodotto è {prodotto}");
            Console.WriteLine($"La differenza è {diffX1X2}");

            //TryParse.
            Menu();
            Console.WriteLine("inserisci la tua scelta");
            //int scelta = int.Parse(Console.ReadLine());
            //bool verificaCheSiaIntero = int.TryParse(Console.ReadLine(), out int scelta);
            //Console.WriteLine($"La scelta dell'utente è : {scelta}");

            int scelta;

            while (!int.TryParse(Console.ReadLine(), out scelta) || scelta < 1 || scelta > 3)
            {
                Console.WriteLine("Scelta errata. Deve essere un intero compreso tra 1 e 3. riprova");
            }
            Console.WriteLine($"La scelta dell'utente è : {scelta}");
        }

        // Mi deve restituire la differenza. Ma mi interessa anche avere in output il prodotto dei 2 valori passati in input.
        private static int DifferenzaEProdotto(int x, int y, out int p)
        {
            int diff = x - y;
            p = x * y;            
            return diff;
        }


        //SCrivere una funzione che prende in input 2 interi (il primo per riferimento, il secondo per valore)
        //li incrementa di 1 e restituisce la loro somma
        private static int SommaDopoIncremento(ref int x, int y)
        {
            x++;
            y++;
            return x + y; //14
        }


        private static void CambioValore(int x) //passaggio per valore
        {
            x = 5;
            Console.WriteLine($"Ho cambiato il mio parametro. Valore = {x}");
        }
        private static void CambioValorePerRif(ref int x)
        {
            x = 5;
            Console.WriteLine($"Ho cambiato il mio parametro. Valore = {x}");
        }

        private static int Sum(int x, int y)
        {
            return x + y;
        }

        private static void StampaSomma(int x, int y)
        {
            Console.WriteLine($"La somma di {x} + {y} è uguale a {x+y}");
        }

        private static void StampaSommaConRichiamoFunzioneSum(int x, int y)
        {
            Console.WriteLine($"La somma di {x} + {y} è uguale a {Sum(x,y)}");
        }


        private static void Menu()
        {
            Console.WriteLine("*****Menu****");
            Console.WriteLine("1. Opzione 1");
            Console.WriteLine("2. Opzione 2");
            Console.WriteLine("3. Opzione 3");
        }

        //overloading
        private static int Sum(int a, int b, int c)
        {
            return a+b+c;
        }
        private static int Sum(ref int a, int b, int c)
        {
            return a + b + c;
        }

        private static double Sum(double a, double b)
        {
            return a + b;
        }

        



    }
}
