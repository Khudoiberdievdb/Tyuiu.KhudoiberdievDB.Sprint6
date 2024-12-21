using Tyuiu.KhudoiberdievDB.Sprint6.Task7.V11.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint6.Task7.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        static int rows;
        static int columns;
        static string openFilePath;

        public static int[,] LoadFromData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            columns = lines[0].Split(';').Length;
            int[,] result = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = Convert.ToInt32(line_r[j]);
                }
            }
            return result;
        }
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;

            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromData(openFilePath);

            dataGridViewInPut.ColumnCount = columns;
            dataGridViewInPut.RowCount = rows;
            dataGridViewOutPut.ColumnCount = columns;
            dataGridViewOutPut.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridViewInPut.Columns[i].Width = 35;
                dataGridViewOutPut.Columns[i].Width = 35;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewInPut.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone.Enabled = true;
        }

        private void buttonDone_ANR_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOutPut.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
            buttonSaveFile.Enabled = true;
        }

        private void buttonSafeFile_ANR_Click(object sender, EventArgs e)
        {
            saveFileDialogTask.FileName = "OutPutFileTask7V11.csv";
            saveFileDialogTask.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTask.ShowDialog();
            string path = saveFileDialogTask.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExzist = fileInfo.Exists;
            if (fileExzist)
            {
                File.Delete(path);
            }
            int rows = dataGridViewOutPut.RowCount;
            int col = dataGridViewOutPut.ColumnCount;
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != col - 1)
                    {
                        str += dataGridViewOutPut.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewOutPut.Rows[i].Cells[j].Value;
                    }
                }
            }
            File.AppendAllText(path, str + Environment.NewLine);
            str = "";
        }



        private void buttonOpenFile_Click_1(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;

            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromData(openFilePath);

            dataGridViewInPut.ColumnCount = columns;
            dataGridViewInPut.RowCount = rows;
            dataGridViewOutPut.ColumnCount = columns;
            dataGridViewOutPut.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridViewInPut.Columns[i].Width = 35;
                dataGridViewOutPut.Columns[i].Width = 35;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewInPut.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone.Enabled = true;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOutPut.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
            buttonSaveFile.Enabled = true;
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            saveFileDialogTask.FileName = "OutPutFileTask7V11.csv";
            saveFileDialogTask.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTask.ShowDialog();
            string path = saveFileDialogTask.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExzist = fileInfo.Exists;
            if (fileExzist)
            {
                File.Delete(path);
            }
            int rows = dataGridViewOutPut.RowCount;
            int col = dataGridViewOutPut.ColumnCount;
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != col - 1)
                    {
                        str += dataGridViewOutPut.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewOutPut.Rows[i].Cells[j].Value;
                    }
                }
            }
            File.AppendAllText(path, str + Environment.NewLine);
            str = "";
        }
    }
}
