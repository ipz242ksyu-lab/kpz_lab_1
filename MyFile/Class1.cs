using System.IO;

namespace ClassLibrary
{
    public class MyFile
    {
        public string Name;
        public byte[] Bytes;
        public string Path;

        public MyFile(MyFile f)
        {
            Name = f.Name;
            Bytes = f.Bytes;
            Path = f.Path;
        }

        public MyFile(string path)
        {
            using (FileStream fileStream = new FileStream(path, FileMode.Open))
            {
                Bytes = new byte[fileStream.Length];
                fileStream.Read(Bytes, 0, Bytes.Length);
            }

            Path = path;
            Name = new FileInfo(path).Name;
        }

        public void Save(string path)
        {
            using (FileStream fileStream = new FileStream(path, FileMode.Create))
            {
                fileStream.Write(Bytes, 0, Bytes.Length);
            }
        }
    }
}
