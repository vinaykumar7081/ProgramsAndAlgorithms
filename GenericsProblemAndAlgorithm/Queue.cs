using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblemAndAlgorithm
{
    public class Queue<T> where T : IComparable

    {
        private Node<T> top;
        Node<T> head = null;
        decimal total_Amount;
        public Queue()
        {
            this.top = null;
            this.total_Amount = 0;
        }
        public void Enqueue(T data)
        {
            Node<T> node = new Node<T>(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
                Console.WriteLine("inserted into Queue" + node.data);
            }
            DisplayQueue();
        }
        public void DisplayQueue()
        {
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine(" ");
        }
        internal void Dequeue()
        {
            if (this.head == null)
            {
                Console.WriteLine("Queue is empty, Deletion is not possible");
                return;
            }
            else
            {
                while (this.head != null)
                {
                    Console.WriteLine("Value Dequeued is " + this.head.data);
                    this.head = this.head.next;
                }
            }
        }
        public void DepositeCashCounter(decimal total_cash, decimal minAmount,decimal maxAmount)
        {
          
            while (this.head != null)
            {
                Console.WriteLine("Enter the Deposite Amount");
                decimal depositAmount=Convert.ToDecimal(Console.ReadLine());
                if (minAmount < depositAmount && depositAmount < maxAmount)
                {
                    total_cash = total_cash - depositAmount;
                    Console.WriteLine("Total  Amount is :" + total_cash);
                }
                else 
                {
                Console.WriteLine(" $$$$$$$$$ Please Enter the Valid Amount ####### ");
                }
                this.head = this.head.next;
            }
            Console.WriteLine("Total  Amount is :" + total_cash);
        }
        public void CrediteCashCounter(decimal total_cash, decimal minAmount, decimal maxAmount)
        {
            while (this.head != null)
            {
                Console.WriteLine("Enter the Credite Amount");
                decimal crediteAmount = Convert.ToDecimal(Console.ReadLine());
                if (minAmount < crediteAmount && crediteAmount < maxAmount)
                {
                    total_cash = total_cash + crediteAmount;
                    Console.WriteLine("Total  Amount is :" + total_cash);
                }
                else
                {
                    Console.WriteLine(" $$$$$$$$$ Please Enter the Valid Amount ####### ");
                }
                this.head = this.head.next;
            }
            Console.WriteLine("Total  Amount is :" + total_cash);
        }
    }
}
