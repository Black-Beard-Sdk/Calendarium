using Bb.Validations;
using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

//14320
namespace Bb.Helpers
{

    public static class Helper
    {

        static Helper()
        {
            var _path = new FileInfo(typeof(Helper).Assembly.Location).Directory.FullName;
            filename = Path.Combine(_path, "configuration.json");
        }

        public static void Load()
        {

            if (File.Exists(filename))
                Parameters = JsonConvert.DeserializeObject<Parameter>(File.ReadAllText(filename));
            
            else
                Parameters = new Parameter();

            if (!ValidatorExtension.CheckToken())
                Helper.Parameters.Token = null;

        }

        public static void Save()
        {
            string txt = JsonConvert.SerializeObject(Parameters);
            File.WriteAllLines(filename, new List<string>() { txt }, Encoding.UTF8);
        }

        public static Parameter Parameters { get; set; }


        public static string LoadContentFromFile(string _path)
        {

            string fileContents = string.Empty;
            System.Text.Encoding encoding = null;
            FileInfo _file = new FileInfo(_path);

            using (FileStream fs = _file.OpenRead())
            {

                Ude.CharsetDetector cdet = new Ude.CharsetDetector();
                cdet.Feed(fs);
                cdet.DataEnd();
                if (cdet.Charset != null)
                    encoding = System.Text.Encoding.GetEncoding(cdet.Charset);
                else
                    encoding = System.Text.Encoding.UTF8;

                fs.Position = 0;

                byte[] ar = new byte[_file.Length];
                fs.Read(ar, 0, ar.Length);
                fileContents = encoding.GetString(ar);
            }

            if (fileContents.StartsWith("ï»¿"))
                fileContents = fileContents.Substring(3);

            if (encoding != System.Text.Encoding.UTF8)
            {
                var datas = System.Text.Encoding.UTF8.GetBytes(fileContents);
                fileContents = System.Text.Encoding.UTF8.GetString(datas);
            }

            return fileContents;

        }


        public static string LoadContentFromText(byte[] text)
        {

            string textContents = string.Empty;
            System.Text.Encoding encoding = null;

            using (MemoryStream fs = new MemoryStream(text))
            {

                Ude.CharsetDetector cdet = new Ude.CharsetDetector();
                cdet.Feed(fs);
                cdet.DataEnd();
                if (cdet.Charset != null)
                    encoding = System.Text.Encoding.GetEncoding(cdet.Charset);
                else
                    encoding = System.Text.Encoding.UTF8;

                fs.Position = 0;

                byte[] ar = new byte[text.Length];
                fs.Read(ar, 0, ar.Length);
                textContents = encoding.GetString(ar);
            }

            if (textContents.StartsWith("ï»¿"))
                textContents = textContents.Substring(3);

            if (encoding != System.Text.Encoding.UTF8)
            {
                var datas = System.Text.Encoding.UTF8.GetBytes(textContents);
                textContents = System.Text.Encoding.UTF8.GetString(datas);
            }

            return textContents;

        }



        public static string SerializeContract(this string self)
        {

            if (string.IsNullOrEmpty(self))
                return string.Empty;

            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(self);
            var result = Convert.ToBase64String(bytes);
            return result;
        }


        public static string DeserializeContract(this string self)
        {

            if (string.IsNullOrEmpty(self))
                return string.Empty;

            byte[] bytes = Convert.FromBase64String(self); ;
            string result = System.Text.Encoding.UTF8.GetString(bytes);

            return result;

        }

       
        //public static void Compress()
        //{
        //    using (var fs = File.Create("html-archive.zip"))
        //    using (var outStream = new ZipOutputStream(fs))
        //    {
        //        outStream.PutNextEntry(new ZipEntry("content.html"));

        //        using (var sw = new StreamWriter(outStream))
        //        {
        //            sw.Write(htmlData);
        //        }
        //    }
        //}


        public static void DeleteDirectoryTree(this DirectoryInfo self)
        {

            foreach (var item in self.GetDirectories())
                item.DeleteDirectoryTree();

            foreach (var item in self.GetFiles())
                item.Delete();

            self.Delete();

        }

        public static void UnzipFromFile(this FileInfo self, string outFolder)
        {

            using (var data = self.OpenRead())
            {
                // This stream cannot be opened with the ZipFile class because CanSeek is false.
                UnzipFromStream(data, outFolder);
            }

        }

        public static void UnzipFromStream(this Stream self, string outFolder)
        {
            using (var zipInputStream = new ZipInputStream(self))
            {
                while (zipInputStream.GetNextEntry() is ZipEntry zipEntry)
                {
                    var entryFileName = zipEntry.Name;
                    // To remove the folder from the entry:
                    //var entryFileName = Path.GetFileName(entryFileName);
                    // Optionally match entrynames against a selection list here
                    // to skip as desired.
                    // The unpacked length is available in the zipEntry.Size property.

                    // 4K is optimum
                    var buffer = new byte[4096];

                    // Manipulate the output filename here as desired.
                    var fullZipToPath = Path.Combine(outFolder, entryFileName);
                    var directoryName = Path.GetDirectoryName(fullZipToPath);
                    if (directoryName.Length > 0)
                        Directory.CreateDirectory(directoryName);

                    // Skip directory entry
                    if (Path.GetFileName(fullZipToPath).Length == 0)
                    {
                        continue;
                    }

                    // Unzip file in buffered chunks. This is just as fast as unpacking
                    // to a buffer the full size of the file, but does not waste memory.
                    // The "using" will close the stream even if an exception occurs.
                    using (FileStream streamWriter = File.Create(fullZipToPath))
                    {
                        StreamUtils.Copy(zipInputStream, streamWriter, buffer);
                    }
                }
            }
        }



        private static readonly string filename;

    }

}
