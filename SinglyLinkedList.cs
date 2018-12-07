using System;

namespace SingleList
{
    public class Program
    {
        public static void Main(string[] args)

        {
            // Instantiate new Linked List of type int, called list.

            LinkedList<int> list = new LinkedList<int>();

            list.AddFirst(3);

            // +-----------+-----------+
            // |     3     |   Null    |
            // +-----------+-----------+

            list.AddLast(5);

            // +-----------+-----------+  +-----------+-----------+
            // |     3     |   Next    |  |     5     |   Null    |      
            // +-----------+-----------+  +-----------+-----------+

            // +-----------+-----------+  +-----------+-----------+
            // |     3     |   Next -------->   5     |   Null    |      
            // +-----------+-----------+  +-----------+-----------+

            list.AddLast(7);

            // +-----------+-----------+  +-----------+-----------+  +-----------+-----------+
            // |     3     |   Next -------->   5     |   Next    |  |      7    |    Null   | 
            // +-----------+-----------+  +-----------+-----------+  +-----------+-----------+

            // +-----------+-----------+  +-----------+-----------+  +-----------+-----------+
            // |     3     |   Next -------->   5     |   Next  -------->   7    |    Null   | 
            // +-----------+-----------+  +-----------+-----------+  +-----------+-----------+

            LinkedList<int>.PrintLinkedList(list);

            // 3 --> 5 --> 7 --> Null

            Console.WriteLine(list.Contains(5));

            // True

            list.RemoveLast(); 

            // +-----------+-----------+  +-----------+-----------+
            // |     3     |   Next -------->   5     |   Null    |      
            // +-----------+-----------+  +-----------+-----------+

            LinkedList<int>.PrintLinkedList(list);
           
            // 3 --> 5 --> Null

            list.AddLast(15);

            // +-----------+-----------+  +-----------+-----------+  +-----------+-----------+
            // |     3     |   Next -------->   5     |   Next    |  |     15    |    Null   | 
            // +-----------+-----------+  +-----------+-----------+  +-----------+-----------+

            // +-----------+-----------+  +-----------+-----------+  +-----------+-----------+
            // |     3     |   Next -------->   5     |   Next  -------->  15    |    Null   | 
            // +-----------+-----------+  +-----------+-----------+  +-----------+-----------+

            LinkedList<int>.PrintLinkedList(list);

            // 3 --> 5 --> 15 --> Null

            list.RemoveFirst();

            // +-----------+-----------+  +-----------+-----------+
            // |     5     |   Next -------->   15    |   Null    |      
            // +-----------+-----------+  +-----------+-----------+

            LinkedList<int>.PrintLinkedList(list);

            //5 --> 15 --> Null

            list.Clear();
            
            LinkedList<int>.PrintLinkedList(list);

            // Null
        }
    }

    // Create a Node class to define a node.

    public class Node<T>
    {
        // Constructor sets initial node value.
        public Node(T value)
        {
            Value = value;
        }

        // public Property: Value of Node.
        public T Value { get; set; }

        // Property: NextPointer
        public Node<T> Next { get; set; }
    }
    // Linked List inherits from ICollection<T> interface.
    // To define methods to manipulate Generic <T> collections.
    // Allows me to make a custom collection<T> of Linked List Nodes.

    public class LinkedList<T> :
        System.Collections.Generic.ICollection<T>
    {

        // Properties are pointers to the head and tail nodes.
        // Auto-Implemented properties, so default to the value null.
        // Private setters so the list can manage values and nothing else.

        public Node<T> Head
        {
            get;
            private set;
        }

        public Node<T> Tail
        {
            get;
            private set;
        }

        // AddFirst Method creates new Node with specified value at head.
        // Add the specified value to the start of the list.

        public void AddFirst(T value)
        {
            AddFirst(new Node<T>(value));
        }

        // AddFirst method where new Node is provided.

        public void AddFirst(Node<T> node)
        {
            // Store head node in temp so we don't lose it. 
            Node<T> temp = Head;

            // Point Head node to new argument node. 
            Head = node;

            // Insert the remaining list behind new head node.
            Head.Next = temp;

            Count++;

            if (Count == 1)
            {
                // If the list was empty then head and tail both point to new node.
                Tail = Head;
            }
        }

        // AddLast method similar to AddFirst
        // Can add by value and create new node
        // or add new node.

        public void AddLast(T value)
        {
            AddLast(new Node<T>(value));
        }

        public void AddLast(Node<T> node)
        {
            if (Count == 0)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
            }

            Tail = node;

            Count++;
        }

