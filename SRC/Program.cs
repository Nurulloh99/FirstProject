using System.Collections.Specialized;
using System.Diagnostics.Metrics;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Threading.Channels;

namespace second
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /** #1
            Console.Write("Son kiriting >> ");
            var number = Convert.ToInt32(Console.ReadLine());

            var ones = number % 10;
            var tens = number % 1000 % 100 / 10;
            var hundreds = number % 1000 / 100;
            var thousands = number / 1000;

            var result = (thousands * 1000) + (hundreds * 100) + (ones * 10) + tens;
            Console.WriteLine(result);
            Main(args);
            */




            /// _________________________________________________________________________________________




            /** #2
            Console.Write("Son kiriting >> ");
            var number = Convert.ToInt32(Console.ReadLine());

            var ones = number % 10;
            var tens = number % 1000 % 100 / 10;
            var hundreds = number % 1000 / 100;

            var result = (hundreds * 10) + (tens * 100) + ones;
            Console.WriteLine(result);
            Main(args);
            */



            /// _________________________________________________________________________________________




            /** #3
            Console.Write("Son kiriting >> ");
            var number = Convert.ToInt32(Console.ReadLine());

            var ones = number % 10;
            var tens = number % 1000 % 100 / 10;
            var hundreds = number % 1000 / 100;
            var thousands = number / 1000;

            var result = (tens * 1000) + (hundreds * 100) + (thousands * 10) + ones;
            Console.WriteLine(result);
            Main(args);
            */





            /// _________________________________________________________________________________________






            /** #4
            Console.Write("GB ni kiriting >> ");
            var Gbayt = Convert.ToInt32(Console.ReadLine());

            var Mbayt = Gbayt * 1024;
            Console.WriteLine("Bu >> " + Mbayt + " hisoblanadi.");
            Console.WriteLine();
            Main(args);
            */




            /// _________________________________________________________________________________________






            /** #5
            Console.Write("GB ni kiriting >> ");
            var Gbayt = Convert.ToInt32(Console.ReadLine());

            var Bit = Gbayt * 8589934592;
            Console.WriteLine("Bu >> " + Bit + " bit hisoblanadi.");
            Console.WriteLine();
            Main(args);
            */





            /// _________________________________________________________________________________________





            /** #6
            Console.Write(" Gbayt ni kiritning >> ");
            var Gbayt = Convert.ToInt32(Console.ReadLine());

            var Tbayt = Gbayt / 1024;

            Console.WriteLine( " Natija >> " + Tbayt + " terrabayt!");
            Console.WriteLine();
            Main(args);
            */



            /// _________________________________________________________________________________________




            /** #7
            Console.Write("Gbaytni kiriting >> ");
            var microCardSize = Convert.ToInt32(Console.ReadLine());

            var moviesAmount = microCardSize / 2;

            Console.WriteLine("Bu fleshkaga " + moviesAmount + " ta kino sig'adi.");
            Console.WriteLine();
            Main(args);
            */




            /// _________________________________________________________________________________________




            /** #8
            Console.Write("Son kiriting >> ");
            var number = Convert.ToInt32(Console.ReadLine());

            var additional = number * number * number;
            additional = additional * additional;

            Console.WriteLine(additional);
            Console.WriteLine();
            Main(args);
            */




            /// _________________________________________________________________________________________




            /** #9
            Console.Write("Son kiriting >> ");
            var number = Convert.ToInt32(Console.ReadLine());

            var additional = number * number;
            additional = additional * additional;
            additional = additional * additional;

            Console.WriteLine("Natija >> " + additional);
            Console.WriteLine();
            Main(args);
            */




            /// _________________________________________________________________________________________





            /** #10
            Console.Write("Son kiriting >> ");
            var number = Convert.ToInt32(Console.ReadLine());

            var trueFalse = false;

            if (number % 2 == 0)
            {
                trueFalse = true;
            }
            else
            {
                trueFalse = false;
            }
            Console.WriteLine(trueFalse);
            Console.WriteLine();
            Main(args);
            */





            /// _________________________________________________________________________________________





            /** #11
            Console.Write("Son kiriting >> ");
            var number = Convert.ToInt32(Console.ReadLine());

            var trueFalse = false;

            if (number % 2 == 0)
            {
                trueFalse = true;
            }
            else
            {
                trueFalse = false;
            }
            Console.WriteLine(trueFalse);
            Console.WriteLine();
            Main(args);
            */





            /// _________________________________________________________________________________________




            /** #12
            Console.Write("Son kiriting >> ");
            var number = Convert.ToInt32(Console.ReadLine());

            var trueFalse = false;

            if (number >= 10 && number <= 99)
            {
                trueFalse = true;
            }
            else
            {
                trueFalse = false;
            }
            Console.WriteLine(trueFalse);
            Console.WriteLine();
            Main(args);
            */





            /// _________________________________________________________________________________________





            /** #13
            Console.Write("Son kiriting >> ");
            var number = Convert.ToInt32(Console.ReadLine());

            var trueFalse = false;

            if (number >= 1000 && number <= 9999)
            {
                trueFalse = true;
            }
            else
            {
                trueFalse = false;
            }
            Console.WriteLine(trueFalse);
            Console.WriteLine();
            Main(args);
            */





            /// _________________________________________________________________________________________





            /** #14
            Console.Write("Son kiriting >> ");
            var number = Convert.ToInt32(Console.ReadLine());

            var trueFalse = false;

            if (number >= 10 && number <= 99 && number % 2 == 0)
            {
                trueFalse = true;
            }
            else
            {
                trueFalse = false;
            }
            Console.WriteLine(trueFalse);
            Console.WriteLine();
            Main(args);
            */




            /// _________________________________________________________________________________________





            /** #15
            Console.Write("Son kiriting >> ");
            var number = Convert.ToInt32(Console.ReadLine());

            var trueFalse = false;

            if(number % 2 == 0 && number >= 1000 && number <= 9999)
            {
                trueFalse = true;
            }
            else
            {
                trueFalse = false;
            }

            Console.WriteLine(trueFalse);
            Console.WriteLine();
            Main(args);
            */




            /// _________________________________________________________________________________________




            /** #16
            Console.Write("Birinchi sonni kiriting >> ");
            var firstDigit = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ikkinchi sonni kiriting >> ");
            var secondDigit = Convert.ToInt32(Console.ReadLine());

            var trueFalse = false;

            if(firstDigit % 2 != 0 && secondDigit % 2 != 0)
            {
                trueFalse = true;
            }
            else
            {
                trueFalse = false;
            }
            Console.WriteLine(trueFalse);
            Console.WriteLine();
            Main(args);
            */





            /// _________________________________________________________________________________________






            /** #17
            Console.Write("Birinchi sonni kiriting >> ");
            var firstDigit = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ikkinchi sonni kiriting >> ");
            var secondDigit = Convert.ToInt32(Console.ReadLine());

            var trueFalse = false;

            if (firstDigit % 2 != 0 && secondDigit % 2 != 0)
            {
                trueFalse = true;
            }
            else
            {
                trueFalse = false;
            }
            Console.WriteLine(trueFalse);
            Console.WriteLine();
            Main(args);
            */




            /// _________________________________________________________________________________________





            /** #18
            Console.Write("Birinchi sonni kiriting >> ");
            var firstDigit = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ikkinchi sonni kiriting >> ");
            var secondDigit = Convert.ToInt32(Console.ReadLine());

            var trueFalse = false;

            if (firstDigit % 2 != 0 && secondDigit % 2 != 0 && firstDigit >= 10 && firstDigit <= 99 && secondDigit >= 10 && secondDigit <= 99)
            {
                trueFalse = true;
            }
            else
            {
                trueFalse = false;
            }
            Console.WriteLine(trueFalse);
            Console.WriteLine();
            Main(args);
            */




            /// _________________________________________________________________________________________




            /** #19
            Console.Write("Sonni kiriting >> ");
            var natDigit = Convert.ToInt32(Console.ReadLine());

            if (natDigit <= 99 && natDigit >= 10)
            {
                var ones = natDigit % 10;
                var tens = natDigit / 10;

                var trueFalse = false;

                if (ones == tens)
                {
                    trueFalse = true;
                }

                Console.WriteLine("Natija >> " + trueFalse);
                Console.WriteLine();
                Main(args);
            }
            else
            {
                Main(args);
            }
            */





            /// _________________________________________________________________________________________






            /** #20
            Console.Write("Birinchi sonni kiriting >> ");
            var number = Convert.ToInt32(Console.ReadLine());

            var ones = number % 10;
            var tens = number / 10;

            var trueFalse = false;

            if(ones * tens >= 20)
            {
                trueFalse = true;
            }
            Console.WriteLine("Natija >> " + trueFalse);
            Console.WriteLine();
            Main(args);
            */





            /// _________________________________________________________________________________________




            /** #21
            Console.Write("Son kiriting >> ");
            var number = Convert.ToInt32(Console.ReadLine());

            var ones = number % 10;
            var tens = number / 10;

            var trueFalse = false;

            if(ones >= 5 && tens >= 5)
            {
                trueFalse = true;
            }

            Console.WriteLine("Natija >> " + trueFalse);
            Console.WriteLine();
            Main(args);
            */





            /// _________________________________________________________________________________________




            /** #22
            Console.Write("Son kiriting >> ");
            var number = Convert.ToInt32(Console.ReadLine());

            var trueFalse = false;

            if(number % 7 == 0)
            {
                trueFalse = true;
            }

            Console.WriteLine("Natija >> " + trueFalse);
            Console.WriteLine();
            Main(args);
            */




            /// _________________________________________________________________________________________



            /** #23
            Console.Write("Son kiriting >> ");
            var number = Convert.ToInt32(Console.ReadLine());

            var trueFalse = false;

            if(number % 7 == 0 && number % 9 == 0)
            {
                trueFalse = true;
            }
            Console.WriteLine("Natija >> " + trueFalse);
            Console.WriteLine();
            Main(args);
            */




            /// _________________________________________________________________________________________




            /** #24
            Console.Write("Son kiriting >> ");
            var number = Convert.ToInt32(Console.ReadLine());

            var trueFalse = false;

            if(number % 5 != 0)
            {
                trueFalse = true;
            }
            Console.WriteLine("Natija >> " + trueFalse);
            Console.WriteLine();
            Main(args);
            */





            /// _________________________________________________________________________________________





            /** #25
            Console.Write("A son kiriting >> ");
            var a_Number = Convert.ToInt32(Console.ReadLine());

            Console.Write("B son kiriting >> ");
            var b_Number = Convert.ToInt32(Console.ReadLine());

            var trueFalse = false;

            if (a_Number > b_Number)
            {
                trueFalse = true;
            }

            Console.WriteLine("Natija >> " + trueFalse);
            Console.WriteLine();
            Main(args);
            */




            /// _________________________________________________________________________________________




            /** #26
            Console.Write("1 chi sonni kiriting >> ");
            var firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("2 chi sonni kiriting >> ");
            var secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("3 chi sonni kiriting >> ");
            var thirdNumber = Convert.ToInt32(Console.ReadLine());

            var trueFalse = false;

            if (firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                trueFalse = true;
            }

            Console.WriteLine("Natija >> " + trueFalse);
            Console.WriteLine();
            Main(args);
            */




            /// _________________________________________________________________________________________




            /** #27
            Console.Write("1 chi sonni kiriting >> ");
            var firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("2 chi sonni kiriting >> ");
            var secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("3 chi sonni kiriting >> ");
            var thirdNumber = Convert.ToInt32(Console.ReadLine());

            var trueFalse = false;

            if (secondNumber < firstNumber && secondNumber < thirdNumber)
            {
                trueFalse = true;
            }

            Console.WriteLine("Natija >> " + trueFalse);
            Console.WriteLine();
            Main(args);
            */





            /// _________________________________________________________________________________________




            /** #28
            Console.Write("1 chi sonni kiriting >> ");
            var firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("2 chi sonni kiriting >> ");
            var secondNumber = Convert.ToInt32(Console.ReadLine());

            var trueFalse = false;

            if(firstNumber == secondNumber * 2)
            {
                trueFalse = true;
            }

            Console.WriteLine("Natija >> " + trueFalse);
            Console.WriteLine();
            Main(args);
            */





            /// _________________________________________________________________________________________






            /** #29
            Console.Write("1 chi sonni kiriting >> ");
            var firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("2 chi sonni kiriting >> ");
            var secondNumber = Convert.ToInt32(Console.ReadLine());

            var trueFalse = false;

            if (secondNumber == firstNumber * 5)
            {
                trueFalse = true;
            }

            Console.WriteLine("Natija >> " + trueFalse);
            Console.WriteLine();
            Main(args);
            */




            /// _________________________________________________________________________________________




            /** #30
            Console.Write("1 chi sonni kiriting >> ");
            var firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("2 chi sonni kiriting >> ");
            var secondNumber = Convert.ToInt32(Console.ReadLine());

            var trueFalse = false;

            if(firstNumber == secondNumber * 4 || secondNumber == firstNumber * 4)
            {
                trueFalse = true;  
            }

            Console.WriteLine("Natija >> " + trueFalse);
            Console.WriteLine();
            Main(args);
            */




            /// _________________________________________________________________________________________



            /** #31
            Console.Write("1 chi sonni kiriting >> ");
            var firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("2 chi sonni kiriting >> ");
            var secondNumber = Convert.ToInt32(Console.ReadLine());


            if(firstNumber > secondNumber)
            {
                Console.WriteLine("Natija >> " + firstNumber);
            }
            else
            {
                Console.WriteLine("Natija >> " + secondNumber);
            }
            Console.WriteLine();
            Main(args);
            */






            /// _________________________________________________________________________________________




            /** #32
            Console.Write("1 chi sonni kiriting >> ");
            var firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("2 chi sonni kiriting >> ");
            var secondNumber = Convert.ToInt32(Console.ReadLine());

            if(firstNumber > secondNumber)
            {
                Console.WriteLine("Natija >> " + secondNumber);
            }
            else
            {
                Console.WriteLine("Natija >> " + firstNumber);
            }
            Console.WriteLine();
            Main(args);
            */





            /// _________________________________________________________________________________________





            /** #33
            Console.Write("1 chi sonni kiriting >> ");
            var firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("2 chi sonni kiriting >> ");
            var secondNumber = Convert.ToInt32(Console.ReadLine());

            var addition = 0;

            if(firstNumber >= 10 && firstNumber <= 99 && secondNumber <= 99 && secondNumber >= 10)
            {
                addition = firstNumber + secondNumber;
            }
            else
            {
                addition = firstNumber * secondNumber;
            }
            Console.WriteLine("Natija >> " + addition);
            Console.WriteLine();
            Main(args);
            */





            /// _________________________________________________________________________________________




            /** #34
            Console.Write("1 chi sonni kiriting >> ");
            var firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("2 chi sonni kiriting >> ");
            var secondNumber = Convert.ToInt32(Console.ReadLine());

            var result = 0;

            if(firstNumber % 2 == 0 && secondNumber % 2 == 0)
            {
                result = firstNumber + secondNumber;
            }
            else
            {
                result = firstNumber * secondNumber;
            }

            Console.WriteLine("Natija >> " + result);
            Console.WriteLine();
            Main(args);
            */





            /// _________________________________________________________________________________________




            /** #35
            Console.Write("1 chi sonni kiriting >> ");
            var firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("2 chi sonni kiriting >> ");
            var secondNumber = Convert.ToInt32(Console.ReadLine());

            var result = 0;

            if (firstNumber % 2 != 0 && secondNumber % 2 != 0)
            {
                result = firstNumber * secondNumber;
                Console.WriteLine("Natija >> " + result);
            }
            else
            {
                Console.WriteLine("1 chi son >> " + firstNumber);
                Console.WriteLine("2 chi son >> " + secondNumber);
            }

            Console.WriteLine();
            Main(args);
            */





            /// _________________________________________________________________________________________




            /** #36
            Console.Write("1 chi son >> ");
            var firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("2 chi son >> ");
            var secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("3 chi son >> ");
            var thirdNumber = Convert.ToInt32(Console.ReadLine());

            var counter = 0;

            if(firstNumber % 2 != 0)
            {
                counter++;
            }
            if(secondNumber % 2 != 0)
            {
                counter++;
            }
            if(thirdNumber % 2 != 0)
            {
                counter++;
            }
            Console.WriteLine();
            Console.WriteLine("Natija >> " + counter + " ta toq son");
            Console.WriteLine();
            Main(args);
            */






            /// _________________________________________________________________________________________




            /** #37
            Console.Write("4 xonali son kiriting >> ");
            var number = Convert.ToInt32(Console.ReadLine());


            var ones = number % 10;
            var tens = number % 1000 % 100 / 10;
            var hundreds = number % 1000 / 100;
            var thousands = number / 1000;

            var counter = 0;

            if(ones % 2 == 0)
            {
                counter++;
            }
            if(tens % 2 == 0)
            {
                counter++;
            }
            if(hundreds % 2 == 0)
            {
                counter++;
            }
            if(thousands % 2 == 0)
            {
                counter++;
            }
            Console.WriteLine();
            Console.WriteLine("Natija >> " + counter + " ta juft son");
            Console.WriteLine();
            Main(args);
            */






            /// _________________________________________________________________________________________




            /** #38
            Console.Write("1 chi sonni kiriting >> ");
            var firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("2 chi sonni kiriting >> ");
            var secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("3 chi sonni kiriting >> ");
            var thirdNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("4 chi sonni kiriting >> ");
            var fourthNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("5 chi sonni kiriting >> ");
            var fifthNumber = Convert.ToInt32(Console.ReadLine());

            var counter = 0;

            if(firstNumber % 2 == 0)
            {
                counter++;
            }
            if(secondNumber % 2 == 0)
            {
                counter++;
            }
            if(thirdNumber % 2 == 0)
            {
                counter++;
            }
            if(fourthNumber % 2 == 0)
            {
                counter++;
            }
            if(fifthNumber % 2 == 0)
            {
                counter++;
            }
            Console.WriteLine();
            Console.WriteLine("Natija >> " + counter + " ta juft son bor!");
            Console.WriteLine();
            Main(args);
            */




            /// _________________________________________________________________________________________






            //Console.WriteLine("Enter your estimated informations about yourself below...");
            //Console.Write("Enter your age: ");
            //var age = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter your name: ");
            //var name = Console.ReadLine();

            //Console.WriteLine($"Result >> Your name is {name} and your age is {age}. Thanks for your informations that you provided with that above!!!");
            //Console.WriteLine();
            //Main(args);






            /// _________________________________________________________________________________________





            /**
            Ikki o'lchamlik massivning har bir ustunlarini alohida - alohida yig'indilarini, 
                va shu yig'indilardan eng kottasini alohida, 
                va shu eng kotta yigindini massivdagi ustun ko'rinishini alohida pasdan,
                va shu massivdagi hamma sonlarning yig'indisidan eng kottasini, va uning i va j indekslarini alohida - alohida,
                va shu massivning hamma sonlarning yig'indisidan eng kichigini, va uning i va j indekslarini alohida - alohida,
                va eng kotta yig'indi bilan massivdagi eng oxxirgi o'rinda joylashgan son blan o'rnining almashganini,
                va eng kichik yig'indi bilan massivdagi birinchi o'rinda joylashgan son blan o'rnining almashganini chiqarib beruvchi dastur tuzing!!!'
            */

            /**
            var rand = new Random();
            Console.Write("Massivni o'lchamini kiriting >> ");
            var number = Convert.ToInt32(Console.ReadLine());
            var arr = new int[number, number];
            // int[,] arr = new int[number, number];
            Console.WriteLine();
            for(int i = 0; i < number; i++)
            {
                for(int j = 0; j < number; j++)
                {
                    arr[i, j] = rand.Next(0, 10);
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();

            var maxx = 0;
            var index_i = 0;

            for(int i = 0; i < number; i++)
            {
                var summary = 0;
                for(int j = 0; j < number; j++)
                {
                    summary += arr[j, i];
                }
                if(maxx < summary)
                {
                    maxx = summary;
                    index_i = i;
                }
                Console.WriteLine($"  {i} chi ustundagi raqamlar yig'indisi >> {summary}.\n\n");
            }

            Console.WriteLine($"Eng kotta yig'indi >> {maxx}.\n");
            for(int i = 0; i < number; i++)
            {
                Console.Write("  ");
                Console.WriteLine(arr[i, index_i]);
                
            }
            Console.WriteLine();
            Console.WriteLine();

            for(int i = 0; i < number; i++)
            {
                for(int j = 0; j < number; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            var maxx1 = arr[0, 0];
            var mini = arr[0, 0];
            var index_i1 = 0;
            var index_j1 = 0;
            var index_i2 = 0;
            var index_j2 = 0;

            for(int i = 0; i < number; i++)
            {
                for(int j = 0; j < number; j++)
                {
                    if(maxx1 < arr[i, j])
                    {
                        maxx1 = arr[i, j];
                        index_i1 = i;
                        index_j1 = j;
                    }
                    if(mini > arr[i, j])
                    {
                        mini = arr[i, j];
                        index_i2 = i;
                        index_j2 = j;
                    }
                }
            }
            Console.WriteLine("  Eng kotta son >> " + maxx1);
            Console.WriteLine("  Eng kotta sonning satr bo'yicha joylashgan o'rni >> " + index_i1);
            Console.WriteLine("  Eng kotta sonning ustun bo'yicha joylashgan o'rni >> " + index_j1);
            Console.WriteLine();
            Console.WriteLine("  Eng kichik son >> " + mini);
            Console.WriteLine("  Eng kichik sonning satr bo'yicha joylashgan o'rni >> " + index_i2);
            Console.WriteLine("  Eng kichik sonning ustun bo'yicha joylashgan o'rni >> " + index_j2);
            Console.WriteLine();

            var helperMax = arr[index_i1, index_j1];
            arr[index_i1, index_j1] = arr[number - 1, number - 1];
            arr[number - 1, number - 1] = helperMax;

            var helperMin = arr[index_i2, index_j2];
            arr[index_i2, index_j2] = arr[0, 0];
            arr[0, 0] = helperMin;


            for(int i = 0; i < number; i++)
            {
                for(int j = 0; j < number; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(); 
            Console.WriteLine();
            Main(args);
            */

            string str = "Nurulloh";
            Console.WriteLine($"Kiriting >> {str}");
            //Console.WriteLine(str.Remove(0, 3));
            //str.Substring(0, 3);
            str.IndexOf(str, 0, 3);
            Console.WriteLine(str);



            


            
        }
    }
}
