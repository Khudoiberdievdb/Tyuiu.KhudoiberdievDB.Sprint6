namespace Tyuiu.KhudoiberdievDB.Sprint6.Task2.V24
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxTask = new GroupBox();
            pictureBox1 = new PictureBox();
            textBoxTask = new TextBox();
            groupBox1 = new GroupBox();
            groupBoxData = new GroupBox();
            groupBoxVarStopValue = new GroupBox();
            textBoxVarStopValue = new TextBox();
            groupBoxVarSV = new GroupBox();
            textBoxVarStartValue = new TextBox();
            groupBoxRes = new GroupBox();
            chartTable = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewRes = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            ColumnVarFx = new DataGridViewTextBoxColumn();
            buttonHelp = new Button();
            buttonDone = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxData.SuspendLayout();
            groupBoxVarStopValue.SuspendLayout();
            groupBoxVarSV.SuspendLayout();
            groupBoxRes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(pictureBox1);
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Controls.Add(groupBox1);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(624, 347);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._2024_12_10_16_01_45;
            pictureBox1.Location = new Point(0, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(477, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(0, 20);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(612, 321);
            textBoxTask.TabIndex = 1;
            textBoxTask.TabStop = false;
            textBoxTask.Text = "Написать программу которая выводит таблицу значений функции :\r\n";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(20, 379);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(262, 61);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // groupBoxData
            // 
            groupBoxData.Controls.Add(groupBoxVarStopValue);
            groupBoxData.Controls.Add(groupBoxVarSV);
            groupBoxData.Location = new Point(12, 365);
            groupBoxData.Name = "groupBoxData";
            groupBoxData.Size = new Size(378, 93);
            groupBoxData.TabIndex = 1;
            groupBoxData.TabStop = false;
            groupBoxData.Text = "Ввод данных";
            // 
            // groupBoxVarStopValue
            // 
            groupBoxVarStopValue.Controls.Add(textBoxVarStopValue);
            groupBoxVarStopValue.Location = new Point(193, 20);
            groupBoxVarStopValue.Name = "groupBoxVarStopValue";
            groupBoxVarStopValue.Size = new Size(179, 67);
            groupBoxVarStopValue.TabIndex = 1;
            groupBoxVarStopValue.TabStop = false;
            groupBoxVarStopValue.Text = "Конец шага";
            // 
            // textBoxVarStopValue
            // 
            textBoxVarStopValue.Location = new Point(6, 26);
            textBoxVarStopValue.Name = "textBoxVarStopValue";
            textBoxVarStopValue.Size = new Size(167, 27);
            textBoxVarStopValue.TabIndex = 0;
            // 
            // groupBoxVarSV
            // 
            groupBoxVarSV.Controls.Add(textBoxVarStartValue);
            groupBoxVarSV.Location = new Point(6, 20);
            groupBoxVarSV.Name = "groupBoxVarSV";
            groupBoxVarSV.Size = new Size(181, 66);
            groupBoxVarSV.TabIndex = 0;
            groupBoxVarSV.TabStop = false;
            groupBoxVarSV.Text = "Старт шага";
            // 
            // textBoxVarStartValue
            // 
            textBoxVarStartValue.Location = new Point(6, 26);
            textBoxVarStartValue.Name = "textBoxVarStartValue";
            textBoxVarStartValue.Size = new Size(169, 27);
            textBoxVarStartValue.TabIndex = 0;
            // 
            // groupBoxRes
            // 
            groupBoxRes.Controls.Add(chartTable);
            groupBoxRes.Controls.Add(dataGridViewRes);
            groupBoxRes.Location = new Point(642, 12);
            groupBoxRes.Name = "groupBoxRes";
            groupBoxRes.Size = new Size(553, 446);
            groupBoxRes.TabIndex = 2;
            groupBoxRes.TabStop = false;
            groupBoxRes.Text = "Вывод данных";
            // 
            // chartTable
            // 
            chartArea2.Name = "ChartArea1";
            chartTable.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartTable.Legends.Add(legend2);
            chartTable.Location = new Point(196, 26);
            chartTable.Name = "chartTable";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartTable.Series.Add(series2);
            chartTable.Size = new Size(351, 426);
            chartTable.TabIndex = 1;
            chartTable.Text = "chart1";
            // 
            // dataGridViewRes
            // 
            dataGridViewRes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRes.Columns.AddRange(new DataGridViewColumn[] { X, ColumnVarFx });
            dataGridViewRes.Location = new Point(0, 20);
            dataGridViewRes.Name = "dataGridViewRes";
            dataGridViewRes.ReadOnly = true;
            dataGridViewRes.RowHeadersVisible = false;
            dataGridViewRes.RowHeadersWidth = 51;
            dataGridViewRes.ScrollBars = ScrollBars.Vertical;
            dataGridViewRes.Size = new Size(190, 426);
            dataGridViewRes.TabIndex = 0;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.ReadOnly = true;
            X.ToolTipText = "X";
            X.Width = 95;
            // 
            // ColumnVarFx
            // 
            ColumnVarFx.HeaderText = "F(x)";
            ColumnVarFx.MinimumWidth = 6;
            ColumnVarFx.Name = "ColumnVarFx";
            ColumnVarFx.ReadOnly = true;
            ColumnVarFx.Width = 95;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.CornflowerBlue;
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Location = new Point(396, 365);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(93, 93);
            buttonHelp.TabIndex = 3;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            buttonHelp.MouseEnter += buttonHelp_MouseEnter;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.Green;
            buttonDone.Location = new Point(495, 365);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(141, 93);
            buttonDone.TabIndex = 4;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            buttonDone.MouseDown += buttonDone_MouseDown;
            buttonDone.MouseEnter += buttonDone_MouseEnter;
            buttonDone.MouseLeave += buttonDone_MouseLeave;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 470);
            Controls.Add(buttonDone);
            Controls.Add(groupBoxData);
            Controls.Add(buttonHelp);
            Controls.Add(groupBoxRes);
            Controls.Add(groupBoxTask);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            Text = "|Спринт 6 | Таск 2 | Вариант 24 | Худойбердиев Далер Бахритдинович";
            Load += FormMain_Load;
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxData.ResumeLayout(false);
            groupBoxVarStopValue.ResumeLayout(false);
            groupBoxVarStopValue.PerformLayout();
            groupBoxVarSV.ResumeLayout(false);
            groupBoxVarSV.PerformLayout();
            groupBoxRes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private GroupBox groupBox1;
        private GroupBox groupBoxData;
        private GroupBox groupBoxRes;
        private Button buttonHelp;
        private Button buttonDone;
        private TextBox textBoxTask;
        private GroupBox groupBoxVarStopValue;
        private TextBox textBoxVarStopValue;
        private GroupBox groupBoxVarSV;
        private TextBox textBoxVarStartValue;
        private PictureBox pictureBox1;
        private DataGridView dataGridViewRes;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTable;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn ColumnVarFx;
    }
}
