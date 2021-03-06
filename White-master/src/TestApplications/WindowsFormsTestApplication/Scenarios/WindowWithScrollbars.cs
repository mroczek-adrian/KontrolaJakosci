using System;
using System.Windows.Forms;

namespace WindowsFormsTestApplication.Scenarios
{
    public partial class WindowWithScrollbars : Form
    {
        public WindowWithScrollbars()
        {
            InitializeComponent();
        }

        private void ButtonBackUpTop_Click(object sender, EventArgs e)
        {
            ButtonBackUpTop.AccessibleDescription = "ButtonBackUpTopClicked";
        }

        private void HiddenButton_Click(object sender, EventArgs e)
        {
            HiddenButton.AccessibleDescription = "HiddenButtonClicked";
        }
    }
}
