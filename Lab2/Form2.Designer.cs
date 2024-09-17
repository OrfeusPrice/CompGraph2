namespace Lab2
{
    partial class Form2
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.Button_Task2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanel.Location = new System.Drawing.Point(221, 10);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(900, 674);
            this.MainPanel.TabIndex = 1;
            // 
            // Button_Task2
            // 
            this.Button_Task2.Location = new System.Drawing.Point(20, 13);
            this.Button_Task2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Button_Task2.Name = "Button_Task2";
            this.Button_Task2.Size = new System.Drawing.Size(179, 43);
            this.Button_Task2.TabIndex = 2;
            this.Button_Task2.Text = "Задание#2   RGB -> R,G,B";
            this.Button_Task2.UseVisualStyleBackColor = true;
            this.Button_Task2.Click += new System.EventHandler(this.Button_Task2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 693);
            this.Controls.Add(this.Button_Task2);
            this.Controls.Add(this.MainPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button Button_Task2;
    }
}