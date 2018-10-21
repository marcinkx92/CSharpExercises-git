using System;
using System.Text;
using System.Collections.Generic;
    public class NucleotideCount
    {
        // Given a single stranded DNA string, compute how many times each nucleotide occurs in the string.
        // Nucleotides: 'A' for adenine, 'C' for cytosine, 'G' for guanine, and 'T' thymine.
        public static void NucleotideCounter(string DNA){
            Dictionary<string,string> nucleotidesDict = new Dictionary<string,string>();
            nucleotidesDict.Add("A","adenine");
            nucleotidesDict.Add("C","cytosine");
            nucleotidesDict.Add("G","guanine");
            nucleotidesDict.Add("T","thymine");
            int a=0,c=0,g=0,t=0;
            foreach (char ch in DNA){
                if(nucleotidesDict.ContainsKey(ch.ToString())){
                    switch (ch){
                        case 'A': a++;
                        break;
                        case 'C': c++;
                        break;
                        case 'G': g++;
                        break;
                        case 'T': t++;
                        break;
                    }
                    
                }
                else continue;
            }
            Console.WriteLine($"Nucleotides in given DNA: {nucleotidesDict["A"]}:{a}, {nucleotidesDict["C"]}:{c}, {nucleotidesDict["G"]}:{g}, {nucleotidesDict["T"]}:{t}");
            
        }

        public static void NucleotideCountTest(){
            Console.WriteLine("\n---NucleotidesCount---");
            NucleotideCounter("ACCTAGAGTT"); //3,2,2,3
        }


    }
