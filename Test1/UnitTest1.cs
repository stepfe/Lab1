using NUnit.Framework;
using Laba1;
namespace Test1
{
    public class Tests
    {
        
        
        private LinkedList<int> list;
        
        [SetUp]
        public void Setup()
        {
            list = new LinkedList<int>();
            list.pushBack(new Node<int>(1));
            list.pushBack(new Node<int>(2));
            list.pushBack(new Node<int>(3));
        }

        [Test]

        public void POP_BACK()
        {
            list.popLast();
            Assert.AreEqual(2, list.popLast().getData());
        }

        [Test]
        public void POP_FIRST()
        {
            list.popFirst();
            Assert.AreEqual(2, list.popFirst().getData());
        }

        [Test]
        public void POP_BACK_IN_EMPTY()
        {
            list = new LinkedList<int>();
            Assert.AreEqual(null, list.popLast());
        }

        [Test]

        public void POP_FIRST_IN_EMPTY()
        {
            list = new LinkedList<int>();
            Assert.AreEqual(null, list.popFirst());
        }

        [Test]
        public void PUSH_BACK()
        {
            list.pushBack(new Node<int>(4));
            Assert.AreEqual(4, list.popLast().getData());
        }

        [Test]

        public void PUSH_BACK_IN_EMPTY()
        {
            list = new LinkedList<int>();
            list.pushBack(new Node<int>(1));
            Assert.AreEqual(1, list.popLast().getData());
        }

        [Test]

        public void PUSH_FORWARD()
        {
            list = new LinkedList<int>();
            list.pushForward(new Node<int>(0));
            Assert.AreEqual(0, list.popFirst().getData());
        }

        [Test]

        public void PUSH_FORWARD_IN_EMPTY()
        {
            list = new LinkedList<int>();
            list.pushForward(new Node<int>(1));
            Assert.AreEqual(1, list.popLast().getData());
        }

        [Test]

        public void REVERSE()
        {
            bool isOk = true;
            list.reverse();

            for (int i = 1; i < 4; i++)
            {
                if (list.popLast().getData() != i)
                    isOk = false;
                
            }
            
            Assert.AreEqual(true, isOk);
        }
    }
}