using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace LExiDocumentsEditor.Model
{
    public abstract class Glyph
    {
        //Draw glyph on control
        protected abstract void Draw(Control control);
        //Insert other glyph into current glyph
        protected abstract void Insert(Glyph glyph);
        //Hit test agains point
        protected abstract bool Intersect(Point point);
    }
}
