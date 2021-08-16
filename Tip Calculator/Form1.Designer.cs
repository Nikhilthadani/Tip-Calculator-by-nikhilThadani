
namespace Tip_Calculator
{
    partial class CalculateTip
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtBillAmt = new System.Windows.Forms.TextBox();
            this.txtTipPercentage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDecreaseTip = new System.Windows.Forms.Button();
            this.btnIncreaseTip = new System.Windows.Forms.Button();
            this.btnIncresePeople = new System.Windows.Forms.Button();
            this.btnDecreasePeople = new System.Windows.Forms.Button();
            this.txtNoOfPeople = new System.Windows.Forms.TextBox();
            this.lblNoOfPeople = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotalPerPerson = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTipPerPerson = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bill";
            // 
            // txtBillAmt
            // 
            this.txtBillAmt.Location = new System.Drawing.Point(70, 87);
            this.txtBillAmt.Name = "txtBillAmt";
            this.txtBillAmt.PlaceholderText = "Ex: 500";
            this.txtBillAmt.Size = new System.Drawing.Size(207, 27);
            this.txtBillAmt.TabIndex = 1;
            this.txtBillAmt.TextChanged += new System.EventHandler(this.txtBillAmt_TextChanged);
            // 
            // txtTipPercentage
            // 
            this.txtTipPercentage.Location = new System.Drawing.Point(70, 184);
            this.txtTipPercentage.Name = "txtTipPercentage";
            this.txtTipPercentage.PlaceholderText = "Ex: 10";
            this.txtTipPercentage.Size = new System.Drawing.Size(207, 27);
            this.txtTipPercentage.TabIndex = 3;
            this.txtTipPercentage.TextChanged += new System.EventHandler(this.txtTipPercentage_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tip %";
            // 
            // btnDecreaseTip
            // 
            this.btnDecreaseTip.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDecreaseTip.Location = new System.Drawing.Point(21, 182);
            this.btnDecreaseTip.Name = "btnDecreaseTip";
            this.btnDecreaseTip.Size = new System.Drawing.Size(43, 29);
            this.btnDecreaseTip.TabIndex = 4;
            this.btnDecreaseTip.Text = "-";
            this.btnDecreaseTip.UseVisualStyleBackColor = false;
            this.btnDecreaseTip.Click += new System.EventHandler(this.btnDecreaseTip_Click);
            // 
            // btnIncreaseTip
            // 
            this.btnIncreaseTip.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnIncreaseTip.Location = new System.Drawing.Point(283, 182);
            this.btnIncreaseTip.Name = "btnIncreaseTip";
            this.btnIncreaseTip.Size = new System.Drawing.Size(43, 29);
            this.btnIncreaseTip.TabIndex = 6;
            this.btnIncreaseTip.Text = "+";
            this.btnIncreaseTip.UseVisualStyleBackColor = false;
            this.btnIncreaseTip.Click += new System.EventHandler(this.btnIncreaseTip_Click);
            // 
            // btnIncresePeople
            // 
            this.btnIncresePeople.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnIncresePeople.Location = new System.Drawing.Point(283, 287);
            this.btnIncresePeople.Name = "btnIncresePeople";
            this.btnIncresePeople.Size = new System.Drawing.Size(43, 29);
            this.btnIncresePeople.TabIndex = 10;
            this.btnIncresePeople.Text = "+";
            this.btnIncresePeople.UseVisualStyleBackColor = false;
            this.btnIncresePeople.Click += new System.EventHandler(this.btnIncresePeople_Click);
            // 
            // btnDecreasePeople
            // 
            this.btnDecreasePeople.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDecreasePeople.Location = new System.Drawing.Point(21, 285);
            this.btnDecreasePeople.Name = "btnDecreasePeople";
            this.btnDecreasePeople.Size = new System.Drawing.Size(43, 29);
            this.btnDecreasePeople.TabIndex = 9;
            this.btnDecreasePeople.Text = "-";
            this.btnDecreasePeople.UseVisualStyleBackColor = false;
            this.btnDecreasePeople.Click += new System.EventHandler(this.btnDecreasePeople_Click);
            // 
            // txtNoOfPeople
            // 
            this.txtNoOfPeople.Location = new System.Drawing.Point(70, 287);
            this.txtNoOfPeople.Name = "txtNoOfPeople";
            this.txtNoOfPeople.PlaceholderText = "Ex: 2";
            this.txtNoOfPeople.Size = new System.Drawing.Size(207, 27);
            this.txtNoOfPeople.TabIndex = 8;
            this.txtNoOfPeople.TextChanged += new System.EventHandler(this.txtNoOfPeople_TextChanged);
            // 
            // lblNoOfPeople
            // 
            this.lblNoOfPeople.AutoSize = true;
            this.lblNoOfPeople.Location = new System.Drawing.Point(32, 246);
            this.lblNoOfPeople.Name = "lblNoOfPeople";
            this.lblNoOfPeople.Size = new System.Drawing.Size(101, 20);
            this.lblNoOfPeople.TabIndex = 7;
            this.lblNoOfPeople.Text = "No. Of People";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotalPerPerson);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblTipPerPerson);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(388, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 238);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bill";
            // 
            // lblTotalPerPerson
            // 
            this.lblTotalPerPerson.AutoSize = true;
            this.lblTotalPerPerson.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalPerPerson.Location = new System.Drawing.Point(283, 131);
            this.lblTotalPerPerson.Name = "lblTotalPerPerson";
            this.lblTotalPerPerson.Size = new System.Drawing.Size(56, 46);
            this.lblTotalPerPerson.TabIndex = 13;
            this.lblTotalPerPerson.Text = "0$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Per Person";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(15, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 41);
            this.label8.TabIndex = 15;
            this.label8.Text = "Total";
            // 
            // lblTipPerPerson
            // 
            this.lblTipPerPerson.AutoSize = true;
            this.lblTipPerPerson.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTipPerPerson.Location = new System.Drawing.Point(283, 33);
            this.lblTipPerPerson.Name = "lblTipPerPerson";
            this.lblTipPerPerson.Size = new System.Drawing.Size(56, 46);
            this.lblTipPerPerson.TabIndex = 12;
            this.lblTipPerPerson.Text = "0$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Per Person";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(15, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 41);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tip";
            // 
            // CalculateTip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(901, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIncresePeople);
            this.Controls.Add(this.btnDecreasePeople);
            this.Controls.Add(this.txtNoOfPeople);
            this.Controls.Add(this.lblNoOfPeople);
            this.Controls.Add(this.btnIncreaseTip);
            this.Controls.Add(this.btnDecreaseTip);
            this.Controls.Add(this.txtTipPercentage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBillAmt);
            this.Controls.Add(this.label1);
            this.Name = "CalculateTip";
            this.Text = "Tip Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBillAmt;
        private System.Windows.Forms.TextBox txtTipPercentage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDecreaseTip;
        private System.Windows.Forms.Button btnIncreaseTip;
        private System.Windows.Forms.Button btnIncresePeople;
        private System.Windows.Forms.Button btnDecreasePeople;
        private System.Windows.Forms.TextBox txtNoOfPeople;
        private System.Windows.Forms.Label lblNoOfPeople;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalPerPerson;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTipPerPerson;
        private System.Windows.Forms.Label label5;
    }
}

