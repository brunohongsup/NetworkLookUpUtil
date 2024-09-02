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
            label_TargetIP = new Label();
            textBox_UserName = new TextBox();
            label_UserName = new Label();
            label1 = new Label();
            textBox_Password = new TextBox();
            label_Path = new Label();
            textBox_Path = new TextBox();
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
            button_LookUp.Location = new Point(178, 295);
            button_LookUp.Name = "button_LookUp";
            button_LookUp.Size = new Size(75, 23);
            button_LookUp.TabIndex = 2;
            button_LookUp.Text = "Look Up";
            button_LookUp.UseVisualStyleBackColor = true;
            button_LookUp.Click += button_LookUp_Click;
            // 
            // button_Update
            // 
            button_Update.Location = new Point(46, 295);
            button_Update.Name = "button_Update";
            button_Update.Size = new Size(75, 23);
            button_Update.TabIndex = 3;
            button_Update.Text = "Update";
            button_Update.UseVisualStyleBackColor = true;
            button_Update.Click += button_Update_Click;
            // 
            // textBox_TargetIP
            // 
            textBox_TargetIP.Location = new Point(83, 92);
            textBox_TargetIP.Name = "textBox_TargetIP";
            textBox_TargetIP.Size = new Size(100, 23);
            textBox_TargetIP.TabIndex = 4;
            // 
            // label_TargetIP
            // 
            label_TargetIP.AutoSize = true;
            label_TargetIP.BorderStyle = BorderStyle.FixedSingle;
            label_TargetIP.Location = new Point(46, 98);
            label_TargetIP.Name = "label_TargetIP";
            label_TargetIP.Size = new Size(19, 17);
            label_TargetIP.TabIndex = 5;
            label_TargetIP.Text = "IP";
            // 
            // textBox_UserName
            // 
            textBox_UserName.Location = new Point(83, 214);
            textBox_UserName.Name = "textBox_UserName";
            textBox_UserName.Size = new Size(100, 23);
            textBox_UserName.TabIndex = 6;
            // 
            // label_UserName
            // 
            label_UserName.AutoSize = true;
            label_UserName.BorderStyle = BorderStyle.FixedSingle;
            label_UserName.Location = new Point(10, 220);
            label_UserName.Name = "label_UserName";
            label_UserName.Size = new Size(67, 17);
            label_UserName.TabIndex = 7;
            label_UserName.Text = "User Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(10, 252);
            label1.Name = "label1";
            label1.Size = new Size(59, 17);
            label1.TabIndex = 8;
            label1.Text = "Password";
            // 
            // textBox_Password
            // 
            textBox_Password.Location = new Point(83, 246);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(100, 23);
            textBox_Password.TabIndex = 9;
            // 
            // label_Path
            // 
            label_Path.AutoSize = true;
            label_Path.BorderStyle = BorderStyle.FixedSingle;
            label_Path.Location = new Point(32, 159);
            label_Path.Name = "label_Path";
            label_Path.Size = new Size(33, 17);
            label_Path.TabIndex = 10;
            label_Path.Text = "Path";
            // 
            // textBox_Path
            // 
            textBox_Path.Location = new Point(83, 153);
            textBox_Path.Name = "textBox_Path";
            textBox_Path.Size = new Size(100, 23);
            textBox_Path.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox_Path);
            Controls.Add(label_Path);
            Controls.Add(textBox_Password);
            Controls.Add(label1);
            Controls.Add(label_UserName);
            Controls.Add(textBox_UserName);
            Controls.Add(label_TargetIP);
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
        private Label label_TargetIP;
        private TextBox textBox_UserName;
        private Label label_UserName;
        private Label label1;
        private TextBox textBox_Password;
        private Label label_Path;
        private TextBox textBox_Path;
    }
}
