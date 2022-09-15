using System.Diagnostics;

namespace TelltaleEXTGUI
{
    public partial class TelltaleEXTForm : Form
    {
        private SynchronizationContext? _syncContext;

        public TelltaleEXTForm()
        {
            InitializeComponent();

            // update gamesList selection box
            GamesList.BeginUpdate();
            foreach (String s in TelltaleEXTMain.GAMES)
            {
                GamesList.Items.Add(s);

            }
            GamesList.EndUpdate();

            _syncContext = SynchronizationContext.Current;
        }

        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void OutputTextBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void InputButton_Click(object sender, EventArgs e)
        {
            // an option must be checked before selecting a file/folder
            if (!ExtractOption.Checked && !BuildOption.Checked) { return; }

            if (ExtractOption.Checked)
            { //if extract is checked
                // open an input file
                OpenFileDialog ofd = new OpenFileDialog
                {
                    Title = "Select TTARCH File",
                    InitialDirectory = Directory.GetCurrentDirectory(),
                    Filter = "TTarch File (*.ttarch*)|*.ttarch*",
                    FilterIndex = 1
                };

                ofd.ShowDialog();

                // do nothing if nothing chosen
                if (ofd.FileName == "") { return; }

                InputTextBox.Text = ofd.FileName;
                
            } else
            {// if build is cheked
                // open an output folder
                FolderBrowserDialog fbd = new FolderBrowserDialog()
                {
                    Description = "Select Folder Input",
                    InitialDirectory = Directory.GetCurrentDirectory()
                };

                fbd.ShowDialog();

                // do nothing if nothing is chosen
                if (fbd.SelectedPath == "") { return; }

                InputTextBox.Text = fbd.SelectedPath;
            }
        }

        private void OutputButton_Click(object sender, EventArgs e)
        {
            // an option must be checked before selecting a file/folder
            if (!ExtractOption.Checked && !BuildOption.Checked) { return; }

            
            if (ExtractOption.Checked)
            { // if extract option is checked
                //open folder dialog box
                FolderBrowserDialog fbd = new FolderBrowserDialog()
                {
                    Description = "Select Extraction Folder",
                    InitialDirectory = Directory.GetCurrentDirectory()
                };

                fbd.ShowDialog();

                // if nothing is chosen do nothing
                if (fbd.SelectedPath == "") { return; }

                OutputTextBox.Text = fbd.SelectedPath;

            } else
            {// if build option is checked
                // open save file dialog box
                SaveFileDialog sfd = new SaveFileDialog()
                {
                    Title = "Save TTARCH File As",
                    Filter = "TTARCH|*.ttarch|TTARCH2|*.ttarch2",
                    InitialDirectory = Directory.GetCurrentDirectory()
                };

                sfd.ShowDialog();

                // if nothing is chosen do nothing
                if (sfd.FileName == "") { return; }

                OutputTextBox.Text = sfd.FileName;
            }
            
        }

        private void GamesList_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void ExtractOption_CheckedChanged(object sender, EventArgs e)
        {
            if (ExtractOption.Checked)
            { // if extract option is checked 
                // change text to fit operation
                // input = file, output = folder
                InputButton.Text = "Select Input File";
                OutputButton.Text = "Select Output Folder";

                // reset path text
                InputTextBox.Text = "";
                OutputTextBox.Text = "";
            }
        }

        private void BuildOption_CheckedChanged(object sender, EventArgs e)
        {
            if (BuildOption.Checked)
            { // if build option is checked
                // change text to fit operation
                // input = folder, output = file
                InputButton.Text = "Select Input Folder";
                OutputButton.Text = "Select Output File";

                // reset path text
                InputTextBox.Text = "";
                OutputTextBox.Text = "";
            }
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            // check if all values are filled in
            if (InputTextBox.Text == "" ||
                OutputTextBox.Text == "" ||
                (ExtractOption.Checked && BuildOption.Checked) ||
                GamesList.SelectedItem == null)
            {

                Console.WriteLine("--\niBox: " + InputTextBox.Text + "\noBox: " + OutputTextBox.Text == "\nexOption: " + ExtractOption.Checked + "\nbOption: " + BuildOption.Checked + "\ngList: " + GamesList.SelectedItem); return;

            }

            // execution path and args
            string file = Directory.GetCurrentDirectory() + "\\ttarchext\\ttarchext.exe";
            string args;

            if (BuildOption.Checked)
            {// if build option
                // run required build args
                // ttarchext.exe -b -V 7 # "folder" file.ttarch
                args = " -b -V 7 " + GamesList.SelectedIndex + " " + OutputTextBox.Text + " " + InputTextBox.Text;
            }else
            {// if extract option
                // run required extract option
                // ttarchext.exe # "file.ttarch" folder
                args = " " + GamesList.SelectedIndex + " " + InputTextBox.Text + " " + OutputTextBox.Text;
            }

            // init process for execution
            using (var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = file,
                    RedirectStandardOutput = true,
                    Arguments = args
                }
            })
            {
                process.OutputDataReceived += (sender, args) => Display(args.Data);

                process.Start();
                process.BeginOutputReadLine();

                process.WaitForExit();
            }

            Console.WriteLine(args);
        }

        // dynamic console output 
        void Display(string output)
        {
            if (_syncContext != null)
            {
                _syncContext.Post(_ => ProgramOutput.AppendText(output), null);
            }
            
        }

        private void Process_OutputDataReceived(object sender, DataReceivedEventArgs e) => throw new NotImplementedException();

        private void Title_Click(object sender, EventArgs e) => throw new NotImplementedException();

    }
}