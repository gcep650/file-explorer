using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace MyCMD
{
    class Program
    {
        string m_path = Directory.GetCurrentDirectory();

        static void Main(string[] args)
        {

            string cmd = "";

            while (!cmd.ToLower().Equals("exit"))
            {
                Write(">");
                cmd = ReadLine();
                process(cmd);
            }


        }

        static void process(string cmd)
        {
            string[] args = cmd.Split(' ');
            cmd = args[0];

            switch (cmd)
            {
                case "beep":
                    WriteLine("Beep!");
                    Beep();
                    break;
                case "exists":
                    WriteLine(File.Exists(args[1]));
                    break;
                case "pwd":
                    WriteLine(Directory.GetCurrentDirectory());
                    break;
                case "ls":
                case "dir":

                    foreach (String item in Directory.GetDirectories(Directory.GetCurrentDirectory()))
                    {
                        WriteLine(item + "\\");
                    }
                    foreach (string item in Directory.GetFiles(Directory.GetCurrentDirectory()))
                    {
                        WriteLine(item);
                    }
                    break;
                case "cd":
                    if (args.Length > 0)
                    {
                        if (args[1].Trim().Equals(".."))
                        {
                            Directory.SetCurrentDirectory(Directory.GetParent(Directory.GetCurrentDirectory()).ToString());
                        }
                        else
                        {
                            Directory.SetCurrentDirectory(args[1]);
                        }
                    }
                    break;
                case "cd..":
                    process("cd ..");
                    break;
                case "copy":
                case "cp":
                    File.Copy(args[1], args[2]);
                    break;
                case "del":
                case "rm":
                    File.Delete(args[1]);
                    break;
                case "move":
                    File.Move(args[1], args[2]);
                    break;
                case "fileinfo":
                    FileInfo f = new FileInfo(args[1]);
                    if (f.Exists)
                    {
                    WriteLine("{0}\n{1}\n{2}\n{3}", f.Length, f.LastWriteTime, f.IsReadOnly, f.CreationTime);
                    }
                    else
                    {
                        WriteLine("File not found.");
                    }
                    break;
                default:
                    WriteLine("Command not found.");
                    break;
            }
        }
    }
}
