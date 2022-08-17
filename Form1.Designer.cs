namespace Millioner
{
    partial class Form1
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
            this.buttonAnswer1 = new System.Windows.Forms.Button();
            this.buttonAnswer2 = new System.Windows.Forms.Button();
            this.buttonAnswer3 = new System.Windows.Forms.Button();
            this.buttonAnswer4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_points = new System.Windows.Forms.Label();
            this.textBoxQuestionText = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAnswer1
            // 
            this.buttonAnswer1.AutoSize = true;
            this.buttonAnswer1.Location = new System.Drawing.Point(48, 128);
            this.buttonAnswer1.Name = "buttonAnswer1";
            this.buttonAnswer1.Size = new System.Drawing.Size(75, 23);
            this.buttonAnswer1.TabIndex = 0;
            this.buttonAnswer1.Text = "button1";
            this.buttonAnswer1.UseVisualStyleBackColor = true;
            this.buttonAnswer1.Click += new System.EventHandler(this.buttonAnswer1_Click);
            // 
            // buttonAnswer2
            // 
            this.buttonAnswer2.AutoSize = true;
            this.buttonAnswer2.Location = new System.Drawing.Point(48, 157);
            this.buttonAnswer2.Name = "buttonAnswer2";
            this.buttonAnswer2.Size = new System.Drawing.Size(75, 23);
            this.buttonAnswer2.TabIndex = 1;
            this.buttonAnswer2.Text = "button2";
            this.buttonAnswer2.UseVisualStyleBackColor = true;
            this.buttonAnswer2.Click += new System.EventHandler(this.buttonAnswer2_Click);
            // 
            // buttonAnswer3
            // 
            this.buttonAnswer3.AutoSize = true;
            this.buttonAnswer3.Location = new System.Drawing.Point(48, 186);
            this.buttonAnswer3.Name = "buttonAnswer3";
            this.buttonAnswer3.Size = new System.Drawing.Size(75, 23);
            this.buttonAnswer3.TabIndex = 2;
            this.buttonAnswer3.Text = "button3";
            this.buttonAnswer3.UseVisualStyleBackColor = true;
            this.buttonAnswer3.Click += new System.EventHandler(this.buttonAnswer3_Click);
            // 
            // buttonAnswer4
            // 
            this.buttonAnswer4.AutoSize = true;
            this.buttonAnswer4.Location = new System.Drawing.Point(48, 215);
            this.buttonAnswer4.Name = "buttonAnswer4";
            this.buttonAnswer4.Size = new System.Drawing.Size(75, 23);
            this.buttonAnswer4.TabIndex = 3;
            this.buttonAnswer4.Text = "button4";
            this.buttonAnswer4.UseVisualStyleBackColor = true;
            this.buttonAnswer4.Click += new System.EventHandler(this.buttonAnswer4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Очки";
            // 
            // label_points
            // 
            this.label_points.AutoSize = true;
            this.label_points.Location = new System.Drawing.Point(280, 42);
            this.label_points.Name = "label_points";
            this.label_points.Size = new System.Drawing.Size(13, 13);
            this.label_points.TabIndex = 5;
            this.label_points.Text = "0";
            // 
            // textBoxQuestionText
            // 
            this.textBoxQuestionText.Enabled = false;
            this.textBoxQuestionText.Location = new System.Drawing.Point(48, 12);
            this.textBoxQuestionText.Multiline = true;
            this.textBoxQuestionText.Name = "textBoxQuestionText";
            this.textBoxQuestionText.Size = new System.Drawing.Size(220, 110);
            this.textBoxQuestionText.TabIndex = 6;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(283, 59);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 7;
            this.buttonStart.Text = "Начать";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 260);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxQuestionText);
            this.Controls.Add(this.label_points);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAnswer4);
            this.Controls.Add(this.buttonAnswer3);
            this.Controls.Add(this.buttonAnswer2);
            this.Controls.Add(this.buttonAnswer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAnswer1;
        private System.Windows.Forms.Button buttonAnswer2;
        private System.Windows.Forms.Button buttonAnswer3;
        private System.Windows.Forms.Button buttonAnswer4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_points;
        private System.Windows.Forms.TextBox textBoxQuestionText;
        private System.Windows.Forms.Button buttonStart;
    }
}

