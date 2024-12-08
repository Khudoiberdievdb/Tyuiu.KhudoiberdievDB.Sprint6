namespace Tyuiu.KhudoiberdievDB.Sprint6.Task0.V10
{
    partial class Form1
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
            textBoxCond = new TextBox();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            buttonHelp = new Button();
            buttonDone = new Button();
            textBoxRes = new TextBox();
            groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxCond);
            groupBoxTask.Controls.Add(pictureBox1);
            groupBoxTask.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(776, 234);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // textBoxCond
            // 
            textBoxCond.Location = new Point(6, 55);
            textBoxCond.Multiline = true;
            textBoxCond.Name = "textBoxCond";
            textBoxCond.Size = new Size(411, 173);
            textBoxCond.TabIndex = 1;
            textBoxCond.Text = "Вычислить выражение по формуле, х=2";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Снимок_экрана_2024_12_08_205942;
            pictureBox1.Location = new Point(423, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(347, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonHelp);
            groupBox1.Controls.Add(buttonDone);
            groupBox1.Controls.Add(textBoxRes);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.Location = new Point(25, 253);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(757, 194);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Результат";
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(228, 113);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(50, 50);
            buttonHelp.TabIndex = 2;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(6, 113);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(216, 50);
            buttonDone.TabIndex = 1;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // textBoxRes
            // 
            textBoxRes.Location = new Point(6, 64);
            textBoxRes.Name = "textBoxRes";
            textBoxRes.Size = new Size(272, 27);
            textBoxRes.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxTask);
            Name = "Form1";
            Text = "Form1";
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private TextBox textBoxCond;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Button buttonHelp;
        private Button buttonDone;
        private TextBox textBoxRes;
    }
}
