using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OOPAssignment1;


namespace OOPAssignment1.nUnitTests
{
    public class Tests
    {
        private Set set;

        [SetUp]
        public void Setup()
        {
            set = new Set();
        }

        [Test]
        public void TestInsert()
        {
            set.Insert(1);
            set.Insert(2);
            set.Insert(3);
            Assert.Throws < Set.ElementAlreadyInserted > (() => set.Insert(3));
            Assert.That(set.Contains(1));
            Assert.That(set.Contains(2));
            Assert.That(set.Contains(3));
        }

        [Test]
        public void TestRemove()
        {
            set.Insert(1);
            set.Insert(2);
            set.Insert(3);
            set.Remove(2);
            Assert.Throws<Set.ElementDoesNotExist>(() => set.Remove(2));
            Assert.That(!set.Contains(2));
            set.Remove(1);
            Assert.That(!set.Contains(1));
            set.Remove(3);
            Assert.Throws<Set.TheSetIsEmpty>(() => set.Remove(3));  
        }

        [Test]
        public void TestIsEmpty()
        {
            Assert.That(set.IsEmpty());
            set.Insert(1);
            Assert.That(!set.IsEmpty());
            set.Remove(1);
            Assert.That(set.IsEmpty());
        }

        [Test]
        public void TestContains()
        {
            set.Insert(1);
            set.Insert(2);
            set.Insert(3);
            Assert.That(set.Contains(1));
            Assert.That(set.Contains(2));
            Assert.That(set.Contains(3));
            Assert.That(!set.Contains(4));
        }

        [Test]
        public void TestRandomElement()
        {
            set.Insert(1);
            set.Insert(2);
            set.Insert(3);
            int randomElement = set.RandomElement();
            Assert.That(set.Contains(randomElement));

        }

        [Test]
        public void TestLargestElement()
        {
            set.Insert(1);
            set.Insert(5);
            set.Insert(3);
            int largestEntry = set.Largest();
            Assert.That(largestEntry == 5);
            set.Remove(1);
            set.Remove(5);
            set.Remove(3);
            Assert.Throws<Set.TheSetIsEmpty>(() => set.Largest());
        }
    }
}