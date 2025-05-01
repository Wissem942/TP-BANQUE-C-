using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Banque_V1
{

  
    
    internal class Compte
    {

        private int num;
        private Client proprio;
        private double solde;
        private double decouvert;




        public Compte(int n, Client cl)
        {
            num = n;
            solde = 0;
            proprio = cl;

            cl.ajouterCompte(this);

         
    
        }

        // on peut faire ça
        /*  public int getNum() {
              return num; 
          }
        */

        // ou ça

        public int Numero
        {
            get
            { return num; }
        }



        public string Description
        {
            get
            {
                
                return num + " " + proprio + " Solde : " + solde + " Euros" + " Decouvert : " + decouvert + " Euros"; }

        }


        public Client Proprietaire
        {
            get { return proprio; }
        }

/* on peut utiliser ça

        public double Decouvert { 

get => decouvert;


            set
            {
                if (-value < this.solde)
                {
                    decouvert = value;
                }
            }
            
        }
*/

        /* ou ça :*/
        public string setDecouvertAutorise(double nouveauDecouvert)
        {
            
            if (-nouveauDecouvert<this.solde) { 
                
                this.decouvert = nouveauDecouvert;
                return ("ok");
            
            }

            else
            {
                return("on ne peut pas modifier le découvert, le solde ne le permet pas");
            }


        }

        public void crediter(double mont)
        {
            solde = solde + mont;
        }

        public string debiter(double mont)
        {
            if (solde - mont > -decouvert)
            {
                solde = solde - mont;
                return ("ok");
            }
            else
            {
                return("on ne peut pas débiter, le decouvert est dépassé");
            }
            
        }
    }
}
