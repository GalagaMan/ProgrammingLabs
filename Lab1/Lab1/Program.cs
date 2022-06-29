using System;
using System.Collections;
using System.Diagnostics;
using System.Text.Json;
using System.Linq;
using System.Reflection.Metadata;

namespace lab1
{
    class Program
    {
        enum Lab
        {
            Lab1, Lab2, Lab3
        }
        
        public static void Main(string[] args)
        {
            var lab = Lab.Lab3;
            
            switch (lab)
            {
                case Lab.Lab1:
                    #region lab1.1
                    int n = 10;
                    
                    var strings = new List<string>
                    {
                        "1asfwg", "2dsgagrew", "3safgwr", "4sagrwegs", "5sadgweegege", "6sdfsg"
                    };
                    
                    for (int i = 0; i < strings.Count; i+= 2 * n)
                    {
                        for (int j = i; j < i + n && j < strings.Count; j++)
                        {
                            Console.Write(strings[j] + " ");
                        }
                        
                        Console.WriteLine();
                        
                        for (int j = Math.Min(i + 2 * n, strings.Count) - 1; j >= i + n; j--)
                        {
                            Console.Write(strings[j] + " ");
                        }
                        
                        Console.WriteLine();
                    }
                    Console.Read();
                    #endregion
                    break;
                case Lab.Lab2:
                    #region Lab1.2
                    
                    var dict = new Dictionary<string, int>
                    {                                 
                        {"Kyiv", 12445},              
                        {"Summy", 42280},             
                        {"Fastiv", 0b1011011},        
                        {"Lviv", 1474345}             
                    };
                    
                    var listOfKeys = dict.Keys.ToList();  
                    listOfKeys.Sort();
                    string s = JsonSerializer.Serialize(dict);
                    File.WriteAllText("D:/lab1.json", s);
                    
                    #endregion
                break;
                case Lab.Lab3:
                #region lab1.3

                var row = new List<string>{"fsaewgqqqd", "lasdsfadf", "fadsfewdsv", "723rffdsas", "1246"};

                var reverseFirstChars = new string(row.Select(
                    s => s[0])
                    .Reverse().ToArray());
                Console.WriteLine(reverseFirstChars);
                Console.Read();
                
                #endregion
                break;
            }
        }
    }
}   