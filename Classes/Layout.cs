using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CinemaBookingSystem.Classes
{
    class Layout
    {
        // Public variable to store the Person object of active person
        public Person activePerson;

        // Public variable to store if editorMode is enabled / disabled
        public bool editorMode;

        // Public variable to store if editorMode mode is to enable / disable seats
        public string enabler = "none";

        // Public variable to store number of seats 
        public int seatCounter = 0;

        // Public variable to store the seatsPanel Panel reference to allow class to access it 
        public Panel seatsPanel = (Panel)null;

        // Public variable to store the maxSeatsTextBox TextBox reference to allow class to access it
        public TextBox maxSeatsTextBox = (TextBox)null;

        // Public variable to store the person button reference to allow class to access it
        public Button personBtn = (Button)null;

        // Public variable to store the list of bookedSeats nodes to allow class to access it
        public List<Node> bookedSeats = new List<Node>();
        
        // Public variable to store the max number of seats possible to be booked
        public int maxSeats = 0;

        // Private variable to hold the _seats DLL
        private DoubleLinkedList _seats;

        // Private variable to store if smartMode is enabled / disabled
        private bool _smartMode;

        // Constructor.
        public Layout(bool smart = false, bool safe = false)
        {
            _smartMode = smart;
        }

        // Seats property to hold DLL
        public DoubleLinkedList Seats
        {
            // Defining get method
            get { return _seats; }

            // Defining set method
            set { _seats = value; }
        }

        // Method to generate seating layout
        public Seat[,] GenerateLayout(int[] size, bool normal = false)
        {
            // Define seat size
            int[] seatSize = { 80, 80 };

            // Define first seat positions
            int seatLeft;
            int seatTop = 0;

            // Define margin variables
            int[] margins = { 0, 0 };

            // Define new matrix t ostore seat nodes
            Seat[,] matrix = new Seat[size[0], size[1]];

            // Define starting seat id
            int id = 1;

            for (int row = 0; row < size[0]; row++)
            {
                if (!normal)
                {
                    // Determine if there should be aisles between rows
                    if (row % 3 == 0)
                    {
                        margins[0] = 100;
                    }
                    else
                    {
                        margins[0] = 25;
                    }
                }
                else
                {
                    // Determine if there should be aisles between rows
                    if ((row % 2 == 0 && row % 4 != 0) || row % 5 == 0)
                    {
                        margins[0] = 100;
                    }
                    else
                    {
                        margins[0] = 25;
                    }
                }

                // Sets the y position of each row
                seatTop += seatSize[0] + margins[0];

                // Reset the x position of first seat
                seatLeft = 0;

                for (int col = 0; col < size[1]; col++)
                {
                    if (!normal)
                    {
                        // Determine if there should be aisles between columns
                        if (col % 11 == 0 || (col % 6 == 0 & col % 12 != 0))
                        {
                            margins[1] = 100;
                        }
                        else
                        {
                            margins[1] = 25;
                        }
                    }
                    else
                    {
                        // Determine if there should be aisles between columns
                        if (col % 3 == 0 && col % 6 != 0)
                        {
                            margins[1] = 100;
                        }
                        else
                        {
                            margins[1] = 25;
                        }
                    }

                    // Define seat number
                    int[] seatNumber = { 65 + row, col + 1 };

                    // Set x position of seat
                    seatLeft += seatSize[1] + margins[1];

                    // Set seat position as list
                    int[] seatPos = { seatLeft, seatTop };

                    // Create a new seat object to represent the seat
                    Seat seat = new Seat(seatPos, seatSize, seatNumber, id);

                    // Increment seat id
                    id++;

                    // Set matrix element as seat
                    matrix[row, col] = seat;
                }
            }

            return matrix;
        }
        // Generates seat label with seatNode object
        public Label GenerateSeat(Node seatNode)
        {
            // Create a new label to represent the seat
            Label seatLabel = new Label();

            // Create a seat object to hold seat data
            Seat seatData = seatNode.seat;

            // Sets position of the seat
            seatLabel.Location = new Point(seatData.Position[0], seatData.Position[1]);

            // Define the border of the seat
            seatLabel.BorderStyle = BorderStyle.FixedSingle;

            // Define the colour of the seat
            // If seat is booked, set colour to pink
            if (seatData.Booked == true)
            {
                seatLabel.BackColor = Color.Pink;
            }
            // Else, check whether seat is disabled. If so, set colour to IndianRed. Otherwise, LightGray.
            else
            {
                if (seatData.Disabled == true)
                {
                    seatLabel.BackColor = Color.IndianRed;
                } 
                else
                {
                    seatLabel.BackColor = Color.LightGray;
                }
            }

            // Set name of seat
            seatLabel.Name = $"seat_{seatData.Label}";

            // Set width and height of seat
            seatLabel.Size = new Size(seatData.Size[0], seatData.Size[1]);

            // Attach method to handle label control's click event
            seatLabel.Click += new EventHandler(HandleLabelClick);

            // Assign seatNode as referenced Node object for the label through Tag
            seatLabel.Tag = seatNode;

            // Generate label text
            seatLabel.Text = seatData.Label;

            return seatLabel;
        }

        // Generates the screen
        public Label GenerateScreen(int locX, int locY)
        {
            // Generate screen
            Label screen = new Label();
            screen.Location = new Point(locX, locY);
            screen.Size = new Size(1016, 64);
            screen.Text = "SCREEN";
            screen.Font = new Font(screen.Font, FontStyle.Bold);
            screen.BackColor = Color.FromArgb(255, 192, 128);
            screen.TextAlign = ContentAlignment.MiddleCenter;
            screen.BorderStyle = BorderStyle.FixedSingle;

            return screen;
        }

        // Refresh method to refresh the seat designs
        public Control Refresh(Node seatNode, Control control, bool reset = false)
        {
            // Extract seat data from node
            Seat seatData = seatNode.seat;

            // Assign seat node object to the Tag property of seat label
            if (control.Tag == seatNode)
            {
                if (reset)
                {
                    seatNode.seat.Recommended = false;
                }
                // Check if seat is disabled
                if (seatData.Disabled == false)
                {
                    // Check if seat has been booked
                    if (seatData.BookedBy == null)
                    {
                        control.BackColor = Color.LightGray;
                    }
                    // Sets colour of seat according to the active person 
                    else
                    {
                        if (activePerson != null)
                        {
                            switch (seatData.BookedBy.Id)
                            {
                                case (1):
                                    if (activePerson.Id != 1)
                                    {
                                        control.BackColor = Color.Pink;
                                    }
                                    else
                                    {
                                        control.BackColor = Color.Yellow;
                                    }
                                    break;
                                case (2):
                                    if (activePerson.Id != 2)
                                    {
                                        control.BackColor = Color.Pink;
                                    }
                                    else
                                    {
                                        control.BackColor = Color.Blue;
                                    }
                                    break;
                                case (3):
                                    if (activePerson.Id != 3)
                                    {
                                        control.BackColor = Color.Pink;
                                    }
                                    else
                                    {
                                        control.BackColor = Color.Red;
                                    }
                                    break;
                                case (4):
                                    if (activePerson.Id != 4)
                                    {
                                        control.BackColor = Color.Pink;
                                    }
                                    else
                                    {
                                        control.BackColor = Color.Green;
                                    }
                                    break;
                            }
                        }
                        else
                        {
                            control.BackColor = Color.Pink;
                        }
                    }
                }
                // Set colour for disabled seats
                else
                {
                    control.BackColor = Color.IndianRed;
                }
            }

            return control;
        }


        // Handle the label clicks
        private void HandleLabelClick(object sender, EventArgs e)
        {
            // Sender automatically references object raised by the Click event signal

            // Use simple casting technique to make labelSeat reference the sender
            Label seatLabel = (Label)sender;

            // Obtain the seat node which is tagged to the Label which raised the Click event
            Node seatNode = (Node)seatLabel.Tag;

            // Extract seat data from node
            Seat seat = seatNode.seat;

            // Checks if editor mode is enabled
            if (editorMode)
            {
                // Checks option selected
                if (enabler == "none")
                {
                    MessageBox.Show("Please select whether to enable or disable seats.");
                }
                else
                {
                    // Set seat disabled property to user option
                    seat.Disabled = !bool.Parse(enabler);
                    // Set colour accordingly
                    if (seat.Disabled)
                    {
                        seatLabel.BackColor = Color.IndianRed;
                    }
                    else
                    {
                        seatLabel.BackColor = Color.LightGray;
                    }
                }
            }
            //Make sure a person has been chosen before attempting to book
            else if (activePerson == null)
            {
                MessageBox.Show("Please choose a person to start booking.");
            }
            // Make sure max seats is given
            else if (maxSeats == 0)
            {
                MessageBox.Show("Please set a maximum number of seats first.");
            }
            // Allow booking
            else
            {

                // Sort all booked seats in ascending order to ensure adjacent bookimgs
                bookedSeats.Sort((x, y) => x.seat.Id.CompareTo(y.seat.Id));

                // Allow booking if seat has not been booked and is not disabled
                if (seat.Booked == false && seat.Disabled == false)
                {
                    // Make sure seats booked is not max yet
                    if (seatCounter >= maxSeats)
                    {
                        MessageBox.Show("You have booked the maximum number of seats!");
                    }
                    else
                    {
                        // Check if seat is adjacent
                        bool leftNull = false;
                        bool rightNull = false;
                        bool condition = false;

                        // To handle subsequent seat bookings
                        if (seatCounter > 0)
                        {
                            // Set condition to check if seat booked is adjacent to earlier seats
                            if (bookedSeats[0].left == null)
                            {
                                leftNull = true;
                            }

                            if (bookedSeats[bookedSeats.Count - 1].right == null)
                            {
                                rightNull = true;
                            }

                            if (!(leftNull == true && rightNull == true))
                            {
                                if (leftNull == true)
                                {
                                    condition = seat == bookedSeats[bookedSeats.Count - 1].right.seat;
                                }
                                else if (rightNull == true)
                                {
                                    condition = seat == bookedSeats[0].left.seat;
                                }
                                else
                                {
                                    condition = seat == bookedSeats[0].left.seat || seat == bookedSeats[bookedSeats.Count - 1].right.seat;
                                }
                            }
                            // Allow booking of adjacent seats, or recommended seats
                            if (condition || seat.Recommended == true)
                            {
                                seat.BookedBy = activePerson;
                                seat.Booked = true;
                                activePerson.HasBooked = true;
                                // Increment counter to calaulcate how many seats active person has chosen
                                seatCounter++;
                                // Adds booked seat node to _seat DLL
                                bookedSeats.Add(seatNode);

                                // Sets the colour of the booking accordingly
                                SetPersonColour(seatLabel);

                                if (seatsPanel != null)
                                {
                                    // Checks whether adjacent seats (3x3 radius) are booked / disabled
                                    // Recommends seats if they are not
                                    RecommendSeats("booking", seatNode);
                                }

                            }
                            // Bookings are not adjacent
                            else
                            {
                                MessageBox.Show("You may only book adjacent seats.");
                            }
                        }
                        else
                        {
                            // Adds first booked seat node to _seat DLL
                            bookedSeats.Add(seatNode);

                            // Disable max seats text box
                            maxSeatsTextBox.Enabled = false;
                            
                            // Set booked by property
                            seat.BookedBy = activePerson;

                            // Indicate that active person has booked
                            activePerson.HasBooked = true;

                            // Change seat booked property to true
                            seat.Booked = true;

                            if (seatsPanel != null)
                            {
                                // Change recommended property to true
                                seat.Recommended = true;
                                SetRecommendedColour(seatNode);
                            }

                            // Increment counter to calaulcate how many seats active person has chosen
                            seatCounter++;

                            // Disable person button
                            personBtn.Enabled = false;

                            // Sets the colour of the booking accordingly
                            SetPersonColour(seatLabel);

                            if (seatsPanel != null)
                            {
                                // Checks whether adjacent seats (3x3 radius) are booked / disabled
                                // Recommends seats if they are not
                                RecommendSeats("booking", seatNode);
                            }


                        }
                    }
                }
                else
                {
                    // Handle disabled seats
                    if (seat.Disabled == true)
                    {
                        MessageBox.Show("Seat is disabled.");
                    }
                    // Handle unbooking of seats
                    else
                    {
                        if (seat.BookedBy == activePerson && (seat == bookedSeats[0].seat || seat == bookedSeats[bookedSeats.Count - 1].seat))
                        {
                            // Set seat booked to false
                            seat.Booked = false;
                            // Reset colour of seat
                            if (seat.Recommended && _smartMode)
                            {
                                seatLabel.BackColor = Color.LightGreen;
                            }
                            else
                            {
                                seatLabel.BackColor = Color.LightGray;
                            }
                            // Set booking person to null
                            seat.BookedBy = null;

                            // Decrement seat counter
                            seatCounter--;

                            if (seatsPanel != null)
                            {
                                // Checks whether adjacent seats (3x3 radius) are booked / disabled
                                // Recommends seats if they are not
                                RecommendSeats("unbooking", seatNode);
                            }
                            // Remove seat node from booked seats list
                            bookedSeats.Remove(seatNode);

                            // If unbooked all seats, reactivate buttons and reset necessary variables
                            if (seatCounter == 0)
                            {
                                activePerson.HasBooked = false; 
                                maxSeatsTextBox.Enabled = true;
                                personBtn.Enabled = true;
                                
                                if (seatsPanel != null)
                                {
                                    // Change recommended property to true
                                    seat.Recommended = false;
                                    SetRecommendedColour(seatNode);
                                }
                            }

                        }
                        else if (seat.BookedBy != activePerson)
                        {
                            MessageBox.Show("Seat has already been booked by another person.");
                        }
                        else
                        {
                            MessageBox.Show("You may only book adjacent seats.");
                        }
                    }
                }
            }
        }

        // Changes colour of seat as necessary. For recommended seats.
        private void SetRecommendedColour(Node seatNode)
        {
            // Loop through all controls
            foreach (Control item in seatsPanel.Controls)
            {
                // Check if item matches with node
                if (item.Text == seatNode.seat.Label)
                {
                    // Set colour of seat based on recommended status
                    if (seatNode.seat.Recommended && _smartMode)
                    {
                        item.BackColor = Color.LightGreen;
  
                    } 
                    else
                    {
                        if (!seatNode.seat.Disabled && seatNode.seat.Booked == false)
                        {
                            item.BackColor = Color.LightGray;
                        }
                    }
                }
            }
        }

        // Method to determine if seats should be recommended
        private void RecommendSeats(string action, Node seatNode)
        {
            bool condition;
            bool lone = true;
            if (action == "booking")
            {
                condition = true;
            } 
            else
            {
                condition = false;
            }

            //foreach(Node seatNode in bookedSeats)
            //{
                // Recommends seats based on whether the seat has been booked, and whether it has been disabled.
                // Recommendations are valid in a 3x3 radius, excluding top and bottom seats (which will always be disabled)
            if (seatNode.up != null)
            {
                if (!seatNode.up.seat.Booked) 
                {
                    seatNode.up.seat.Recommended = seatNode.up.seat.Disabled == false && seatNode.seat.Booked && condition;
                    SetRecommendedColour(seatNode.up);
                }
                else
                {
                    if (seatNode.up.seat.BookedBy == activePerson)
                    {
                        lone = false;
                    }
                }

                if (seatNode.up.right != null)
                {
                    if (!seatNode.up.right.seat.Booked)
                    {
                        seatNode.up.right.seat.Recommended = seatNode.up.right.seat.Disabled == false && seatNode.seat.Booked && condition;
                        SetRecommendedColour(seatNode.up.right);
                    }
                    else
                    {
                        if (seatNode.up.right.seat.BookedBy == activePerson)
                        {
                            lone = false;
                        }
                    }
                }

                if (seatNode.up.left != null)
                {
                    if (!seatNode.up.left.seat.Booked)
                    {
                        seatNode.up.left.seat.Recommended = seatNode.up.left.seat.Disabled == false && seatNode.seat.Booked && condition;
                        SetRecommendedColour(seatNode.up.left);
                    }
                    else
                    {
                        if (seatNode.up.left.seat.BookedBy == activePerson)
                        {
                            lone = false;
                        }
                    }

                }

            }

            if (seatNode.right != null)
            {
                if (!seatNode.right.seat.Booked)
                {
                    seatNode.right.seat.Recommended = seatNode.right.seat.Disabled == false && seatNode.seat.Booked && condition;
                    SetRecommendedColour(seatNode.right);
                }
                else
                {
                    if (seatNode.right.seat.BookedBy == activePerson)
                    {
                        lone = false;
                    }
                }

            }

            if (seatNode.left != null)
            {
                if (!seatNode.left.seat.Booked)
                {
                    seatNode.left.seat.Recommended = seatNode.left.seat.Disabled == false && seatNode.seat.Booked && condition;
                    SetRecommendedColour(seatNode.left);
                }
                else
                {
                    if (seatNode.left.seat.BookedBy == activePerson)
                    {
                        lone = false;
                    }
                }


                if (seatNode.left.down != null)
                {
                    if (!seatNode.left.down.seat.Booked)
                    {
                        seatNode.left.down.seat.Recommended = seatNode.left.down.seat.Disabled == false && seatNode.seat.Booked && condition;
                        SetRecommendedColour(seatNode.left.down);
                    }
                    else
                    {
                        if (seatNode.left.down.seat.BookedBy == activePerson)
                        {
                            lone = false;
                        }
                    }
                }
            }

            if (seatNode.down != null)
            {
                if (!seatNode.down.seat.Booked)
                {
                    seatNode.down.seat.Recommended = seatNode.down.seat.Disabled == false && seatNode.seat.Booked && condition;
                    SetRecommendedColour(seatNode.down);
                }
                else
                {
                    if (seatNode.down.seat.BookedBy == activePerson)
                    {
                        lone = false;
                    }
                }

                if (seatNode.down.right != null)
                {
                    if (!seatNode.down.right.seat.Booked)
                    {
                        seatNode.down.right.seat.Recommended = seatNode.down.right.seat.Disabled == false && seatNode.seat.Booked && condition;
                        SetRecommendedColour(seatNode.down.right);
                    }
                    else
                    {
                        if (seatNode.down.right.seat.BookedBy == activePerson)
                        {
                            lone = false;
                        }
                    }
                }
            }

            if ((!condition) && lone)
            {
                seatNode.seat.Recommended = false;
                SetRecommendedColour(seatNode);
            }
            //}
        }

        // Set the colour of the person's booking
        private void SetPersonColour(Label seatLabel)
        {
            switch (activePerson.Id)
            {
                case (1):
                    seatLabel.BackColor = Color.Yellow;
                    break;
                case (2):
                    seatLabel.BackColor = Color.Blue;
                    break;
                case (3):
                    seatLabel.BackColor = Color.Red;
                    break;
                case (4):
                    seatLabel.BackColor = Color.Green;
                    break;
            }
        }
    }

}
