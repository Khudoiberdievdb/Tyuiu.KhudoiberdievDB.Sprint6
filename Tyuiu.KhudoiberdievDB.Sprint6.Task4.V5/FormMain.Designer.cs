namespace Tyuiu.KhudoiberdievDB.Sprint6.Task4.V5
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            panelTask = new Panel();
            groupBoxVars = new GroupBox();
            labelVarStop = new Label();
            labelVarStart = new Label();
            textBoxVarStart = new TextBox();
            textBoxVarStop = new TextBox();
            buttonDone = new Button();
            buttonFile = new Button();
            buttonHelp = new Button();
            groupBoxTask = new GroupBox();
            pictureBox1 = new PictureBox();
            textBoxTask = new TextBox();
            panelRes = new Panel();
            groupBoxRes = new GroupBox();
            textBoxRes = new TextBox();
            panelGrindWiew = new Panel();
            chartArea = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitterResWiew = new Splitter();
            panelTask.SuspendLayout();
            groupBoxVars.SuspendLayout();
            groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelRes.SuspendLayout();
            groupBoxRes.SuspendLayout();
            panelGrindWiew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartArea).BeginInit();
            SuspendLayout();
            // 
            // panelTask
            // 
            panelTask.Controls.Add(groupBoxVars);
            panelTask.Controls.Add(buttonDone);
            panelTask.Controls.Add(buttonFile);
            panelTask.Controls.Add(buttonHelp);
            panelTask.Controls.Add(groupBoxTask);
            panelTask.Dock = DockStyle.Top;
            panelTask.Location = new Point(0, 0);
            panelTask.Name = "panelTask";
            panelTask.Size = new Size(1070, 125);
            panelTask.TabIndex = 0;
            // 
            // groupBoxVars
            // 
            groupBoxVars.Controls.Add(labelVarStop);
            groupBoxVars.Controls.Add(labelVarStart);
            groupBoxVars.Controls.Add(textBoxVarStart);
            groupBoxVars.Controls.Add(textBoxVarStop);
            groupBoxVars.Location = new Point(482, 0);
            groupBoxVars.Name = "groupBoxVars";
            groupBoxVars.Size = new Size(273, 128);
            groupBoxVars.TabIndex = 2;
            groupBoxVars.TabStop = false;
            groupBoxVars.Text = "Ввод данных:";
            // 
            // labelVarStop
            // 
            labelVarStop.AutoSize = true;
            labelVarStop.Location = new Point(137, 47);
            labelVarStop.Name = "labelVarStop";
            labelVarStop.Size = new Size(94, 20);
            labelVarStop.TabIndex = 1;
            labelVarStop.Text = "Конец шага:";
            // 
            // labelVarStart
            // 
            labelVarStart.AutoSize = true;
            labelVarStart.Location = new Point(6, 47);
            labelVarStart.Name = "labelVarStart";
            labelVarStart.Size = new Size(88, 20);
            labelVarStart.TabIndex = 1;
            labelVarStart.Text = "Старт шага:";
            // 
            // textBoxVarStart
            // 
            textBoxVarStart.Location = new Point(6, 70);
            textBoxVarStart.Name = "textBoxVarStart";
            textBoxVarStart.Size = new Size(125, 27);
            textBoxVarStart.TabIndex = 0;
            textBoxVarStart.TextChanged += textBoxVarStart_TextChanged;
            // 
            // textBoxVarStop
            // 
            textBoxVarStop.Location = new Point(137, 70);
            textBoxVarStop.Name = "textBoxVarStop";
            textBoxVarStop.Size = new Size(125, 27);
            textBoxVarStop.TabIndex = 0;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(761, 12);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(100, 85);
            buttonDone.TabIndex = 1;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonFile
            // 
            buttonFile.Location = new Point(867, 12);
            buttonFile.Name = "buttonFile";
            buttonFile.Size = new Size(100, 85);
            buttonFile.TabIndex = 1;
            buttonFile.Text = "Сохранить";
            buttonFile.UseVisualStyleBackColor = true;
            buttonFile.Click += buttonFile_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp.Location = new Point(973, 12);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(85, 85);
            buttonHelp.TabIndex = 1;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(pictureBox1);
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Location = new Point(0, 0);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(476, 125);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._2024_12_18_21_17_58;
            pictureBox1.Location = new Point(73, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(383, 50);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(0, 29);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(467, 96);
            textBoxTask.TabIndex = 0;
            textBoxTask.TabStop = false;
            textBoxTask.Text = "Написать программу, которая выводит таблицу значений функции:\r\n\r\n\r\n";
            // 
            // panelRes
            // 
            panelRes.Controls.Add(groupBoxRes);
            panelRes.Dock = DockStyle.Left;
            panelRes.Location = new Point(0, 125);
            panelRes.Name = "panelRes";
            panelRes.Size = new Size(250, 378);
            panelRes.TabIndex = 1;
            // 
            // groupBoxRes
            // 
            groupBoxRes.Controls.Add(textBoxRes);
            groupBoxRes.Location = new Point(0, 0);
            groupBoxRes.Name = "groupBoxRes";
            groupBoxRes.Padding = new Padding(5);
            groupBoxRes.Size = new Size(250, 375);
            groupBoxRes.TabIndex = 0;
            groupBoxRes.TabStop = false;
            groupBoxRes.Text = "Вывод:";
            // 
            // textBoxRes
            // 
            textBoxRes.Dock = DockStyle.Fill;
            textBoxRes.Location = new Point(5, 25);
            textBoxRes.Multiline = true;
            textBoxRes.Name = "textBoxRes";
            textBoxRes.ReadOnly = true;
            textBoxRes.ScrollBars = ScrollBars.Vertical;
            textBoxRes.Size = new Size(240, 345);
            textBoxRes.TabIndex = 0;
            // 
            // panelGrindWiew
            // 
            panelGrindWiew.Controls.Add(chartArea);
            panelGrindWiew.Controls.Add(splitterResWiew);
            panelGrindWiew.Dock = DockStyle.Fill;
            panelGrindWiew.Location = new Point(250, 125);
            panelGrindWiew.Name = "panelGrindWiew";
            panelGrindWiew.Size = new Size(820, 378);
            panelGrindWiew.TabIndex = 1;
            // 
            // chartArea
            // 
            chartArea1.Name = "ChartArea1";
            chartArea.ChartAreas.Add(chartArea1);
            chartArea.Dock = DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chartArea.Legends.Add(legend1);
            chartArea.Location = new Point(4, 0);
            chartArea.Name = "chartArea";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartArea.Series.Add(series1);
            chartArea.Size = new Size(816, 378);
            chartArea.TabIndex = 1;
            chartArea.Text = "chart";
            title1.BorderWidth = 3;
            title1.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold);
            title1.ForeColor = Color.DarkGreen;
            title1.Name = "TitleFunction";
            title1.Text = "График функции:";
            chartArea.Titles.Add(title1);
            // 
            // splitterResWiew
            // 
            splitterResWiew.Location = new Point(0, 0);
            splitterResWiew.Name = "splitterResWiew";
            splitterResWiew.Size = new Size(4, 378);
            splitterResWiew.TabIndex = 0;
            splitterResWiew.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 503);
            Controls.Add(panelGrindWiew);
            Controls.Add(panelRes);
            Controls.Add(panelTask);
            MinimumSize = new Size(1088, 550);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 5 | Худойбердиев Далер | ИСПб-24-1";
            Load += FormMain_Load;
            panelTask.ResumeLayout(false);
            groupBoxVars.ResumeLayout(false);
            groupBoxVars.PerformLayout();
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelRes.ResumeLayout(false);
            groupBoxRes.ResumeLayout(false);
            groupBoxRes.PerformLayout();
            panelGrindWiew.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartArea).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTask;
        private Panel panelRes;
        private Panel panelGrindWiew;
        private Splitter splitterResWiew;
        private GroupBox groupBoxTask;
        private GroupBox groupBoxRes;
        private TextBox textBoxRes;
        private Button buttonDone;
        private Button buttonHelp;
        private Button buttonFile;
        private TextBox textBoxTask;
        private PictureBox pictureBox1;
        private GroupBox groupBoxVars;
        private Label labelVarStop;
        private Label labelVarStart;
        private TextBox textBoxVarStart;
        private TextBox textBoxVarStop;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartArea;
    }
}
