using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            LoadBalancer balancer1 = LoadBalancer.getLoadBalancer();
            LoadBalancer balancer2 = LoadBalancer.getLoadBalancer();
            LoadBalancer balancer3 = LoadBalancer.getLoadBalancer();
            LoadBalancer balancer4 = LoadBalancer.getLoadBalancer();
            if (balancer1 == balancer2 && balancer1 == balancer3 && balancer1 == balancer4) Console.WriteLine("服务器负载均衡性具有唯一性!");
            balancer1.addServer("Server 1");
            balancer1.addServer("Server 2");
            balancer1.addServer("Server 3");
            balancer1.addServer("Server 4");
            for(int i = 0; i < 10; i++)
            {
                String server = balancer1.getServer();
                Console.WriteLine("分发请求至服务器："+server);
            }
        }
    }
    class LoadBalancer
    {
        private static LoadBalancer instance = null;
        private List<string> serverList = null;
        private static Random random = new Random();
        private LoadBalancer()
        {
            serverList = new List<string>();
        }
        public static LoadBalancer getLoadBalancer()
        {
            if (instance == null) instance = new LoadBalancer();
            return instance;
        }
        public void addServer(String server)
        {
            serverList.Add(server);
        }
        public void removeServer(String server)
        {
            serverList.Remove(server);
        }
        public string getServer()
        {
            int i = random.Next(serverList.Count);
            return serverList.ElementAt(i);
        }
    }
}
