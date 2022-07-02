using System;

namespace CinemaBookingSystem.Classes
{
    [Serializable]
    public class Person
    {
        // Private variable to represent person ID.
        private int _id;

        // Private variable to represent if the person can book seats.
        private bool _hasBooked;

        // Constructor.
        public Person(int id)
        {
            this.Id = id;
            this.HasBooked = false;
        }

        // Id property to represent person ID.
        public int Id
        {
            // Defining get method.
            get { return _id; }

            // Defining set method.
            set { _id = value; }
        }

        // Has Booked property to represent if person has booked any seats.
        public bool HasBooked
        {
            // Defining get method.
            get { return _hasBooked; }

            // Defining set method.
            set { _hasBooked = value; }
        }

    }
}
