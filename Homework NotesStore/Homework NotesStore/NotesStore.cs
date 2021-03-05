using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_NotesStore
{
    class NotesStore
    {
         List<NotesStore> collectionOfNotes = new List<NotesStore>();
        public string nameOfNote { get; set; }
        public string stateOfNote { get; set; }
        public DateTime timeForNote { get; set; }

        public NotesStore(string name, string state)
        {
            this.nameOfNote = name;
            this.stateOfNote = state;
           // this.collectionOfNotes = new List<NotesStore>();
        }

        public void AddNote(NotesStore note)
        {
            bool TryAgain = true;
            do
            {

                string state;
                string name;
                Console.WriteLine("Please enter name and state of note.");
                Console.WriteLine("The state for notes can be active, inactive and completed");
                name = Console.ReadLine();
                state = Console.ReadLine();

                if (name == null || name == " ")
                {
                    Console.WriteLine("Name can not be empty!");
                }
                else
                {
                    note.nameOfNote = name;
                    TryAgain = false;
                }
                if (state != "completed" && state != "inactive" && state != "active")
                {
                    Console.WriteLine($"Invalid state {state}");
                }
                else
                {
                    note.stateOfNote = state;
                    TryAgain = false;
                }
            } while (TryAgain == true);

            note.timeForNote = DateTime.Now;
            this.collectionOfNotes.Add(note);
        }

        public List<NotesStore> GetNotes(string state)
        {
            bool TryAgain = false;
            List<NotesStore> NameswithGivenState = new List<NotesStore>();
            do
            {
                
                if (state != "completed" && state != "inactive" && state != "active")
                {
                    Console.WriteLine($"Invalid state {state}");
                    TryAgain = true;
                }       
                
            } while (TryAgain == true);

            for (int i = 0; i < collectionOfNotes.Count; i++)
            {
                if (collectionOfNotes[i].stateOfNote == state)
                {
                    NameswithGivenState.Add(collectionOfNotes[i]);
                    Console.WriteLine(collectionOfNotes[i].nameOfNote);
                }
            }
            
            return NameswithGivenState;
        }

    }
}
