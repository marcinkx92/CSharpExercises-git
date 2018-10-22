using System;
using System.Collections.Generic;
using System.Linq;

/*Implement the accumulate operation, which, given a collection and an operation
 to perform on each element of the collection, returns a new collection containing 
 the result of applying that operation to each element of the input collection.
 */
 /*
 eg. given collection (1,2,3,4,5) and operation square a number (x => x*x), result: (1,4,9,16,25)
  */
    public class Accumulate
    {
        public static void ModifyCollection(int[] arr){

                var result = arr.Select(x => x*x); 
                foreach (var i in result){
                    Console.Write(i+ ", ");
                }

        }

        public static void AccumulateTest(){
            Console.WriteLine("\n---AccumulateTest---");
            ModifyCollection(new int[] {1,2,3,4,5});
        }
        
    }
//NA RAZIE ZA TRUDNE -> trzeba znać kolekcje i LINQ