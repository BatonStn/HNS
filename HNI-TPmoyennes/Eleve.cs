namespace HNI_TPmoyennes;

class Eleve
{
    public string prenom;
    public string nom;
    private Note[] notes;

    private int nbNotes;

    public Eleve(string p, string n)
    {
        prenom = p;
        nom = n;
        notes = new Note[200];
        nbNotes = 0;
    }

    public void AjouterNote(Note n)
    {
        notes[nbNotes] = n;
        nbNotes++;
    }
    public string MoyenneMatiere(int m)
    {
        return MoyenneMatiereCalcul(m).ToString("0.00");
    }

    public float MoyenneMatiereCalcul(int m)
    {
        float sum = 0;
        int nbNoteMatiere = 0;

        for (int i = 0; i < nbNotes; i ++)
        {
            if (notes[i].Matiere == m)
            {
                sum += notes[i].NoteValeur;
                nbNoteMatiere++;
            }
        }
        if (nbNoteMatiere > 0) return (sum / nbNoteMatiere);
        else return 0;
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
