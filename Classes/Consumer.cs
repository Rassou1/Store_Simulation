using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment3_Form.Classes
{
    internal class Consumer
    {
        Product.categoryType consumeType;
        
        Storage<Product> consumerStorage;
        StorageManager storageManager;
        
        public List<Product> products = new List<Product>();
        bool isRunning = true;
        int maxCapacity;
        public bool IsRunning {  get { return isRunning; } set { isRunning = value; } }
        public int MaxCapacity { get {  return maxCapacity; } set {  maxCapacity = value; } }

        public Consumer(Product.categoryType consumeType, Storage<Product> consumerStorage, StorageManager storageManager, int maxCapacity)
        {
            this.consumeType = consumeType;
            this.consumerStorage = consumerStorage;
            this.storageManager = storageManager;
            this.maxCapacity = maxCapacity;
          
        }

        public void Consuming()
        {
            if(products.Count < maxCapacity)
            {
                Product product = consumerStorage.Consume();
                products.Add(product);
            }
            else
            {
                switch(consumeType)
                {
                    case Product.categoryType.Bread:
                        storageManager.mainForm.UpdateWillys(false);
                        break;
                    case Product.categoryType.Produce:
                        storageManager.mainForm.UpdateIca(false);
                        break;
                    case Product.categoryType.Electronics:
                        storageManager.mainForm.UpdateCarrefour(false);
                        break;
                }
            }
        }

        public void Reset()
        {
            switch(consumeType)
            {
                case Product.categoryType.Bread:
                    if (storageManager.mainForm.WillysCheckbox.Checked)
                    {
                        if(products.Count >= maxCapacity)
                        {
                            products.Clear();
                        }
                        storageManager.mainForm.UpdateWillys(true);
                    }
                    break;
                case Product.categoryType.Produce:
                    if (storageManager.mainForm.IcaCheckbox.Checked)
                    {
                        if (products.Count >= maxCapacity)
                        {
                            products.Clear();
                        }
                        storageManager.mainForm.UpdateIca(true);
                    }
                    break;
                case Product.categoryType.Electronics:
                    if (storageManager.mainForm.CarrefourCheckbox.Checked)
                    {
                        if (products.Count >= maxCapacity)
                        {
                            products.Clear();
                        }
                        storageManager.mainForm.UpdateCarrefour(true);
                    }
                    break;
            }
        }

        public void Run()
        {
            while (isRunning)
            {
                Consuming();
                Reset();
                Thread.Sleep(2000);
            }
        }
    }
}
