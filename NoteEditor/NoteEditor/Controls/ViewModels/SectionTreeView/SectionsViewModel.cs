using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using NoteEditor.Model;

namespace NoteEditor.Controls.ViewModels.SectionTreeView
{
    public class SectionsViewModel
    {
        public SectionsViewModel(IEnumerable<ISection> sections)
        {
            Sections = new ObservableCollection<SectionViewModel>(
                sections.Select(section => new SectionViewModel(section)).ToList()
                );
        }

        public ObservableCollection<SectionViewModel> Sections { get; private set; }
    }
}
