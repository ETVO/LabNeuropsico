using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using LabNeuropsico.Model;
using LabNeuropsico.Model.Suporte;

namespace LabNeuropsico.Guia
{
    public static class Ajuda
    {

        public static string Guia(string fonte){
            string output = "";

            string line;

            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(fonte + ".txt");

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

            output = output.Replace('\n', '\n');

            return output;
        }

        
    }
}
