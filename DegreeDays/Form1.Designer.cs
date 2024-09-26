namespace DegreeDays
{
    partial class formDegreeDay
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.llbLow = new System.Windows.Forms.Label();
            this.lblHigh = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.txtBoxLow = new System.Windows.Forms.TextBox();
            this.txtBoxHigh = new System.Windows.Forms.TextBox();
            this.txtBoxBase = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.lblDegreeDaysHeader = new System.Windows.Forms.Label();
            this.lblDegreeDays = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.Black;
            this.btnCalculate.Location = new System.Drawing.Point(51, 309);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(109, 57);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(211, 309);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(109, 57);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.RosyBrown;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(371, 309);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 57);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // llbLow
            // 
            this.llbLow.AutoSize = true;
            this.llbLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbLow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.llbLow.Location = new System.Drawing.Point(46, 89);
            this.llbLow.Name = "llbLow";
            this.llbLow.Size = new System.Drawing.Size(55, 26);
            this.llbLow.TabIndex = 3;
            this.llbLow.Text = "Low";
            // 
            // lblHigh
            // 
            this.lblHigh.AutoSize = true;
            this.lblHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHigh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblHigh.Location = new System.Drawing.Point(46, 188);
            this.lblHigh.Name = "lblHigh";
            this.lblHigh.Size = new System.Drawing.Size(61, 26);
            this.lblHigh.TabIndex = 4;
            this.lblHigh.Text = "High";
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblBase.Location = new System.Drawing.Point(326, 89);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(207, 26);
            this.lblBase.TabIndex = 5;
            this.lblBase.Text = "Base Temperature";
            // 
            // txtBoxLow
            // 
            this.txtBoxLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLow.Location = new System.Drawing.Point(109, 89);
            this.txtBoxLow.Name = "txtBoxLow";
            this.txtBoxLow.Size = new System.Drawing.Size(100, 30);
            this.txtBoxLow.TabIndex = 6;
            // 
            // txtBoxHigh
            // 
            this.txtBoxHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxHigh.Location = new System.Drawing.Point(109, 188);
            this.txtBoxHigh.Name = "txtBoxHigh";
            this.txtBoxHigh.Size = new System.Drawing.Size(100, 30);
            this.txtBoxHigh.TabIndex = 7;
            // 
            // txtBoxBase
            // 
            this.txtBoxBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBase.Location = new System.Drawing.Point(331, 139);
            this.txtBoxBase.Name = "txtBoxBase";
            this.txtBoxBase.Size = new System.Drawing.Size(150, 30);
            this.txtBoxBase.TabIndex = 8;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(47, 246);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(171, 24);
            this.lblError.TabIndex = 9;
            this.lblError.Text = "tempErrorMessage";
            // 
            // lblDegreeDaysHeader
            // 
            this.lblDegreeDaysHeader.AutoSize = true;
            this.lblDegreeDaysHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDegreeDaysHeader.ForeColor = System.Drawing.Color.White;
            this.lblDegreeDaysHeader.Location = new System.Drawing.Point(80, 399);
            this.lblDegreeDaysHeader.Name = "lblDegreeDaysHeader";
            this.lblDegreeDaysHeader.Size = new System.Drawing.Size(386, 39);
            this.lblDegreeDaysHeader.TabIndex = 10;
            this.lblDegreeDaysHeader.Text = "Electrical Degree Days";
            // 
            // lblDegreeDays
            // 
            this.lblDegreeDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.lblDegreeDays.ForeColor = System.Drawing.Color.LightGreen;
            this.lblDegreeDays.Location = new System.Drawing.Point(117, 438);
            this.lblDegreeDays.Name = "lblDegreeDays";
            this.lblDegreeDays.Size = new System.Drawing.Size(312, 78);
            this.lblDegreeDays.TabIndex = 11;
            this.lblDegreeDays.Text = "tempDegreeDays";
            this.lblDegreeDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(51, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(211, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 57);
            this.button2.TabIndex = 1;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RosyBrown;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(371, 309);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 57);
            this.button3.TabIndex = 2;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // formDegreeDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(546, 567);
            this.Controls.Add(this.lblDegreeDays);
            this.Controls.Add(this.lblDegreeDaysHeader);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtBoxBase);
            this.Controls.Add(this.txtBoxHigh);
            this.Controls.Add(this.txtBoxLow);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.lblHigh);
            this.Controls.Add(this.llbLow);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCalculate);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "formDegreeDay";
            this.Text = "Degree Day Calculator";
            this.Load += new System.EventHandler(this.formDegreeDay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label llbLow;
        private System.Windows.Forms.Label lblHigh;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.TextBox txtBoxLow;
        private System.Windows.Forms.TextBox txtBoxHigh;
        private System.Windows.Forms.TextBox txtBoxBase;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblDegreeDaysHeader;
        private System.Windows.Forms.Label lblDegreeDays;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

