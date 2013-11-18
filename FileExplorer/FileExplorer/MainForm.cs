using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FileExplorer
{
    public partial class MainForm : Form
    {
        SplitContainer mainContainer;
        public MainForm()
        {
            InitializeComponent();
            /* To do
             * Set MainForm properties - size, start position
             * Add split container
             * Add 2 panels to split container
             */
           
            this.Size = new System.Drawing.Size(1500, 500);
            mainContainer = new SplitContainer();
            mainContainer.BackColor = Color.Red;
            Rectangle workArea = Screen.PrimaryScreen.WorkingArea;
            Console.Write(workArea.Size.Width);
            Console.Write(workArea.Size.Height);

            this.Controls.Add(mainContainer);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            /* To do
             * Set size of Form
             * Set size of 2 panels
             */
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            /* To do
             * Free 1 split container
             * Free 2 panels
             */

        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            /* To do
             * Set size of 2 panels
             */

        }
    }
}
