namespace HFch4_DayAtTheRaces
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.raceTrack = new System.Windows.Forms.PictureBox();
            this.hound1 = new System.Windows.Forms.PictureBox();
            this.bookmakerGroupBox = new System.Windows.Forms.GroupBox();
            this.alBetLabel = new System.Windows.Forms.Label();
            this.bobBetLabel = new System.Windows.Forms.Label();
            this.joeBetLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.houndNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.dollars4lHoundsLabel = new System.Windows.Forms.Label();
            this.amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.betButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.alRadioButton = new System.Windows.Forms.RadioButton();
            this.bobRadioButton = new System.Windows.Forms.RadioButton();
            this.joeRadioButton = new System.Windows.Forms.RadioButton();
            this.betLabel = new System.Windows.Forms.Label();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.hound2 = new System.Windows.Forms.PictureBox();
            this.hound3 = new System.Windows.Forms.PictureBox();
            this.hound4 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.raceTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hound1)).BeginInit();
            this.bookmakerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.houndNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hound2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hound3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hound4)).BeginInit();
            this.SuspendLayout();
            // 
            // raceTrack
            // 
            this.raceTrack.Image = ((System.Drawing.Image)(resources.GetObject("raceTrack.Image")));
            this.raceTrack.Location = new System.Drawing.Point(-3, -1);
            this.raceTrack.Name = "raceTrack";
            this.raceTrack.Size = new System.Drawing.Size(709, 242);
            this.raceTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.raceTrack.TabIndex = 0;
            this.raceTrack.TabStop = false;
            // 
            // hound1
            // 
            this.hound1.BackColor = System.Drawing.Color.Transparent;
            this.hound1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.hound1.Image = ((System.Drawing.Image)(resources.GetObject("hound1.Image")));
            this.hound1.Location = new System.Drawing.Point(0, 12);
            this.hound1.Name = "hound1";
            this.hound1.Size = new System.Drawing.Size(96, 28);
            this.hound1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hound1.TabIndex = 1;
            this.hound1.TabStop = false;
            // 
            // bookmakerGroupBox
            // 
            this.bookmakerGroupBox.Controls.Add(this.alBetLabel);
            this.bookmakerGroupBox.Controls.Add(this.bobBetLabel);
            this.bookmakerGroupBox.Controls.Add(this.joeBetLabel);
            this.bookmakerGroupBox.Controls.Add(this.startButton);
            this.bookmakerGroupBox.Controls.Add(this.houndNumericUpDown);
            this.bookmakerGroupBox.Controls.Add(this.dollars4lHoundsLabel);
            this.bookmakerGroupBox.Controls.Add(this.amountNumericUpDown);
            this.bookmakerGroupBox.Controls.Add(this.betButton);
            this.bookmakerGroupBox.Controls.Add(this.nameLabel);
            this.bookmakerGroupBox.Controls.Add(this.alRadioButton);
            this.bookmakerGroupBox.Controls.Add(this.bobRadioButton);
            this.bookmakerGroupBox.Controls.Add(this.joeRadioButton);
            this.bookmakerGroupBox.Controls.Add(this.betLabel);
            this.bookmakerGroupBox.Controls.Add(this.minimumBetLabel);
            this.bookmakerGroupBox.Location = new System.Drawing.Point(12, 247);
            this.bookmakerGroupBox.Name = "bookmakerGroupBox";
            this.bookmakerGroupBox.Size = new System.Drawing.Size(694, 229);
            this.bookmakerGroupBox.TabIndex = 2;
            this.bookmakerGroupBox.TabStop = false;
            this.bookmakerGroupBox.Text = "Bookmaker\'s House";
            // 
            // alBetLabel
            // 
            this.alBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alBetLabel.Location = new System.Drawing.Point(156, 132);
            this.alBetLabel.Name = "alBetLabel";
            this.alBetLabel.Size = new System.Drawing.Size(229, 16);
            this.alBetLabel.TabIndex = 16;
            this.alBetLabel.Text = "alBetLabel";
            // 
            // bobBetLabel
            // 
            this.bobBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bobBetLabel.Location = new System.Drawing.Point(156, 95);
            this.bobBetLabel.Name = "bobBetLabel";
            this.bobBetLabel.Size = new System.Drawing.Size(229, 16);
            this.bobBetLabel.TabIndex = 15;
            this.bobBetLabel.Text = "bobBetLabel";
            // 
            // joeBetLabel
            // 
            this.joeBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.joeBetLabel.Location = new System.Drawing.Point(156, 58);
            this.joeBetLabel.Name = "joeBetLabel";
            this.joeBetLabel.Size = new System.Drawing.Size(229, 16);
            this.joeBetLabel.TabIndex = 14;
            this.joeBetLabel.Text = "joeBetLabel";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(405, 57);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(145, 91);
            this.startButton.TabIndex = 13;
            this.startButton.Text = "START!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // houndNumericUpDown
            // 
            this.houndNumericUpDown.Location = new System.Drawing.Point(355, 186);
            this.houndNumericUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.houndNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.houndNumericUpDown.Name = "houndNumericUpDown";
            this.houndNumericUpDown.Size = new System.Drawing.Size(30, 20);
            this.houndNumericUpDown.TabIndex = 12;
            this.houndNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dollars4lHoundsLabel
            // 
            this.dollars4lHoundsLabel.AutoSize = true;
            this.dollars4lHoundsLabel.Location = new System.Drawing.Point(232, 188);
            this.dollars4lHoundsLabel.Name = "dollars4lHoundsLabel";
            this.dollars4lHoundsLabel.Size = new System.Drawing.Size(106, 13);
            this.dollars4lHoundsLabel.TabIndex = 11;
            this.dollars4lHoundsLabel.Text = "dollars for hound no.:";
            // 
            // amountNumericUpDown
            // 
            this.amountNumericUpDown.Location = new System.Drawing.Point(159, 186);
            this.amountNumericUpDown.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.amountNumericUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.amountNumericUpDown.Name = "amountNumericUpDown";
            this.amountNumericUpDown.Size = new System.Drawing.Size(55, 20);
            this.amountNumericUpDown.TabIndex = 10;
            this.amountNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // betButton
            // 
            this.betButton.Location = new System.Drawing.Point(83, 183);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(55, 23);
            this.betButton.TabIndex = 9;
            this.betButton.Text = "bets";
            this.betButton.UseVisualStyleBackColor = true;
            this.betButton.Click += new System.EventHandler(this.betButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(10, 188);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(24, 13);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Joe";
            // 
            // alRadioButton
            // 
            this.alRadioButton.AutoSize = true;
            this.alRadioButton.Location = new System.Drawing.Point(0, 131);
            this.alRadioButton.Name = "alRadioButton";
            this.alRadioButton.Size = new System.Drawing.Size(92, 17);
            this.alRadioButton.TabIndex = 4;
            this.alRadioButton.TabStop = true;
            this.alRadioButton.Text = "alRadioButton";
            this.alRadioButton.UseVisualStyleBackColor = true;
            this.alRadioButton.CheckedChanged += new System.EventHandler(this.alRadioButton_CheckedChanged);
            // 
            // bobRadioButton
            // 
            this.bobRadioButton.AutoSize = true;
            this.bobRadioButton.Location = new System.Drawing.Point(0, 94);
            this.bobRadioButton.Name = "bobRadioButton";
            this.bobRadioButton.Size = new System.Drawing.Size(102, 17);
            this.bobRadioButton.TabIndex = 3;
            this.bobRadioButton.TabStop = true;
            this.bobRadioButton.Text = "bobRadioButton";
            this.bobRadioButton.UseVisualStyleBackColor = true;
            this.bobRadioButton.CheckedChanged += new System.EventHandler(this.bobRadioButton_CheckedChanged);
            // 
            // joeRadioButton
            // 
            this.joeRadioButton.AutoSize = true;
            this.joeRadioButton.Checked = true;
            this.joeRadioButton.Location = new System.Drawing.Point(0, 57);
            this.joeRadioButton.Name = "joeRadioButton";
            this.joeRadioButton.Size = new System.Drawing.Size(98, 17);
            this.joeRadioButton.TabIndex = 2;
            this.joeRadioButton.TabStop = true;
            this.joeRadioButton.Text = "joeRadioButton";
            this.joeRadioButton.UseVisualStyleBackColor = true;
            this.joeRadioButton.CheckedChanged += new System.EventHandler(this.joeRadioButton_CheckedChanged);
            // 
            // betLabel
            // 
            this.betLabel.AutoSize = true;
            this.betLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.betLabel.Location = new System.Drawing.Point(156, 28);
            this.betLabel.Name = "betLabel";
            this.betLabel.Size = new System.Drawing.Size(32, 13);
            this.betLabel.TabIndex = 1;
            this.betLabel.Text = "Bets";
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minimumBetLabel.Location = new System.Drawing.Point(10, 28);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(92, 13);
            this.minimumBetLabel.TabIndex = 0;
            this.minimumBetLabel.Text = "Minimum bet: 5";
            // 
            // hound2
            // 
            this.hound2.BackColor = System.Drawing.Color.Transparent;
            this.hound2.Image = ((System.Drawing.Image)(resources.GetObject("hound2.Image")));
            this.hound2.Location = new System.Drawing.Point(0, 66);
            this.hound2.Name = "hound2";
            this.hound2.Size = new System.Drawing.Size(96, 30);
            this.hound2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hound2.TabIndex = 3;
            this.hound2.TabStop = false;
            // 
            // hound3
            // 
            this.hound3.BackColor = System.Drawing.Color.Transparent;
            this.hound3.Image = ((System.Drawing.Image)(resources.GetObject("hound3.Image")));
            this.hound3.Location = new System.Drawing.Point(0, 134);
            this.hound3.Name = "hound3";
            this.hound3.Size = new System.Drawing.Size(96, 30);
            this.hound3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hound3.TabIndex = 4;
            this.hound3.TabStop = false;
            this.hound3.Click += new System.EventHandler(this.hound3_Click);
            // 
            // hound4
            // 
            this.hound4.BackColor = System.Drawing.Color.Transparent;
            this.hound4.Image = ((System.Drawing.Image)(resources.GetObject("hound4.Image")));
            this.hound4.Location = new System.Drawing.Point(0, 193);
            this.hound4.Name = "hound4";
            this.hound4.Size = new System.Drawing.Size(96, 28);
            this.hound4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hound4.TabIndex = 5;
            this.hound4.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 481);
            this.Controls.Add(this.hound4);
            this.Controls.Add(this.hound3);
            this.Controls.Add(this.hound2);
            this.Controls.Add(this.bookmakerGroupBox);
            this.Controls.Add(this.hound1);
            this.Controls.Add(this.raceTrack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Day at the Races";
            ((System.ComponentModel.ISupportInitialize)(this.raceTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hound1)).EndInit();
            this.bookmakerGroupBox.ResumeLayout(false);
            this.bookmakerGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.houndNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hound2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hound3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hound4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox raceTrack;
        private System.Windows.Forms.PictureBox hound1;
        private System.Windows.Forms.GroupBox bookmakerGroupBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.NumericUpDown houndNumericUpDown;
        private System.Windows.Forms.Label dollars4lHoundsLabel;
        private System.Windows.Forms.NumericUpDown amountNumericUpDown;
        private System.Windows.Forms.Button betButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.RadioButton alRadioButton;
        private System.Windows.Forms.RadioButton bobRadioButton;
        private System.Windows.Forms.RadioButton joeRadioButton;
        private System.Windows.Forms.Label betLabel;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.PictureBox hound2;
        private System.Windows.Forms.PictureBox hound3;
        private System.Windows.Forms.PictureBox hound4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label joeBetLabel;
        private System.Windows.Forms.Label alBetLabel;
        private System.Windows.Forms.Label bobBetLabel;
    }
}

