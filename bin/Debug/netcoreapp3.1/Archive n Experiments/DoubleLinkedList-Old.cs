using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CinemaBookingSystem.Classes
{
    /* SOURCES FOR THIS CLASS
     * IENumerable - https://www.c-sharpcorner.com/UploadFile/0c1bb2/ienumerable-interface-in-C-Sharp/
     * LinkedList Implementation - https://www.youtube.com/watch?v=GcC5kW9tyOQ
     * LinkedList Implementation - Blackboard SP DSAL Lecture Materials
     * What is 'yield return'? - https://findnerd.com/list/view/Difference-between-yield-and-return-statement-in-C-/17243/
     */
    // Make sure node is writable to data file
    [Serializable]
    class DoubleLinkedList : IEnumerable<Node>
    {
        // Private variable to store first value of the list
        private Node _head;
        // Start property to return head of list
        public Node Start {
            get
            {
                return _head;
            }
        }

        // Private variable to store last value of the list
        private Node _tail;
        // End property to return tail of list
        public Node End
        {
            get
            {
                return _tail;
            }
        }

        // Length property to return length of DLL
        public int Length { get; private set; }

        // Enumerator for foward traversal
        public IEnumerator<Node> GetEnumerator()
        {
            // Begin enumeration from head. Point pointer to _head (first element)
            Node pointer = _head;

            while (pointer != null)
            {
                // Use yield so that GetEnumerator() will continue running even after returning numerable
                yield return pointer;

                // Point to next element
                pointer = pointer.next;
            }
        }

        // Enumeratror for reverse traversal
        public IEnumerable GetEnumeratorReverse()
        {
            // Begin enumeration from tail. Point pointer to _tail (last element)
            Node pointer = _tail;

            while (pointer != null)
            {
                // Use yield so that function will continue running even after returning numerable
                yield return pointer;

                // Point to next element (backwards)
                pointer = pointer.prev;
            }
        }
        
        // IEnumerable Interface implementation code
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        // Unshift method - adds new node to START of list, returns new length of list
        public int Unshift(Seat seatData)
        {
            Node data = new Node(seatData);

            // Points the next value for data to be the current first element of the list
            data.next = _head;

            // Checks if list is empty
            if (_head == null)
            {
                // Sets tail node as data
                // Required as in this case, _head = _tail
                _tail = data;
            }
            else
            {
                // If list is not empty, point previous element of _head to data
                _head.prev = data;
            }

            // Set new head
            _head = data;

            // Increment length
            Length++;

            // Return int length
            return Length;
        }

        // Push method - adds new node to END of list, returns new length of list
        public int Push(Seat seatData)
        {
            Node data = new Node(seatData);

            // Checks if list is empty
            if (_tail == null)
            {
                // Sets head node as data
                // Required as in this case, _tail = _head
                _head = data;
            }
            else
            {
                // If list is not empty, connect the old and new last node
                
                // Pointing data's previous node to _tail
                data.prev = _tail;

                // Pointing the next element of the old last element to data 
                _tail.next = data;
            }

            // Set new tail
            _tail = data;

            // Increment length
            Length++;

            // Return int length
            return Length;
        }

        // Remove method - remove by value
        public int Remove(string seatID)
        {
            // Start pointer from start of DLL
            Node pointer = _head;

            // Make sure list is not empty
            while (pointer != null)
            {
                if(pointer.seat.Label == seatID)
                {
                    // Found seat 

                    // Realign pointers
                    if (pointer.next == null)
                    {
                        // Realign pointers for last element
                        _tail = pointer.prev;
                    }
                    else
                    {
                        pointer.next.prev = pointer.prev;
                    }

                    // Set pointer to null
                    pointer = null;

                    // Decrement the length of DLL
                    Length--;

                    // Return length
                    return Length;
                }

                // Point to next node
                pointer = pointer.next;
            }

            return -1;
        }

        // Pop method - remove last node, returns length
        public int Pop()
        {
            // Make sure list is not empty
            if (_tail != null)
            {
                // Sets last node to old 2nd last node
                _tail = _tail.prev;

                // If list is now empty
                if (_tail == null)
                {
                    _head = null;
                }

                Length--;
                return Length;
            }
            return -1;
        }

        // Shift method - remove first node, retunr removed node
        public int Shift()
        {
            // Make sure list is not empty
            if (_head != null)
            {
                // Sets first node to old 2nd node
                _head = _head.next;

                // If list is now empty
                if (_head == null)
                {
                    _tail = null;
                }

                Length--;
                return Length;
            }
            return -1;
        }
        // Includes method - Return value of first element which meet search criteria
        // Search criteria - seatID i.e A1
        public Node Includes(string seatID)
        {
            // Start pointer from start of DLL
            Node pointer = _head;
            
            // Make sure list is not empty
            while (pointer != null)
            {
                // Checks if pointed seat label equals to search ID
                if (pointer.seat.Label == seatID)
                {
                    // If so, return node
                    return pointer;
                }
                // Else, finds next node
                // Else statement not necessary as if the 'if' statement was true, code execution would have ended at return
                pointer = pointer.next;
            }

            // Cannot be found, return null
            return null;
        }
    }

    //
}
