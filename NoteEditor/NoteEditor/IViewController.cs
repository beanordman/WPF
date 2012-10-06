using NoteEditor.Controls.ViewModels.SectionTreeView;

namespace NoteEditor
{
    public interface IViewController
    {
        void SelectedNodeChanged(object newNode);
    }
}
