/*Given a number, find the sum of all the multiples of particular numbers up to but not including that number.
 If we list all the natural numbers below 20 that are multiples of 3 or 5, we get 3, 5, 6, 9, 10, 12, 15, and 18.
The sum of these multiples is 78.
 */

using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

public class SumOfMultiples
    {
        static int[] FindMultiples(int range, int[] ints)
        {
            int[] collection = new int[range]; //tworzę pustą tablicę o wielkości równej podanemu zakresowi


            //if (m1 * m2 < range) collection[m1 * m2] = m1 * m2;
            /*Rozwiazanie problemu:
             -do metody przekazuję zakres oraz tablicę liczb, dla których będziemy szukać wielokrotności
             -pętla wewnęrzna leci po kolei po liczbach naturalnych i sprawdza, czy aktualna liczba z tablicy argumentów pomnożona przez tę liczbę
              -naturalną mieści się w zakresie -> jeśli tak, to ustawia odpowiednie miejsce w tablicy wyjściowej
             -jeżeli iloczyn przekroczy zakres, pętla wewnętrzna się kończy
             -pętla zewnętrzna wykonuje powyzsze dla kazdego argumentu tablicy wejściowej
             */
            foreach (int x in ints)
            {
                for (int i = 1; i < range; i++)
                {
                    if (x * i >= range) break;
                    else collection[x * i] = x * i;
                    //Console.WriteLine(x*i); //sprawdzam czy dobrze iteruje
                }
            }
            Console.WriteLine("Wszystkie znalezione liczby: ");
             foreach (int i in collection)
            {
                Console.Write(i+" ");
            }

            return collection;
        }

        static void SumUp(int[] collection)
        {
            int suma = 0;
            foreach (int x in collection)
            {
                suma += x;
            }
            Console.WriteLine("\nSuma: "+suma);
        }

        public static void SumOfMultiplesTest()
        {
            Console.WriteLine("\n---SumOfMultiples--");
            SumUp(FindMultiples(20, new int[] {3,5}));
        }
    }
