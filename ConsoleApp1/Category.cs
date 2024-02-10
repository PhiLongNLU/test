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
       public IDictionary<string,Category> children { get; set; }
        public override string ToString()
        {
            return $"level : {level}, name : {name}, code : {code}, sort_num: {sort_num}, children : {children.ToString()}";
        }
    }
}
