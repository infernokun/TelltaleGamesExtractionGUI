namespace TelltaleEXTGUI
{
    partial class TelltaleEXTForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Title
        private Label title;

        // Games List
        private ListBox gamesList;

        // Buttons
        private Button inputButton;
        private Button outputButton;
        private Button runButton;

        // Path Boxes
        private TextBox inputTextBox;
        private TextBox outputTextBox;

        // Program Output
        private TextBox programOutput;

        // Progress Bar
        private ProgressBar processBar;
        
        // Radio Buttons
        private RadioButton extractOption;
        private RadioButton buildOption;




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
            this.title = new System.Windows.Forms.Label();
            this.gamesList = new System.Windows.Forms.ListBox();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.inputButton = new System.Windows.Forms.Button();
            this.outputButton = new System.Windows.Forms.Button();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.processBar = new System.Windows.Forms.ProgressBar();
            this.runButton = new System.Windows.Forms.Button();
            this.extractOption = new System.Windows.Forms.RadioButton();
            this.buildOption = new System.Windows.Forms.RadioButton();
            this.programOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(270, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(276, 37);
            this.title.TabIndex = 0;
            this.title.Text = "Telltale Extraction GUI";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // gamesList
            // 
            this.gamesList.FormattingEnabled = true;
            this.gamesList.ItemHeight = 15;
            this.gamesList.Location = new System.Drawing.Point(265, 141);
            this.gamesList.Name = "gamesList";
            this.gamesList.Size = new System.Drawing.Size(361, 94);
            this.gamesList.TabIndex = 1;
            this.gamesList.SelectedIndexChanged += new System.EventHandler(this.gamesList_SelectedIndexChanged);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(29, 74);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.ReadOnly = true;
            this.inputTextBox.Size = new System.Drawing.Size(597, 23);
            this.inputTextBox.TabIndex = 2;
            this.inputTextBox.TextChanged += new System.EventHandler(this.inputTextBox_TextChanged);
            // 
            // inputButton
            // 
            this.inputButton.Location = new System.Drawing.Point(647, 74);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(140, 23);
            this.inputButton.TabIndex = 3;
            this.inputButton.Text = "Select Input File";
            this.inputButton.UseVisualStyleBackColor = true;
            this.inputButton.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // outputButton
            // 
            this.outputButton.Location = new System.Drawing.Point(647, 112);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(140, 23);
            this.outputButton.TabIndex = 4;
            this.outputButton.Text = "Select Output Folder";
            this.outputButton.UseVisualStyleBackColor = true;
            this.outputButton.Click += new System.EventHandler(this.outputButton_Click);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(29, 112);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(597, 23);
            this.outputTextBox.TabIndex = 5;
            this.outputTextBox.TextChanged += new System.EventHandler(this.outputTextBox_TextChanged);
            // 
            // processBar
            // 
            this.processBar.Location = new System.Drawing.Point(46, 529);
            this.processBar.Name = "processBar";
            this.processBar.Size = new System.Drawing.Size(719, 23);
            this.processBar.TabIndex = 6;
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(379, 241);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(129, 23);
            this.runButton.TabIndex = 7;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // extractOption
            // 
            this.extractOption.AutoSize = true;
            this.extractOption.Location = new System.Drawing.Point(306, 49);
            this.extractOption.Name = "extractOption";
            this.extractOption.Size = new System.Drawing.Size(61, 19);
            this.extractOption.TabIndex = 8;
            this.extractOption.TabStop = true;
            this.extractOption.Text = "Extract";
            this.extractOption.UseVisualStyleBackColor = true;
            this.extractOption.CheckedChanged += new System.EventHandler(this.extractOption_CheckedChanged);
            // 
            // buildOption
            // 
            this.buildOption.AutoSize = true;
            this.buildOption.Location = new System.Drawing.Point(456, 49);
            this.buildOption.Name = "buildOption";
            this.buildOption.Size = new System.Drawing.Size(52, 19);
            this.buildOption.TabIndex = 9;
            this.buildOption.TabStop = true;
            this.buildOption.Text = "Build";
            this.buildOption.UseVisualStyleBackColor = true;
            this.buildOption.CheckedChanged += new System.EventHandler(this.buildOption_CheckedChanged);
            // 
            // programOutput
            // 
            this.programOutput.Location = new System.Drawing.Point(29, 286);
            this.programOutput.Multiline = true;
            this.programOutput.Name = "programOutput";
            this.programOutput.ReadOnly = true;
            this.programOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.programOutput.Size = new System.Drawing.Size(1095, 237);
            this.programOutput.TabIndex = 10;
            this.programOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TelltaleEXTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 564);
            this.Controls.Add(this.programOutput);
            this.Controls.Add(this.buildOption);
            this.Controls.Add(this.extractOption);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.processBar);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.outputButton);
            this.Controls.Add(this.inputButton);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.gamesList);
            this.Controls.Add(this.title);
            this.Name = "TelltaleEXTForm";
            this.Text = "TelltaleExtractionGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private void populateGames()
        {
            gamesList.BeginUpdate();

            foreach (String s in TelltaleEXTMain.GAMES)
            {
                gamesList.Items.Add(s);
                
            }
            gamesList.EndUpdate();
        }
    }
}