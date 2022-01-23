using Ionic.Zip;

namespace NucZip.Services
{
    /// <summary>
    /// The zip file extractor
    /// </summary>
    public class ZipService
    {
        /// <summary>
        /// This method is called in the cracking service, if the password is wrong,
        /// a error will be thrown. (try-catch in cracking service)
        /// </summary>
        /// <param name="input">The path of the zipfile</param>
        /// <param name="output">The output path where the zip will be extracted</param>
        /// <param name="password">The zipfile password</param>
        public void UnZip(string input, string output, string password)
        {
            using (ZipFile zip = ZipFile.Read(input))
            {
                zip.Password = password;
                zip.ExtractAll(output);
            }
        }
    }
}


