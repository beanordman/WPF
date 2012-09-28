using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using NoteEditor.Controls.Models;

namespace NoteEditor.Controls.Views
{
    /// <summary>
    /// Interaction logic for SectionListControl.xaml
    /// </summary>
    public partial class SectionListControl : UserControl
    {
        public SectionListControl()
        {
            InitializeComponent();

            this.DataContext = SectionInitializer.Initialize();
        }
    }
}
