using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabNeuropsico.Model
{
    public static class Util
    {
        private static string title;
        private static string app_name;

        public static string Title { get => title; set => title = value; }
        public static string App_Name { get => app_name; set => app_name = value; }

        static Util()
        {
            Title = "Lab. de Neuropsicologia";
            App_Name = "LabNeuropsico";
        }

        /// <summary>
        /// Shows a Dialog and returns whether what was chosen by the user
        /// </summary>
        /// <param name="message">The query message</param>
        /// <returns></returns>
        public static Boolean Confirm(String message)
        {
            DialogResult result = MessageBox.Show(message, Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Shows a MessageBox
        /// </summary>
        /// <param name="message">The message</param>
        public static void Alert(string message)
        {
            MessageBox.Show(message, Title, MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        /// <summary>
        /// Shows a MessageBox
        /// </summary>
        /// <param name="message">The message</param>
        /// <param name="ico">The icon</param>
        public static void Alert(string message, MessageBoxIcon ico)
        {
            MessageBox.Show(message, Title, MessageBoxButtons.OK, ico);
        }

        /// <summary>
        /// Encrypts a determined string using MD5 algorithm
        /// </summary>
        /// <param name="input">The string to be encrypted</param>
        /// <returns></returns>
        public static string Md5(string input)
        {
            MD5 md5Hash = MD5.Create();

            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString(); // output in MD5 encryption
        }

        /// <summary>
        /// Disposes a determined form
        /// </summary>
        /// <param name="form_name">The name of the form to be disposed (namespace included)</param>
        public static void DisposeForm(string form_name)
        {
            string name;

            if (!form_name.Contains(App_Name))
                form_name = App_Name + "." + form_name;

            List<Form> frms = Application.OpenForms.OfType<Form>().ToList();
            for (int i = 0; i < frms.Count(); i++)
            {
                name = frms[i].CompanyName.ToString() + "." + frms[i].Name.ToString();
                if (name == form_name)
                {
                    frms[i].Dispose();
                }
            }
        }

        /// <summary>
        /// Closes and disposes every open form (ends application)
        /// </summary>
        public static void DisposeAllForms()
        {
            List<Form> frms = Application.OpenForms.OfType<Form>().ToList();
            for (int i = 0; i < frms.Count(); i++)
            {
                frms[i].Dispose();
            }
        }

        /// <summary>
        /// Shows every open form
        /// </summary>
        public static void ShowOpenForms()
        {
            string name = "";
            string output = "";

            List<Form> frms = Application.OpenForms.OfType<Form>().ToList();
            for (int i = 0; i < frms.Count(); i++)
            {
                name = frms[i].CompanyName.ToString() + "." + frms[i].Name.ToString();

                Alert(name);
            }
        }


        public static void CleanFields(ICollection controls)
        {
            List<ComboBox> cmbs = new List<ComboBox>();

            List<TextBox> txts = new List<TextBox>();

            List<NumericUpDown> nums = new List<NumericUpDown>();

            List<DateTimePicker> dates = new List<DateTimePicker>();

            foreach (Control con in controls)
            {
                if (con is ComboBox)
                {
                    cmbs.Add(con as ComboBox);
                }
                else if (con is TextBox)
                {
                    txts.Add(con as TextBox);
                }
                else if (con is NumericUpDown)
                {
                    nums.Add(con as NumericUpDown);
                }
                else if (con is DateTimePicker)
                {
                    dates.Add(con as DateTimePicker);
                }
            }

            foreach (ComboBox cmb in cmbs)
            {
                cmb.SelectedIndex = -1;
            }

            foreach (TextBox txt in txts)
            {
                txt.Text = "";
            }

            foreach (NumericUpDown num in nums)
            {
                num.Value = num.Value;
            }

            foreach (DateTimePicker date in dates)
            {
                date.Value = date.MaxDate;
            }
        }

        public static bool FieldsEmpty(ICollection cons)
        {

            ComboBox cmb = new ComboBox();
            TextBox txt = new TextBox();
            NumericUpDown num = new NumericUpDown();
            DateTimePicker date = new DateTimePicker();

            foreach (Control con in cons)
            {
                if (con is ComboBox)
                {
                    cmb = con as ComboBox;
                    if (cmb.SelectedIndex != -1)
                    {
                        return false;
                    }
                }
                else if (con is TextBox)
                {
                    txt = con as TextBox;
                    if (txt.Text != "")
                    {
                        return false;
                    }
                }
                else if (con is NumericUpDown)
                {
                    num = con as NumericUpDown;
                    if (num.Value != 0)
                    {
                        return false;
                    }
                }
                else if (con is DateTimePicker)
                {
                    date = con as DateTimePicker;
                    if (date.Value != date.MaxDate)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static void FieldsEnabled(ICollection controls, bool enabled)
        {
            foreach (Control control in controls)
            {
                if (control is ComboBox || control is TextBox 
                    || control is NumericUpDown || control is DateTimePicker)
                {
                    control.Enabled = enabled;
                }
            }
        }

        public static string RawText(string font)
        {
            string output = "";

            string line;

            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(font + ".txt");

                //Read the first line of text
                line = sr.ReadLine();

                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the lie to console window
                    output += line;
                    //Read the next line
                    line = sr.ReadLine();
                }

                //close the file
                sr.Close();
            }
            catch (Exception ex)
            {
                Util.Alert("Algo deu errado!\n\nMais detalhes: " + ex.Message, MessageBoxIcon.Error);
            }
            return output;
        }
    }
}
