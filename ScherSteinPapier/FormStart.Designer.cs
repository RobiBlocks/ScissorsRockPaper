namespace ScherSteinPapier
{
    partial class FormStart
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
            buttonStart = new Button();
            buttonBeenden = new Button();
            SuspendLayout();
            // 
            // buttonStart
            // 
            buttonStart.Font = new Font("Trebuchet MS", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStart.Location = new Point(560, 423);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(360, 180);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonBeenden
            // 
            buttonBeenden.Font = new Font("Trebuchet MS", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBeenden.Location = new Point(1020, 423);
            buttonBeenden.Name = "buttonBeenden";
            buttonBeenden.Size = new Size(360, 180);
            buttonBeenden.TabIndex = 1;
            buttonBeenden.Text = "Beenden";
            buttonBeenden.UseVisualStyleBackColor = true;
            buttonBeenden.Click += buttonBeenden_Click;
            // 
            // FormStart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(buttonBeenden);
            Controls.Add(buttonStart);
            Name = "FormStart";
            Text = "FormStart";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonStart;
        private Button buttonBeenden;
    }
}