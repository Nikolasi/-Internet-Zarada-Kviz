using System;
using System.Collections.Generic;
using System.Text;

namespace Internet_Zarada_Kviz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Internet Zarada Kviz";
            
            // napravicemo jesnostavan kviz sa koriscenjam if else statements

            string answer1 = "da";
            string answer2 = "ne";
            string userInput1;
            string userInput2;
            int correctAnsweres = 0;

            Console.WriteLine("Odgovorite na sledeca pitanja sa da ili ne:");
            Console.WriteLine();

            // prvo pitanje
            Console.Write("Da li je moguce zaraditi od YouTub-a ,ako se taj posao ne voli?");
            userInput1 = Console.ReadLine();
            if (userInput1 == answer1)
            {
                Console.WriteLine("Tacan Odgovor");
                correctAnsweres++;
            }
            else
            {
                Console.WriteLine("Netacan Odgovor. The correct answer is {0}", answer1);
            }
            Console.WriteLine();
            

            //drugo piranje

            Console.WriteLine("Da li je moguce postati popularan bloger sasvim slucajno?");
            userInput2 = Console.ReadLine();
            if (userInput2 == answer2)
            {
                Console.WriteLine("Tacan Odgovor");
                correctAnsweres++;
            }
            else
            {

                Console.WriteLine("Netacan Odgovor. The correct answer is {0}", answer2);
            }
            Console.WriteLine();

            
            
            //trece pitanje
            Console.WriteLine("Da li ce ljudi da kliknu na reklamu ,a da pri tom znaju da ce te vi od toga zaraditi?");
            userInput2 = Console.ReadLine();
            if (userInput2 == answer2)
            {
                Console.WriteLine("Tacan Odgovor");
                correctAnsweres++;
            }
            else
            {

                Console.WriteLine("Netacan Odgovor. The correct answer is {0}", answer2);
            }
            Console.WriteLine();

           


            //cetvrto pitanje
            Console.WriteLine("Da li deca mogu da zaradjuju vise od odraslih na Internetu?");
            userInput1 = Console.ReadLine();
            if (userInput1 == answer1)
            {
                Console.WriteLine("Tacan Odgovor");
                correctAnsweres++;
            }
            else
            {
                Console.WriteLine("Netacan Odgovor. The correct answer is {0}", answer1);
            }
            Console.WriteLine();


            //peto pitanje
            Console.WriteLine("Da li su kriptovalute projekti vrhunskih strucnjaka?");
            userInput2 = Console.ReadLine();
            if (userInput2 == answer2)
            {
                Console.WriteLine("Tacan Odgovor");
                correctAnsweres++;
            }
            else
            {

                Console.WriteLine("Netacan Odgovor. The correct answer is {0}", answer2);
            }
            Console.WriteLine();



            // sesto pitanje
            Console.WriteLine("Da li hejteri mogu da upropaste neciju Internet Zaradu?");
            userInput1 = Console.ReadLine();
            if (userInput1 == answer1)
            {
                Console.WriteLine("Tacan Odgovor");
                correctAnsweres++;
            }
            else
            {
                Console.WriteLine("Netacan Odgovor. The correct answer is {0}", answer1);
            }
            Console.WriteLine();


            // sedmo pitanje
            Console.WriteLine("Da li su game developeri naj vise placeni?");
            userInput1 = Console.ReadLine();
            if (userInput1 == answer1)
            {
                Console.WriteLine("Tacan Odgovor");
                correctAnsweres++;
            }
            else
            {
                Console.WriteLine("Netacan Odgovor. The correct answer is {0}", answer1);
            }
            Console.WriteLine();


            // osmo pitanje
            Console.WriteLine("Da li ljudi dolaze na Internet samo kako bi zaradili novac?");
            userInput1 = Console.ReadLine();
            if (userInput1 == answer1)
            {
                Console.WriteLine("Tacan Odgovor");
                correctAnsweres++;
            }
            else
            {
                Console.WriteLine("Netacan Odgovor. The correct answer is {0}", answer1);
            }
            Console.WriteLine();


            // deveto pitanje
            Console.WriteLine("Da li su platni procesori jedini razlog zasto je Internet Zarada moguca?");
            userInput2 = Console.ReadLine();
            if (userInput2 == answer2)
            {
                Console.WriteLine("Tacan Odgovor");
                correctAnsweres++;
            }
            else
            {

                Console.WriteLine("Netacan Odgovor. The correct answer is {0}", answer2);
            }
            Console.WriteLine();



            // deseto pitanje
            Console.WriteLine("Da li je legalno kladjenje preko interneta?");
            userInput2 = Console.ReadLine();
            if (userInput2 == answer2)
            {
                Console.WriteLine("Tacan Odgovor");
                correctAnsweres++;
            }
            else
            {

                Console.WriteLine("Netacan Odgovor. The correct answer is {0}", answer2);
            }
            Console.WriteLine();

            // jedanaesto pitanje
            Console.WriteLine("Da li je legalno baviti se preprodajom virtuelnih predmeta kao i igara?");
            userInput2 = Console.ReadLine();
            if (userInput2 == answer2)
            {
                Console.WriteLine("Tacan Odgovor");
                correctAnsweres++;
            }
            else
            {

                Console.WriteLine("Netacan Odgovor. The correct answer is {0}", answer2);
            }
            Console.WriteLine();



            // dvanaesto pitanje
            Console.WriteLine("Da li je naj jednostavniji nacin zaraditi preko referala?");
            userInput1 = Console.ReadLine();
            if (userInput1 == answer1)
            {
                Console.WriteLine("Tacan Odgovor");
                correctAnsweres++;
            }
            else
            {
                Console.WriteLine("Netacan Odgovor. The correct answer is {0}", answer1);
            }
            Console.WriteLine();



            // trinaesto pitanje
            Console.WriteLine("Da li bi ljudi naj vise voleli da zaradjuju od donacija?");
            userInput1 = Console.ReadLine();
            if (userInput1 == answer1)
            {
                Console.WriteLine("Tacan Odgovor");
                correctAnsweres++;
            }
            else
            {
                Console.WriteLine("Netacan Odgovor. The correct answer is {0}", answer1);
            }
            Console.WriteLine();



            // cetrnaesto pitanje
            Console.WriteLine("Da li je Internet Kurvanje legalno?");
            userInput2 = Console.ReadLine();
            if (userInput2 == answer2)
            {
                Console.WriteLine("Tacan Odgovor");
                correctAnsweres++;
            }
            else
            {

                Console.WriteLine("Netacan Odgovor. The correct answer is {0}", answer2);
            }
            Console.WriteLine();



            // petnaesto pitanje
            Console.WriteLine("Da li treba paziti sa kim na Internetu radimo(saradjujemo)?");
            userInput1 = Console.ReadLine();
            if (userInput1 == answer1)
            {
                Console.WriteLine("Tacan Odgovor");
                correctAnsweres++;
            }
            else
            {
                Console.WriteLine("Netacan Odgovor. The correct answer is {0}", answer1);
            }
            Console.WriteLine();
            Console.WriteLine("Tacan Odgovor {0}", correctAnsweres);
            Console.ReadLine();



        }
    }
}

   
 