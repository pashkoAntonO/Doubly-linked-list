using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Doubly_linked_list
{
    class DoublyLinkedList<T> : IEnumerable<T>
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }
        public int Count { get; private set; } = 0;


        public void AddFirst(T value)
        {
            Node<T> node = new Node<T>(value);
            Node<T> tmp = Head;

            node.Next = tmp;

            if (Head != null)
            {
                tmp.Previous = node;
            }
            else
            {
                Tail = Head;
            }

            Count++;
        }

        public void AddLast(T value)
        {
            Node<T> node = new Node<T>(value);


            if(Head == null)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
                node.Previous = Tail;
            }

            Tail = node;

            Count++;

        }

        public void RemoveFirst()
        {
            Head = Head.Next;

            Count--;

            if(Count == 0)
            {
                Tail = null;
            }
            else
            {
                Head.Previous = null;
            }
            
        }
        public void RemoveLast()
        {
            Tail = Tail.Previous;

            Count--;

            if (Count == 0)
            {
                Head = null;
            }
            else
            {
                Tail.Next = null;
            }

        }

        public void Remove(T value)
        {
            Node<T> current = Head;
            Node<T> previous = null;

            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                   
                    // Если узел в начале
                    if (current.Equals(Head))
                    {
                        RemoveFirst();
                        return;
                    }
                    // Если узел в конце
                    if (current.Next == null)
                    {
                        RemoveLast();
                        return;
                    }
                    //Если в середине
                    previous.Next = current.Next;
                    current.Previous = previous;
                    return;
                }

                current = current.Next;
                previous = current;

            }

            return;
        }

        public void Sort(T value)
        {
            Node<T> current = Head;
            Node<T> previous = null;

            while (current != null)
            {
                if (current.Value.Equals(value))
                {

                    // Если узел в начале
                    if (current.Equals(Head))
                    {
                        RemoveFirst();
                        return;
                    }
                    // Если узел в конце
                    if (current.Next == null)
                    {
                        RemoveLast();
                        return;
                    }
                    //Если в середине
                    previous.Next = current.Next;
                    current.Previous = previous;
                    return;
                }
                current = current.Next;
                previous = current;

            }
            return;
        }


        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = Head;

            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

    }
}
