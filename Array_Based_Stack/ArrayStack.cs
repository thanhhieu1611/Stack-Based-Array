using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Based_Stack
{
    class ArrayStack
    {
        #region CLASS VARIABLES
        //what the maximum number of integers in the stack can be
        //Assign an initial value for stack capacity
        private int capacity = 10;

        //contains the actual integers in the stack
        private int[] stack;

        //Top of stack (size)
        private int size;

        #endregion

        #region PROPERTIES
        public int Capacity
        {
            get => capacity;
            set
            {
                capacity = value;
            }
        }

        public int[] Stack
        {
            get => stack;
            set
            {
                stack = value;
            }
        }

        public int Size
        {
            get => size;
            set
            {
                size = value;
            }
        }

        #endregion

        #region CONSTRUCTORS
        //default constructor
        public ArrayStack()
        {
            //Initialize an empty stack
            stack = new int[capacity];

            //Set an empty stack
            size = -1;
        }

        //constructor with capacity parametter
        public ArrayStack(int myCapacity)
        {
            //Initialize an empty stack
            stack = new int[myCapacity];

            //Set an empty stack
            size = -1;
        }
        #endregion

        #region METHODS
        public void push(int x)
        {
            if(size + 1 == stack.Length)
                throw new OverflowException("Need to double the current array!");
            stack[++size] = x;
        }

        public void pop()
        {
            if(size == -1)
                throw new OverflowException("Sorry, you can not pop last value because stack is empty!");
            size--;
            //Remove values in array, which have larger index than current top of the array
            stack[size + 1] = 0;
        }

        public int peek()
        {
            if(size == -1)
                throw new OverflowException("Top if current stack is empty!");
            return stack[size];
        }

        #endregion
    }
}
