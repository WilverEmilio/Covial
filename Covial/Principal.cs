using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Principal : Form
    {
        private int childFormNumber = 0;

        public string usuario_id = "";
        public string nombre_usuario = "";
        public string rol = "";
        public Principal()
        {
            InitializeComponent();
        }
    }
}
