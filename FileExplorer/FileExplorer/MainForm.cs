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
        public MainForm()
        {
            InitializeComponent();
            Console.WriteLine("Test" + this.ClientSize + this.Size);
        }
    }
}
