using System.ComponentModel;
using NoteEditor.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace NoteEditor.Controls.ViewModels.SectionTreeView
{
    public class SectionViewModel : INotifyPropertyChanged
    {
        private readonly ObservableCollection<NoteViewModel> _notes;
        private readonly ISection _section ;

        public SectionViewModel(ISection section)
        {
            if (section == null) 
                return;

            _section = section;
            
            if (section.Notes == null) 
                return;

            _notes = new ObservableCollection<NoteViewModel>(
                section.Notes.Select(note => new NoteViewModel(note)).ToList()
                );
        }

        public ObservableCollection<NoteViewModel> Notes
        {
            get { return _notes; }
        }

        public string Title
        {
            get { return _section.Title; } 
            set
            {
                _section.Title = value;
                OnPropertyChanged("Title");
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            var handler = PropertyChanged;

            if (handler == null) 
                return;
            
            handler(this, new PropertyChangedEventArgs(name));
        }
    }
}
