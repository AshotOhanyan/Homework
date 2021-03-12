using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_NotesStore
{
    class Note
    {
        private string Name;
        public string name
        {
            set
            {
                if (value == " " || value == string.Empty)
                {
                    throw new Exception("Name cannot be empty.");
                }
                else
                {
                    Name = value;
                }
            }
            get
            {
                return Name;
            }
        }

        private string State;
        public string state
        {
            set
            {
                if (value == "active" || value == "inactive" || value == "compelted")
                {
                    State = value;
                }
                else
                {
                    throw new Exception($"Invalid state {value}");
                }
            }
            get
            {
                return State;
            }
        }

        public DateTime createdTime { get; set; }
    }
}
