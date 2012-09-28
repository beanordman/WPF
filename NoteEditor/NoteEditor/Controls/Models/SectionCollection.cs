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
            //get { return new ReadOnlyCollection<Section>(SectionsEnum.ToList()); }
            get { return SectionsEnum; }
        }

        private IEnumerable<Section> SectionsEnum
        {
            //get { return SectionInitializer.Initialize(); }
            get
            {
                yield return new Section() {Title = "1" };
                yield return new Section() {Title = "2" };
                yield return new Section() {Title = "3" };
                yield return new Section() {Title = "4" };
            }
        }
    }
}
