using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Diagnostics;

namespace labasraba3
{
    class BakeryProducts
    {
        private string type;
        private bool fresh;

        public string Type { get; set; }
        public bool Fresh { get; set; }

        public BakeryProducts() { }
        public BakeryProducts(string type) { this.type = type;}
        public BakeryProducts(string type, bool fresh)
        {
            this.fresh = fresh;
            this.type = type; 
        }
        public virtual string Print()
        {
            return $"Type - {this.type}, fresh - {this.fresh}";
        }
        private void Check(bool fresh)
        {
            if (fresh == false) { False(); }
        }
        public virtual string False()
        {
            return $" Bakery products is not fresh, please don't eat it!!!";
        }
    }

}
