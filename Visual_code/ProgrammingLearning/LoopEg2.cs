using System;

    public class LoopEg2
    {
        public static void Main()
        {
            double start_no, end_no;

            Console.Write("Enter start number : ");
            start_no = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter end number : ");
            end_no = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The number is divisible by 8 and 5");
            for (double i = start_no; i <= end_no; i++)               
            {
                if (i % 8 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("The number is divisible by only 8");
            while (start_no <= end_no)
            {
                if (start_no % 8 == 0)
                {
                    Console.WriteLine(start_no);  
                }
                else if (start_no > end_no)
                {
                    break;
                }
                start_no++;
            }


            Console.WriteLine("The number is divisible by only 5.");
            while (start_no <= end_no)
            {
                if (start_no % 5 == 0)
                {
                    Console.WriteLine(start_no);  
                }
                else if (start_no > end_no)
                {
                    break;
                }
                start_no++;
            }
        }
    }
