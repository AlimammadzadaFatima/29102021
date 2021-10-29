using System;
using System.Collections.Generic;
using System.Text;

namespace _29102021
{
    class Notebook : Product
    {
        public Notebook(string brand, string model, int ram, int storage, int count, int price) : base(count, price) 
        {
            Model = model;
            Ram = ram;
            Storage = storage;
            Brand = brand;

        }
        public string Brand;
        public string Model;
        public int Ram;
        public int Storage;

    }
}
