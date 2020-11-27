namespace Lab3
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
            this.SHA256TextBox = new System.Windows.Forms.TextBox();
            this.DomenTextBox = new System.Windows.Forms.TextBox();
            this.KHATextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.DoEncryptButton = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ReadBlockTimeLabel = new System.Windows.Forms.Label();
            this.KHATimeLabel = new System.Windows.Forms.Label();
            this.TotalTimeLabel = new System.Windows.Forms.Label();
            this.SHA256TimeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SHA256TextBox
            // 
            this.SHA256TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SHA256TextBox.Location = new System.Drawing.Point(12, 356);
            this.SHA256TextBox.Multiline = true;
            this.SHA256TextBox.Name = "SHA256TextBox";
            this.SHA256TextBox.ReadOnly = true;
            this.SHA256TextBox.Size = new System.Drawing.Size(1019, 318);
            this.SHA256TextBox.TabIndex = 0;
            // 
            // DomenTextBox
            // 
            this.DomenTextBox.Location = new System.Drawing.Point(12, 40);
            this.DomenTextBox.Name = "DomenTextBox";
            this.DomenTextBox.Size = new System.Drawing.Size(267, 22);
            this.DomenTextBox.TabIndex = 1;
            this.DomenTextBox.Text = "https://norvig.com/big.txt";
            // 
            // KHATextBox
            // 
            this.KHATextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KHATextBox.Location = new System.Drawing.Point(286, 40);
            this.KHATextBox.Multiline = true;
            this.KHATextBox.Name = "KHATextBox";
            this.KHATextBox.ReadOnly = true;
            this.KHATextBox.Size = new System.Drawing.Size(746, 290);
            this.KHATextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Domen";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label10.Location = new System.Drawing.Point(12, 333);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(71, 20);
            this.Label10.TabIndex = 5;
            this.Label10.Text = "SHA256";
            // 
            // DoEncryptButton
            // 
            this.DoEncryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoEncryptButton.Location = new System.Drawing.Point(12, 279);
            this.DoEncryptButton.Name = "DoEncryptButton";
            this.DoEncryptButton.Size = new System.Drawing.Size(267, 51);
            this.DoEncryptButton.TabIndex = 15;
            this.DoEncryptButton.Text = "Encrypt";
            this.DoEncryptButton.UseVisualStyleBackColor = true;
            this.DoEncryptButton.Click += new System.EventHandler(this.DoEncryptButton_Click);
            // 
            // Label3
            // 
            this.Label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label3.Location = new System.Drawing.Point(282, 17);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(44, 20);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "KHA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Read Block = ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "KHA =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "SHA256 =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Total time = ";
            // 
            // ReadBlockTimeLabel
            // 
            this.ReadBlockTimeLabel.AutoSize = true;
            this.ReadBlockTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReadBlockTimeLabel.Location = new System.Drawing.Point(119, 105);
            this.ReadBlockTimeLabel.Name = "ReadBlockTimeLabel";
            this.ReadBlockTimeLabel.Size = new System.Drawing.Size(18, 20);
            this.ReadBlockTimeLabel.TabIndex = 20;
            this.ReadBlockTimeLabel.Text = "0";
            // 
            // KHATimeLabel
            // 
            this.KHATimeLabel.AutoSize = true;
            this.KHATimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KHATimeLabel.Location = new System.Drawing.Point(65, 138);
            this.KHATimeLabel.Name = "KHATimeLabel";
            this.KHATimeLabel.Size = new System.Drawing.Size(18, 20);
            this.KHATimeLabel.TabIndex = 21;
            this.KHATimeLabel.Text = "0";
            // 
            // TotalTimeLabel
            // 
            this.TotalTimeLabel.AutoSize = true;
            this.TotalTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalTimeLabel.Location = new System.Drawing.Point(109, 205);
            this.TotalTimeLabel.Name = "TotalTimeLabel";
            this.TotalTimeLabel.Size = new System.Drawing.Size(18, 20);
            this.TotalTimeLabel.TabIndex = 22;
            this.TotalTimeLabel.Text = "0";
            // 
            // SHA256TimeLabel
            // 
            this.SHA256TimeLabel.AutoSize = true;
            this.SHA256TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SHA256TimeLabel.Location = new System.Drawing.Point(97, 172);
            this.SHA256TimeLabel.Name = "SHA256TimeLabel";
            this.SHA256TimeLabel.Size = new System.Drawing.Size(18, 20);
            this.SHA256TimeLabel.TabIndex = 23;
            this.SHA256TimeLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 686);
            this.Controls.Add(this.SHA256TimeLabel);
            this.Controls.Add(this.TotalTimeLabel);
            this.Controls.Add(this.KHATimeLabel);
            this.Controls.Add(this.ReadBlockTimeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DoEncryptButton);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KHATextBox);
            this.Controls.Add(this.DomenTextBox);
            this.Controls.Add(this.SHA256TextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SHA256TextBox;
        private System.Windows.Forms.TextBox DomenTextBox;
        private System.Windows.Forms.TextBox KHATextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.Button DoEncryptButton;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ReadBlockTimeLabel;
        private System.Windows.Forms.Label KHATimeLabel;
        private System.Windows.Forms.Label TotalTimeLabel;
        private System.Windows.Forms.Label SHA256TimeLabel;
    }
}

