using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

                        // Solution 1 pour couleur damier, un peu plus longue
                        //if ((i % 2 == 0 && j % 2 == 0) || (i % 2 != 0 && j % 2 != 0)) { bouton.BackColor = Color.Black; }
                        //else { bouton.BackColor = Color.White; }

                        //Solution 2 pour couleur damier, plus efficiente
                        if ((i+j) % 2 == 0) { bouton.BackColor = Color.Black; }
                        else { bouton.BackColor = Color.White; }

                        //Ajout des nouveaux boutons
                        bouton.Text = i.ToString();
                        bouton.Size = new System.Drawing.Size(taille, taille);
                        bouton.Location = new Point(x, y);
                        groupBox1.Controls.Add(bouton);
                        x += taille;                      
                    }
                    y += taille;
                    x = 0;
                }

            }



        }
    }
}
