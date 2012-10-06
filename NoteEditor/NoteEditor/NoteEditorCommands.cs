using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using NoteEditor.Controls.Views;

namespace NoteEditor
{
    public class NoteEditorCommands
    {
        public static readonly RoutedUICommand AddSectionCommand = new RoutedUICommand("Add Section", "AddSectionCommand", typeof(IViewController));
        public static readonly RoutedUICommand AddNoteCommand = new RoutedUICommand("Add Note", "AddNoteCommand", typeof(IViewController));
        public static readonly RoutedUICommand DeleteSectionCommand = new RoutedUICommand("Delete Section", "DeleteSectionCommand", typeof(IViewController));
        public static readonly RoutedUICommand DeleteNoteCommand = new RoutedUICommand("Delete Note", "DeleteNoteCommand", typeof(IViewController));
    }
}
