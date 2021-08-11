
namespace Gaming
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.egg3 = new System.Windows.Forms.PictureBox();
            this.egg2 = new System.Windows.Forms.PictureBox();
            this.egg1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.egg3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.egg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.egg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(720, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "catch";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(832, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(720, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "Miss";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(832, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // egg3
            // 
            this.egg3.Image = global::Gaming.Properties.Resources.Egg;
            this.egg3.Location = new System.Drawing.Point(316, 100);
            this.egg3.Name = "egg3";
            this.egg3.Size = new System.Drawing.Size(36, 50);
            this.egg3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.egg3.TabIndex = 3;
            this.egg3.TabStop = false;
            // 
            // egg2
            // 
            this.egg2.Image = global::Gaming.Properties.Resources.Egg;
            this.egg2.Location = new System.Drawing.Point(462, 222);
            this.egg2.Name = "egg2";
            this.egg2.Size = new System.Drawing.Size(36, 50);
            this.egg2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.egg2.TabIndex = 2;
            this.egg2.TabStop = false;
            // 
            // egg1
            // 
            this.egg1.Image = global::Gaming.Properties.Resources.Egg;
            this.egg1.Location = new System.Drawing.Point(169, 100);
            this.egg1.Name = "egg1";
            this.egg1.Size = new System.Drawing.Size(36, 50);
            this.egg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.egg1.TabIndex = 1;
            this.egg1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImage = global::Gaming.Properties.Resources.Basket;
            this.pictureBox1.Image = global::Gaming.Properties.Resources.Basket;
            this.pictureBox1.Location = new System.Drawing.Point(97, 458);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.BackColorChanged += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(961, 602);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.egg3);
            this.Controls.Add(this.egg2);
            this.Controls.Add(this.egg1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.egg3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.egg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.egg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox egg1;
        private System.Windows.Forms.PictureBox egg2;
        private System.Windows.Forms.PictureBox egg3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}

