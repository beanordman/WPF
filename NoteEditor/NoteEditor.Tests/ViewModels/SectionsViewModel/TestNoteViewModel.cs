using Microsoft.VisualStudio.TestTools.UnitTesting;
using NoteEditor.Controls.ViewModels.SectionTreeView;
using NoteEditor.Model;
using Rhino.Mocks;


namespace NoteEditor.Tests.ViewModels.SectionsViewModel
{
    [TestClass]
    public class TestNoteViewModel
    {
        [TestMethod]
        public void TestConstruction()
        {
            var stubbedNote = MockRepository.GenerateStub<INote>();
            stubbedNote.Title = "Title";
            stubbedNote.Text = "Text";

            var noteViewModel = new NoteViewModel(stubbedNote);

            Assert.AreEqual("Text", noteViewModel.Text);
            Assert.AreEqual("Title", noteViewModel.Title);
        }
    }
}
