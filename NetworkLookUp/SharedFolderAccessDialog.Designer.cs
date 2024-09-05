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
            textBoxSrcPath = new TextBox();
            textBoxDstPath = new TextBox();
            buttonCopy = new Button();
            listView1 = new ListView();
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
            label2.Location = new Point(39, 389);
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
            buttonSrcBrowse.Location = new Point(430, 96);
            buttonSrcBrowse.Name = "buttonSrcBrowse";
            buttonSrcBrowse.Size = new Size(91, 23);
            buttonSrcBrowse.TabIndex = 3;
            buttonSrcBrowse.Text = "Src Browse";
            buttonSrcBrowse.UseVisualStyleBackColor = true;
            // 
            // buttonDstBrowse
            // 
            buttonDstBrowse.Location = new Point(430, 391);
            buttonDstBrowse.Name = "buttonDstBrowse";
            buttonDstBrowse.Size = new Size(91, 23);
            buttonDstBrowse.TabIndex = 4;
            buttonDstBrowse.Text = "Dst Browse";
            buttonDstBrowse.UseVisualStyleBackColor = true;
            // 
            // textBoxSrcPath
            // 
            textBoxSrcPath.Location = new Point(136, 92);
            textBoxSrcPath.Name = "textBoxSrcPath";
            textBoxSrcPath.Size = new Size(277, 23);
            textBoxSrcPath.TabIndex = 5;
            // 
            // textBoxDstPath
            // 
            textBoxDstPath.Location = new Point(136, 391);
            textBoxDstPath.Name = "textBoxDstPath";
            textBoxDstPath.Size = new Size(277, 23);
            textBoxDstPath.TabIndex = 6;
            // 
            // buttonCopy
            // 
            buttonCopy.Location = new Point(162, 435);
            buttonCopy.Name = "buttonCopy";
            buttonCopy.Size = new Size(194, 64);
            buttonCopy.TabIndex = 7;
            buttonCopy.Text = "Copy";
            buttonCopy.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Location = new Point(39, 134);
            listView1.Name = "listView1";
            listView1.Size = new Size(482, 220);
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // SharedFolderAccessDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 546);
            Controls.Add(listView1);
            Controls.Add(buttonCopy);
            Controls.Add(textBoxDstPath);
            Controls.Add(textBoxSrcPath);
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
        private TextBox textBoxSrcPath;
        private TextBox textBoxDstPath;
        private Button buttonCopy;
        private ListView listView1;
    }
}