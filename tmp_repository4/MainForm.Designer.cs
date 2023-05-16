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
            this.SuspendLayout();
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(67, 305);
            this.btAdd.Margin = new System.Windows.Forms.Padding(6);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(177, 54);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "+";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btSum
            // 
            this.btSum.Location = new System.Drawing.Point(314, 302);
            this.btSum.Margin = new System.Windows.Forms.Padding(6);
            this.btSum.Name = "btSum";
            this.btSum.Size = new System.Drawing.Size(177, 54);
            this.btSum.TabIndex = 1;
            this.btSum.Text = "-";
            this.btSum.UseVisualStyleBackColor = true;
            // 
            // btMul
            // 
            this.btMul.Location = new System.Drawing.Point(570, 302);
            this.btMul.Margin = new System.Windows.Forms.Padding(6);
            this.btMul.Name = "btMul";
            this.btMul.Size = new System.Drawing.Size(177, 54);
            this.btMul.TabIndex = 2;
            this.btMul.Text = "*";
            this.btMul.UseVisualStyleBackColor = true;
            // 
            // btDiv
            // 
            this.btDiv.Location = new System.Drawing.Point(784, 302);
            this.btDiv.Margin = new System.Windows.Forms.Padding(6);
            this.btDiv.Name = "btDiv";
            this.btDiv.Size = new System.Drawing.Size(177, 54);
            this.btDiv.TabIndex = 3;
            this.btDiv.Text = "/";
            this.btDiv.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 49);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 53);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(146, 180);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(232, 53);
            this.textBox2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(425, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ввод числа 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(425, 189);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 46);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ввод числа 2";
            // 
            // btLog
            // 
            this.btLog.Location = new System.Drawing.Point(1050, 302);
            this.btLog.Margin = new System.Windows.Forms.Padding(6);
            this.btLog.Name = "btLog";
            this.btLog.Size = new System.Drawing.Size(196, 57);
            this.btLog.TabIndex = 8;
            this.btLog.Text = "Log";
            this.btLog.UseVisualStyleBackColor = true;
            this.btLog.Click += new System.EventHandler(this.btLog_Click);
            // 
            // lbAnswer
            // 
            this.lbAnswer.AutoSize = true;
            this.lbAnswer.Location = new System.Drawing.Point(563, 422);
            this.lbAnswer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbAnswer.Name = "lbAnswer";
            this.lbAnswer.Size = new System.Drawing.Size(130, 46);
            this.lbAnswer.TabIndex = 9;
            this.lbAnswer.Text = "Ответ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1364, 511);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
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
    }
}

