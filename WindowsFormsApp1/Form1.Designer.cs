﻿namespace WindowsFormsApp1
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
            this.fdata = new System.Windows.Forms.TextBox();
            this.idata = new System.Windows.Forms.TextBox();
            this.fdatalbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cdata = new System.Windows.Forms.TextBox();
            this.vecx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MID = new System.Windows.Forms.TextBox();
            this.flagdata = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.OptionVals = new System.Windows.Forms.TextBox();
            this.OBits = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Behavior = new System.Windows.Forms.TextBox();
            this.tag = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.vecz = new System.Windows.Forms.TextBox();
            this.vecy = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // fdata
            // 
            this.fdata.Location = new System.Drawing.Point(135, 6);
            this.fdata.Name = "fdata";
            this.fdata.Size = new System.Drawing.Size(150, 20);
            this.fdata.TabIndex = 0;
            // 
            // idata
            // 
            this.idata.Location = new System.Drawing.Point(135, 39);
            this.idata.Name = "idata";
            this.idata.Size = new System.Drawing.Size(150, 20);
            this.idata.TabIndex = 1;
            // 
            // fdatalbl
            // 
            this.fdatalbl.AutoSize = true;
            this.fdatalbl.Location = new System.Drawing.Point(29, 9);
            this.fdatalbl.Name = "fdatalbl";
            this.fdatalbl.Size = new System.Drawing.Size(31, 13);
            this.fdatalbl.TabIndex = 6;
            this.fdatalbl.Text = "fdata";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "idata";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Serialize";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(210, 443);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Deserialize";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Index:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(210, 406);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(71, 410);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(36, 20);
            this.numericUpDown1.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "cdata";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "f_vec";
            // 
            // cdata
            // 
            this.cdata.Location = new System.Drawing.Point(135, 105);
            this.cdata.Name = "cdata";
            this.cdata.Size = new System.Drawing.Size(150, 20);
            this.cdata.TabIndex = 19;
            // 
            // vecx
            // 
            this.vecx.Location = new System.Drawing.Point(135, 72);
            this.vecx.Name = "vecx";
            this.vecx.Size = new System.Drawing.Size(50, 20);
            this.vecx.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "MID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "flagdata";
            // 
            // MID
            // 
            this.MID.Location = new System.Drawing.Point(135, 171);
            this.MID.Name = "MID";
            this.MID.Size = new System.Drawing.Size(150, 20);
            this.MID.TabIndex = 23;
            // 
            // flagdata
            // 
            this.flagdata.Location = new System.Drawing.Point(135, 138);
            this.flagdata.Name = "flagdata";
            this.flagdata.Size = new System.Drawing.Size(150, 20);
            this.flagdata.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "OptionVals";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "OptionBits";
            // 
            // OptionVals
            // 
            this.OptionVals.Location = new System.Drawing.Point(135, 237);
            this.OptionVals.Name = "OptionVals";
            this.OptionVals.Size = new System.Drawing.Size(150, 20);
            this.OptionVals.TabIndex = 27;
            // 
            // OBits
            // 
            this.OBits.Location = new System.Drawing.Point(135, 204);
            this.OBits.Name = "OBits";
            this.OBits.Size = new System.Drawing.Size(150, 20);
            this.OBits.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 306);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Behavior";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 273);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "tag";
            // 
            // Behavior
            // 
            this.Behavior.Location = new System.Drawing.Point(135, 303);
            this.Behavior.Name = "Behavior";
            this.Behavior.Size = new System.Drawing.Size(150, 20);
            this.Behavior.TabIndex = 31;
            // 
            // tag
            // 
            this.tag.Location = new System.Drawing.Point(135, 270);
            this.tag.Name = "tag";
            this.tag.Size = new System.Drawing.Size(150, 20);
            this.tag.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(29, 339);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "ID";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(135, 336);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(150, 20);
            this.ID.TabIndex = 34;
            // 
            // vecz
            // 
            this.vecz.Location = new System.Drawing.Point(235, 72);
            this.vecz.Name = "vecz";
            this.vecz.Size = new System.Drawing.Size(50, 20);
            this.vecz.TabIndex = 36;
            // 
            // vecy
            // 
            this.vecy.Location = new System.Drawing.Point(185, 72);
            this.vecy.Name = "vecy";
            this.vecy.Size = new System.Drawing.Size(50, 20);
            this.vecy.TabIndex = 37;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 478);
            this.Controls.Add(this.vecy);
            this.Controls.Add(this.vecz);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Behavior);
            this.Controls.Add(this.tag);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.OptionVals);
            this.Controls.Add(this.OBits);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MID);
            this.Controls.Add(this.flagdata);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cdata);
            this.Controls.Add(this.vecx);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fdatalbl);
            this.Controls.Add(this.idata);
            this.Controls.Add(this.fdata);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fdata;
        private System.Windows.Forms.TextBox idata;
        private System.Windows.Forms.Label fdatalbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cdata;
        private System.Windows.Forms.TextBox vecx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MID;
        private System.Windows.Forms.TextBox flagdata;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox OptionVals;
        private System.Windows.Forms.TextBox OBits;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Behavior;
        private System.Windows.Forms.TextBox tag;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox vecz;
        private System.Windows.Forms.TextBox vecy;
    }
}

