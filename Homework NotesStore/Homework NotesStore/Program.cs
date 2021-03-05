using System;
using System.Collections.Generic;

namespace Homework_NotesStore
{
    class Program
    {
        static void Main(string[] args)
        {
            NotesStore note = new NotesStore(" "," ");
            note.AddNote(note);
            NotesStore note1 = new NotesStore(" ", " ");
            note1.AddNote(note1);
            note1.GetNotes("active");
        }
    }
}
