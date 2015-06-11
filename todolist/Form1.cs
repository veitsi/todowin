using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace todolist
{
    public partial class frmTodo : Form
    {
        class tmp
        {
            public int a = 1;
            public string s = "s";

        }
        public void saveJson()
        {
            ToDoList t = new ToDoList();
            t.addTestData();
            string serialized = JsonConvert.SerializeObject(t);
            System.IO.File.WriteAllText(@"serialized.txt", serialized);
            serialized = System.IO.File.ReadAllText(@"serialized.txt");
            log.Text = serialized;
            t = JsonConvert.DeserializeObject<ToDoList>(serialized);
            log.Text = t.tasks[0].text;
           
        }

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
            saveJson();
            Console.WriteLine("n=" + todo.Nodes.Count);
            TreeNode node;
            node = todo.Nodes[0];
            //todo.Nodes[0]
        
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
