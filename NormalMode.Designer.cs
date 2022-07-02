
namespace CinemaBookingSystem
{
    partial class NormalMode
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
            this.maxSeats = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.seatEditorBtn = new System.Windows.Forms.Button();
            this.enableRadioBtn = new System.Windows.Forms.RadioButton();
            this.disableRadioBtn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.enableAllBtn = new System.Windows.Forms.Button();
            this.disableAllBtn = new System.Windows.Forms.Button();
            this.endBtn = new System.Windows.Forms.Button();
            this.seatsPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveBtn.Location = new System.Drawing.Point(225, 25);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(158, 56);
            this.saveBtn.TabIndex = 12;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.loadBtn.Enabled = false;
            this.loadBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loadBtn.Location = new System.Drawing.Point(28, 25);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(158, 56);
            this.loadBtn.TabIndex = 11;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = false;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // seatsPanel
            // 
            this.seatsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seatsPanel.Controls.Add(this.screenLabel);
            this.seatsPanel.Location = new System.Drawing.Point(440, 25);
            this.seatsPanel.Name = "seatsPanel";
            this.seatsPanel.Size = new System.Drawing.Size(1704, 1160);
            this.seatsPanel.TabIndex = 10;
            // 
            // screenLabel
            // 
            this.screenLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.screenLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.screenLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.screenLabel.Location = new System.Drawing.Point(325, 27);
            this.screenLabel.Name = "screenLabel";
            this.screenLabel.Size = new System.Drawing.Size(1016, 64);
            this.screenLabel.TabIndex = 0;
            this.screenLabel.Text = "SCREEN";
            this.screenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoPanel
            // 
            this.infoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoPanel.Location = new System.Drawing.Point(28, 955);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(353, 228);
            this.infoPanel.TabIndex = 18;
            // 
            // resetSimulationBtn
            // 
            this.resetSimulationBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resetSimulationBtn.Location = new System.Drawing.Point(26, 874);
            this.resetSimulationBtn.Name = "resetSimulationBtn";
            this.resetSimulationBtn.Size = new System.Drawing.Size(355, 54);
            this.resetSimulationBtn.TabIndex = 17;
            this.resetSimulationBtn.Text = "Reset Simulation";
            this.resetSimulationBtn.UseVisualStyleBackColor = true;
            this.resetSimulationBtn.Click += new System.EventHandler(this.resetSimulationBtn_Click);
            // 
            // personDBtn
            // 
            this.personDBtn.BackColor = System.Drawing.Color.Green;
            this.personDBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.personDBtn.Location = new System.Drawing.Point(28, 394);
            this.personDBtn.Name = "personDBtn";
            this.personDBtn.Size = new System.Drawing.Size(355, 54);
            this.personDBtn.TabIndex = 16;
            this.personDBtn.Text = "Person D Booking";
            this.personDBtn.UseVisualStyleBackColor = false;
            this.personDBtn.Click += new System.EventHandler(this.personDBtn_Click);
            // 
            // personCBtn
            // 
            this.personCBtn.BackColor = System.Drawing.Color.Red;
            this.personCBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.personCBtn.Location = new System.Drawing.Point(28, 322);
            this.personCBtn.Name = "personCBtn";
            this.personCBtn.Size = new System.Drawing.Size(355, 54);
            this.personCBtn.TabIndex = 15;
            this.personCBtn.Text = "Person C Booking";
            this.personCBtn.UseVisualStyleBackColor = false;
            this.personCBtn.Click += new System.EventHandler(this.personCBtn_Click);
            // 
            // personBBtn
            // 
            this.personBBtn.BackColor = System.Drawing.Color.Blue;
            this.personBBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.personBBtn.Location = new System.Drawing.Point(28, 248);
            this.personBBtn.Name = "personBBtn";
            this.personBBtn.Size = new System.Drawing.Size(355, 54);
            this.personBBtn.TabIndex = 14;
            this.personBBtn.Text = "Person B Booking";
            this.personBBtn.UseVisualStyleBackColor = false;
            this.personBBtn.Click += new System.EventHandler(this.personBBtn_Click);
            // 
            // personABtn
            // 
            this.personABtn.BackColor = System.Drawing.Color.Yellow;
            this.personABtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.personABtn.Location = new System.Drawing.Point(28, 177);
            this.personABtn.Name = "personABtn";
            this.personABtn.Size = new System.Drawing.Size(355, 54);
            this.personABtn.TabIndex = 13;
            this.personABtn.Text = "Person A Booking";
            this.personABtn.UseVisualStyleBackColor = false;
            this.personABtn.Click += new System.EventHandler(this.personABtn_Click);
            // 
            // maxSeats
            // 
            this.maxSeats.Enabled = false;
            this.maxSeats.Location = new System.Drawing.Point(183, 113);
            this.maxSeats.MaxLength = 2;
            this.maxSeats.Name = "maxSeats";
            this.maxSeats.Size = new System.Drawing.Size(200, 39);
            this.maxSeats.TabIndex = 19;
            this.maxSeats.TextChanged += new System.EventHandler(this.maxSeats_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "Max Seats";
            // 
            // seatEditorBtn
            // 
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.enableAllBtn);
            this.groupBox1.Controls.Add(this.disableAllBtn);
            this.groupBox1.Controls.Add(this.disableRadioBtn);
            this.groupBox1.Controls.Add(this.enableRadioBtn);
            this.groupBox1.Controls.Add(this.seatEditorBtn);
            this.groupBox1.Location = new System.Drawing.Point(28, 540);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 314);
            this.groupBox1.TabIndex = 1;
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
            // endBtn
            // 
            this.endBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.endBtn.Location = new System.Drawing.Point(28, 469);
            this.endBtn.Name = "endBtn";
            this.endBtn.Size = new System.Drawing.Size(355, 54);
            this.endBtn.TabIndex = 21;
            this.endBtn.Text = "End Simulation";
            this.endBtn.UseVisualStyleBackColor = true;
            this.endBtn.Click += new System.EventHandler(this.endBtn_Click);
            // 
            // NormalMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2168, 1197);
            this.Controls.Add(this.endBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maxSeats);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.seatsPanel);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.resetSimulationBtn);
            this.Controls.Add(this.personDBtn);
            this.Controls.Add(this.personCBtn);
            this.Controls.Add(this.personBBtn);
            this.Controls.Add(this.personABtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "NormalMode";
            this.Text = "Normal Mode";
            this.Load += new System.EventHandler(this.NormalMode_Load);
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
        private System.Windows.Forms.TextBox maxSeats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button seatEditorBtn;
        private System.Windows.Forms.RadioButton enableRadioBtn;
        private System.Windows.Forms.RadioButton disableRadioBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button enableAllBtn;
        private System.Windows.Forms.Button disableAllBtn;
        private System.Windows.Forms.Button endBtn;
    }
}