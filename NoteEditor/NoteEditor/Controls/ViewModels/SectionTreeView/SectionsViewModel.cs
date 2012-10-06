using System.Collections.Generic;
using System.Collections.ObjectModel;
using NoteEditor.Controls.Models;
using System.Linq;

namespace NoteEditor.Controls.ViewModels.SectionTreeView
{
    public class SectionsViewModel
    {
        public SectionsViewModel(SectionCollection sections)
        {
            Sections = new ReadOnlyCollection<SectionViewModel>(
                sections.Sections.Select(section => new SectionViewModel(section)).ToList()
                );
        }

        public IReadOnlyCollection<SectionViewModel> Sections { get; private set; }
    }
}
