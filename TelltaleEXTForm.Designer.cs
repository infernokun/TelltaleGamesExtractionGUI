namespace TelltaleEXTGUI
{
    partial class TelltaleEXTForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Label title;
        private ListBox gamesList;
        private TextBox inputTextBox;
        private Button inputButton;
        private Button outputButton;
        private TextBox outputTextBox;
        private FolderBrowserDialog folderBrowserDialog1;
        private OpenFileDialog openFileDialog1;
        private ProgressBar processBar;
        private Button runButton;
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.processBar = new System.Windows.Forms.ProgressBar();
            this.runButton = new System.Windows.Forms.Button();
            this.extractOption = new System.Windows.Forms.RadioButton();
            this.buildOption = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(365, 38);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(121, 15);
            this.title.TabIndex = 0;
            this.title.Text = "Telltale Extraction GUI";
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // gamesList
            // 
            this.gamesList.FormattingEnabled = true;
            this.gamesList.ItemHeight = 15;
            this.gamesList.Location = new System.Drawing.Point(220, 190);
            this.gamesList.Name = "gamesList";
            this.gamesList.Size = new System.Drawing.Size(395, 94);
            this.gamesList.TabIndex = 1;
            this.gamesList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(98, 107);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.ReadOnly = true;
            this.inputTextBox.Size = new System.Drawing.Size(482, 23);
            this.inputTextBox.TabIndex = 2;
            this.inputTextBox.TextChanged += new System.EventHandler(this.inputTextBox_TextChanged);
            // 
            // inputButton
            // 
            this.inputButton.Location = new System.Drawing.Point(622, 107);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(140, 23);
            this.inputButton.TabIndex = 3;
            this.inputButton.Text = "Select Input File";
            this.inputButton.UseVisualStyleBackColor = true;
            this.inputButton.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // outputButton
            // 
            this.outputButton.Location = new System.Drawing.Point(622, 147);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(140, 23);
            this.outputButton.TabIndex = 4;
            this.outputButton.Text = "Select Output Folder";
            this.outputButton.UseVisualStyleBackColor = true;
            this.outputButton.Click += new System.EventHandler(this.outputButton_Click);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(98, 148);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(482, 23);
            this.outputTextBox.TabIndex = 5;
            this.outputTextBox.TextChanged += new System.EventHandler(this.outputTextBox_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // processBar
            // 
            this.processBar.Location = new System.Drawing.Point(46, 430);
            this.processBar.Name = "processBar";
            this.processBar.Size = new System.Drawing.Size(732, 23);
            this.processBar.TabIndex = 6;
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(349, 363);
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
            this.extractOption.Location = new System.Drawing.Point(349, 313);
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
            this.buildOption.Location = new System.Drawing.Point(426, 313);
            this.buildOption.Name = "buildOption";
            this.buildOption.Size = new System.Drawing.Size(52, 19);
            this.buildOption.TabIndex = 9;
            this.buildOption.TabStop = true;
            this.buildOption.Text = "Build";
            this.buildOption.UseVisualStyleBackColor = true;
            this.buildOption.CheckedChanged += new System.EventHandler(this.buildOption_CheckedChanged);
            // 
            // TelltaleEXTGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 465);
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
            this.Name = "TelltaleEXTGUI";
            this.Text = "TelltaleExtractionGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        //private Program program;

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