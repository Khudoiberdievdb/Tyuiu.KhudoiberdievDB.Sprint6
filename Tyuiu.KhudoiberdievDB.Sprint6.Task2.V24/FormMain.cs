using Tyuiu.KhudoiberdievDB.Sprint6.Task2.V24.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint6.Task2.V24
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {

                int StartStep = Convert.ToInt32(textBoxVarStartValue.Text);
                int StopStep = Convert.ToInt32(textBoxVarStopValue.Text);

                int len = ds.GetMassFunction(StartStep, StopStep).Length;

                double[] valueArray = new double[len];

                valueArray = ds.GetMassFunction(StartStep, StopStep);

                chartTable.Titles.Add("График функции sin(x)");

                chartTable.ChartAreas[0].AxisX.Title = "Ось Х";
                chartTable.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i < len; i++)
                {
                    dataGridViewRes.Rows.Add(Convert.ToString(StartStep), Convert.ToString(valueArray[i]));
                    chartTable.Series[0].Points.AddXY(StartStep, valueArray[i]);
                    StartStep++;
                }



            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK);
            }


        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнен студентом группы ИСПб-24-1 Худойбердиевым Далером");
        }

        private void buttonHelp_MouseEnter(object sender, EventArgs e)
        {

        }

        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.Red;
        }

        private void buttonDone_MouseLeave(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.Green;
        }

        private void buttonDone_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone.BackColor = Color.Blue;
        }
    }
}
