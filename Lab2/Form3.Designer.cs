namespace Lab2
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.V_trackBar = new System.Windows.Forms.TrackBar();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.S_trackBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.H_trackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_Task3 = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.V_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.S_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.V_trackBar);
            this.groupBox1.Controls.Add(this.SaveButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.S_trackBar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.H_trackBar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Button_Task3);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(189, 288);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Инструменты Задание#3";
            // 
            // V_trackBar
            // 
            this.V_trackBar.Location = new System.Drawing.Point(8, 183);
            this.V_trackBar.Margin = new System.Windows.Forms.Padding(2);
            this.V_trackBar.Maximum = 100;
            this.V_trackBar.Name = "V_trackBar";
            this.V_trackBar.Size = new System.Drawing.Size(177, 45);
            this.V_trackBar.TabIndex = 9;
            this.V_trackBar.Value = 50;
            this.V_trackBar.Scroll += new System.EventHandler(this.V_trackBar_Scroll);
            this.V_trackBar.MouseCaptureChanged += new System.EventHandler(this.V_trackBar_MouseCaptureChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(8, 231);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(179, 52);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Сохранить изображение";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Значение";
            // 
            // S_trackBar
            // 
            this.S_trackBar.Location = new System.Drawing.Point(8, 132);
            this.S_trackBar.Margin = new System.Windows.Forms.Padding(2);
            this.S_trackBar.Maximum = 100;
            this.S_trackBar.Name = "S_trackBar";
            this.S_trackBar.Size = new System.Drawing.Size(177, 45);
            this.S_trackBar.TabIndex = 7;
            this.S_trackBar.Value = 50;
            this.S_trackBar.MouseCaptureChanged += new System.EventHandler(this.S_trackBar_MouseCaptureChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Насыщеннность";
            // 
            // H_trackBar
            // 
            this.H_trackBar.Location = new System.Drawing.Point(8, 84);
            this.H_trackBar.Margin = new System.Windows.Forms.Padding(2);
            this.H_trackBar.Maximum = 360;
            this.H_trackBar.Name = "H_trackBar";
            this.H_trackBar.Size = new System.Drawing.Size(177, 45);
            this.H_trackBar.SmallChange = 5;
            this.H_trackBar.TabIndex = 5;
            this.H_trackBar.Value = 180;
            this.H_trackBar.MouseCaptureChanged += new System.EventHandler(this.H_trackBar_MouseCaptureChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Оттенок";
            // 
            // Button_Task3
            // 
            this.Button_Task3.Location = new System.Drawing.Point(5, 17);
            this.Button_Task3.Margin = new System.Windows.Forms.Padding(2);
            this.Button_Task3.Name = "Button_Task3";
            this.Button_Task3.Size = new System.Drawing.Size(179, 43);
            this.Button_Task3.TabIndex = 3;
            this.Button_Task3.Text = "Задание#3   RGB -> HSV";
            this.Button_Task3.UseVisualStyleBackColor = true;
            this.Button_Task3.Click += new System.EventHandler(this.Button_Task3_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanel.Location = new System.Drawing.Point(202, 10);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(900, 674);
            this.MainPanel.TabIndex = 6;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 693);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.V_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.S_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_trackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar V_trackBar;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar S_trackBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar H_trackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_Task3;
        private System.Windows.Forms.Panel MainPanel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}