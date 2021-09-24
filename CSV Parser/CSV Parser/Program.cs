using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CSV_Parser
{
    class Program
    {

        static void Main(string[] args)
        {
            int count = 0;
            double sum = 0;
            double i;
            double avg = 0;
            string num = "";
            string textContent = "";
            if (args.Length > 0)
            {
                foreach (var item in args)
                {
                    List<string> lines = File.ReadAllLines(item).ToList();
                    foreach (var line in lines)
                    {
                        string[] value = line.Split(',');
                        foreach (string s in value)
                        {
                            if (s.Contains("$"))
                            {
                                foreach (char c in s) 
                                { 
                                    if(c == '$')
                                    {
                                        i = 0;
                                        num = " ";
                                        num = s.Trim(new char[] { '$', ' ' }); 
                                        if (double.TryParse(num, out i))
                                        {
                                            count++;
                                            sum += i;
                                            avg = sum / count;
                                        }
                                    }
                                }
                            }
                            
                        }
                    }

                    textContent = "Sum    Average\n"+
                                  $"{sum}   {avg}";
                    File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\" + "Test.txt", textContent);

                }
                
            }
            Console.ReadKey();
        }
    }
}
