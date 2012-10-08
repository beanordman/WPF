using Microsoft.VisualStudio.TestTools.UnitTesting;
using NoteEditor.Model.Xml;
using System.IO;
using System.Xml.Serialization;

namespace NoteEditor.Model.Tests.Xml
{
    [TestClass]
    public class TestNoteEditor_Model
    {
        [TestMethod]
        public void TestDeserialize()
        {
            var serializer = new XmlSerializer(typeof(Sections));
            Sections sections;

            using (var reader = new StringReader(Constants.TestXml))
            {
                sections = (Sections)serializer.Deserialize(reader);
            }

            Assert.IsNotNull(sections);
            Assert.AreEqual(3, sections.Items.Length);

            var section1 = sections.Items[0];
            Assert.AreEqual("Section1", section1.Title);

            Assert.AreEqual("Note1", section1.Note[0].Title);
            Assert.AreEqual("Note1 Text", section1.Note[0].Value);
        }
    }
}
