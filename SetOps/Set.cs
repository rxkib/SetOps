using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace SetOps
{
    public class Set
    {
        #region Exceptions
        public class ElementAlreadyInserted : Exception { };
        public class TheSetIsEmpty : Exception { };
        public class ElementDoesNotExist : Exception { };
        #endregion


        private List<int> elements;
        private int largestEntry;

        public Set()  //initializing the elements list and largestEntry in the constructor
        {
            elements = new List<int>();
            largestEntry = int.MinValue;
        }

        #region Insert

        // inserting an element into the set
        public void Insert(int m)
        {
            foreach (int e in elements)
            {
                if (e == m)
                {
                    throw new ElementAlreadyInserted();
                }
            }

            elements.Add(m);
            if (m > largestEntry)
            {
                largestEntry = m;
            }
        }
        #endregion


        #region Remove

        // removing an element from the set
        public void Remove(int m)
        {
            if (elements.Count < 1) throw new TheSetIsEmpty();

            bool same = false;

            foreach (int e in elements)
            {
                if (e == m)
                {
                    same = true;
                    elements.Remove(m);
                    break;
                }
            }

            if (!same) throw new ElementDoesNotExist();

            if (m == largestEntry)
            {
                largestEntry = elements.Count > 0 ? elements.Max() : int.MinValue;
            }
        }

        #endregion

        #region Empty

        // checking if the set is empty 
        public bool IsEmpty()
        {
            return elements.Count == 0;
        }

        // checking if the set contains an element
        public bool Contains(int m)
        {
            if (elements.Count < 1) throw new TheSetIsEmpty();

            foreach (int e in elements)
            {
                if (e == m)
                {
                    return true;
                }
            }

            return false;
        }

        #endregion

        #region Random
        // returning a random element without removing it from the set
        public int RandomElement()
        {
            if (elements.Count < 1) throw new TheSetIsEmpty();

            Random random = new Random();
            int randomInd = random.Next(elements.Count);
            return elements[randomInd];
        }
        #endregion

        #region LargestElement
        // returning the largest element in the set
        public int Largest()
        {
            if (elements.Count < 1) throw new TheSetIsEmpty();
            return largestEntry;
        }

        #endregion


        #region Print

        // printing the set
        public void PrintSet()
        {
            if (elements.Count < 1) throw new TheSetIsEmpty();

            Console.Write("{ ");
            foreach (int m in elements)
            {
                Console.Write(m + " ");
            }
            Console.WriteLine("}");
        }

        #endregion
    }
}
