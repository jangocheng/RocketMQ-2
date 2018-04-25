using org.apache.rocketmq.client.producer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class pro
    {
        static void Main(string[] args)
        {
            DefaultMQProducer p = new DefaultMQProducer(" test ");
            p.setNamesrvAddr(" 192.168.100.3:9876 ");
            P.start();
            var data = Encoding.UTF8.GetBytes(txbMessage.Text);
            cMessage m = new com.alibaba.rocketmq.common.message.Message(" defaulttopic1 ", data);
            P.send(m);
            P.shutdown();
        }
    }
}
