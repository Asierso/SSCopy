using System;
using System.Collections;
using System.Linq;
using System.Threading;
using System.Net;
using System.Text;
using System.IO;
namespace Net 
{
    class Net 
    {
                public static void Main(string[] args)
        {
            if(args.Length != 0)
            {
                if(args[0] == "help")
                {
                    StreamReader helps = new StreamReader("models/Read.txt");
                    string dss = helps.ReadToEnd();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(dss);
                    Console.ForegroundColor = ConsoleColor.White;
                    Environment.Exit(0);
                }
              Console.ForegroundColor = ConsoleColor.Yellow;
              WebClient wb = new WebClient();
              byte[] data = wb.DownloadData(args[0]);
              string code = Encoding.ASCII.GetString(data);
              Console.WriteLine(code);
              Console.ForegroundColor = ConsoleColor.White;
                    
                    if(args[1] == "NaH" || args[1] == "none" || args[1] == "null")
                    {
                        Environment.Exit(0);
                        
                        
            
                    }else
                    {
                        StreamWriter savechanges = new StreamWriter(args[1]);
                        savechanges.Write(code);
                        savechanges.Close();

                        if(args[2].Length != 0)
                        {
                            string duplicate = args[2];
                            string comA = "git remote add origin " + args[2];
                            string comB = "git push -u origin master";
                            System.Diagnostics.Process.Start("C:/Program Files/Git/git-bash.exe", "/c " + "git init");
                            System.Diagnostics.Process.Start("C:/Program Files/Git/git-bash.exe", "/c " + "git add .");
                            System.Diagnostics.Process.Start("C:/Program Files/Git/git-bash.exe", "/c " + "git commit -m \"SSCopied\"");
                            System.Diagnostics.Process.Start("C:/Program Files/Git/git-bash.exe", "/c " + comA);
                            System.Diagnostics.Process.Start("C:/Program Files/Git/git-bash.exe", "/c " + comB);
                            System.Diagnostics.Process.Start("cmd", "/c " + "C:/Program Files/Git/git-bash.exe git init");
                            System.Diagnostics.Process.Start("cmd", "/c " + "C:/Program Files/Git/git-bash.exe git add .");
                            System.Diagnostics.Process.Start("cmd", "/c " + "C:/Program Files/Git/git-bash.exe git commit -m \"SSCopied\"");
                            System.Diagnostics.Process.Start("cmd", "/c " + "C:/Program Files/Git/git-bash.exe " +comA);
                            System.Diagnostics.Process.Start("cmd", "/c " + "C:/Program Files/Git/git-bash.exe " +comB);
                            
                        }
                        if (args[3].Length !=0)
                        {
                            switch(args[3])
                            {
                                case "-a":
                                int linq_structure = 14;
                                linq_structure++;
                                StreamReader linq_read = new StreamReader("models/linq_names.db");
                                string ln = linq_read.ReadLine();
                                string l1 = linq_read.ReadLine();
                                string l2 = linq_read.ReadLine();
                                string l3 = linq_read.ReadLine();
                                string l4 = linq_read.ReadLine();
                                string l5 = linq_read.ReadLine();
                                string l6 = linq_read.ReadLine();
                                string l7 = linq_read.ReadLine();
                                string l8 = linq_read.ReadLine();
                                string l9 = linq_read.ReadLine();
                                string l10 = linq_read.ReadLine();
                                string l11 = linq_read.ReadLine();
                                string l12 = linq_read.ReadLine();
                                string l13= linq_read.ReadLine();
                                string l14 = linq_read.ReadLine();
                                byte[] getDatas1 = wb.DownloadData(l1);
                                byte[] getDatas2 = wb.DownloadData(l2);
                                byte[] getDatas3 = wb.DownloadData(l3);
                                byte[] getDatas4 = wb.DownloadData(l4);
                                byte[] getDatas5 = wb.DownloadData(l5);
                                byte[] getDatas6 = wb.DownloadData(l6);
                                byte[] getDatas7 = wb.DownloadData(l7);
                                byte[] getDatas8 = wb.DownloadData(l8);
                                byte[] getDatas9 = wb.DownloadData(l9);
                                byte[] getDatas10 = wb.DownloadData(l10);
                                byte[] getDatas11 = wb.DownloadData(l11);
                                byte[] getDatas12 = wb.DownloadData(l12);
                                byte[] getDatas13 = wb.DownloadData(l13);
                                byte[] getDatas14 = wb.DownloadData(l14);
                                string getNewCode1 = Encoding.ASCII.GetString(getDatas1);
                                string getNewCode2 = Encoding.ASCII.GetString(getDatas2);
                                string getNewCode3 = Encoding.ASCII.GetString(getDatas3);
                                string getNewCode4 = Encoding.ASCII.GetString(getDatas4);
                                string getNewCode5 = Encoding.ASCII.GetString(getDatas5);
                                string getNewCode6 = Encoding.ASCII.GetString(getDatas6);
                                string getNewCode7 = Encoding.ASCII.GetString(getDatas7);
                                string getNewCode8 = Encoding.ASCII.GetString(getDatas8);
                                string getNewCode9 = Encoding.ASCII.GetString(getDatas9);
                                string getNewCode10 = Encoding.ASCII.GetString(getDatas10);
                                string getNewCode11 = Encoding.ASCII.GetString(getDatas11);
                                string getNewCode12 = Encoding.ASCII.GetString(getDatas12);
                                string getNewCode13 = Encoding.ASCII.GetString(getDatas13);
                                string getNewCode14 = Encoding.ASCII.GetString(getDatas14);
                                StreamWriter w1 = new StreamWriter(l1);
                                StreamWriter w2 = new StreamWriter(l2);
                                StreamWriter w3 = new StreamWriter(l3);
                                StreamWriter w4 = new StreamWriter(l4);
                                StreamWriter w5 = new StreamWriter(l5);
                                StreamWriter w6 = new StreamWriter(l6);
                                StreamWriter w7 = new StreamWriter(l7);
                                StreamWriter w8 = new StreamWriter(l8);
                                StreamWriter w9 = new StreamWriter(l9);
                                StreamWriter w10 = new StreamWriter(l10);
                                StreamWriter w11 = new StreamWriter(l11);
                                StreamWriter w12 = new StreamWriter(l12);
                                StreamWriter w13 = new StreamWriter(l13);
                                StreamWriter w14 = new StreamWriter(l14);
                                w1.WriteLine(getNewCode1);
                                w2.WriteLine(getNewCode2);
                                w3.WriteLine(getNewCode3);
                                w4.WriteLine(getNewCode4);
                                w5.WriteLine(getNewCode5);
                                w6.WriteLine(getNewCode6);
                                w7.WriteLine(getNewCode7);
                                w8.WriteLine(getNewCode8);
                                w9.WriteLine(getNewCode9);
                                w10.WriteLine(getNewCode10);
                                w11.WriteLine(getNewCode11);
                                w12.WriteLine(getNewCode12);
                                w13.WriteLine(getNewCode13);
                                w14.WriteLine(getNewCode14);
                                w1.Close();
                                w2.Close();
                                w3.Close();
                                w4.Close();
                                w5.Close();
                                w6.Close();
                                w7.Close();
                                w8.Close();
                                w9.Close();
                                w10.Close();
                                w11.Close();
                                w12.Close();
                                w13.Close();
                                w14.Close();
                                break;
                                case "-b": 
                                Console.WriteLine("");
                                Console.WriteLine("File " + args[1]);
                                Console.WriteLine("");
                                Console.ForegroundColor = 
                                ConsoleColor.Yellow;System.Diagnostics.Process.Start(args[0]);
                                Console.ForegroundColor = ConsoleColor.Green;
                                break;
                                case "-c": 
                                Console.WriteLine("");
                                Console.WriteLine("File " + args[1]);
                                Console.WriteLine("");
                                Console.ForegroundColor = 
                                ConsoleColor.Yellow;System.Diagnostics.Process.Start(args[0]);
                                Console.ForegroundColor = ConsoleColor.Green;
                                File.Delete(args[1]);
                                break;
                                default:break;
                            }
                        }
                    

                }


            }

            
        }
}
}