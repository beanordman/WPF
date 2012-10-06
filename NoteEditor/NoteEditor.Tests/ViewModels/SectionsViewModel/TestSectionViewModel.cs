using Microsoft.VisualStudio.TestTools.UnitTesting;
using NoteEditor.Controls.Models;
using NoteEditor.Controls.ViewModels.SectionTreeView;
using System.Collections.Generic;
using System.Linq;

namespace NoteEditor.Tests.ViewModels.SectionsViewModel
{
    [TestClass]
    public class TestSectionViewModel
    {
        [TestMethod]
        public void TestConstruction()
        {
            {
                var section = new Section();
                var sectionViewModel = new SectionViewModel(section);

                Assert.IsNull(sectionViewModel.Title);
                Assert.IsNull(sectionViewModel.Notes);
            }

            {
                var section = new Section()
                                  {
                                      Title = "Section Title",
                                      Notes =
                                          new List<Note>
                                              {
                                                  new Note {Title = "Title1", Text = "Text1"},
                                                  new Note {Title = "Title1", Text = "Text1"}
                                              }
                                  };

                var sectionViewModel = new SectionViewModel(section);

                Assert.AreEqual("Section Title", sectionViewModel.Title);
                Assert.IsNotNull(sectionViewModel.Notes);
                Assert.AreEqual(2, sectionViewModel.Notes.Count);
                Assert.AreEqual("Title1", section.Notes.First().Title);
                Assert.AreEqual("Text1", section.Notes.First().Text);
            }
        }
    }
}
