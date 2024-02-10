using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class RootObject
    {
        public bool success { get; set; }
        public Dictionary<string , Category> categories { get; set; }
        public override string ToString() => $"success : {success} , categories : {categories.ToList().ToString()}";

        public Category search(string code)
        {
            Category result = null;
            string[] temp = Spliter(code);
            Stack<Category> stack = new Stack<Category>();
            while(stack.Count() == 0)
            {
                foreach (var items in categories.Values)
                {

                }
            }
            
            
            return result;
        }
        
        public string[] Spliter(string code)
        {
            char[] delimiterChars = { '-' };
            string[] levels = code.Split(delimiterChars);
            return levels;
        }

        public Category Find(string[] temp , int index ,  Dictionary<string ,Category> category)
        {

            if (index == temp.Length - 1) return category.TryGetValue().;
            else
            {
                foreach (var cate in category.children.Values) 
                {
                    if (cate.code.Equals(temp[index]))
                    {
                        Find(temp, index++, cate);
                    }
                }
            }
            return null;

        }
    }
}
