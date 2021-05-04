using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling
{
    class QueueOperations
    {
        Queue<string> myQueue;
        public QueueOperations()
        {
            myQueue = new Queue<string>();
        }
        void enQueueOp()
        {
            myQueue.Enqueue("Dheeraj");
            myQueue.Enqueue("Venkat");
            myQueue.Enqueue("saikrishna");
        }
        void QueueCount()
        {
            Console.WriteLine("count : "+myQueue.Count);
        }
        void deQueue()
        {
            while(myQueue.Count>0)
            {
                Console.WriteLine(myQueue.Dequeue());
            }
        }
        static void Main(string[] args)
        {
            QueueOperations Qo = new QueueOperations();
            Qo.enQueueOp();
            Qo.QueueCount();
            Qo.deQueue();
           
        }

    }
}
