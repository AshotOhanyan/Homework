using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_NotesStore
{
    class NotesStore
    {
        List<Note> notes = new List<Note>();
        public int Count { get => notes.Count; }

        private int num;
        public int ActiveNotes
        {
            get
            {
                return num;
            }
            set
            {

                value = 0;
                for (int i = 0; i < Count; i++)
                {
                    if (notes[i].state == "active")
                    {
                        value++;
                    }
                }
                num = value;
            }
        }
        public int CompletedNotes
        {
            get
            {
                return num;
            }
            set
            {

                value = 0;
                for (int i = 0; i < Count; i++)
                {
                    if (notes[i].state == "completed")
                    {
                        value++;
                    }
                }
                num = value;
            }
        }
        public void AddNote(string state, string name)
        {
            Note note = new Note();
            note.name = name;
            note.state = state;
            note.createdTime = DateTime.Now;
            notes.Add(note);

        }
        public List<string> GetNotes(string state)
        {
            List<string> noteNames = new List<string>();
            for (int i = 0; i < notes.Count; i++)
            {
                if (notes[i].state == state)
                {
                    noteNames.Add(notes[i].name);
                }
            }
            return noteNames;
        }
        public void DeleteNote(string name)
        {
            for (int i = 0; i < notes.Count; i++)
            {
                if (notes[i].name == name)
                {
                    notes.RemoveAt(i);
                }
            }

        }
    }
}
