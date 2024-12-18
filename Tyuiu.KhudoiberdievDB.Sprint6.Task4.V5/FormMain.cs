using Tyuiu.KhudoiberdievDB.Sprint6.Task4.V5.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint6.Task4.V5
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

        private void buttonFile_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Path.GetTempPath()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxRes.Text);
                DialogResult dr = MessageBox.Show($"Данные сохранены в файл по пути: {path} \n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранениии файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try

            {
                int startStep = Convert.ToInt32(textBoxVarStart.Text);
                int stopStep = Convert.ToInt32(textBoxVarStop.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] array = new double[len];
                array = ds.GetMassFunction(startStep, stopStep);

                chartArea.ChartAreas[0].AxisX.Title = "Ось Х";
                chartArea.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxRes.Text = "";

                chartArea.Series[0].Points.Clear();
                for (int i = 0; i < len; i++)
                {
                    chartArea.Series[0].Points.AddXY(startStep, array[i]);
                    textBoxRes.AppendText(array[i] + Environment.NewLine);
                    startStep++;
                }


            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }






        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 Выполнил студент группы ИСПб-24-1 Худойбердиев Далер", "Сообщение", MessageBoxButtons.OK);


        }

        private void textBoxVarStart_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
