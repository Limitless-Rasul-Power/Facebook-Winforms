using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Task2
{

    public static class Verify
    { 
        public static bool IsUsernameExist(string username)
        {
            return File.Exists($"Database/{username}.json");
        }       

    }


    public static class JsonFileHelper
    {
        #region JSON        

        public static void JSONSerialization(in User user)
        {
            var serializer = new JsonSerializer();
            
             if (!System.IO.Directory.Exists("Database"))
              {
                System.IO.Directory.CreateDirectory("Database");
              }
            
            using (var sw = new StreamWriter($"Database/{user.Username}.json"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Formatting.Indented;
                    serializer.Serialize(jw, user);
                }
            }
        }

        public static void JSONDeSerialization(ref User user, string fileName)
        {
            var serializer = new JsonSerializer();

            using (var sr = new StreamReader(fileName))
            {
                using (var jr = new JsonTextReader(sr))
                {
                    user = serializer.Deserialize<User>(jr);
                }
            }
        }

        #endregion
    }

    static class Program
    {

        

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
