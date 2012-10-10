using System.Windows.Input;
using NoteEditor.Controls.ViewModels.SectionTreeView;
using System;
using System.Windows;
using System.Linq;
using System.Linq.Expressions;
using NoteEditor.Model;

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

        public void OnRename(object sender, ExecutedRoutedEventArgs e)
        {
            if (e.Parameter is SectionViewModel)
            {
                var section = e.Parameter as SectionViewModel;
                section.Title = "Iain was here!!!";
            }
            else if (e.Parameter is NoteViewModel)
            {
                var note = e.Parameter as NoteViewModel;
                note.Title = "A new note title!!!";
            }
        }

        public void CanExecuteAddNote(object sender, CanExecuteRoutedEventArgs e)
        {
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
            e.CanExecute = true;
        }

        public void CanExecuteRename(object sender, CanExecuteRoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
