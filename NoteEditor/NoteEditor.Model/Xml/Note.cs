using System.Globalization;

namespace NoteEditor.Model.Xml
{
    class Note : INote
    {
        public string Text { get; set; }
        public string Title { get; set; }
    }
}
