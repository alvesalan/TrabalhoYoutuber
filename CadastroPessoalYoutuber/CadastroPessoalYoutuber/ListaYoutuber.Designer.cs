namespace CadastroPessoalYoutuber
{
    partial class ListaYoutuber
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSenha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSobrenome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNickName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNacionalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIdade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRendaMensal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomeDoCanal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQTDInscritos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantidadeDeVisualizacoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantidadeMediaDeLikesPorVideo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantidadeDeVideos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPossueLive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPossueMonetizacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPossuePatrocinador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantidadeStricker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnLogin,
            this.ColumnSenha,
            this.ColumnNome,
            this.ColumnSobrenome,
            this.ColumnNickName,
            this.ColumnNacionalidade,
            this.ColumnIdade,
            this.ColumnRendaMensal,
            this.ColumnNomeDoCanal,
            this.ColumnCategoria,
            this.ColumnQTDInscritos,
            this.ColumnQuantidadeDeVisualizacoes,
            this.ColumnQuantidadeMediaDeLikesPorVideo,
            this.ColumnQuantidadeDeVideos,
            this.ColumnPossueLive,
            this.ColumnPossueMonetizacao,
            this.ColumnPossuePatrocinador,
            this.ColumnQuantidadeStricker,
            this.ColumnLink,
            this.ColumnDescricao});
            this.dataGridView1.Location = new System.Drawing.Point(12, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(941, 434);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 23);
            this.label1.TabIndex = 67;
            this.label1.Text = "APER A TECLA  (Ctrl + T) ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lime;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 23);
            this.label2.TabIndex = 66;
            this.label2.Text = "*PARA EXCUIR UM YOUTUBER\r\n";
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button3.BackColor = System.Drawing.Color.Lime;
            this.button3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 77);
            this.button3.TabIndex = 65;
            this.button3.Text = "VOLTAR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Lime;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(610, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 23);
            this.label3.TabIndex = 68;
            this.label3.Text = "*PARA EDITAR UM YOUTUBER\r\n";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Lime;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(633, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 23);
            this.label4.TabIndex = 69;
            this.label4.Text = "APERTE A TECLA (Ctrl + E)";
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "Codigo";
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.ReadOnly = true;
            // 
            // ColumnLogin
            // 
            this.ColumnLogin.HeaderText = "Login";
            this.ColumnLogin.Name = "ColumnLogin";
            this.ColumnLogin.ReadOnly = true;
            this.ColumnLogin.Width = 150;
            // 
            // ColumnSenha
            // 
            this.ColumnSenha.HeaderText = "Senha";
            this.ColumnSenha.Name = "ColumnSenha";
            this.ColumnSenha.ReadOnly = true;
            this.ColumnSenha.Width = 150;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            this.ColumnNome.Width = 150;
            // 
            // ColumnSobrenome
            // 
            this.ColumnSobrenome.HeaderText = "Sobrenome";
            this.ColumnSobrenome.Name = "ColumnSobrenome";
            this.ColumnSobrenome.ReadOnly = true;
            this.ColumnSobrenome.Width = 150;
            // 
            // ColumnNickName
            // 
            this.ColumnNickName.HeaderText = "Nick Name";
            this.ColumnNickName.Name = "ColumnNickName";
            this.ColumnNickName.ReadOnly = true;
            this.ColumnNickName.Width = 150;
            // 
            // ColumnNacionalidade
            // 
            this.ColumnNacionalidade.HeaderText = "Nacionalidade";
            this.ColumnNacionalidade.Name = "ColumnNacionalidade";
            this.ColumnNacionalidade.ReadOnly = true;
            this.ColumnNacionalidade.Width = 150;
            // 
            // ColumnIdade
            // 
            this.ColumnIdade.HeaderText = "Idade";
            this.ColumnIdade.Name = "ColumnIdade";
            this.ColumnIdade.ReadOnly = true;
            this.ColumnIdade.Width = 150;
            // 
            // ColumnRendaMensal
            // 
            this.ColumnRendaMensal.HeaderText = "Renda Mensal";
            this.ColumnRendaMensal.Name = "ColumnRendaMensal";
            this.ColumnRendaMensal.ReadOnly = true;
            this.ColumnRendaMensal.Width = 150;
            // 
            // ColumnNomeDoCanal
            // 
            this.ColumnNomeDoCanal.HeaderText = "Nome do Canal";
            this.ColumnNomeDoCanal.Name = "ColumnNomeDoCanal";
            this.ColumnNomeDoCanal.ReadOnly = true;
            this.ColumnNomeDoCanal.Width = 150;
            // 
            // ColumnCategoria
            // 
            this.ColumnCategoria.HeaderText = "Categoria";
            this.ColumnCategoria.Name = "ColumnCategoria";
            this.ColumnCategoria.ReadOnly = true;
            this.ColumnCategoria.Width = 150;
            // 
            // ColumnQTDInscritos
            // 
            this.ColumnQTDInscritos.HeaderText = "Quantidades de Inscritos";
            this.ColumnQTDInscritos.Name = "ColumnQTDInscritos";
            this.ColumnQTDInscritos.ReadOnly = true;
            this.ColumnQTDInscritos.Width = 150;
            // 
            // ColumnQuantidadeDeVisualizacoes
            // 
            this.ColumnQuantidadeDeVisualizacoes.HeaderText = "Quantidade de Visualizacões";
            this.ColumnQuantidadeDeVisualizacoes.Name = "ColumnQuantidadeDeVisualizacoes";
            this.ColumnQuantidadeDeVisualizacoes.ReadOnly = true;
            this.ColumnQuantidadeDeVisualizacoes.Width = 150;
            // 
            // ColumnQuantidadeMediaDeLikesPorVideo
            // 
            this.ColumnQuantidadeMediaDeLikesPorVideo.HeaderText = "Quantidade Media De Likes Por Video";
            this.ColumnQuantidadeMediaDeLikesPorVideo.Name = "ColumnQuantidadeMediaDeLikesPorVideo";
            this.ColumnQuantidadeMediaDeLikesPorVideo.ReadOnly = true;
            this.ColumnQuantidadeMediaDeLikesPorVideo.Width = 150;
            // 
            // ColumnQuantidadeDeVideos
            // 
            this.ColumnQuantidadeDeVideos.HeaderText = "Quantidade de Videos";
            this.ColumnQuantidadeDeVideos.Name = "ColumnQuantidadeDeVideos";
            this.ColumnQuantidadeDeVideos.ReadOnly = true;
            this.ColumnQuantidadeDeVideos.Width = 150;
            // 
            // ColumnPossueLive
            // 
            this.ColumnPossueLive.HeaderText = "PossueLive";
            this.ColumnPossueLive.Name = "ColumnPossueLive";
            this.ColumnPossueLive.ReadOnly = true;
            this.ColumnPossueLive.Width = 150;
            // 
            // ColumnPossueMonetizacao
            // 
            this.ColumnPossueMonetizacao.HeaderText = "Possue Monetização";
            this.ColumnPossueMonetizacao.Name = "ColumnPossueMonetizacao";
            this.ColumnPossueMonetizacao.ReadOnly = true;
            this.ColumnPossueMonetizacao.Width = 150;
            // 
            // ColumnPossuePatrocinador
            // 
            this.ColumnPossuePatrocinador.HeaderText = "Possue patrocinador";
            this.ColumnPossuePatrocinador.Name = "ColumnPossuePatrocinador";
            this.ColumnPossuePatrocinador.ReadOnly = true;
            this.ColumnPossuePatrocinador.Width = 150;
            // 
            // ColumnQuantidadeStricker
            // 
            this.ColumnQuantidadeStricker.HeaderText = "Quantidade de Stricker";
            this.ColumnQuantidadeStricker.Name = "ColumnQuantidadeStricker";
            this.ColumnQuantidadeStricker.ReadOnly = true;
            this.ColumnQuantidadeStricker.Width = 150;
            // 
            // ColumnLink
            // 
            this.ColumnLink.HeaderText = "Link";
            this.ColumnLink.Name = "ColumnLink";
            this.ColumnLink.ReadOnly = true;
            this.ColumnLink.Width = 150;
            // 
            // ColumnDescricao
            // 
            this.ColumnDescricao.HeaderText = "Descrição";
            this.ColumnDescricao.Name = "ColumnDescricao";
            this.ColumnDescricao.ReadOnly = true;
            this.ColumnDescricao.Width = 300;
            // 
            // ListaYoutuber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(965, 587);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.KeyPreview = true;
            this.Name = "ListaYoutuber";
            this.Text = "ListaCadastrosPessoais";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.ListaCadastrosPessoais_Activated);
            this.Load += new System.EventHandler(this.ListaCadastrosPessoais_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListaCadastrosPessoais_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSenha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSobrenome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNickName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNacionalidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRendaMensal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomeDoCanal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQTDInscritos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantidadeDeVisualizacoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantidadeMediaDeLikesPorVideo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantidadeDeVideos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPossueLive;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPossueMonetizacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPossuePatrocinador;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantidadeStricker;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLink;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescricao;
    }
}