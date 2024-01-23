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
            textBoxName = new TextBox();
            SuspendLayout();
            // 
            // buttonStart
            // 
            buttonStart.Font = new Font("Trebuchet MS", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStart.Location = new Point(225, 392);
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
            buttonBeenden.Location = new Point(677, 392);
            buttonBeenden.Name = "buttonBeenden";
            buttonBeenden.Size = new Size(360, 180);
            buttonBeenden.TabIndex = 1;
            buttonBeenden.Text = "Beenden";
            buttonBeenden.UseVisualStyleBackColor = true;
            buttonBeenden.Click += buttonBeenden_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(412, 113);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(322, 23);
            textBoxName.TabIndex = 9;
            // 
            // FormStart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(textBoxName);
            Controls.Add(buttonBeenden);
            Controls.Add(buttonStart);
            Name = "FormStart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormStart";
            Load += FormStart_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonStart;
        private Button buttonBeenden;
        private TextBox textBoxName;
    }
}