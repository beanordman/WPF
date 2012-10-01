using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteEditor.Controls.Models
{
    class SectionCollection
    {
        public SectionCollection()
        {
        }

        public IEnumerable<Section> Sections
        {
            get { return SectionsEnum; }
        }

        private IEnumerable<Section> SectionsEnum
        {
            get { return SectionInitializer.Initialize(); }
        }
    }
}
