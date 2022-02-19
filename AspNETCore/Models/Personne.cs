using System.Collections.Generic;

namespace AspNETCore.Models
{
    public class Personne
    {

        private int id;
        private string nom;
        private string prenom;
        private string telephone;
        private int counter = 0;
        public static List<Personne> Liste = new List<Personne> { new Personne() { Nom = "Toto", Prenom = "Titi", Telephone = "0604050708" }, new Personne() { Nom = "Tutu", Prenom = "Tata", Telephone = "0604053774" }
    };
    public Personne()
        {
            Id = ++counter;
        }

        public Personne(string nom, string prenom, string telephone): this ()
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Telephone = telephone;
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public int Counter { get => counter; }

        public static List<Personne> GetPersonne()
        {
            return Liste;
        }

        public static Personne GetPersonneById(int Id)
        {
            return Liste[Id-1];
        }
    }
}
