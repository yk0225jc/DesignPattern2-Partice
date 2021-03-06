//Written by Jiameng Zhou
// 05/02/2021
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
        public int unitPrice;
        public int quantity;

        public Item(string aName, string aCategory, string aSupplier, int aUnitPrice, int aQuantity)
        {
            this.name = aName;
            this.category =aCategory;
            this.supplier = aSupplier;
            this.unitPrice = aUnitPrice;
            this.quantity = aQuantity;


        }
        public string Name { get { return this.name; } set { this.name = value; } }
        public string Category { get { return this.category; } set { this.category = value; } }
        public string Supplier { get { return this.supplier; } set { this.supplier = value; } }
        public int UnitPrice { get { return this.unitPrice; } set { this.unitPrice = value; } }
        public int Quantity { get { return this.quantity; } set { this.quantity = value; } }

        public override string ToString()
        {
            return "Name: "+ name + "\n" 
                    +"Category: "+ category + "\n" 
                    +"Supplier: "+ supplier + "\n" 
                    + "Unit Price:" +unitPrice + "\n" 
                    +"Quantity : "+ quantity;
        }

    }
}
