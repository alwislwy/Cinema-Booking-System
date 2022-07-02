using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CinemaBookingSystem.Classes;
using System.IO;

namespace CinemaBookingSystem
{
    public partial class SafeDistancing : Form
    {
        // Initialise classes to create fileManager, _seats, layoutHandler objects
        private FileManager fileManager = new FileManager();
        private DoubleLinkedList _seats = new DoubleLinkedList();
        private Layout layoutHandler = new Layout();

        // Private variable to store max number of seats
        private int maxNumSeats = 0;

        // Initialise classes to create 4 person objects
        private Person personA = new Person(1);
        private Person personB = new Person(2);
        private Person personC = new Person(3);
        private Person personD = new Person(4);

        // Private variable to store layout and save data file paths
        string layoutData = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\layouts\";
        string saveData = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\saves\safeDistancingSave.dat";
        int numRow, numCol;

        public SafeDistancing()
        {
            InitializeComponent();
        }

        public void GenerateLayout()
        {
            // Sets cursor to wait
            Cursor.Current = Cursors.WaitCursor;

            // Set maxSeats textbox reference for layoutHandler
            layoutHandler.maxSeatsTextBox = maxSeats;

            // Clear all form controls
            seatsPanel.Controls.Clear();

            // Define the number of rows and columns for seat layout
            int[] size = { numRow, numCol };

            // Enable load button depending on existance of save data
            loadBtn.Enabled = File.Exists(saveData);

            try
            {
                // Attempt to load saved layout
                _seats = fileManager.Load(layoutData + $"safeDistancingMode_{numRow}_{numCol}.dat");
                layoutHandler.Seats = _seats;
            }
            catch (FileNotFoundException exception)
            {
                // Generate seats and matrix
                Seat[,] matrix = layoutHandler.GenerateLayout(size);

                // Construct matrix DLL
                _seats.Construct(matrix, size[0], size[1]);

                // Save layout
                fileManager.Save(_seats, layoutData + $"safeDistancingMode_{numRow}_{numCol}.dat");

                // Set DLL reference for layoutHandler
                layoutHandler.Seats = _seats;
            }
            catch (Exception exception)
            {
                // Unlikely to have any errors. In such case, likely due to corrupted data
                MessageBox.Show("Corrupted file! Please try re-installing and running the code again.");
                Application.Exit();
            }
            finally
            {
                // Generate seats based on data
                foreach (Node seatNode in _seats)
                {
                    seatsPanel.Controls.Add(layoutHandler.GenerateSeat(seatNode));
                }

                // Passes reference for seatsPanel
                layoutHandler.seatsPanel = seatsPanel;

                // Allow setup safe distance layout button
                setupSafeDistanceBtn.Enabled = true;
                
                // Disable all person buttons
                personABtn.Enabled = false;
                personBBtn.Enabled = false;
                personCBtn.Enabled = false;
                personDBtn.Enabled = false;

                // Generate screen
                seatsPanel.Controls.Add(layoutHandler.GenerateScreen(471, 19));
            }

            // Resets cursor
            Cursor.Current = Cursors.Default;
        }

        private void SafeDistancing_Load(object sender, EventArgs e)
        {
            numRow = 7;
            numCol = 14;
            GenerateLayout();
            numRow = 0;
            numCol = 0;
        }

        private void setupLayoutBtn_Click(object sender, EventArgs e)
        {
            GenerateLayout();
            maxSeats.Enabled = false;
        }

        private void numRows_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            // Tooltip to display error messages
            ToolTip message = new ToolTip();

            // Checks if input can be parsed into int
            try
            {
                // Ensures values are in range
                if (int.Parse(numRows.Text) < 7 || int.Parse(numRows.Text) > 10)
                {
                    message.Show("Please key in a number between 7 - 10", textbox, 0, -45, 1000);
                    // Resets numrow
                    numRow = 0;

                    // Disables layout button
                    setupLayoutBtn.Enabled = false;
                }
                else
                {
                    numRow = int.Parse(numRows.Text);
                    // Enables layout button only when both numRow and numCol have values
                    setupLayoutBtn.Enabled = (numRow > 0 && numCol > 0);
                }
            }
            catch (FormatException ex)
            {
                // Resets numrow
                numRow = 0;

                // Disables layout button
                setupLayoutBtn.Enabled = false;
                message.Show("Please key in a number between 7 - 10", textbox, 0, -45, 1000);
            }
        }

