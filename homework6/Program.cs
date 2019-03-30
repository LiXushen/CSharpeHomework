using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ordertest
{
    public class MainClass
    {
        public static void Main()
        {
            try
            {
                Customer customer1 = new Customer(1, "Customer1");
                Customer customer2 = new Customer(2, "Customer2");

                Goods milk = new Goods(1, "Milk", 69.9);
                Goods eggs = new Goods(2, "eggs", 4.99);
                Goods apple = new Goods(3, "apple", 5.59);

                OrderDetail orderDetails1 = new OrderDetail(1, apple, 8);
                OrderDetail orderDetails2 = new OrderDetail(2, eggs, 2);
                OrderDetail orderDetails3 = new OrderDetail(3, milk, 1);

                Order order1 = new Order(1, customer1);
                Order order2 = new Order(2, customer2);
                Order order3 = new Order(3, customer2);
                order1.AddDetails(orderDetails1);
                order1.AddDetails(orderDetails2);
                order1.AddDetails(orderDetails3);
                //order1.AddOrderDetails(orderDetails3);
                order2.AddDetails(orderDetails2);
                order2.AddDetails(orderDetails3);
                order3.AddDetails(orderDetails3);

                OrderService os = new OrderService();
                os.AddOrder(order1);
                os.AddOrder(order2);
                os.AddOrder(order3);

                Console.WriteLine("GetAllOrders");
                List<Order> orders = os.QueryAllOrders();
                foreach (Order order in orders)
                    Console.WriteLine(order.ToString());

                Console.WriteLine("GetOrdersByCustomerName:'Customer2'");
                orders = os.QueryByCustomerName("Customer2");
                foreach (Order order in orders)
                    Console.WriteLine(order.ToString());

                Console.WriteLine("GetOrdersByGoodsName:'apple'");
                orders = os.QueryByGoodsName("apple");
                foreach (Order order in orders)
                    Console.WriteLine(order);

                Console.WriteLine("Remove order(id=2) and qurey all");
                os.RemoveOrder(2);
                os.QueryAllOrders().ForEach(
                    od => Console.WriteLine(od));



                os.Export();
                os.Import();
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
    /// <summary>
    /// OrderService:provide ordering service,
    /// like add order, remove order, query order and so on
    /// 实现添加订单、删除订单、修改订单、查询订单（按照订单号、商品名称、客户等字段进行查询)
    /// </summary>
    [Serializable]
    public class OrderService
    {

        public List<Order> orderList;
        /// <summary>
        /// OrderService constructor
        /// </summary>
        public OrderService()
        {
            orderList = new List<Order>();
        }

        /// <summary>
        /// add new order
        /// </summary>
        /// <param name="order">the order will be added</param>
        public void AddOrder(Order order)
        {
            
          foreach (Order o in orderList)
            {
                if (o.Id.Equals(order.Id))
                {
                    throw new Exception($"order-{order.Id} is already existed!");
                }
            }
            orderList.Add(order);
            
        }

        /// <summary>
        /// query by orderId
        /// </summary>
        /// <param name="orderId">id of the order to find</param>
        /// <returns>List<Order></returns> 
        public Order GetById(uint orderId)
        {
            foreach (Order o in orderList)
            {
                if (o.Id == orderId)
                {
                    return o;
                }
            }
            return null;
        }

        /// <summary>
        /// remove order
        /// </summary>
        /// <param name="orderId">id of the order which will be removed</param> 
        public void RemoveOrder(uint orderId)
        {
            Order order = GetById(orderId);
            if (order == null) return;
            orderList.Remove(order);
        }

        /// <summary>
        /// query all orders
        /// </summary>
        /// <returns>List<Order>:all the orders</returns> 
        public List<Order> QueryAllOrders()
        {
            return orderList;
        }


        /// <summary>
        /// query by goodsName
        /// </summary>
        /// <param name="goodsName">the name of goods in order's orderDetail</param>
        /// <returns></returns> 
        public List<Order> QueryByGoodsName(string goodsName)
        {
            List<Order> result = new List<Order>();
            foreach (Order order in orderList)
            {
                foreach (OrderDetail detail in order.Details)
                {
                    if (detail.Goods.Name == goodsName)
                    {
                        result.Add(order);
                        break;
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// query by customerName
        /// </summary>
        /// <param name="customerName">customer name</param>
        /// <returns></returns> 
        public List<Order> QueryByCustomerName(string customerName)
        {
            var query = orderList
                .Where(order => order.Customer.Name == customerName);
            return query.ToList();
        }


        public void Import()//读入
        {
            
            orderList.Clear();
            XDocument XDoc = XDocument.Load(@"Order.xml");

            var elementsa = from element in XDoc.Elements("Order") select element;
            foreach (var e in elementsa)
            {
                Order order = new Order();
                order.Id = uint.Parse(e.Attribute("Id").ToString());
                    var elementsb = from element in e.Elements("Customer") select element;
                    var f = elementsb.ElementAt(0);
                    Customer customer = new Customer();
                    customer.Id = uint.Parse(f.Attribute("Id").ToString());
                    customer.Name = f.Attribute("Name").ToString();
                order.Customer = customer;
                    var  elementsc = from element in e.Elements("Details") select element;
                    f = elementsc.ElementAt(0);
                    List<OrderDetail> details = new List<OrderDetail>();
                        var elementsd = from element in e.Elements("OrderDetail") select element;
                        foreach (var g in elementsd)
                        {
                            OrderDetail detail = new OrderDetail();
                            detail.Id = uint.Parse(g.Attribute("Id").ToString());
                            detail.Quantity = uint.Parse(g.Attribute("Quantity").ToString());
                                var elementse = from element in e.Elements("OrderDetail") select element;
                                f = elementse.ElementAt(0);
                                Goods goods = new Goods();
                                goods.Id = uint.Parse(f.Attribute("Id").ToString());
                                goods.Price = double.Parse(f.Attribute("Price").ToString());
                                goods.Name = f.Attribute("Name").ToString();
                            detail.Goods = goods;
                            details.Add(detail);
                        }
                order.Details = details;
                orderList.Add(order); 
            }
        }

        public void Export()//输出
        {
            
            XmlSerializer xmlser = new XmlSerializer(typeof(List<Order>));
            String filename = "order.xml";
            XmlSerialize(xmlser, filename, orderList);
            Console.WriteLine("已输出为xml文件！");
            
        }
        public static void XmlSerialize(XmlSerializer ser, String filename, object obj)
        {
            FileStream fs = new FileStream(filename, FileMode.Create);
            ser.Serialize(fs, obj);
            fs.Close();
        }
    }
    /// <summary>
    /// OrderDetail class : a entry of an order object
    /// to record the goods and its quantity
    /// </summary>
    [Serializable]
    public class OrderDetail
    {

        /// <summary>
        /// OrderDetail constructor
        /// </summary>
        /// <param name="id">orderDetail's id</param>
        /// <param name="goods">orderDetail's goods</param>
        /// <param name="quantity">goods quantity</param>
        public OrderDetail(uint id, Goods goods, uint quantity)
        {
            this.Id = id;
            this.Goods = goods;
            this.Quantity = quantity;
        }
        /// <summary>
        /// OrderDetail's id
        /// </summary>
        public uint Id { get; set; }

        /// <summary>
        /// orderDetail's goods
        /// </summary>
        public Goods Goods { get; set; }

        /// <summary>
        /// goods quantity
        /// </summary>
        public uint Quantity { get; set; }

        public OrderDetail() { }
        public override bool Equals(object obj)
        {
            var detail = obj as OrderDetail;
            return detail != null &&
                Goods.Id == detail.Goods.Id &&
                Quantity == detail.Quantity;
        }

        public override int GetHashCode()
        {
            var hashCode = 1522631281;
            hashCode = hashCode * -1521134295 + Goods.Name.GetHashCode();
            hashCode = hashCode * -1521134295 + Quantity.GetHashCode();
            return hashCode;
        }

        /// <summary>
        /// override ToString
        /// </summary>
        /// <returns>string:message of the OrderDetail object</returns>
        public override string ToString()
        {
            string result = "";
            result += $"orderDetailId:{Id}:  ";
            result += Goods + $", quantity:{Quantity}";
            return result;
        }
    }
    /// <summary>
    /// Order class : all orderDetails
    /// to record each goods and its quantity in this ordering
    /// </summary>
    [Serializable]
    public class Order
    {
        /// <summary>
        /// order id
        /// </summary>
        public uint Id { get; set; }

        /// <summary>
        /// the man who orders goods
        /// </summary>
        public Customer Customer { get; set; }

        public List<OrderDetail> Details = new List<OrderDetail>();

        /// <summary>
        /// Order constructor
        /// </summary>
        /// <param name="orderId">order id</param>
        /// <param name="customer">who orders goods</param>
        public Order() { }
        public Order(uint orderId, Customer customer)
        {
            Id = orderId;
            Customer = customer;
        }
        
        /// <summary>
        /// add new orderDetail to order
        /// </summary>
        /// <param name="orderDetail">the new orderDetail which will be added</param>
        public void AddDetails(OrderDetail orderDetail)
        {
            if (Details.Contains(orderDetail))
            {
                throw new Exception($"orderDetails-{orderDetail.Id} is already existed!");
            }
            Details.Add(orderDetail);
        }

        /// <summary>
        /// remove orderDetail by orderDetailId from order
        /// </summary>
        /// <param name="orderDetailId">id of the orderDetail which will be removed</param>
        public void RemoveDetails(uint orderDetailId)
        {
            Details.RemoveAll(d => d.Id == orderDetailId);
        }

        /// <summary>
        /// override ToString
        /// </summary>
        /// <returns>string:message of the Order object</returns>
        public override string ToString()
        {
            String result = $"orderId:{Id}, customer:({Customer})";
            Details.ForEach(detail => result += "\n\t" + detail);
            return result;
        }
    }
    /// <summary>
    /// Goods class:the message of goods
    /// </summary>
    [Serializable]
    public class Goods
    {
        public Goods() { }
        public double Price;

        /// <summary>
        /// Goods constuctor
        /// </summary>
        /// <param name="id">goods id</param>
        /// <param name="name">goods name</param>
        /// <param name="value">>goods value</param>
        public Goods(uint id, string name, double value)
        {
            Id = id;
            Name = name;
            Price = value;
        }

        /// <summary>
        /// property : goods id
        /// </summary>
        public uint Id { get; set; }

        /// <summary>
        /// property : goods name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// property : goods value
        /// </summary>
        

        /// <summary>
        /// override ToString
        /// </summary>
        /// <returns>string:message of the Goods object</returns>
        public override string ToString()
        {
            return $"Id:{Id}, Name:{Name}, Value:{Price}";
        }
    }
    /// <summary>
    /// Customer the man who orders goods.
    /// </summary>
    [Serializable]
    public class Customer
    {

        /// <summary>
        /// customer's identifier
        /// </summary>
       
        public uint Id { get; set; }

        /// <summary>
        /// customer's name
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// Customer constructor
        /// </summary>
        /// <param name="id">customer id</param>
        /// <param name="name">customer name </param>
        public Customer() { }
        public Customer(uint id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        /// <summary>
        /// override ToString
        /// </summary>
        /// <returns>string:message of the Customer object</returns>
        public override string ToString()
        {
            return $"customerId:{Id}, CustomerName:{Name}";
        }
        
    }
}
