namespace Lab2
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MainGroupBox = new System.Windows.Forms.GroupBox();
            this.Button_Task3 = new System.Windows.Forms.Button();
            this.Button_Task2 = new System.Windows.Forms.Button();
            this.Button_Task1 = new System.Windows.Forms.Button();
            this.MainGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanel.Location = new System.Drawing.Point(270, 12);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1200, 829);
            this.MainPanel.TabIndex = 0;
            // 
            // MainGroupBox
            // 
            this.MainGroupBox.Controls.Add(this.Button_Task2);
            this.MainGroupBox.Controls.Add(this.Button_Task1);
            this.MainGroupBox.Controls.Add(this.Button_Task3);
            this.MainGroupBox.Location = new System.Drawing.Point(12, 12);
            this.MainGroupBox.Name = "MainGroupBox";
            this.MainGroupBox.Size = new System.Drawing.Size(252, 206);
            this.MainGroupBox.TabIndex = 1;
            this.MainGroupBox.TabStop = false;
            this.MainGroupBox.Text = "Инструменты";
            // 
            // Button_Task3
            // 
            this.Button_Task3.Location = new System.Drawing.Point(6, 140);
            this.Button_Task3.Name = "Button_Task3";
            this.Button_Task3.Size = new System.Drawing.Size(239, 53);
            this.Button_Task3.TabIndex = 3;
            this.Button_Task3.Text = "Задание#3   RGB -> HSV";
            this.Button_Task3.UseVisualStyleBackColor = true;
            this.Button_Task3.Click += new System.EventHandler(this.Button_Task3_Click);
            // 
            // Button_Task2
            // 
            this.Button_Task2.Location = new System.Drawing.Point(7, 81);
            this.Button_Task2.Name = "Button_Task2";
            this.Button_Task2.Size = new System.Drawing.Size(239, 53);
            this.Button_Task2.TabIndex = 1;
            this.Button_Task2.Text = "Задание#2   RGB -> R,G,B";
            this.Button_Task2.UseVisualStyleBackColor = true;
            this.Button_Task2.Click += new System.EventHandler(this.Button_Task2_Click);
            // 
            // Button_Task1
            // 
            this.Button_Task1.Location = new System.Drawing.Point(7, 22);
            this.Button_Task1.Name = "Button_Task1";
            this.Button_Task1.Size = new System.Drawing.Size(239, 53);
            this.Button_Task1.TabIndex = 0;
            this.Button_Task1.Text = "Задание#1   RGB -> Оттенки серого";
            this.Button_Task1.UseVisualStyleBackColor = true;
            this.Button_Task1.Click += new System.EventHandler(this.Button_Task1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.MainGroupBox);
            this.Controls.Add(this.MainPanel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MainGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.GroupBox MainGroupBox;
        private System.Windows.Forms.Button Button_Task2;
        private System.Windows.Forms.Button Button_Task1;
        private System.Windows.Forms.Button Button_Task3;
    }
}

