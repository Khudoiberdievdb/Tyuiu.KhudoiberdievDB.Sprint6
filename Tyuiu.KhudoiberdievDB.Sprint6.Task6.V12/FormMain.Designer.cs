namespace Tyuiu.KhudoiberdievDB.Sprint6.Task6.V12
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelButtons = new Panel();
            panelInput = new Panel();
            groupBoxInput = new GroupBox();
            textBoxInput = new TextBox();
            panelOutput = new Panel();
            groupBoxOutput = new GroupBox();
            textBoxOutput = new TextBox();
            splitterBetPuts = new Splitter();
            panelTask = new Panel();
            groupBoxTask = new GroupBox();
            textBoxTask = new TextBox();
            groupBoxButtons = new GroupBox();
            buttonInfo = new Button();
            buttonDone = new Button();
            buttonOpenFile = new Button();
            openFileDialogTask = new OpenFileDialog();
            toolTip = new ToolTip(components);
            panelInput.SuspendLayout();
            groupBoxInput.SuspendLayout();
            panelOutput.SuspendLayout();
            groupBoxOutput.SuspendLayout();
            panelTask.SuspendLayout();
            groupBoxTask.SuspendLayout();
            groupBoxButtons.SuspendLayout();
            SuspendLayout();
            // 
            // panelButtons
            // 
            panelButtons.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelButtons.Location = new Point(3, 3);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(1175, 85);
            panelButtons.TabIndex = 0;
            // 
            // panelInput
            // 
            panelInput.Controls.Add(groupBoxInput);
            panelInput.Location = new Point(3, 225);
            panelInput.Name = "panelInput";
            panelInput.Size = new Size(590, 316);
            panelInput.TabIndex = 0;
            // 
            // groupBoxInput
            // 
            groupBoxInput.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBoxInput.Controls.Add(textBoxInput);
            groupBoxInput.Location = new Point(3, 3);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(584, 310);
            groupBoxInput.TabIndex = 0;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод:";
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(0, 26);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.ScrollBars = ScrollBars.Vertical;
            textBoxInput.Size = new Size(581, 287);
            textBoxInput.TabIndex = 0;
            // 
            // panelOutput
            // 
            panelOutput.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panelOutput.Controls.Add(groupBoxOutput);
            panelOutput.Controls.Add(splitterBetPuts);
            panelOutput.Location = new Point(599, 225);
            panelOutput.Name = "panelOutput";
            panelOutput.Size = new Size(579, 316);
            panelOutput.TabIndex = 0;
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(textBoxOutput);
            groupBoxOutput.Location = new Point(3, 3);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(573, 310);
            groupBoxOutput.TabIndex = 0;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод:";
            // 
            // textBoxOutput
            // 
            textBoxOutput.Location = new Point(-3, 26);
            textBoxOutput.Multiline = true;
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.ScrollBars = ScrollBars.Vertical;
            textBoxOutput.Size = new Size(579, 287);
            textBoxOutput.TabIndex = 0;
            // 
            // splitterBetPuts
            // 
            splitterBetPuts.Location = new Point(0, 0);
            splitterBetPuts.Name = "splitterBetPuts";
            splitterBetPuts.Size = new Size(4, 316);
            splitterBetPuts.TabIndex = 0;
            splitterBetPuts.TabStop = false;
            // 
            // panelTask
            // 
            panelTask.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panelTask.Controls.Add(groupBoxTask);
            panelTask.Location = new Point(3, 94);
            panelTask.Name = "panelTask";
            panelTask.Size = new Size(1175, 125);
            panelTask.TabIndex = 0;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Location = new Point(0, 3);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(1172, 125);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие:";
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(3, 26);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(1169, 96);
            textBoxTask.TabIndex = 0;
            textBoxTask.TabStop = false;
            textBoxTask.Text = resources.GetString("textBoxTask.Text");
            // 
            // groupBoxButtons
            // 
            groupBoxButtons.Controls.Add(buttonInfo);
            groupBoxButtons.Controls.Add(buttonDone);
            groupBoxButtons.Controls.Add(buttonOpenFile);
            groupBoxButtons.Location = new Point(3, 3);
            groupBoxButtons.Name = "groupBoxButtons";
            groupBoxButtons.Size = new Size(1175, 88);
            groupBoxButtons.TabIndex = 0;
            groupBoxButtons.TabStop = false;
            // 
            // buttonInfo
            // 
            buttonInfo.Location = new Point(1075, 15);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(94, 73);
            buttonInfo.TabIndex = 0;
            buttonInfo.Text = "Инфо";
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(113, 15);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(101, 73);
            buttonDone.TabIndex = 0;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Location = new Point(6, 15);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(101, 73);
            buttonOpenFile.TabIndex = 0;
            buttonOpenFile.Text = "Проводник";
            toolTip.SetToolTip(buttonOpenFile, "Открыть файл \r\nНайти нужный файл\r\n");
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // toolTip
            // 
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 553);
            Controls.Add(groupBoxButtons);
            Controls.Add(panelInput);
            Controls.Add(panelTask);
            Controls.Add(panelOutput);
            Controls.Add(panelButtons);
            KeyPreview = true;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Таск 6 | Вариант 12 | ИСПб-24-1 | Худойбердиев Далер";
            panelInput.ResumeLayout(false);
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            panelOutput.ResumeLayout(false);
            groupBoxOutput.ResumeLayout(false);
            groupBoxOutput.PerformLayout();
            panelTask.ResumeLayout(false);
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            groupBoxButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButtons;
        private Panel panelInput;
        private Panel panelOutput;
        private Panel panelTask;
        private GroupBox groupBoxInput;
        private GroupBox groupBoxOutput;
        private Splitter splitterBetPuts;
        private GroupBox groupBoxTask;
        private GroupBox groupBoxButtons;
        private TextBox textBoxInput;
        private TextBox textBoxOutput;
        private TextBox textBoxTask;
        private Button buttonInfo;
        private Button buttonDone;
        private Button buttonOpenFile;
        private ToolTip toolTip;
        private OpenFileDialog openFileDialogTask;
    }
}
