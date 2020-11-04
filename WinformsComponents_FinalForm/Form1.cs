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
        public void orderTabIndex()
        {
            OptionsBox.TabIndex = 1;
            visibleButton.TabIndex = 2;
            enabledButton.TabIndex = 3;
            centerButton.TabIndex = 4;
            upButton.TabIndex = 5;
            leftButton.TabIndex = 6;
            downButton.TabIndex = 7;
            rightButton.TabIndex = 8;
            targedButton.TabStop = false;
        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            orderTabIndex();
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

        private void centerButton_Click(object sender, EventArgs e)
        {
            int y = this.Height / 2 - 50;
            int x = this.Width / 2 - 50;

            targedButton.Location = new Point(x, y);
        }

        private void targedButton_Move(object sender, EventArgs e)
        {
            setTargetLocation();
        }
        public void setTargetLocation()
        {
            int x = targedButton.Location.X;
            int y = targedButton.Location.Y;
            targedButton.Text = $"Targed\n X = {x}\n Y = {y}";
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            int y = targedButton.Location.Y;
            int x = (targedButton.Location.X) + 5;
            targedButton.Location = new Point(x, y);
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            int y = targedButton.Location.Y;
            int x = (targedButton.Location.X) - 5;
            targedButton.Location = new Point(x, y);
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            int y = targedButton.Location.Y + 5;
            int x = targedButton.Location.X;
            targedButton.Location = new Point(x, y);
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            int y = targedButton.Location.Y - 5;
            int x = targedButton.Location.X;
            targedButton.Location = new Point(x, y);
        }
    }
}
