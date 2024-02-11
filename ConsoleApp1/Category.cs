using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Category
    {
       public int level { get; set; }
       public string name { get; set; }
       public string code { get; set; }
       public int sort_num { get; set; }
       public Dictionary<string,Category> children { get; set; }

        public string toString()
        {
            return $"name : {name} , code : {code}";
        }

    }
}
