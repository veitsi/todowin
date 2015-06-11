using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace todolist
{
    public partial class frmTodo : Form
    {
        public frmTodo()
        {
            InitializeComponent();
        }

        private void todo_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            status.Text =""+ todo.Nodes.Count;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