        public void RemoveFirst()
        {
            // Simple and efficient operation.
            // Set the head's NextPointer to node that follows head
            // and that's it.

            if (Count != 0)
            {
                // Before: Head -> 3 -> 5 -> null
                // After:  Head ------> 5 -> null
                Head = Head.Next;
                Count--;

                if (Count == 0)
                {
                    Tail = null;
                }
            }
        }

        // RemoveLast method is not very performant 
        // Forced to walk from beginning to end each time.

        public void RemoveLast()
        {
            if (Count != 0)
            {
                if (Count == 1)
                {
                    Head = null;
                    Tail = null;
                }
                else
                {
                    Node<T> current = Head;
                    while (current.Next != Tail)
                    {
                        current = current.Next;
                    }

                    current.Next = null;
                    Tail = current;
                }

                Count--;
            }
        }

        // The number of items in the list.

        public int Count
        {
            get;
            private set;
        }

        public void Add(T item)
        {
            AddFirst(item);
        }

        // Contains method returns true if item is found.
        // False if value not found.
        // Param item is item to search for.

        public bool Contains(T item)
        {
            Node<T> current = Head;
            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    return true;
                }

                current = current.Next;
            }

            return false;
        }

        // CopyTo method copies node values into specified array.
        // Param array is array to copy values to.
        // Param arrayIndex is index in array to start copying at.

        public void CopyTo(T[] array, int arrayIndex)
        {
            Node<T> current = Head;
            while (current != null)
            {
                array[arrayIndex++] = current.Value;
                current = current.Next;
            }
        }

        // Returns true if collection is read only,
        // false oterwise.

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        // Removes the first occurrence of the item from list.
        // Searches from head to tail. 

        public bool Remove(T item)
        {
            Node<T> previous = null;
            Node<T> current = Head;

            // 1. Empty List: Do nothing.
            // 2. Single node: Previous is null.
            // 3. Many nodes: 
            //  a. node to remove is first node.
            //  b. node to remove is middle or last node. 

            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    // It's a node in the middle or end.
                    if (previous != null)
                    {
                        // Case 3b
                        // Before: 3 -> 5 -> 7
                        // After: 3 ------> 7
                        previous.Next = current.Next;

                        // item is Tail, so update Tail to now be previous, removing tail.
                        // Before: Head -> 3 -> 5 -> null
                        // After:  Head -> 3 ------> null
                        if (current.Next == null)
                        {
                            Tail = previous;
                        }

                        //Regardless of case, decrement the count.
                        Count--;
                    }
                    else
                    {
                        // Case 2 ar 3a
                        RemoveFirst();
                    }
                    // If any node is removed:
                    return true;
                }
                // If nothing removed, eventually current will return null.
                // Stop at last node:
                previous = current;
                current = current.Next;
            }
            // Break out of loop and:
            return false;
        }

        // Enumerates over linked list values from Head to Tail. 

        System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = Head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        // Non-generic Colletion Method simply points to Generic Method.

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return ((System.Collections.Generic.IEnumerable<T>)this).GetEnumerator();
        }

        // Removes all nodes from linked list.

        public void Clear()
        {
            // Possible in C# due to Garbage Collection.
            // After setting to null/0 list nodes are garbage collected. 
            // In C/C++ you would have to iterate and remove each node.

            Head = null;
            Tail = null;
            Count = 0;
        }

        public static void PrintLinkedList(LinkedList<T> list)
        {
            foreach (var node in list)
            {
                Console.Write($"{node} --> ");
            }
            Console.Write("Null\n");
        }
    }
}