using System.Diagnostics;

namespace TelltaleEXTGUI
{
    public partial class TelltaleEXTForm : Form
    {
        public TelltaleEXTForm()
        {
            InitializeComponent();
        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void outputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputButton_Click(object sender, EventArgs e)
        {
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
        }

        private void outputButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog() {
                Description = "Select Extraction Folder",
                InitialDirectory = Directory.GetCurrentDirectory()
            };

            fbd.ShowDialog();

            if (fbd.SelectedPath == "") { return; }

            outputTextBox.Text = fbd.SelectedPath;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void extractOption_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buildOption_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void runButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("--\niBox: " + inputTextBox.Text + "\noBox: " + outputTextBox.Text + "\nexOption: " + extractOption.Checked + "\nbOption: " + buildOption.Checked + "\ngList: " + gamesList.SelectedItem + TelltaleEXTMain.GAMES.IndexOf((string)gamesList.SelectedItem) + "\n--");
  
            if (inputTextBox.Text == "" || 
                outputTextBox.Text == "" || 
                (!extractOption.Checked && !buildOption.Checked) ||
                gamesList.SelectedItem == null)
            {

                //Console.WriteLine("--\niBox: " + inputTextBox.Text + "\noBox: " + outputTextBox.Text == "\nexOption: " + extractOption.Checked + "\nbOption: " + buildOption.Checked + "\ngList: " + gamesList.SelectedItem); return;
                return;
            }

            Process.Start(Directory.GetCurrentDirectory() + "\\ttarchext\\ttarchext.exe");

        }

        private void title_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

    }
}