using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labasraba3
{
    class Pastry : BakeryProducts
    {
        private string topping;
        private string size;

        public string Topping { get; set; }
        public string Size { get; set; }

        public Pastry() : base() { }
        public Pastry(string type, bool fresh) : base(type, fresh) { }
        public Pastry(string type, bool fresh, string topping) : base(type,fresh) {this.topping = topping;}
        public Pastry(string type, bool fresh, string topping, string size) : base(type, fresh)
        {
            this.topping = topping;
            this.size = size;
        }
        public override string Print()
        {
            return $" {base.Print()}, topping - {topping}, size {size}";            
        }
        
        public override string False()
        {
            return $" Bakery products is not fresh, please don't eat it!!!";
        }
      
    }
}
