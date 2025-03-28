using System.Drawing;
using System.Windows.Forms;

namespace LobotomyInjector
{
    internal class DraculaStyleRender
    {
        public class DraculaStyleRenderMenu : ToolStripProfessionalRenderer
        {
            public DraculaStyleRenderMenu() : base(new CustomColorTable()) { }
        }

        public class CustomColorTable : ProfessionalColorTable
        {
            //public override Color MenuItemSelected => Color.FromArgb(255, 121, 198);
            public override Color MenuItemSelected => Color.FromArgb(112, 131, 182);
            public override Color MenuItemSelectedGradientBegin => Color.FromArgb(255, 121, 198);
            public override Color MenuItemSelectedGradientEnd => Color.FromArgb(255, 121, 198);
            public override Color MenuItemBorder => Color.FromArgb(68, 71, 90);
            public override Color MenuStripGradientBegin => Color.FromArgb(40, 42, 54);
            public override Color MenuStripGradientEnd => Color.FromArgb(40, 42, 54);
        }
    }
}
