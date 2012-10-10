using System.ComponentModel;
using NoteEditor.Model;

namespace NoteEditor.Controls.ViewModels.SectionTreeView
{
    public class NoteViewModel : INotifyPropertyChanged
    {
        private readonly INote _note;

        public NoteViewModel(INote note)
        {
            _note = note;
        }

        public string Title
        {
            get { return _note.Title; } 
            set
            {
                _note.Title = value;
                OnPropertyChanged("Title");
            }
        }
        
        public string Text
        {
            get { return _note.Text; }
            set
            {
                _note.Text = value;
                OnPropertyChanged("Text");
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
