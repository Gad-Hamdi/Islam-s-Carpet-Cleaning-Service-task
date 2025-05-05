namespace Islam_s_Carpet_Cleaning_Service_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom at Islam's Carpet Cleaning Service \n");
            Console.WriteLine("we have an ofer for you  \n");
            Console.WriteLine("$25 per small carpet  and $35 per large one and only Sales tax rate is 6%\n");
            Console.WriteLine("How many small carpet you have ? \n");
            double smallCarpetNumber =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many large carpet you have ? \n");
            double largeCarpetNumber =Convert.ToDouble(Console.ReadLine());
            double salary =(smallCarpetNumber*25)+(largeCarpetNumber*35);
            double tax = (salary * 6) / 100;
            double totalEstimate = salary + tax;
            Console.WriteLine($"Total estimate: {totalEstimate} \n");
            Console.WriteLine("This estimate is valid for 30 days  ");

        }
    }
}
