using CsvHelper;
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace DataHandling
{
    public class ReadCSV_And_WriteJSON
    {
        public static void ImplementCSVToJSON()
        {
            string importFilePath = "C:/Bridgelabz/ThirdPartyLibraryProblem/ThirdPartyLibraryProblem/DataHandling/DataHandling/Address.csv";
            string exportFilePath = "C:/Bridgelabz/ThirdPartyLibraryProblem/ThirdPartyLibraryProblem/DataHandling/DataHandling/jsconfig1.json";

            // reading csv file
            using (var reader = new StreamReader(importFilePath))
            using(var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<AddressData>().ToList();
                Console.WriteLine("Read data successfully from addresses.csv, here are codes ");
                foreach(AddressData addressData in records)
                {
                    Console.WriteLine("\t" + addressData.phone);
                }
                Console.WriteLine("\n******************** Now reading from csv file and write to json*****************");

                // write data to json file
                JsonSerializer serializer = new JsonSerializer();
                using (StreamWriter sw = new StreamWriter(exportFilePath))
                using(JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, records);
                }
            }
        }
    }
}
