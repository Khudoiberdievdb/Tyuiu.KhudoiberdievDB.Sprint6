
namespace Tyuiu.KhudoiberdievDB.Sprint6.Task3.V16
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxTask = new GroupBox();
            textBoxTask = new TextBox();
            dataGridViewMatrixRes = new DataGridView();
            groupBoxData = new GroupBox();
            groupBoxRes = new GroupBox();
            buttonDone = new Button();
            buttonHelp = new Button();
            dataGridViewMatrix = new DataGridView();
            groupBox1 = new GroupBox();
            groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrixRes).BeginInit();
            groupBoxData.SuspendLayout();
            groupBoxRes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(410, 426);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(0, 25);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(398, 395);
            textBoxTask.TabIndex = 0;
            textBoxTask.TabStop = false;
            textBoxTask.Text = resources.GetString("textBoxTask.Text");
            textBoxTask.TextChanged += textBoxTask_TextChanged;
            // 
            // dataGridViewMatrixRes
            // 
            dataGridViewMatrixRes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrixRes.Location = new Point(0, 26);
            dataGridViewMatrixRes.Name = "dataGridViewMatrixRes";
            dataGridViewMatrixRes.ReadOnly = true;
            dataGridViewMatrixRes.RowHeadersWidth = 51;
            dataGridViewMatrixRes.Size = new Size(300, 365);
            dataGridViewMatrixRes.TabIndex = 1;
            dataGridViewMatrixRes.CellContentClick += dataGridViewMatrix_CellContentClick;
            // 
            // groupBoxData
            // 
            groupBoxData.Controls.Add(groupBoxRes);
            groupBoxData.Location = new Point(734, 21);
            groupBoxData.Name = "groupBoxData";
            groupBoxData.Size = new Size(307, 417);
            groupBoxData.TabIndex = 2;
            groupBoxData.TabStop = false;
            groupBoxData.Text = "Ввод данных";
            // 
            // groupBoxRes
            // 
            groupBoxRes.Controls.Add(dataGridViewMatrixRes);
            groupBoxRes.Location = new Point(6, 26);
            groupBoxRes.Name = "groupBoxRes";
            groupBoxRes.Size = new Size(300, 385);
            groupBoxRes.TabIndex = 0;
            groupBoxRes.TabStop = false;
            groupBoxRes.Text = "Результат";
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(905, 438);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(130, 43);
            buttonDone.TabIndex = 2;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Location = new Point(805, 439);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(94, 43);
            buttonHelp.TabIndex = 1;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // dataGridViewMatrix
            // 
            dataGridViewMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix.Location = new Point(0, 52);
            dataGridViewMatrix.Name = "dataGridViewMatrix";
            dataGridViewMatrix.ReadOnly = true;
            dataGridViewMatrix.RowHeadersWidth = 51;
            dataGridViewMatrix.ShowCellErrors = false;
            dataGridViewMatrix.ShowRowErrors = false;
            dataGridViewMatrix.Size = new Size(300, 359);
            dataGridViewMatrix.TabIndex = 3;
            dataGridViewMatrix.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewMatrix);
            groupBox1.Location = new Point(428, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(306, 417);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Матрица";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 491);
            Controls.Add(buttonDone);
            Controls.Add(buttonHelp);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxData);
            Controls.Add(groupBoxTask);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 16 | Худойбердиев Далер";
            Load += FormMain_Load;
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrixRes).EndInit();
            groupBoxData.ResumeLayout(false);
            groupBoxRes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }



        #endregion

        private GroupBox groupBoxTask;
        private TextBox textBoxTask;
        private DataGridView dataGridViewMatrixRes;
        private GroupBox groupBoxData;
        private GroupBox groupBoxRes;
        private Button buttonDone;
        private Button buttonHelp;
        private DataGridView dataGridViewMatrix;
        private GroupBox groupBox1;
    }
}
