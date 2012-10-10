namespace NoteEditor.Model
{
    public interface IFactory
    {
        INote NewNote(string title, string text);
        ISection NewSection(string title);
    }
}
