using System;
using System.Text;
    public class Raindrops
    {
        public static string RaindropSpeak(int number){
            string speakup="";
            if (number%3==0) speakup+="Pling";
            if (number%5==0) speakup+="Plang";
            if (number%7==0) speakup+="Plong";
            if (speakup.IsNullOrEmpty()) speakup+=number.ToString();
            return speakup;

        }

        public static void RaindropsTest(){
         Console.WriteLine(Raindrops.RaindropSpeak(28));  
        }
    }
