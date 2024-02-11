using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class RootObject
    {
        public bool Success { get; set; }
        public Dictionary<string ,Category> Categories { get; set; }

        public Category Search(string searchData)
        {
            Category result = null;
            if(Categories ==  null) return null;
            else
            {
                foreach(var category in Categories.Values)
                {
                    result = DFS(category, searchData);
                }
            }
            return result;
        }

        private Category DFS(Category Category, string searchData)
        {
       
            if (Category.code.Equals(searchData))
            {
                return Category;
            }
            if(Category.children != null)
            {
                foreach (var child in Category.children.Values)
                {
                    var result = DFS(child, searchData);
                    if (result != null)
                    {
                        return result;
                    }
                }
            }
            return null;
        }

    }
}
