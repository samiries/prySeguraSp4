namespace prySeguraSp4
{
    public partial class Mozos : Form
    {
        public Mozos()
        {
            InitializeComponent();
        }

        float[,] importes = new float[5, 4];
        string[] mozos = { "Julio", "Esteban", "Javier", "Gonzalo", "Alberto" };

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvVentas.Rows.Add(5);

            for (int i = 0; i < 5; i++)
            {
                dgvVentas.Rows[i].HeaderCell.Value = mozos[i];
            }

            lblTotalGeneral.Visible = false;
            lblTotalComidas.Visible = false;
            lblTotalSinAlcohol.Visible = false;
            lblTotalConAlcohol.Visible = false;
            lblTotalPostres.Visible = false;
            lblMejorMozo.Visible = false;

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            dgvVentas.EndEdit();

            bool hayError = false;
            float[,] temp = new float[5, 4];

            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    string texto = dgvVentas.Rows[f].Cells[c].Value?.ToString()?.Trim() ?? "";
                    float numero;

                    if (float.TryParse(texto, out numero))
                    {
                        temp[f, c] = numero;
                        dgvVentas.Rows[f].Cells[c].Style.BackColor = Color.White;
                    }
                    else
                    {
                        hayError = true;
                        dgvVentas.Rows[f].Cells[c].Style.BackColor = Color.MistyRose;
                    }
                }
            }

            if (hayError)
            {
                btnMozoDia.Enabled = false;
                btnTotales.Enabled = false;

                MessageBox.Show(
                    "Todas las celdas deben contener un valor numérico (se admite el cero).\n" +
                    "Revise las celdas marcadas en rojo.",
                    "Error de validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                importes = temp;
                btnMozoDia.Enabled = true;
                btnTotales.Enabled = true;

                MessageBox.Show("Datos válidos. Ya puede realizar las consultas.",
                    "Validación correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnMozoDia_Click(object sender, EventArgs e)
        {
            lblMejorMozo.Visible = true;
            float maxTotal = float.MinValue;
            int indiceMozo = -1;

            for (int f = 0; f < 5; f++)
            {
                float totalMozo = 0;

                for (int c = 0; c < 4; c++)
                {
                    totalMozo += importes[f, c];
                }

                if (totalMozo > maxTotal)
                {
                    maxTotal = totalMozo;
                    indiceMozo = f;
                }
            }
            lblMejorMozo.Visible = true;
            lblMejorMozo.Text = mozos[indiceMozo] + " " + maxTotal.ToString("C2");
        }

        private void btnTotales_Click(object sender, EventArgs e)
        {
            float[] totalesCategoria = new float[4];
            float totalGeneral = 0;

            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    totalesCategoria[c] += importes[f, c];
                    totalGeneral += importes[f, c];
                }
            }

            lblTotalGeneral.Text = "Total general: " + totalGeneral.ToString("C2");
            lblTotalComidas.Text = "Total por comidas: " + totalesCategoria[0].ToString("C2");
            lblTotalSinAlcohol.Text = "Total por bebidas sin alcohol: " + totalesCategoria[1].ToString("C2");
            lblTotalConAlcohol.Text = "Total por bebidas con alcohol: " + totalesCategoria[2].ToString("C2");
            lblTotalPostres.Text = "Total por postres: " + totalesCategoria[3].ToString("C2");

            lblTotalGeneral.Visible = true;
            lblTotalComidas.Visible = true;
            lblTotalSinAlcohol.Visible = true;
            lblTotalConAlcohol.Visible = true;
            lblTotalPostres.Visible = true;
        }

        private void dgvVentas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            btnMozoDia.Enabled = false;
            btnTotales.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblMozo1_Click(object sender, EventArgs e)
        {

        }

        private void dgvVentas_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            btnMozoDia.Enabled = false;
            btnTotales.Enabled = false;


            lblTotalGeneral.Visible = false;
            lblTotalComidas.Visible = false;
            lblTotalSinAlcohol.Visible = false;
            lblTotalConAlcohol.Visible = false;
            lblTotalPostres.Visible = false;
            lblMejorMozo.Visible = false;

        }
    }
}



    
