namespace DataHandling
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************** WELCOME TO THIRD PARTY LIBRARY********************");

            // UC1
            CSVHandler.ImplementCSVDataHandling();
            // UC2
            ReadCSV_And_WriteJSON.ImplementCSVToJSON();
            // UC3
            ReadJSON_And_WriteCSV.ImplementJSONToCSV();

        }
    } 
}