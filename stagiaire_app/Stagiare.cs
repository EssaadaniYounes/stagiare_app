using System;

namespace stagiaire_app
{
    public class Stagiare
    {
        //Attributs
        public int Num { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateBirth { get; set; }
        public double Moyenne { get; set; }

        //constructors

        //Default Constructor
        public Stagiare()
        {

        }

        //Insitialisation Constructor
        public Stagiare(int num, string nom, string prenom, DateTime dateBirth, double moyenne)
        {
            this.Num = num;
            this.Nom = nom;
            this.Prenom = prenom;
            this.DateBirth = dateBirth;
            this.Moyenne = moyenne;

        }

        //Copy Constructor
        public Stagiare(Stagiare stagiareObj)
        {
            this.Num = stagiareObj.Num;
            this.Nom = stagiareObj.Nom;
            this.Prenom = stagiareObj.Prenom;
            this.DateBirth = stagiareObj.DateBirth;
            this.Moyenne = stagiareObj.Moyenne;
        }

        //initialise Num
        public Stagiare(int num)
        {
            this.Num = num;
        }

        ////Methods
        //toString()
        public override string ToString()
        {
            return "Num Inscription : "+ this.Num + " ,Nom De Stagiare : "
                   + this.Nom + " ,Prenom : "+ this.Prenom + " ,Date Naissance : "
                   + this.DateBirth + " ,De Moyenne : "+this.Moyenne ;
        }
        //nomComplet
        public string nomComplet()
        {
            return this.Nom + "  " + this.Prenom;
        }
    }
}
