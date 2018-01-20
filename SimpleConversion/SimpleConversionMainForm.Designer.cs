namespace SimpleConversion
{
    partial class SimpleConversionMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resourceing used.
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
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DistanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TemperatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DistanceMainMenu = new System.Windows.Forms.Button();
            this.MassMainMenu = new System.Windows.Forms.Button();
            this.TemperatureMainMenu = new System.Windows.Forms.Button();
            this.TimeMainMenu = new System.Windows.Forms.Button();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.UserInputTextBox = new System.Windows.Forms.TextBox();
            this.InitialUnitsComboBox = new System.Windows.Forms.ComboBox();
            this.FromLabel = new System.Windows.Forms.Label();
            this.ToLabel = new System.Windows.Forms.Label();
            this.ResultingUnitsComboBox = new System.Windows.Forms.ComboBox();
            this.InstructionLabel = new System.Windows.Forms.Label();
            this.ValueOfLabel = new System.Windows.Forms.Label();
            this.ConvertSubmissionButton = new System.Windows.Forms.Button();
            this.InitialValueLabel = new System.Windows.Forms.Label();
            this.EqualsLabel = new System.Windows.Forms.Label();
            this.InitialUnitsLabel = new System.Windows.Forms.Label();
            this.ResultingValueLabel = new System.Windows.Forms.Label();
            this.ResultingUnitsLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.BackButtonLabel = new System.Windows.Forms.Label();
            this.DividerLabel = new System.Windows.Forms.Label();
            this.clearFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.DistanceToolStripMenuItem,
            this.MassToolStripMenuItem,
            this.TimeToolStripMenuItem,
            this.TemperatureToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(407, 24);
            this.MenuStrip1.TabIndex = 0;
            this.MenuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.clearFormToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.FileToolStripMenuItem.Text = "&File";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.mainMenuToolStripMenuItem.Text = "&Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.MainMenuToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // DistanceToolStripMenuItem
            // 
            this.DistanceToolStripMenuItem.Name = "DistanceToolStripMenuItem";
            this.DistanceToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.DistanceToolStripMenuItem.Text = "&Distance";
            this.DistanceToolStripMenuItem.Click += new System.EventHandler(this.DistanceToolStripMenuItem_Click);
            // 
            // MassToolStripMenuItem
            // 
            this.MassToolStripMenuItem.Name = "MassToolStripMenuItem";
            this.MassToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.MassToolStripMenuItem.Text = "&Mass";
            this.MassToolStripMenuItem.Click += new System.EventHandler(this.MassToolStripMenuItem_Click);
            // 
            // TimeToolStripMenuItem
            // 
            this.TimeToolStripMenuItem.Name = "TimeToolStripMenuItem";
            this.TimeToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.TimeToolStripMenuItem.Text = "&Time";
            this.TimeToolStripMenuItem.Click += new System.EventHandler(this.TimeToolStripMenuItem_Click);
            // 
            // TemperatureToolStripMenuItem
            // 
            this.TemperatureToolStripMenuItem.Name = "TemperatureToolStripMenuItem";
            this.TemperatureToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.TemperatureToolStripMenuItem.Text = "T&emperature";
            this.TemperatureToolStripMenuItem.Click += new System.EventHandler(this.TemperatureToolStripMenuItem_Click);
            // 
            // DistanceMainMenu
            // 
            this.DistanceMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DistanceMainMenu.Location = new System.Drawing.Point(0, 27);
            this.DistanceMainMenu.Name = "DistanceMainMenu";
            this.DistanceMainMenu.Size = new System.Drawing.Size(200, 200);
            this.DistanceMainMenu.TabIndex = 1;
            this.DistanceMainMenu.Text = "Distance";
            this.DistanceMainMenu.UseVisualStyleBackColor = true;
            this.DistanceMainMenu.Click += new System.EventHandler(this.DistanceMainMenu_Click);
            // 
            // MassMainMenu
            // 
            this.MassMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MassMainMenu.Location = new System.Drawing.Point(206, 27);
            this.MassMainMenu.Name = "MassMainMenu";
            this.MassMainMenu.Size = new System.Drawing.Size(200, 200);
            this.MassMainMenu.TabIndex = 2;
            this.MassMainMenu.Text = "Mass";
            this.MassMainMenu.UseVisualStyleBackColor = true;
            this.MassMainMenu.Click += new System.EventHandler(this.MassMainMenu_Click);
            // 
            // TemperatureMainMenu
            // 
            this.TemperatureMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemperatureMainMenu.Location = new System.Drawing.Point(206, 233);
            this.TemperatureMainMenu.Name = "TemperatureMainMenu";
            this.TemperatureMainMenu.Size = new System.Drawing.Size(200, 200);
            this.TemperatureMainMenu.TabIndex = 3;
            this.TemperatureMainMenu.Text = "Temperature";
            this.TemperatureMainMenu.UseVisualStyleBackColor = true;
            this.TemperatureMainMenu.Click += new System.EventHandler(this.TemperatureMainMenu_Click);
            // 
            // TimeMainMenu
            // 
            this.TimeMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeMainMenu.Location = new System.Drawing.Point(0, 233);
            this.TimeMainMenu.Name = "TimeMainMenu";
            this.TimeMainMenu.Size = new System.Drawing.Size(200, 200);
            this.TimeMainMenu.TabIndex = 4;
            this.TimeMainMenu.Text = "Time";
            this.TimeMainMenu.UseVisualStyleBackColor = true;
            this.TimeMainMenu.Click += new System.EventHandler(this.TimeMainMenu_Click);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.BackColor = System.Drawing.Color.Gainsboro;
            this.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Items.AddRange(new object[] {
            "Distance",
            "Mass",
            "Time",
            "Temperature"});
            this.CategoryComboBox.Location = new System.Drawing.Point(143, 64);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(181, 39);
            this.CategoryComboBox.TabIndex = 5;
            this.CategoryComboBox.Visible = false;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryLabel.Location = new System.Drawing.Point(4, 64);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(133, 31);
            this.CategoryLabel.TabIndex = 6;
            this.CategoryLabel.Text = "Category";
            this.CategoryLabel.Visible = false;
            // 
            // UserInputTextBox
            // 
            this.UserInputTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UserInputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserInputTextBox.Location = new System.Drawing.Point(169, 165);
            this.UserInputTextBox.Name = "UserInputTextBox";
            this.UserInputTextBox.Size = new System.Drawing.Size(218, 30);
            this.UserInputTextBox.TabIndex = 7;
            this.UserInputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UserInputTextBox.Visible = false;
            this.UserInputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserInputTextBox_KeyDown);
            // 
            // InitialUnitsComboBox
            // 
            this.InitialUnitsComboBox.BackColor = System.Drawing.Color.Gainsboro;
            this.InitialUnitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InitialUnitsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InitialUnitsComboBox.FormattingEnabled = true;
            this.InitialUnitsComboBox.Location = new System.Drawing.Point(97, 210);
            this.InitialUnitsComboBox.Name = "InitialUnitsComboBox";
            this.InitialUnitsComboBox.Size = new System.Drawing.Size(121, 33);
            this.InitialUnitsComboBox.TabIndex = 8;
            this.InitialUnitsComboBox.Visible = false;
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromLabel.Location = new System.Drawing.Point(37, 213);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(54, 25);
            this.FromLabel.TabIndex = 9;
            this.FromLabel.Text = "from";
            this.FromLabel.Visible = false;
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToLabel.Location = new System.Drawing.Point(230, 213);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(30, 25);
            this.ToLabel.TabIndex = 10;
            this.ToLabel.Text = "to";
            this.ToLabel.Visible = false;
            // 
            // ResultingUnitsComboBox
            // 
            this.ResultingUnitsComboBox.BackColor = System.Drawing.Color.Gainsboro;
            this.ResultingUnitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ResultingUnitsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultingUnitsComboBox.FormattingEnabled = true;
            this.ResultingUnitsComboBox.Location = new System.Drawing.Point(266, 210);
            this.ResultingUnitsComboBox.Name = "ResultingUnitsComboBox";
            this.ResultingUnitsComboBox.Size = new System.Drawing.Size(121, 33);
            this.ResultingUnitsComboBox.TabIndex = 11;
            this.ResultingUnitsComboBox.Visible = false;
            // 
            // InstructionLabel
            // 
            this.InstructionLabel.AutoSize = true;
            this.InstructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionLabel.Location = new System.Drawing.Point(12, 106);
            this.InstructionLabel.Name = "InstructionLabel";
            this.InstructionLabel.Size = new System.Drawing.Size(294, 38);
            this.InstructionLabel.TabIndex = 12;
            this.InstructionLabel.Text = "I am converting ...";
            this.InstructionLabel.Visible = false;
            // 
            // ValueOfLabel
            // 
            this.ValueOfLabel.AutoSize = true;
            this.ValueOfLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueOfLabel.Location = new System.Drawing.Point(22, 165);
            this.ValueOfLabel.Name = "ValueOfLabel";
            this.ValueOfLabel.Size = new System.Drawing.Size(132, 25);
            this.ValueOfLabel.TabIndex = 13;
            this.ValueOfLabel.Text = "The value of";
            this.ValueOfLabel.Visible = false;
            // 
            // ConvertSubmissionButton
            // 
            this.ConvertSubmissionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertSubmissionButton.Location = new System.Drawing.Point(229, 249);
            this.ConvertSubmissionButton.Name = "ConvertSubmissionButton";
            this.ConvertSubmissionButton.Size = new System.Drawing.Size(158, 39);
            this.ConvertSubmissionButton.TabIndex = 14;
            this.ConvertSubmissionButton.Text = "Convert";
            this.ConvertSubmissionButton.UseVisualStyleBackColor = true;
            this.ConvertSubmissionButton.Visible = false;
            this.ConvertSubmissionButton.Click += new System.EventHandler(this.ConvertSubmissionButton_Click);
            // 
            // InitialValueLabel
            // 
            this.InitialValueLabel.AutoSize = true;
            this.InitialValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InitialValueLabel.Location = new System.Drawing.Point(15, 325);
            this.InitialValueLabel.Name = "InitialValueLabel";
            this.InitialValueLabel.Size = new System.Drawing.Size(91, 20);
            this.InitialValueLabel.TabIndex = 15;
            this.InitialValueLabel.Text = "Initial Value";
            this.InitialValueLabel.Visible = false;
            // 
            // EqualsLabel
            // 
            this.EqualsLabel.AutoSize = true;
            this.EqualsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqualsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.EqualsLabel.Location = new System.Drawing.Point(5, 354);
            this.EqualsLabel.Name = "EqualsLabel";
            this.EqualsLabel.Size = new System.Drawing.Size(393, 25);
            this.EqualsLabel.TabIndex = 16;
            this.EqualsLabel.Text = "---------------  is equal to...  ---------------";
            this.EqualsLabel.Visible = false;
            // 
            // InitialUnitsLabel
            // 
            this.InitialUnitsLabel.AutoSize = true;
            this.InitialUnitsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InitialUnitsLabel.Location = new System.Drawing.Point(308, 325);
            this.InitialUnitsLabel.Name = "InitialUnitsLabel";
            this.InitialUnitsLabel.Size = new System.Drawing.Size(87, 20);
            this.InitialUnitsLabel.TabIndex = 17;
            this.InitialUnitsLabel.Text = "Initial Units";
            this.InitialUnitsLabel.Visible = false;
            // 
            // ResultingValueLabel
            // 
            this.ResultingValueLabel.AutoSize = true;
            this.ResultingValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultingValueLabel.Location = new System.Drawing.Point(15, 390);
            this.ResultingValueLabel.Name = "ResultingValueLabel";
            this.ResultingValueLabel.Size = new System.Drawing.Size(121, 20);
            this.ResultingValueLabel.TabIndex = 18;
            this.ResultingValueLabel.Text = "Resulting Value";
            this.ResultingValueLabel.Visible = false;
            // 
            // ResultingUnitsLabel
            // 
            this.ResultingUnitsLabel.AutoSize = true;
            this.ResultingUnitsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultingUnitsLabel.Location = new System.Drawing.Point(308, 390);
            this.ResultingUnitsLabel.Name = "ResultingUnitsLabel";
            this.ResultingUnitsLabel.Size = new System.Drawing.Size(117, 20);
            this.ResultingUnitsLabel.TabIndex = 19;
            this.ResultingUnitsLabel.Text = "Resulting Units";
            this.ResultingUnitsLabel.Visible = false;
            // 
            // BackButton
            // 
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("MT Extra", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.BackButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackButton.Location = new System.Drawing.Point(0, 27);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(34, 34);
            this.BackButton.TabIndex = 20;
            this.BackButton.Text = "<-";
            this.BackButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Visible = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // BackButtonLabel
            // 
            this.BackButtonLabel.AutoSize = true;
            this.BackButtonLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackButtonLabel.Location = new System.Drawing.Point(24, 39);
            this.BackButtonLabel.Name = "BackButtonLabel";
            this.BackButtonLabel.Size = new System.Drawing.Size(32, 13);
            this.BackButtonLabel.TabIndex = 21;
            this.BackButtonLabel.Text = "Back";
            this.BackButtonLabel.Visible = false;
            // 
            // DividerLabel
            // 
            this.DividerLabel.AutoSize = true;
            this.DividerLabel.Location = new System.Drawing.Point(-3, 291);
            this.DividerLabel.Name = "DividerLabel";
            this.DividerLabel.Size = new System.Drawing.Size(427, 13);
            this.DividerLabel.TabIndex = 22;
            this.DividerLabel.Text = "______________________________________________________________________";
            this.DividerLabel.Visible = false;
            // 
            // clearFormToolStripMenuItem
            // 
            this.clearFormToolStripMenuItem.Name = "clearFormToolStripMenuItem";
            this.clearFormToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clearFormToolStripMenuItem.Text = "&Clear Form";
            this.clearFormToolStripMenuItem.Click += new System.EventHandler(this.ClearFormToolStripMenuItem_Click);
            // 
            // SimpleConversionMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 434);
            this.Controls.Add(this.DividerLabel);
            this.Controls.Add(this.BackButtonLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ResultingUnitsLabel);
            this.Controls.Add(this.ResultingValueLabel);
            this.Controls.Add(this.InitialUnitsLabel);
            this.Controls.Add(this.EqualsLabel);
            this.Controls.Add(this.InitialValueLabel);
            this.Controls.Add(this.ConvertSubmissionButton);
            this.Controls.Add(this.ValueOfLabel);
            this.Controls.Add(this.InstructionLabel);
            this.Controls.Add(this.ResultingUnitsComboBox);
            this.Controls.Add(this.ToLabel);
            this.Controls.Add(this.FromLabel);
            this.Controls.Add(this.InitialUnitsComboBox);
            this.Controls.Add(this.UserInputTextBox);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.TimeMainMenu);
            this.Controls.Add(this.TemperatureMainMenu);
            this.Controls.Add(this.MassMainMenu);
            this.Controls.Add(this.DistanceMainMenu);
            this.Controls.Add(this.MenuStrip1);
            this.MainMenuStrip = this.MenuStrip1;
            this.Name = "SimpleConversionMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Conversion";
            this.Load += new System.EventHandler(this.SimpleConversionMainForm_Load);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DistanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TemperatureToolStripMenuItem;
        private System.Windows.Forms.Button DistanceMainMenu;
        private System.Windows.Forms.Button MassMainMenu;
        private System.Windows.Forms.Button TemperatureMainMenu;
        private System.Windows.Forms.Button TimeMainMenu;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.TextBox UserInputTextBox;
        private System.Windows.Forms.ComboBox InitialUnitsComboBox;
        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.ComboBox ResultingUnitsComboBox;
        private System.Windows.Forms.Label InstructionLabel;
        private System.Windows.Forms.Label ValueOfLabel;
        private System.Windows.Forms.Button ConvertSubmissionButton;
        private System.Windows.Forms.Label InitialValueLabel;
        private System.Windows.Forms.Label EqualsLabel;
        private System.Windows.Forms.Label InitialUnitsLabel;
        private System.Windows.Forms.Label ResultingValueLabel;
        private System.Windows.Forms.Label ResultingUnitsLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label BackButtonLabel;
        private System.Windows.Forms.Label DividerLabel;
        private System.Windows.Forms.ToolStripMenuItem clearFormToolStripMenuItem;
    }
}