        private void setupSafeDistanceBtn_Click(object sender, EventArgs e)
        {
            setupSafeDistancingUtil();

            // Enable all person buttons
            personABtn.Enabled = true;
            personBBtn.Enabled = true;
            personCBtn.Enabled = true;
            personDBtn.Enabled = true;

            // Enables editor
            seatEditorBtn.Enabled = true;
        }

        // Method to set the active person and reset all values 
        private void SetPerson(int id)
        {
            // Disable editor button
            seatEditorBtn.Enabled = false;

            // Enable maxSeats text box
            maxSeats.Enabled = true;

            // Set the max seats depending on value of text box.
            // Allows carry over of data from previous settings
            layoutHandler.maxSeats = maxNumSeats > 0 ? maxNumSeats : 0;

            // Reset seat counter
            layoutHandler.seatCounter = 0;

            // Replace previous booked seats list
            layoutHandler.bookedSeats = new List<Node>();

            // Set active person and button depending on given id
            switch (id)
            {
                case (1):
                    layoutHandler.activePerson = personA;
                    layoutHandler.personBtn = personABtn;
                    break;
                case (2):
                    layoutHandler.activePerson = personB;
                    layoutHandler.personBtn = personBBtn;
                    break;
                case (3):
                    layoutHandler.activePerson = personC;
                    layoutHandler.personBtn = personCBtn;
                    break;
                case (4):
                    layoutHandler.activePerson = personD;
                    layoutHandler.personBtn = personDBtn;
                    break;
            }

            // Disables person buttons if the person has booked seats
            personABtn.Enabled = !personA.HasBooked;
            personBBtn.Enabled = !personB.HasBooked;
            personCBtn.Enabled = !personC.HasBooked;
            personDBtn.Enabled = !personD.HasBooked;

            // Loop through all seats
            foreach (Node seatNode in _seats)
            {

                // Change colour of seat
                foreach (Control item in seatsPanel.Controls)
                {
                    layoutHandler.Refresh(seatNode, item, true);
                }
            }
        }
        private void personABtn_Click(object sender, EventArgs e)
        {
            infoPanel.Text = "Person A is booking now";
            SetPerson(1);
        }

        private void personBBtn_Click(object sender, EventArgs e)
        {
            infoPanel.Text = "Person B is booking now";
            SetPerson(2);
        }

        private void personCBtn_Click(object sender, EventArgs e)
        {
            infoPanel.Text = "Person C is booking now";
            SetPerson(3);
        }

        private void personDBtn_Click(object sender, EventArgs e)
        {
            infoPanel.Text = "Person D is booking now";
            SetPerson(4);
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Loaded previous saved data");
            // Resets simulation
            Reset(saveData, true);

            setupSafeDistanceBtn.Enabled = false;
            seatEditorBtn.Enabled = true;
            endBtn.Enabled = true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved current data");
            //Saves data
            fileManager.Save(_seats, saveData);
            // Enables load button
            loadBtn.Enabled = true;
        }

        private void resetSimulationBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Simulation reset!");
            Reset(layoutData + $"safeDistancingMode_7_14.dat");

            // Override and reassign values for buttons as appropiate
            infoPanel.Text = "";
            seatEditorBtn.Enabled = false;
            layoutHandler.editorMode = false;
            disableRadioBtn.Enabled = false;
            enableRadioBtn.Enabled = false;
            enableAllBtn.Enabled = false;
            disableAllBtn.Enabled = false;
            maxSeats.Enabled = false;
            
            // Reset all person buttons
            personABtn.Enabled = false;
            personBBtn.Enabled = false;
            personCBtn.Enabled = false;

            numRows.Enabled = true;
            numSeatsPerRow.Enabled = true;
            personDBtn.Enabled = false;

            numRow = 7;
            numCol = 14;
            numRows.Text = "";
            numSeatsPerRow.Text = "";
            seatEditorBtn.Text = "Enter Editor Mode";

