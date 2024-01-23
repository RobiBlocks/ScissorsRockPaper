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
            buttonStein = new Button();
            buttonSchere = new Button();
            buttonPapier = new Button();
            labelBenutzerWahl = new Label();
            labelGegnerWahl = new Label();
            labelGewinner = new Label();
            buttonBeenden = new Button();
            buttonWeiter = new Button();
            labelRunde = new Label();
            labelPlayerName = new Label();
            labelBefindetSich = new Label();
            SuspendLayout();
            // 
            // buttonStein
            // 
            buttonStein.BackColor = Color.LightSkyBlue;
            buttonStein.Font = new Font("Trebuchet MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStein.Location = new Point(475, 340);
            buttonStein.Name = "buttonStein";
            buttonStein.Size = new Size(330, 170);
            buttonStein.TabIndex = 0;
            buttonStein.Text = "Stein";
            buttonStein.UseVisualStyleBackColor = false;
            buttonStein.Click += buttonStein_Click;
            // 
            // buttonSchere
            // 
            buttonSchere.BackColor = Color.FromArgb(255, 128, 128);
            buttonSchere.Font = new Font("Trebuchet MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSchere.Location = new Point(105, 340);
            buttonSchere.Name = "buttonSchere";
            buttonSchere.Size = new Size(330, 170);
            buttonSchere.TabIndex = 1;
            buttonSchere.Text = "Schere";
            buttonSchere.UseVisualStyleBackColor = false;
            buttonSchere.Click += buttonSchere_Click;
            // 
            // buttonPapier
            // 
            buttonPapier.BackColor = Color.FromArgb(255, 255, 128);
            buttonPapier.Font = new Font("Trebuchet MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPapier.Location = new Point(845, 340);
            buttonPapier.Name = "buttonPapier";
            buttonPapier.Size = new Size(330, 170);
            buttonPapier.TabIndex = 2;
            buttonPapier.Text = "Papier";
            buttonPapier.UseVisualStyleBackColor = false;
            buttonPapier.Click += buttonPapier_Click;
            // 
            // labelBenutzerWahl
            // 
            labelBenutzerWahl.AutoSize = true;
            labelBenutzerWahl.Font = new Font("Trebuchet MS", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelBenutzerWahl.Location = new Point(475, 442);
            labelBenutzerWahl.Name = "labelBenutzerWahl";
            labelBenutzerWahl.Size = new Size(328, 43);
            labelBenutzerWahl.TabIndex = 3;
            labelBenutzerWahl.Text = "labelBenutzerWahl";
            labelBenutzerWahl.Visible = false;
            // 
            // labelGegnerWahl
            // 
            labelGegnerWahl.AutoSize = true;
            labelGegnerWahl.Font = new Font("Trebuchet MS", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelGegnerWahl.Location = new Point(494, 99);
            labelGegnerWahl.Name = "labelGegnerWahl";
            labelGegnerWahl.Size = new Size(296, 43);
            labelGegnerWahl.TabIndex = 4;
            labelGegnerWahl.Text = "labelGegnerWahl";
            labelGegnerWahl.Visible = false;
            // 
            // labelGewinner
            // 
            labelGewinner.AutoSize = true;
            labelGewinner.Font = new Font("Trebuchet MS", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelGewinner.Location = new Point(516, 269);
            labelGewinner.Name = "labelGewinner";
            labelGewinner.Size = new Size(256, 43);
            labelGewinner.TabIndex = 5;
            labelGewinner.Text = "labelGewinner";
            labelGewinner.Visible = false;
            // 
            // buttonBeenden
            // 
            buttonBeenden.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBeenden.Location = new Point(105, 520);
            buttonBeenden.Name = "buttonBeenden";
            buttonBeenden.Size = new Size(290, 140);
            buttonBeenden.TabIndex = 6;
            buttonBeenden.Text = "Beenden";
            buttonBeenden.UseVisualStyleBackColor = true;
            buttonBeenden.Visible = false;
            buttonBeenden.Click += buttonBeenden_Click;
            // 
            // buttonWeiter
            // 
            buttonWeiter.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonWeiter.Location = new Point(885, 520);
            buttonWeiter.Name = "buttonWeiter";
            buttonWeiter.Size = new Size(290, 140);
            buttonWeiter.TabIndex = 7;
            buttonWeiter.Text = "Weiter";
            buttonWeiter.UseVisualStyleBackColor = true;
            buttonWeiter.Visible = false;
            buttonWeiter.Click += buttonWeiter_Click;
            // 
            // labelRunde
            // 
            labelRunde.AutoSize = true;
            labelRunde.Location = new Point(381, 64);
            labelRunde.Name = "labelRunde";
            labelRunde.Size = new Size(38, 15);
            labelRunde.TabIndex = 8;
            labelRunde.Text = "runde";
            // 
            // labelPlayerName
            // 
            labelPlayerName.AutoSize = true;
            labelPlayerName.Location = new Point(155, 64);
            labelPlayerName.Name = "labelPlayerName";
            labelPlayerName.Size = new Size(37, 15);
            labelPlayerName.TabIndex = 9;
            labelPlayerName.Text = "name";
            // 
            // labelBefindetSich
            // 
            labelBefindetSich.AutoSize = true;
            labelBefindetSich.Location = new Point(238, 64);
            labelBefindetSich.Name = "labelBefindetSich";
            labelBefindetSich.Size = new Size(108, 15);
            labelBefindetSich.TabIndex = 10;
            labelBefindetSich.Text = "befindet sich in der";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(labelBefindetSich);
            Controls.Add(labelPlayerName);
            Controls.Add(labelRunde);
            Controls.Add(buttonWeiter);
            Controls.Add(buttonBeenden);
            Controls.Add(labelGewinner);
            Controls.Add(labelGegnerWahl);
            Controls.Add(labelBenutzerWahl);
            Controls.Add(buttonPapier);
            Controls.Add(buttonSchere);
            Controls.Add(buttonStein);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Schere Stein Papier";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonStein;
        private Button buttonSchere;
        private Button buttonPapier;
        private Label labelBenutzerWahl;
        private Label labelGegnerWahl;
        private Label labelGewinner;
        private Button buttonBeenden;
        private Button buttonWeiter;
        private Label labelRunde;
        private Label labelPlayerName;
        private Label labelBefindetSich;
    }
}