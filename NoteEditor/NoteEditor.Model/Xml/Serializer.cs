using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NoteEditor.Model.Xml
{
    public class Serializer
    {
        static public IEnumerable<ISection> Load(Stream xmlStream)
        {
            var serializer = new XmlSerializer(typeof(Sections));
            var sections = (Sections)serializer.Deserialize(xmlStream);

            return Load(sections);
        }

        static public IEnumerable<ISection> Load(TextReader reader)
        {
            var serializer = new XmlSerializer(typeof(Sections));
            var sections = (Sections)serializer.Deserialize(reader);

            return Load(sections);
        }

        static protected IEnumerable<ISection> Load(Sections sections)
        {
            var sectionsList = new List<ISection>();

            foreach (var xmlSection in sections.Items)
            {
                sectionsList.Add(new Section(xmlSection));
            }

            return sectionsList;              
        }
    }
}
