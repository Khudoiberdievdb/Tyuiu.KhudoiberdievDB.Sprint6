using Tyuiu.KhudoiberdievDB.Sprint6.Task1.V21.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint6.Task1.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
           
            DataService ds = new DataService();
            try
            { 
             int startStep = Convert.ToInt32(textBoxVarStartValue.Text);
             int stopStep = Convert.ToInt32(textBoxVarStopValue.Text);

             string strLine;

             int len = ds.GetMassFunction(startStep, stopStep).Length;

             double[] valueArray;
             valueArray = new double[len];
             valueArray = ds.GetMassFunction(startStep, stopStep);
             textBoxRes.Text = "";
             textBoxRes.AppendText("+----------+----------+" + Environment.NewLine);
             textBoxRes.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
             textBoxRes.AppendText("+----------+----------+" + Environment.NewLine);
             for (int i = 0; i < len; i++)
             {
                strLine = String.Format("|{0,5:d}     | {1, 7:f2}  |", startStep, valueArray[i]);
                textBoxRes.AppendText((strLine + Environment.NewLine));
                startStep++;
             }
             textBoxRes.AppendText("+----------+----------+" + Environment.NewLine);



            }
            catch
             {
             MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
          MessageBox.Show("Таск 1 выполнен студентом группы ИСПб-24-1 Худойбердиев Далер ");
        }

         private void textBoxVarStopValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxRes_Enter(object sender, EventArgs e)
        {

        }
    }
}
