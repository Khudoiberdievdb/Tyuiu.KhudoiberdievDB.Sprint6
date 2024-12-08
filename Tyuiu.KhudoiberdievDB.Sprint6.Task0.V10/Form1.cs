using Tyuiu.KhudoiberdievDB.Sprint6.Task0.V10.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint6.Task0.V10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            textBoxRes.Text = Convert.ToString(ds.Calculate(2));
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 Выполнил студент группы ИСПб-24-1 Худойбердиев Далер Бахритдинович ");
        }
    }
}
