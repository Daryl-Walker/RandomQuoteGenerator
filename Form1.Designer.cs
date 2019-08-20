namespace RandomQuoteGenerator
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
            this.Pastquoteselector = new System.Windows.Forms.MonthCalendar();
            this.Quotebox = new System.Windows.Forms.RichTextBox();
            this.Authorbox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Pastquoteselector
            // 
            this.Pastquoteselector.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pastquoteselector.Location = new System.Drawing.Point(489, 30);
            this.Pastquoteselector.Name = "Pastquoteselector";
            this.Pastquoteselector.TabIndex = 0;
            // 
            // Quotebox
            // 
            this.Quotebox.Location = new System.Drawing.Point(25, 30);
            this.Quotebox.Name = "Quotebox";
            this.Quotebox.Size = new System.Drawing.Size(452, 130);
            this.Quotebox.TabIndex = 3;
            this.Quotebox.Text = "";
            // 
            // Authorbox
            // 
            this.Authorbox.Location = new System.Drawing.Point(240, 166);
            this.Authorbox.Name = "Authorbox";
            this.Authorbox.Size = new System.Drawing.Size(236, 70);
            this.Authorbox.TabIndex = 4;
            this.Authorbox.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Old English Text MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(25, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 69);
            this.button1.TabIndex = 5;
            this.button1.Text = "Next Quote";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Old English Text MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(132, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 69);
            this.button2.TabIndex = 6;
            this.button2.Text = "Prev Quote";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.BackgroundImage = global::RandomQuoteGenerator.Properties.Resources.AdobeStock_159699127;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(820, 283);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Authorbox);
            this.Controls.Add(this.Quotebox);
            this.Controls.Add(this.Pastquoteselector);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random Quote Generator";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar Pastquoteselector;
        private System.Windows.Forms.RichTextBox Quotebox;
        private System.Windows.Forms.RichTextBox Authorbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

