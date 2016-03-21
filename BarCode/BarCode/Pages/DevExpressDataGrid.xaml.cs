using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace BarCode.Pages
{
    public partial class DevExpressDataGrid : ContentPage
    {
        public DevExpressDataGrid()
        {
            InitializeComponent();

            //声明对象
            TestOrdersRepository model = new TestOrdersRepository();
            //上下文绑定数据模型
            BindingContext = model;
        }
    }

    /// <summary>
    /// 排序类
    /// </summary>
    public class Order : ModelObject
    {

        DateTime date;
        bool shipped;
        Product product;
        int quantity;

        public Order()
        {
            this.date = DateTime.Today;
            this.shipped = false;
            this.product = new Product("", 0);
            this.quantity = 0;
        }

        public Order(DateTime date, bool shipped, Product product, int quantity)
        {
            this.date = date;
            this.shipped = shipped;
            this.product = product;
            this.quantity = quantity;
        }

        public DateTime Date
        {
            get { return date; }
            set
            {
                if (date != value)
                {
                    date = value;
                    RaisePropertyChanged("Date");
                }
            }
        }

        public bool Shipped
        {
            get { return shipped; }
            set
            {
                if (shipped != value)
                {
                    shipped = value;
                    RaisePropertyChanged("Shipped");
                }
            }
        }

        public Product Product
        {
            get { return product; }
            set
            {
                if (product != value)
                {
                    product = value;
                    RaisePropertyChanged("Product");
                }
            }
        }

        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (quantity != value)
                {
                    quantity = value;
                    RaisePropertyChanged("Quantity");
                }
            }
        }
    }

    /// <summary>
    /// 商品类
    /// </summary>
    public class Product : ModelObject
    {
        string name;
        int unitPrice;

        public Product(string name, int unitPrice)
        {
            this.name = name;
            this.unitPrice = unitPrice;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }
    }

    public class ModelObject : System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(name));
        }
    }

    /***********************/
    public abstract class OrdersRepository
    {
        readonly System.Collections.ObjectModel.ObservableCollection<Order> orders;

        public OrdersRepository()
        {
            this.orders = new System.Collections.ObjectModel.ObservableCollection<Order>();
        }

        public System.Collections.ObjectModel.ObservableCollection<Order> Orders
        {
            get { return orders; }
        }
    }

    public class TestOrdersRepository : OrdersRepository
    {

        const int orderCount = 100;
        readonly List<Product> products;
        readonly Random random;

        public TestOrdersRepository() : base()
        {
            this.random = new Random((int)DateTime.Now.Ticks);
            this.products = new List<Product>();

            GenerateProducts();

            for (int i = 0; i < orderCount; i++)
                Orders.Add(GenerateOrder(i));
        }

        Order GenerateOrder(int number)
        {
            Order order = new Order(new DateTime(2014, 1, 1).AddDays(random.Next(0, 60)),
                number % 3 == 0, RandomItem<Product>(products), random.Next(1, 100));
            return order;
        }

        T RandomItem<T>(IList<T> list)
        {
            int index = (int)(random.NextDouble() * 0.99 * (list.Count));
            return list[index];
        }

        void GenerateProducts()
        {
            products.Add(new Product("Tofu", 50));
            products.Add(new Product("Chocolade", 34));
            products.Add(new Product("Ikura", 70));
            products.Add(new Product("Chai", 3));
            products.Add(new Product("Boston Crab Meat", 36));
            products.Add(new Product("Ravioli Angelo", 18));
            products.Add(new Product("Ipon Coffee", 10));
            products.Add(new Product("Questo Cabrales", 25));
        }
    }
}
