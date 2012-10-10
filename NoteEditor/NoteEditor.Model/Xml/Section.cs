using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteEditor.Model.Xml
{
    class Section : ISection
    {
        private List<INote> _notes = new List<INote>();

        public Section()
        {
        }

        public Section(SectionsSection xmlSection)
        {
            Title = xmlSection.Title;

            if(xmlSection.Note == null)
            {
                return;
            }

            foreach (var xmlNote in xmlSection.Note)
            {
                _notes.Add(new Note {Title = xmlNote.Title, Text = xmlNote.Value});
            }
        }

        #region ISection implementation

        public string Title { get; set; }
        
        public IEnumerable<INote> Notes
        {
            get { return _notes; }
        }

        public void Add(INote note)
        {
            throw new NotImplementedException();
        }

        public void Remove(INote note)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
