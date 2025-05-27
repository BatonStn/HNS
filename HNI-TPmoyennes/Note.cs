namespace HNI_TPmoyennes;

// Classes fournies par HNI Institut
class Note
{
    public int Matiere { get; private set; }
    public float NoteValeur { get; private set; }
    public Note(int m, float n)
    {
        Matiere = m;
        NoteValeur = n;
    }
}
