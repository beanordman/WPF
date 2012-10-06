using System.Windows.Controls;
using NoteEditor.Controls.ViewModels.SectionTreeView;

namespace NoteEditor.Controls.Views
{
    /// <summary>
    /// Interaction logic for SectionTreeControl.xaml
    /// </summary>
    public partial class SectionTreeControl : UserControl
    {
        public SectionTreeControl()
        {
            InitializeComponent();
            var s = new SectionsViewModel(new Models.SectionCollection());
            DataContext = s;
        }
    }
}
