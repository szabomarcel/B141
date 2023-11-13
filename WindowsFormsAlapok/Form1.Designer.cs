namespace WindowsFormsAlapok
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Forrasfajl = new System.Windows.Forms.TextBox();
            this.button_betoltes = new System.Windows.Forms.Button();
            this.listBox_Orszagok = new System.Windows.Forms.ListBox();
            this.button_terulet_atlag = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_szazezerfelett = new System.Windows.Forms.RadioButton();
            this.radioButton_legfeljebb_szazezer_meretu = new System.Windows.Forms.RadioButton();
            this.button_megszamolas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_eredmeny_fajl_neve = new System.Windows.Forms.TextBox();
            this.button_kiiratas = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_Min_Max_Kiirat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Orszag_bevitel = new System.Windows.Forms.TextBox();
            this.checkBox_Talalatok_listaban = new System.Windows.Forms.CheckBox();
            this.button_Kereses = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Forrés Fájl neve:";
            // 
            // textBox_Forrasfajl
            // 
            this.textBox_Forrasfajl.Location = new System.Drawing.Point(161, 41);
            this.textBox_Forrasfajl.Name = "textBox_Forrasfajl";
            this.textBox_Forrasfajl.Size = new System.Drawing.Size(128, 20);
            this.textBox_Forrasfajl.TabIndex = 2;
            // 
            // button_betoltes
            // 
            this.button_betoltes.Location = new System.Drawing.Point(161, 75);
            this.button_betoltes.Name = "button_betoltes";
            this.button_betoltes.Size = new System.Drawing.Size(128, 23);
            this.button_betoltes.TabIndex = 3;
            this.button_betoltes.Text = "Betöltés";
            this.button_betoltes.UseVisualStyleBackColor = true;
            this.button_betoltes.Click += new System.EventHandler(this.button_betoltes_Click);
            // 
            // listBox_Orszagok
            // 
            this.listBox_Orszagok.FormattingEnabled = true;
            this.listBox_Orszagok.Location = new System.Drawing.Point(161, 112);
            this.listBox_Orszagok.Name = "listBox_Orszagok";
            this.listBox_Orszagok.Size = new System.Drawing.Size(128, 238);
            this.listBox_Orszagok.TabIndex = 4;
            // 
            // button_terulet_atlag
            // 
            this.button_terulet_atlag.Location = new System.Drawing.Point(161, 364);
            this.button_terulet_atlag.Name = "button_terulet_atlag";
            this.button_terulet_atlag.Size = new System.Drawing.Size(128, 23);
            this.button_terulet_atlag.TabIndex = 3;
            this.button_terulet_atlag.Text = "Terület átlag";
            this.button_terulet_atlag.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_legfeljebb_szazezer_meretu);
            this.groupBox1.Controls.Add(this.radioButton_szazezerfelett);
            this.groupBox1.Location = new System.Drawing.Point(418, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mit számoljunk";
            // 
            // radioButton_szazezerfelett
            // 
            this.radioButton_szazezerfelett.AutoSize = true;
            this.radioButton_szazezerfelett.Location = new System.Drawing.Point(17, 20);
            this.radioButton_szazezerfelett.Name = "radioButton_szazezerfelett";
            this.radioButton_szazezerfelett.Size = new System.Drawing.Size(163, 17);
            this.radioButton_szazezerfelett.TabIndex = 0;
            this.radioButton_szazezerfelett.TabStop = true;
            this.radioButton_szazezerfelett.Text = "100 000-nél nagyobb területű";
            this.radioButton_szazezerfelett.UseVisualStyleBackColor = true;
            // 
            // radioButton_legfeljebb_szazezer_meretu
            // 
            this.radioButton_legfeljebb_szazezer_meretu.AutoSize = true;
            this.radioButton_legfeljebb_szazezer_meretu.Location = new System.Drawing.Point(17, 48);
            this.radioButton_legfeljebb_szazezer_meretu.Name = "radioButton_legfeljebb_szazezer_meretu";
            this.radioButton_legfeljebb_szazezer_meretu.Size = new System.Drawing.Size(151, 17);
            this.radioButton_legfeljebb_szazezer_meretu.TabIndex = 1;
            this.radioButton_legfeljebb_szazezer_meretu.TabStop = true;
            this.radioButton_legfeljebb_szazezer_meretu.Text = "Legfeljebb 100 000 méretű";
            this.radioButton_legfeljebb_szazezer_meretu.UseVisualStyleBackColor = true;
            // 
            // button_megszamolas
            // 
            this.button_megszamolas.Location = new System.Drawing.Point(418, 124);
            this.button_megszamolas.Name = "button_megszamolas";
            this.button_megszamolas.Size = new System.Drawing.Size(200, 23);
            this.button_megszamolas.TabIndex = 6;
            this.button_megszamolas.Text = "Megszámolás";
            this.button_megszamolas.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Eredmény fájl neve:";
            // 
            // textBox_eredmeny_fajl_neve
            // 
            this.textBox_eredmeny_fajl_neve.Location = new System.Drawing.Point(418, 176);
            this.textBox_eredmeny_fajl_neve.Name = "textBox_eredmeny_fajl_neve";
            this.textBox_eredmeny_fajl_neve.Size = new System.Drawing.Size(200, 20);
            this.textBox_eredmeny_fajl_neve.TabIndex = 8;
            // 
            // button_kiiratas
            // 
            this.button_kiiratas.Location = new System.Drawing.Point(418, 202);
            this.button_kiiratas.Name = "button_kiiratas";
            this.button_kiiratas.Size = new System.Drawing.Size(200, 23);
            this.button_kiiratas.TabIndex = 9;
            this.button_kiiratas.Text = "Kiíratás";
            this.button_kiiratas.UseVisualStyleBackColor = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(418, 238);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(111, 13);
            this.label.TabIndex = 10;
            this.label.Text = "Minimum és maximum:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Minimum",
            "Maximum"});
            this.comboBox1.Location = new System.Drawing.Point(418, 266);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // button_Min_Max_Kiirat
            // 
            this.button_Min_Max_Kiirat.Location = new System.Drawing.Point(418, 293);
            this.button_Min_Max_Kiirat.Name = "button_Min_Max_Kiirat";
            this.button_Min_Max_Kiirat.Size = new System.Drawing.Size(200, 23);
            this.button_Min_Max_Kiirat.TabIndex = 12;
            this.button_Min_Max_Kiirat.Text = "Minimum / Maximum kiíratás";
            this.button_Min_Max_Kiirat.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ország keresése:";
            // 
            // textBox_Orszag_bevitel
            // 
            this.textBox_Orszag_bevitel.Location = new System.Drawing.Point(418, 335);
            this.textBox_Orszag_bevitel.Name = "textBox_Orszag_bevitel";
            this.textBox_Orszag_bevitel.Size = new System.Drawing.Size(200, 20);
            this.textBox_Orszag_bevitel.TabIndex = 14;
            // 
            // checkBox_Talalatok_listaban
            // 
            this.checkBox_Talalatok_listaban.AutoSize = true;
            this.checkBox_Talalatok_listaban.Location = new System.Drawing.Point(418, 362);
            this.checkBox_Talalatok_listaban.Name = "checkBox_Talalatok_listaban";
            this.checkBox_Talalatok_listaban.Size = new System.Drawing.Size(164, 17);
            this.checkBox_Talalatok_listaban.TabIndex = 15;
            this.checkBox_Talalatok_listaban.Text = "Találatok kijelölése a listában";
            this.checkBox_Talalatok_listaban.UseVisualStyleBackColor = true;
            // 
            // button_Kereses
            // 
            this.button_Kereses.Location = new System.Drawing.Point(418, 385);
            this.button_Kereses.Name = "button_Kereses";
            this.button_Kereses.Size = new System.Drawing.Size(200, 23);
            this.button_Kereses.TabIndex = 16;
            this.button_Kereses.Text = "Keresés";
            this.button_Kereses.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Kereses);
            this.Controls.Add(this.checkBox_Talalatok_listaban);
            this.Controls.Add(this.textBox_Orszag_bevitel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_Min_Max_Kiirat);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.button_kiiratas);
            this.Controls.Add(this.textBox_eredmeny_fajl_neve);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_megszamolas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox_Orszagok);
            this.Controls.Add(this.button_terulet_atlag);
            this.Controls.Add(this.button_betoltes);
            this.Controls.Add(this.textBox_Forrasfajl);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Példa WindowsForms Alkalmzás";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Forrasfajl;
        private System.Windows.Forms.Button button_betoltes;
        private System.Windows.Forms.ListBox listBox_Orszagok;
        private System.Windows.Forms.Button button_terulet_atlag;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_legfeljebb_szazezer_meretu;
        private System.Windows.Forms.RadioButton radioButton_szazezerfelett;
        private System.Windows.Forms.Button button_megszamolas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_eredmeny_fajl_neve;
        private System.Windows.Forms.Button button_kiiratas;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_Min_Max_Kiirat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Orszag_bevitel;
        private System.Windows.Forms.CheckBox checkBox_Talalatok_listaban;
        private System.Windows.Forms.Button button_Kereses;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

