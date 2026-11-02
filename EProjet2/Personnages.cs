using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EProjet2
{
    /// <summary>
    /// Création d'une abstract class Personnages.
    /// </summary>
    /// <seealso cref="System.IComparable" />
    [SerializableAttribute]

    
    public abstract class Personnages : IComparable 
    {
        protected String nom;

        /// <summary>
        /// Initialisation du constructeur <see cref="Personnages"/>.
        /// </summary>
        /// <param name="nom">The nom.</param>
        public Personnages(string nom)
        {
            this.nom = nom;
        }

        /// <summary>
        /// Compare l'instance actuelle avec un autre objet du même type et retourne un entier qui indique si l'instance actuelle précède ou suit un autre objet ou se trouve à la même position dans l'ordre de tri.
        /// </summary>
        /// <param name="obj">Objet à comparer à cette instance.</param>
        /// <returns>
        /// Valeur qui indique l'ordre relatif des objets comparés. La valeur de retour a les significations suivantes :
        /// Value
        /// Signification
        /// Inférieure à zéro
        /// Cette instance précède <paramref name="obj" /> dans l'ordre de tri.
        /// Zéro
        /// Cette instance se produit à la même position dans l'ordre de tri que <paramref name="obj" />.
        /// Supérieure à zéro
        /// Cette instance suit <paramref name="obj" /> dans l'ordre de tri.
        /// </returns>
        public int CompareTo(object obj)
        {
            return nom.CompareTo(((Personnages)obj).getNom());
        }

        /// <summary>
        /// Module qui permet d'obtenir le nom d'un personnage.
        /// </summary>
        /// <returns></returns>
        public string getNom()
        {
            return this.nom;
        }

        /// <summary>
        /// Module qui permet d'afficher ces informations dans DataSource
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return this.nom;
        }

        

    }

    /// <summary>
    /// Création de la classe Humain, héritiaire de Personnages.
    /// </summary>
    /// <seealso cref="EProjet2.Personnages" />
    [SerializableAttribute]

    
    public class Humain : Personnages 
    {

        private int vie;

        /// <summary>
        /// Initialisation du constructeur Humain <see cref="Humain"/> ayant pour base les paramètres de Personnages.
        /// </summary>
        /// <param name="nom">The nom.</param>
        /// <param name="vie">The vie.</param>
        public Humain(string nom, int vie) : base(nom)
        {
            this.vie = vie;
        }

        /// <summary>
        /// Module qui permet d'obtenir la vie d'un personnage.
        /// </summary>
        /// <returns></returns>
        public int getVie()
        {
            return this.vie;
        }

        /// <summary>
        /// Module qui permet de modifier la vie d'un personnage.
        /// </summary>
        /// <param name="modifVie">The modif vie.</param>
        public void setVie(int modifVie)
        {
            this.vie = modifVie;
        }

        /// <summary>
        /// Information affichée dans la liste
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return getNom() + " PV : " + getVie();
        }

    }
}
