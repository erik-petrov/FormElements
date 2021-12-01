using System;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormElements
{
    public partial class Form1 : Form
    {
        TreeView tree;
        Button btn, btn2;
        Label lbl;
        CheckBox chk, chk2, chk3, chk4;
        RadioButton rad, rad2;
        PictureBox pcx;
        TextBox txt;
        TabControl dynamicTabControl;
        SoundPlayer player;
        SoundPlayer coil;
        public int count = 1;
        public Form1()
        {
            //InitializeComponent();
            player = new SoundPlayer();
            coil = new SoundPlayer();
            coil.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\coil.wav";
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\menu.wav";
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
            btn2 = new Button
            {
                Text = "Create a new tab",
                Location = new Point(200, 100),
                Height = 30,
                Width = 100
            };
            btn2.Click += Btn2_Click;

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

            Image dotaImg = Image.FromFile(@"C:\Users\opilane\source\repos\FormElements\faces\dota.jpg");
            Image maksImg = Image.FromFile(@"C:\Users\opilane\source\repos\FormElements\faces\maksim.jpg");
            Image zhukiImg = Image.FromFile(@"C:\Users\opilane\source\repos\FormElements\faces\zhuki.jpg");
            Image vitasImg = Image.FromFile(@"C:\Users\opilane\source\repos\FormElements\faces\vitas.jpg");

            //играть музыку или нет
            chk = new CheckBox
            {
                Height = 300,
                Width = 300,
                Image = dotaImg,
            Location = new Point(1200, 600)
            };
            chk.CheckedChanged += Chk_CheckedChanged;
            chk2 = new CheckBox
            {
                Height = 300,
                Width = 300,
                Image = zhukiImg,
            Location = new Point(900, 600)
            };
            chk2.CheckedChanged += Chk2_CheckedChanged;
            chk3 = new CheckBox
            {
                Height = 300,
                Width = 300,
                Image = maksImg,
            Location = new Point(600, 600)
            };
            chk3.CheckedChanged += Chk3_CheckedChanged;
            chk4 = new CheckBox
            {
                Height = 300,
                Width = 300,
                Image = vitasImg,
                Location = new Point(300, 600)
            };
            chk4.CheckedChanged += Chk4_CheckedChanged;

            rad = new RadioButton
            {
                Location = new Point(1500, 630),
                Text = "Normal"
            };
            rad2 = new RadioButton
            {
                Location = new Point(1500, 600),
                Text = "Skin"
            };
            rad.CheckedChanged += Rad_CheckedChanged;
            rad2.CheckedChanged += Rad2_CheckedChanged;

            txt = new TextBox
            {
                Location = new Point(300, 300)
            };
            txt.KeyDown += Txt_KeyDown;

            //tabControl
            dynamicTabControl = new TabControl();
            dynamicTabControl.Name = "DynamicTabControl";
            dynamicTabControl.BackColor = Color.White;
            dynamicTabControl.ForeColor = Color.Black;
            dynamicTabControl.Location = new Point(500, 300);
            dynamicTabControl.Width = 300;
            dynamicTabControl.Height = 200;
            //tab1
            TabPage python = new TabPage();
            python.Text = "Python";
            python.Width = 100;
            python.Height = 100;
            Label pythonL = new Label();
            pythonL.Text = "Ugly and slow PL";
            python.Controls.Add(pythonL);
            pythonL.Width = 100;
            dynamicTabControl.TabPages.Add(python);
            //tab2
            TabPage sharp = new TabPage();
            sharp.Text = "C Sharp";
            sharp.Width = 200;
            sharp.Height = 100;
            Label sharpL = new Label();
            sharpL.Text = "Meh.";
            sharpL.Width = 100;
            sharp.Controls.Add(sharpL);
            dynamicTabControl.TabPages.Add(sharp);
            //tab3
            TabPage php = new TabPage();
            php.Text = "PHP";
            php.Width = 200;
            php.Height = 100;
            Label phpL = new Label();
            phpL.Text = "Disgusting";
            phpL.Width = 100;
            php.Controls.Add(phpL);
            dynamicTabControl.TabPages.Add(php);
            //
            TabPage js = new TabPage();
            js.Text = "JavaScript";
            js.Width = 300;
            js.Height = 100;
            Label jsL = new Label();
            jsL.Text = "Ugly web PL.";
            jsL.Width = 100;
            js.Controls.Add(jsL);
            dynamicTabControl.TabPages.Add(js);

            tree.Nodes.Add(tn);
            this.Controls.Add(tree);
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            //string name = Interaction.InputBox("Prompt", "Title", "Default", x_coordinate, y_coordinate);
        }

        private void Txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt.Text == "1000-7")
                {
                    var answer = MessageBox.Show("Are you a ghoul?", "1000-7", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (answer == DialogResult.No)
                    {
                        this.Close();
                    }
                    else MessageBox.Show("Nice");
                }
            }
        }

        private void Rad_CheckedChanged(object sender, EventArgs e)
        {
            Image back = Image.FromFile(@"C:\Users\opilane\source\repos\FormElements\norm.jpg");
            if (rad.Checked) this.BackgroundImage = back;
        }

        private void Rad2_CheckedChanged(object sender, EventArgs e)
        {
            Image back = Image.FromFile(@"C:\Users\opilane\source\repos\FormElements\330x192.png");
            if (rad2.Checked) this.BackgroundImage = back;
        }

        private void Chk_CheckedChanged(object sender, EventArgs e)
        {
            switch (chk.Checked)
            {
                case true:
                    player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\menu.wav";
                    player.PlayLooping();
                    break;
                case false:
                    player.Stop();
                    break;
            }
        }
        private void Chk2_CheckedChanged(object sender, EventArgs e)
        {
            switch (chk2.Checked)
            {
                case true:
                    player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\bat.wav";
                    player.PlayLooping();
                    break;
                case false:
                    player.Stop();
                    break;
            }
        }
        private void Chk3_CheckedChanged(object sender, EventArgs e)
        {
            switch (chk3.Checked)
            {
                case true:
                    player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\maks.wav";
                    player.PlayLooping();
                    break;
                case false:
                    player.Stop();
                    break;
            }
        }
        private void Chk4_CheckedChanged(object sender, EventArgs e)
        {
            switch (chk4.Checked)
            {
                case true:
                    player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\vitas.wav";
                    player.PlayLooping();
                    break;
                case false:
                    player.Stop();
                    break;
            }
        }

        private void Pcx_Click(object sender, EventArgs e)
        {
            switch (count)
            {
                case 1:
                    pcx.Image = new Bitmap(@"C:\Users\opilane\source\repos\FormElements\razes\close.jpg");
                    count++;
                    coil.Play();
                    break;
                case 2:
                    pcx.Image = new Bitmap(@"C:\Users\opilane\source\repos\FormElements\razes\mid.png");
                    count++;
                    coil.Play();
                    break;
                case 3:
                    pcx.Image = new Bitmap(@"C:\Users\opilane\source\repos\FormElements\razes\far.png");
                    count = 1;
                    coil.Play();
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
            else if (e.Node.Text == "CheckBox")
            {
                this.Controls.Add(chk);
                this.Controls.Add(chk2);
                this.Controls.Add(chk3);
                this.Controls.Add(chk4);
            }
            else if (e.Node.Text == "RadioButton")
            {
                this.Controls.Add(rad);
                this.Controls.Add(rad2);
            }
            else if (e.Node.Text == "TextBox")
            {
                this.Controls.Add(txt);
            }
            else if (e.Node.Text == "TabControl")
            {
                this.Controls.Add(dynamicTabControl);
            }
            //throw new NotImplementedException();
        }
    }
}
