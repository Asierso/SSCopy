using System;
using System.Linq;
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

              WebClient wb = new WebClient();
              byte[] data = wb.DownloadData(args[0]);
              string code = Encoding.ASCII.GetString(data);
              Console.WriteLine(code);
                if(args[1].Length != 0)
                {
                    if(args[1] == "NaH" || args[1] == "none" || args[1] == "null")
                    {
                        Environment.Exit(0);
                    }
                    else
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
                            System.Diagnostics.Process.Start("C:/Program Files/Git/git-bash.exe", "/c " + "git add " + args[1] );
                            System.Diagnostics.Process.Start("C:/Program Files/Git/git-bash.exe", "/c " + "git commit -m \"SSCopied\"");
                            System.Diagnostics.Process.Start("C:/Program Files/Git/git-bash.exe", "/c " + comA);
                            System.Diagnostics.Process.Start("C:/Program Files/Git/git-bash.exe", "/c " + comB);
                            System.Diagnostics.Process.Start("cmd", "/c " + "C:/Program Files/Git/git-bash.exe git init");
                            System.Diagnostics.Process.Start("cmd", "/c " + "C:/Program Files/Git/git-bash.exe git add " + args[1] );
                            System.Diagnostics.Process.Start("cmd", "/c " + "C:/Program Files/Git/git-bash.exe git commit -m \"SSCopied\"");
                            System.Diagnostics.Process.Start("cmd", "/c " + "C:/Program Files/Git/git-bash.exe " +comA);
                            System.Diagnostics.Process.Start("cmd", "/c " + "C:/Program Files/Git/git-bash.exe " +comB);
                        }
                    }

                }

            }

            
        }
    }
}