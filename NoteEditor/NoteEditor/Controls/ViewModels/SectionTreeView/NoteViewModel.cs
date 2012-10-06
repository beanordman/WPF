using NoteEditor.Controls.Models;

namespace NoteEditor.Controls.ViewModels.SectionTreeView
{
    public class NoteViewModel
    {
        private readonly Note _note;

        public NoteViewModel()
        {
            _note = new Note();
        }

        public NoteViewModel(Note note)
        {
            _note = note;
        }

        public string Title
        {
            get { return _note.Title; } 
            set { _note.Title = value; }
        }

        public string Text
        {
            get { return _note.Text; }
            set { _note.Text = value; }
        }
    }
}
