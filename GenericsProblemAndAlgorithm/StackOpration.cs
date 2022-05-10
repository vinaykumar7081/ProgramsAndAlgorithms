using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblemAndAlgorithm
{
    public class StackOpration<T>
    {
        private Node<T> top;
        Node<T> head = null;
        public StackOpration()
        {
            this.top = null;
        }
        public void Push(T value)
        {
            Node<T> node = new Node<T>(value);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} pushed to stack" + value);
        }
        internal void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("{0} is in the top of the stack", this.top.data);
            Display();
        }
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty, Deletion is not possible");
                return;
            }
            Console.WriteLine("Value popped is " + this.top.data);
            top = top.next;
            //.Display();
        }
        internal void IsEmpty()
        {
            while (this.top != null)
            {
                Peek();
                Pop();
            }
        }
        public void Display()
        {
            Node<T> temp = this.top;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine(" ");
        }
        int openParenthesiscount = 0;
        int closeParenthesisCount = 0;
        int number = 0;
        public void BalancedParenthesys()
        { 
        Node<T> temp = this.top;
            while(temp != null)
            {
                if (temp.data.Equals( ")" ))
                {
                    closeParenthesisCount++;
                }
                if (temp.data.Equals( "(" ))
                {
                    openParenthesiscount++;
                }
                else
                {
                    number++;
                }
                temp = temp.next;
            }
        }
        public void ComparingParenthesys()
        {
            if (openParenthesiscount == closeParenthesisCount)
            {
                Console.WriteLine("Parenthesys is Balanced");
            }
            else 
            {
                Console.WriteLine("Parenthesys is not Balanced");
            }
        }
    }
}
