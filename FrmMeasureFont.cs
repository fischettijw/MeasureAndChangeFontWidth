using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeasureAndChangeFontWidth
{
    public partial class FrmMeasureFont : Form
    {
        public FrmMeasureFont()
        {
            InitializeComponent();
        }

        private void FrmMeasureFont_Load(object sender, EventArgs e)
        {
            TxtTextInput.Text = "This is the time for all good men.";
            TxtFontSize.Text = "36";
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            //int newWidth = AutoSizeTextBox(TxtTextInput);
            int newWidth = AutoSizeTextBox(TxtTextInput, Convert.ToInt32(TxtFontSize.Text));

            TxtTextInput.Select(TxtTextInput.Text.Length, 0);
            TxtTextInput.Focus();

            this.ClientSize = new Size(newWidth + 50, this.ClientSize.Height);

        }

        // Make the TextBox fit its contents.
        private int AutoSizeTextBox(TextBox txtBox, int newFontSize = 0)
        {
            if (newFontSize != 0) txtBox.Font = new Font(txtBox.Font.FontFamily, newFontSize);
            Size size = TextRenderer.MeasureText(txtBox.Text, txtBox.Font);
            txtBox.ClientSize = new Size(size.Width, size.Height);
            return txtBox.ClientSize.Width;
        }
    }

}
