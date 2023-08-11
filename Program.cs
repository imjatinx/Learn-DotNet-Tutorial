namespace consoleCalc
{
    class Program
    {
        static void Greet(string name){
            System.Console.WriteLine("Good Morning " + name);
        }

        static int Average(int a, int b, int c, int d){
            return (a + b + c + d)/4;
        }

        static void Main(string[] args)
        {
            Greet("Rohan");
            int avg = Average(2,4,6,8);
            System.Console.WriteLine(avg);

            // Welcome 
            // Console.WriteLine("Hello Jatin");
            // Console.Write("Welcome to");
            // Console.WriteLine(" C# Tutorial");

            /**************/
            /* Data types */
            /**************/

            // int age = 23;
            // char section = 'A';
            // string name = "Jatin Gautam";
            // float height = 5.5F;
            // double weight = 63.5D;
            // bool isEligible = true;

            // System.Console.WriteLine(age);
            // System.Console.WriteLine(section);
            // System.Console.WriteLine(name);
            // System.Console.WriteLine(height);
            // System.Console.WriteLine(weight);
            // System.Console.WriteLine(isEligible);

            /***************/
            /* Typecasting */
            /***************/

            /*** Implicit ***/

            // int a = 5;
            // double b = a;
            // float c = 'b';
            // char d = '6';
            // int e = d;

            // System.Console.WriteLine(a);
            // System.Console.WriteLine(b);
            // System.Console.WriteLine(c);
            // System.Console.WriteLine(d);
            // System.Console.WriteLine(e);

            /*** Explicit ***/

            // int p = (int) 3.8;
            // double q = (double) 5.5;
            // float r = (float) q;

            // System.Console.WriteLine(p);
            // System.Console.WriteLine(q);
            // System.Console.WriteLine(r);

            /**********/
            /* Inputs */
            /**********/

            // System.Console.WriteLine("What is your Name?");
            // string myName = System.Console.ReadLine();

            // System.Console.WriteLine("How old are you?");
            // string myAge = System.Console.ReadLine();

            // System.Console.WriteLine("How many years to be a billionaire?");
            // int Years = Convert.ToInt32(System.Console.ReadLine());
            // System.Console.WriteLine("Hey " + myName + ", " + "You will be rich by : "+ (Convert.ToInt32(myAge) + 4));

            /*******************/
            /* String Fucntion */
            /*******************/

            /*** String Interpolation ***/

            // string str1 = Console.ReadLine();
            // string str2 = Console.ReadLine();
            // Console.WriteLine($"Your name is {str1}. You will get {str2} candies.");

            /*** String methods ***/

            // string str3 = "You are a good boy";

            // System.Console.WriteLine(str3.Length);
            // System.Console.WriteLine(str3.ToUpper());
            // System.Console.WriteLine(str3.ToLower());
            // System.Console.WriteLine(str3[5]);
            // System.Console.WriteLine(str3.IndexOf("You"));
            // System.Console.WriteLine(str3.IndexOf("good"));
            // System.Console.WriteLine(str3.Substring(5));

            // string str4 = "Hello, I am a \"full stack\" developer\nand I know that. \t Apne Baap ko mat sikha";

            // System.Console.WriteLine(str4);

            /*************************/
            /* Conditional Statement */
            /*************************/

            // System.Console.WriteLine("Enter Your Age : ");
            // int num = Convert.ToInt32(Console.ReadLine());

            /*** if/else if/else ***/

            // if (1 < num && num <= 12)
            // {
            //     System.Console.WriteLine("You are just born");
            // }
            // else if (13 < num && num < 18)
            // {
            //     System.Console.WriteLine("You are not eligible");
            // }
            // else if (100 >= num && num >= 18)
            // {
            //     System.Console.WriteLine("You are eligible");
            // }
            // else
            // {
            //     System.Console.WriteLine("Invalid Age!");
            // }

            /*** switch case ***/

            // switch (num)
            // {
            //     case int n when n > 1 && n <= 12:
            //         System.Console.WriteLine("You are just born");
            //         break;
            //     case int n when n > 13 && n < 18:
            //         System.Console.WriteLine("You are not eligible");
            //         break;
            //     case int n when n >= 18 && n <= 100:
            //         System.Console.WriteLine("You are eligible");
            //         break;
            //     default:
            //         System.Console.WriteLine("Invalid Age!");
            //         break;
            // }

            /*********/
            /* Loops */
            /*********/

            // System.Console.WriteLine("Enter any number to print its table ");
            // int num1 = Convert.ToInt32(Console.ReadLine());

            // System.Console.WriteLine("*************************************");

            /*** for loop ***/

            // for (int i = 0; i < 10; i++)
            // {
            //     System.Console.WriteLine(num1 * (i+1));
            // }

            /*** while loop ***/

            // int i = 0;
            // while (i < 10)
            // {
            //     System.Console.WriteLine(num1 * (i + 1));
            //     i++;
            // }

            /*** do while loop ***/

            // int i = 0;
            // do
            // {
            //     System.Console.WriteLine(num1 * (i + 1));
            //     i++;
            // } while (i < 10);

            // Console.ReadLine();
        }
    }
}