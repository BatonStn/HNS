namespace HNI_TPmoyennes;

class Classe
{
    public string nomClasse;
    public List<Eleve> eleves;
    public List<string> matieres;
    public Classe(string nom)
    {
        nomClasse = nom;
        eleves = new List<Eleve>();
        matieres = new List<string>();
    }

    public void AjouterEleve(string prenom, string nom)
    {
        eleves.Add(new Eleve(prenom, nom));
    }

    public void AjouterMatiere(string m)
    {
        matieres.Add(m);
    }

    public string MoyenneMatiere(int m)
    {
        return MoyenneMatiereCalcul(m).ToString("0.00");
    }

    public float MoyenneMatiereCalcul(int m)
    {
        float sumMatieres = 0;

        foreach (Eleve eleve in eleves)
        {
            sumMatieres += eleve.MoyenneMatiereCalcul(m);
        }

        return sumMatieres/eleves.Count;
    }

    public string MoyenneGeneral()
    {
        return MoyenneGeneralCalcul().ToString("0.00");
    }

    public float MoyenneGeneralCalcul()
    {
        float sumMatieres = 0;
        int nbMatieres = 0;

        for (int i = 0; i < 10; i++)
        {
            float curMatiere = MoyenneMatiereCalcul(i);

            if (curMatiere == 0) break;
            else
            {
                sumMatieres += curMatiere;
                nbMatieres++;
            }
        }

        return sumMatieres / nbMatieres;
    }
}
