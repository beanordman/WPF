using Microsoft.VisualStudio.TestTools.UnitTesting;
using NoteEditor.Controls.ViewModels.SectionTreeView;
using System.Collections.Generic;
using System.Linq;
using NoteEditor.Model;

namespace NoteEditor.Tests.ViewModels.SectionsViewModel
{
    [TestClass]
    public class TestSectionsViewModel
    {
        [TestMethod]
        public void TestConstrucition()
        {
            var sections = new Controls.ViewModels.SectionTreeView.SectionsViewModel(new List<ISection>());

            TestInitialize(sections.Sections);
        }

        public static void TestInitialize(IEnumerable<SectionViewModel> sections)
        {
            Assert.AreEqual(3, sections.Count());

            var section = sections.First(s => s.Title == "Section 1");
            Assert.IsNotNull(section);

            Assert.AreEqual("Note 1 Text", section.Notes.First(n => n.Title == "Note 1").Text);
            Assert.AreEqual("Note 2 Text", section.Notes.First(n => n.Title == "Note 2").Text);

            Assert.IsNotNull(sections.First(s => s.Title == "Section 2"));
            Assert.IsNotNull(sections.First(s => s.Title == "Section 3"));
        }
    }
}
