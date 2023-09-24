namespace Deliverable_1_
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputSodasSold = new System.Windows.Forms.TextBox();
            this.inputChipsSold = new System.Windows.Forms.TextBox();
            this.inputCandySold = new System.Windows.Forms.TextBox();
            this.calcSodas = new System.Windows.Forms.TextBox();
            this.calcChips = new System.Windows.Forms.TextBox();
            this.calcCandy = new System.Windows.Forms.TextBox();
            this.lblSodaWarning = new System.Windows.Forms.Label();
            this.lblChipsWarning = new System.Windows.Forms.Label();
            this.lblCandyWarning = new System.Windows.Forms.Label();
            this.eventLog1 = new System.Diagnostics.EventLog();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "How many unit of Soda where sold today?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "How many units of Chips were sold?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "How many units of candy were sold?";
            // 
            // inputSodasSold
            // 
            this.inputSodasSold.Location = new System.Drawing.Point(258, 32);
            this.inputSodasSold.Name = "inputSodasSold";
            this.inputSodasSold.Size = new System.Drawing.Size(199, 20);
            this.inputSodasSold.TabIndex = 3;
            this.inputSodasSold.TextChanged += new System.EventHandler(this.inputSodasSold_TextChanged);
            // 
            // inputChipsSold
            // 
            this.inputChipsSold.Location = new System.Drawing.Point(258, 78);
            this.inputChipsSold.Name = "inputChipsSold";
            this.inputChipsSold.Size = new System.Drawing.Size(199, 20);
            this.inputChipsSold.TabIndex = 4;
            this.inputChipsSold.TextChanged += new System.EventHandler(this.inputChipsSold_TextChanged_1);
            // 
            // inputCandySold
            // 
            this.inputCandySold.Location = new System.Drawing.Point(258, 131);
            this.inputCandySold.Name = "inputCandySold";
            this.inputCandySold.Size = new System.Drawing.Size(199, 20);
            this.inputCandySold.TabIndex = 5;
            this.inputCandySold.TextChanged += new System.EventHandler(this.inputCandySold_TextChanged_1);
            // 
            // calcSodas
            // 
            this.calcSodas.Location = new System.Drawing.Point(238, 295);
            this.calcSodas.Name = "calcSodas";
            this.calcSodas.Size = new System.Drawing.Size(314, 20);
            this.calcSodas.TabIndex = 6;
            // 
            // calcChips
            // 
            this.calcChips.Location = new System.Drawing.Point(238, 334);
            this.calcChips.Name = "calcChips";
            this.calcChips.Size = new System.Drawing.Size(314, 20);
            this.calcChips.TabIndex = 7;
            // 
            // calcCandy
            // 
            this.calcCandy.Location = new System.Drawing.Point(238, 377);
            this.calcCandy.Name = "calcCandy";
            this.calcCandy.Size = new System.Drawing.Size(314, 20);
            this.calcCandy.TabIndex = 8;
            // 
            // lblSodaWarning
            // 
            this.lblSodaWarning.AutoSize = true;
            this.lblSodaWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSodaWarning.ForeColor = System.Drawing.Color.Red;
            this.lblSodaWarning.Location = new System.Drawing.Point(255, 16);
            this.lblSodaWarning.Name = "lblSodaWarning";
            this.lblSodaWarning.Size = new System.Drawing.Size(252, 13);
            this.lblSodaWarning.TabIndex = 9;
            this.lblSodaWarning.Text = "Input exceedes inventory, please try again!";
            this.lblSodaWarning.Visible = false;
            // 
            // lblChipsWarning
            // 
            this.lblChipsWarning.AutoSize = true;
            this.lblChipsWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChipsWarning.ForeColor = System.Drawing.Color.Red;
            this.lblChipsWarning.Location = new System.Drawing.Point(258, 62);
            this.lblChipsWarning.Name = "lblChipsWarning";
            this.lblChipsWarning.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblChipsWarning.Size = new System.Drawing.Size(252, 13);
            this.lblChipsWarning.TabIndex = 10;
            this.lblChipsWarning.Text = "Input exceedes inventory, please try again!";
            this.lblChipsWarning.Visible = false;
            // 
            // lblCandyWarning
            // 
            this.lblCandyWarning.AutoSize = true;
            this.lblCandyWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCandyWarning.ForeColor = System.Drawing.Color.Red;
            this.lblCandyWarning.Location = new System.Drawing.Point(255, 115);
            this.lblCandyWarning.Name = "lblCandyWarning";
            this.lblCandyWarning.Size = new System.Drawing.Size(252, 13);
            this.lblCandyWarning.TabIndex = 11;
            this.lblCandyWarning.Text = "Input exceedes inventory, please try again!";
            this.lblCandyWarning.Visible = false;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCandyWarning);
            this.Controls.Add(this.lblChipsWarning);
            this.Controls.Add(this.lblSodaWarning);
            this.Controls.Add(this.calcCandy);
            this.Controls.Add(this.calcChips);
            this.Controls.Add(this.calcSodas);
            this.Controls.Add(this.inputCandySold);
            this.Controls.Add(this.inputChipsSold);
            this.Controls.Add(this.inputSodasSold);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputSodasSold;
        private System.Windows.Forms.TextBox inputChipsSold;
        private System.Windows.Forms.TextBox inputCandySold;
        private System.Windows.Forms.TextBox calcSodas;
        private System.Windows.Forms.TextBox calcChips;
        private System.Windows.Forms.TextBox calcCandy;
        private System.Windows.Forms.Label lblSodaWarning;
        private System.Windows.Forms.Label lblChipsWarning;
        private System.Windows.Forms.Label lblCandyWarning;
        private System.Diagnostics.EventLog eventLog1;
    }
}

