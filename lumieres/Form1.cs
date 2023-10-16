using System.Drawing.Drawing2D;

namespace lumieres
{
    public partial class Form1 : Form
    {
        private List<Button> boutons = new List<Button>();
        private List<int> sequence = new List<int>();
        private int etape = 0;
        private bool joueurEnTrainDeJouer = false;
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            InitialiserBoutons();
            label2.Text = joueurEnTrainDeJouer.ToString();
        }
        private void InitialiserBoutons()
        {
            // Ajoutez vos boutons ici. Vous pouvez également les créer dynamiquement.
            boutons.Add(button1);
            boutons.Add(button2);
            boutons.Add(button3);
            boutons.Add(button4);
            boutons.Add(button5);
            boutons.Add(button6);
            boutons.Add(button7);
            boutons.Add(button8);
            boutons.Add(button9);
        }

        private void JouerTour()
        {
            joueurEnTrainDeJouer = false;
            etape = 0;

            sequence.Clear(); // Efface la séquence précédente

            // Génère neuf indices aléatoires pour la séquence
            for (int i = 0; i < 9; i++)
            {
                sequence.Add(random.Next(0, boutons.Count));
            }

            AfficherSequence();
            label2.Text = joueurEnTrainDeJouer.ToString();

        }

        private void AfficherSequence()
        {
            int vitesse = 0;
            string forme = "";
            joueurEnTrainDeJouer = true;
            if (ch_simple.Checked)
            {
                vitesse = 500;
            }
            else if (ch_rapide.Checked)
            {
                vitesse = 300;
            }
            else if (ch_tresRapide.Checked)
            {
                vitesse = 100;
            }

            if (ch_rond.Checked)
            {
                foreach (var item in boutons)
                {
                    System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                    buttonPath.AddEllipse(0, 0, item.Width, item.Height);
                    item.Region = new Region(buttonPath);

                }
            }
            else if (ch_arrondis.Checked)
            {
                vitesse = 300;
            }
            else if (ch_carre.Checked)
            {
                vitesse = 100;
            }

            foreach (int index in sequence)
            {
                boutons[index].BackColor = System.Drawing.Color.Yellow;
                Application.DoEvents();
                Thread.Sleep(vitesse);
                boutons[index].BackColor = SystemColors.Control;
                Application.DoEvents();
                Thread.Sleep(vitesse);
            }
            joueurEnTrainDeJouer = true;
            label2.Text = joueurEnTrainDeJouer.ToString();

        }



        private void button_Click(object sender, EventArgs e)
        {
            label2.Text = joueurEnTrainDeJouer.ToString();

            if (!joueurEnTrainDeJouer) return;

            Button bouton = (Button)sender;
            int index = boutons.IndexOf(bouton);
            if (index == sequence[etape])
            {
                bouton.BackColor = System.Drawing.Color.Red;
                Application.DoEvents();
                Thread.Sleep(300);
                bouton.BackColor = SystemColors.Control;
                Application.DoEvents();
                Thread.Sleep(300);
                etape++;

                if (etape == sequence.Count)
                {
                    this.Enabled = false;
                    string message = "Vous avez gagné !" + Environment.NewLine + "Voulez vous recommencer depuis le début ?";
                    string title = "Partie terminée";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        sequence.Clear();
                        Application.Restart();
                    }
                    else
                    {
                        this.Enabled = true;
                        joueurEnTrainDeJouer = false;
                    }
                }
            }
            else
            {
                this.Enabled = false;
                string message = "Vous avez perdu ! La séquence était : " + string.Join(", ", sequence) + Environment.NewLine + "Voulez vous recommencer depuis le début ?";
                string title = "Partie terminée";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    sequence.Clear();
                    Application.Restart();
                }
                else
                {
                    this.Enabled = true;
                    joueurEnTrainDeJouer = false;
                }
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            label2.Text = joueurEnTrainDeJouer.ToString();

            if (!joueurEnTrainDeJouer)
            {
                JouerTour();
                buttonStart.Enabled = false;
            }
            foreach (var item in sequence)
            {
                label1.Text += " " + Convert.ToString(item);

            }
        }

        private void btn_restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

