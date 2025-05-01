using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque_V1
{
    internal class Client
    {

        private int num;
        private string nom;
        private string prenom;
        private string adresse;

        private List<Compte> comptes = new List<Compte>();

        public Client(int num, string nom, string prenom, string ad)
        {
            this.num = num;
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = ad;


        }

        public int Num { get => num;  }
        public string Nom { get => nom;  }
        public string Prenom { get => prenom;  }

        
       // On peut faire ça... 
    /*    
        public string getAdresse() 
    {
            return (this.adresse);

        }

        public void setAdresse(string nouvelleAdresse)
        {

            this.adresse =nouvelleAdresse;
        }
*/

        // ou ça

        public string Adresse { get => adresse; set => adresse = value; }


        public string Description
        {
            get
            {
                return num + "  " +nom + " " + prenom + " "+ adresse;
            }

        }

        public override string ToString()
        {

            return (num + "  " + nom + " " + prenom + " " + adresse);
        }

        public  string afficher()
        {

            return (num + "  " + nom + " " + prenom + " " + adresse);
        }

        public void ajouterCompte(Compte c)
        {

            this.comptes.Add(c);    
        }

    }

}

