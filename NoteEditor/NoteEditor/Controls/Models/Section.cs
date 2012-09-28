using System;
using System.Collections.Generic;

namespace NoteEditor.Controls.Models
{
    public class Section
    {
        public string Title { get; set; }

        public IEnumerable<Note> Notes { get; set; }
    }
}
