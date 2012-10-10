using System.Windows.Input;
using NoteEditor.Controls.ViewModels.SectionTreeView;

namespace NoteEditor
{
    public interface IViewController
    {
        void SelectedNodeChanged(object newNode);

        void OnAddNote(object sender, ExecutedRoutedEventArgs e);
        void OnAddSection(object sender, ExecutedRoutedEventArgs e);
        void OnDeleteNote(object sender, ExecutedRoutedEventArgs e);
        void OnDeleteSection(object sender, ExecutedRoutedEventArgs e);
        void OnRename(object sender, ExecutedRoutedEventArgs e);
        
        void CanExecuteAddNote(object sender, CanExecuteRoutedEventArgs e);
        void CanExecuteAddSection(object sender, CanExecuteRoutedEventArgs e);
        void CanExecuteDeleteNote(object sender, CanExecuteRoutedEventArgs e);
        void CanExecuteDeleteSection(object sender, CanExecuteRoutedEventArgs e);
        void CanExecuteRename(object sender, CanExecuteRoutedEventArgs e);
    }
}
