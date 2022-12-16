using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandling
{
    public class ReadJSON_And_WriteCSV
    {
        public static void ImplementJSONToCSV()
        {
            string importFilePath = "C:/Bridgelabz/ThirdPartyLibraryProblem/ThirdPartyLibraryProblem/DataHandling/DataHandling/jsconfig1.json";
            string exportFilePath = "C:/Bridgelabz/ThirdPartyLibraryProblem/ThirdPartyLibraryProblem/DataHandling/DataHandling/exportAddress.csv";

            IList<AddressData> addressData = JsonConvert.DeserializeObject<IList<AddressData>>(File.ReadAllText(importFilePath));

            Console.WriteLine("\n****************** Now reading from JSON file and write to CSV file****************");
            // writing csv file
            using(var writer = new StreamWriter(exportFilePath))
            using(var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csvExport.WriteRecords(addressData);
            }
        }
    }
}
