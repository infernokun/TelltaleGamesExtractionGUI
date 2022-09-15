namespace TelltaleEXTGUI
{
    partial class TelltaleEXTForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Title
        private Label Title;

        // Games List
        private ListBox GamesList;

        // Buttons
        private Button InputButton;
        private Button OutputButton;
        private Button RunButton;

        // Path Boxes
        private TextBox InputTextBox;
        private TextBox OutputTextBox;

        // Program Output
        private TextBox ProgramOutput;

        // Progress Bar
        private ProgressBar ProcessBar;
        
        // Radio Buttons
        private RadioButton ExtractOption;
        private RadioButton BuildOption;




        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.Label();
            this.GamesList = new System.Windows.Forms.ListBox();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.InputButton = new System.Windows.Forms.Button();
            this.OutputButton = new System.Windows.Forms.Button();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.ProcessBar = new System.Windows.Forms.ProgressBar();
            this.RunButton = new System.Windows.Forms.Button();
            this.ExtractOption = new System.Windows.Forms.RadioButton();
            this.BuildOption = new System.Windows.Forms.RadioButton();
            this.ProgramOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(270, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(276, 37);
            this.Title.TabIndex = 0;
            this.Title.Text = "Telltale Extraction GUI";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // GamesList
            // 
            this.GamesList.FormattingEnabled = true;
            this.GamesList.ItemHeight = 15;
            this.GamesList.Location = new System.Drawing.Point(265, 141);
            this.GamesList.Name = "GamesList";
            this.GamesList.Size = new System.Drawing.Size(361, 94);
            this.GamesList.TabIndex = 1;
            this.GamesList.SelectedIndexChanged += new System.EventHandler(this.GamesList_SelectedIndexChanged);
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(29, 74);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.ReadOnly = true;
            this.InputTextBox.Size = new System.Drawing.Size(597, 23);
            this.InputTextBox.TabIndex = 2;
            this.InputTextBox.TextChanged += new System.EventHandler(this.InputTextBox_TextChanged);
            // 
            // InputButton
            // 
            this.InputButton.Location = new System.Drawing.Point(647, 74);
            this.InputButton.Name = "InputButton";
            this.InputButton.Size = new System.Drawing.Size(140, 23);
            this.InputButton.TabIndex = 3;
            this.InputButton.Text = "Select Input File";
            this.InputButton.UseVisualStyleBackColor = true;
            this.InputButton.Click += new System.EventHandler(this.InputButton_Click);
            // 
            // OutputButton
            // 
            this.OutputButton.Location = new System.Drawing.Point(647, 112);
            this.OutputButton.Name = "OutputButton";
            this.OutputButton.Size = new System.Drawing.Size(140, 23);
            this.OutputButton.TabIndex = 4;
            this.OutputButton.Text = "Select Output Folder";
            this.OutputButton.UseVisualStyleBackColor = true;
            this.OutputButton.Click += new System.EventHandler(this.OutputButton_Click);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(29, 112);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.Size = new System.Drawing.Size(597, 23);
            this.OutputTextBox.TabIndex = 5;
            this.OutputTextBox.TextChanged += new System.EventHandler(this.OutputTextBox_TextChanged);
            // 
            // ProcessBar
            // 
            this.ProcessBar.Location = new System.Drawing.Point(46, 529);
            this.ProcessBar.Name = "ProcessBar";
            this.ProcessBar.Size = new System.Drawing.Size(719, 23);
            this.ProcessBar.TabIndex = 6;
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(379, 241);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(129, 23);
            this.RunButton.TabIndex = 7;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // ExtractOption
            // 
            this.ExtractOption.AutoSize = true;
            this.ExtractOption.Location = new System.Drawing.Point(306, 49);
            this.ExtractOption.Name = "ExtractOption";
            this.ExtractOption.Size = new System.Drawing.Size(61, 19);
            this.ExtractOption.TabIndex = 8;
            this.ExtractOption.TabStop = true;
            this.ExtractOption.Text = "Extract";
            this.ExtractOption.UseVisualStyleBackColor = true;
            this.ExtractOption.CheckedChanged += new System.EventHandler(this.ExtractOption_CheckedChanged);
            // 
            // BuildOption
            // 
            this.BuildOption.AutoSize = true;
            this.BuildOption.Location = new System.Drawing.Point(456, 49);
            this.BuildOption.Name = "BuildOption";
            this.BuildOption.Size = new System.Drawing.Size(52, 19);
            this.BuildOption.TabIndex = 9;
            this.BuildOption.TabStop = true;
            this.BuildOption.Text = "Build";
            this.BuildOption.UseVisualStyleBackColor = true;
            this.BuildOption.CheckedChanged += new System.EventHandler(this.BuildOption_CheckedChanged);
            // 
            // ProgramOutput
            // 
            this.ProgramOutput.Location = new System.Drawing.Point(29, 286);
            this.ProgramOutput.Multiline = true;
            this.ProgramOutput.Name = "ProgramOutput";
            this.ProgramOutput.ReadOnly = true;
            this.ProgramOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ProgramOutput.Size = new System.Drawing.Size(773, 237);
            this.ProgramOutput.TabIndex = 10;
            this.ProgramOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TelltaleEXTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 564);
            this.Controls.Add(this.ProgramOutput);
            this.Controls.Add(this.BuildOption);
            this.Controls.Add(this.ExtractOption);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.ProcessBar);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.OutputButton);
            this.Controls.Add(this.InputButton);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.GamesList);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelltaleEXTForm";
            this.Text = "TelltaleExtractionGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
    }
}