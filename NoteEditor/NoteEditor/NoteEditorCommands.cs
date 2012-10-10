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
        public static readonly RoutedUICommand AddSectionCommand = new RoutedUICommand("Add Section", "AddSectionCommand", typeof(SectionTreeControl));
        public static readonly RoutedUICommand AddNoteCommand = new RoutedUICommand("Add Note", "AddNoteCommand", typeof(SectionTreeControl));
        public static readonly RoutedUICommand DeleteSectionCommand = new RoutedUICommand("Delete Section", "DeleteSectionCommand", typeof(SectionTreeControl));
        public static readonly RoutedUICommand DeleteNoteCommand = new RoutedUICommand("Delete Note", "DeleteNoteCommand", typeof(SectionTreeControl));
        public static readonly RoutedUICommand RenameCommand = new RoutedUICommand("Rename", "RenameCommand", typeof(SectionTreeControl));
    }
}
