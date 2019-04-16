using Microsoft.VisualStudio.TestTools.UnitTesting;
using ordertest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordertest.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        public static Customer customer1 = new Customer(1, "Customer1");
        public static Customer customer2 = new Customer(2, "Customer2");

        public static Goods milk = new Goods(1, "Milk", 69.9f);
        public static Goods eggs = new Goods(2, "eggs", 4.99f);
        public static Goods apple = new Goods(3, "apple", 5.59f);

        public static Order order1 = new Order(1, customer1);
        public static Order order2 = new Order(2, customer2);
        public static Order order3 = new Order(3, customer2);
       
        public static OrderService orderService = new OrderService();
        public static void Test()
        {
            order1.AddDetails(new OrderDetail(apple, 8));
            order1.AddDetails(new OrderDetail(eggs, 10));
            order1.AddDetails(new OrderDetail(milk, 10));
            
            order2.AddDetails(new OrderDetail(eggs, 10));
            order2.AddDetails(new OrderDetail(milk, 10));

            order3.AddDetails(new OrderDetail(milk, 100));
            
        }

        [TestMethod()]
        public void OrderServiceTest()
        {
            Test();
            //Assert.Fail();
        }

        [TestMethod()]
        public void AddOrderTest()
        {
            //Test();
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            orderService.AddOrder(order3);
            //Assert.Fail();
        }

        [TestMethod()]
        public void UpdateTest()
        {
            orderService.Update(order1);
            //Assert.Fail();
        }

        [TestMethod()]
        public void GetByIdTest()
        {
           orderService.GetById(1);
            //Assert.Fail();
        }

        [TestMethod()]
        public void RemoveOrderTest()
        {
            orderService.RemoveOrder(2);
            //Assert.Fail();
        }

        [TestMethod()]
        public void QueryAllTest()
        {
            orderService.QueryAll();
            //Assert.Fail();
        }

        [TestMethod()]
        public void QueryByGoodsNameTest()
        {
            orderService.QueryByGoodsName("1");
            //Assert.Fail();
        }

        [TestMethod()]
        public void QueryByTotalAmountTest()
        {
            orderService.QueryByTotalAmount(83);
            //Assert.Fail();
        }

        [TestMethod()]
        public void QueryByCustomerNameTest()
        {
            orderService.QueryByCustomerName("1");
            //Assert.Fail();
        }

        [TestMethod()]
        public void SortTest()
        {
            orderService.Sort((a, b) => a.TotalAmount.CompareTo(b.TotalAmount));
            //Assert.Fail();
        }

        [TestMethod()]
        public void ExportTest()
        {
            orderService.Export("ordertest.xml");
            //Assert.Fail();
        }

        [TestMethod()]
        public void ImportTest()
        {
            orderService.Import("ordertest.xml");
            //Assert.Fail();
        }
    }
}