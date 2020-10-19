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
            public int b_time;
            public int time_on_way;
            public string type_plane;
            public int ticket_cost;
            public int number_seats;
            public int time_dest;
            public int procceds;

        };

        planes[] massiv;
        public int n;

        void Print()
        {
            dataGridView1.Rows.Clear();
            foreach (var t in massiv)
                dataGridView1.Rows.Add(t.n_flight, t.dest, t.b_time, t.time_on_way, t.type_plane, t.ticket_cost, t.number_seats, t.time_dest, t.procceds);
        }
        void Sort()
        {
            planes p;
 //           dataGridView1.Rows.Clear();
            for (int i = n - 1; i > 0; i--)
                for (int j = 0; j < i; j++)
                {
                    if (massiv[j].dest.CompareTo(massiv[j + 1].dest) == 1)
                    {
                        p = massiv[j];
                        massiv[j] = massiv[j + 1];
                        massiv[j + 1] = p;
                    }
                }
        }
        void Otbor()
        {
            dataGridView1.Rows.Clear();
            string k = textBox1.Text;
            foreach (var t in massiv)
                if (t.type_plane == k)
                {
                    dataGridView1.Rows.Add(t.n_flight, t.dest, t.b_time, t.time_on_way, t.type_plane, t.ticket_cost, t.number_seats, t.time_dest, t.procceds);
                }
        }
        int Time_dest(int a, int b)
        {
            return a + b;
        }
        int Proceeds(int a, int b)
        {
            return a * b;
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
                massiv[i].b_time = int.Parse(str[2]);
                massiv[i].time_on_way = int.Parse(str[3]);
                massiv[i].type_plane = str[4];
                massiv[i].ticket_cost = int.Parse(str[5]);
                massiv[i].number_seats = int.Parse(str[6]);
                massiv[i].time_dest = Time_dest(massiv[i].b_time, massiv[i].time_on_way);
                massiv[i].procceds = Proceeds(massiv[i].ticket_cost, massiv[i].number_seats);

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Print();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sort();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Otbor();
        }
    }
}
