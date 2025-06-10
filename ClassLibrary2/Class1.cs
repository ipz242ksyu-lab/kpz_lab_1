using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using static System.Net.WebRequestMethods;
using ClassLibrary;
using ClassLibrary1;

namespace ClassLibrary2
{
    public class ZippingUnzipping
    {
        public static void RemoveDirectory(string path)
        {
            var files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                {
                    FileInfo File = new FileInfo(file);
                    File.Delete();
                }

                Directory.Delete(path, true);
            }
        }

        public static string Zipping(List<string> files, string zipPath)
        {
            string tempPath = "D:\\ООП 25-2\\Деархиватор";
            Directory.CreateDirectory(tempPath);

            using (StreamWriter streamWriter = new StreamWriter(Path.Combine(tempPath, "\\00sort.sort")))
            {
                foreach (string file in files)
                {
                    string destFile = Path.Combine(tempPath, Path.GetFileName(file));
                    System.IO.File.Copy(file, destFile, true);
                    streamWriter.WriteLine(Path.GetFileName(file));
                }
                streamWriter.Close();
            }

            ZipFile.CreateFromDirectory(tempPath, zipPath);
            RemoveDirectory(tempPath);

            return zipPath;
        }

        public static List<string> Unzipping(string zipPath)
        {
            List<string> result = new List<string>();
            string mainPath = "D:\\ООП 25-2\\Деархиватор";
            string archivePath = "D:\\ООП 25-2\\Архіватор";

            Directory.CreateDirectory(mainPath);
            Directory.CreateDirectory(archivePath);
            System.IO.File.Copy(zipPath, Path.Combine(archivePath, Path.GetFileName(zipPath)), true);
            ZipFile.ExtractToDirectory(zipPath, mainPath);

            string[] nameArr;
            using (StreamReader reader = new StreamReader(Path.Combine(mainPath, "00sort.sort")))
            {
                nameArr = reader.ReadToEnd().Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (string file in Directory.GetFiles(mainPath))
            {
                string fileName = Path.GetFileName(file);

                if (Array.Exists(nameArr, name => name.Trim() == fileName.Trim()))
                {
                    result.Add(file);
                }
            }

            RemoveDirectory(mainPath);
            RemoveDirectory(archivePath);

            return result;
        }

        public static string Zipping(List<MyFile> filesToZip, string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
