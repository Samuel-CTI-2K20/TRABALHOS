using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRU
{
    public partial class frmMRU : Form
    {
        public frmMRU()
        {
            InitializeComponent();
        }

        private void frmMRU_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void picFuncaohoraria_Click(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            numEspacoInicial.Value = 0;
            numVelocidade.Value = 0;
            numTempo.Value = 0;
  
            numEspacoInicial.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            const string mensagem =
                "Deseja realmente sair do programa?";
            const string fechamento = "Form Fechando...";
            var resultado = MessageBox.Show(mensagem, fechamento,
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
          
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            if (numTempo.Value < 0 || numEspacoInicial.Value < 0 || numVelocidade.Value < 0  )
            {
                MessageBox.Show("O valor não pode ser negativo!!!", "Cálculo do MRU", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;            
            }



            //calculo do mru
            decimal EspacoFinal = CalcularEspacoFinal(numEspacoInicial.Value, 
                            numVelocidade.Value,
                            numTempo.Value);

            lblResultado.Text = EspacoFinal.ToString("#,##0.000");

                            
        }

        private decimal CalcularEspacoFinal(decimal espacoInicial,
                                            decimal velocidade,
                                            decimal tempo)
        {
            decimal espacoFinal = 0;

            espacoFinal = espacoInicial + velocidade * tempo;

            return espacoFinal;
        }

        private void radMetros_Click(object sender, EventArgs e)
        {
            
            
            lblMetros.Text = "Metros";
            lblMetrosporSegundo.Text = "metros/segundo";
            lblSegundos.Text = "segundos";
            lblmetros2.Text = "metros";

                numEspacoInicial.Value = numEspacoInicial.Value * (decimal)1000.0;

                numVelocidade.Value = numVelocidade.Value / (decimal)3.6;

                numTempo.Value = numTempo.Value * (decimal)3600.0;




        }

        private void radKM_Click(object sender, EventArgs e)
        {
            lblMetros.Text = "KM";
            lblMetrosporSegundo.Text = "KM/H";
            lblSegundos.Text = "HORAS";
            lblmetros2.Text = "KM";

            numEspacoInicial.Value = numEspacoInicial.Value / (decimal)1000.0;

                numVelocidade.Value = numVelocidade.Value * (decimal)3.6;

                numTempo.Value = numTempo.Value / (decimal)3600.0;




        }

        private void txtEspacoFinal_TextChanged(object sender, EventArgs e)
        {

        }

        private void radMetros_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numEspacoInicial_ValueChanged(object sender, EventArgs e)
        {
            decimal EspacoFinal = CalcularEspacoFinal(numEspacoInicial.Value,
                                    numVelocidade.Value, numTempo.Value);
            lblResultado.Text = EspacoFinal.ToString("#,##0.00");
        }

        private void numVelocidade_ValueChanged(object sender, EventArgs e)
        {
            decimal EspacoFinal = CalcularEspacoFinal(numEspacoInicial.Value,
                                    numVelocidade.Value, numTempo.Value);
            lblResultado.Text = EspacoFinal.ToString("#,##0.00");
        }

        private void numTempo_ValueChanged(object sender, EventArgs e)
        {
            decimal EspacoFinal = CalcularEspacoFinal(numEspacoInicial.Value,
                                    numVelocidade.Value, numTempo.Value);
            lblResultado.Text = EspacoFinal.ToString("#,##0.00");
        }

        private void lblMetros_Click(object sender, EventArgs e)
        {

        }

        private void lblEspacofinal_Click(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
