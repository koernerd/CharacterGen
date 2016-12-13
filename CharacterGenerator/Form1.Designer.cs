namespace CharacterGenerator
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
            this.strBox = new System.Windows.Forms.TextBox();
            this.strLabel = new System.Windows.Forms.Label();
            this.charRace = new System.Windows.Forms.ComboBox();
            this.charClass = new System.Windows.Forms.ComboBox();
            this.intLabel = new System.Windows.Forms.Label();
            this.intBox = new System.Windows.Forms.TextBox();
            this.wisLabel = new System.Windows.Forms.Label();
            this.wisBox = new System.Windows.Forms.TextBox();
            this.dexLabel = new System.Windows.Forms.Label();
            this.dexBox = new System.Windows.Forms.TextBox();
            this.conLabel = new System.Windows.Forms.Label();
            this.conBox = new System.Windows.Forms.TextBox();
            this.chrLabel = new System.Windows.Forms.Label();
            this.chrBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // strBox
            // 
            this.strBox.Location = new System.Drawing.Point(54, 79);
            this.strBox.Name = "strBox";
            this.strBox.Size = new System.Drawing.Size(35, 20);
            this.strBox.TabIndex = 0;
            // 
            // strLabel
            // 
            this.strLabel.AutoSize = true;
            this.strLabel.Location = new System.Drawing.Point(13, 82);
            this.strLabel.Name = "strLabel";
            this.strLabel.Size = new System.Drawing.Size(29, 13);
            this.strLabel.TabIndex = 1;
            this.strLabel.Text = "STR";
            this.strLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // charRace
            // 
            this.charRace.FormattingEnabled = true;
            this.charRace.Items.AddRange(new object[] {
            "Human",
            "Dwarf",
            "Elf",
            "Gnome",
            "Halfling"});
            this.charRace.Location = new System.Drawing.Point(298, 36);
            this.charRace.Name = "charRace";
            this.charRace.Size = new System.Drawing.Size(121, 21);
            this.charRace.TabIndex = 6;
            this.charRace.Text = "Race";
            this.charRace.SelectedIndexChanged += new System.EventHandler(this.charRace_SelectedIndexChanged);
            // 
            // charClass
            // 
            this.charClass.FormattingEnabled = true;
            this.charClass.Items.AddRange(new object[] {
            "Bard",
            "Cleric",
            "Druid",
            "Fighter",
            "Paladin",
            "Ranger",
            "Rogue",
            "Sorcerer",
            "Wizard"});
            this.charClass.Location = new System.Drawing.Point(171, 36);
            this.charClass.Name = "charClass";
            this.charClass.Size = new System.Drawing.Size(121, 21);
            this.charClass.Sorted = true;
            this.charClass.TabIndex = 8;
            this.charClass.Text = "Class";
            this.charClass.SelectedIndexChanged += new System.EventHandler(this.charClass_SelectedIndexChanged);
            // 
            // intLabel
            // 
            this.intLabel.AutoSize = true;
            this.intLabel.Location = new System.Drawing.Point(13, 109);
            this.intLabel.Name = "intLabel";
            this.intLabel.Size = new System.Drawing.Size(25, 13);
            this.intLabel.TabIndex = 10;
            this.intLabel.Text = "INT";
            // 
            // intBox
            // 
            this.intBox.Location = new System.Drawing.Point(54, 106);
            this.intBox.Name = "intBox";
            this.intBox.Size = new System.Drawing.Size(35, 20);
            this.intBox.TabIndex = 9;
            // 
            // wisLabel
            // 
            this.wisLabel.AutoSize = true;
            this.wisLabel.Location = new System.Drawing.Point(13, 136);
            this.wisLabel.Name = "wisLabel";
            this.wisLabel.Size = new System.Drawing.Size(28, 13);
            this.wisLabel.TabIndex = 12;
            this.wisLabel.Text = "WIS";
            // 
            // wisBox
            // 
            this.wisBox.Location = new System.Drawing.Point(54, 133);
            this.wisBox.Name = "wisBox";
            this.wisBox.Size = new System.Drawing.Size(35, 20);
            this.wisBox.TabIndex = 11;
            // 
            // dexLabel
            // 
            this.dexLabel.AutoSize = true;
            this.dexLabel.Location = new System.Drawing.Point(13, 163);
            this.dexLabel.Name = "dexLabel";
            this.dexLabel.Size = new System.Drawing.Size(29, 13);
            this.dexLabel.TabIndex = 14;
            this.dexLabel.Text = "DEX";
            // 
            // dexBox
            // 
            this.dexBox.Location = new System.Drawing.Point(54, 160);
            this.dexBox.Name = "dexBox";
            this.dexBox.Size = new System.Drawing.Size(35, 20);
            this.dexBox.TabIndex = 13;
            // 
            // conLabel
            // 
            this.conLabel.AutoSize = true;
            this.conLabel.Location = new System.Drawing.Point(13, 191);
            this.conLabel.Name = "conLabel";
            this.conLabel.Size = new System.Drawing.Size(30, 13);
            this.conLabel.TabIndex = 16;
            this.conLabel.Text = "CON";
            this.conLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // conBox
            // 
            this.conBox.Location = new System.Drawing.Point(54, 188);
            this.conBox.Name = "conBox";
            this.conBox.Size = new System.Drawing.Size(35, 20);
            this.conBox.TabIndex = 15;
            this.conBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // chrLabel
            // 
            this.chrLabel.AutoSize = true;
            this.chrLabel.Location = new System.Drawing.Point(13, 218);
            this.chrLabel.Name = "chrLabel";
            this.chrLabel.Size = new System.Drawing.Size(30, 13);
            this.chrLabel.TabIndex = 18;
            this.chrLabel.Text = "CHR";
            // 
            // chrBox
            // 
            this.chrBox.Location = new System.Drawing.Point(54, 215);
            this.chrBox.Name = "chrBox";
            this.chrBox.Size = new System.Drawing.Size(35, 20);
            this.chrBox.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 497);
            this.Controls.Add(this.chrLabel);
            this.Controls.Add(this.chrBox);
            this.Controls.Add(this.conLabel);
            this.Controls.Add(this.conBox);
            this.Controls.Add(this.dexLabel);
            this.Controls.Add(this.dexBox);
            this.Controls.Add(this.wisLabel);
            this.Controls.Add(this.wisBox);
            this.Controls.Add(this.intLabel);
            this.Controls.Add(this.intBox);
            this.Controls.Add(this.charClass);
            this.Controls.Add(this.charRace);
            this.Controls.Add(this.strLabel);
            this.Controls.Add(this.strBox);
            this.Name = "Form1";
            this.Text = "Character Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox strBox;
        private System.Windows.Forms.Label strLabel;
        private System.Windows.Forms.ComboBox charRace;
        private System.Windows.Forms.ComboBox charClass;
        private System.Windows.Forms.Label intLabel;
        private System.Windows.Forms.TextBox intBox;
        private System.Windows.Forms.Label wisLabel;
        private System.Windows.Forms.TextBox wisBox;
        private System.Windows.Forms.Label dexLabel;
        private System.Windows.Forms.TextBox dexBox;
        private System.Windows.Forms.Label conLabel;
        private System.Windows.Forms.TextBox conBox;
        private System.Windows.Forms.Label chrLabel;
        private System.Windows.Forms.TextBox chrBox;
    }
}

