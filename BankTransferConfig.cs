using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul8_103022300058
{
    class Transfer
    { 
        public int threshold { get; set; }
        public int low_fee { get; set; }
        public int high_fee { get; set; }
    }

    class Confirmation
    { 
        public string en { get; set; }
        public string id { get; set; }
    }
    class BankTransferConfig
    {
        public string lang { get; set; }
        public Transfer transfer { get; set; }
        public Confirmation confirmation { get; set; }
        public List<string>methods { get; set; }

        String path = Path.GetFullPath("D:\\mod8\\modul8_103022300058\\datas\\bank_transfer_config.json");

        public BankTransferConfig LoadConf()
        {
            if (!File.Exists(path)) 
            {
                var defaultSetting = new BankTransferConfig();
                SaveNewConfig(defaultSetting);
                return defaultSetting;
            }
            string json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<BankTransferConfig>(json);

        }

        public void SaveNewConfig(BankTransferConfig config)
        {
            var json = JsonSerializer.Serialize(config, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(path, json);
        }

        public void GantiBahasa()
        {
            if (lang.Equals("en"))
            {
                lang = "id";
            }
            else 
            {
                lang = "en";
            }
        }
    }
}
