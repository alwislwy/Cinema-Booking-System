using System;
using System.Collections;
using System.Collections.Generic;

namespace CinemaBookingSystem.Classes
{
    // Allow conversion of object into bytes to sroe the object in a .dat file. Allow for subsequent reconstruction.
    [Serializable]
    // Tags the IEnumerable interface to allow looping over the DLL.
    class DoubleLinkedList : IEnumerable<Node>
    {
        // Private variable to hold matrix. Elements must be of type Node.
        private Node[,] _matrixList;

        // Private variable to store first value of the DLL.
        private Node _head;

        // Private variable to store last value of the DLL.
        private Node _tail;

        // Start property to return head of the DLL.
        public Node Start
        {
            get { return _head; }
        }

        // Start property to return head of the DLL.
        public Node Last {
            get { return _tail; }
        }

        // Length property to return length of DLL.
        public int Length { get; private set; }

        // IEnumerable Interface implementation code.
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        // Enumerator for foward traversal.
        public IEnumerator<Node> GetEnumerator()
        {
            // Begin enumeration from head. Point pointer to _head. Pointer for down.
            Node downPointer = _head;

            // Pointer to move right.
            Node rightPointer;

            // Loop until node.down is null.
            while (downPointer != null)
            {
                rightPointer = downPointer;

                // Loop until node.right is null.
                while (rightPointer != null)
                {
                    yield return rightPointer;
                    rightPointer = rightPointer.right;
                }

                downPointer = downPointer.down;
            }
        }

        // Enumerator for reverse traversal.
        public IEnumerable GetEnumeratorReverse()
        {
            // Begin enumeration from tail. Point pointer to _tail. Pointer for up.
            Node upPointer = _tail;

            // Pointer to move left.
            Node leftPointer;

            // Loop until node.up is null.
            while (upPointer != null)
            {
                leftPointer = upPointer;

                // Loop until node.left is null.
                while (leftPointer != null)
                {
                    yield return leftPointer;
                    leftPointer = leftPointer.left;
                }

                upPointer = upPointer.up;
            }
        }

        // Constructor.
        public DoubleLinkedList()
        {
            _head = null;
            _tail = null;
        }

        // Construct method to build matrix-DLL from matrix input.
        public Node Construct(Seat[,] matrix, int rows, int columns)
        {
            // Define matrix size based on rows and col arguments
            _matrixList = new Node[rows, columns];

            // Calls private construct util recursively.
            // Construct the doubly linked list, starting with first element (0,0).
            _head = ConstructUtil(matrix, rows, columns, 0, 0, null);
            return _head;
        }

        // Contruct util to build the matrix-DLL.
        private Node ConstructUtil(Seat[,] matrix, int rows, int columns, int i, int j, Node pointer)
        { 

            // Make sure matrix row / column does not exceed set dimension
            if (i >= rows || j >= columns)
            {
                return null;
            }

            // Create a node with data being matrix element at (i, j)
            Node element = new Node(matrix[i, j]);

            // Add element to _matrixList
            _matrixList[i, j] = element;

            // If element is in first column, make sure to set element.left to null.
            if (j == 0)
            {
                element.left = null;
            } else
            {
                element.left = pointer;
            }

            // Set element.up to value to the node on top of the current element
            if (i != 0)
            {
                element.up = _matrixList[i - 1, j];
            }
            // Recursive call for right pointer
            element.right = ConstructUtil(matrix, rows, columns, i, j + 1, element);

            // Recursive call for down pointer
            element.down = ConstructUtil(matrix, rows, columns, i + 1, j, element);

            // Storing last element
            if (i == rows - 1 && j == columns - 1)
            {
                _tail = element;
            }

            // Return element
            return element;
        }
    }
}
