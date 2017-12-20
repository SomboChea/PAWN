using Bunifu.Framework.UI;
using DataConnection;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

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
        /// This is A function Use to Upload Photo into Specific Directory
        /// </summary>
        /// <param name="filepath">Original full file path</param>
        /// <param name="Directory_Path">Directory to Copy file into</param>
        /// <returns>Return a name and extension of Image in Directory_path</returns>
        public static string Upload_Photo(string filepath, string Directory_Path)
        {
            string[] filesplit = filepath.Split('\\');
            string filename = filesplit[filesplit.Length-1];
            string imgpath = Directory_Path + filename;


            if (!Directory.Exists(Directory_Path))
            {
                Directory.CreateDirectory(Directory_Path);
            }

            if (File.Exists(imgpath))
            {
                DialogResult diag = MessageBox.Show("File : \n" + filepath + Environment.NewLine + " is Already Exist ! \nDo you want to Replace file" + Environment.NewLine + "\n\nYes : Replace File" + Environment.NewLine + "No : Auto Rename file" + Environment.NewLine + "Cancel : Abort", "File Exist", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                for (int i = 1; File.Exists(imgpath); i++)
                {
                    if (diag == DialogResult.Yes)
                    {
                        File.Delete(imgpath);
                        break;
                    }
                    else if (diag == DialogResult.No)
                    {
                        imgpath = Directory_Path + filename.Split('.')[0] + "-" + i + "." + filename.Split('.')[filename.Split('.').Length - 1];
                    }
                    else
                    {
                        return "";
                    }
                }
            }
            File.Copy(filepath, imgpath);

            return filename;
        }

        /// <summary>
        /// Use For set Redbox around TextBox , Combobox.
        /// By Create Label with Backcolor
        /// </summary>
        /// <param name="control">Textbox or ComboBox</param>
        public static void SetRedbox(Control control, Control main)
        {
            if (control is BunifuMetroTextbox)
            {
                BunifuMetroTextbox box = (BunifuMetroTextbox)control;
                box.BorderColorFocused = Color.Red;
                box.BorderColorIdle = Color.Red;
                box.BorderColorMouseHover = Color.Red;
                control = box;
                main.Controls.Add(box);
                return;
            }
            Label Redbox = new Label();
            Redbox.Size = new System.Drawing.Size(control.Width + 4, control.Height + 4);
            Redbox.Location = new System.Drawing.Point(control.Location.X - 2, control.Location.Y - 2);
            Redbox.BackColor = Color.Red;
            Redbox.Tag = "remove";
            main.Controls.Add(Redbox);
        }

        /// <summary>
        /// Use For CheckRequirement if Text is null or not
        /// </summary>
        /// <param name="controls">instance of TextBox or ComboBox that can get text</param>
        /// <returns>True: No problem , False: Have null</returns>
        public static Boolean CheckRequirement(Control main, Control[] requirement)
        {
            bool check = true;

            foreach (Control ctrl in requirement)
                if (ctrl.Text.Equals(""))
                {
                    SetRedbox(ctrl, main);
                    check = false;
                }

            return check;
        }

        public static bool CheckDouble(Control main,params Control[] Controls)
        {
            bool check = true;
            double d = 0 ;
            foreach(Control ctrl in Controls)
            {
                if (!double.TryParse(ctrl.Text,out d)){
                    check = false;
                }
            }
            return check;
        }

        /// <summary>
        /// use for clear all redbox around Textbox or Combobox for UserControl
        /// </summary>
        /// <param name="uc"> The Container of Control</param>
        public static void ClearRedbox(Control uc)
        {
            foreach (Control control in uc.Controls)
            {
                try
                {
                    if (control.Tag.Equals("remove"))
                        control.Visible = false;
                }
                catch (Exception) { }
            }
            foreach (Control control in uc.Controls)
            {
                try
                {
                    if (control.Tag.Equals("remove"))
                        uc.Controls.Remove(control);
                }
                catch (Exception) { }
            }
            if (uc is BunifuMetroTextbox)
            {
                BunifuMetroTextbox box = (BunifuMetroTextbox)uc;
                box.BorderColorFocused = Color.Black;
                box.BorderColorIdle = Color.Black;
                box.BorderColorMouseHover = Color.Black;
                uc = box;
            }
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
        public static void FillCombobox(ComboBox cb, string displaymember, string valuemember, string sql)
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
        public static void FillDatagridview(DataGridView Dg, string sql)
        {
            Dg.DataSource = Connect.GetModel(sql);
        }

        /// <summary>
        /// Use for refresh Language
        /// </summary>
        /// <param name="uc">Current UserControl</param>
        /// <param name="path2">Set custom path</param>
        public static void SetLanguage(UserControl uc, string path2 = null)
        {
            path = path2.Equals(null) ? path : path2;
            json = JObject.Parse(path + SetCurrentLang + ".json");
            foreach (Control ctrl in uc.Controls)
            {
                try
                {
                    ctrl.Text = json[ctrl.Tag].ToString();
                }
                catch (Exception ex)
                {
                    Log.Write(ex.Message);
                }
            }
        }
    }

    /// <summary>
    /// Fullmode { Screen }
    /// </summary>
    public class FullMode
    {
        public static void Fullscreen(Form context)
        {
            context.Width = Screen.PrimaryScreen.Bounds.Width;
            context.Height = Screen.PrimaryScreen.Bounds.Height;
        }

        public static void Fullscreen(Form context, bool workingAreaEnable = false)
        {
            if (workingAreaEnable)
            {
                context.Width = Screen.PrimaryScreen.WorkingArea.Width;
                context.Height = Screen.PrimaryScreen.WorkingArea.Height;
            }
            else
            {
                Fullscreen(context);
            }
        }

        public static void PopUp(Form context)
        {
            context.FormBorderStyle = FormBorderStyle.None;
            context.ShowIcon = false;
            context.ShowInTaskbar = false;
            context.MinimizeBox = false;
            context.MaximizeBox = false;
            context.WindowState = FormWindowState.Normal;
            context.StartPosition = FormStartPosition.CenterScreen;
            context.TopMost = true;
            context.TopLevel = true;
            context.Visible = true;
        }
    }

    /// <summary>
    /// Ini Parser
    /// </summary>
    public class INIParser
    {
        private string Path;
        private string EXE = Assembly.GetExecutingAssembly().GetName().Name;

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        private static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        private static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

        public INIParser(string IniPath = null)
        {
            Path = new FileInfo(IniPath ?? EXE + ".ini").FullName.ToString();
        }

        public string Read(string Key, string Section = null)
        {
            var RetVal = new StringBuilder(255);
            GetPrivateProfileString(Section ?? EXE, Key, "", RetVal, 255, Path);
            return RetVal.ToString();
        }

        public void Write(string Key, string Value, string Section = null)
        {
            WritePrivateProfileString(Section ?? EXE, Key, Value, Path);
        }

        public void DeleteKey(string Key, string Section = null)
        {
            Write(Key, null, Section ?? EXE);
        }

        public void DeleteSection(string Section = null)
        {
            Write(null, null, Section ?? EXE);
        }

        public bool KeyExists(string Key, string Section = null)
        {
            return Read(Key, Section).Length > 0;
        }
    }

    /// <summary>
    /// Log files
    /// </summary>
    public class Log
    {
        private static string path = "log.txt";

        public static void Write(string text)
        {
            if (!File.Exists(path))
            {
                File.WriteAllText(path, text);
            }
            else
            {
                File.AppendAllText(path, Environment.NewLine + text, Encoding.UTF8);
            }
        }

        public static string Read()
        {
            if (File.Exists(path))
            {
                return File.ReadAllText(path);
            }
            else
            {
                MessageBox.Show("Can't read log file!");
                return null;
            }
        }
    }

    public class App
    {
        public static void Open(Form context)
        {
            context.Show();
            return;
        }

        public static void ExitThread(Form context)
        {
            new ApplicationContext(context).ExitThread();
            return;
        }

        public static void Hide(Form context)
        {
            context.Hide();
            return;
        }

        public static void ExitAll()
        {
            Application.Exit();
            Application.ExitThread();
            return;
        }
    }

    //public class Crypt
    //{
    //    public static string encode(string value)
    //    {
    //        return null;
    //    }

    //    private string _encode(string val, int len)
    //    {
    //        string xcode = null;
    //        char[] ABC = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'X', 'Y', 'Z' };
    //        char[] NUM = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

    //        char[] value = val.ToCharArray();
    //        for (int i = 0; i < len; i++)
    //        {
    //            for(int j=0;j<value.Length;j++)
    //            {
    //                switch(value[j])
    //                {
    //                }
    //            }
    //        }

    //        return xcode;
    //    }
    //}
}