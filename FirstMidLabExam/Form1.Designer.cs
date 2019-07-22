namespace FirstMidLabExam
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnStops = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxEven = new System.Windows.Forms.CheckBox();
            this.checkBoxOdd = new System.Windows.Forms.CheckBox();
            this.checkBoxFace = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(131, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnShuffle
            // 
            this.btnShuffle.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnShuffle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShuffle.Location = new System.Drawing.Point(348, 177);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(93, 34);
            this.btnShuffle.TabIndex = 2;
            this.btnShuffle.Text = "Shuffle";
            this.btnShuffle.UseVisualStyleBackColor = false;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnStops
            // 
            this.btnStops.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnStops.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStops.Location = new System.Drawing.Point(348, 241);
            this.btnStops.Name = "btnStops";
            this.btnStops.Size = new System.Drawing.Size(93, 34);
            this.btnStops.TabIndex = 3;
            this.btnStops.Text = "Stops";
            this.btnStops.UseVisualStyleBackColor = false;
            this.btnStops.Click += new System.EventHandler(this.btnStops_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 90;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Score";
            // 
            // checkBoxEven
            // 
            this.checkBoxEven.AutoSize = true;
            this.checkBoxEven.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEven.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBoxEven.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEven.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBoxEven.Location = new System.Drawing.Point(117, 73);
            this.checkBoxEven.Name = "checkBoxEven";
            this.checkBoxEven.Size = new System.Drawing.Size(90, 35);
            this.checkBoxEven.TabIndex = 7;
            this.checkBoxEven.Text = "Even";
            this.checkBoxEven.UseVisualStyleBackColor = false;
            this.checkBoxEven.CheckedChanged += new System.EventHandler(this.checkBoxEven_CheckedChanged);
            // 
            // checkBoxOdd
            // 
            this.checkBoxOdd.AutoSize = true;
            this.checkBoxOdd.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxOdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBoxOdd.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxOdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBoxOdd.Location = new System.Drawing.Point(221, 73);
            this.checkBoxOdd.Name = "checkBoxOdd";
            this.checkBoxOdd.Size = new System.Drawing.Size(82, 35);
            this.checkBoxOdd.TabIndex = 8;
            this.checkBoxOdd.Text = "Odd";
            this.checkBoxOdd.UseVisualStyleBackColor = false;
            this.checkBoxOdd.CheckedChanged += new System.EventHandler(this.checkBoxOdd_CheckedChanged);
            // 
            // checkBoxFace
            // 
            this.checkBoxFace.AutoSize = true;
            this.checkBoxFace.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxFace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBoxFace.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFace.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBoxFace.Location = new System.Drawing.Point(317, 73);
            this.checkBoxFace.Name = "checkBoxFace";
            this.checkBoxFace.Size = new System.Drawing.Size(86, 35);
            this.checkBoxFace.TabIndex = 9;
            this.checkBoxFace.Text = "Face";
            this.checkBoxFace.UseVisualStyleBackColor = false;
            this.checkBoxFace.CheckedChanged += new System.EventHandler(this.checkBoxFace_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(470, 406);
            this.Controls.Add(this.checkBoxFace);
            this.Controls.Add(this.checkBoxOdd);
            this.Controls.Add(this.checkBoxEven);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStops);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Button btnStops;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxEven;
        private System.Windows.Forms.CheckBox checkBoxOdd;
        private System.Windows.Forms.CheckBox checkBoxFace;
    }
}

