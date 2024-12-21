using Tyuiu.KhudoiberdievDB.Sprint6.Task6.V12.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint6.Task6.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();

        private void buttonDone_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;
            textBoxInput.Text = File.ReadAllText(openFilePath);
            groupBoxOutput.Text += " " + openFileDialogTask.FileName;
            buttonDone.Enabled = true;
        }
    }
}
