using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoteEditor.Controls.Models;

namespace NoteEditor.Controls.ViewModels.SectionTreeView
{
    public class SectionViewModel
    {
        private readonly IReadOnlyCollection<NoteViewModel> _notes;

        public SectionViewModel(Section section)
        {
            if (section != null)
            {
                if (section.Notes != null)
                {
                    _notes = new ReadOnlyCollection<NoteViewModel>(
                        section.Notes.Select(note => new NoteViewModel() { Text = note.Text, Title = note.Title }).ToList()
                        );
                }
                Title = section.Title;
            }
        }

        public IReadOnlyCollection<NoteViewModel> Notes
        {
            get { return _notes; }
        }

        public string Title { get; private set; }
    }
}
