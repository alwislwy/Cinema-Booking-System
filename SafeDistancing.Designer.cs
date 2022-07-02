
namespace CinemaBookingSystem
{
    partial class SafeDistancing
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
            this.setupLayoutBtn = new System.Windows.Forms.Button();
            this.setupSafeDistanceBtn = new System.Windows.Forms.Button();
            this.numRows = new System.Windows.Forms.TextBox();
            this.numSeatsPerRow = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.disableRadioBtn = new System.Windows.Forms.RadioButton();
            this.enableRadioBtn = new System.Windows.Forms.RadioButton();
            this.seatEditorBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.enableAllBtn = new System.Windows.Forms.Button();
            this.disableAllBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.maxSeats = new System.Windows.Forms.TextBox();
            this.endBtn = new System.Windows.Forms.Button();
            this.seatsPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveBtn.Location = new System.Drawing.Point(209, 22);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(158, 56);
            this.saveBtn.TabIndex = 21;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.loadBtn.Enabled = false;
            this.loadBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loadBtn.Location = new System.Drawing.Point(12, 22);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(158, 56);
            this.loadBtn.TabIndex = 20;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = false;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // seatsPanel
            // 
            this.seatsPanel.AutoScroll = true;
            this.seatsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seatsPanel.Controls.Add(this.screenLabel);
            this.seatsPanel.Location = new System.Drawing.Point(424, 22);
            this.seatsPanel.Name = "seatsPanel";
            this.seatsPanel.Size = new System.Drawing.Size(1870, 1332);
            this.seatsPanel.TabIndex = 19;
            // 
            // screenLabel
            // 
            this.screenLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.screenLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.screenLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.screenLabel.Location = new System.Drawing.Point(471, 19);
            this.screenLabel.Name = "screenLabel";
            this.screenLabel.Size = new System.Drawing.Size(1016, 64);
            this.screenLabel.TabIndex = 0;
            this.screenLabel.Text = "SCREEN";
            this.screenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoPanel
            // 
            this.infoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoPanel.Location = new System.Drawing.Point(16, 1242);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(353, 112);
            this.infoPanel.TabIndex = 27;
            // 
            // resetSimulationBtn
            // 
            this.resetSimulationBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resetSimulationBtn.Location = new System.Drawing.Point(14, 1157);
            this.resetSimulationBtn.Name = "resetSimulationBtn";
            this.resetSimulationBtn.Size = new System.Drawing.Size(355, 54);
            this.resetSimulationBtn.TabIndex = 26;
            this.resetSimulationBtn.Text = "Reset Simulation";
            this.resetSimulationBtn.UseVisualStyleBackColor = true;
            this.resetSimulationBtn.Click += new System.EventHandler(this.resetSimulationBtn_Click);
            // 
            // personDBtn
            // 
            this.personDBtn.BackColor = System.Drawing.Color.Green;
            this.personDBtn.Enabled = false;
            this.personDBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.personDBtn.Location = new System.Drawing.Point(12, 669);
            this.personDBtn.Name = "personDBtn";
            this.personDBtn.Size = new System.Drawing.Size(355, 54);
            this.personDBtn.TabIndex = 25;
            this.personDBtn.Text = "Person D Booking";
            this.personDBtn.UseVisualStyleBackColor = false;
            this.personDBtn.Click += new System.EventHandler(this.personDBtn_Click);
            // 
            // personCBtn
            // 
            this.personCBtn.BackColor = System.Drawing.Color.Red;
            this.personCBtn.Enabled = false;
            this.personCBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.personCBtn.Location = new System.Drawing.Point(12, 597);
            this.personCBtn.Name = "personCBtn";
            this.personCBtn.Size = new System.Drawing.Size(355, 54);
            this.personCBtn.TabIndex = 24;
            this.personCBtn.Text = "Person C Booking";
            this.personCBtn.UseVisualStyleBackColor = false;
            this.personCBtn.Click += new System.EventHandler(this.personCBtn_Click);
            // 
            // personBBtn
            // 
            this.personBBtn.BackColor = System.Drawing.Color.Blue;
            this.personBBtn.Enabled = false;
            this.personBBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.personBBtn.Location = new System.Drawing.Point(12, 523);
            this.personBBtn.Name = "personBBtn";
            this.personBBtn.Size = new System.Drawing.Size(355, 54);
            this.personBBtn.TabIndex = 23;
            this.personBBtn.Text = "Person B Booking";
            this.personBBtn.UseVisualStyleBackColor = false;
            this.personBBtn.Click += new System.EventHandler(this.personBBtn_Click);
            // 
            // personABtn
            // 
            this.personABtn.BackColor = System.Drawing.Color.Yellow;
            this.personABtn.Enabled = false;
            this.personABtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.personABtn.Location = new System.Drawing.Point(12, 452);
            this.personABtn.Name = "personABtn";
            this.personABtn.Size = new System.Drawing.Size(355, 54);
            this.personABtn.TabIndex = 22;
            this.personABtn.Text = "Person A Booking";
            this.personABtn.UseVisualStyleBackColor = false;
            this.personABtn.Click += new System.EventHandler(this.personABtn_Click);
            // 
            // setupLayoutBtn
            // 
            this.setupLayoutBtn.Enabled = false;
            this.setupLayoutBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.setupLayoutBtn.Location = new System.Drawing.Point(14, 227);
            this.setupLayoutBtn.Name = "setupLayoutBtn";
            this.setupLayoutBtn.Size = new System.Drawing.Size(355, 54);
            this.setupLayoutBtn.TabIndex = 28;
            this.setupLayoutBtn.Text = "Setup Cinema Seat Layout";
            this.setupLayoutBtn.UseVisualStyleBackColor = true;
            this.setupLayoutBtn.Click += new System.EventHandler(this.setupLayoutBtn_Click);
            // 
            // setupSafeDistanceBtn
            // 
            this.setupSafeDistanceBtn.Enabled = false;
            this.setupSafeDistanceBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.setupSafeDistanceBtn.Location = new System.Drawing.Point(14, 303);
            this.setupSafeDistanceBtn.Name = "setupSafeDistanceBtn";
            this.setupSafeDistanceBtn.Size = new System.Drawing.Size(355, 54);
            this.setupSafeDistanceBtn.TabIndex = 29;
            this.setupSafeDistanceBtn.Text = "Setup Safe Distance Mode";
            this.setupSafeDistanceBtn.UseVisualStyleBackColor = true;
            this.setupSafeDistanceBtn.Click += new System.EventHandler(this.setupSafeDistanceBtn_Click);
            // 
            // numRows
            // 
            this.numRows.Location = new System.Drawing.Point(221, 110);
            this.numRows.MaxLength = 2;
            this.numRows.Name = "numRows";
            this.numRows.Size = new System.Drawing.Size(146, 39);
            this.numRows.TabIndex = 30;
            this.numRows.TextChanged += new System.EventHandler(this.numRows_TextChanged);
            // 
            // numSeatsPerRow
            // 
            this.numSeatsPerRow.Location = new System.Drawing.Point(221, 166);
            this.numSeatsPerRow.MaxLength = 2;
            this.numSeatsPerRow.Name = "numSeatsPerRow";
            this.numSeatsPerRow.Size = new System.Drawing.Size(148, 39);
            this.numSeatsPerRow.TabIndex = 31;
            this.numSeatsPerRow.TextChanged += new System.EventHandler(this.numSeatsPerRow_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(123, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 32);
            this.label1.TabIndex = 32;
            this.label1.Text = "Row";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 32);
            this.label2.TabIndex = 33;
            this.label2.Text = "Seats per Row";
            // 
            // disableRadioBtn
            // 
            this.disableRadioBtn.AutoSize = true;
            this.disableRadioBtn.Enabled = false;
            this.disableRadioBtn.Location = new System.Drawing.Point(182, 118);
            this.disableRadioBtn.Name = "disableRadioBtn";
            this.disableRadioBtn.Size = new System.Drawing.Size(123, 36);
            this.disableRadioBtn.TabIndex = 23;
            this.disableRadioBtn.TabStop = true;
            this.disableRadioBtn.Text = "Disable";
            this.disableRadioBtn.UseVisualStyleBackColor = true;
            this.disableRadioBtn.CheckedChanged += new System.EventHandler(this.disableRadioBtn_CheckedChanged);
            // 
            // enableRadioBtn
            // 
            this.enableRadioBtn.AutoSize = true;
            this.enableRadioBtn.Enabled = false;
            this.enableRadioBtn.Location = new System.Drawing.Point(52, 118);
            this.enableRadioBtn.Name = "enableRadioBtn";
            this.enableRadioBtn.Size = new System.Drawing.Size(116, 36);
            this.enableRadioBtn.TabIndex = 22;
            this.enableRadioBtn.TabStop = true;
            this.enableRadioBtn.Text = "Enable";
            this.enableRadioBtn.UseVisualStyleBackColor = true;
            this.enableRadioBtn.CheckedChanged += new System.EventHandler(this.enableRadioBtn_CheckedChanged);
            // 
            // seatEditorBtn
            // 
            this.seatEditorBtn.Enabled = false;
            this.seatEditorBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.seatEditorBtn.Location = new System.Drawing.Point(40, 44);
            this.seatEditorBtn.Name = "seatEditorBtn";
            this.seatEditorBtn.Size = new System.Drawing.Size(269, 54);
            this.seatEditorBtn.TabIndex = 21;
            this.seatEditorBtn.Tag = "";
            this.seatEditorBtn.Text = "Enter Editor Mode";
            this.seatEditorBtn.UseVisualStyleBackColor = true;
            this.seatEditorBtn.Click += new System.EventHandler(this.seatEditorBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.enableAllBtn);
            this.groupBox1.Controls.Add(this.disableAllBtn);
            this.groupBox1.Controls.Add(this.disableRadioBtn);
            this.groupBox1.Controls.Add(this.enableRadioBtn);
            this.groupBox1.Controls.Add(this.seatEditorBtn);
            this.groupBox1.Location = new System.Drawing.Point(16, 814);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 314);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manual Editor";
            // 
            // enableAllBtn
            // 
            this.enableAllBtn.Enabled = false;
            this.enableAllBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enableAllBtn.Location = new System.Drawing.Point(96, 170);
            this.enableAllBtn.Name = "enableAllBtn";
            this.enableAllBtn.Size = new System.Drawing.Size(153, 54);
            this.enableAllBtn.TabIndex = 25;
            this.enableAllBtn.Tag = "";
            this.enableAllBtn.Text = "Enable All";
            this.enableAllBtn.UseVisualStyleBackColor = true;
            this.enableAllBtn.Click += new System.EventHandler(this.enableAllBtn_Click);
            // 
            // disableAllBtn
            // 
            this.disableAllBtn.Enabled = false;
            this.disableAllBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.disableAllBtn.Location = new System.Drawing.Point(96, 248);
            this.disableAllBtn.Name = "disableAllBtn";
            this.disableAllBtn.Size = new System.Drawing.Size(153, 54);
            this.disableAllBtn.TabIndex = 24;
            this.disableAllBtn.Tag = "";
            this.disableAllBtn.Text = "Disable All";
            this.disableAllBtn.UseVisualStyleBackColor = true;
            this.disableAllBtn.Click += new System.EventHandler(this.disableAllBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(14, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 32);
            this.label3.TabIndex = 36;
            this.label3.Text = "Max Seats";
            // 
            // maxSeats
            // 
            this.maxSeats.Enabled = false;
            this.maxSeats.Location = new System.Drawing.Point(169, 392);
            this.maxSeats.MaxLength = 2;
            this.maxSeats.Name = "maxSeats";
            this.maxSeats.Size = new System.Drawing.Size(200, 39);
            this.maxSeats.TabIndex = 35;
            this.maxSeats.TextChanged += new System.EventHandler(this.maxSeats_TextChanged);
            // 
            // endBtn
            // 
            this.endBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.endBtn.Location = new System.Drawing.Point(12, 740);
            this.endBtn.Name = "endBtn";
            this.endBtn.Size = new System.Drawing.Size(355, 54);
            this.endBtn.TabIndex = 37;
            this.endBtn.Text = "End Simulation";
            this.endBtn.UseVisualStyleBackColor = true;
            this.endBtn.Click += new System.EventHandler(this.endBtn_Click);
            // 
            // SafeDistancing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2316, 1366);
            this.Controls.Add(this.endBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maxSeats);
            this.Controls.Add(this.groupBox1);
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
            this.Name = "SafeDistancing";
            this.Text = "SafeDistancing";
            this.Load += new System.EventHandler(this.SafeDistancing_Load);
            this.seatsPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Button setupLayoutBtn;
        private System.Windows.Forms.Button setupSafeDistanceBtn;
        private System.Windows.Forms.TextBox numRows;
        private System.Windows.Forms.TextBox numSeatsPerRow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton disableRadioBtn;
        private System.Windows.Forms.RadioButton enableRadioBtn;
        private System.Windows.Forms.Button seatEditorBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button enableAllBtn;
        private System.Windows.Forms.Button disableAllBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox maxSeats;
        private System.Windows.Forms.Button endBtn;
    }
}