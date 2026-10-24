namespace prySeguraSp4
{
    partial class Mozos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mozos));
            dgvVentas = new DataGridView();
            colComidas = new DataGridViewTextBoxColumn();
            colSinAlcohol = new DataGridViewTextBoxColumn();
            colConAlcohol = new DataGridViewTextBoxColumn();
            colPostres = new DataGridViewTextBoxColumn();
            btnValidar = new Button();
            btnMozoDia = new Button();
            btnTotales = new Button();
            lblMejorMozo = new Label();
            lblTotalGeneral = new Label();
            lblTotalComidas = new Label();
            lblTotalSinAlcohol = new Label();
            lblTotalConAlcohol = new Label();
            lblTotalPostres = new Label();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.AllowUserToResizeRows = false;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Columns.AddRange(new DataGridViewColumn[] { colComidas, colSinAlcohol, colConAlcohol, colPostres });
            dgvVentas.Location = new Point(69, 12);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.RowHeadersWidth = 230;
            dgvVentas.ScrollBars = ScrollBars.None;
            dgvVentas.Size = new Size(625, 165);
            dgvVentas.TabIndex = 0;
            dgvVentas.CellBeginEdit += dgvVentas_CellBeginEdit;
            dgvVentas.CellValueChanged += dgvVentas_CellValueChanged;
            // 
            // colComidas
            // 
            colComidas.HeaderText = "Comidas";
            colComidas.Name = "colComidas";
            colComidas.Width = 79;
            // 
            // colSinAlcohol
            // 
            colSinAlcohol.HeaderText = "Bebidas sin alcohol";
            colSinAlcohol.Name = "colSinAlcohol";
            colSinAlcohol.Width = 122;
            // 
            // colConAlcohol
            // 
            colConAlcohol.HeaderText = "Bebidas sin alcohol";
            colConAlcohol.Name = "colConAlcohol";
            colConAlcohol.Width = 122;
            // 
            // colPostres
            // 
            colPostres.HeaderText = "Postres";
            colPostres.Name = "colPostres";
            colPostres.Width = 70;
            // 
            // btnValidar
            // 
            btnValidar.Font = new Font("Impact", 12F, FontStyle.Italic);
            btnValidar.Location = new Point(80, 292);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(128, 30);
            btnValidar.TabIndex = 1;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // btnMozoDia
            // 
            btnMozoDia.Enabled = false;
            btnMozoDia.Font = new Font("Impact", 12F, FontStyle.Italic);
            btnMozoDia.Location = new Point(80, 238);
            btnMozoDia.Name = "btnMozoDia";
            btnMozoDia.Size = new Size(128, 28);
            btnMozoDia.TabIndex = 2;
            btnMozoDia.Text = "Mozo del dia";
            btnMozoDia.UseVisualStyleBackColor = true;
            btnMozoDia.Click += btnMozoDia_Click;
            // 
            // btnTotales
            // 
            btnTotales.Enabled = false;
            btnTotales.Font = new Font("Impact", 12F, FontStyle.Italic);
            btnTotales.Location = new Point(392, 238);
            btnTotales.Name = "btnTotales";
            btnTotales.Size = new Size(110, 28);
            btnTotales.TabIndex = 3;
            btnTotales.Text = "Totales";
            btnTotales.UseVisualStyleBackColor = true;
            btnTotales.Click += btnTotales_Click;
            // 
            // lblMejorMozo
            // 
            lblMejorMozo.AutoSize = true;
            lblMejorMozo.Font = new Font("Impact", 12F, FontStyle.Italic);
            lblMejorMozo.Location = new Point(235, 246);
            lblMejorMozo.Name = "lblMejorMozo";
            lblMejorMozo.Size = new Size(47, 20);
            lblMejorMozo.TabIndex = 4;
            lblMejorMozo.Text = "label1";
            lblMejorMozo.Click += lblMozo1_Click;
            // 
            // lblTotalGeneral
            // 
            lblTotalGeneral.AutoSize = true;
            lblTotalGeneral.Font = new Font("Impact", 12F, FontStyle.Italic);
            lblTotalGeneral.Location = new Point(531, 202);
            lblTotalGeneral.Name = "lblTotalGeneral";
            lblTotalGeneral.Size = new Size(47, 20);
            lblTotalGeneral.TabIndex = 5;
            lblTotalGeneral.Text = "label1";
            // 
            // lblTotalComidas
            // 
            lblTotalComidas.AutoSize = true;
            lblTotalComidas.Font = new Font("Impact", 12F, FontStyle.Italic);
            lblTotalComidas.Location = new Point(531, 228);
            lblTotalComidas.Name = "lblTotalComidas";
            lblTotalComidas.Size = new Size(49, 20);
            lblTotalComidas.TabIndex = 6;
            lblTotalComidas.Text = "label2";
            // 
            // lblTotalSinAlcohol
            // 
            lblTotalSinAlcohol.AutoSize = true;
            lblTotalSinAlcohol.Font = new Font("Impact", 12F, FontStyle.Italic);
            lblTotalSinAlcohol.Location = new Point(531, 256);
            lblTotalSinAlcohol.Name = "lblTotalSinAlcohol";
            lblTotalSinAlcohol.Size = new Size(49, 20);
            lblTotalSinAlcohol.TabIndex = 7;
            lblTotalSinAlcohol.Text = "label3";
            // 
            // lblTotalConAlcohol
            // 
            lblTotalConAlcohol.AutoSize = true;
            lblTotalConAlcohol.Font = new Font("Impact", 12F, FontStyle.Italic);
            lblTotalConAlcohol.Location = new Point(531, 288);
            lblTotalConAlcohol.Name = "lblTotalConAlcohol";
            lblTotalConAlcohol.Size = new Size(49, 20);
            lblTotalConAlcohol.TabIndex = 8;
            lblTotalConAlcohol.Text = "label4";
            // 
            // lblTotalPostres
            // 
            lblTotalPostres.AutoSize = true;
            lblTotalPostres.Font = new Font("Impact", 12F, FontStyle.Italic);
            lblTotalPostres.Location = new Point(531, 316);
            lblTotalPostres.Name = "lblTotalPostres";
            lblTotalPostres.Size = new Size(50, 20);
            lblTotalPostres.TabIndex = 9;
            lblTotalPostres.Text = "label5";
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Impact", 12F, FontStyle.Italic);
            btnCancelar.Location = new Point(392, 292);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(110, 30);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cerrar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // Mozos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(848, 377);
            Controls.Add(btnCancelar);
            Controls.Add(lblTotalPostres);
            Controls.Add(lblTotalConAlcohol);
            Controls.Add(lblTotalSinAlcohol);
            Controls.Add(lblTotalComidas);
            Controls.Add(lblTotalGeneral);
            Controls.Add(lblMejorMozo);
            Controls.Add(btnTotales);
            Controls.Add(btnMozoDia);
            Controls.Add(btnValidar);
            Controls.Add(dgvVentas);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Mozos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mozos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVentas;
        private DataGridViewTextBoxColumn colComidas;
        private DataGridViewTextBoxColumn colSinAlcohol;
        private DataGridViewTextBoxColumn colConAlcohol;
        private DataGridViewTextBoxColumn colPostres;
        private Button btnValidar;
        private Button btnMozoDia;
        private Button btnTotales;
        private Label lblMejorMozo;
        private Label lblTotalGeneral;
        private Label lblTotalComidas;
        private Label lblTotalSinAlcohol;
        private Label lblTotalConAlcohol;
        private Label lblTotalPostres;
        private Button btnCancelar;
    }
}
