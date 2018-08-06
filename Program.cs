﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Owner\Desktop\ingredients.txt";

            string[] allLines = File.ReadAllLines(path);


            Dictionary<string, int> hash = new Dictionary<string, int>();
            {
                foreach (string line in allLines)
                {
                    var test = line.Split(',');

                    hash.Add(test[0], int.Parse(test[1]));
                }

                Console.WriteLine("order a roast beef sandwich");
                int x = int.Parse(Console.ReadLine());

                switch (x)
                {
                    case 1:
                        --hash["rb"];
                        --hash["white bread"];
                        --hash["cheese"];
                        --hash["lettuce"];
                        --hash["tomoato"];
                        --hash["onion"];
                        --hash["mayo"];


                        break;

                    default: break;
                }
            }
            using (StreamWriter writer = new StreamWriter(path))
                foreach (var hashRW in hash)
                {
                    writer.WriteLine($"{hashRW.Key}, {hashRW.Value}");
                }
        }
    }
}
                   
            
            

              
    