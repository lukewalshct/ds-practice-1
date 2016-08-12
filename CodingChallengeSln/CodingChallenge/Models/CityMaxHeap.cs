using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Models
{
    public class CityMaxHeap
    {
        private City[] cities;
        public int numCities { get; internal set; }

        public CityMaxHeap(int[] popsToHeapify)
        {
            if (popsToHeapify == null)
            {
                throw new ArgumentNullException("Cannot pass null array.");
            }

            this.numCities = popsToHeapify.Length;
            this.cities = new City[this.numCities];

            createCities(popsToHeapify);
            heapifyCities();                                                
        }

        private void createCities(int[] popsToHeapify)
        {
            for(int i = 0; i < popsToHeapify.Length; i++)
            {
                if(!(popsToHeapify[i] >= 1 && popsToHeapify[i] <= 5000000))
                {
                    throw new ArgumentOutOfRangeException("City populations must be between 1 and 5,000,000.");
                }
                this.cities[i] = new City(popsToHeapify[i]);
            }
        }

        private void heapifyCities()
        {
            //get the last parent item in the unsorted array
            int parent = (this.numCities - 2) / 2;

            //sift down parent and all items to the left
            for(int i = parent; i >= 0; i--)
            {
                siftDown(parent);
            }            
        } 

        public void addClinic()
        {
            City c = this.cities[0];
            c.addClinic();
            siftDown(0);
        }        

        public int peek()
        {
            if (this.numCities == 0)
            {
                throw new ArgumentOutOfRangeException("The heap is empty.");
            }
            return this.cities[0].maxClinicPop;
        }
        
        private void siftDown(int i)
        {
            //set index references for item to be sifted (parent) and leftmost child
            int parent = i;
            int child = 2 * parent + 1;
            City cityToSift = this.cities[i];

            //traverse the heap from top down and swap places with item until the item's children
            //are both less than the item
            while(child < this.numCities)
            {
                //set child index reference to the greater of the two children
                if(child < this.numCities -1 && this.cities[child].maxClinicPop < 
                    this.cities[child+1].maxClinicPop)
                {
                    child++;
                }
                //if the item to sift is >= both its children, the sifting is done
                if(cityToSift.maxClinicPop >= this.cities[child].maxClinicPop)
                {
                    break;
                }
                //swap the parent (item being sifted) with its larger child
                this.cities[parent] = this.cities[child];
                parent = child;
                child = 2 * parent + 1;
            }

            //once sifting is done, set the item in its final place in the heap
            this.cities[parent] = cityToSift;
        }

        class City
        {
            int origPop;
            int numClinics;
            public int maxClinicPop { get; internal set; }

            public City(int pop)
            {
                this.origPop = this.maxClinicPop = pop;
                this.numClinics = 1;
            }

            public void addClinic()
            {
                this.numClinics++;
                this.maxClinicPop = (int)Math.Ceiling((double)this.origPop / this.numClinics);
            }
        }            
    }    
}
