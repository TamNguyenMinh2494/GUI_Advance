using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        private Button hello1;
        private Button hello2;
        private DateTimePicker dateTimePicker;
        public Form1()
        {
            
            InitializeComponent();

            //created button 1
            hello1 = new Button();
            hello1.Text = "Hello, I'm Alice";
            hello1.Size = new Size(200, 150);
            hello1.ForeColor = Color.Yellow;
            hello1.BackColor = Color.Brown;
            hello1.Click += btn1Click;

            //created button 2
            hello2 = new Button();
            hello2.Text = "Hello, I'm Bob";
            hello2.Size = new Size(200, 150);
            hello2.Location = new Point(201, 0);
            hello2.ForeColor = Color.White;
            hello2.BackColor = Color.Blue;
            hello2.Click += btn2Click; 
            Controls.Add(hello1);
            Controls.Add(hello2);

            //created datetimepicker

            dateTimePicker = new DateTimePicker();
            dateTimePicker.Size = new Size(200, 150);
            dateTimePicker.Location = new Point(402, 0);
            dateTimePicker.ValueChanged += dtp_ValueChanged;
            Controls.Add(dateTimePicker);
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(dateTimePicker.Value.ToString());
            form2.ShowDialog();
        }

        private void btn2Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2(hello2.Text);
            form2.Show();
        }

        private void btn1Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alice xin chào các bạn!!!");
        }

        
    }
}
