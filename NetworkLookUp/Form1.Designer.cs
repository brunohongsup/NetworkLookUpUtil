namespace NetworkLookUp
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
            comboBox_NetworkInterface = new ComboBox();
            panel1 = new Panel();
            treeView_FileSystem = new TreeView();
            button_LookUp = new Button();
            button_Update = new Button();
            textBox_TargetIP = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox_NetworkInterface
            // 
            comboBox_NetworkInterface.FormattingEnabled = true;
            comboBox_NetworkInterface.Location = new Point(31, 27);
            comboBox_NetworkInterface.Name = "comboBox_NetworkInterface";
            comboBox_NetworkInterface.Size = new Size(275, 23);
            comboBox_NetworkInterface.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(treeView_FileSystem);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(344, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(456, 450);
            panel1.TabIndex = 1;
            // 
            // treeView_FileSystem
            // 
            treeView_FileSystem.Location = new Point(0, 0);
            treeView_FileSystem.Name = "treeView_FileSystem";
            treeView_FileSystem.Size = new Size(456, 450);
            treeView_FileSystem.TabIndex = 0;
            // 
            // button_LookUp
            // 
            button_LookUp.Location = new Point(218, 232);
            button_LookUp.Name = "button_LookUp";
            button_LookUp.Size = new Size(75, 23);
            button_LookUp.TabIndex = 2;
            button_LookUp.Text = "Look Up";
            button_LookUp.UseVisualStyleBackColor = true;
            button_LookUp.Click += button_LookUp_Click;
            // 
            // button_Update
            // 
            button_Update.Location = new Point(66, 232);
            button_Update.Name = "button_Update";
            button_Update.Size = new Size(75, 23);
            button_Update.TabIndex = 3;
            button_Update.Text = "Update";
            button_Update.UseVisualStyleBackColor = true;
            button_Update.Click += button_Update_Click;
            // 
            // textBox_TargetIP
            // 
            textBox_TargetIP.Location = new Point(31, 93);
            textBox_TargetIP.Name = "textBox_TargetIP";
            textBox_TargetIP.Size = new Size(100, 23);
            textBox_TargetIP.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox_TargetIP);
            Controls.Add(button_Update);
            Controls.Add(button_LookUp);
            Controls.Add(panel1);
            Controls.Add(comboBox_NetworkInterface);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox_NetworkInterface;
        private Panel panel1;
        private TreeView treeView_FileSystem;
        private Button button_LookUp;
        private Button button_Update;
        private TextBox textBox_TargetIP;
    }
}
