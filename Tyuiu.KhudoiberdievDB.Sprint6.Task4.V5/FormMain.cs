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
                DialogResult dr = MessageBox.Show($"������ ��������� � ���� �� ����: {path} \n ������� ��� � ��������?", "���������", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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
                MessageBox.Show("���� ��� ����������� �����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

                chartArea.ChartAreas[0].AxisX.Title = "��� �";
                chartArea.ChartAreas[0].AxisY.Title = "��� Y";

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
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }






        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 4 �������� ������� ������ ����-24-1 ������������ �����", "���������", MessageBoxButtons.OK);


        }

        private void textBoxVarStart_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
