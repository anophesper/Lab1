using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab1_ControlLibrary
{
    [ToolboxBitmap(@"C:\Users\Owner\Desktop\labs\Second\APPZ\Lab1_Kiian\Lab1_ControlLibrary\Resources\Lab1_Icon.bmp")]
    public partial class Lab1_Kiian: UserControl
    {
        public Lab1_Kiian()
        {
            InitializeComponent();
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Перевіряємо, чи є введений символ числом чи пробілом
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox.Text, out int val))
            {
                if (val >= trackBar.Minimum && val <= trackBar.Maximum)
                {
                    trackBar.Value = val;
                }
                else
                {
                    MessageBox.Show("Введіть число в межах від " + trackBar.Minimum + " до " + trackBar.Maximum);
                    textBox.Text = "";
                }
            }
        }
    }
}
