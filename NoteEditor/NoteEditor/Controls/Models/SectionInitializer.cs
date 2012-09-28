using System;
using System.Collections.Generic;

namespace NoteEditor.Controls.Models
{
    class SectionInitializer
    {
        public static IEnumerable<Section> Initialize()
        {
            yield return new Section
                             {
                                 Title = "Section 1",
                                 Notes = new List<Note>
                                             {
                                                 new Note {Title = "Note 1", Text = "Note 1 Text"},
                                                 new Note {Title = "Note 2", Text = "Note 2 Text"}
                                             }
                             };
            yield return new Section
                             {
                                 Title = "Section 2"
                             };
            yield return new Section
                             {
                                 Title = "Section 3"
                             };

        }
    }
}
