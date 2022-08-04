using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public EventHandler<EventArgs> handler;
        public Form1()
        {
            InitializeComponent();
            handler = new EventHandler<EventArgs>(button5_Click);
                

        }
        public List<string> Users { get; set; } = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            //Form2 form2 = new Form2(textBox1.Text);
            //form2.ShowDialog();



            //Form2 form2=new Form2();
            //form2.Username = textBox1.Text;
            //form2.ShowDialog();



            //Form2 form2 = new Form2();
            //form2.Users = Users;

            //this.Hide();

            //if (form2.ShowDialog() == DialogResult.Cancel)
            //{
            //    this.Show();
            //}



            //Parent Child melumat oturmenin yollari
            // 1.  By constructor
            // 2. By Property 
            //3.  By ShowDialog Overloading
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Users.Add(textBox1.Text);
            textBox1.Text = String.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Name = nameTxtb.Text;
            user.Surname = surnameTxtb.Text;
            user.Age = int.Parse(ageMTxtb.Text);

            //Form2 form2 = new Form2();
           // form2.ShowDialog(user);
        }

            //Form2 form2 = new Form2();
        Form2 form2 = new Form2();
        private void button4_Click(object sender, EventArgs e)
        {
            form2.Handler = handler;
            form2.Show();

        }



        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = form2.Data;
        }
    }
}
