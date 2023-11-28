namespace BuffaloWindowForm
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
            textName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textPort = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textName
            // 
            textName.Location = new Point(99, 32);
            textName.Name = "textName";
            textName.Size = new Size(100, 23);
            textName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 32);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 77);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 3;
            label2.Text = "Port";
            // 
            // textPort
            // 
            textPort.Location = new Point(99, 77);
            textPort.Name = "textPort";
            textPort.Size = new Size(100, 23);
            textPort.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(124, 140);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(271, 209);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textPort);
            Controls.Add(label1);
            Controls.Add(textName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textName;
        private Label label1;
        private Label label2;
        private TextBox textPort;
        private Button button1;
    }
}