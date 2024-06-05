using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment3_Form.Classes
{
    internal class StorageManager
    {
        public Storage<Product> Storage { get; set; } = new Storage<Product>();
        public List<Product> products = new List<Product>();
        Dictionary<Product.categoryType, Producer> producers = new Dictionary<Product.categoryType, Producer>();
        Dictionary<Product.categoryType, Consumer> consumers = new Dictionary<Product.categoryType, Consumer>();
        public MainForm mainForm;
        bool isRunning = true;
        public bool IsRunning {  get { return isRunning; } }

        public Thread managerThread;
        string[] testProducts;

        public StorageManager(MainForm mainForm)
        {
            this.mainForm = mainForm;
        }

        void AddTestProducts()
        {
            var path = Environment.CurrentDirectory;
            string newPath = Path.GetFullPath(Path.Combine(path, @"..\..\"));
            testProducts = File.ReadAllLines
                (newPath + "\\Products.txt");

            foreach (string line in testProducts)
            {
                string[] parts = line.Split(',');
                try
                {
                    if (parts.Length == 3)
                    {
                        string name = parts[0];
                        double.TryParse(parts[1], NumberStyles.Any, CultureInfo.InvariantCulture, out double price);
                        Enum.TryParse(parts[2], out Product.categoryType type);
                        CreateProduct(name, price, type);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public Product CreateProduct(string name, double price, Product.categoryType type)
        {
            Product product = new Product(name, price, type);
            product.Name = name;
            product.Price = price;
            product.CategoryType = type;
            products.Add(product);
            return product;
        }

        public void MakeConsumers()
        {
            consumers[Product.categoryType.Bread] = new Consumer(Product.categoryType.Bread, Storage, this, 15);
            consumers[Product.categoryType.Produce] = new Consumer(Product.categoryType.Produce, Storage, this, 10);
            consumers[Product.categoryType.Electronics] = new Consumer(Product.categoryType.Electronics, Storage, this, 5);
        }

        public void MakeProducers()
        {
            producers[Product.categoryType.Bread] = new Producer(Product.categoryType.Bread, Storage, this);
            producers[Product.categoryType.Produce] = new Producer(Product.categoryType.Produce, Storage, this);
            producers[Product.categoryType.Electronics] = new Producer(Product.categoryType.Electronics, Storage, this);
        }

        public void StartConsumer(Product.categoryType category)
        {
            if(consumers.TryGetValue(category, out var consumer))
            {
                consumer.IsRunning = true;
                Thread consumerThread = new Thread(consumer.Run);
                consumerThread.Start();
            }
        }

        public void StartProducer(Product.categoryType category)
        {
            if(producers.TryGetValue(category, out var producer))
            {
                producer.IsRunning = true;
                Thread producerThread = new Thread(producer.Run);
                producerThread.Start();
            }
        }

        public void StopConsumer(Product.categoryType category)
        {
            if(consumers.TryGetValue(category, out var consumer))
            {
                consumer.IsRunning = false;
            }
        }

        public void StopProducer(Product.categoryType category)
        {
            if (producers.TryGetValue(category, out var producer))
            {
                producer.IsRunning = false;
            }
        }

        public void Start()
        {
            MakeConsumers();
            MakeProducers();
            managerThread = new Thread(Run);
        }

        public void Run()
        {
            AddTestProducts();
            while(isRunning)
            {
                UpdateWillysTextBox();
                UpdateCarrefourTextBox();
                UpdateIcaTextBox();
                mainForm.UpdateBufferBar(Storage.ComponentsInBuffer);
                Thread.Sleep(2000);
            }
        }

        public string[] GetWillysInfo()
        {
            if (consumers[Product.categoryType.Bread].products.Count == 0)
            {
                return new string[] { "Empty" };
            }
            string[] infoStrings = new string[consumers[Product.categoryType.Bread].products.Count + 1];

            infoStrings[0] = $"Products Available:{consumers[Product.categoryType.Bread].products.Count}";

            for (int i = 0; i < consumers[Product.categoryType.Bread].products.Count; i++)
            {
                infoStrings[i + 1] = consumers[Product.categoryType.Bread].products[i].ToString();
            }
            return infoStrings;
        }

        public string[] GetCarrefourInfo()
        {
            if (consumers[Product.categoryType.Electronics].products.Count == 0)
            {
                return new string[] { "Empty" };
            }
            string[] infoStrings = new string[consumers[Product.categoryType.Electronics].products.Count + 1];

            infoStrings[0] = $"Products Available:{consumers[Product.categoryType.Electronics].products.Count}";

            for (int i = 0; i < consumers[Product.categoryType.Electronics].products.Count; i++)
            {
                infoStrings[i + 1] = consumers[Product.categoryType.Electronics].products[i].ToString();
            }
            return infoStrings;
        }

        public string[] GetIcaInfo()
        {
            if (consumers[Product.categoryType.Produce].products.Count == 0)
            {
                return new string[] { "Empty" };
            }
            string[] infoStrings = new string[consumers[Product.categoryType.Produce].products.Count + 1];

            infoStrings[0] = $"Products Available:{consumers[Product.categoryType.Produce].products.Count}";

            for (int i = 0; i < consumers[Product.categoryType.Produce].products.Count; i++)
            {
                infoStrings[i + 1] = consumers[Product.categoryType.Produce].products[i].ToString();
            }
            return infoStrings;
        }

        public void UpdateWillysTextBox()
        {
            string[] strings = GetWillysInfo();
            if(mainForm.WillysTextBox.InvokeRequired)
            {
                mainForm.WillysTextBox.Invoke(new Action(UpdateWillysTextBox));
            }
            else
            {
                ClearWillysTextBox();
                foreach(string info in strings)
                {
                    mainForm.UpdateWillysProducts(info);
                }
            }
        }

        public void UpdateCarrefourTextBox()
        {
            string[] strings = GetCarrefourInfo();
            if (mainForm.CarrefourTextBox.InvokeRequired)
            {
                mainForm.CarrefourTextBox.Invoke(new Action(UpdateCarrefourTextBox));
            }
            else
            {
                ClearCarrefourTextBox();
                foreach (string info in strings)
                {
                    mainForm.UpdateCarrefourProducts(info);
                }
            }
        }

        public void UpdateIcaTextBox()
        {
            string[] strings = GetIcaInfo();
            if (mainForm.IcaTextBox.InvokeRequired)
            {
                mainForm.IcaTextBox.Invoke(new Action(UpdateIcaTextBox));
            }
            else
            {
                ClearIcaTextBox();
                foreach (string info in strings)
                {
                    mainForm.UpdateIcaProducts(info);
                }
            }
        }

        private void ClearWillysTextBox()
        {
            mainForm.WillysTextBox.Items.Clear();
        }
        private void ClearCarrefourTextBox()
        {
            mainForm.CarrefourTextBox.Items.Clear();
        }
        private void ClearIcaTextBox()
        {
            mainForm.IcaTextBox.Items.Clear();
        }
        


    }
}
