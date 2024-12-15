using Tyuiu.KhudoiberdievDB.Sprint6.Task3.V16.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint6.Task3.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] matrix = new int[5, 5] {{14, 1, -3, 1, 10 },
                                        { 7, -3, 5, -4, 0 },
                                        { -10, -19, -18, -9, 19 },
                                        { -2, -2, -16, 2, -17 },
                                        { -16, 9, 5, 10, 16 } };

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int cols = matrix.Length / rows;
            dataGridViewMatrix.ColumnCount = cols;
            dataGridViewMatrix.RowCount = rows;
            for (int i = 0; i < cols; i++)
            {
                dataGridViewMatrix.Columns[i].Width = 50;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewMatrix.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            int[,] mtrx = ds.Calculate(matrix);
            int rows = mtrx.GetUpperBound(0) + 1;
            int cols = mtrx.Length / rows;
            dataGridViewMatrixRes.ColumnCount = cols;
            dataGridViewMatrixRes.RowCount = rows;
            for (int i = 0; i < cols; i++)
            {
                this.dataGridViewMatrixRes.Columns[i].Width = 50;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    this.dataGridViewMatrixRes.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }


        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИСПб-24-1 Худойбердиев Далер ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridViewMatrix_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxTask_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
