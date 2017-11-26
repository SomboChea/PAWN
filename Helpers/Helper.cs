using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using DataConnection;

namespace Helpers
{
    public class Helper
    {
        /// <summary>
        /// You can set Path of Json Language folder here
        /// Recommend Dont Change it
        /// </summary>
        public static string path = "../../Language/";
        public static JObject json;
        /// <summary>
        /// English or Khmer or Other
        /// </summary>
        public static string SetCurrentLang;
        /// <summary>
        /// Use For set Redbox around TextBox , Combobox. 
        /// By Create Label with Backcolor
        /// </summary>
        /// <param name="control">Textbox or ComboBox</param>
        public static void SetRedbox(Control control)
        {
            Label Redbox = new Label();
            Redbox.Size = new System.Drawing.Size(Redbox.Width + 4, Redbox.Height + 4);
            Redbox.Location = new System.Drawing.Point(Redbox.Location.X - 2, Redbox.Location.Y - 2);
            Redbox.BackColor = Color.Red;
            Redbox.Tag = "remove";
        }
        /// <summary>
        /// Use For CheckRequirement if Text is null or not 
        /// </summary>
        /// <param name="controls">instance of TextBox or ComboBox that can get text</param>
        /// <returns>True: No problem , False: Have null</returns>
        public static Boolean CheckRequirement(Control[] controls)
        {
            bool check = true;
            foreach (Control ctrl in controls)
                if (ctrl.Text.Equals(""))
                {
                    SetRedbox(ctrl);
                    check = false;
                }
            return check;
        }

        /// <summary>
        /// use for clear all redbox around Textbox or Combobox for UserControl
        /// </summary>
        /// <param name="uc">UserControl:(if in Current UserControl You Can put "this")</param>
        public static void ClearRedbox(UserControl uc)
        {
            foreach (Control control in uc.Controls)
                if (control.Tag.Equals("remove"))
                    control.Visible = false;
            foreach (Control control in uc.Controls)
                if (control.Tag.Equals("remove"))
                    uc.Controls.Remove(control);
        }

        /// <summary>
        /// Use for Clear Redbox around Box for Form
        /// </summary>
        /// <param name="frm">Form (if in Current form , You can set "this")</param>
        public static void ClearRedbox(Form frm)
        {
            foreach (Control control in frm.Controls)
                if (control.Tag.Equals("remove"))
                    control.Visible = false;
            foreach (Control control in frm.Controls)
                if (control.Tag.Equals("remove"))
                    frm.Controls.Remove(control);
        }

        /// <summary>
        /// Set the Combobox Language Depend on Files with Extension Json of Path;
        /// Please Set Your Language ComboBox By here
        /// </summary>
        /// <param name="cb">put Language combobox here</param>
        public static void SetLangCombobox(ComboBox cb)
        {
            List<String> Lang = new List<string>();
            DirectoryInfo dir = new DirectoryInfo(path);
            foreach (FileInfo file in dir.GetFiles("*.json"))
                cb.Items.Add(file.Name.Split('.')[0]);
        }
        /// <summary>
        /// Use for Fill item in Combobox from Database
        /// </summary>
        /// <param name="cb">Combobox Control</param>
        /// <param name="displaymember">(ColumnName) items you want to show in combobox</param>
        /// <param name="valuemember">(ColumnName) what you get when selecteditem</param>
        /// <param name="sql">SQL Select Command</param>
        public static void FillCombobox(ComboBox cb, string displaymember, string valuemember,string sql)
        {
            cb.ValueMember = valuemember;
            cb.DisplayMember = displaymember;
            cb.DataSource = Connect.GetModel(sql);
        }
        /// <summary>
        /// Fill Datagridview from database
        /// </summary>
        /// <param name="Dg">Datagridview you want to fill</param>
        /// <param name="sql">SQL Select Command</param>
        public static void FillDatagridview(DataGridView Dg,string sql)
        {
            Dg.DataSource = Connect.GetModel(sql);
        }
 
        /// <summary>
        /// Use for refresh Language
        /// </summary>
        /// <param name="uc">Current UserControl</param>
        /// <param name="path2">Set custom path</param>
        public static void SetLanguage(UserControl uc, string path2=null)
        {
            path = path2.Equals(null)?path:path2;
            json = JObject.Parse(path + SetCurrentLang + ".json");
            foreach (Control ctrl in uc.Controls)
            {
                try
                {
                    ctrl.Text = json[ctrl.Tag].ToString();
                }
                catch (Exception ex) { }
            }
        }
    }
}
