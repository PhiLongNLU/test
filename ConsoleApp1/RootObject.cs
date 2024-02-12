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

        public List<Category> GetCategory(int level)
        {
            List<Category> result = new List<Category>();
            foreach(var category in this.Categories.Values)
            {
                result.AddRange(GetCategory(category, level));
            }
            return result;
        }

        private List<Category> GetCategory(Category Category, int level)
        {
            List<Category> categories = new List<Category>();
            if (islevel(Category, level))
            {
                categories.Add(Category);
            }
            if (Category.children != null)
            {
                foreach (var child in Category.children.Values)
                {
                    var result = GetCategory(child, level);
                    if (result != null)
                    {
                        categories.AddRange(result);
                    }
                }
            }
            return categories;
        }

        public bool islevel(Category category , int level)
        {
            if(category == null) return false;
            if(category.level == level) return true;
            return false;
        }

        

    }
}
