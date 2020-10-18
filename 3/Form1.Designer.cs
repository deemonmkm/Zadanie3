namespace _3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.n_flight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_on_way = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_plane = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticket_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number_seats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.n_flight,
            this.dest,
            this.b_time,
            this.time_on_way,
            this.type_plane,
            this.ticket_cost,
            this.number_seats});
            this.dataGridView1.Location = new System.Drawing.Point(438, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // n_flight
            // 
            this.n_flight.HeaderText = "Номер рейса";
            this.n_flight.Name = "n_flight";
            // 
            // dest
            // 
            this.dest.HeaderText = "Конечный пункт";
            this.dest.Name = "dest";
            // 
            // b_time
            // 
            this.b_time.HeaderText = "Время вылета";
            this.b_time.Name = "b_time";
            // 
            // time_on_way
            // 
            this.time_on_way.HeaderText = "Время в пути";
            this.time_on_way.Name = "time_on_way";
            // 
            // type_plane
            // 
            this.type_plane.HeaderText = "Тип самолета";
            this.type_plane.Name = "type_plane";
            // 
            // ticket_cost
            // 
            this.ticket_cost.HeaderText = "Стоимость билета";
            this.ticket_cost.Name = "ticket_cost";
            // 
            // number_seats
            // 
            this.number_seats.HeaderText = "Количество мест";
            this.number_seats.Name = "number_seats";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Заполнить таблицу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(83, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(264, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Сортировка по конечному пункту";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(83, 149);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(264, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Отбор по типу самолета";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn n_flight;
        private System.Windows.Forms.DataGridViewTextBoxColumn dest;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn time_on_way;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_plane;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticket_cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn number_seats;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

