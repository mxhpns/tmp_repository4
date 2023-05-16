namespace tmp_repository4
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btAdd = new System.Windows.Forms.Button();
            this.btSum = new System.Windows.Forms.Button();
            this.btMul = new System.Windows.Forms.Button();
            this.btDiv = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btLog = new System.Windows.Forms.Button();
            this.lbAnswer = new System.Windows.Forms.Label();
            this.btAnswer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(189, 212);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "+";
            this.btAdd.UseVisualStyleBackColor = true;
            // 
            // btSum
            // 
            this.btSum.Location = new System.Drawing.Point(294, 211);
            this.btSum.Name = "btSum";
            this.btSum.Size = new System.Drawing.Size(75, 23);
            this.btSum.TabIndex = 1;
            this.btSum.Text = "-";
            this.btSum.UseVisualStyleBackColor = true;
            // 
            // btMul
            // 
            this.btMul.Location = new System.Drawing.Point(401, 211);
            this.btMul.Name = "btMul";
            this.btMul.Size = new System.Drawing.Size(75, 23);
            this.btMul.TabIndex = 2;
            this.btMul.Text = "*";
            this.btMul.UseVisualStyleBackColor = true;
            // 
            // btDiv
            // 
            this.btDiv.Location = new System.Drawing.Point(516, 211);
            this.btDiv.Name = "btDiv";
            this.btDiv.Size = new System.Drawing.Size(75, 23);
            this.btDiv.TabIndex = 3;
            this.btDiv.Text = "/";
            this.btDiv.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(210, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(210, 117);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ввод числа 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ввод числа 2";
            // 
            // btLog
            // 
            this.btLog.Location = new System.Drawing.Point(628, 211);
            this.btLog.Name = "btLog";
            this.btLog.Size = new System.Drawing.Size(82, 24);
            this.btLog.TabIndex = 8;
            this.btLog.Text = "Log";
            this.btLog.UseVisualStyleBackColor = true;
            // 
            // lbAnswer
            // 
            this.lbAnswer.AutoSize = true;
            this.lbAnswer.Location = new System.Drawing.Point(413, 284);
            this.lbAnswer.Name = "lbAnswer";
            this.lbAnswer.Size = new System.Drawing.Size(47, 16);
            this.lbAnswer.TabIndex = 9;
            this.lbAnswer.Text = "Ответ";
            // 
            // btAnswer
            // 
            this.btAnswer.Location = new System.Drawing.Point(382, 340);
            this.btAnswer.Name = "btAnswer";
            this.btAnswer.Size = new System.Drawing.Size(113, 39);
            this.btAnswer.TabIndex = 10;
            this.btAnswer.Text = "Ответ";
            this.btAnswer.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 391);
            this.Controls.Add(this.btAnswer);
            this.Controls.Add(this.lbAnswer);
            this.Controls.Add(this.btLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btDiv);
            this.Controls.Add(this.btMul);
            this.Controls.Add(this.btSum);
            this.Controls.Add(this.btAdd);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btSum;
        private System.Windows.Forms.Button btMul;
        private System.Windows.Forms.Button btDiv;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btLog;
        private System.Windows.Forms.Label lbAnswer;
        private System.Windows.Forms.Button btAnswer;
    }
}

