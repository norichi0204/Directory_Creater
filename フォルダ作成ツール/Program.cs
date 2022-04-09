using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace フォルダ作成ツール
{
    class Program
    {
        static void Main(string[] args)
        {
           const string 大フォルダ = "成果物\\";
        
            StreamReader sr = new StreamReader("フォルダ名.txt", Encoding.GetEncoding("Shift_JIS"));

            while (sr.Peek() != -1)
            {          
                Directory.CreateDirectory(大フォルダ + sr.ReadLine());
            }

            sr.Close();

           
        }
    }
}
