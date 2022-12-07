namespace Kameng
{
    enum Tone
    {
        A = 220,
        Asharp = 233,
        B = 247,
        C = 262,
        Csharp = 277,
        D = 294,
        Dsharp = 311,
        E = 330,
        F = 349,
        Fsharp = 370,
        G = 392,
        Gsharp = 415,
    }

    struct Note
    {
        public int frequency;
        public int duration;

        public Note(int frequency, int duration)
        {
            this.frequency = frequency;
            this.duration = duration;
        }

        public Note(Tone tone, int duration)
        {
            this.frequency = (int)tone;
            this.duration = duration;
        }

        static public void Play(List<Note> notes)
        {
            notes.ForEach(delegate (Note note)
            {
                Console.Beep(note.frequency, note.duration);
            });
        }

        static public void Play(Note note)
        {
            Console.Beep(note.frequency, note.duration);
        }
    }
}
