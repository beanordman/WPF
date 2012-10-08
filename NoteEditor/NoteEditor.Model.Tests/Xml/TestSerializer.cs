using Microsoft.VisualStudio.TestTools.UnitTesting;
using NoteEditor.Model.Xml;
using System.IO;
using System.Linq;

namespace NoteEditor.Model.Tests.Xml
{
    [TestClass]
    public class TestSerializer
    {
        [TestMethod]
        public void TestLoad()
        {
            using (var reader = new StringReader(Constants.TestXml))
            {
                var sections = Serializer.Load(reader);

                // Section 1
                var section1 = sections.First(s => s.Title == "Section1");
                Assert.AreEqual("Section1", section1.Title);

                var note1 = section1.Notes.First(n => n.Title == "Note1");
                Assert.AreEqual("Note1", note1.Title);
                Assert.AreEqual("Note1 Text", note1.Text);

                var note2 = section1.Notes.First(n => n.Title == "Note2");
                Assert.AreEqual("Note2", note2.Title);
                Assert.AreEqual("Note2 Text", note2.Text);

                // Section 2
                var section2 = sections.First(s => s.Title == "Section2");
                Assert.AreEqual("Section2", section2.Title);

                var note3 = section2.Notes.First(n => n.Title == "Note3");
                Assert.AreEqual("Note3", note3.Title);
                Assert.AreEqual("Note3 Text", note3.Text);

                // Section 3
                var section3 = sections.First(s => s.Title == "Section3");
                Assert.AreEqual("Section3", section3.Title);

            }
        }
    }
}
