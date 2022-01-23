using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace NucZip.Services
{
    /// <summary>
    /// The cracking service 
    /// </summary>
    public class CrackingService
    {
        private protected ZipService _zipService;
        private bool loop = true;

        public CrackingService()
        {
            _zipService = new ZipService();
        }
        /// <summary>
        /// Start the cracking attempt
        /// </summary>
        /// <param name="input">The path of the zipfile</param>
        /// <param name="output">The output path where the zip will be extracted</param>
        /// <param name="wordlistPath">The path to the wordlist</param>
        /// <param name="delay">Thread sleep delay (default: 0)</param>
        public void Start(string input, string output, string wordlistPath, int delay)
        {
            string pass = "";

            using (StreamReader file = new StreamReader(wordlistPath))
            {
                while (loop == true && (pass = file.ReadLine()) != null)
                {
                    try
                    {

                        _zipService.UnZip(input, output, pass);
                        loop = false;
                    }
                    catch (Exception)
                    {
                        Program.getInstance().AddItems($"Tryed » {pass}");
                    }
                    Thread.Sleep(delay);
                }

                if (loop == false)
                {
                    Program.getInstance().AddItems("");
                    Program.getInstance().AddItems($"Password found » {pass}");
                    Program.getInstance().AddItems($"Zip unpacked to » {output}");
                    Program.getInstance().EnableStartButton();
                } else if(file.EndOfStream && loop == true) {
                    Program.getInstance().AddItems("");
                    Program.getInstance().AddItems($"No password found! :(");
                    Program.getInstance().EnableStartButton();
                }
            }
        }
    }
}
