using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace modul8_1302210096
{
    internal class BankTransferConfig
    {
        public class config
        {
            public string lang { get; set; }
            public transferr transfer { get; set; }
            public List<string> methods { get; set; }
            public konfirmasi confirmation { get; set; }



            public class transferr
            {
                public int threshold;
                public int low_fee;
                public int high_fee;

                public transferr(int threshold, int low_fee, int high_fee)
                {
                    this.threshold = threshold;
                    this.low_fee = low_fee;
                    this.high_fee = high_fee;
                }

                public transferr()
                {

                }
            }

            public class konfirmasi
            {
                public string en { get; set; }
                public string id { get; set; }

                public konfirmasi()
                {

                }

                public konfirmasi(string en, string id)
                {
                    this.en = en;
                    this.id = id;
                }
            }

            public config(string lang, transferr transfer, List<string> methods,  konfirmasi confirmation)
            {
                this.lang = lang;
                this.transfer = transfer;
                this.methods = methods;
                this.confirmation = confirmation;

            }

            public config()
            {

            }


        }

        public config ReadConfig()
        {
            string jsonFromFile = File.ReadAllText(path + '/' + configFileName);
            Config = JsonSerializer.Deserialize<config>(jsonFromFile);


            return Config;
        }

        public void WriteConfig()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true,
            };

            String jsonString = JsonSerializer.Serialize(Config, options);
            string fullPath = path + "/" + configFileName;
            File.WriteAllText(fullPath, jsonString);
        }


        public config Config { get; set; }
        public string configFileName = "bank_transfer_config.json";
        public string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;


        

        









    }
}
