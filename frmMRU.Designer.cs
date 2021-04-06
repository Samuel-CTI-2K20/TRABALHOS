
namespace MRU
{
    partial class frmMRU
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMRU));
            this.lblEspacoinicial = new System.Windows.Forms.Label();
            this.lblVelocidade = new System.Windows.Forms.Label();
            this.lblTempo = new System.Windows.Forms.Label();
            this.lblMetros = new System.Windows.Forms.Label();
            this.lblMetrosporSegundo = new System.Windows.Forms.Label();
            this.lblSegundos = new System.Windows.Forms.Label();
            this.picFuncaohoraria = new System.Windows.Forms.PictureBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.picEQMRU = new System.Windows.Forms.PictureBox();
            this.lblEspacofinal = new System.Windows.Forms.Label();
            this.numEspacoInicial = new System.Windows.Forms.NumericUpDown();
            this.numVelocidade = new System.Windows.Forms.NumericUpDown();
            this.numTempo = new System.Windows.Forms.NumericUpDown();
            this.radMetros = new System.Windows.Forms.RadioButton();
            this.radKM = new System.Windows.Forms.RadioButton();
            this.lblmetros2 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFuncaohoraria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEQMRU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEspacoInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVelocidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTempo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEspacoinicial
            // 
            this.lblEspacoinicial.AutoSize = true;
            this.lblEspacoinicial.BackColor = System.Drawing.Color.White;
            this.lblEspacoinicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspacoinicial.ForeColor = System.Drawing.Color.Black;
            this.lblEspacoinicial.Location = new System.Drawing.Point(23, 240);
            this.lblEspacoinicial.Name = "lblEspacoinicial";
            this.lblEspacoinicial.Size = new System.Drawing.Size(106, 16);
            this.lblEspacoinicial.TabIndex = 0;
            this.lblEspacoinicial.Text = "Espaço Inicial";
            this.lblEspacoinicial.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblVelocidade
            // 
            this.lblVelocidade.AutoSize = true;
            this.lblVelocidade.BackColor = System.Drawing.Color.White;
            this.lblVelocidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVelocidade.ForeColor = System.Drawing.Color.Black;
            this.lblVelocidade.Location = new System.Drawing.Point(23, 305);
            this.lblVelocidade.Name = "lblVelocidade";
            this.lblVelocidade.Size = new System.Drawing.Size(88, 16);
            this.lblVelocidade.TabIndex = 0;
            this.lblVelocidade.Text = "Velocidade";
            this.lblVelocidade.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.BackColor = System.Drawing.Color.White;
            this.lblTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.ForeColor = System.Drawing.Color.Black;
            this.lblTempo.Location = new System.Drawing.Point(23, 366);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(57, 16);
            this.lblTempo.TabIndex = 0;
            this.lblTempo.Text = "Tempo";
            // 
            // lblMetros
            // 
            this.lblMetros.AutoSize = true;
            this.lblMetros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetros.Location = new System.Drawing.Point(261, 240);
            this.lblMetros.Name = "lblMetros";
            this.lblMetros.Size = new System.Drawing.Size(44, 13);
            this.lblMetros.TabIndex = 0;
            this.lblMetros.Text = "metros";
            this.lblMetros.Click += new System.EventHandler(this.lblMetros_Click);
            // 
            // lblMetrosporSegundo
            // 
            this.lblMetrosporSegundo.AutoSize = true;
            this.lblMetrosporSegundo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetrosporSegundo.Location = new System.Drawing.Point(261, 305);
            this.lblMetrosporSegundo.Name = "lblMetrosporSegundo";
            this.lblMetrosporSegundo.Size = new System.Drawing.Size(98, 13);
            this.lblMetrosporSegundo.TabIndex = 0;
            this.lblMetrosporSegundo.Text = "metros/segundo";
            // 
            // lblSegundos
            // 
            this.lblSegundos.AutoSize = true;
            this.lblSegundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundos.Location = new System.Drawing.Point(261, 368);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(61, 13);
            this.lblSegundos.TabIndex = 0;
            this.lblSegundos.Text = "segundos";
            // 
            // picFuncaohoraria
            // 
            this.picFuncaohoraria.Image = ((System.Drawing.Image)(resources.GetObject("picFuncaohoraria.Image")));
            this.picFuncaohoraria.Location = new System.Drawing.Point(12, 5);
            this.picFuncaohoraria.Name = "picFuncaohoraria";
            this.picFuncaohoraria.Size = new System.Drawing.Size(355, 171);
            this.picFuncaohoraria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFuncaohoraria.TabIndex = 6;
            this.picFuncaohoraria.TabStop = false;
            this.picFuncaohoraria.Click += new System.EventHandler(this.picFuncaohoraria_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalcular.Location = new System.Drawing.Point(135, 414);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNovo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNovo.Location = new System.Drawing.Point(529, 358);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 7;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.Location = new System.Drawing.Point(529, 414);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sai&r";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // picEQMRU
            // 
            this.picEQMRU.Image = ((System.Drawing.Image)(resources.GetObject("picEQMRU.Image")));
            this.picEQMRU.Location = new System.Drawing.Point(373, 5);
            this.picEQMRU.Name = "picEQMRU";
            this.picEQMRU.Size = new System.Drawing.Size(325, 171);
            this.picEQMRU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEQMRU.TabIndex = 13;
            this.picEQMRU.TabStop = false;
            // 
            // lblEspacofinal
            // 
            this.lblEspacofinal.AutoSize = true;
            this.lblEspacofinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspacofinal.ForeColor = System.Drawing.Color.Black;
            this.lblEspacofinal.Location = new System.Drawing.Point(413, 218);
            this.lblEspacofinal.Name = "lblEspacofinal";
            this.lblEspacofinal.Size = new System.Drawing.Size(99, 16);
            this.lblEspacofinal.TabIndex = 0;
            this.lblEspacofinal.Text = "Espaço Final";
            this.lblEspacofinal.Click += new System.EventHandler(this.lblEspacofinal_Click);
            // 
            // numEspacoInicial
            // 
            this.numEspacoInicial.DecimalPlaces = 2;
            this.numEspacoInicial.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numEspacoInicial.Location = new System.Drawing.Point(135, 238);
            this.numEspacoInicial.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numEspacoInicial.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
            this.numEspacoInicial.Name = "numEspacoInicial";
            this.numEspacoInicial.Size = new System.Drawing.Size(120, 20);
            this.numEspacoInicial.TabIndex = 3;
            this.numEspacoInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numEspacoInicial.ValueChanged += new System.EventHandler(this.numEspacoInicial_ValueChanged);
            // 
            // numVelocidade
            // 
            this.numVelocidade.DecimalPlaces = 2;
            this.numVelocidade.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numVelocidade.Location = new System.Drawing.Point(135, 305);
            this.numVelocidade.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numVelocidade.Minimum = new decimal(new int[] {
            1410065407,
            2,
            0,
            -2147483648});
            this.numVelocidade.Name = "numVelocidade";
            this.numVelocidade.Size = new System.Drawing.Size(120, 20);
            this.numVelocidade.TabIndex = 4;
            this.numVelocidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numVelocidade.ValueChanged += new System.EventHandler(this.numVelocidade_ValueChanged);
            // 
            // numTempo
            // 
            this.numTempo.DecimalPlaces = 2;
            this.numTempo.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numTempo.Location = new System.Drawing.Point(135, 362);
            this.numTempo.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numTempo.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.numTempo.Name = "numTempo";
            this.numTempo.Size = new System.Drawing.Size(120, 20);
            this.numTempo.TabIndex = 5;
            this.numTempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numTempo.ValueChanged += new System.EventHandler(this.numTempo_ValueChanged);
            // 
            // radMetros
            // 
            this.radMetros.AutoSize = true;
            this.radMetros.Checked = true;
            this.radMetros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMetros.Location = new System.Drawing.Point(36, 182);
            this.radMetros.Name = "radMetros";
            this.radMetros.Size = new System.Drawing.Size(63, 17);
            this.radMetros.TabIndex = 1;
            this.radMetros.TabStop = true;
            this.radMetros.Text = "Metros";
            this.radMetros.UseVisualStyleBackColor = true;
            this.radMetros.CheckedChanged += new System.EventHandler(this.radMetros_CheckedChanged);
            this.radMetros.Click += new System.EventHandler(this.radMetros_Click);
            // 
            // radKM
            // 
            this.radKM.AutoSize = true;
            this.radKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radKM.Location = new System.Drawing.Point(105, 182);
            this.radKM.Name = "radKM";
            this.radKM.Size = new System.Drawing.Size(115, 17);
            this.radKM.TabIndex = 2;
            this.radKM.TabStop = true;
            this.radKM.Text = "Quilômetros(km)";
            this.radKM.UseVisualStyleBackColor = true;
            this.radKM.Click += new System.EventHandler(this.radKM_Click);
            // 
            // lblmetros2
            // 
            this.lblmetros2.AutoSize = true;
            this.lblmetros2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmetros2.Location = new System.Drawing.Point(611, 269);
            this.lblmetros2.Name = "lblmetros2";
            this.lblmetros2.Size = new System.Drawing.Size(45, 13);
            this.lblmetros2.TabIndex = 0;
            this.lblmetros2.Text = "Metros";
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(413, 242);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(191, 79);
            this.lblResultado.TabIndex = 14;
            this.lblResultado.Text = "\r\n";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // frmMRU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(722, 505);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblmetros2);
            this.Controls.Add(this.radKM);
            this.Controls.Add(this.radMetros);
            this.Controls.Add(this.numTempo);
            this.Controls.Add(this.numVelocidade);
            this.Controls.Add(this.numEspacoInicial);
            this.Controls.Add(this.lblEspacofinal);
            this.Controls.Add(this.picEQMRU);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.picFuncaohoraria);
            this.Controls.Add(this.lblSegundos);
            this.Controls.Add(this.lblMetrosporSegundo);
            this.Controls.Add(this.lblMetros);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.lblVelocidade);
            this.Controls.Add(this.lblEspacoinicial);
            this.Name = "frmMRU";
            this.Text = "MRU ";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.Load += new System.EventHandler(this.frmMRU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFuncaohoraria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEQMRU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEspacoInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVelocidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTempo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEspacoinicial;
        private System.Windows.Forms.Label lblVelocidade;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Label lblMetros;
        private System.Windows.Forms.Label lblMetrosporSegundo;
        private System.Windows.Forms.Label lblSegundos;
        private System.Windows.Forms.PictureBox picFuncaohoraria;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox picEQMRU;
        private System.Windows.Forms.Label lblEspacofinal;
        private System.Windows.Forms.NumericUpDown numEspacoInicial;
        private System.Windows.Forms.NumericUpDown numVelocidade;
        private System.Windows.Forms.NumericUpDown numTempo;
        private System.Windows.Forms.RadioButton radMetros;
        private System.Windows.Forms.RadioButton radKM;
        private System.Windows.Forms.Label lblmetros2;
        private System.Windows.Forms.Label lblResultado;
    }
}

