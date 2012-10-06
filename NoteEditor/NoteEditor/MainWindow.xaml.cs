using NoteEditor.Controls.ViewModels.SectionTreeView;
using System;
using System.Windows;

namespace NoteEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IViewController
    {
        public MainWindow()
        {
            InitializeComponent();

            _sectionTreeControl.Controller = this;
        }

        public void SelectedNodeChanged(object node)
        {
            if (node is NoteViewModel)
            {
                _noteControl.DataContext = node as NoteViewModel;
            }
            else
            {
                _noteControl.DataContext = null;
            }
        }
    }
}
