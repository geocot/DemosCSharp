namespace DemoSemaine11.Models
{
    public class Arbre
    {
        private int id;
        private String espece;
        private double dhp;
        private double hauteur;

        public Arbre() : this(0, "", 0, 0) { }
        public Arbre(int id, string espece, double DHP, double hauteur)
        {
            this.id = id;
            this.espece = espece;
            this.dhp = DHP;
            this.hauteur = hauteur;
        }

        public int Id { get => id; set => id = value; }
        public string Espece { get => espece; set => espece = value; }
        public double Dhp { get => dhp; set => dhp = value; }
        public double Hauteur { get => hauteur; set => hauteur = value; }

        public override bool Equals(object? obj)
        {
            return obj is Arbre arbre &&
                   id == arbre.id &&
                   espece == arbre.espece &&
                   dhp == arbre.dhp &&
                   hauteur == arbre.hauteur &&
                   Id == arbre.Id &&
                   Espece == arbre.Espece &&
                   Dhp == arbre.Dhp &&
                   Hauteur == arbre.Hauteur;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id, espece, dhp, hauteur, Id, Espece, Dhp, Hauteur);
        }

        public override string ToString()
        {
            return $"Id={id},Espèce={espece},DHP={dhp},Hauteur={hauteur}";
        }

    }

}
