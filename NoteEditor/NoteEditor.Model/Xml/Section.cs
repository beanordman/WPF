using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteEditor.Model.Xml
{
    class Section : ISection
    {
        private List<INote> _notes = new List<INote>();

        public Section(SectionsSection xmlSection)
        {
            Title = xmlSection.Title;

            if(xmlSection.Note == null)
            {
                return;
            }

            foreach (var xmlNote in xmlSection.Note)
            {
                var note = new Note {Title = xmlNote.Title, Text = xmlNote.Value};
                _notes.Add(note);
            }
        }

        #region INote implementation

        public string Title { get; set; }
        
        public IEnumerable<INote> Notes
        {
            get { return _notes; }
        }

        #endregion
    }
}
