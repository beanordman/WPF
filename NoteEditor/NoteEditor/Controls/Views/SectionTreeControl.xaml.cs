using System.Windows.Controls;
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
    }
}
