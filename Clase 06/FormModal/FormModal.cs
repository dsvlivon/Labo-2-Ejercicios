using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormModal
{
    public partial class FormModal : Form
    {
        public string msg1;
        public FormModal(string n, string a)
        {
            this.msg1 = "¡Hola, windows Forms!";
            this.msg1 = $"Soy {n} {a}";
            InitializeComponent();
        }

        private void FormModal_Load(object sender, EventArgs e)
        {

        }
    }
}
