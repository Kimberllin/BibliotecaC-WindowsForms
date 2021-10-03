
namespace Sistema_Biblioteca
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
            this.txb_nome = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_descricao = new System.Windows.Forms.Label();
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.lbl_editora = new System.Windows.Forms.Label();
            this.lbl_autor = new System.Windows.Forms.Label();
            this.txb_status = new System.Windows.Forms.TextBox();
            this.txb_descricao = new System.Windows.Forms.TextBox();
            this.txb_categoria = new System.Windows.Forms.TextBox();
            this.txb_editora = new System.Windows.Forms.TextBox();
            this.txb_autor = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_editora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_inserir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_nome
            // 
            this.txb_nome.Location = new System.Drawing.Point(53, 35);
            this.txb_nome.Name = "txb_nome";
            this.txb_nome.Size = new System.Drawing.Size(71, 20);
            this.txb_nome.TabIndex = 0;
            this.txb_nome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(12, 38);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome.TabIndex = 6;
            this.lbl_nome.Text = "Nome";
            this.lbl_nome.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(641, 38);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(37, 13);
            this.lbl_status.TabIndex = 7;
            this.lbl_status.Text = "Status";
            // 
            // lbl_descricao
            // 
            this.lbl_descricao.AutoSize = true;
            this.lbl_descricao.Location = new System.Drawing.Point(503, 38);
            this.lbl_descricao.Name = "lbl_descricao";
            this.lbl_descricao.Size = new System.Drawing.Size(55, 13);
            this.lbl_descricao.TabIndex = 8;
            this.lbl_descricao.Text = "Descrição";
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Location = new System.Drawing.Point(368, 38);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(52, 13);
            this.lbl_categoria.TabIndex = 9;
            this.lbl_categoria.Text = "Categoria";
            // 
            // lbl_editora
            // 
            this.lbl_editora.AutoSize = true;
            this.lbl_editora.Location = new System.Drawing.Point(245, 38);
            this.lbl_editora.Name = "lbl_editora";
            this.lbl_editora.Size = new System.Drawing.Size(40, 13);
            this.lbl_editora.TabIndex = 10;
            this.lbl_editora.Text = "Editora";
            // 
            // lbl_autor
            // 
            this.lbl_autor.AutoSize = true;
            this.lbl_autor.Location = new System.Drawing.Point(130, 38);
            this.lbl_autor.Name = "lbl_autor";
            this.lbl_autor.Size = new System.Drawing.Size(32, 13);
            this.lbl_autor.TabIndex = 11;
            this.lbl_autor.Text = "Autor";
            // 
            // txb_status
            // 
            this.txb_status.Location = new System.Drawing.Point(684, 35);
            this.txb_status.Name = "txb_status";
            this.txb_status.Size = new System.Drawing.Size(71, 20);
            this.txb_status.TabIndex = 12;
            // 
            // txb_descricao
            // 
            this.txb_descricao.Location = new System.Drawing.Point(564, 35);
            this.txb_descricao.Name = "txb_descricao";
            this.txb_descricao.Size = new System.Drawing.Size(71, 20);
            this.txb_descricao.TabIndex = 13;
            // 
            // txb_categoria
            // 
            this.txb_categoria.Location = new System.Drawing.Point(426, 35);
            this.txb_categoria.Name = "txb_categoria";
            this.txb_categoria.Size = new System.Drawing.Size(71, 20);
            this.txb_categoria.TabIndex = 14;
            // 
            // txb_editora
            // 
            this.txb_editora.Location = new System.Drawing.Point(291, 35);
            this.txb_editora.Name = "txb_editora";
            this.txb_editora.Size = new System.Drawing.Size(71, 20);
            this.txb_editora.TabIndex = 15;
            // 
            // txb_autor
            // 
            this.txb_autor.Location = new System.Drawing.Point(168, 35);
            this.txb_autor.Name = "txb_autor";
            this.txb_autor.Size = new System.Drawing.Size(71, 20);
            this.txb_autor.TabIndex = 16;
            this.txb_autor.TextChanged += new System.EventHandler(this.txb_autor_TextChanged);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(15, 85);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 17;
            this.btn_save.Text = "SALVAR";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(107, 85);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 18;
            this.btn_Clear.Text = "LIMPAR";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id,
            this.col_nome,
            this.col_autor,
            this.col_editora,
            this.col_categoria,
            this.col_descricao,
            this.col_status});
            this.dataGridView1.Location = new System.Drawing.Point(12, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(755, 270);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // col_id
            // 
            this.col_id.HeaderText = "ID";
            this.col_id.Name = "col_id";
            this.col_id.Width = 50;
            // 
            // col_nome
            // 
            this.col_nome.HeaderText = "Nome";
            this.col_nome.Name = "col_nome";
            this.col_nome.Width = 150;
            // 
            // col_autor
            // 
            this.col_autor.HeaderText = "Autor";
            this.col_autor.Name = "col_autor";
            // 
            // col_editora
            // 
            this.col_editora.HeaderText = "Editora";
            this.col_editora.Name = "col_editora";
            // 
            // col_categoria
            // 
            this.col_categoria.HeaderText = "Categoria";
            this.col_categoria.Name = "col_categoria";
            // 
            // col_descricao
            // 
            this.col_descricao.HeaderText = "Descrição";
            this.col_descricao.Name = "col_descricao";
            this.col_descricao.Width = 150;
            // 
            // col_status
            // 
            this.col_status.HeaderText = "Status";
            this.col_status.Name = "col_status";
            this.col_status.Width = 70;
            // 
            // btn_inserir
            // 
            this.btn_inserir.Location = new System.Drawing.Point(201, 85);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(75, 23);
            this.btn_inserir.TabIndex = 20;
            this.btn_inserir.Text = "INSERIR";
            this.btn_inserir.UseVisualStyleBackColor = true;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 415);
            this.Controls.Add(this.btn_inserir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txb_autor);
            this.Controls.Add(this.txb_editora);
            this.Controls.Add(this.txb_categoria);
            this.Controls.Add(this.txb_descricao);
            this.Controls.Add(this.txb_status);
            this.Controls.Add(this.lbl_autor);
            this.Controls.Add(this.lbl_editora);
            this.Controls.Add(this.lbl_categoria);
            this.Controls.Add(this.lbl_descricao);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.txb_nome);
            this.Name = "Form1";
            this.Text = "Biblioteca";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_nome;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_descricao;
        private System.Windows.Forms.Label lbl_categoria;
        private System.Windows.Forms.Label lbl_editora;
        private System.Windows.Forms.Label lbl_autor;
        private System.Windows.Forms.TextBox txb_status;
        private System.Windows.Forms.TextBox txb_descricao;
        private System.Windows.Forms.TextBox txb_categoria;
        private System.Windows.Forms.TextBox txb_editora;
        private System.Windows.Forms.TextBox txb_autor;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_editora;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_status;
        private System.Windows.Forms.Button btn_inserir;
    }
}

