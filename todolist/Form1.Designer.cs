namespace todolist
{
    partial class frmTodo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node3");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Item0", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Item1", new System.Windows.Forms.TreeNode[] {
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Item2");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Node8");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Node9");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Node10");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Node12");
            this.todo = new System.Windows.Forms.TreeView();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.log = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // todo
            // 
            this.todo.CheckBoxes = true;
            this.todo.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.todo.LabelEdit = true;
            this.todo.Location = new System.Drawing.Point(13, 13);
            this.todo.Name = "todo";
            treeNode1.Name = "Node3";
            treeNode1.Text = "Node3";
            treeNode2.Name = "Node4";
            treeNode2.Text = "Node4";
            treeNode3.Name = "Node5";
            treeNode3.Text = "Node5";
            treeNode4.Name = "Node6";
            treeNode4.Text = "Node6";
            treeNode5.Name = "Node11";
            treeNode5.Text = "";
            treeNode6.Name = "Node0";
            treeNode6.Text = "Item0";
            treeNode7.Name = "Node7";
            treeNode7.Text = "Node7";
            treeNode8.Name = "node1";
            treeNode8.Text = "Item1";
            treeNode9.Name = "Node2";
            treeNode9.Text = "Item2";
            treeNode10.Name = "Node8";
            treeNode10.Text = "Node8";
            treeNode11.Name = "Node9";
            treeNode11.Text = "Node9";
            treeNode12.Name = "Node10";
            treeNode12.Text = "Node10";
            treeNode13.Name = "Node12";
            treeNode13.Text = "Node12";
            this.todo.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13});
            this.todo.Size = new System.Drawing.Size(427, 191);
            this.todo.TabIndex = 0;
            this.todo.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.todo_AfterSelect);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 272);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(213, 57);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(237, 272);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(203, 57);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(134, 191);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(167, 13);
            this.status.TabIndex = 3;
            this.status.Text = "label1hfghfgh  hfghfghfgh hfghfgh";
            this.status.Click += new System.EventHandler(this.label1_Click);
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(13, 211);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(427, 55);
            this.log.TabIndex = 4;
            this.log.Text = "hfghfgh\ngdfgdfgdf\nfdgdfgdfgdfg\ngdfgdfg";
            // 
            // frmTodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 334);
            this.Controls.Add(this.log);
            this.Controls.Add(this.status);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.todo);
            this.Name = "frmTodo";
            this.Text = "todolist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TreeView todo;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.RichTextBox log;
    }
}

