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
    public partial class Form2 : Form
    {
        //public Form2(string text)
        //{
        //    InitializeComponent();
        //    label1.Text = text;
        //}
        //public string Username { get; set; }
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; label1.Text = username; }
        }
        private List<string> users;

        public List<string> Users
        {
            get { return users; }
            set { users = value; SetLabel(users); }
        }

        void SetLabel(List<string> users)
        {
            foreach (var item in users)
            {
                label1.Text += item + "\n";
            }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //label1.Text = Username;
        }

        public DialogResult ShowDialog(User user)
        {
            label1.Text = $"Name : {user.Name}  Surname : {user.Surname}  Age : {user.Age}";
            return ShowDialog();
        }
        public EventHandler<EventArgs> Handler { get; set; }
        public string Data { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            Data = textBox1.Text;
            Handler.Invoke(sender,e);
            //this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Data = textBox1.Text;
            Handler.Invoke(sender, e);
        }
    }
}
