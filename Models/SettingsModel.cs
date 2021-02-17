using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarLibrary.Models.Settings
{
    public class SettingsModel
    {
        public static bool CheckIntegration(TextBox txt1,ComboBox cb1,ComboBox cb2)
        {
            bool output = false;
            bool part_1 = false;
            bool part_2 = false;
            bool part_3 = false;

            if (txt1.Text.Length > 2)
            {
                part_1 = true;
            }
            else if (cb1.Text != "")
            {
                part_2 = true;
            }
            else if (cb2.Text != "")
            {
                part_3 = true;
            }

                if (part_1 && part_2 && part_3) { output = true; }

            return output;
        }
    }
}
