using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Kategori
    {
        public String? Name { get; set; }

        public Kategori() { }

        public Kategori(String name)
        {
            Name = name;
        }

    }
}
