using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace WPDText
{
    class Program
    {
        static void Main(string[] args)
        {

            List<WPDFile> files = new List<WPDFile>();
            string url = @"path\\to\\wpd2.0";

            DirectoryInfo d = new DirectoryInfo(url);
            FileInfo[] f = d.GetFiles();
            foreach (FileInfo file in f)
            {
                string text = WPD_TextParser.Parse(file.FullName);
                files.Add(new WPDFile(file.Name, text));
            }
        }
    }


    public struct WPDFile
    {
        public string fileName;
        public string text;

        public WPDFile(string _fileName, string _text)
        {
            fileName = _fileName;
            text = _text;
        }
    }
}
