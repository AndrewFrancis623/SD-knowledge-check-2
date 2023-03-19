using KnowledgeCheck2;
using System.Diagnostics;
using System.Reflection;


namespace KnowledgeCheck2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Run GetAppInfo function to get info
            GetAppInfo();


            Console.WriteLine("How many records do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine()!);
            var recordList = new List<Record>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                //Populate the object's properties 
                var record = new Record();

                Console.WriteLine("What is the Name of the record? ");

                record.Name = Console.ReadLine();

                if (record.Name == "")
                {

                    Console.WriteLine("You did not enter a Name");
                    return;

                }
                Console.WriteLine("Who is the Author of the record? ");

                record.Author = Console.ReadLine();

                if (record.Author == "")
                {

                    Console.WriteLine("Entry not Valid");
                    return;

                }
                Console.WriteLine("Enter the year the record was made: ");
                record.Year = Convert.ToInt32(Console.ReadLine());

                recordList.Add(new Record()
                {
                    Name = record.Name,
                    Author = record.Author,
                    Year = record.Year,
                });


            }
            //display list to screen
            Console.WriteLine("Records:");

            foreach (var record in recordList)
            {
                Console.WriteLine(" Name: " + record.Name + ", Author:  " + record.Author + ", Year: " + record.Year);
            }
            Console.ReadKey();


        }

        static void GetAppInfo()
        {
           
            string appName = "BIG CITY RECORDS CORP. RECORD LOG";
            string appVersion = "1.0";
            string appAuthor = "Andrew Francis";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset Color
            Console.ResetColor();

        }
    }
}