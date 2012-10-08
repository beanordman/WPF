using Microsoft.VisualStudio.TestTools.UnitTesting;
using NoteEditor.Controls.ViewModels.SectionTreeView;
using System.Collections.Generic;
using System.Linq;
using NoteEditor.Model;
using Rhino.Mocks;

namespace NoteEditor.Tests.ViewModels.SectionsViewModel
{
    [TestClass]
    public class TestSectionViewModel
    {
        [TestMethod]
        public void TestConstruction()
        {
            var stubbedNote1 = MockRepository.GenerateStub<INote>();
            stubbedNote1.Title = "Title1";
            stubbedNote1.Text = "Text1";

            var stubbedNote2 = MockRepository.GenerateStub<INote>();
            stubbedNote2.Title = "Title2";
            stubbedNote2.Text = "Text2";

            var stubbedSection = MockRepository.GenerateStub<ISection>();
            stubbedSection.Title = "Section Title";
            stubbedSection.Stub(x => x.Notes).Return
                (
                    new List<INote>()
                        {
                            stubbedNote1, stubbedNote2
                        }
                );

            var sectionViewModel = new SectionViewModel(stubbedSection);

            Assert.AreEqual("Section Title", sectionViewModel.Title);
            Assert.IsNotNull(sectionViewModel.Notes);
            Assert.AreEqual(2, sectionViewModel.Notes.Count);
            Assert.AreEqual("Title1", stubbedSection.Notes.First().Title);
            Assert.AreEqual("Text1", stubbedSection.Notes.First().Text);
        }
    }
}
