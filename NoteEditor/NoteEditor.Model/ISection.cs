using System.Collections.Generic;

namespace NoteEditor.Model
{
    public interface ISection
    {
        string Title { get; set; }
        IEnumerable<INote> Notes { get; }
    }
}
