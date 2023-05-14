using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AplikasiHotel
{
    public class Login
    {
        public Config config { get; set; }
        public string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        public string configFileName = "Login_config.json";

        public Login()
        {
            try
            {
                ReadConfig();
            }
            catch
            {
                SetDefault();
                WriteConfig();
            }
        }

        private Config ReadConfig()
        {
            string jsonFromFile = File.ReadAllText(Path.Combine(path, configFileName));
            config = JsonSerializer.Deserialize<Config>(jsonFromFile);
            return config;
        }

        private void WriteConfig()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            String jsonString = JsonSerializer.Serialize(config, options);
            string fullPath = Path.Combine(path, configFileName);
            File.WriteAllText(fullPath, jsonString);
        }

        public void SetDefault()
        {
            config = new Config("admin", "pasword123", "Login sukses", "Login gagal");
        }

        public bool IsInputValid(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                Console.WriteLine("input tidak boleh kosong");
            }

            if (config.Username == username && config.Password == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public class Config
        {
            public string Username { get; set; }
            public string Password { get; set; }
            public string Login_sukses { get; set; }
            public string Login_gagal { get; set; }

            public Config() { }

            public Config(string Username, string Password, string Login_sukses, string Login_gagal)
            {
                this.Username = Username;
                this.Password = Password;
                this.Login_sukses = Login_sukses;
                this.Login_gagal = Login_gagal;
            }
        }
    }
}
