using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTagApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Init tags
            List<string> tags = new List<string>();
            tags.Add("C#");
            tags.Add("Windows Forms");
            tags.Add("WPF");
            tags.Add("WCF");
            tags.Add("ASP.NET");
            tags.AddRange(new string[] { "Web Services", "MVC", "Entity Framework" });
            tagListControl1.Tags = tags;
        }
    }
}
