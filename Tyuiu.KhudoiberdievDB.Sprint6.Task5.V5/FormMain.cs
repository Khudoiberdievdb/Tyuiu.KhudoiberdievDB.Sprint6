using Tyuiu.KhudoiberdievDB.Sprint6.Task5.V5.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint6.Task5.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\DataSprint6\InPutDataFileTask5V5.txt";





        private void buttonDone_Click(object sender, EventArgs e)
        {
            dataGridViewRes.ColumnCount = 2;
            dataGridViewRes.Columns[0].Width = 90;
            dataGridViewRes.Columns[1].Width = 50;

            chartRes.ChartAreas[0].AxisX.Title = "Ось Х";
            chartRes.ChartAreas[0].AxisY.Title = "Ось Y";

            chartRes.Series[0].Points.Clear();

            double[] array = new double[ds.len];

            array = ds.LoadFromDataFile(path);

            for (int i = 0; i < array.Length; i++)
            {
                dataGridViewRes.Rows.Add(Convert.ToString(i), Convert.ToString(array[i]));
                chartRes.Series[0].Points.AddXY(i, array[i]);
            }





        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show ("Таск 5 Выполнил студент группы ИСПб-24-1 Худойбердиев Далер", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
