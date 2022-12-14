namespace StateVendingMachine
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
            this.lblCredit = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblDrink = new System.Windows.Forms.Label();
            this.pcbCoin15 = new System.Windows.Forms.PictureBox();
            this.pcbCoin10 = new System.Windows.Forms.PictureBox();
            this.pcbCoin5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCoin15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCoin10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCoin5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCredit
            // 
            this.lblCredit.AutoSize = true;
            this.lblCredit.BackColor = System.Drawing.Color.Gold;
            this.lblCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredit.Location = new System.Drawing.Point(312, 96);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(116, 29);
            this.lblCredit.TabIndex = 2;
            this.lblCredit.Text = "Credit: 0¢";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.Location = new System.Drawing.Point(316, 337);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(0, 29);
            this.lblChange.TabIndex = 5;
            // 
            // lblDrink
            // 
            this.lblDrink.AutoSize = true;
            this.lblDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrink.Location = new System.Drawing.Point(316, 281);
            this.lblDrink.Name = "lblDrink";
            this.lblDrink.Size = new System.Drawing.Size(0, 29);
            this.lblDrink.TabIndex = 6;
            // 
            // pcbCoin15
            // 
            this.pcbCoin15.Image = global::StateVendingMachine.Properties.Resources.coin15;
            this.pcbCoin15.Location = new System.Drawing.Point(215, 3);
            this.pcbCoin15.Name = "pcbCoin15";
            this.pcbCoin15.Size = new System.Drawing.Size(100, 91);
            this.pcbCoin15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbCoin15.TabIndex = 9;
            this.pcbCoin15.TabStop = false;
            this.pcbCoin15.Tag = "15";
            this.pcbCoin15.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcbCoin_MouseDown);
            this.pcbCoin15.MouseEnter += new System.EventHandler(this.pcbCoin_MouseEnter);
            this.pcbCoin15.MouseLeave += new System.EventHandler(this.pcbCoin_MouseLeave);
            this.pcbCoin15.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pcbCoin_MouseUp);
            // 
            // pcbCoin10
            // 
            this.pcbCoin10.Image = global::StateVendingMachine.Properties.Resources.coin10;
            this.pcbCoin10.Location = new System.Drawing.Point(109, 3);
            this.pcbCoin10.Name = "pcbCoin10";
            this.pcbCoin10.Size = new System.Drawing.Size(100, 91);
            this.pcbCoin10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbCoin10.TabIndex = 8;
            this.pcbCoin10.TabStop = false;
            this.pcbCoin10.Tag = "10";
            this.pcbCoin10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcbCoin_MouseDown);
            this.pcbCoin10.MouseEnter += new System.EventHandler(this.pcbCoin_MouseEnter);
            this.pcbCoin10.MouseLeave += new System.EventHandler(this.pcbCoin_MouseLeave);
            this.pcbCoin10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pcbCoin_MouseUp);
            // 
            // pcbCoin5
            // 
            this.pcbCoin5.Image = global::StateVendingMachine.Properties.Resources.coin5;
            this.pcbCoin5.Location = new System.Drawing.Point(3, 3);
            this.pcbCoin5.Name = "pcbCoin5";
            this.pcbCoin5.Size = new System.Drawing.Size(100, 91);
            this.pcbCoin5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbCoin5.TabIndex = 7;
            this.pcbCoin5.TabStop = false;
            this.pcbCoin5.Tag = "5";
            this.pcbCoin5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcbCoin_MouseDown);
            this.pcbCoin5.MouseEnter += new System.EventHandler(this.pcbCoin_MouseEnter);
            this.pcbCoin5.MouseLeave += new System.EventHandler(this.pcbCoin_MouseLeave);
            this.pcbCoin5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pcbCoin_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.Image = global::StateVendingMachine.Properties.Resources.VendingMachine;
            this.pictureBox1.Location = new System.Drawing.Point(10, 49);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 358);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pcbCoin15);
            this.panel1.Controls.Add(this.pcbCoin5);
            this.panel1.Controls.Add(this.pcbCoin10);
            this.panel1.Location = new System.Drawing.Point(317, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 100);
            this.panel1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(774, 452);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDrink);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.lblCredit);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Vending Machine";
            ((System.ComponentModel.ISupportInitialize)(this.pcbCoin15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCoin10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCoin5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblDrink;
        private System.Windows.Forms.PictureBox pcbCoin5;
        private System.Windows.Forms.PictureBox pcbCoin10;
        private System.Windows.Forms.PictureBox pcbCoin15;
        private System.Windows.Forms.Panel panel1;
    }
}

