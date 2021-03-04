namespace Part_4___Random_Assignment
{
    partial class RandomNumbers
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
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnInt = new System.Windows.Forms.Button();
            this.btnDouble = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(143, 84);
            this.txtMax.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(180, 20);
            this.txtMax.TabIndex = 0;
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(143, 155);
            this.txtMin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(180, 20);
            this.txtMin.TabIndex = 1;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("SimSun-ExtB", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(64, 18);
            this.lblInstructions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(259, 15);
            this.lblInstructions.TabIndex = 2;
            this.lblInstructions.Text = "Enter a maximum and minimum:";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Font = new System.Drawing.Font("SimSun-ExtB", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.Location = new System.Drawing.Point(50, 84);
            this.lblMax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(79, 15);
            this.lblMax.TabIndex = 3;
            this.lblMax.Text = "Maximum:";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("SimSun-ExtB", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.Location = new System.Drawing.Point(50, 156);
            this.lblMin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(79, 15);
            this.lblMin.TabIndex = 4;
            this.lblMin.Text = "Minimum:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(77, 269);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(75, 19);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "Result";
            // 
            // btnInt
            // 
            this.btnInt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInt.Font = new System.Drawing.Font("SimSun-ExtB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInt.Location = new System.Drawing.Point(52, 206);
            this.btnInt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInt.Name = "btnInt";
            this.btnInt.Size = new System.Drawing.Size(128, 31);
            this.btnInt.TabIndex = 6;
            this.btnInt.Text = "Get Integer";
            this.btnInt.UseVisualStyleBackColor = false;
            this.btnInt.Click += new System.EventHandler(this.btnInt_Click);
            // 
            // btnDouble
            // 
            this.btnDouble.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDouble.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDouble.Font = new System.Drawing.Font("SimSun-ExtB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDouble.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDouble.Location = new System.Drawing.Point(204, 206);
            this.btnDouble.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(128, 31);
            this.btnDouble.TabIndex = 7;
            this.btnDouble.Text = "Get Double";
            this.btnDouble.UseVisualStyleBackColor = false;
            this.btnDouble.Click += new System.EventHandler(this.btnDouble_Click);
            // 
            // RandomNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 320);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.btnInt);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtMax);
            this.Name = "RandomNumbers";
            this.Text = "Random Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnInt;
        private System.Windows.Forms.Button btnDouble;
    }
}

