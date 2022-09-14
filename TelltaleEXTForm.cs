using System.Diagnostics;

namespace TelltaleEXTGUI
{
    public partial class TelltaleEXTForm : Form
    {
        private SynchronizationContext _syncContext;

        public TelltaleEXTForm()
        {
            InitializeComponent();
            _syncContext = SynchronizationContext.Current;
        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void outputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputButton_Click(object sender, EventArgs e)
        {

            if (!extractOption.Checked && !buildOption.Checked) { return; }

            if (extractOption.Checked)
            {
                // open an input file
                OpenFileDialog ofd = new OpenFileDialog
                {
                    Title = "Select TTARCH File",
                    InitialDirectory = Directory.GetCurrentDirectory(),
                    Filter = "TTarch File (*.ttarch*)|*.ttarch*",
                    FilterIndex = 1
                };

                ofd.ShowDialog();

                if (ofd.FileName == "") { return; }

                inputTextBox.Text = ofd.FileName;
                Console.WriteLine(ofd.FileName);
                
            } else
            {
                // open an output folder
                FolderBrowserDialog fbd = new FolderBrowserDialog()
                {
                    Description = "Select Folder Input",
                    InitialDirectory = Directory.GetCurrentDirectory()
                };

                fbd.ShowDialog();

                if (fbd.SelectedPath == "") { return; }

                inputTextBox.Text = fbd.SelectedPath;
            }
        }

        private void outputButton_Click(object sender, EventArgs e)
        {
            if (!extractOption.Checked && !buildOption.Checked) { return; }

            if (extractOption.Checked)
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog()
                {
                    Description = "Select Extraction Folder",
                    InitialDirectory = Directory.GetCurrentDirectory()
                };

                fbd.ShowDialog();

                if (fbd.SelectedPath == "") { return; }

                outputTextBox.Text = fbd.SelectedPath;

            } else
            {
                SaveFileDialog sfd = new SaveFileDialog()
                {
                    Title = "Save TTARCH File As",
                    Filter = "TTARCH|*.ttarch|TTARCH2|*.ttarch2",
                    InitialDirectory = Directory.GetCurrentDirectory()
                };

                sfd.ShowDialog();

                if (sfd.FileName == "") { return; }

                outputTextBox.Text = sfd.FileName;
            }
            
        }

        private void gamesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine();
        }

        private void extractOption_CheckedChanged(object sender, EventArgs e)
        {
            if (extractOption.Checked)
            {
                // allow for input file to output directory
                inputButton.Text = "Select Input File";
                outputButton.Text = "Select Output Folder";

                inputTextBox.Text = "";
                outputTextBox.Text = "";
            }
        }

        private void buildOption_CheckedChanged(object sender, EventArgs e)
        {
            if (buildOption.Checked)
            {
                // allow input directory to output file
                inputButton.Text = "Select Input Folder";
                outputButton.Text = "Select Output File";

                inputTextBox.Text = "";
                outputTextBox.Text = "";
            }
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("--\niBox: " + inputTextBox.Text + "\noBox: " + outputTextBox.Text + "\nexOption: " + extractOption.Checked + "\nbOption: " + buildOption.Checked + "\ngList: " + gamesList.SelectedItem + TelltaleEXTMain.GAMES.IndexOf((string)gamesList.SelectedItem) + "\n--");

            if (inputTextBox.Text == "" ||
                outputTextBox.Text == "" ||
                (extractOption.Checked && buildOption.Checked) ||
                gamesList.SelectedItem == null)
            {

                Console.WriteLine("--\niBox: " + inputTextBox.Text + "\noBox: " + outputTextBox.Text == "\nexOption: " + extractOption.Checked + "\nbOption: " + buildOption.Checked + "\ngList: " + gamesList.SelectedItem); return;

            }

            string file = Directory.GetCurrentDirectory() + "\\ttarchext\\ttarchext.exe";

            string args = " " + gamesList.SelectedIndex + " " + inputTextBox.Text + " " + outputTextBox.Text;

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

            /*var proc = new Process();
            proc.StartInfo.FileName = file;
            proc.Start();*/

        }

        // dynamic console output 
        void Display(string output)
        {
            _syncContext.Post(_ => programOutput.AppendText(output), null);
        }

        private void Process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void title_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

    }
}