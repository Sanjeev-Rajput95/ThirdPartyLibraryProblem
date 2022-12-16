using CsvHelper;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DataHandling
{
    public class CSVHandler
    {
        public static void ImplementCSVDataHandling()
        {
            string importFilePath = "C:/Bridgelabz/ThirdPartyLibraryProblem/ThirdPartyLibraryProblem/DataHandling/DataHandling/Address.csv";
            string exportFilePath = "C:/Bridgelabz/ThirdPartyLibraryProblem/ThirdPartyLibraryProblem/DataHandling/DataHandling/exportAddress.csv";

            // reading CSV file
            using (var reader = new StreamReader(importFilePath)) 
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<AddressData>().ToList();
                Console.WriteLine("Read data successful from addresses.csv,here are city ");
                foreach(AddressData addressData in records)
                {
                    Console.WriteLine("\t" + addressData.country);
                }
                Console.WriteLine("\n************** Now reading from csv file and write to csv file **********************");

                // writing csv file
                using (var writer = new StreamWriter(exportFilePath))
                using (var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csvExport.WriteRecords(records);
                }
            }
        }
        
    }
}
