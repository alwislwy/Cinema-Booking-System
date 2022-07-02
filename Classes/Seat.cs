using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaBookingSystem.Classes
{
    [Serializable]
    class Seat
    {
        //Private variable to represent if seat is booked.
        private bool _isBooked;

        // Private variable to represent if seat is disabled.
        private bool _isDisabled;

        // Private variable to represent the seat position.
        // Format: { top, left } { x, y }
        private int[] _position;

        // Private variable to represent the seat size.
        // Format: { width, height }
        private int[] _size;

        // Private variable to represent the seat alphabet and number.
        // Format: { alpha_ascii, number } i.e 65 = A
        private int[] _number;

        // Private variable to represent seat label.
        // Format: A4
        private string _label;

        // Private variable to represent seat ID.
        // Format: 1
        private int _id;

        // Private variable to rerpesent recommended or not.
        // Format: true or false
        private bool _recommended;

        // Private variable to represent booking person object.
        private Person _bookedBy;

        // Constructor.
        public Seat(int[] position, int[] size, int[] number, int id, int type = 1, bool booked = false, bool disabled = true, bool recommend = false)
        {
            this.Booked = booked;
            this.Disabled = disabled;
            this.Position = position;
            this.Size = size;
            this.Number = number;
            this.Id = id;
            this.Recommended = recommend;
            this.BookedBy = (Person)null;
            this.Label = ComputeSeatLabel();

        }

        // Recommended property - indicates if seat is recommended by algorithm.
        public bool Recommended
        {
            // Defining get method.
            get { return _recommended; }

            // Defining set method.
            set { _recommended = value; }
        }

        // Booked property - indicates if seat has been booked.
        public bool Booked
        {
            // Defining get method.
            get { return _isBooked; }

            // Defining set method.
            set { _isBooked = value; }
        }

        // Disabled property - indicates if seat is disabled.
        public bool Disabled
        {
            // Defining get method.
            get { return _isDisabled; }

            // Defining set method.
            set { _isDisabled = value; }
        }

        // Position property - represents position of seat.
        public int[] Position
        {
            // Defining get method.
            get { return _position; }

            // Defining set method.
            set { _position = value; }
        }

        // Size property - represents size of seat.
        public int[] Size
        {
            // Defining get method.
            get { return _size; }

            // Defining set method.
            set { _size = value; }
        }

        // Number property - represents row & number of seat .
        public int[] Number
        {
            // Defining get method.
            get { return _number; }

            // Defining set method.
            set { _number = value; }
        }

        // Label property - stores the seat label text.
        public string Label
        {
            // Defining get method.
            get { return _label; }
            
            // Defining set method.
            set { _label = value; }
        }

        // Id property - stores the seat ID.
        public int Id
        {
            // Defining get method.
            get { return _id; }

            // Defining set method.
            set { _id = value; }
        }

        // BookedBy property - stores the person object which booked seat.
        public Person BookedBy
        {
            // Defining get method.
            get { return _bookedBy; }
            
            // Defining set method.
            set { _bookedBy = value; }
        }

        // ComputeLabel method - compute the seat label from seat number.
        private string ComputeSeatLabel()
        {
            // Takes ascii code of alphabet, converts it to string and combines it with the number. i.e 65, 1 = A1
            return ((char)(_number[0])).ToString() + _number[1].ToString();
        }

    }
}
