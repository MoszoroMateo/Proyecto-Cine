namespace FrontEnd1.Forms
{
    partial class FrmConsultarPelicula
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarPelicula));
            lblTitulo = new Label();
            cboGenero = new ComboBox();
            label2 = new Label();
            lblEdad = new Label();
            cboEdad = new ComboBox();
            dataGridView1 = new DataGridView();
            txtTitulo = new TextBox();
            panel1 = new Panel();
            label6 = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            btnConsultar = new Button();
            lblEstadoPelicula = new Label();
            rbtDisponible = new RadioButton();
            rbtNoDisponible = new RadioButton();
            colTitulo = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            colGenero = new DataGridViewTextBoxColumn();
            colEdad = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(288, 192);
            lblTitulo.Margin = new Padding(5, 0, 5, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(104, 31);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Titulo :";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // cboGenero
            // 
            cboGenero.Anchor = AnchorStyles.Top;
            cboGenero.FormattingEnabled = true;
            cboGenero.Location = new Point(409, 245);
            cboGenero.Margin = new Padding(5, 4, 5, 4);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(223, 28);
            cboGenero.TabIndex = 5;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(267, 243);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(127, 31);
            label2.TabIndex = 4;
            label2.Text = "Genero :";
            // 
            // lblEdad
            // 
            lblEdad.Anchor = AnchorStyles.Top;
            lblEdad.AutoSize = true;
            lblEdad.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEdad.ForeColor = Color.White;
            lblEdad.Location = new Point(201, 295);
            lblEdad.Margin = new Padding(5, 0, 5, 0);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(198, 31);
            lblEdad.TabIndex = 9;
            lblEdad.Text = "Clasificacion :\r\n";
            // 
            // cboEdad
            // 
            cboEdad.Anchor = AnchorStyles.Top;
            cboEdad.FormattingEnabled = true;
            cboEdad.Location = new Point(409, 297);
            cboEdad.Margin = new Padding(5, 4, 5, 4);
            cboEdad.Name = "cboEdad";
            cboEdad.Size = new Size(153, 28);
            cboEdad.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top;
            dataGridView1.BackgroundColor = Color.FromArgb(11, 7, 17);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colTitulo, colEstado, colGenero, colEdad });
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(230, 437);
            dataGridView1.Margin = new Padding(5, 4, 5, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(725, 229);
            dataGridView1.TabIndex = 13;
            // 
            // txtTitulo
            // 
            txtTitulo.Anchor = AnchorStyles.Top;
            txtTitulo.Location = new Point(409, 195);
            txtTitulo.Margin = new Padding(5, 4, 5, 4);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(378, 27);
            txtTitulo.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(11, 7, 17);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(-1, 0);
            panel1.Margin = new Padding(5, 4, 5, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1221, 100);
            panel1.TabIndex = 26;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(410, 12);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(373, 42);
            label6.TabIndex = 0;
            label6.Text = "Consulte su pelicula";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(235, 5, 75);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(-1, 91);
            panel2.Margin = new Padding(5, 4, 5, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1221, 16);
            panel2.TabIndex = 27;
            // 
            // panel4
            // 
            panel4.Location = new Point(0, 12);
            panel4.Margin = new Padding(5, 4, 5, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(14, 599);
            panel4.TabIndex = 24;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel3.BackColor = Color.FromArgb(235, 5, 75);
            panel3.Location = new Point(-7, 100);
            panel3.Margin = new Padding(5, 4, 5, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(14, 683);
            panel3.TabIndex = 38;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(15, 116);
            pictureBox2.Margin = new Padding(5, 4, 5, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(58, 56);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 39;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Anchor = AnchorStyles.Top;
            btnConsultar.BackColor = Color.FromArgb(11, 7, 17);
            btnConsultar.FlatAppearance.BorderSize = 0;
            btnConsultar.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 5, 75);
            btnConsultar.FlatStyle = FlatStyle.Flat;
            btnConsultar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnConsultar.ForeColor = Color.White;
            btnConsultar.ImageAlign = ContentAlignment.MiddleLeft;
            btnConsultar.Location = new Point(832, 388);
            btnConsultar.Margin = new Padding(5, 4, 5, 4);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(121, 40);
            btnConsultar.TabIndex = 40;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // lblEstadoPelicula
            // 
            lblEstadoPelicula.Anchor = AnchorStyles.Top;
            lblEstadoPelicula.AutoSize = true;
            lblEstadoPelicula.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstadoPelicula.ForeColor = Color.White;
            lblEstadoPelicula.Location = new Point(272, 355);
            lblEstadoPelicula.Margin = new Padding(5, 0, 5, 0);
            lblEstadoPelicula.Name = "lblEstadoPelicula";
            lblEstadoPelicula.Size = new Size(122, 31);
            lblEstadoPelicula.TabIndex = 41;
            lblEstadoPelicula.Text = "Estado :";
            // 
            // rbtDisponible
            // 
            rbtDisponible.AutoSize = true;
            rbtDisponible.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            rbtDisponible.ForeColor = SystemColors.Control;
            rbtDisponible.Location = new Point(397, 347);
            rbtDisponible.Margin = new Padding(3, 4, 3, 4);
            rbtDisponible.Name = "rbtDisponible";
            rbtDisponible.Size = new Size(188, 41);
            rbtDisponible.TabIndex = 42;
            rbtDisponible.TabStop = true;
            rbtDisponible.Text = "\"Disponible\"";
            rbtDisponible.UseVisualStyleBackColor = true;
            // 
            // rbtNoDisponible
            // 
            rbtNoDisponible.AutoSize = true;
            rbtNoDisponible.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            rbtNoDisponible.ForeColor = SystemColors.Control;
            rbtNoDisponible.Location = new Point(583, 347);
            rbtNoDisponible.Margin = new Padding(3, 4, 3, 4);
            rbtNoDisponible.Name = "rbtNoDisponible";
            rbtNoDisponible.Size = new Size(231, 41);
            rbtNoDisponible.TabIndex = 43;
            rbtNoDisponible.TabStop = true;
            rbtNoDisponible.Text = "\"No Disponible\"";
            rbtNoDisponible.UseVisualStyleBackColor = true;
            // 
            // colTitulo
            // 
            colTitulo.HeaderText = "Título";
            colTitulo.MinimumWidth = 6;
            colTitulo.Name = "colTitulo";
            colTitulo.ReadOnly = true;
            colTitulo.Width = 125;
            // 
            // colEstado
            // 
            colEstado.HeaderText = "Estado";
            colEstado.MinimumWidth = 6;
            colEstado.Name = "colEstado";
            colEstado.ReadOnly = true;
            colEstado.Width = 125;
            // 
            // colGenero
            // 
            colGenero.HeaderText = "Género";
            colGenero.MinimumWidth = 6;
            colGenero.Name = "colGenero";
            colGenero.ReadOnly = true;
            colGenero.Width = 125;
            // 
            // colEdad
            // 
            colEdad.HeaderText = "Clasificación";
            colEdad.MinimumWidth = 6;
            colEdad.Name = "colEdad";
            colEdad.ReadOnly = true;
            colEdad.Width = 125;
            // 
            // FrmConsultarPelicula
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(1218, 773);
            Controls.Add(rbtNoDisponible);
            Controls.Add(rbtDisponible);
            Controls.Add(lblEstadoPelicula);
            Controls.Add(btnConsultar);
            Controls.Add(pictureBox2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(lblEdad);
            Controls.Add(cboEdad);
            Controls.Add(cboGenero);
            Controls.Add(label2);
            Controls.Add(lblTitulo);
            Controls.Add(txtTitulo);
            Margin = new Padding(5, 4, 5, 4);
            Name = "FrmConsultarPelicula";
            Text = "FrmConsultarPelicula";
            Load += FrmConsultarPelicula_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private ComboBox cboGenero;
        private Label label2;
        private Label lblEdad;
        private ComboBox cboEdad;
        private DataGridView dataGridView1;
        private TextBox txtTitulo;
        private Panel panel1;
        private Label label6;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Button btnConsultar;
        private Label lblEstadoPelicula;
        private RadioButton rbtDisponible;
        private RadioButton rbtNoDisponible;
        private DataGridViewTextBoxColumn colTitulo;
        private DataGridViewTextBoxColumn colEstado;
        private DataGridViewTextBoxColumn colGenero;
        private DataGridViewTextBoxColumn colEdad;
    }
}