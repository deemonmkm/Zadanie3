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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

