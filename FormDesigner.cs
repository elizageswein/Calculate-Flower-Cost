namespace Program_3
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
            this.grdnInpt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.itemNumInpt = new System.Windows.Forms.TextBox();
            this.quantInpt = new System.Windows.Forms.TextBox();
            this.calcBtn = new System.Windows.Forms.Button();
            this.flwrCostOutpt = new System.Windows.Forms.Label();
            this.adjstCostOutpt = new System.Windows.Forms.Label();
            this.discntOutpt = new System.Windows.Forms.Label();
            this.totalOutpt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // grdnInpt
            // 
            this.grdnInpt.FormattingEnabled = true;
            this.grdnInpt.Items.AddRange(new object[] {
            "Premium",
            "Standard",
            "Discount"});
            this.grdnInpt.Location = new System.Drawing.Point(225, 47);
            this.grdnInpt.Name = "grdnInpt";
            this.grdnInpt.Size = new System.Drawing.Size(121, 28);
            this.grdnInpt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Garden:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Entree/Item Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Flowers Cost:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Base Adjusted Cost:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Discount Percent:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(121, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Total Price:";
            // 
            // itemNumInpt
            // 
            this.itemNumInpt.Location = new System.Drawing.Point(225, 87);
            this.itemNumInpt.Name = "itemNumInpt";
            this.itemNumInpt.Size = new System.Drawing.Size(121, 26);
            this.itemNumInpt.TabIndex = 8;
            // 
            // quantInpt
            // 
            this.quantInpt.Location = new System.Drawing.Point(225, 131);
            this.quantInpt.Name = "quantInpt";
            this.quantInpt.Size = new System.Drawing.Size(121, 26);
            this.quantInpt.TabIndex = 9;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(160, 169);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(120, 36);
            this.calcBtn.TabIndex = 10;
            this.calcBtn.Text = "Calculate";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // flwrCostOutpt
            // 
            this.flwrCostOutpt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flwrCostOutpt.Location = new System.Drawing.Point(225, 224);
            this.flwrCostOutpt.Name = "flwrCostOutpt";
            this.flwrCostOutpt.Size = new System.Drawing.Size(100, 23);
            this.flwrCostOutpt.TabIndex = 11;
            // 
            // adjstCostOutpt
            // 
            this.adjstCostOutpt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adjstCostOutpt.Location = new System.Drawing.Point(225, 253);
            this.adjstCostOutpt.Name = "adjstCostOutpt";
            this.adjstCostOutpt.Size = new System.Drawing.Size(100, 23);
            this.adjstCostOutpt.TabIndex = 12;
            // 
            // discntOutpt
            // 
            this.discntOutpt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.discntOutpt.Location = new System.Drawing.Point(225, 283);
            this.discntOutpt.Name = "discntOutpt";
            this.discntOutpt.Size = new System.Drawing.Size(100, 23);
            this.discntOutpt.TabIndex = 13;
            // 
            // totalOutpt
            // 
            this.totalOutpt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalOutpt.Location = new System.Drawing.Point(225, 314);
            this.totalOutpt.Name = "totalOutpt";
            this.totalOutpt.Size = new System.Drawing.Size(100, 23);
            this.totalOutpt.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.totalOutpt);
            this.Controls.Add(this.discntOutpt);
            this.Controls.Add(this.adjstCostOutpt);
            this.Controls.Add(this.flwrCostOutpt);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.quantInpt);
            this.Controls.Add(this.itemNumInpt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdnInpt);
            this.Name = "Form1";
            this.Text = "The Happy Garden Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox grdnInpt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox itemNumInpt;
        private System.Windows.Forms.TextBox quantInpt;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Label flwrCostOutpt;
        private System.Windows.Forms.Label adjstCostOutpt;
        private System.Windows.Forms.Label discntOutpt;
        private System.Windows.Forms.Label totalOutpt;
    }
}

