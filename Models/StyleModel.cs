using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar.Models
{
    interface IStylePanel
    {
        void Slide_LeftToRight(Panel panel,float speed);
        void Slide_RightToLeft(Panel panel,float speed);
        void Fade_in(Panel panel, float speed);
        void Fade_out(Panel panel, float speed);
        void Ease_in(Panel panel, float speed);
        void Ease_out(Panel panel, float speed);
    }
    interface IStyleButton
    {
        void Slide_LeftToRight(Button button, float speed);
        void Slide_RightToLeft(Button button, float speed);
        void Fade_in(Button button, float speed);
        void Fade_out(Button button, float speed);
        void Ease_in(Button button, float speed);
        void Ease_out(Button button, float speed);
    }
    interface IStyleLabel
    {
        void Slide_LeftToRight(Label label, float speed);
        void Slide_RightToLeft(Label label, float speed);
        void Fade_in(Label label, float speed);
        void Fade_out(Label label, float speed);
        void Ease_in(Label label, float speed);
        void Ease_out(Label label, float speed);
    }

    public class StyleModel//:IStylePanel,IStyleLabel,IStyleButton
    {

    }
}
