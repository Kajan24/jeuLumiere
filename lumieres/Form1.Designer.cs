namespace lumieres
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            buttonStart = new Button();
            label1 = new Label();
            label2 = new Label();
            grb_style = new GroupBox();
            ch_arrondis = new RadioButton();
            ch_carre = new RadioButton();
            ch_rond = new RadioButton();
            groupBox1 = new GroupBox();
            ch_tresRapide = new RadioButton();
            ch_rapide = new RadioButton();
            ch_simple = new RadioButton();
            btn_quit = new Button();
            btn_restart = new Button();
            grb_style.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Location = new Point(16, 17);
            button1.Name = "button1";
            button1.Size = new Size(130, 127);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.Location = new Point(166, 17);
            button2.Name = "button2";
            button2.Size = new Size(130, 127);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Control;
            button3.Location = new Point(314, 17);
            button3.Name = "button3";
            button3.Size = new Size(130, 127);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Control;
            button4.Location = new Point(16, 150);
            button4.Name = "button4";
            button4.Size = new Size(130, 127);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.Control;
            button5.Location = new Point(166, 150);
            button5.Name = "button5";
            button5.Size = new Size(130, 127);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.Control;
            button6.Location = new Point(314, 150);
            button6.Name = "button6";
            button6.Size = new Size(130, 127);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.Control;
            button7.Location = new Point(16, 283);
            button7.Name = "button7";
            button7.Size = new Size(130, 127);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button_Click;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.Control;
            button8.Location = new Point(166, 283);
            button8.Name = "button8";
            button8.Size = new Size(130, 127);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button_Click;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.Control;
            button9.Location = new Point(314, 283);
            button9.Name = "button9";
            button9.Size = new Size(130, 127);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = false;
            button9.Click += button_Click;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(16, 440);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(186, 55);
            buttonStart.TabIndex = 9;
            buttonStart.Text = "Commencer 🏁";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(450, 222);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 10;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(450, 183);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 11;
            label2.Text = "label2";
            // 
            // grb_style
            // 
            grb_style.Controls.Add(ch_arrondis);
            grb_style.Controls.Add(ch_carre);
            grb_style.Controls.Add(ch_rond);
            grb_style.Location = new Point(450, 265);
            grb_style.Name = "grb_style";
            grb_style.Size = new Size(143, 145);
            grb_style.TabIndex = 12;
            grb_style.TabStop = false;
            grb_style.Text = "Style";
            // 
            // ch_arrondis
            // 
            ch_arrondis.AutoSize = true;
            ch_arrondis.Location = new Point(29, 118);
            ch_arrondis.Name = "ch_arrondis";
            ch_arrondis.Size = new Size(70, 19);
            ch_arrondis.TabIndex = 2;
            ch_arrondis.TabStop = true;
            ch_arrondis.Text = "Arrondis";
            ch_arrondis.UseVisualStyleBackColor = true;
            // 
            // ch_carre
            // 
            ch_carre.AutoSize = true;
            ch_carre.Checked = true;
            ch_carre.Location = new Point(29, 77);
            ch_carre.Name = "ch_carre";
            ch_carre.Size = new Size(82, 19);
            ch_carre.TabIndex = 1;
            ch_carre.TabStop = true;
            ch_carre.Text = "Rectangles";
            ch_carre.UseVisualStyleBackColor = true;
            // 
            // ch_rond
            // 
            ch_rond.AutoSize = true;
            ch_rond.Location = new Point(29, 34);
            ch_rond.Name = "ch_rond";
            ch_rond.Size = new Size(58, 19);
            ch_rond.TabIndex = 0;
            ch_rond.TabStop = true;
            ch_rond.Text = "Ronds";
            ch_rond.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ch_tresRapide);
            groupBox1.Controls.Add(ch_rapide);
            groupBox1.Controls.Add(ch_simple);
            groupBox1.Location = new Point(450, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(143, 141);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Difficulté";
            // 
            // ch_tresRapide
            // 
            ch_tresRapide.AutoSize = true;
            ch_tresRapide.Location = new Point(29, 102);
            ch_tresRapide.Name = "ch_tresRapide";
            ch_tresRapide.Size = new Size(81, 19);
            ch_tresRapide.TabIndex = 2;
            ch_tresRapide.Text = "Très rapide";
            ch_tresRapide.UseVisualStyleBackColor = true;
            // 
            // ch_rapide
            // 
            ch_rapide.AutoSize = true;
            ch_rapide.Location = new Point(29, 63);
            ch_rapide.Name = "ch_rapide";
            ch_rapide.Size = new Size(61, 19);
            ch_rapide.TabIndex = 1;
            ch_rapide.Text = "Rapide";
            ch_rapide.UseVisualStyleBackColor = true;
            // 
            // ch_simple
            // 
            ch_simple.AutoSize = true;
            ch_simple.Checked = true;
            ch_simple.Location = new Point(29, 29);
            ch_simple.Name = "ch_simple";
            ch_simple.Size = new Size(61, 19);
            ch_simple.TabIndex = 0;
            ch_simple.TabStop = true;
            ch_simple.Text = "Simple";
            ch_simple.UseVisualStyleBackColor = true;
            // 
            // btn_quit
            // 
            btn_quit.Location = new Point(407, 440);
            btn_quit.Name = "btn_quit";
            btn_quit.Size = new Size(186, 55);
            btn_quit.TabIndex = 14;
            btn_quit.Text = "Quitter ❌";
            btn_quit.UseVisualStyleBackColor = true;
            btn_quit.Click += btn_quit_Click;
            // 
            // btn_restart
            // 
            btn_restart.Location = new Point(212, 440);
            btn_restart.Name = "btn_restart";
            btn_restart.Size = new Size(186, 55);
            btn_restart.TabIndex = 15;
            btn_restart.Text = "Recommencer 🔄";
            btn_restart.UseVisualStyleBackColor = true;
            btn_restart.Click += btn_restart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 507);
            Controls.Add(btn_restart);
            Controls.Add(btn_quit);
            Controls.Add(groupBox1);
            Controls.Add(grb_style);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonStart);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Jeu des Lumières";
            grb_style.ResumeLayout(false);
            grb_style.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button buttonStart;
        private Label label1;
        private Label label2;
        private GroupBox grb_style;
        private RadioButton ch_arrondis;
        private RadioButton ch_carre;
        private RadioButton ch_rond;
        private GroupBox groupBox1;
        private RadioButton ch_tresRapide;
        private RadioButton ch_rapide;
        private RadioButton ch_simple;
        private Button btn_quit;
        private Button btn_restart;
    }
}

