using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Based_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Create an empty default arrayStack");
                ArrayStack myArrayStack = new ArrayStack();

                Console.WriteLine("Test default values of top and array");
                PrintArrayStackElements(myArrayStack);

                Console.WriteLine("Push first integer into myArrayStack");
                myArrayStack.push(1);

                Console.WriteLine("Push second integer into myArrayStack");
                myArrayStack.push(2);

                Console.WriteLine("Push third integer into myArrayStack");
                myArrayStack.push(3);

                Console.WriteLine("Current top of myArrayStack is " + myArrayStack.peek() + Environment.NewLine);

                Console.WriteLine("Test values of top and array after push 1 into the stack");
                PrintArrayStackElements(myArrayStack);

                Console.WriteLine("Pop first integer from myArrayStack");
                myArrayStack.pop();

                Console.WriteLine("Pop second integer from myArrayStack");
                myArrayStack.pop();

                Console.WriteLine("Current top of myArrayStack is " + myArrayStack.peek() + Environment.NewLine);

                Console.WriteLine("Test values of top and array after pop 1 from the stack");
                PrintArrayStackElements(myArrayStack);

            }
            catch (OverflowException uex)
            {
                Console.WriteLine(uex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }


        #region Methods
        //Print stack elements
        static void PrintArrayStackElements(ArrayStack myStack)
        {
            Console.WriteLine("Index of current Top of stack: " + myStack.Size);
            for (int i = myStack.Stack.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("Integer " + i + ": " + myStack.Stack[i]);
            }
            Console.WriteLine("");
        }

        #endregion

    }
}
