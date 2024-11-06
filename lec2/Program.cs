namespace lec2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            #region lec2 task1 
            float num1, num2;
            //float calc;

            Console.WriteLine("this program to make  *  / + -  for two number  ");
            Console.WriteLine("Enter Number 1 ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2 ");
            num2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"\n this is mult operation \n {num1}*{num2}= {num1 * num2}");
            Console.WriteLine($"\n this is div operation \n {num1}/{num2}= {num1 / num2}");
            Console.WriteLine($"\n this is sum  operation \n {num1}+{num2}= {num1 + num2}");
            Console.WriteLine($"\n this is sub operation \n {num1}-{num2}= {num1 - num2}");

            #endregion



            #region lec2 task2

            string fname, lname, fullName;
            Console.WriteLine("\n \n this program to print full name  ");
            Console.WriteLine("Enter First Name ");

            fname= Console.ReadLine();

           
            Console.WriteLine("Enter Last Name ");
            lname = Console.ReadLine();

            fullName = fname + lname;

            Console.WriteLine($"your full name is :  {fullName}");
            Console.WriteLine($"your length of full name is :  {fullName.Length}");


            #endregion

        }
    }
}
