
namespace Tyuiu.KhudoiberdievDB.Sprint6.Task7.V11
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
            panelButtons = new Panel();
            groupBoxButtons = new GroupBox();
            buttonInfo = new Button();
            buttonDone = new Button();
            buttonSaveFile = new Button();
            buttonOpenFile = new Button();
            panelTask = new Panel();
            groupBoxTask = new GroupBox();
            textBoxTask = new TextBox();
            panelInPut = new Panel();
            groupBoxInPut = new GroupBox();
            dataGridViewInPut = new DataGridView();
            panelOutPut = new Panel();
            groupBoxOutPut = new GroupBox();
            dataGridViewOutPut = new DataGridView();
            openFileDialogTask = new OpenFileDialog();
            saveFileDialogTask = new SaveFileDialog();
            panelButtons.SuspendLayout();
            groupBoxButtons.SuspendLayout();
            panelTask.SuspendLayout();
            groupBoxTask.SuspendLayout();
            panelInPut.SuspendLayout();
            groupBoxInPut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInPut).BeginInit();
            groupBoxOutPut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut).BeginInit();
            SuspendLayout();
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(groupBoxButtons);
            panelButtons.Dock = DockStyle.Top;
            panelButtons.Location = new Point(0, 0);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(1220, 125);
            panelButtons.TabIndex = 0;
            // 
            // groupBoxButtons
            // 
            groupBoxButtons.Controls.Add(buttonInfo);
            groupBoxButtons.Controls.Add(buttonDone);
            groupBoxButtons.Controls.Add(buttonSaveFile);
            groupBoxButtons.Controls.Add(buttonOpenFile);
            groupBoxButtons.Location = new Point(0, 0);
            groupBoxButtons.Name = "groupBoxButtons";
            groupBoxButtons.Size = new Size(1220, 125);
            groupBoxButtons.TabIndex = 0;
            groupBoxButtons.TabStop = false;
            // 
            // buttonInfo
            // 
            buttonInfo.FlatStyle = FlatStyle.Flat;
            buttonInfo.Image = Properties.Resources.help;
            buttonInfo.Location = new Point(1114, 12);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(100, 107);
            buttonInfo.TabIndex = 0;
            buttonInfo.UseVisualStyleBackColor = true;
            // 
            // buttonDone
            // 
            buttonDone.FlatStyle = FlatStyle.Flat;
            buttonDone.Image = Properties.Resources.page_white_go;
            buttonDone.Location = new Point(109, 12);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(100, 107);
            buttonDone.TabIndex = 0;
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonSaveFile
            // 
            buttonSaveFile.FlatStyle = FlatStyle.Flat;
            buttonSaveFile.Image = Properties.Resources.page_save;
            buttonSaveFile.Location = new Point(215, 12);
            buttonSaveFile.Name = "buttonSaveFile";
            buttonSaveFile.Size = new Size(100, 107);
            buttonSaveFile.TabIndex = 0;
            buttonSaveFile.UseVisualStyleBackColor = true;
            buttonSaveFile.Click += buttonSaveFile_Click;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.FlatStyle = FlatStyle.Flat;
            buttonOpenFile.Image = Properties.Resources.folder_page;
            buttonOpenFile.Location = new Point(3, 12);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(100, 107);
            buttonOpenFile.TabIndex = 0;
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click_1;
            // 
            // panelTask
            // 
            panelTask.Controls.Add(groupBoxTask);
            panelTask.Location = new Point(0, 131);
            panelTask.Name = "panelTask";
            panelTask.Size = new Size(1220, 110);
            panelTask.TabIndex = 0;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Location = new Point(3, 0);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(1217, 107);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(0, 26);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.Size = new Size(1214, 75);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = resources.GetString("textBoxTask.Text");
            // 
            // panelInPut
            // 
            panelInPut.Controls.Add(groupBoxInPut);
            panelInPut.Location = new Point(0, 247);
            panelInPut.Name = "panelInPut";
            panelInPut.Size = new Size(579, 230);
            panelInPut.TabIndex = 1;
            // 
            // groupBoxInPut
            // 
            groupBoxInPut.Controls.Add(dataGridViewInPut);
            groupBoxInPut.Location = new Point(3, -3);
            groupBoxInPut.Name = "groupBoxInPut";
            groupBoxInPut.Size = new Size(573, 230);
            groupBoxInPut.TabIndex = 0;
            groupBoxInPut.TabStop = false;
            groupBoxInPut.Text = "Ввод:";
            // 
            // dataGridViewInPut
            // 
            dataGridViewInPut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInPut.Location = new Point(0, 26);
            dataGridViewInPut.Name = "dataGridViewInPut";
            dataGridViewInPut.RowHeadersWidth = 51;
            dataGridViewInPut.Size = new Size(573, 204);
            dataGridViewInPut.TabIndex = 0;
            // 
            // panelOutPut
            // 
            panelOutPut.Location = new Point(585, 247);
            panelOutPut.Name = "panelOutPut";
            panelOutPut.Size = new Size(635, 230);
            panelOutPut.TabIndex = 1;
            // 
            // groupBoxOutPut
            // 
            groupBoxOutPut.Controls.Add(dataGridViewOutPut);
            groupBoxOutPut.Location = new Point(588, 244);
            groupBoxOutPut.Name = "groupBoxOutPut";
            groupBoxOutPut.Size = new Size(629, 230);
            groupBoxOutPut.TabIndex = 0;
            groupBoxOutPut.TabStop = false;
            groupBoxOutPut.Text = "Вывод:";
            // 
            // dataGridViewOutPut
            // 
            dataGridViewOutPut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutPut.Location = new Point(0, 26);
            dataGridViewOutPut.Name = "dataGridViewOutPut";
            dataGridViewOutPut.RowHeadersWidth = 51;
            dataGridViewOutPut.Size = new Size(629, 207);
            dataGridViewOutPut.TabIndex = 0;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialogTask";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1220, 489);
            Controls.Add(groupBoxOutPut);
            Controls.Add(panelOutPut);
            Controls.Add(panelInPut);
            Controls.Add(panelTask);
            Controls.Add(panelButtons);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 7 | Вариант 11 | Худойбердиев Далер | ИСПб-24-1 ";
            WindowState = FormWindowState.Maximized;
            Load += FormMain_Load;
            panelButtons.ResumeLayout(false);
            groupBoxButtons.ResumeLayout(false);
            panelTask.ResumeLayout(false);
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            panelInPut.ResumeLayout(false);
            groupBoxInPut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInPut).EndInit();
            groupBoxOutPut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut).EndInit();
            ResumeLayout(false);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panelButtons;
        private Panel panelTask;
        private Panel panelInPut;
        private Panel panelOutPut;
        private GroupBox groupBoxButtons;
        private GroupBox groupBoxTask;
        private GroupBox groupBoxInPut;
        private GroupBox groupBoxOutPut;
        private Button buttonInfo;
        private Button buttonDone;
        private Button buttonSaveFile;
        private Button buttonOpenFile;
        private TextBox textBoxTask;
        private DataGridView dataGridViewInPut;
        private DataGridView dataGridViewOutPut;
        private OpenFileDialog openFileDialogTask;
        private SaveFileDialog saveFileDialogTask;
    }
}
