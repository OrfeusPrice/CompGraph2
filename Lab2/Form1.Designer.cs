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
            this.Button_Task1 = new System.Windows.Forms.Button();
            this.Button_Task2 = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Button_Task3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.H_trackBar = new System.Windows.Forms.TrackBar();
            this.S_trackBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.V_trackBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.MainGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.H_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.S_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.V_trackBar)).BeginInit();
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
            this.MainGroupBox.Controls.Add(this.groupBox1);
            this.MainGroupBox.Controls.Add(this.SaveButton);
            this.MainGroupBox.Controls.Add(this.Button_Task2);
            this.MainGroupBox.Controls.Add(this.Button_Task1);
            this.MainGroupBox.Location = new System.Drawing.Point(12, 12);
            this.MainGroupBox.Name = "MainGroupBox";
            this.MainGroupBox.Size = new System.Drawing.Size(252, 500);
            this.MainGroupBox.TabIndex = 1;
            this.MainGroupBox.TabStop = false;
            this.MainGroupBox.Text = "Инструменты";
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
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(13, 421);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(239, 64);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Сохранить изображение";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.V_trackBar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.S_trackBar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.H_trackBar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Button_Task3);
            this.groupBox1.Location = new System.Drawing.Point(0, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 275);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Инструменты Задание#3";
            // 
            // Button_Task3
            // 
            this.Button_Task3.Location = new System.Drawing.Point(7, 21);
            this.Button_Task3.Name = "Button_Task3";
            this.Button_Task3.Size = new System.Drawing.Size(239, 53);
            this.Button_Task3.TabIndex = 3;
            this.Button_Task3.Text = "Задание#3   RGB -> HSV";
            this.Button_Task3.UseVisualStyleBackColor = true;
            this.Button_Task3.Click += new System.EventHandler(this.Button_Task3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Оттенок";
            // 
            // H_trackBar
            // 
            this.H_trackBar.Location = new System.Drawing.Point(10, 101);
            this.H_trackBar.Name = "H_trackBar";
            this.H_trackBar.Size = new System.Drawing.Size(236, 56);
            this.H_trackBar.TabIndex = 5;
            this.H_trackBar.Scroll += new System.EventHandler(this.H_trackBar_Scroll);
            // 
            // S_trackBar
            // 
            this.S_trackBar.Location = new System.Drawing.Point(10, 163);
            this.S_trackBar.Name = "S_trackBar";
            this.S_trackBar.Size = new System.Drawing.Size(236, 56);
            this.S_trackBar.TabIndex = 7;
            this.S_trackBar.Scroll += new System.EventHandler(this.S_trackBar_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Насыщеннность";
            // 
            // V_trackBar
            // 
            this.V_trackBar.Location = new System.Drawing.Point(10, 225);
            this.V_trackBar.Name = "V_trackBar";
            this.V_trackBar.Size = new System.Drawing.Size(236, 56);
            this.V_trackBar.TabIndex = 9;
            this.V_trackBar.Scroll += new System.EventHandler(this.V_trackBar_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Значение";
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.H_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.S_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.V_trackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.GroupBox MainGroupBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button Button_Task2;
        private System.Windows.Forms.Button Button_Task1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Button_Task3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar V_trackBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar S_trackBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar H_trackBar;
    }
}

