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
            buttonFinish = new Button();
            textBoxName = new TextBox();
            labelScore = new Label();
            labelName = new Label();
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
            // buttonFinish
            // 
            buttonFinish.Font = new Font("Trebuchet MS", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFinish.Location = new Point(677, 392);
            buttonFinish.Name = "buttonFinish";
            buttonFinish.Size = new Size(360, 180);
            buttonFinish.TabIndex = 1;
            buttonFinish.Text = "Beenden";
            buttonFinish.UseVisualStyleBackColor = true;
            buttonFinish.Click += buttonFinish_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(545, 139);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(292, 23);
            textBoxName.TabIndex = 9;
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.Location = new Point(447, 233);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(40, 15);
            labelScore.TabIndex = 10;
            labelScore.Text = "scores";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(447, 132);
            labelName.Name = "labelName";
            labelName.Size = new Size(93, 35);
            labelName.TabIndex = 11;
            labelName.Text = "Name:";
            // 
            // FormStart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(labelName);
            Controls.Add(labelScore);
            Controls.Add(textBoxName);
            Controls.Add(buttonFinish);
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
        private Button buttonFinish;
        private TextBox textBoxName;
        private Label labelScore;
        private Label labelName;
    }
}