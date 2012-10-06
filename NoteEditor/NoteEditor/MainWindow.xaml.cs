using System.Windows.Input;
using NoteEditor.Controls;
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

        public void OnAddNote(object sender, ExecutedRoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void OnDeleteNote(object sender, ExecutedRoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void OnDeleteSection(object sender, ExecutedRoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void OnAddSection(object sender, ExecutedRoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void CanExecuteAddNote(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        public void CanExecuteAddSection(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        public void CanExecuteDeleteNote(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        public void CanExecuteDeleteSection(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
    }
}
