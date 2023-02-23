using System;
using System.Collections;
using System.IO;
using System.Text;

namespace AnimeWeb.Services
{
    public class FIleService
    {
        private static bool _disposed = false;
        private static string path = @"C:\Users\steve\Documents\CSHARP\AnimeWeb\AnimeWeb\Assets\Femboyo.txt";
        private static List<string> files = new List<string>();
        //private static void DisposeOfOldFile()
        //{
        //    bool test = File.Exists(path);
        //    if (test)
        //    {
        //        File.Delete(path);
        //        var c = File.Create(path);
        //        c.Close();
        //    }

        //}
        public async void WriteToFile(string url)
        {
            try
            {
                //if (_disposed == false)
                //{
                //    DisposeOfOldFile();
                //    _disposed = true;
                //}
                string readText = File.ReadAllText(path);

                using var sw = new StreamWriter(path);
                sw.Write(readText +";" + url);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public async Task<string> ReadLast()
        {
            using var sr = new StreamReader(path);
            var line = sr.ReadLine();
            sr.Close();
            if (line != null)
            {

                var smth = line.Split(';');
                using var sw = new StreamWriter(path);
                for (int i = 0; i < smth.Length - 1; i++)
                {
                    files.Add(smth[i]);

                }
                files.RemoveAt(files.Count - 1);
                for (int i = 0; i < files.Count; i++)
                {
                    sw.Write(files[i]);
                }
                sw.Close();
            }
            return files.Last();
        }
    }
}
