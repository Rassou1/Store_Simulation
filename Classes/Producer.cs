using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Assignment3_Form.Classes.Product;

namespace Assignment3_Form.Classes
{
    internal class Producer
    {
        Storage<Product> producerStorage;
        StorageManager storageManager;
        bool isRunning = true;
        categoryType categoryType;
        public bool IsRunning { get { return isRunning; } set { isRunning = value; } }

        public Producer(Product.categoryType catergoryType, Storage<Product> producerStorage, StorageManager storageManager)
        {
            this.categoryType = catergoryType;
            this.producerStorage = producerStorage;
            this.storageManager = storageManager;
        }

        public Product MakeRandomProduct()
        {
            Random rnd = new Random();
            List<Product> sameCategoryProducts = storageManager.products.Where(product => product.CategoryType == categoryType).ToList();
            int index = rnd.Next(0, sameCategoryProducts.Count);
            Product matchingProduct = sameCategoryProducts[index];
            return matchingProduct;
        }

        public void Run()
        {
            while(isRunning)
            {
                if (!isRunning)
                {
                    continue;
                }
                if(storageManager.products.Count > 0)
                {
                    Product someProduct = MakeRandomProduct();
                    producerStorage.Produce(someProduct);
                    Thread.Sleep(2000);
                }
            }
        }
    }
}
