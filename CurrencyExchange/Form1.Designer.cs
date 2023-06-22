namespace CurrencyExchange
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
            this.comboBoxFrom = new System.Windows.Forms.ComboBox();
            this.comboBoxTo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.button2Confirm = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxHistory = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBoxFrom
            // 
            this.comboBoxFrom.FormattingEnabled = true;
            this.comboBoxFrom.Location = new System.Drawing.Point(148, 35);
            this.comboBoxFrom.Name = "comboBoxFrom";
            this.comboBoxFrom.Size = new System.Drawing.Size(100, 21);
            this.comboBoxFrom.TabIndex = 0;
            // 
            // comboBoxTo
            // 
            this.comboBoxTo.FormattingEnabled = true;
            this.comboBoxTo.Location = new System.Drawing.Point(272, 35);
            this.comboBoxTo.Name = "comboBoxTo";
            this.comboBoxTo.Size = new System.Drawing.Size(100, 21);
            this.comboBoxTo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "To";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(28, 35);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(100, 20);
            this.textBoxAmount.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Amount";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(509, 35);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(100, 23);
            this.buttonCalculate.TabIndex = 7;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Conversion Result";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(28, 97);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(457, 20);
            this.textBoxResult.TabIndex = 9;
            // 
            // button2Confirm
            // 
            this.button2Confirm.Location = new System.Drawing.Point(509, 95);
            this.button2Confirm.Name = "button2Confirm";
            this.button2Confirm.Size = new System.Drawing.Size(100, 23);
            this.button2Confirm.TabIndex = 10;
            this.button2Confirm.Text = "Confirm";
            this.button2Confirm.UseVisualStyleBackColor = true;
            this.button2Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Exchange History";
            // 
            // textBoxHistory
            // 
            this.textBoxHistory.Location = new System.Drawing.Point(28, 160);
            this.textBoxHistory.Multiline = true;
            this.textBoxHistory.Name = "textBoxHistory";
            this.textBoxHistory.ReadOnly = true;
            this.textBoxHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxHistory.Size = new System.Drawing.Size(581, 346);
            this.textBoxHistory.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 549);
            this.Controls.Add(this.textBoxHistory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2Confirm);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTo);
            this.Controls.Add(this.comboBoxFrom);
            this.Name = "Form1";
            this.Text = "CurrencyWizard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFrom;
        private System.Windows.Forms.ComboBox comboBoxTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button button2Confirm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxHistory;
    }
}

