using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalendarLibrary.Models;
using CalendarLibrary.Models.Settings;
using Forms.Form1;
using static System.Net.WebRequestMethods;

namespace CalendarUI.Forms
{
    public partial class Settings : Form
    {
        public static UserInformationModel GlobalSettings=null;
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            #region Application Icon

            Form1.App_Icon.Icon = null;
            Form1.App_Icon.Dispose();
            Application.DoEvents();

            #endregion

            Application.Exit();
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        public static UserInformationModel LoadSettings()
        {
            UserInformationModel Model = new UserInformationModel();
            FileSystemModel File = new FileSystemModel();

            try
            {
                var files = Directory.GetFiles(File.AlternativeFileLocation, "*.txt*", SearchOption.AllDirectories);

                foreach (var file in files)
                {
                    if (Path.GetFileName(file) == "GlobalSettings.txt")
                    {
                        int index = 0;
                        using (StreamReader sr = new StreamReader(file,Encoding.Default))
                        {
                            while (!sr.EndOfStream)
                            {
                                string row = sr.ReadLine();

                                if (index == 0) { Model.Username = row; }
                                else if (index == 1) { Model.AlarmPerDay = Convert.ToInt32(row); }
                                else if (index == 2) {Color color=Color.FromName(row); Model.TemplateColor = color; }

                                index++;
                            }
                        }
                    }
                }

            }
            catch (Exception x)
            {

            }

            return Model;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (SettingsModel.CheckIntegration(usernameTxtBox, alarmPerDayBox, colorBox))
            //{
            FileSystemModel FileS = new FileSystemModel();



            string _username = usernameTxtBox.Text;
            int _alarm = Convert.ToInt32(alarmPerDayBox.Text);
            string _color = colorBox.Text;

            try
            {
                var files = Directory.GetFiles(FileS.AlternativeFileLocation, "*.txt*", SearchOption.AllDirectories);

                foreach (var file in files)
                {
                    if (Path.GetFileName(file) == "GlobalSettings.txt")
                    {
                        System.IO.File.Delete(file);

                        using (StreamWriter sw = new StreamWriter(file))
                        {
                            sw.WriteLine(_username);
                            sw.WriteLine(_alarm);
                            sw.WriteLine(_color);

                            sw.Close();
                        }
                    }
                }

            }
            catch (Exception x)
            {

            }
            this.Hide();

            Form1 form = new Form1();

            form.Show();

            //}
            // else
            // {

            //kezdje újra
            //
            //  }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 form = new Form1();

            form.Show();
        }
    }
}
