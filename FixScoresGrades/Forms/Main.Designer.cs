namespace FixScoresGrades
{
    partial class Main
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
            components = new System.ComponentModel.Container();
            bindingSource1 = new BindingSource(components);
            fixMode = new Button();
            osuDatabasePath = new TextBox();
            label3 = new Label();
            openFile = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // fixMode
            // 
            fixMode.Font = new Font("Yu Gothic UI", 12F);
            fixMode.Location = new Point(192, 40);
            fixMode.Name = "fixMode";
            fixMode.Size = new Size(131, 34);
            fixMode.TabIndex = 4;
            fixMode.Text = "モードを修正する";
            fixMode.UseVisualStyleBackColor = true;
            fixMode.Click += FixMode_Click;
            // 
            // osuDatabasePath
            // 
            osuDatabasePath.Font = new Font("Yu Gothic UI", 12F);
            osuDatabasePath.Location = new Point(129, 5);
            osuDatabasePath.Name = "osuDatabasePath";
            osuDatabasePath.Size = new Size(280, 29);
            osuDatabasePath.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 13F);
            label3.Location = new Point(12, 7);
            label3.Name = "label3";
            label3.Size = new Size(111, 25);
            label3.TabIndex = 5;
            label3.Text = "osu.dbのパス";
            // 
            // openFile
            // 
            openFile.Font = new Font("Yu Gothic UI", 12F);
            openFile.Location = new Point(415, 5);
            openFile.Name = "openFile";
            openFile.Size = new Size(102, 30);
            openFile.TabIndex = 7;
            openFile.Text = "開く";
            openFile.UseVisualStyleBackColor = true;
            openFile.Click += OpenFile_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 81);
            Controls.Add(openFile);
            Controls.Add(osuDatabasePath);
            Controls.Add(label3);
            Controls.Add(fixMode);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Main";
            Text = "FixScoresMode";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource bindingSource1;
        private Button fixMode;
        private TextBox osuDatabasePath;
        private Label label3;
        private Button openFile;
    }
}
