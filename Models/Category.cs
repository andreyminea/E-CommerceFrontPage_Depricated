using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IzonStore.Models
{
    public class Category
    {
        public string Name { get; set; }
        public List<string> Subcategories { get; set; }

        public Category()
        {
            Name = "Test Category";
            Subcategories = new List<string>()
            { "SCateg 1", "SCateg 2", "SCateg 3", "SCateg 4"};
        }

        public Category(string name)
        {
            Name = name;
            Subcategories = new List<string>()
            { "SCateg 1", "SCateg 2", "SCateg 3", "SCateg 4"};
        }
    }
}
