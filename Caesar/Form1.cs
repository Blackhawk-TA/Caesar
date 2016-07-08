using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caesar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void box_input_TextChanged(object sender, EventArgs e)
        {
            execute();
        }

        private void num_key_ValueChanged(object sender, EventArgs e)
        {
            execute();
        }

        private void rad_encrypt_CheckedChanged(object sender, EventArgs e)
        {
            execute();
        }

        public void execute()
        {
            //Variabeln
            char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray(); //Alphabet Array für Ver- / Entschlüsselung
            string text_input = box_input.Text.ToUpper(); //Speichere Eingabe Text in Variable und transferiere alles in Großbuchstaben
            string text_output = ""; //Lege Variable für Ausgabe Text fest
            decimal key = num_key.Value; //Speichere Schlüssel in Variable
            decimal newCharNum = 0; //Variable für Char Nummber die Verschlüsselt bzw Entschlüsselt wurde
            char[] text_chars = text_input.ToCharArray(); //Wandle 'Text Eingabe String'(text_input) in Char Array (Array das aus den Zeichen des Strings besteht) um

            //Für jedes Zeichen in text_chars wird das Zeichen entsprechend des Schlüssels verschoben
            for (int i = 0; i < text_chars.Length; i++)
            {
                char curChar = text_chars[i];
                bool charInArray = Array.Exists(alphabet, element => element == curChar); //Bool ob char im Alphabet ist oder nicht

                if (charInArray) //Char ist im Alphabet vorhanden und wird verschlüsselt
                {
                    int curChar_Index = Array.IndexOf(alphabet, curChar); //Wandle Zeichen aus dem Char Array in Alphabet Nummer um (A=0, B=1, C=2, ...)

                    //Verschiebe Buchstabe im Alphabet um den Faktor 'key' (A+2=C, wird hier jedoch in Zahlen gemacht also: 0+2 = 2 -> C)
                    //Text wird Entschlüsselt
                    if (rad_decrypt.Checked == true && rad_encrypt.Checked == false) //Überprüfen welcher RadioButton ausgewählt wurde
                    {
                        newCharNum = (26 + (curChar_Index - key)) % 26; //Verschiebung des Buchstabens um 'key' nach links
                    }
                    //Text wird Verschlüsselt
                    else if (rad_decrypt.Checked == false && rad_encrypt.Checked == true) //Überprüfen welcher RadioButton ausgewählt wurde
                    {
                        newCharNum = (curChar_Index + key) % 26; //Verschiebung des Buchstabens um 'key' nach rechts
                    }

                    text_output += alphabet[Convert.ToInt32(newCharNum)]; //text_output String wird um das verschlüsselte Zeichen verlängert
                }
                else //Wenn keine Übereinstimmung gefunden -> Zeichen einfach übernehmen also '!' bleibt '!'
                {
                    text_output += curChar; //text_output String wird um das unverschlüsselte Sonderzeichen verlängert
                }
            }
            box_output.Text = text_output; //Gib text_output in Ausgabe Textbox aus
        }
    }
}
