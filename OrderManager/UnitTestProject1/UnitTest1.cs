using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using homework_3;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            OrderService service = new OrderService();
            Product coffee1 = new Product("Americano", "coffee", 28);
            Product coffee2 = new Product("Latte", "coffee", 34);
            Product coffee3 = new Product("Mocha", "coffee", 32);
            Customer cus1 = new Customer("Sylvia", "18109100910");
            Customer cus2 = new Customer("Harley", "13510081008");

            OrderItem item_Americano1, item_Latte1, item_Mocha1, item_Americano2, item_Mocha2;
        }

        [TestInitialize()]
        public void init()
        {
            OrderItem item_Americano1 = new OrderItem(coffee1, 10);
            OrderItem item_Latte1 = new OrderItem(coffee2, 5);
            OrderItem item_Mocha1 = new OrderItem(coffee3, 3);
            OrderItem item_Americano2 = new OrderItem(coffee1, 8);
            OrderItem item_Mocha2 = new OrderItem(coffee2, 1);
        }
        [TestMethod]
        public void AddOrderTest()
        {
            service.AddOrder(cus1);
            service.AddOrderItem("00000001", item_Americano1);
            service.AddOrderItem("00000001", item_Latte1);
            service.AddOrderItem("00000001", item_Mocha1);
            service.AddOrder(cus2);
            service.AddOrderItem("00000002", item_Americano2);
            service.AddOrderItem("00000002", item_Mocha2);
            Assert.AreEqual(2, service.OrderCount);
        }
    }
}
