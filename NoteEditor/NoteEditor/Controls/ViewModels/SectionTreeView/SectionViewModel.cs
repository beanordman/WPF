using NoteEditor.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace NoteEditor.Controls.ViewModels.SectionTreeView
{
    public class SectionViewModel
    {
        private readonly IReadOnlyCollection<NoteViewModel> _notes;

        public SectionViewModel(ISection section)
        {
            if (section != null)
            {
                if (section.Notes != null)
                {
                    _notes = new ReadOnlyCollection<NoteViewModel>(
                        section.Notes.Select(note => new NoteViewModel(note)).ToList()
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
