namespace CK3DefinitionsTool
{
    partial class CK3DefinitionsApp
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
            this.SelectedEntry = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProvinceHierarchy = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.ColorPicker = new System.Windows.Forms.ColorDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.PrettyNameBox = new System.Windows.Forms.TextBox();
            this.InternalIDName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TitleLevel = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CapitalSelect = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CSVColor = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.IGTitleColor = new System.Windows.Forms.Button();
            this.ValidDeJureTitles = new System.Windows.Forms.CheckedListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TitleSaverButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.ProvinceID = new System.Windows.Forms.NumericUpDown();
            this.OutputCode = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.LandedTitlesButton = new System.Windows.Forms.Button();
            this.DefinitionsButton = new System.Windows.Forms.Button();
            this.LocalizationButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProvinceID)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectedEntry
            // 
            this.SelectedEntry.FormattingEnabled = true;
            this.SelectedEntry.Location = new System.Drawing.Point(15, 25);
            this.SelectedEntry.Name = "SelectedEntry";
            this.SelectedEntry.Size = new System.Drawing.Size(121, 21);
            this.SelectedEntry.TabIndex = 0;
            this.SelectedEntry.Text = "e_starting_tile";
            this.SelectedEntry.SelectedIndexChanged += new System.EventHandler(this.SelectedEntry_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Title";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ProvinceHierarchy
            // 
            this.ProvinceHierarchy.Location = new System.Drawing.Point(723, 25);
            this.ProvinceHierarchy.Name = "ProvinceHierarchy";
            this.ProvinceHierarchy.Size = new System.Drawing.Size(238, 279);
            this.ProvinceHierarchy.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(723, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Current Hierarchy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pretty Name";
            // 
            // PrettyNameBox
            // 
            this.PrettyNameBox.Location = new System.Drawing.Point(15, 70);
            this.PrettyNameBox.Name = "PrettyNameBox";
            this.PrettyNameBox.Size = new System.Drawing.Size(243, 20);
            this.PrettyNameBox.TabIndex = 5;
            // 
            // InternalIDName
            // 
            this.InternalIDName.Location = new System.Drawing.Point(15, 109);
            this.InternalIDName.Name = "InternalIDName";
            this.InternalIDName.Size = new System.Drawing.Size(243, 20);
            this.InternalIDName.TabIndex = 6;
            this.InternalIDName.Text = "e_starting_title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Internal ID Name";
            // 
            // TitleLevel
            // 
            this.TitleLevel.FormattingEnabled = true;
            this.TitleLevel.Items.AddRange(new object[] {
            "Empire",
            "Kingdom",
            "Duchy",
            "County",
            "Barony"});
            this.TitleLevel.Location = new System.Drawing.Point(15, 148);
            this.TitleLevel.Name = "TitleLevel";
            this.TitleLevel.Size = new System.Drawing.Size(121, 21);
            this.TitleLevel.TabIndex = 8;
            this.TitleLevel.Text = "Empire";
            this.TitleLevel.SelectedIndexChanged += new System.EventHandler(this.TitleLevel_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Title Level";
            // 
            // CapitalSelect
            // 
            this.CapitalSelect.Enabled = false;
            this.CapitalSelect.FormattingEnabled = true;
            this.CapitalSelect.Items.AddRange(new object[] {
            "c_cool_county",
            "c_lamer_county"});
            this.CapitalSelect.Location = new System.Drawing.Point(15, 188);
            this.CapitalSelect.Name = "CapitalSelect";
            this.CapitalSelect.Size = new System.Drawing.Size(121, 21);
            this.CapitalSelect.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Capital";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "CSV Color";
            // 
            // CSVColor
            // 
            this.CSVColor.BackColor = System.Drawing.Color.Blue;
            this.CSVColor.Enabled = false;
            this.CSVColor.Location = new System.Drawing.Point(15, 232);
            this.CSVColor.Name = "CSVColor";
            this.CSVColor.Size = new System.Drawing.Size(118, 23);
            this.CSVColor.TabIndex = 13;
            this.CSVColor.UseVisualStyleBackColor = false;
            this.CSVColor.Click += new System.EventHandler(this.CSVColor_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Title Color (In Game)";
            // 
            // IGTitleColor
            // 
            this.IGTitleColor.BackColor = System.Drawing.Color.Red;
            this.IGTitleColor.Location = new System.Drawing.Point(15, 281);
            this.IGTitleColor.Name = "IGTitleColor";
            this.IGTitleColor.Size = new System.Drawing.Size(118, 23);
            this.IGTitleColor.TabIndex = 15;
            this.IGTitleColor.UseVisualStyleBackColor = false;
            this.IGTitleColor.Click += new System.EventHandler(this.IGTitleColor_Click);
            // 
            // ValidDeJureTitles
            // 
            this.ValidDeJureTitles.Enabled = false;
            this.ValidDeJureTitles.FormattingEnabled = true;
            this.ValidDeJureTitles.Location = new System.Drawing.Point(143, 148);
            this.ValidDeJureTitles.Name = "ValidDeJureTitles";
            this.ValidDeJureTitles.ScrollAlwaysVisible = true;
            this.ValidDeJureTitles.Size = new System.Drawing.Size(218, 154);
            this.ValidDeJureTitles.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(143, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "De Jure Titles";
            // 
            // TitleSaverButton
            // 
            this.TitleSaverButton.Location = new System.Drawing.Point(142, 25);
            this.TitleSaverButton.Name = "TitleSaverButton";
            this.TitleSaverButton.Size = new System.Drawing.Size(116, 21);
            this.TitleSaverButton.TabIndex = 18;
            this.TitleSaverButton.Text = "New/Overwrite Title";
            this.TitleSaverButton.UseVisualStyleBackColor = true;
            this.TitleSaverButton.Click += new System.EventHandler(this.TitleSaverButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(262, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Province ID";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // ProvinceID
            // 
            this.ProvinceID.Enabled = false;
            this.ProvinceID.Location = new System.Drawing.Point(265, 25);
            this.ProvinceID.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.ProvinceID.Name = "ProvinceID";
            this.ProvinceID.Size = new System.Drawing.Size(120, 20);
            this.ProvinceID.TabIndex = 20;
            // 
            // OutputCode
            // 
            this.OutputCode.Location = new System.Drawing.Point(392, 25);
            this.OutputCode.Name = "OutputCode";
            this.OutputCode.ReadOnly = true;
            this.OutputCode.Size = new System.Drawing.Size(325, 277);
            this.OutputCode.TabIndex = 21;
            this.OutputCode.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(389, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Generated Text";
            // 
            // LandedTitlesButton
            // 
            this.LandedTitlesButton.Location = new System.Drawing.Point(270, 51);
            this.LandedTitlesButton.Name = "LandedTitlesButton";
            this.LandedTitlesButton.Size = new System.Drawing.Size(116, 21);
            this.LandedTitlesButton.TabIndex = 23;
            this.LandedTitlesButton.Text = "Generate Titles";
            this.LandedTitlesButton.UseVisualStyleBackColor = true;
            this.LandedTitlesButton.Click += new System.EventHandler(this.LandedTitlesButton_Click);
            // 
            // DefinitionsButton
            // 
            this.DefinitionsButton.Location = new System.Drawing.Point(270, 78);
            this.DefinitionsButton.Name = "DefinitionsButton";
            this.DefinitionsButton.Size = new System.Drawing.Size(116, 21);
            this.DefinitionsButton.TabIndex = 24;
            this.DefinitionsButton.Text = "Generate Definitions";
            this.DefinitionsButton.UseVisualStyleBackColor = true;
            this.DefinitionsButton.Click += new System.EventHandler(this.DefinitionsButton_Click);
            // 
            // LocalizationButton
            // 
            this.LocalizationButton.Location = new System.Drawing.Point(270, 105);
            this.LocalizationButton.Name = "LocalizationButton";
            this.LocalizationButton.Size = new System.Drawing.Size(116, 21);
            this.LocalizationButton.TabIndex = 25;
            this.LocalizationButton.Text = "Generate Localiz.";
            this.LocalizationButton.UseVisualStyleBackColor = true;
            this.LocalizationButton.Click += new System.EventHandler(this.LocalizationButton_Click);
            // 
            // CK3DefinitionsApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 316);
            this.Controls.Add(this.LocalizationButton);
            this.Controls.Add(this.DefinitionsButton);
            this.Controls.Add(this.LandedTitlesButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.OutputCode);
            this.Controls.Add(this.ProvinceID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TitleSaverButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ValidDeJureTitles);
            this.Controls.Add(this.IGTitleColor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CSVColor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CapitalSelect);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TitleLevel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.InternalIDName);
            this.Controls.Add(this.PrettyNameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProvinceHierarchy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectedEntry);
            this.Name = "CK3DefinitionsApp";
            this.Text = "CK3 Definitions Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProvinceID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SelectedEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView ProvinceHierarchy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog ColorPicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PrettyNameBox;
        private System.Windows.Forms.TextBox InternalIDName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox TitleLevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CapitalSelect;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button CSVColor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button IGTitleColor;
        private System.Windows.Forms.CheckedListBox ValidDeJureTitles;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button TitleSaverButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown ProvinceID;
        private System.Windows.Forms.RichTextBox OutputCode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button LandedTitlesButton;
        private System.Windows.Forms.Button DefinitionsButton;
        private System.Windows.Forms.Button LocalizationButton;
    }
}

