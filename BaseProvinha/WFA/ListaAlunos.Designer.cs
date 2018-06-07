namespace WFA
{
    partial class ListaAlunos
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
            this.btnApagarAluno = new System.Windows.Forms.Button();
            this.btnEditarAluno = new System.Windows.Forms.Button();
            this.btnAdicionarAluno = new System.Windows.Forms.Button();
            this.Column1Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1Turma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1Turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1Idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1Codigo,
            this.ColumnNome,
            this.Column1Turma,
            this.Column1Turno,
            this.Column1Idade});
            this.dataGridView1.Location = new System.Drawing.Point(22, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(470, 407);
            this.dataGridView1.TabIndex = 18;
            // 
            // btnApagarAluno
            // 
            this.btnApagarAluno.BackColor = System.Drawing.Color.DarkRed;
            this.btnApagarAluno.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagarAluno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnApagarAluno.Location = new System.Drawing.Point(347, 12);
            this.btnApagarAluno.Name = "btnApagarAluno";
            this.btnApagarAluno.Size = new System.Drawing.Size(140, 36);
            this.btnApagarAluno.TabIndex = 17;
            this.btnApagarAluno.Text = "APAGAR";
            this.btnApagarAluno.UseVisualStyleBackColor = false;
            // 
            // btnEditarAluno
            // 
            this.btnEditarAluno.BackColor = System.Drawing.Color.DarkRed;
            this.btnEditarAluno.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarAluno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarAluno.Location = new System.Drawing.Point(27, 12);
            this.btnEditarAluno.Name = "btnEditarAluno";
            this.btnEditarAluno.Size = new System.Drawing.Size(140, 36);
            this.btnEditarAluno.TabIndex = 20;
            this.btnEditarAluno.Text = "EDITAR";
            this.btnEditarAluno.UseVisualStyleBackColor = false;
            // 
            // btnAdicionarAluno
            // 
            this.btnAdicionarAluno.BackColor = System.Drawing.Color.DarkRed;
            this.btnAdicionarAluno.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarAluno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdicionarAluno.Location = new System.Drawing.Point(188, 12);
            this.btnAdicionarAluno.Name = "btnAdicionarAluno";
            this.btnAdicionarAluno.Size = new System.Drawing.Size(140, 36);
            this.btnAdicionarAluno.TabIndex = 19;
            this.btnAdicionarAluno.Text = "ADICIONAR";
            this.btnAdicionarAluno.UseVisualStyleBackColor = false;
            this.btnAdicionarAluno.Click += new System.EventHandler(this.btnAdicionarAluno_Click);
            // 
            // Column1Codigo
            // 
            this.Column1Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1Codigo.HeaderText = "Código";
            this.Column1Codigo.Name = "Column1Codigo";
            this.Column1Codigo.ReadOnly = true;
            // 
            // ColumnNome
            // 
            this.ColumnNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            // 
            // Column1Turma
            // 
            this.Column1Turma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1Turma.HeaderText = "Turma";
            this.Column1Turma.Name = "Column1Turma";
            this.Column1Turma.ReadOnly = true;
            // 
            // Column1Turno
            // 
            this.Column1Turno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1Turno.HeaderText = "Turno";
            this.Column1Turno.Name = "Column1Turno";
            this.Column1Turno.ReadOnly = true;
            // 
            // Column1Idade
            // 
            this.Column1Idade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1Idade.HeaderText = "Idade";
            this.Column1Idade.Name = "Column1Idade";
            this.Column1Idade.ReadOnly = true;
            // 
            // ListaAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(516, 497);
            this.Controls.Add(this.btnEditarAluno);
            this.Controls.Add(this.btnAdicionarAluno);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnApagarAluno);
            this.Name = "ListaAlunos";
            this.Text = "ListaAlunos";
            this.Activated += new System.EventHandler(this.ListaAlunos_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnApagarAluno;
        private System.Windows.Forms.Button btnEditarAluno;
        private System.Windows.Forms.Button btnAdicionarAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1Turma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1Turno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1Idade;
    }
}