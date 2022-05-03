using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        List<string> input = new List<string>();
       string line;
        while ((line = Console.ReadLine()) != null && line != "") {
            input.Add(line);
        }
            foreach(string item in input) {
                 camelCase(item);
            }
       
    }
    
      public static void camelCase(string a)
        {
            
            string[] myString = a.Split(';');
            string operation = myString[0].Trim();
            string type = myString[1].Trim();
            string input = myString[2].Trim();
            if (operation.Equals("S"))
            {
                switch(type)
                {
                    case "M":
                        SplitMethodAndVariable(input);
                        break;
                    case "C":
                        SplitClass(input);
                        break;
                    case "V":
                        SplitMethodAndVariable(input);
                        break;
                    default:
                        break;
                }

            }
            else
            {
                switch (type)
                {
                    case "M":
                        CombineMethodAndVariable(input,type);
                        break;
                    case "C":
                        CombineClass(input);
                        break;
                    case "V":
                        CombineMethodAndVariable(input,type);
                        break;
                    default:
                        break;
                }
            }
        }
        
         private static void CombineClass(string input)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if(i==0)
                {
                    sb.Append(char.ToUpper(input[i]));
                }
                else if (char.IsWhiteSpace(input[i]))
                {
                    i++;
                    sb.Append(char.ToUpper(input[i]));
                }
                else
                {
                    sb.Append(input[i]);
                }
            }
            Console.WriteLine(sb.ToString().Trim());
        }

        private static void SplitClass(string input)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
               
                if (char.IsUpper(input[i]))
                {
                    sb.Append(" ");
                    sb.Append(input[i]);
                }
                else
                {
                    sb.Append(input[i]);
                }
            }
            Console.WriteLine(sb.ToString().ToLower().Trim());
        }

        private static void SplitMethodAndVariable(string input)
        {
            int indexOfUpper = 0;
            for (int i=0;i<input.Length-1;i++)
            {
                if(char.IsUpper(input[i]))
                {
                    indexOfUpper = i;
                    break;
                }
            }
            var res = input.Substring(0, indexOfUpper) + " " +input.Substring(indexOfUpper, input.Length- indexOfUpper) ;
           
                Console.WriteLine(res.Replace("(", "").Replace(")", "").ToLower());
           
        }

        private static void CombineMethodAndVariable(string input,string type)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {

                if (char.IsWhiteSpace(input[i]))
                {
                    i++;
                    sb.Append(char.ToUpper(input[i]));
                }
                else
                {
                    sb.Append(input[i]);
                }
            }
            if(type.Equals("V"))
            {
                Console.WriteLine(sb.ToString().Trim());
            }
            else
            {
                sb.Append("(");
                sb.Append(")");
                Console.WriteLine(sb.ToString().Trim());
            }
          
        }

}

