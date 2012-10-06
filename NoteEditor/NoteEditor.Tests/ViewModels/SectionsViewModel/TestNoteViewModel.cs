using Microsoft.VisualStudio.TestTools.UnitTesting;
using NoteEditor.Controls.Models;
using NoteEditor.Controls.ViewModels.SectionTreeView;

namespace NoteEditor.Tests.ViewModels.SectionsViewModel
{
    [TestClass]
    public class TestNoteViewModel
    {
        [TestMethod]
        public void TestConstruction()
        {
            var note = new Note() {Text = "Text", Title = "Title"};
            var noteViewModel = new NoteViewModel(note);

            Assert.AreEqual("Text", noteViewModel.Text);
            Assert.AreEqual("Title", noteViewModel.Title);
        }
    }
}
