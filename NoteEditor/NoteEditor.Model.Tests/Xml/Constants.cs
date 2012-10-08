using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteEditor.Model.Tests.Xml
{
    sealed class Constants
    {
        internal const string TestXml =
            "<?xml version=\"1.0\" encoding=\"utf-8\" ?>" +
            "<Sections>" +
            "  <Section Title=\"Section1\">" +
            "    <Note Title=\"Note1\">" +
                    "Note1 Text" +
                "</Note>" +
                "<Note Title=\"Note2\">" +
                    "Note2 Text" +
                 "</Note>" +
            "  </Section>" +
            "  <Section Title=\"Section2\">" +
            "    <Note Title=\"Note3\">Note3 Text</Note>" +
            "  </Section>" +
            "  <Section Title=\"Section3\">" +
            "  </Section>" +
            "</Sections>";
    }
}
