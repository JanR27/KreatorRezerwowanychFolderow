using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KreatorRezerwowanychFolderow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ścieżkę do folderu:");
            string path = Console.ReadLine();


            if (Directory.Exists(path))
            {

            }
            else
            {
                Console.WriteLine("Ta ścieżka nie istnieje.");
                Console.ReadKey();
                return;
            }

            Console.Clear();

            Console.WriteLine("Podaj nazwę folderu do stworzenia: \n1) CON \n2) PRN \n3) AUX \n4) COM \n5) LPT");
            int choice = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (choice)
            {
                case 1: string invalidFolderPath = $@"\\?\{Path.Combine(path, "CON")}"; Directory.CreateDirectory(invalidFolderPath); break;
                case 2: invalidFolderPath = $@"\\?\{Path.Combine(path, "PRN")}"; Directory.CreateDirectory(invalidFolderPath); break;
                case 3: invalidFolderPath = $@"\\?\{Path.Combine(path, "AUX")}"; Directory.CreateDirectory(invalidFolderPath); break;
                case 4:
                    Console.WriteLine("Podaj nazwę folderu do stworzenia: \n1) COM0 \n2) COM1 \n3) COM2 \n4) COM3 \n5) COM4\n6) COM5 \n7) COM6 \n8) COM7 \n9) COM8 \n10) COM9 \n11) COM¹\n12) COM²\n13) COM³");
                    choice = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (choice)
                    {
                        case 1: invalidFolderPath = $@"\\?\{Path.Combine(path, "COM0")}"; Directory.CreateDirectory(invalidFolderPath); break;
                        case 2: invalidFolderPath = $@"\\?\{Path.Combine(path, "COM1")}"; Directory.CreateDirectory(invalidFolderPath); break;
                        case 3: invalidFolderPath = $@"\\?\{Path.Combine(path, "COM2")}"; Directory.CreateDirectory(invalidFolderPath); break;
                        case 4: invalidFolderPath = $@"\\?\{Path.Combine(path, "COM3")}"; Directory.CreateDirectory(invalidFolderPath); break;
                        case 5: invalidFolderPath = $@"\\?\{Path.Combine(path, "COM4")}"; Directory.CreateDirectory(invalidFolderPath); break;
                        case 6: invalidFolderPath = $@"\\?\{Path.Combine(path, "COM5")}"; Directory.CreateDirectory(invalidFolderPath); break;
                        case 7: invalidFolderPath = $@"\\?\{Path.Combine(path, "COM6")}"; Directory.CreateDirectory(invalidFolderPath); break;
                        case 8: invalidFolderPath = $@"\\?\{Path.Combine(path, "COM7")}"; Directory.CreateDirectory(invalidFolderPath); break;
                        case 9: invalidFolderPath = $@"\\?\{Path.Combine(path, "COM8")}"; Directory.CreateDirectory(invalidFolderPath); break;
                        case 10: invalidFolderPath = $@"\\?\{Path.Combine(path, "COM9")}"; Directory.CreateDirectory(invalidFolderPath); break;
                        case 11: invalidFolderPath = $@"\\?\{Path.Combine(path, "COM¹")}"; Directory.CreateDirectory(invalidFolderPath); break;
                        case 12: invalidFolderPath = $@"\\?\{Path.Combine(path, "COM²")}"; Directory.CreateDirectory(invalidFolderPath); break;
                        case 13: invalidFolderPath = $@"\\?\{Path.Combine(path, "COM³")}"; Directory.CreateDirectory(invalidFolderPath); break;
                        default: Console.WriteLine("Niepoprawna opcja!"); return;
                    }
                    break;
                case 5:
                    Console.WriteLine("Podaj nazwę folderu do stworzenia: \n1) LPT0 \n2) LPT1 \n3) LPT2 \n4) LPT3 \n5) LPT4\n6) LPT5 \n7) LPT6 \n8) LPT7 \n9) LPT8 \n10) LPT9 \n11) LPT¹\n12) LPT²\n13) LPT³");
                    choice = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (choice)
                    {
                        case 1: invalidFolderPath = $@"\\?\{Path.Combine(path, "LPT0")}"; Directory.CreateDirectory(invalidFolderPath); break;
                        case 2: invalidFolderPath = $@"\\?\{Path.Combine(path, "LPT1")}"; Directory.CreateDirectory(invalidFolderPath); break;
                        case 3: invalidFolderPath = $@"\\?\{Path.Combine(path, "LPT2")}"; Directory.CreateDirectory(invalidFolderPath); break;
                        case 4: invalidFolderPath = $@"\\?\{Path.Combine(path, "LPT3")}"; Directory.CreateDirectory(invalidFolderPath); break;
                        case 5: invalidFolderPath = $@"\\?\{Path.Combine(path, "LPT4")}"; Directory.CreateDirectory(invalidFolderPath); break;
                        case 6: invalidFolderPath = $@"\\?\{Path.Combine(path, "LPT5")}"; Directory.CreateDirectory(invalidFolderPath); break;
                        case 7: invalidFolderPath = $@"\\?\{Path.Combine(path, "LPT6")}"; Directory.CreateDirectory(invalidFolderPath); break;
                        case 8: invalidFolderPath = $@"\\?\{Path.Combine(path, "LPT7")}"; Directory.CreateDirectory(invalidFolderPath); break;
                        case 9: invalidFolderPath = $@"\\?\{Path.Combine(path, "LPT8")}"; Directory.CreateDirectory(invalidFolderPath); break;
                        case 10: invalidFolderPath = $@"\\?\{Path.Combine(path, "LPT9")}"; Directory.CreateDirectory(invalidFolderPath); break;
                        case 11: invalidFolderPath = $@"\\?\{Path.Combine(path, "LPT¹")}"; Directory.CreateDirectory(invalidFolderPath); break;
                        case 12: invalidFolderPath = $@"\\?\{Path.Combine(path, "LPT²")}"; Directory.CreateDirectory(invalidFolderPath); break;
                        case 13: invalidFolderPath = $@"\\?\{Path.Combine(path, "LPT³")}"; Directory.CreateDirectory(invalidFolderPath); break;
                        default: Console.WriteLine("Niepoprawna opcja!"); return;
                    }
                    break;
                default: Console.WriteLine("Niepoprawna opcja!"); return;
            }

            Console.ReadKey();
        }
    }
}
