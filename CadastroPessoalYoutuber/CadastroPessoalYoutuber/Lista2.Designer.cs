namespace CadastroPessoalYoutuber
{
    partial class Lista2
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
            this.ColumnNomeYoutubers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomedocanal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantidadeinscritos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNomeYoutubers,
            this.ColumnNomedocanal,
            this.ColumnQuantidadeinscritos});
            this.dataGridView1.Location = new System.Drawing.Point(127, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(579, 796);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColumnNomeYoutubers
            // 
            this.ColumnNomeYoutubers.HeaderText = "Nome Do Youtuber";
            this.ColumnNomeYoutubers.Name = "ColumnNomeYoutubers";
            this.ColumnNomeYoutubers.Width = 173;
            // 
            // ColumnNomedocanal
            // 
            this.ColumnNomedocanal.HeaderText = "Nome do canal";
            this.ColumnNomedocanal.Name = "ColumnNomedocanal";
            this.ColumnNomedocanal.Width = 172;
            // 
            // ColumnQuantidadeinscritos
            // 
            this.ColumnQuantidadeinscritos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnQuantidadeinscritos.HeaderText = "Quantidades de inscritos";
            this.ColumnQuantidadeinscritos.Name = "ColumnQuantidadeinscritos";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Lime;
            this.label3.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(199, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(468, 39);
            this.label3.TabIndex = 21;
            this.label3.Text = "YOUTUBERS CADASTRADOS";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lime;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(574, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "PARA VOLTA A PAGINA ANTERIOR APERTE O BOTÃO *ESC";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(717, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lista2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(814, 858);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Lista2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LISTA DOS YOUTUBERS";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomeYoutubers;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomedocanal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantidadeinscritos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}