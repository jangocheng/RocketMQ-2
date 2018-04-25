using org.apache.rocketmq.client.producer;
using org.apache.rocketmq.common.message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProducerPro
{
    class Program
    {
        static void Main(string[] args)
        {
            DefaultMQProducer p = new DefaultMQProducer(" test ");
            p.setNamesrvAddr("192.168.1.15:9876 ");
            try
            {
                p.start();
                var data = Encoding.UTF8.GetBytes("Hello to all");
                Message m = new Message(" defaulttopic1 ", data);
                p.send(m);
                p.shutdown();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            Console.ReadKey();
        }
    }
}
