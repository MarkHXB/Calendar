using Calendar.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarLibrary.Models
{
    public class FileSystemModel
    {
        #region Properties

        public string AlternativeFileLocation = @"C:\Users\bakon\OneDrive\Asztali gép\Infó\C#\Calendar\User\";
        public string[] ReadableFileTypes { get; set; } = new string[]{ ".txt" };

        #endregion

        #region Functions

        public string ReadFile(string Username)
        {
            //UserInformationModel User = new UserInformationModel();
            string t = "";
            try
            {
                t = File.ReadAllText(AlternativeFileLocation);
                
            }
            catch (Exception x)
            {
                LogModel.Error currErr = new LogModel.Error(x.Message);
            }

           

            return t;
        }

        public void WriteFile(string FileName,UserInformationModel Content)
        {
            try
            {
                using(StreamWriter sw=new StreamWriter(FileName))
                {
                    sw.WriteLine(Content.Username);
                    sw.WriteLine(Content.AlarmPerDay);
                    sw.WriteLine(Content.TemplateColor);

                    sw.Close();
                }
            }
            catch (Exception x)
            {
                LogModel.Error currErr = new LogModel.Error(x.Message);
            }
        }

        #endregion

        #region Constructors

        #endregion

        #region 
        #endregion
    }
}
