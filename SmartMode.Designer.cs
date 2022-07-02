
namespace CinemaBookingSystem
{
    partial class SmartMode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numSeatsPerRow = new System.Windows.Forms.TextBox();
            this.numRows = new System.Windows.Forms.TextBox();
            this.setupSafeDistanceBtn = new System.Windows.Forms.Button();
            this.setupLayoutBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.seatsPanel = new System.Windows.Forms.Panel();
            this.screenLabel = new System.Windows.Forms.Label();
            this.infoPanel = new System.Windows.Forms.Label();
            this.resetSimulationBtn = new System.Windows.Forms.Button();
            this.personDBtn = new System.Windows.Forms.Button();
            this.personCBtn = new System.Windows.Forms.Button();
            this.personBBtn = new System.Windows.Forms.Button();
            this.personABtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.maxSeats = new System.Windows.Forms.TextBox();
            this.endBtn = new System.Windows.Forms.Button();
            this.seatsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 32);
            this.label2.TabIndex = 48;
            this.label2.Text = "Seats per Row";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(132, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 32);
            this.label1.TabIndex = 47;
            this.label1.Text = "Row";
            // 
            // numSeatsPerRow
            // 
            this.numSeatsPerRow.Location = new System.Drawing.Point(230, 167);
            this.numSeatsPerRow.MaxLength = 2;
            this.numSeatsPerRow.Name = "numSeatsPerRow";
            this.numSeatsPerRow.Size = new System.Drawing.Size(148, 39);
            this.numSeatsPerRow.TabIndex = 46;
            this.numSeatsPerRow.TextChanged += new System.EventHandler(this.numSeatsPerRow_TextChanged);
            // 
            // numRows
            // 
            this.numRows.Location = new System.Drawing.Point(230, 111);
            this.numRows.MaxLength = 2;
            this.numRows.Name = "numRows";
            this.numRows.Size = new System.Drawing.Size(146, 39);
            this.numRows.TabIndex = 45;
            this.numRows.TextChanged += new System.EventHandler(this.numRows_TextChanged);
            // 
            // setupSafeDistanceBtn
            // 
            this.setupSafeDistanceBtn.Enabled = false;
            this.setupSafeDistanceBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.setupSafeDistanceBtn.Location = new System.Drawing.Point(23, 304);
            this.setupSafeDistanceBtn.Name = "setupSafeDistanceBtn";
            this.setupSafeDistanceBtn.Size = new System.Drawing.Size(355, 54);
            this.setupSafeDistanceBtn.TabIndex = 44;
            this.setupSafeDistanceBtn.Text = "Setup Safe Distance Mode";
            this.setupSafeDistanceBtn.UseVisualStyleBackColor = true;
            this.setupSafeDistanceBtn.Click += new System.EventHandler(this.setupSafeDistanceBtn_Click);
            // 
            // setupLayoutBtn
            // 
            this.setupLayoutBtn.Enabled = false;
            this.setupLayoutBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.setupLayoutBtn.Location = new System.Drawing.Point(23, 228);
            this.setupLayoutBtn.Name = "setupLayoutBtn";
            this.setupLayoutBtn.Size = new System.Drawing.Size(355, 54);
            this.setupLayoutBtn.TabIndex = 43;
            this.setupLayoutBtn.Text = "Setup Cinema Seat Layout";
            this.setupLayoutBtn.UseVisualStyleBackColor = true;
            this.setupLayoutBtn.Click += new System.EventHandler(this.setupLayoutBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveBtn.Location = new System.Drawing.Point(218, 23);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(158, 56);
            this.saveBtn.TabIndex = 36;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.loadBtn.Enabled = false;
            this.loadBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loadBtn.Location = new System.Drawing.Point(21, 23);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(158, 56);
            this.loadBtn.TabIndex = 35;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = false;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // seatsPanel
            // 
            this.seatsPanel.AutoScroll = true;
            this.seatsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seatsPanel.Controls.Add(this.screenLabel);
            this.seatsPanel.Location = new System.Drawing.Point(433, 23);
            this.seatsPanel.Name = "seatsPanel";
            this.seatsPanel.Size = new System.Drawing.Size(1870, 1088);
            this.seatsPanel.TabIndex = 34;
            // 
            // screenLabel
            // 
            this.screenLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.screenLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.screenLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.screenLabel.Location = new System.Drawing.Point(467, 19);
            this.screenLabel.Name = "screenLabel";
            this.screenLabel.Size = new System.Drawing.Size(1016, 64);
            this.screenLabel.TabIndex = 0;
            this.screenLabel.Text = "SCREEN";
            this.screenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoPanel
            // 
            this.infoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoPanel.Location = new System.Drawing.Point(23, 947);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(353, 164);
            this.infoPanel.TabIndex = 42;
            // 
            // resetSimulationBtn
            // 
            this.resetSimulationBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resetSimulationBtn.Location = new System.Drawing.Point(21, 870);
            this.resetSimulationBtn.Name = "resetSimulationBtn";
            this.resetSimulationBtn.Size = new System.Drawing.Size(355, 54);
            this.resetSimulationBtn.TabIndex = 41;
            this.resetSimulationBtn.Text = "Reset Simulation";
            this.resetSimulationBtn.UseVisualStyleBackColor = true;
            this.resetSimulationBtn.Click += new System.EventHandler(this.resetSimulationBtn_Click);
            // 
            // personDBtn
            // 
            this.personDBtn.BackColor = System.Drawing.Color.Green;
            this.personDBtn.Enabled = false;
            this.personDBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.personDBtn.Location = new System.Drawing.Point(21, 692);
            this.personDBtn.Name = "personDBtn";
            this.personDBtn.Size = new System.Drawing.Size(355, 54);
            this.personDBtn.TabIndex = 40;
            this.personDBtn.Text = "Person D Booking";
            this.personDBtn.UseVisualStyleBackColor = false;
            this.personDBtn.Click += new System.EventHandler(this.personDBtn_Click);
            // 
            // personCBtn
            // 
            this.personCBtn.BackColor = System.Drawing.Color.Red;
            this.personCBtn.Enabled = false;
            this.personCBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.personCBtn.Location = new System.Drawing.Point(21, 620);
            this.personCBtn.Name = "personCBtn";
            this.personCBtn.Size = new System.Drawing.Size(355, 54);
            this.personCBtn.TabIndex = 39;
            this.personCBtn.Text = "Person C Booking";
            this.personCBtn.UseVisualStyleBackColor = false;
            this.personCBtn.Click += new System.EventHandler(this.personCBtn_Click);
            // 
            // personBBtn
            // 
            this.personBBtn.BackColor = System.Drawing.Color.Blue;
            this.personBBtn.Enabled = false;
            this.personBBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.personBBtn.Location = new System.Drawing.Point(21, 546);
            this.personBBtn.Name = "personBBtn";
            this.personBBtn.Size = new System.Drawing.Size(355, 54);
            this.personBBtn.TabIndex = 38;
            this.personBBtn.Text = "Person B Booking";
            this.personBBtn.UseVisualStyleBackColor = false;
            this.personBBtn.Click += new System.EventHandler(this.personBBtn_Click);
            // 
            // personABtn
            // 
            this.personABtn.BackColor = System.Drawing.Color.Yellow;
            this.personABtn.Enabled = false;
            this.personABtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.personABtn.Location = new System.Drawing.Point(21, 475);
            this.personABtn.Name = "personABtn";
            this.personABtn.Size = new System.Drawing.Size(355, 54);
            this.personABtn.TabIndex = 37;
            this.personABtn.Text = "Person A Booking";
            this.personABtn.UseVisualStyleBackColor = false;
            this.personABtn.Click += new System.EventHandler(this.personABtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(21, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 32);
            this.label3.TabIndex = 50;
            this.label3.Text = "Max Seats";
            // 
            // maxSeats
            // 
            this.maxSeats.Enabled = false;
            this.maxSeats.Location = new System.Drawing.Point(176, 407);
            this.maxSeats.MaxLength = 2;
            this.maxSeats.Name = "maxSeats";
            this.maxSeats.Size = new System.Drawing.Size(200, 39);
            this.maxSeats.TabIndex = 49;
            this.maxSeats.TextChanged += new System.EventHandler(this.maxSeats_TextChanged);
            // 
            // endBtn
            // 
            this.endBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.endBtn.Location = new System.Drawing.Point(23, 771);
            this.endBtn.Name = "endBtn";
            this.endBtn.Size = new System.Drawing.Size(355, 54);
            this.endBtn.TabIndex = 51;
            this.endBtn.Text = "End Simulation";
            this.endBtn.UseVisualStyleBackColor = true;
            this.endBtn.Click += new System.EventHandler(this.endBtn_Click);
            // 
            // SmartMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2314, 1133);
            this.Controls.Add(this.endBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maxSeats);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numSeatsPerRow);
            this.Controls.Add(this.numRows);
            this.Controls.Add(this.setupSafeDistanceBtn);
            this.Controls.Add(this.setupLayoutBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.seatsPanel);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.resetSimulationBtn);
            this.Controls.Add(this.personDBtn);
            this.Controls.Add(this.personCBtn);
            this.Controls.Add(this.personBBtn);
            this.Controls.Add(this.personABtn);
            this.Name = "SmartMode";
            this.Text = "Safe Distancing (Smart Mode)";
            this.Load += new System.EventHandler(this.SmartMode_Load);
            this.seatsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numSeatsPerRow;
        private System.Windows.Forms.TextBox numRows;
        private System.Windows.Forms.Button setupSafeDistanceBtn;
        private System.Windows.Forms.Button setupLayoutBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Panel seatsPanel;
        private System.Windows.Forms.Label screenLabel;
        private System.Windows.Forms.Label infoPanel;
        private System.Windows.Forms.Button resetSimulationBtn;
        private System.Windows.Forms.Button personDBtn;
        private System.Windows.Forms.Button personCBtn;
        private System.Windows.Forms.Button personBBtn;
        private System.Windows.Forms.Button personABtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox maxSeats;
        private System.Windows.Forms.Button endBtn;
    }
}