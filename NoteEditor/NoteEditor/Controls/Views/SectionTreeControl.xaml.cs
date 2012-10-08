using System.IO;
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
        internal const string TestXml =
    "<?xml version=\"1.0\" encoding=\"utf-8\" ?>" +
    "<Sections>" +
    "  <Section Title=\"Section1\">" +
    "    <Note Title=\"Note1\">" +
            "Note1 Text" +
        "</Note>" +
        "<Note Title=\"Note2\">" +
            "Note2 Text" +
         "</Note>" +
    "  </Section>" +
    "  <Section Title=\"Section2\">" +
    "    <Note Title=\"Note3\">Note3 Text</Note>" +
    "  </Section>" +
    "  <Section Title=\"Section3\">" +
    "  </Section>" +
    "</Sections>";

        public IViewController Controller { get; set; }

        public SectionTreeControl()
        {
            InitializeComponent();

            using (var reader = new StringReader(TestXml))
            {

                var sectionsViewModel = new SectionsViewModel(Model.Xml.Serializer.Load(reader));
                DataContext = sectionsViewModel;
                SectionsTreeView.ItemsSource = sectionsViewModel.Sections;
            }

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
