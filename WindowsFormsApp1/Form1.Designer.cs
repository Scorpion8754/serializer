namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fdataz = new System.Windows.Forms.TextBox();
            this.idataz = new System.Windows.Forms.TextBox();
            this.fdatalbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.serializeButton = new System.Windows.Forms.Button();
            this.deserializeButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cdataz = new System.Windows.Forms.TextBox();
            this.vecxz = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MIDz = new System.Windows.Forms.TextBox();
            this.flagdataz = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.OptionValz = new System.Windows.Forms.TextBox();
            this.OBitz = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Behaviorz = new System.Windows.Forms.TextBox();
            this.tagz = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.IDz = new System.Windows.Forms.TextBox();
            this.veczz = new System.Windows.Forms.TextBox();
            this.vecyz = new System.Windows.Forms.TextBox();
            this.SelectFileButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // fdataz
            // 
            this.fdataz.Location = new System.Drawing.Point(135, 6);
            this.fdataz.Name = "fdataz";
            this.fdataz.Size = new System.Drawing.Size(150, 20);
            this.fdataz.TabIndex = 0;
            // 
            // idataz
            // 
            this.idataz.Location = new System.Drawing.Point(135, 39);
            this.idataz.Name = "idataz";
            this.idataz.Size = new System.Drawing.Size(150, 20);
            this.idataz.TabIndex = 1;
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
            // serializeButton
            // 
            this.serializeButton.Location = new System.Drawing.Point(32, 443);
            this.serializeButton.Name = "serializeButton";
            this.serializeButton.Size = new System.Drawing.Size(75, 23);
            this.serializeButton.TabIndex = 11;
            this.serializeButton.Text = "Serialize";
            this.serializeButton.UseVisualStyleBackColor = true;
            this.serializeButton.Click += new System.EventHandler(this.SerializeButton_Click);
            // 
            // deserializeButton
            // 
            this.deserializeButton.Location = new System.Drawing.Point(210, 443);
            this.deserializeButton.Name = "deserializeButton";
            this.deserializeButton.Size = new System.Drawing.Size(75, 23);
            this.deserializeButton.TabIndex = 12;
            this.deserializeButton.Text = "Deserialize";
            this.deserializeButton.UseVisualStyleBackColor = true;
            this.deserializeButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Index:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(71, 405);
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
            // cdataz
            // 
            this.cdataz.Location = new System.Drawing.Point(135, 105);
            this.cdataz.Name = "cdataz";
            this.cdataz.Size = new System.Drawing.Size(150, 20);
            this.cdataz.TabIndex = 19;
            // 
            // vecxz
            // 
            this.vecxz.Location = new System.Drawing.Point(135, 72);
            this.vecxz.Name = "vecxz";
            this.vecxz.Size = new System.Drawing.Size(50, 20);
            this.vecxz.TabIndex = 18;
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
            // MIDz
            // 
            this.MIDz.Location = new System.Drawing.Point(135, 171);
            this.MIDz.Name = "MIDz";
            this.MIDz.Size = new System.Drawing.Size(150, 20);
            this.MIDz.TabIndex = 23;
            // 
            // flagdataz
            // 
            this.flagdataz.Location = new System.Drawing.Point(135, 138);
            this.flagdataz.Name = "flagdataz";
            this.flagdataz.Size = new System.Drawing.Size(150, 20);
            this.flagdataz.TabIndex = 22;
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
            // OptionValz
            // 
            this.OptionValz.Location = new System.Drawing.Point(135, 237);
            this.OptionValz.Name = "OptionValz";
            this.OptionValz.Size = new System.Drawing.Size(150, 20);
            this.OptionValz.TabIndex = 27;
            // 
            // OBitz
            // 
            this.OBitz.Location = new System.Drawing.Point(135, 204);
            this.OBitz.Name = "OBitz";
            this.OBitz.Size = new System.Drawing.Size(150, 20);
            this.OBitz.TabIndex = 26;
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
            // Behaviorz
            // 
            this.Behaviorz.Location = new System.Drawing.Point(135, 303);
            this.Behaviorz.Name = "Behaviorz";
            this.Behaviorz.Size = new System.Drawing.Size(150, 20);
            this.Behaviorz.TabIndex = 31;
            // 
            // tagz
            // 
            this.tagz.Location = new System.Drawing.Point(135, 270);
            this.tagz.Name = "tagz";
            this.tagz.Size = new System.Drawing.Size(150, 20);
            this.tagz.TabIndex = 30;
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
            // IDz
            // 
            this.IDz.Location = new System.Drawing.Point(135, 336);
            this.IDz.Name = "IDz";
            this.IDz.Size = new System.Drawing.Size(150, 20);
            this.IDz.TabIndex = 34;
            // 
            // veczz
            // 
            this.veczz.Location = new System.Drawing.Point(235, 72);
            this.veczz.Name = "veczz";
            this.veczz.Size = new System.Drawing.Size(50, 20);
            this.veczz.TabIndex = 36;
            // 
            // vecyz
            // 
            this.vecyz.Location = new System.Drawing.Point(185, 72);
            this.vecyz.Name = "vecyz";
            this.vecyz.Size = new System.Drawing.Size(50, 20);
            this.vecyz.TabIndex = 37;
            // 
            // SelectFileButton
            // 
            this.SelectFileButton.Location = new System.Drawing.Point(210, 402);
            this.SelectFileButton.Name = "SelectFileButton";
            this.SelectFileButton.Size = new System.Drawing.Size(75, 23);
            this.SelectFileButton.TabIndex = 38;
            this.SelectFileButton.Text = "Select File";
            this.SelectFileButton.UseVisualStyleBackColor = true;
            this.SelectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 478);
            this.Controls.Add(this.SelectFileButton);
            this.Controls.Add(this.vecyz);
            this.Controls.Add(this.veczz);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.IDz);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Behaviorz);
            this.Controls.Add(this.tagz);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.OptionValz);
            this.Controls.Add(this.OBitz);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MIDz);
            this.Controls.Add(this.flagdataz);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cdataz);
            this.Controls.Add(this.vecxz);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.deserializeButton);
            this.Controls.Add(this.serializeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fdatalbl);
            this.Controls.Add(this.idataz);
            this.Controls.Add(this.fdataz);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Serializer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fdataz;
        private System.Windows.Forms.TextBox idataz;
        private System.Windows.Forms.Label fdatalbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button serializeButton;
        private System.Windows.Forms.Button deserializeButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cdataz;
        private System.Windows.Forms.TextBox vecxz;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MIDz;
        private System.Windows.Forms.TextBox flagdataz;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox OptionValz;
        private System.Windows.Forms.TextBox OBitz;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Behaviorz;
        private System.Windows.Forms.TextBox tagz;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox IDz;
        private System.Windows.Forms.TextBox veczz;
        private System.Windows.Forms.TextBox vecyz;
        private System.Windows.Forms.Button SelectFileButton;
    }
}

