using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.ConstrainedExecution;
using System.Diagnostics;

namespace FileManager
{
    internal class Program
    {
        static string[] drives;
        static List<DirectoryInfo> directories;
        static int n = 0;
        static int choose;
        static FileInfo[] files;
        static DirectoryInfo current;
        static string path;


        
        static void Drives()
        {
            for (int i = 0; i < drives.Length; i++)
            {
                if (i == n)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                Console.Write("    ");
                Console.Write(drives[i].TrimEnd(Path.DirectorySeparatorChar));

                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
            }
            Console.WriteLine("\n");
        }

        static void Update()
        {
            directories.Clear();
            if (!IsRoot())
            {
                directories.Add(new DirectoryInfo(Previous()));
            }
            directories.AddRange(current.GetDirectories());
            files = current.GetFiles();
        }

        static void Show()
        {
            int dirIndex = 0;
            if (directories[0].FullName == Previous())
            {
                if (0 == choose)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.WriteLine("\u2190");                                    //стрелочка
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                dirIndex = 1;
            }

            for (int i = dirIndex; i < directories.Count; i++)
            {
                if (i == choose)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.WriteLine(directories[i].Name);
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
            }

            for (int i = 0; i < files.Length; i++)
            {
                if (i == choose - directories.Count)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.WriteLine(files[i].Name);
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
            }
        } 

        static string Previous()
        {
            if (path == $"{drives[n]}")
            {
                return $"{drives[n]}";
            }
            int slash = path.Length -2;
            while (path[slash] != '\\')
            {
                slash--;
            }
            int count = path.Length - slash + 1;
            return path.Remove(slash + 1, count - 2);
        }
        static bool IsRoot()
        {
            return path == $"{drives[n]}";
        }

        static void Main(string[] args)
        {
            Console.SetWindowSize(130, 63);                                     //задаем размер окна
            
            Console.BufferWidth = 130;
            Console.BufferHeight = 63;


            Console.CursorVisible = false;                                      //невидимый курсор
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;

            drives = Directory.GetLogicalDrives();
            path = $"{drives[n]}";
            directories = new List<DirectoryInfo>();

            while (true)
            {
                //Console.ForegroundColor = ConsoleColor.Black;
                //Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                drives = Directory.GetLogicalDrives();
                Drives();
                current = new DirectoryInfo(path);

                Update();
                Show();

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.LeftArrow:
                        
                        --n;
                        if (n < 0)
                        {
                            n = drives.Length-1;                                    
                            
                        }
                        path = $"{drives[n]}";

                        break;
                    case ConsoleKey.RightArrow:
                        
                        ++n;
                        if (n >= drives.Length-1)
                        {
                            n = 0;
                            
                        }
                        path = $"{drives[n]}";
                        break;
                    case ConsoleKey.UpArrow:
                        
                        --choose;
                        break;
                    case ConsoleKey.DownArrow:
                        
                        ++choose;
                        break;
                    case ConsoleKey.Enter:
                        if (choose < directories.Count)
                        {
                            path = directories[choose].FullName;
                        }
                        else
                        {
                            Process.Start(files[choose - directories.Count].FullName);
                        }
                        break;
                }
               // if (n < 0) n = drives.Length - 1;
                //if (n > drives.Length-1) n = 0;
                if (choose < 0)
                {
                    choose = (files.Length + directories.Count-1);
                }
                if (choose >= (files.Length + directories.Count ))
                {
                    choose = 0;
               }
            }
        }
    }
}
