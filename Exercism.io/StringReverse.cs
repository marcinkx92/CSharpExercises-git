using System;
using System.Text;

   public class StringReverse{
        static void Reverse(string word){

        // standardowe rozwiązanie
         /* string reversed=string.Copy(word);
            for(int i=word.Length-1, k=0; i>=0; i--, k++){
                reversed[k]=word[i];
            }*/
                /*error: Property or indexer 'string.this[int]' cannot be assigned to -- it is read only 

                Strings are immutable: you can retrieve the character at a certain position,
                 but you cannot change the character to a new one directly.
                Instead you'll have to build a new string with the change. 
                There are several ways to do this, but StringBuilder does the job in a similar fashion to what you already have: */
            
            StringBuilder reversed=new StringBuilder(word);
            StringBuilder empty=new StringBuilder();
            for(int i=word.Length-1, k=0; i>=0; i--, k++){
                reversed[k]=word[i];
            }
            //można prosciej
            for (int i = word.Length - 1; i >= 0; i-- ){
                empty.Append(word[i]);
            }
            Console.WriteLine(reversed);
            Console.WriteLine(empty);
        }

        //zamiana na tablicę char[]
        static void StringToArrayReverse(string word){
            char[] c = word.ToCharArray();
        
            //char[] ch2 = Array.Reverse(c);
            //error: Cannot implicitly convert type 'void' to 'char[]'  (metoda Array.Reverse() jest statycz)
            Array.Reverse(c);
            foreach(char ch in c){
                Console.Write(ch);
            }
        }

       
        public static void StringReverseTest() 
        //klasa "testująca" - odpala metody (lokalna funkcja Main, prawdziwa funkcja Main
        // jest jedna dla całego projektu)
        {
            Console.WriteLine("---StringReverseTest---");
            StringReverse.Reverse("Hello");
            StringReverse.StringToArrayReverse("World!");
        }
    }

