using System.Globalization;

namespace NoteEditor.Model.Xml
{
    public class Factory : IFactory
    {
        public INote NewNote(string title, string text)
        {
            return new Note {Title = title, Text = text};
        }

        public ISection NewSection(string title)
        {
            return new Section { Title = title };
        }
    }
}
