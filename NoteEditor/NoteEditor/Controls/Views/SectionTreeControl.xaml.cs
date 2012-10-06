using System.Windows.Controls;
using System.Windows.Input;
using NoteEditor.Controls.ViewModels.SectionTreeView;

namespace NoteEditor.Controls.Views
{
    /// <summary>
    /// Interaction logic for SectionTreeControl.xaml
    /// </summary>
    public partial class SectionTreeControl : UserControl
    {
        public IViewController Controller { get; set; }

        public SectionTreeControl()
        {
            InitializeComponent();
            var sectionsViewModel = new SectionsViewModel(new Models.SectionCollection());
            DataContext = sectionsViewModel;
            SectionsTreeView.ItemsSource = sectionsViewModel.Sections;
                  
        }

        private void SectionsTreeView_SelectedItemChanged(object sender, System.Windows.RoutedPropertyChangedEventArgs<object> e)
        {
            if (Controller != null)
            {
                Controller.SelectedNodeChanged(e.NewValue);
            }
        }

        private void CanExecuteAddSection(object sender, CanExecuteRoutedEventArgs e)
        {
            if (Controller != null)
                Controller.CanExecuteAddSection(sender, e);
        }

        private void CanExecuteAddNote(object sender, CanExecuteRoutedEventArgs e)
        {
            if (Controller != null)
                Controller.CanExecuteAddNote(sender, e);
        }

        private void OnAddSection(object sender, ExecutedRoutedEventArgs e)
        {
            if (Controller != null)
                Controller.OnAddSection(sender, e);
        }

        private void OnAddNote(object sender, ExecutedRoutedEventArgs e)
        {
            if (Controller != null)
                Controller.OnAddNote(sender, e); 
        }

        private void OnDeleteNote(object sender, ExecutedRoutedEventArgs e)
        {
            if (Controller != null)
                Controller.OnDeleteNote(sender, e); 
        }

        private void OnDeleteSection(object sender, ExecutedRoutedEventArgs e)
        {
            if (Controller != null)
                Controller.OnDeleteSection(sender, e);
        }

        private void CanExecuteDeleteNote(object sender, CanExecuteRoutedEventArgs e)
        {
            if (Controller != null)
                Controller.CanExecuteDeleteNote(sender, e); 
        }

        private void CanExecuteDeleteSection(object sender, CanExecuteRoutedEventArgs e)
        {
            if (Controller != null)
                Controller.CanExecuteDeleteSection(sender, e); 
        }
    }
}
