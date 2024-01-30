namespace ScherSteinPapier
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
            buttonStone = new Button();
            buttonScissors = new Button();
            buttonPaper = new Button();
            labelUserChoice = new Label();
            labelOpponentChoice = new Label();
            labelWinner = new Label();
            buttonFinish = new Button();
            buttonNext = new Button();
            labelRound = new Label();
            labelPlayerName = new Label();
            labelBefindetSich = new Label();
            SuspendLayout();
            // 
            // buttonStone
            // 
            buttonStone.BackColor = Color.LightSkyBlue;
            buttonStone.Font = new Font("Trebuchet MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStone.Location = new Point(475, 340);
            buttonStone.Name = "buttonStone";
            buttonStone.Size = new Size(330, 170);
            buttonStone.TabIndex = 0;
            buttonStone.Text = "Stein";
            buttonStone.UseVisualStyleBackColor = false;
            buttonStone.Click += buttonStone_Click;
            // 
            // buttonScissors
            // 
            buttonScissors.BackColor = Color.FromArgb(255, 128, 128);
            buttonScissors.Font = new Font("Trebuchet MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonScissors.Location = new Point(105, 340);
            buttonScissors.Name = "buttonScissors";
            buttonScissors.Size = new Size(330, 170);
            buttonScissors.TabIndex = 1;
            buttonScissors.Text = "Schere";
            buttonScissors.UseVisualStyleBackColor = false;
            buttonScissors.Click += buttonScissors_Click;
            // 
            // buttonPaper
            // 
            buttonPaper.BackColor = Color.FromArgb(255, 255, 128);
            buttonPaper.Font = new Font("Trebuchet MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPaper.Location = new Point(845, 340);
            buttonPaper.Name = "buttonPaper";
            buttonPaper.Size = new Size(330, 170);
            buttonPaper.TabIndex = 2;
            buttonPaper.Text = "Papier";
            buttonPaper.UseVisualStyleBackColor = false;
            buttonPaper.Click += buttonPaper_Click;
            // 
            // labelUserChoice
            // 
            labelUserChoice.AutoSize = true;
            labelUserChoice.Font = new Font("Trebuchet MS", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelUserChoice.Location = new Point(475, 442);
            labelUserChoice.Name = "labelUserChoice";
            labelUserChoice.Size = new Size(282, 43);
            labelUserChoice.TabIndex = 3;
            labelUserChoice.Text = "labelUserChoice";
            labelUserChoice.Visible = false;
            // 
            // labelOpponentChoice
            // 
            labelOpponentChoice.AutoSize = true;
            labelOpponentChoice.Font = new Font("Trebuchet MS", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelOpponentChoice.Location = new Point(494, 99);
            labelOpponentChoice.Name = "labelOpponentChoice";
            labelOpponentChoice.Size = new Size(369, 43);
            labelOpponentChoice.TabIndex = 4;
            labelOpponentChoice.Text = "labelOpponentChoice";
            labelOpponentChoice.Visible = false;
            // 
            // labelWinner
            // 
            labelWinner.AutoSize = true;
            labelWinner.Font = new Font("Trebuchet MS", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelWinner.Location = new Point(516, 269);
            labelWinner.Name = "labelWinner";
            labelWinner.Size = new Size(216, 43);
            labelWinner.TabIndex = 5;
            labelWinner.Text = "labelWinner";
            labelWinner.Visible = false;
            // 
            // buttonFinish
            // 
            buttonFinish.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFinish.Location = new Point(105, 520);
            buttonFinish.Name = "buttonFinish";
            buttonFinish.Size = new Size(290, 140);
            buttonFinish.TabIndex = 6;
            buttonFinish.Text = "Beenden";
            buttonFinish.UseVisualStyleBackColor = true;
            buttonFinish.Visible = false;
            buttonFinish.Click += buttonFinish_Click;
            // 
            // buttonNext
            // 
            buttonNext.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonNext.Location = new Point(885, 520);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(290, 140);
            buttonNext.TabIndex = 7;
            buttonNext.Text = "Weiter";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Visible = false;
            buttonNext.Click += buttonNext_Click;
            // 
            // labelRound
            // 
            labelRound.AutoSize = true;
            labelRound.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelRound.Location = new Point(469, 64);
            labelRound.Name = "labelRound";
            labelRound.Size = new Size(69, 27);
            labelRound.TabIndex = 8;
            labelRound.Text = "round";
            // 
            // labelPlayerName
            // 
            labelPlayerName.AutoSize = true;
            labelPlayerName.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            labelPlayerName.Location = new Point(105, 64);
            labelPlayerName.Name = "labelPlayerName";
            labelPlayerName.Size = new Size(62, 27);
            labelPlayerName.TabIndex = 9;
            labelPlayerName.Text = "name";
            // 
            // labelBefindetSich
            // 
            labelBefindetSich.AutoSize = true;
            labelBefindetSich.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelBefindetSich.Location = new Point(206, 64);
            labelBefindetSich.Name = "labelBefindetSich";
            labelBefindetSich.Size = new Size(268, 27);
            labelBefindetSich.TabIndex = 10;
            labelBefindetSich.Text = "befindet sich in der Runde";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(labelBefindetSich);
            Controls.Add(labelPlayerName);
            Controls.Add(labelRound);
            Controls.Add(buttonNext);
            Controls.Add(buttonFinish);
            Controls.Add(labelWinner);
            Controls.Add(labelOpponentChoice);
            Controls.Add(labelUserChoice);
            Controls.Add(buttonPaper);
            Controls.Add(buttonScissors);
            Controls.Add(buttonStone);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Schere Stein Papier";
            FormClosing += Form1_Closing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonStone;
        private Button buttonScissors;
        private Button buttonPaper;
        private Label labelUserChoice;
        private Label labelOpponentChoice;
        private Label labelWinner;
        private Button buttonFinish;
        private Button buttonNext;
        private Label labelRound;
        private Label labelPlayerName;
        private Label labelBefindetSich;
    }
}