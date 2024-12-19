namespace Tyuiu.KhudoiberdievDB.Sprint6.Task5.V5
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelTask = new Panel();
            groupBoxTask = new GroupBox();
            textBoxTask = new TextBox();
            panelRes = new Panel();
            groupBoxRes = new GroupBox();
            dataGridViewRes = new DataGridView();
            panelDiag = new Panel();
            chartRes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonDone = new Button();
            buttonFile = new Button();
            buttonHelp = new Button();
            panelTask.SuspendLayout();
            groupBoxTask.SuspendLayout();
            panelRes.SuspendLayout();
            groupBoxRes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes).BeginInit();
            panelDiag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartRes).BeginInit();
            SuspendLayout();
            // 
            // panelTask
            // 
            panelTask.Controls.Add(groupBoxTask);
            panelTask.Location = new Point(12, 12);
            panelTask.Name = "panelTask";
            panelTask.Size = new Size(640, 100);
            panelTask.TabIndex = 0;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Location = new Point(3, 3);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(634, 94);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие:";
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(0, 26);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(634, 68);
            textBoxTask.TabIndex = 1;
            textBoxTask.TabStop = false;
            textBoxTask.Text = resources.GetString("textBoxTask.Text");
            // 
            // panelRes
            // 
            panelRes.Controls.Add(groupBoxRes);
            panelRes.Location = new Point(12, 118);
            panelRes.Name = "panelRes";
            panelRes.Size = new Size(200, 386);
            panelRes.TabIndex = 1;
            // 
            // groupBoxRes
            // 
            groupBoxRes.Controls.Add(dataGridViewRes);
            groupBoxRes.Location = new Point(3, 0);
            groupBoxRes.Name = "groupBoxRes";
            groupBoxRes.Size = new Size(194, 383);
            groupBoxRes.TabIndex = 0;
            groupBoxRes.TabStop = false;
            groupBoxRes.Text = "Результат:";
            // 
            // dataGridViewRes
            // 
            dataGridViewRes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRes.ColumnHeadersVisible = false;
            dataGridViewRes.Location = new Point(6, 26);
            dataGridViewRes.Name = "dataGridViewRes";
            dataGridViewRes.ReadOnly = true;
            dataGridViewRes.RowHeadersVisible = false;
            dataGridViewRes.RowHeadersWidth = 51;
            dataGridViewRes.ScrollBars = ScrollBars.Vertical;
            dataGridViewRes.Size = new Size(182, 352);
            dataGridViewRes.TabIndex = 0;
            // 
            // panelDiag
            // 
            panelDiag.Controls.Add(chartRes);
            panelDiag.Location = new Point(218, 118);
            panelDiag.Name = "panelDiag";
            panelDiag.Size = new Size(752, 386);
            panelDiag.TabIndex = 2;
            // 
            // chartRes
            // 
            chartArea1.Name = "ChartArea1";
            chartRes.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chartRes.Legends.Add(legend1);
            chartRes.Location = new Point(3, 3);
            chartRes.Name = "chartRes";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartRes.Series.Add(series1);
            chartRes.Size = new Size(746, 375);
            chartRes.TabIndex = 0;
            chartRes.Text = "chart1";
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(658, 12);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(100, 100);
            buttonDone.TabIndex = 3;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonFile
            // 
            buttonFile.Location = new Point(764, 12);
            buttonFile.Name = "buttonFile";
            buttonFile.Size = new Size(100, 100);
            buttonFile.TabIndex = 4;
            buttonFile.Text = "Открыть файл";
            buttonFile.UseVisualStyleBackColor = true;
            buttonFile.Click += buttonFile_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(870, 12);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(100, 100);
            buttonHelp.TabIndex = 5;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 508);
            Controls.Add(buttonHelp);
            Controls.Add(buttonFile);
            Controls.Add(buttonDone);
            Controls.Add(panelDiag);
            Controls.Add(panelRes);
            Controls.Add(panelTask);
            MinimumSize = new Size(1000, 555);
            Name = "FormMain";
            Text = "Таск 5 | Вариант 5 | ИСПб-24-1 | Худойбердиев Далер |";
            panelTask.ResumeLayout(false);
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            panelRes.ResumeLayout(false);
            groupBoxRes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes).EndInit();
            panelDiag.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartRes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTask;
        private GroupBox groupBoxTask;
        private Panel panelRes;
        private GroupBox groupBoxRes;
        private Panel panelDiag;
        private TextBox textBoxTask;
        private Button buttonDone;
        private Button buttonFile;
        private Button buttonHelp;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRes;
        private DataGridView dataGridViewRes;
    }
}
