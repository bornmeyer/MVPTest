namespace MVPTest
{
    partial class MainForm
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
            CreateIdButton = new Button();
            SuspendLayout();
            // 
            // CreateIdButton
            // 
            CreateIdButton.Location = new Point(159, 275);
            CreateIdButton.Name = "CreateIdButton";
            CreateIdButton.Size = new Size(294, 59);
            CreateIdButton.TabIndex = 0;
            CreateIdButton.Text = "Create Id";
            CreateIdButton.UseVisualStyleBackColor = true;
            CreateIdButton.Click += SaveButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CreateIdButton);
            Name = "MainForm";
            Text = "test";
            ResumeLayout(false);
        }

        #endregion

        private Button CreateIdButton;
    }
}
