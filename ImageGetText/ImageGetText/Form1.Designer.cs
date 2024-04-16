namespace ImageGetText
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
            panel1 = new Panel();
            lblPath = new Label();
            txtPath = new TextBox();
            btnProcess = new Button();
            txtLog = new RichTextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.Indigo;
            panel1.Controls.Add(txtLog);
            panel1.Controls.Add(btnProcess);
            panel1.Controls.Add(txtPath);
            panel1.Controls.Add(lblPath);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 451);
            panel1.TabIndex = 0;
            // 
            // lblPath
            // 
            lblPath.AutoSize = true;
            lblPath.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPath.ForeColor = SystemColors.ButtonHighlight;
            lblPath.Location = new Point(37, 24);
            lblPath.Name = "lblPath";
            lblPath.Size = new Size(53, 25);
            lblPath.TabIndex = 0;
            lblPath.Text = "Path:";
            // 
            // txtPath
            // 
            txtPath.Location = new Point(96, 27);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(546, 23);
            txtPath.TabIndex = 1;
            txtPath.TextChanged += txtPath_TextChanged;
            // 
            // btnProcess
            // 
            btnProcess.BackColor = Color.GhostWhite;
            btnProcess.FlatAppearance.BorderSize = 0;
            btnProcess.FlatStyle = FlatStyle.Popup;
            btnProcess.Location = new Point(658, 27);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(108, 23);
            btnProcess.TabIndex = 2;
            btnProcess.Text = "Start";
            btnProcess.UseVisualStyleBackColor = false;
            btnProcess.Click += btnProcess_Click;
            // 
            // txtLog
            // 
            txtLog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtLog.Location = new Point(37, 66);
            txtLog.Name = "txtLog";
            txtLog.ScrollBars = RichTextBoxScrollBars.Vertical;
            txtLog.Size = new Size(729, 359);
            txtLog.TabIndex = 3;
            txtLog.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "ImageGetText";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtPath;
        private Label lblPath;
        private Button btnProcess;
        private RichTextBox txtLog;
    }
}
