using System.Collections.Generic;

namespace NoteEditor.Model
{
    public interface ISection
    {
        string Title { get; set; }

        void Add(INote note);
        void Remove(INote note);
        IEnumerable<INote> Notes { get; }
    }
}
