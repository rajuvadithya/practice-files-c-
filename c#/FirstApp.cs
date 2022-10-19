using System;
using System.Data;

namespace FirstApp

{
    class Program
    {

        static void Main(string[] args)


        {
            
            {
                //  Console.WriteLine("HelloWorld");
                //  Console.ReadLine();


                //int a, b, c;
                //a = 10;
                //b = 20;
                //c = a + b;
                //Console.WriteLine("The Sum Of {0} and {1} is {2}",a,b,c);


                //int a, b, c;
                //a = int.Parse(Console.ReadLine());
                //b = int.Parse("50");
                //c = a + b;
                //Console.WriteLine("The Sum Of {0} and {1} is {2}",a,b,c); 
            }


            //int a = 10;
            //int b = 20;
            //if (a > b)
            //{
            //    Console.WriteLine("{0} is Greater", a);

            //}    
            //else
            //{
            //    Console.WriteLine("{0} is Greater",b);
            //}



            //int a = 10;
            //int b = 20;
            //int c = 30;
            //if (a > b && a > c)
            //{
            //    Console.WriteLine("{0} is Greater", a);

            //}
            //else
            //{
            //    if (b > a && b > c)
            //    {
            //        Console.WriteLine("{0} is Greater", b);
            //    }
            //    else
            //    {
            //        Console.WriteLine(("{0} is Greater", c);
            //    }
            //}



            //    int a = 10;
            //    int b = 20;
            //    int opt;

            //L: Console.WriteLine("1.Add 2.Mul 3.Sub 4.Exit");
            //    opt = int.Parse(Console.ReadLine());

            //    switch (opt)
            //    {
            //        case 1:
            //            Console.WriteLine("Addition is " + (a + b));
            //            break;
            //        case 2:
            //            Console.WriteLine("multiplication is " + (a * b));
            //            break;
            //        case 3:
            //            Console.WriteLine("sub is " + (a - b));
            //            break;
            //        case 4:
            //            break;
            //        default:
            //            Console.WriteLine("Invalid Option !");
            //        goto L; ;





            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Raju");
            //}

            ////6 * 1 = 6
            ////6 * 2 = 12
            //int n = 6;
            //for (int i = 1; i <=10; i++)
            //{
            //    Console.WriteLine("{0}  *  {1}  =  {2}", n, i, n * i);
            //}
            //Console.WriteLine("----------");
            ////int n = 6;
            //for (int i = 10; i >=1; i--)
            //{
            //    Console.WriteLine("{0}  *  {1}  =  {2}", n, i, n * i);
            //}

            //int n = 236457;
            //sum=10
            //r=n%10=7
            //sum =sum +r=7
            //n=n/10=236

            //r=n%10=6
            //sum =sum +r=13
            //n=n/10=23

            //r=n%10=3
            //sum =sum +r=16
            //n=n/10=2

            //r=n%10=2
            //sum =sum +r=18
            //n=n/10=0

            //int sum = 0;
            //int r = 0;
            //while (n!=0)
            //{
            //    r = n % 10;
            //    sum = sum + r;
            //    n = n / 10;
            //}
            //Console.WriteLine("Sum is "+sum);
            //int i;
            //do
            //{
            //    i = int.Parse(Console.ReadLine());
            //} while (i!=0);

            //for(; ; )
            //{
            //    Console.Write("Raju");
            //}

            //while(true)
            //{
            //    Console.Write("Raju"); 
            //} 



            #region Arrays
            // Console.ReadLine();

            //int[] myArray = new int[5];
            //myArray[0] = 78;
            //myArray[1] = myArray[2] = 34;
            //myArray[3] = myArray[0] + myArray[1];
            //myArray[4] = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Values:");
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    myArray[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Values are:");
            //for(int i=0;i<myArray.Length;i++)
            //{
            //    Console.WriteLine(myArray[i]);
            //}

            //Console.WriteLine("Values Using foreach");
            //foreach(int k in myArray)
            //{
            //    Console.WriteLine(k);
            //}

            //Console.WriteLine("Values Using foreach >100");
            //foreach (int k in myArray)
            //{
            //    if(k>100)
            //    Console.WriteLine(k);
            //}

            //Sum of all the elements
            //int sum = 0;
            //foreach (var item in myArray)
            //{
            //    sum = sum + item; //sum += item;
            //}
            //Console.WriteLine("Sum of all the elements is " + sum);


            //Largest element
            //int largest = myArray[0];
            //foreach (var item in myArray)
            //{
            //    if(item>largest)
            //    {
            //        largest = item;
            //    }
            //}
            //Console.WriteLine("Largest is " + largest);

            //Array.Sort(myArray);
            //Array.Reverse(myArray);
            //Console.WriteLine("Elements after sorting");
            //foreach (var item in myArray)
            //{
            //    Console.WriteLine(item);
            //}


            //int index = Array.IndexOf(myArray, 100);
            //Console.WriteLine("Position of Element is "+(index+1));

            //string[,] Contacts = new string[3, 2];
            //Contacts[0, 0] = "Peter";
            //Contacts[0, 1] = "1234567890";

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Contacts[i, j] = Console.ReadLine();
            //    }
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Console.Write(Contacts[i, j]+ "  ");                    
            //    }
            //    Console.WriteLine();
            //} 
            #endregion

            #region Struct
            //Student S;
            //S.Sid = 100;
            //S.Name = "Raju";
            //S.Avg = 89.89;

            //Console.WriteLine("Sid : {0} Name:{1} Avg:{2}",S.Sid,S.Name,S.Avg);


            //Student[] S = new Student[3];
            //for (int i = 0; i < S.Length; i++)
            //{
            //    Console.WriteLine("Enter {0} Record",(i+1));
            //    S[i].Sid = int.Parse(Console.ReadLine());
            //    S[i].Name = Console.ReadLine();
            //    S[i].Avg = double.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("All Students");
            //foreach (var item in S)
            //{
            //    Console.WriteLine("Sid : {0} Name:{1} Avg:{2}", item.Sid, item.Name, item.Avg);
            //}

            //Console.WriteLine("1st Division students");
            //foreach (var item in S)
            //{
            //    if (item.Avg >= 60)
            //        Console.WriteLine("Sid : {0} Name:{1} Avg:{2}", item.Sid, item.Name, item.Avg);
            //} 
            #endregion

            #region var Vs dynamic
            //int i;
            //i = 10;

            //var i = 10;
            //i = "Raju";

            //dynamic x;

            //x = "Raju";
            //Console.WriteLine(x);

            //x = 23.8;
            //Console.WriteLine(x);

            //x = S;
            //Console.WriteLine("Sid : {0} Name:{1} Avg:{2}", x.Sid, x.Name, x.Avg); 
            #endregion




         
            Console.ReadLine();



        }

        
    }
}

   
