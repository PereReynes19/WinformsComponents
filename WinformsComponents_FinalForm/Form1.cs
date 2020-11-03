using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsComponents_FinalForm
{
    public partial class MainForm : Form
    {
        public void CordsForm()
        {
            int x = this.DesktopLocation.X;
            int y = this.DesktopLocation.Y;
            this.Text = x.ToString() + "," + y.ToString() + " " + "Winforms Components - Common Controls";
        }
        public void BordersForms()
        {
            Object option = OptionsBox.SelectedItem;
            switch (option.ToString())
            {
                case "FixedSingle":
                    FormBorderStyle = FormBorderStyle.FixedSingle;
                    break;
                case "Fixed3D":
                    FormBorderStyle = FormBorderStyle.Fixed3D;
                    break;
                case "FixedDialog":
                    FormBorderStyle = FormBorderStyle.FixedDialog;
                    break;
                case "Sizable":
                    FormBorderStyle = FormBorderStyle.Sizable;
                    break;
                case "FixedToolWindow":
                    FormBorderStyle = FormBorderStyle.FixedToolWindow;
                    break;
                case "SizableToolWindow":
                    FormBorderStyle = FormBorderStyle.SizableToolWindow;
                    break;
                default:
                    FormBorderStyle = FormBorderStyle.None;
                    break;
            }
        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_Move(object sender, EventArgs e)
        {
            CordsForm();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            int h = this.Height;
            int w = this.Width;

            formSizeLabel.Text = "Form Size: " + h + " " + w;
        }
        private void OptionsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BordersForms();
        }

        private void visibleButton_Click(object sender, EventArgs e)
        {
            if (targedButton.Visible)
            {
                targedButton.Visible = false;
                visibleButton.Text = "Visible = False";
            }
            else
            {
                targedButton.Visible = true;
                visibleButton.Text = "Visible = True";
            }
        }

        private void enabledButton_Click(object sender, EventArgs e)
        {
            if (targedButton.Enabled)
            {
                targedButton.Enabled = false;
                enabledButton.Text = "Enabled = False";
            }
            else
            {
                targedButton.Enabled = true;
                enabledButton.Text = "Enabled = True";
            }
        }
    }
}
