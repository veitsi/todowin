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
            //status.Text =""+ todo.Nodes.Count;
            Console.WriteLine("n=" + todo.Nodes.Count);
            TreeNode node;
            node = todo.Nodes[0];
            todo.Nodes[0]
                n
            for (int i = 0; i < todo.Nodes.Count; i++)
            {
                
                Console.WriteLine(todo.Nodes[i].Text);
                for (int j = 0; j < todo.Nodes[i].GetNodeCount(false); j++)
                    Console.WriteLine("--->"+todo.Nodes[i].Nodes[j].Text);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {

        }
    }
}
