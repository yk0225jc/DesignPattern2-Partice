using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    public class Item
    {
        public string name;
        public string category;
        public string supplier;
        public double unitPrice;
        public int quantityInStock;

        public Item(string aName, string aCategory, string aSupplier, double aUnitprint, int aQuantityInStock)
        {
            this.name = aName;
            this.category =aCategory;
            this.supplier = aSupplier;
            this.unitPrice = aUnitprint;
            this.quantityInStock = aQuantityInStock;


        }
        public string Name { get { return this.name; } set { this.name = value; } }
        public string Category { get { return this.category; } set { this.category = value; } }
        public string Supplier { get { return this.supplier; } set { this.supplier = value; } }
        public double UnitPrice { get { return this.unitPrice; } set { this.unitPrice = value; } }
        public int QuantityInStock { get { return this.quantityInStock; } set { this.quantityInStock = value; } }

        public override string ToString()
        {
            return "Name: "+ name + "\n" 
                    +"Category: "+ category + "\n" 
                    +"Supplier: "+ supplier + "\n" 
                    + "Unit Price:" +unitPrice + "\n" 
                    +"Quantity : "+ quantityInStock;
        }

    }
}
