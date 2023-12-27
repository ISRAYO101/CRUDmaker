namespace CRUD_Tako
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNombre = new TextBox();
            DTPfecha = new DateTimePicker();
            label6 = new Label();
            txtEstudio = new TextBox();
            ChkList = new CheckedListBox();
            txtPuntaje = new TextBox();
            btnGuardar = new Button();
            btnConsultar = new Button();
            dataGridView1 = new DataGridView();
            btnBorrar = new Button();
            btnEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 35);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 95);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 1;
            label2.Text = "Fecha de Emisión :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 161);
            label3.Name = "label3";
            label3.Size = new Size(139, 20);
            label3.TabIndex = 2;
            label3.Text = "Estudio Animador : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 229);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 3;
            label4.Text = "Genero(s) : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(317, 229);
            label5.Name = "label5";
            label5.Size = new Size(125, 20);
            label5.TabIndex = 4;
            label5.Text = "Puntaje Personal  ";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(130, 32);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(400, 27);
            txtNombre.TabIndex = 5;
            // 
            // DTPfecha
            // 
            DTPfecha.Location = new Point(187, 88);
            DTPfecha.Name = "DTPfecha";
            DTPfecha.Size = new Size(343, 27);
            DTPfecha.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(187, 160);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 7;
            // 
            // txtEstudio
            // 
            txtEstudio.AcceptsReturn = true;
            txtEstudio.Location = new Point(185, 158);
            txtEstudio.Name = "txtEstudio";
            txtEstudio.Size = new Size(345, 27);
            txtEstudio.TabIndex = 8;
            // 
            // ChkList
            // 
            ChkList.FormattingEnabled = true;
            ChkList.Items.AddRange(new object[] { "Shounen", "Historias de la vida", "Comedia", "Seinen", "Mecha", "Romance", "Drama", "Isekai", "Terror", "Suspenso", "Gore", "Jei", "Musical", "Deportes" });
            ChkList.Location = new Point(40, 229);
            ChkList.Name = "ChkList";
            ChkList.Size = new Size(175, 246);
            ChkList.TabIndex = 9;
            // 
            // txtPuntaje
            // 
            txtPuntaje.Location = new Point(314, 252);
            txtPuntaje.Name = "txtPuntaje";
            txtPuntaje.Size = new Size(128, 27);
            txtPuntaje.TabIndex = 10;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(328, 311);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(99, 37);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Registrar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(587, 476);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(99, 39);
            btnConsultar.TabIndex = 12;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.Silver;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(555, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(732, 457);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(1164, 478);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(99, 37);
            btnBorrar.TabIndex = 15;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(847, 476);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(134, 37);
            btnEditar.TabIndex = 14;
            btnEditar.Text = "Guardar Cambios";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1310, 522);
            Controls.Add(btnBorrar);
            Controls.Add(btnEditar);
            Controls.Add(dataGridView1);
            Controls.Add(btnConsultar);
            Controls.Add(btnGuardar);
            Controls.Add(txtPuntaje);
            Controls.Add(ChkList);
            Controls.Add(txtEstudio);
            Controls.Add(label6);
            Controls.Add(DTPfecha);
            Controls.Add(txtNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Principal";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNombre;
        private DateTimePicker DTPfecha;
        private Label label6;
        private TextBox txtEstudio;
        private CheckedListBox ChkList;
        private TextBox txtPuntaje;
        private Button btnGuardar;
        private Button btnConsultar;
        private DataGridView dataGridView1;
        private Button btnBorrar;
        private Button btnEditar;
    }
}