using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormElements
{
    public partial class Form1 : Form
    {
        TreeView tree;
        Button btn;
        Label lbl;
        CheckBox chk;
        RadioButton rad;
        TextBox txt;
        PictureBox pcx;
        TabControl tab;
        MessageBox msg;
        public int count = 1;
        public Form1()
        {
            //InitializeComponent();
            this.Height = 1080;
            this.Width = 1920;
            this.Text = "lol";
            Image img = new Bitmap(@"C:\Users\opilane\source\repos\FormElements\330x192.png");
            this.BackgroundImage = img;
            tree = new TreeView();
            tree.Dock = DockStyle.Left;
            tree.AfterSelect += Tree_AfterSelect;
            TreeNode tn = new TreeNode("Elements");
            tn.Nodes.Add(new TreeNode("Button"));
            tn.Nodes.Add(new TreeNode("Label"));
            tn.Nodes.Add(new TreeNode("PictureBox"));
            tn.Nodes.Add(new TreeNode("CheckBox"));
            tn.Nodes.Add(new TreeNode("RadioButton"));
            tn.Nodes.Add(new TreeNode("TextBox"));
            tn.Nodes.Add(new TreeNode("TabControl"));
            tn.Nodes.Add(new TreeNode("MessageBox"));

            btn = new Button
            {
                Text = "Press here",
                Location = new Point(100, 100),
                Height = 30,
                Width = 100
            };
            btn.Click += Btn_Click;

            lbl = new Label
            {
                Text = "Amogus",
                Height = 20,
                Width = 50,
                Location = new Point(768, 0)
            };
            lbl.MouseHover += Lbl_MouseHover;

            pcx = new PictureBox
            {
                Height = 500,
                Width = 500,
                Image = new Bitmap(@"C:\Users\opilane\source\repos\FormElements\razes\close.jpg"),
                Location = new Point(768, 500)
            };
            pcx.Click += Pcx_Click;

            chk = new CheckBox
            {

            };

            rad = new RadioButton
            {

            };

            txt = new TextBox
            {

            };

            tab = new TabControl
            {

            };


            tree.Nodes.Add(tn);
            this.Controls.Add(tree);
        }

        private void Pcx_Click(object sender, EventArgs e)
        {
            switch (count)
            {
                case 1:
                    pcx.Image = new Bitmap(@"C:\Users\opilane\source\repos\FormElements\razes\close.jpg");
                    count++;
                    break;
                case 2:
                    pcx.Image = new Bitmap(@"C:\Users\opilane\source\repos\FormElements\razes\mid.png");
                    count++;
                    break;
                case 3:
                    pcx.Image = new Bitmap(@"C:\Users\opilane\source\repos\FormElements\razes\far.png");
                    count = 1;
                    break;
            }
        }

        private void Lbl_MouseHover(object sender, EventArgs e)
        {
            lbl.BackColor = Color.Green;
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "Button")
            {
                this.Controls.Add(btn);
            }
            else if (e.Node.Text == "Label")
            {
                this.Controls.Add(lbl);
            }
            else if (e.Node.Text == "PictureBox")
            {
                this.Controls.Add(pcx);
            }
            //throw new NotImplementedException();
        }
    }
}
