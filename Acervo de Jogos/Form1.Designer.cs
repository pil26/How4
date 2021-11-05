
namespace Acervo_de_Jogos
{
    partial class Form1
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
            System.Windows.Forms.Button btAlterar;
            System.Windows.Forms.Button btDelete;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbCategoria = new System.Windows.Forms.TextBox();
            this.tbPlataforma = new System.Windows.Forms.TextBox();
            this.tbMidia = new System.Windows.Forms.TextBox();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.tbCondic = new System.Windows.Forms.TextBox();
            this.tbData = new System.Windows.Forms.TextBox();
            this.btLimpar = new System.Windows.Forms.Button();
            this.dgAcervo = new System.Windows.Forms.DataGridView();
            this.btInserir = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCod = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.colCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlataforma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMidia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCondicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btAlterar = new System.Windows.Forms.Button();
            btDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAcervo)).BeginInit();
            this.SuspendLayout();
            // 
            // btAlterar
            // 
            btAlterar.Anchor = System.Windows.Forms.AnchorStyles.None;
            btAlterar.BackColor = System.Drawing.Color.Gold;
            btAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btAlterar.Cursor = System.Windows.Forms.Cursors.Default;
            btAlterar.Font = new System.Drawing.Font("Earth Orbiter Expanded", 12F, System.Drawing.FontStyle.Bold);
            btAlterar.ForeColor = System.Drawing.Color.White;
            btAlterar.Location = new System.Drawing.Point(496, 256);
            btAlterar.Name = "btAlterar";
            btAlterar.Size = new System.Drawing.Size(126, 56);
            btAlterar.TabIndex = 17;
            btAlterar.Text = "ALTERAR";
            btAlterar.UseVisualStyleBackColor = false;
            btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btDelete
            // 
            btDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            btDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            btDelete.BackColor = System.Drawing.Color.Red;
            btDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btDelete.Font = new System.Drawing.Font("Earth Orbiter Expanded", 12F, System.Drawing.FontStyle.Bold);
            btDelete.ForeColor = System.Drawing.Color.White;
            btDelete.Location = new System.Drawing.Point(744, 256);
            btDelete.Name = "btDelete";
            btDelete.Size = new System.Drawing.Size(126, 56);
            btDelete.TabIndex = 20;
            btDelete.Text = "DELETAR";
            btDelete.UseVisualStyleBackColor = false;
            btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Earth Orbiter Expanded", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Earth Orbiter Expanded", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "CATEGORIA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Earth Orbiter Expanded", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(292, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "PLATAFORMA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Earth Orbiter Expanded", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(363, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "MÍDIA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Earth Orbiter Expanded", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(364, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "VALOR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Earth Orbiter Expanded", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(680, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "CONDIÇÃO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Earth Orbiter Expanded", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(605, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "DATA DA COMPRA";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(158, 168);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(178, 20);
            this.tbNome.TabIndex = 7;
            // 
            // tbCategoria
            // 
            this.tbCategoria.Location = new System.Drawing.Point(158, 204);
            this.tbCategoria.Name = "tbCategoria";
            this.tbCategoria.Size = new System.Drawing.Size(178, 20);
            this.tbCategoria.TabIndex = 8;
            // 
            // tbPlataforma
            // 
            this.tbPlataforma.Location = new System.Drawing.Point(480, 128);
            this.tbPlataforma.Name = "tbPlataforma";
            this.tbPlataforma.Size = new System.Drawing.Size(133, 20);
            this.tbPlataforma.TabIndex = 9;
            // 
            // tbMidia
            // 
            this.tbMidia.Location = new System.Drawing.Point(480, 168);
            this.tbMidia.Name = "tbMidia";
            this.tbMidia.Size = new System.Drawing.Size(65, 20);
            this.tbMidia.TabIndex = 10;
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(480, 202);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(65, 20);
            this.tbValor.TabIndex = 11;
            // 
            // tbCondic
            // 
            this.tbCondic.Location = new System.Drawing.Point(814, 129);
            this.tbCondic.Name = "tbCondic";
            this.tbCondic.Size = new System.Drawing.Size(65, 20);
            this.tbCondic.TabIndex = 12;
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(812, 164);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(67, 20);
            this.tbData.TabIndex = 13;
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btLimpar.Font = new System.Drawing.Font("Earth Orbiter Expanded", 12F, System.Drawing.FontStyle.Bold);
            this.btLimpar.ForeColor = System.Drawing.Color.White;
            this.btLimpar.Location = new System.Drawing.Point(30, 256);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(126, 56);
            this.btLimpar.TabIndex = 14;
            this.btLimpar.Text = "LIMPAR";
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // dgAcervo
            // 
            this.dgAcervo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgAcervo.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgAcervo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgAcervo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAcervo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCod,
            this.colNome,
            this.colCategoria,
            this.colPlataforma,
            this.colMidia,
            this.colValor,
            this.colCondicao,
            this.colData});
            this.dgAcervo.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgAcervo.Location = new System.Drawing.Point(30, 341);
            this.dgAcervo.Name = "dgAcervo";
            this.dgAcervo.Size = new System.Drawing.Size(840, 344);
            this.dgAcervo.TabIndex = 15;
            this.dgAcervo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAcervo_CellContentClick);
            this.dgAcervo.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAcervo_CellContentClick);
            // 
            // btInserir
            // 
            this.btInserir.BackColor = System.Drawing.Color.LimeGreen;
            this.btInserir.Font = new System.Drawing.Font("Earth Orbiter Expanded", 12F, System.Drawing.FontStyle.Bold);
            this.btInserir.ForeColor = System.Drawing.Color.White;
            this.btInserir.Location = new System.Drawing.Point(261, 256);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(126, 56);
            this.btInserir.TabIndex = 16;
            this.btInserir.Text = "INSERIR";
            this.btInserir.UseVisualStyleBackColor = false;
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Earth Orbiter Expanded", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(14, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Cód.";
            // 
            // tbCod
            // 
            this.tbCod.Enabled = false;
            this.tbCod.Location = new System.Drawing.Point(158, 133);
            this.tbCod.Name = "tbCod";
            this.tbCod.Size = new System.Drawing.Size(49, 20);
            this.tbCod.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Earth Orbiter Expanded", 32F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(174, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(544, 43);
            this.label9.TabIndex = 21;
            this.label9.Text = "ACERVO DE JOGOS";
            // 
            // colCod
            // 
            this.colCod.HeaderText = "Cod.";
            this.colCod.Name = "colCod";
            this.colCod.Width = 50;
            // 
            // colNome
            // 
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.Width = 177;
            // 
            // colCategoria
            // 
            this.colCategoria.HeaderText = "Categoria";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.Width = 150;
            // 
            // colPlataforma
            // 
            this.colPlataforma.HeaderText = "Plataforma";
            this.colPlataforma.Name = "colPlataforma";
            // 
            // colMidia
            // 
            this.colMidia.HeaderText = "Mídia";
            this.colMidia.Name = "colMidia";
            this.colMidia.Width = 80;
            // 
            // colValor
            // 
            this.colValor.HeaderText = "Valor";
            this.colValor.Name = "colValor";
            this.colValor.Width = 50;
            // 
            // colCondicao
            // 
            this.colCondicao.HeaderText = "Condição";
            this.colCondicao.Name = "colCondicao";
            // 
            // colData
            // 
            this.colData.HeaderText = "Data";
            this.colData.Name = "colData";
            this.colData.Width = 70;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(903, 714);
            this.Controls.Add(this.label9);
            this.Controls.Add(btDelete);
            this.Controls.Add(this.tbCod);
            this.Controls.Add(this.label8);
            this.Controls.Add(btAlterar);
            this.Controls.Add(this.btInserir);
            this.Controls.Add(this.dgAcervo);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.tbCondic);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.tbMidia);
            this.Controls.Add(this.tbPlataforma);
            this.Controls.Add(this.tbCategoria);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Acervo de Jogos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAcervo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbCategoria;
        private System.Windows.Forms.TextBox tbPlataforma;
        private System.Windows.Forms.TextBox tbMidia;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.TextBox tbCondic;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.DataGridView dgAcervo;
        private System.Windows.Forms.Button btInserir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCod;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlataforma;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMidia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCondicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
    }
}

