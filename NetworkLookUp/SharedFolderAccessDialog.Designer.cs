namespace NetworkLookUp
{
    partial class SharedFolderAccessDialog
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
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            buttonSrcBrowse = new Button();
            buttonDstBrowse = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(39, 92);
            label1.Name = "label1";
            label1.Size = new Size(82, 27);
            label1.TabIndex = 0;
            label1.Text = "Src";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(39, 144);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 1;
            label2.Text = "Dst";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(26, 28);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            // 
            // buttonSrcBrowse
            // 
            buttonSrcBrowse.Location = new Point(406, 96);
            buttonSrcBrowse.Name = "buttonSrcBrowse";
            buttonSrcBrowse.Size = new Size(91, 23);
            buttonSrcBrowse.TabIndex = 3;
            buttonSrcBrowse.Text = "Src Browse";
            buttonSrcBrowse.UseVisualStyleBackColor = true;
            // 
            // buttonDstBrowse
            // 
            buttonDstBrowse.Location = new Point(406, 145);
            buttonDstBrowse.Name = "buttonDstBrowse";
            buttonDstBrowse.Size = new Size(91, 23);
            buttonDstBrowse.TabIndex = 4;
            buttonDstBrowse.Text = "Dst Browse";
            buttonDstBrowse.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(136, 92);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // SharedFolderAccessDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 339);
            Controls.Add(textBox1);
            Controls.Add(buttonDstBrowse);
            Controls.Add(buttonSrcBrowse);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SharedFolderAccessDialog";
            Text = "SharedFolderAccessDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Button buttonSrcBrowse;
        private Button buttonDstBrowse;
        private TextBox textBox1;
    }
}