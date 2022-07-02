using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaBookingSystem.Classes
{
    // Make sure node is writable to data file
    [Serializable]
    class Node
    {
        // Define pointer for previous node
        public Node prev;

        // Define node data (type seat)
        public Seat seat;

        // Define pointer for next node
        public Node next;

        // Constructor
        public Node (Seat pSeat)
        {
            seat = pSeat;
            prev = null;
            next = null;
        }
    }
}
