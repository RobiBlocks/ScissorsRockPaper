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
            components = new System.ComponentModel.Container();
            buttonStein = new Button();
            buttonSchere = new Button();
            buttonPapier = new Button();
            labelBenutzerWahl = new Label();
            labelGegnerWahl = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            labelGewinner = new Label();
            buttonBeenden = new Button();
            SuspendLayout();
            // 
            // buttonStein
            // 
            buttonStein.BackColor = Color.LightSkyBlue;
            buttonStein.Font = new Font("Trebuchet MS", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStein.Location = new Point(735, 650);
            buttonStein.Name = "buttonStein";
            buttonStein.Size = new Size(450, 220);
            buttonStein.TabIndex = 0;
            buttonStein.Text = "Stein";
            buttonStein.UseVisualStyleBackColor = false;
            buttonStein.Click += buttonStein_Click;
            // 
            // buttonSchere
            // 
            buttonSchere.BackColor = Color.FromArgb(255, 128, 128);
            buttonSchere.Font = new Font("Trebuchet MS", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSchere.Location = new Point(195, 650);
            buttonSchere.Name = "buttonSchere";
            buttonSchere.Size = new Size(450, 220);
            buttonSchere.TabIndex = 1;
            buttonSchere.Text = "Schere";
            buttonSchere.UseVisualStyleBackColor = false;
            buttonSchere.Click += buttonSchere_Click;
            // 
            // buttonPapier
            // 
            buttonPapier.BackColor = Color.FromArgb(255, 255, 128);
            buttonPapier.Font = new Font("Trebuchet MS", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPapier.Location = new Point(1275, 650);
            buttonPapier.Name = "buttonPapier";
            buttonPapier.Size = new Size(450, 220);
            buttonPapier.TabIndex = 2;
            buttonPapier.Text = "Papier";
            buttonPapier.UseVisualStyleBackColor = false;
            buttonPapier.Click += buttonPapier_Click;
            // 
            // labelBenutzerWahl
            // 
            labelBenutzerWahl.AutoSize = true;
            labelBenutzerWahl.Font = new Font("Trebuchet MS", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelBenutzerWahl.Location = new Point(735, 840);
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
            labelGegnerWahl.Location = new Point(735, 140);
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
            labelGewinner.Location = new Point(735, 490);
            labelGewinner.Name = "labelGewinner";
            labelGewinner.Size = new Size(256, 43);
            labelGewinner.TabIndex = 5;
            labelGewinner.Text = "labelGewinner";
            labelGewinner.Visible = false;
            // 
            // buttonBeenden
            // 
            buttonBeenden.Font = new Font("Trebuchet MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBeenden.Location = new Point(1431, 722);
            buttonBeenden.Name = "buttonBeenden";
            buttonBeenden.Size = new Size(367, 188);
            buttonBeenden.TabIndex = 6;
            buttonBeenden.Text = "Beenden";
            buttonBeenden.UseVisualStyleBackColor = true;
            buttonBeenden.Visible = false;
            buttonBeenden.Click += buttonBeenden_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(buttonBeenden);
            Controls.Add(labelGewinner);
            Controls.Add(labelGegnerWahl);
            Controls.Add(labelBenutzerWahl);
            Controls.Add(buttonPapier);
            Controls.Add(buttonSchere);
            Controls.Add(buttonStein);
            Name = "Form1";
            Text = "Schere Stein Papier";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonStein;
        private Button buttonSchere;
        private Button buttonPapier;
        private Label labelBenutzerWahl;
        private Label labelGegnerWahl;
        private System.Windows.Forms.Timer timer1;
        private Label labelGewinner;
        private Button buttonBeenden;
    }
}
