namespace Tyuiu.KhudoiberdievDB.Sprint6.Task1.V21
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
            groupBoxTask = new GroupBox();
            pictureBoxForm = new PictureBox();
            textBoxCond = new TextBox();
            groupBoxData = new GroupBox();
            textBoxVarStopValue = new TextBox();
            textBoxVarStartValue = new TextBox();
            groupBoxRes = new GroupBox();
            textBoxRes = new TextBox();
            buttonHelp = new Button();
            buttonDone = new Button();
            groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxForm).BeginInit();
            groupBoxData.SuspendLayout();
            groupBoxRes.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(pictureBoxForm);
            groupBoxTask.Controls.Add(textBoxCond);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(500, 321);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // pictureBoxForm
            // 
            pictureBoxForm.Image = Properties.Resources._2024_12_09_22_38_09;
            pictureBoxForm.Location = new Point(6, 86);
            pictureBoxForm.Name = "pictureBoxForm";
            pictureBoxForm.Size = new Size(324, 40);
            pictureBoxForm.TabIndex = 1;
            pictureBoxForm.TabStop = false;
            // 
            // textBoxCond
            // 
            textBoxCond.Location = new Point(6, 26);
            textBoxCond.Multiline = true;
            textBoxCond.Name = "textBoxCond";
            textBoxCond.ReadOnly = true;
            textBoxCond.Size = new Size(494, 289);
            textBoxCond.TabIndex = 0;
            textBoxCond.TabStop = false;
            textBoxCond.Text = "Написать программу, которая выводит таблицу значений функции Результат вывести в виде таблицы";
            // 
            // groupBoxData
            // 
            groupBoxData.Controls.Add(textBoxVarStopValue);
            groupBoxData.Controls.Add(textBoxVarStartValue);
            groupBoxData.Location = new Point(12, 339);
            groupBoxData.Name = "groupBoxData";
            groupBoxData.Size = new Size(300, 99);
            groupBoxData.TabIndex = 1;
            groupBoxData.TabStop = false;
            groupBoxData.Text = "Ввод данных : ";
            // 
            // textBoxVarStopValue
            // 
            textBoxVarStopValue.Location = new Point(155, 57);
            textBoxVarStopValue.Name = "textBoxVarStopValue";
            textBoxVarStopValue.Size = new Size(143, 27);
            textBoxVarStopValue.TabIndex = 1;
            textBoxVarStopValue.TextChanged += textBoxVarStopValue_TextChanged;
            // 
            // textBoxVarStartValue
            // 
            textBoxVarStartValue.AccessibleDescription = "";
            textBoxVarStartValue.AccessibleName = "";
            textBoxVarStartValue.Location = new Point(6, 57);
            textBoxVarStartValue.Name = "textBoxVarStartValue";
            textBoxVarStartValue.Size = new Size(143, 27);
            textBoxVarStartValue.TabIndex = 0;
            // 
            // groupBoxRes
            // 
            groupBoxRes.Controls.Add(textBoxRes);
            groupBoxRes.Location = new Point(518, 12);
            groupBoxRes.Name = "groupBoxRes";
            groupBoxRes.Size = new Size(296, 440);
            groupBoxRes.TabIndex = 2;
            groupBoxRes.TabStop = false;
            groupBoxRes.Text = "Вывод данных:";
            groupBoxRes.Enter += groupBoxRes_Enter;
            // 
            // textBoxRes
            // 
            textBoxRes.Font = new Font("Consolas", 9F);
            textBoxRes.Location = new Point(6, 26);
            textBoxRes.Multiline = true;
            textBoxRes.Name = "textBoxRes";
            textBoxRes.ReadOnly = true;
            textBoxRes.ScrollBars = ScrollBars.Vertical;
            textBoxRes.Size = new Size(270, 400);
            textBoxRes.TabIndex = 0;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.FromArgb(192, 255, 255);
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Font = new Font("Segoe UI", 9F);
            buttonHelp.Location = new Point(318, 350);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(87, 88);
            buttonHelp.TabIndex = 3;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.PaleGreen;
            buttonDone.Font = new Font("Segoe UI", 9F);
            buttonDone.Location = new Point(414, 350);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(98, 88);
            buttonDone.TabIndex = 4;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDone);
            Controls.Add(buttonHelp);
            Controls.Add(groupBoxRes);
            Controls.Add(groupBoxData);
            Controls.Add(groupBoxTask);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 21 | Худойбердиев Д.Б.";
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxForm).EndInit();
            groupBoxData.ResumeLayout(false);
            groupBoxData.PerformLayout();
            groupBoxRes.ResumeLayout(false);
            groupBoxRes.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private GroupBox groupBoxData;
        private TextBox textBoxVarStopValue;
        private TextBox textBoxVarStartValue;
        private TextBox textBoxCond;
        private PictureBox pictureBoxForm;
        private GroupBox groupBoxRes;
        private TextBox textBoxRes;
        private Button buttonHelp;
        private Button buttonDone;
    }
}
