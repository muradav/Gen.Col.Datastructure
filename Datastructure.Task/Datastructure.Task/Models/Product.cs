using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructure.Task
{
    abstract class Product:Exceptions
    {
        private static int _id;
        public int ID { get; }

        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        protected double TotalIncome { get; set; }

        public Product()
        { 
            _id++;
            ID = _id;
        }

        public abstract void Sell();
        public abstract void ShowInfo();

        
    }
}
