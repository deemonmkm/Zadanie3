using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        struct planes
        {
            public string n_flight;
            public string dest;
            public string b_time;
            public string time_on_way;
            public string type_plane;
            public string ticket_cost;
            public string number_seats;

        };


        planes[] massiv;
        public int n;
        public int k = 0;
        void Print()
        {
            dataGridView1.Rows.Clear();
            foreach (var t in massiv)
                dataGridView1.Rows.Add(t.n_flight, t.dest, t.b_time, t.time_on_way, t.type_plane, t.ticket_cost, t.number_seats);
        }

        public Form1()
        {
            string[] rows;
            InitializeComponent();
            if (File.Exists("planes.txt"))
            {
                StreamWriter writefl;
                rows = File.ReadAllLines("planes.txt");
                n = rows.Length;
                massiv = new planes[n];
            }
            else
            {
                MessageBox.Show("Файл не найден");
                return;
            }
            for (int i = 0; i < n; i++)
            {
                string[] str = rows[i].Split(';');
                massiv[i].n_flight = str[0];
                massiv[i].dest = str[1];
                massiv[i].b_time = str[2];
                massiv[i].time_on_way = str[3];
                massiv[i].type_plane = str[4];
                massiv[i].ticket_cost = str[5];
                massiv[i].number_seats = str[6];
                //Time_dest(massiv[i].b_time, massiv[i].time_on_way) = ;
                //Proceeds(plane.ticket_cost, massiv[i].number_seats) = ;

            }
            decimal Time_dest(decimal a, decimal b)
            {
                return a + b;
            }
            decimal Proceeds(decimal a, decimal b)
            {
                return a * b;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Print();
        }

    }
}
