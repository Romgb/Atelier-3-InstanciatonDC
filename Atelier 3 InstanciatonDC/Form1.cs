using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atelier_3_InstanciatonDC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void reponseLignes_TextChanged(object sender, EventArgs e)
        {

            bool resultat = int.TryParse(reponseLignes.Text, out int result);

            if (resultat == false)
            {
                MessageBox.Show("Veuillez entrer un chiffre!", "Erreur!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);                              
            }
            else
            {
                groupBox1.Controls.Clear();
                int x = 0;
                int y = 0;
                int taille = groupBox1.Width / result;

                for (int j = 0; j <= result; j++)
                {
                    for (int i = 0; i <= result; i++)
                    {
                        Button bouton = new Button();
                        bouton.Text = i.ToString();
                        bouton.Size = new System.Drawing.Size(taille, taille);
                        //bouton.Location = new Point(bouton.Width * i, y);
                        bouton.Location = new Point(x, y);
                        groupBox1.Controls.Add(bouton);
                        x += taille;
                        /*for (int j = 0; j <= result; j++)
                        {
                            Button bouton1 = new Button();
                            bouton1.Text = j.ToString();
                            bouton1.Size = new System.Drawing.Size((groupBox1.Height / result), (groupBox1.Height / result));
                            bouton1.Location = new Point(x, bouton1.Height * j);
                            groupBox1.Controls.Add(bouton1);
                        }*/
                    }
                    y += taille;
                    x = 0;
                }
            }
           


        }
    }
}
