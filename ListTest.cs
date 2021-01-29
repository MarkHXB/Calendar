using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class ListTest : Form
    {
        static bool[] pressed;
        public ListTest()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Add")
            {
                datesBindingSource.Add(new Dates(1, "Tusday", 2));
            }
        }

        private void ListTest_Load(object sender, EventArgs e)
        {
            datesBindingSource.Add(new Dates(0, "Monday", 1));

            pressed = new bool[this.Controls.OfType<Panel>().ToList().Count];

            setSbPanelsNVisible();
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            panelPressed(button);            
        }

        #region PANEL_HANDLING
        /*********************/
        /*******  TEST  ******/
        /*********************/
        private void panelPressed(Button button)
        {
            List<Panel> panels = this.Controls.OfType<Panel>().ToList();

            panels = panels.OrderBy(x => x.Name).ToList();

            for (int i = 0; i < pressed.Length; i++)
            {
                if (button.Name.Substring(6, 1) == Convert.ToString(i + 1))
                {
                    if (!pressed[i]) { pressed[i] = true; }
                    else { pressed[i] = false; }
                }
            }

            panelVisible(button, panels);
        }
        private void panelVisible(Button button, List<Panel> panels)
        {
            for (int j = 0; j < pressed.Length; j++)
            {
                if (button.Name.Substring(6, 1) == Convert.ToString(j + 1))
                {
                    if (pressed[j])
                    {
                        for (int i = 0; 0 < panels.Count; i++)
                        {
                            if (button.Name.Substring(6, 1) == Convert.ToString(i + 1))
                            {
                                List<Panel> subPanels = panels[i].Controls.OfType<Panel>().ToList();

                                if (subPanels.Count != 0)
                                {
                                    // select subPanel
                                    subPanels = subPanels.OrderBy(x => x.Name).ToList();

                                    for (int x = 0; x < subPanels.Count; x++)
                                    {
                                        subPanels[x].Visible = true;
                                    }
                                }
                                else
                                {
                                    List<Button> sbButtons = panels[i].Controls.OfType<Button>().ToList();
                                    for (int x = 0; x < sbButtons.Count; x++)
                                    {
                                        if (sbButtons[x].Name.Contains("add"))
                                        {
                                            sbButtons[x].Visible = true;
                                        }
                                    }
                                }

                                break;
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; 0 < panels.Count; i++)
                        {
                            if (button.Name.Substring(6, 1) == Convert.ToString(i + 1))
                            {
                                List<Panel> subPanels = panels[i].Controls.OfType<Panel>().ToList();

                                if (subPanels.Count != 0)
                                {
                                    // select subPanel
                                    subPanels = subPanels.OrderBy(x => x.Name).ToList();

                                    for (int x = 0; x < subPanels.Count; x++)
                                    {
                                        subPanels[x].Visible = false;
                                    }
                                }
                                else
                                {
                                    List<Button> sbButtons = panels[i].Controls.OfType<Button>().ToList();
                                    for (int x = 0; x < sbButtons.Count; x++)
                                    {
                                        if (sbButtons[x].Name.Contains("add"))
                                        {
                                            sbButtons[x].Visible = true;
                                        }
                                    }
                                }

                                break;
                            }
                        }
                    }
                }
            }
        }
        /*********************/
        /*******  TEST  ******/
        /*********************/
        #endregion

        #region PANEL_HANDLING_ONLOAD
        private void setSbPanelsNVisible()
        {
            List<Panel> panels = this.Controls.OfType<Panel>().ToList();

            panels = panels.OrderBy(x => x.Name).ToList();

            for (int i = 0; i < panels.Count; i++)
            {
                List<Button> sbButtons = panels[i].Controls.OfType<Button>().ToList();
                for (int x = 0; x < sbButtons.Count; x++)
                {
                    if (sbButtons[x].Name.Contains("add"))
                    {
                        sbButtons[x].Visible = false;
                    }
                }

                List<Panel> sbPanels = panels[i].Controls.OfType<Panel>().ToList();
                for (int x = 0; x < sbPanels.Count; x++)
                {
                    sbPanels[x].Visible = false;
                }
            }
        }
        #endregion
    }
}
