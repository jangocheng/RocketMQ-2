//using com.sun.tools.@internal.ws.wsdl.document;
using com.sun.corba.se.impl.protocol.giopmsgheaders;
using java.util;
using org.apache.rocketmq.client.consumer.listener;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TestListener : MessageListenerConcurrently
    {
        public ConsumeConcurrentlyStatus consumeMessage(List list, ConsumeConcurrentlyContext ccc)
        {
            for(int i = 0 ; i < list.size(); i++ ) 
              {
                var msg = list.get(i) as Message;
                Byte[] body = msg.GetBody();
                var str = Encoding.UTF8.GetString(body);
                if(body.Length == 2 && body[0] == 0 && body[1] == 0)
                  {

                    // System.out.println("Got the end signal");
                    continue;
                }

            }
            return ConsumeConcurrentlyStatus.CONSUME_SUCCESS;
        }

        public ConsumeConcurrentlyStatus ConsumeMessage(List l, ConsumeConcurrentlyContext ccc)
        {
            throw new NotImplementedException();
        }
    }
}