            endBtn.Enabled = true;

        }

        // Method to reset the simulation
        private void Reset(string filepath, bool loading = false)
        {
            layoutHandler.activePerson = null;
            layoutHandler.seatCounter = 0;
            layoutHandler.bookedSeats = new List<Node>();

            // Clear all existing controls
            seatsPanel.Controls.Clear();

            // Reset all person buttons
            personABtn.Enabled = true;
            personBBtn.Enabled = true;
            personCBtn.Enabled = true;
            personDBtn.Enabled = true;

            personA.HasBooked = false;
            personB.HasBooked = false;
            personC.HasBooked = false;
            personD.HasBooked = false;

            // Reload a new set of _seats
            _seats = fileManager.Load(filepath);

            // Generate seats based on data
            foreach (Node seatNode in _seats)
            {
                if (!loading)
                {
                    // Disable all seats by default
                    seatNode.seat.Disabled = true;
                }
                seatsPanel.Controls.Add(layoutHandler.GenerateSeat(seatNode));
                if (seatNode.seat.BookedBy == null)
                {
                    continue;
                }
                else
                {
                    // If seat was booked by someone, reassign person values as appropriate 
                    switch (seatNode.seat.BookedBy.Id)
                    {
                        case 1:
                            personABtn.Enabled = false;
                            personA.HasBooked = true;
                            break;
                        case 2:
                            personBBtn.Enabled = false;
                            personB.HasBooked = true;
                            break;
                        case 3:
                            personCBtn.Enabled = false;
                            personC.HasBooked = true;
                            break;
                        case 4:
                            personDBtn.Enabled = false;
                            personD.HasBooked = true;
                            break;
                    }
                }
            }

            // Pass reference to seats panel
            layoutHandler.seatsPanel = seatsPanel;

            // Generate screen
            seatsPanel.Controls.Add(layoutHandler.GenerateScreen(471, 19));

            // Enable setup safe distancing button
            setupSafeDistanceBtn.Enabled = true;

            // Pass reference of _seats dll to layoutHandler
            layoutHandler.Seats = _seats;

            // Clears info panel
            infoPanel.Text = "";
        }

        private void numSeatsPerRow_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            // Tooltip to display error messages
            ToolTip message = new ToolTip();

            // Checks if input can be parsed into int
            try
            {
                // Ensures values are in range
                if (int.Parse(numSeatsPerRow.Text) < 10 || int.Parse(numSeatsPerRow.Text) > 14)
                {
                    message.Show("Please key in a number between 10 - 14", textbox, 0, -45, 1000);
                    // Resets numcol
                    numCol = 0;

                    // Disables layout button
                    setupLayoutBtn.Enabled = false;
                }
                else
                {
                    numCol = int.Parse(numSeatsPerRow.Text);
                    // Enables layout button only when both numRow and numCol have values
                    setupLayoutBtn.Enabled = (numRow > 0 && numCol > 0);
                }
            }
            catch (FormatException ex)
            {
                // Resets numcol
                numCol = 0;

                // Disables layout button
                setupLayoutBtn.Enabled = false;
                message.Show("Please key in a number between 10 - 14", textbox, 0, -45, 1000);
            }
        }

        // Method to set up safe distancing
        private void setupSafeDistancingUtil()
        {
            // Sets cursor to wait
            Cursor.Current = Cursors.WaitCursor;

            // Iterates through all seats 
            foreach (Node seatNode in _seats)
            {
                // Disables seat based on numbering
                if (seatNode.seat.Number[0] % 2 == 1)
                {
                    if (!(seatNode.seat.Number[1] == 3 || seatNode.seat.Number[1] == 4 || seatNode.seat.Number[1] == 8 || seatNode.seat.Number[1] == 9 || seatNode.seat.Number[1] == 14))
                    {
                        seatNode.seat.Disabled = false;
                    }
                }
                else
                {
                    if (seatNode.seat.Number[1] == 3 || seatNode.seat.Number[1] == 4 || seatNode.seat.Number[1] == 8 || seatNode.seat.Number[1] == 9 || seatNode.seat.Number[1] == 14)
                    {
                        seatNode.seat.Disabled = false;
                    }
                }

                foreach (Control item in seatsPanel.Controls)
                {
                    if (item.Tag == seatNode)
                    {
                        if (seatNode.seat.Booked == true)
                        {
                            item.BackColor = Color.Pink;
                        }
                    }

                    layoutHandler.Refresh(seatNode, item);
                }
            }

            // Disables safe distancing button
            setupSafeDistanceBtn.Enabled = false;

            // Resets cursor
            Cursor.Current = Cursors.Default;
        }

        private void seatEditorBtn_Click(object sender, EventArgs e)
        {
            // For entering editor mode
            if (seatEditorBtn.Text == "Enter Editor Mode")
            {
                infoPanel.Text = "Seat Editor enabled!";

                // Enable option buttons
                layoutHandler.editorMode = true;
                disableRadioBtn.Enabled = true;
                enableRadioBtn.Enabled = true;
                enableAllBtn.Enabled = true;
                disableAllBtn.Enabled = true;
                seatEditorBtn.Text = "Exit Editor Mode";

                // Disable person buttons
                personABtn.Enabled = false;
                personBBtn.Enabled = false;
                personCBtn.Enabled = false;
                personDBtn.Enabled = false;
            }
            // For exiting editor mode
            else
            {
                seatEditorBtn.Text = "Enter Editor Mode";
                infoPanel.Text = "Exited Seat Editor!";

                // Disable option buttons
                layoutHandler.editorMode = false;
                disableRadioBtn.Enabled = false;
                enableRadioBtn.Enabled = false;
                enableAllBtn.Enabled = false;
                disableAllBtn.Enabled = false;

                // Enable person buttons
                personABtn.Enabled = true;
                personBBtn.Enabled = true;
                personCBtn.Enabled = true;
                personDBtn.Enabled = true;
            }
        }

        // Handles when radio button is changed
        private void enableRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (enableRadioBtn.Checked)
            {
                // Set appropriate mode
                layoutHandler.enabler = enableRadioBtn.Checked.ToString();
                infoPanel.Text += "\nClick seats to enable.";
            }
        }

        // Handles when radio button is changed
        private void disableRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (disableRadioBtn.Checked)
            {
                // Set appropriate mode
                layoutHandler.enabler = (!disableRadioBtn.Checked).ToString();
                infoPanel.Text += "\nClick seats to disable.";
            }
        }
        
        // Handles when enableAllBtn is clicked
        private void enableAllBtn_Click(object sender, EventArgs e)
        {
            // Loop through all seats
            foreach (Node seatNode in _seats)
            {
                // Enables seat
                seatNode.seat.Disabled = false;
                // Change colour of seat
                foreach (Control item in seatsPanel.Controls)
                {
                    layoutHandler.Refresh(seatNode, item);
                }
            }
        }

        // Handles when disableAllBtn is clicked.
        private void disableAllBtn_Click(object sender, EventArgs e)
        {
            // Loop through all seats
            foreach (Node seatNode in _seats)
            {
                // Disables seat
                seatNode.seat.Disabled = true;
                // Change colour of seat
                foreach (Control item in seatsPanel.Controls)
                {
                    layoutHandler.Refresh(seatNode, item);
                }
            }
        }

        // Handles when endBtn is clicked.
        private void endBtn_Click(object sender, EventArgs e)
        {
            // Show message to indicate simulation has ended   
            MessageBox.Show("Simulation Ended!");
            infoPanel.Text = ("Simulation Ended. Reset Simulation to restart.");

            layoutHandler.activePerson = null;

            // Loop through all seats
            foreach (Node seatNode in _seats)
            {
                // Change colour of seat
                foreach (Control item in seatsPanel.Controls)
                {
                    layoutHandler.Refresh(seatNode, item);
                }
            }

            // Disable option buttons
            layoutHandler.editorMode = false;
            seatEditorBtn.Enabled = false;
            disableRadioBtn.Enabled = false;
            enableRadioBtn.Enabled = false;
            enableAllBtn.Enabled = false;
            disableAllBtn.Enabled = false;
            maxSeats.Enabled = false;
            setupSafeDistanceBtn.Enabled = false;
            numRows.Enabled = false;
            numSeatsPerRow.Enabled = false;
            setupLayoutBtn.Enabled = false;

            // Enable person buttons
            personABtn.Enabled = false;
            personBBtn.Enabled = false;
            personCBtn.Enabled = false;
            personDBtn.Enabled = false;

            endBtn.Enabled = false;
        }

        // Handles when maxSeats text box is changed
        private void maxSeats_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;

            // Create tool tip
            ToolTip message = new ToolTip();

            // Checks if input can be parsed into int
            try
            {
                // If possible, set max num seats to value
                if (int.Parse(maxSeats.Text) > 0)
                {
                    maxNumSeats = int.Parse(maxSeats.Text);
                    layoutHandler.maxSeats = maxNumSeats;
                }
                // If value is negative, show tooltip to ask for positive number, set max num seats to 0
                else
                {
                    message.Show("Please key in a positive number.", textbox, 0, -45, 1000);
                    maxNumSeats = 0;
                }

            }
            // Show tooltip to ask for number, set max num seats to 0
            catch (FormatException ex)
            {
                message.Show("Please only key in numbers!", textbox, 0, -45, 1000);
                maxNumSeats = 0;
            }
        }
    }
}
