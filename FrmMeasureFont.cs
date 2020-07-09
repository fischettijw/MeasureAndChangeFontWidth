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

            Size mySize = new Size();

            Font myFont = new Font(TxtTextInput.Font.FontFamily, Convert.ToInt32(TxtFontSize.Text));
            TxtTextInput.Font = myFont;
            mySize = TextRenderer.MeasureText(TxtTextInput.Text, myFont);

            Size size = new Size(mySize.Width, mySize.Height);
            TxtTextInput.ClientSize = size;

            TxtTextInput.Select(0, 0);

            this.ClientSize = new Size(mySize.Width + 50, this.ClientSize.Height);
        }

        // Make the TextBox fit its contents.
        private void AutoSizeTextBox(TextBox txtBox, int newFontSize = 0)
        {
            if (newFontSize == 0) newFontSize = (int)txtBox.Font.Size;
            const int xMargin = 0;
            const int yMargin = 2;
            Size size = TextRenderer.MeasureText(txtBox.Text, txtBox.Font);
            txtBox.ClientSize = new Size(size.Width + xMargin, size.Height + yMargin);
        }
    }
}
