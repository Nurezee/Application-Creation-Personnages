using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace EProjet2
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Création du fichier de sauvegarde nommé sauvFich
        /// </summary>
        private String sauvFich = "sauvegarde";
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Chargement du fichier contenant la liste lesPersonnages.
        /// Initialisation de la Biding List
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            btnCreer.Visible = false;

            object obj = Serialise.Recup(sauvFich);

            if(obj != null)
            {
                lesPersonnages = (List<Personnages>)obj;
                bdn();
            }
        }

        //Déclaration des variables

        string nom;
        int vie;
        bool click = false;

        //Déclaration de la liste lesPersonnage.
        //Déclaration de la Biding List sans initialisation.
        
        
        List<Personnages> lesPersonnages = new List<Personnages>();
        BindingList<Personnages> bdnLesPersonnages;


        //Déclaration des modules

        /// <summary>
        /// Création d'un nouveau personnage de la classe héritiaire de Personnages
        /// Ajout du personnage à la liste lesPersonnages
        /// Sauvegarde de la liste dans le fichier sauvFich
        /// </summary>
        public void Creer()
        {
            //Création d'un élément du tableau Personnage
            //Propriétés de la class personnage
            

            Personnages unPersonnage = new Humain(nom, vie);
            lesPersonnages.Add(unPersonnage);

            lesPersonnages.Sort();
            bdn();

            Serialise.Sauve(sauvFich, lesPersonnages);

        }


        /// <summary>
        /// Création Binding List qui contient lesPersonnages.
        /// Liaison entre lstPerso et Binding List.
        /// </summary>
        public void bdn()
        {
            bdnLesPersonnages = new BindingList<Personnages>(lesPersonnages);
            lstPerso.DataSource = bdnLesPersonnages;
        }


        /// <summary>
        /// Mises a jour de la Binding List.
        /// </summary>
        /// <param name="position">Index de la liste qui a été modifié.</param>
        public void MiseAJour(int position)
        {

            bdnLesPersonnages.ResetItem(position);
            Serialise.Sauve(sauvFich, lesPersonnages);
        }

        /// <summary>
        /// Module qui permet d'initialiser l'état de recherche, selon :
        /// - si le bouton rechercher a été cliqué (actif)
        /// - si le bouton terminer LA recherche a été cliqué (inactif).
        /// </summary>
        /// <param name="actif"></param>
        private void ChangerEtatRechercher(bool actif)
        {
            if (actif)
            {
                txtLogin.Enabled = false;
                txtLogin.Text = "";

                nudVie.Enabled = false;
                nudVie.Value = 0;


                btnParLogin.Enabled = true;
                btnParVie.Enabled = true;

                btnCreer.Enabled = false;

                btnModif.Enabled = false;

                btnRechercher.Enabled = false;

                btnTerminerRecherche.Enabled = true;
                btnTerminerRecherche.Visible = true;

            }
            if (!actif)
            {
                txtLogin.Enabled = true;
                txtLogin.Text = "";

                nudVie.Value = 0;

                btnParLogin.Enabled = false;
                txtRechercherLogin.Enabled = false;
                txtRechercherLogin.Text = "";

                btnParVie.Enabled = false;
                txtRechercherVie.Enabled = false;
                txtRechercherVie.Text = "";

                btnModif.Enabled = true;
                btnModif.Focus();

                btnRechercher.Enabled = true;

                btnTerminerRecherche.Enabled = false;
                btnTerminerRecherche.Visible = false;
            }
        }

        /// <summary>
        /// Module qui permet de rechercher un élément de lstPerso grâce aux paramètres
        /// Cela se fait en parcourant les items de la liste lesPersonnages qui contiennent soit :
        /// - le nom recherché
        /// - la vie recherchée.
        /// L'index de l'objet de la liste est mémorisée.
        /// Cet index permet de sélectionner l'item correspondant dans lstPerso
        /// Rappel : Grâce à la Biding list, l'ordre de la liste lesPersonnage est synchronisé à lstPerso.
        /// </summary>
        /// <param name="rechercherLogin"></param>
        /// <param name="rechercherVie"></param>
        private void Rechercher(string rechercherLogin, int rechercherVie)
        {
            if (rechercherLogin != null)
            {
                try
                {

                    int result = lesPersonnages.FindIndex(x => x.getNom().Contains(rechercherLogin));

                    if (result != -1)
                    {
                        lstPerso.SelectedIndex = result;
                    }
                }
                catch
                {

                }
            }
            if (rechercherVie >= 0 && rechercherVie <= 3)
            {
                try
                {
                    int result = lesPersonnages.FindIndex(x => ((Humain)x).getVie().Equals(rechercherVie));

                    if (result != -1)
                    {
                        lstPerso.SelectedIndex = result;
                    }
                }
                catch
                {

                }
            }

        }

        /// <summary>
        /// Terminer les modifications et remettre le formulaire au point de départ.
        /// </summary>
        public void TerminerModif()
        {
            //Réinitialisation des boutons et textes à leur état d'origine.
            //Afin d'initialiser le formulaire à l'étape 1 de la création de personnages.

            //Réinitialisation de l'étape de modification.
            btnTerminer.Visible = false;
            btnTerminer.Enabled = false;

            btnModif.Enabled = true;
            btnModif.Visible = true;

            btnCreer.Enabled = false;

            btnCancel.Enabled = false;
            btnCancel.Visible = false;

            //Initialisation à l'étape login du processus de création de personnages.
            txtLogin.Enabled = true;
            txtLogin.Text = "";
            txtLogin.Focus();

            click = false;
            nudVie.Enabled = false;
            nudVie.Value = 0;

            //Réinitialisation de l'étape de recherche.
            btnParLogin.Enabled = false;
            txtRechercherLogin.Enabled = false;
            txtRechercherLogin.Text = "";

            btnParVie.Enabled = false;
            txtRechercherVie.Enabled = false;
            txtRechercherVie.Text = "";

            btnTerminerRecherche.Enabled = false;
            btnTerminerRecherche.Visible = false;
        }

        /// <summary>
        /// //Rénitialisation complète du formulaire
        /// </summary>
        public void Reinitialiser()
        {
            //Message utilisateur
            DialogResult result = MessageBox.Show("Voulez-vous réinitialiser le formulaire ? ", "Confirmation", MessageBoxButtons.YesNo);
            if ( result == DialogResult.Yes)
            {
                lesPersonnages.Clear();

                //Réinitialisation de la liste bdn et sauvegarde du fichier sauvFich
                bdn();
                
                Serialise.Sauve(sauvFich, lesPersonnages);

                TerminerModif();
                lstPerso_SelectedIndexChanged(null, null);
            }

        }

        //Déclaration des événements.

        /// <summary>
        /// Cliquer sur Entrer pour passer à l'étape suivante du processus de création.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //stockage du texte dans la variable nom
                nom = txtLogin.Text;
                nudVie.Enabled = true;
                btnCreer.Visible = true;
                nudVie.Focus();
            }
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            nudVie.Enabled = false;
            btnCreer.Enabled = false;
        }


        /// <summary>
        /// Cliquer sur Entrer pour passer à l'étape finale du processus de création.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void nudVie_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter && btnTerminer.Enabled == false)
            {
                //Stockage de la valeur numérique dans la variable vie.
                vie = (int)nudVie.Value;

                //Passage à l'étape finale du processus de création.
                btnCreer.Enabled = true;
                btnCreer.Focus();
            }
            else
            {
                nudVie_ValueChanged(null, null);
            }
        }

        /// <summary>
        /// Cette étape ne contribue pas à la création de personnage mais à la modification.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void nudVie_ValueChanged(object sender, EventArgs e)
        {
            //Modification de la valeur numérique vie d'un personnage.
            if (click && lstPerso.SelectedIndex != -1)
            {
                btnTerminer.Enabled = true;
            }
        }

        /// <summary>
        /// Cliquer sur Créer pour finaliser le processus de création.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnCreer_Click(object sender, EventArgs e)
        {
            Creer();

            txtLogin.Text = "";
            txtLogin.Focus();

            nudVie.Value = 0;
            nudVie.Enabled = false;

            btnCreer.Enabled = false;
        }

        private void btnCreer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                btnCreer_Click(null, null);
            }
        }

        /// <summary>
        /// Affichage de l'objet de la liste sélectionné dans txtSelectionPerso.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void lstPerso_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lstPerso.SelectedItem != null)
            {
                txtSelectionPerso.Text = (lstPerso.SelectedItem).ToString();
            }
            
            //Activation du bouton Modifier
            if (lstPerso.Items.Count > 0)
            {
                btnModif.Enabled = true;
                btnRechercher.Enabled = true;
                btnReset.Enabled = true;
            }
            else
            {
                btnModif.Enabled = false;
                btnRechercher.Enabled = false;
                btnReset.Enabled = false;
            }
        }


        /// <summary>
        /// Configuration de l'événement modifier.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnModif_Click(object sender, EventArgs e)
        {
            
            txtLogin.Enabled = false;
            txtLogin.Text = "";

            //Renvoie click pour nudVie_ValueChanged.
            click = true;
            nudVie.Enabled = true;

            //Afin de s'assurer que le bouton créer est désactiver.
            btnCreer.Enabled = false;

            btnModif.Enabled = false;
            btnModif.Visible = false;

            btnTerminer.Visible = true;

            btnCancel.Visible = true;
            btnCancel.Enabled = true;

            lstPerso.Focus();
        }

        /// <summary>
        /// Terminer le processus de modification.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnTerminer_Click(object sender, EventArgs e)
        {
            //Modification de la valeur int vie du personnage[index] (personnagep[k])

            if (txtLogin.Text == "" && txtSelectionPerso.Text != "")
            {
                //Sauvegarde de la valeur numérique nudVie_ValueChanged afin
                //d'apporter les modifications de la variable vie d'un personnage.
                int newVie = (int)nudVie.Value;

                int index = lstPerso.SelectedIndex;

                ((Humain)lesPersonnages[index]).setVie(newVie);

                //Mettre à jour la liste bdn et l'affichage.
                MiseAJour(index);

                //Terminer les modifications.
                TerminerModif();
            }
        }

        /// <summary>
        /// Annuler le processus de modification.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            TerminerModif();
        }

        /// <summary>
        /// Réinitialiser le formulaire
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reinitialiser();
        }

        /// <summary>
        /// Modifier la couleur des éléments contenus dans lstPerso en fonction de leur classe.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstPerso_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            //Récupérer la ligne en cours de dessin.
            try
            {
                string ligne = lstPerso.Items[e.Index].ToString();

                //Récupérer le personnage correspondant.

                Personnages lePersonnage = lesPersonnages[e.Index];

                //Afficher la couleur correspondante.

                Color couleur = lblVie.ForeColor;

                //Définir la couleur du pinceau.

                Brush myBrush = new SolidBrush(couleur);

                e.Graphics.DrawString(ligne, e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
                e.DrawFocusRectangle();
            }
            catch { };

        }

        //Les deux modules qui suivent permettent la recherche d'objet par le login.


        /// <summary>
        /// Initialisation de la recherche par login.
        /// Réinitialisation de la recherche par points de vie.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnParLogin_Click(object sender, EventArgs e)
        {
            txtRechercherVie.Enabled = false;
            txtRechercherVie.Text = "";

            txtRechercherLogin.Enabled = true;
            txtRechercherLogin.Focus();

            btnParLogin.Enabled = false;
        }

        /// <summary>
        /// Rechercher un élément de lstPerso par son login / pseudo / nom uniquement.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtRechercherLogin_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string rechercherLogin = txtRechercherLogin.Text;
                

                Rechercher(rechercherLogin, -1);
            }
            catch { };
        }



        //Les deux modules qui suivent permettent la recherche d'objet par les points de vie.



        /// <summary>
        /// Initialisation de la recherche par points de vie.
        /// Réinitialisation de la recherche par login.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnParVie_Click(object sender, EventArgs e)
        {
            txtRechercherLogin.Enabled = false;
            txtRechercherLogin.Text = "";

            txtRechercherVie.Enabled = true;
            txtRechercherVie.Focus();

            btnParVie.Enabled = false;
        }

        /// <summary>
        /// Rechercher un élément de lstPerso par ses points de vie uniquement.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtRechercherVie_TextChanged(object sender, EventArgs e)
        {

            try
            {
                int rechercherVie = int.Parse(txtRechercherVie.Text);

                Rechercher(null, rechercherVie);
            }
            catch { }
            ;
        }


        //Les deux modules qui suivent permettent d'initialiser / de terminer le processus de recherche.


        /// <summary>
        /// Initialisation de l'état de recherche
        /// Voir Module "ChangerEtatRechercher"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRechercher_Click(object sender, EventArgs e)
        {
            bool actif = true;

            ChangerEtatRechercher(actif);
        }


        private void btnTerminerRecherche_Click(object sender, EventArgs e)
        {
            bool actif = false;

            ChangerEtatRechercher(actif);
        }

    }
}
