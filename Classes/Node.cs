using System;

namespace CinemaBookingSystem.Classes
{
    // Allow conversion of object into bytes to sroe the object in a .dat file. Allow for subsequent reconstruction.
    [Serializable]
    class Node
    {

        // Define pointer for left right up down nodes.
        // Allows for matrix-style Double Linked List.
        public Node left, up, right, down;

        // Define node data (type Seat).
        public Seat seat;

        // Constructor.
        public Node (Seat data)
        {
            seat = data;
            left = null;
            up = null;
            right = null;
            down = null;
        }
    }
}
