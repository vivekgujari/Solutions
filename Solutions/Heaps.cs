using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions
{
    public class Heaps
    {
        public int[] array;
        public int size;
        public Heaps()
        {
            array = new int[10];
            size = 0;
        }

        public void insert(int item)
        {
            array[size++] = item;
            bubbleUp(size--);
        }

        private void bubbleUp(int index)
        {
            int parent = getparent(index);
            while (array[index] > array[parent])
            {
                swap(array, index, parent);
                index = parent;
            }
        }

        private void swap(int[] array, int index, int parent)
        {
            int temp = array[index];
            array[index] = array[parent];
            array[parent] = temp;
        }

        private int leftchild(int parent)
        {
            return 2 * parent + 1;
        }
        private int rightchild(int parent)
        {
            return 2 * parent + 2;
        }
        private int getparent(int child)
        {
            return (child - 1) / 2;
        }
    }
}
