using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Models
{
    public class MaxHeap
    {
        private int[] items;
        public int numItems { get; internal set; }

        public MaxHeap(int[] toHeapify, int size)
        {
            if (toHeapify == null)
            {
                throw new ArgumentNullException("Cannot pass null array.");
            }
            if (size < toHeapify.Length)
            {
                throw new ArgumentException("Heap size must be at least as big as array toHeapify.");
            }

            this.numItems = toHeapify.Length;
            this.items = new int[size];
            copy(toHeapify);
            heapify();            
        }

        private void heapify()
        {
            //get the last parent item in the unsorted array
            int parent = (this.numItems - 2) / 2;

            //sift down parent and all items to the left
            for(int i = parent; i >= 0; i--)
            {
                siftDown(parent);
            }            
        } 

        private void copy(int[] heapified)
        {
            for (int i = 0; i < heapified.Length; i++)
            {
                this.items[i] = heapified[i];
            }
        }

        public bool insert(int item)
        {
            if (this.numItems == this.items.Length)
            {
                return false;
            }

            this.items[numItems] = item;            
            siftUp(item);
            this.numItems++;

            return true;
        }

        public int peek()
        {
            if (this.numItems == 0)
            {
                throw new ArgumentOutOfRangeException("The heap is empty.");
            }

            return this.items[0];
        }
        public int remove()
        {
            if (this.numItems == 0)
            {
                throw new ArgumentOutOfRangeException("The heap is empty.");
            }

            //save result in the front of the queue and decrement numItems
            int result = this.items[0];
            this.numItems--;

            //move last item in heap to front and "sift down"
            this.items[0] = this.items[this.numItems];
            siftDown(0);

            return result;            
        }

        private void siftDown(int i)
        {
            //set index references for item to be sifted (parent) and leftmost child
            int parent = i;
            int child = 2 * parent + 1;
            int itemToSift = this.items[i];

            //traverse the heap from top down and swap places with item until the item's children
            //are both less than the item
            while(child < this.numItems)
            {
                //set child index reference to the greater of the two children
                if(child < this.numItems -1 && this.items[child] < this.items[child+1])
                {
                    child++;
                }
                //if the item to sift is >= both its children, the sifting is done
                if(itemToSift >= this.items[child])
                {
                    break;
                }
                //swap the parent (item being sifted) with its larger child
                this.items[parent] = this.items[child];
                parent = child;
                child = 2 * parent + 1;
            }

            //once sifting is done, set the item in its final place in the heap
            this.items[parent] = itemToSift;
        }

        private void siftUp(int item)
        {
            int childPos = this.numItems;
            int parentPos = (childPos - 1) / 2;

            while (this.items[childPos] > this.items[parentPos])
            {
                int temp = this.items[parentPos];
                this.items[parentPos] = this.items[childPos];
                this.items[childPos] = temp;
                childPos = parentPos;
                parentPos = (childPos - 1) / 2;
            }
        }
    }
}
