namespace listadetarefas
{
    partial class tarefas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.cmbPrioridade = new System.Windows.Forms.ComboBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbPrioridade1 = new System.Windows.Forms.ComboBox();
            this.lvDados = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dData = new System.Windows.Forms.DateTimePicker();
            this.lvInformacoes = new System.Windows.Forms.ListView();
            this.ColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnCancelar1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePickerFiltro = new System.Windows.Forms.DateTimePicker();
            this.cmbFiltrarPrioridade = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Tarefas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(14, 20);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(208, 39);
            this.txtDescricao.TabIndex = 2;
            // 
            // cmbPrioridade
            // 
            this.cmbPrioridade.FormattingEnabled = true;
            this.cmbPrioridade.Location = new System.Drawing.Point(19, 88);
            this.cmbPrioridade.Name = "cmbPrioridade";
            this.cmbPrioridade.Size = new System.Drawing.Size(208, 21);
            this.cmbPrioridade.TabIndex = 12;
            this.cmbPrioridade.SelectedIndexChanged += new System.EventHandler(this.cmbPrioridade_SelectedIndexChanged);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEditar.Location = new System.Drawing.Point(179, 368);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(73, 25);
            this.btnEditar.TabIndex = 14;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnExcluir.Location = new System.Drawing.Point(178, 414);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(74, 25);
            this.btnExcluir.TabIndex = 15;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRegistrar.Location = new System.Drawing.Point(17, 368);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 25);
            this.btnRegistrar.TabIndex = 17;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(14, 15);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(208, 20);
            this.txtCategoria.TabIndex = 20;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(237, -21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(10, 340);
            this.listBox1.TabIndex = 22;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.cmbPrioridade1);
            this.groupBox1.Controls.Add(this.lvDados);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.cmbPrioridade);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 45);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PRIORIDADE:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbPrioridade1
            // 
            this.cmbPrioridade1.FormattingEnabled = true;
            this.cmbPrioridade1.Location = new System.Drawing.Point(14, 18);
            this.cmbPrioridade1.Name = "cmbPrioridade1";
            this.cmbPrioridade1.Size = new System.Drawing.Size(208, 21);
            this.cmbPrioridade1.TabIndex = 31;
            // 
            // lvDados
            // 
            this.lvDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvDados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvDados.HideSelection = false;
            this.lvDados.Location = new System.Drawing.Point(257, 29);
            this.lvDados.Name = "lvDados";
            this.lvDados.Size = new System.Drawing.Size(0, 10);
            this.lvDados.TabIndex = 28;
            this.lvDados.UseCompatibleStateImageBehavior = false;
            this.lvDados.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "PRIORIDADE";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "CATEGORIA";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "TÍTULO";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "DESCRIÇÃO";
            this.columnHeader4.Width = 190;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "DATA";
            this.columnHeader5.Width = 70;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(174, 48);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(0, 0);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.txtDescricao);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(16, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 68);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DESCRIÇÃO:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox3.Controls.Add(this.txtCategoria);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(16, 120);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(236, 43);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CATEGORIA:";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox4.Controls.Add(this.txtTitulo);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(16, 169);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(236, 48);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "TÍTULO:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(14, 19);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(208, 20);
            this.txtTitulo.TabIndex = 28;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox5.Controls.Add(this.dData);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(17, 297);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(235, 53);
            this.groupBox5.TabIndex = 27;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "DATA:";
            // 
            // dData
            // 
            this.dData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dData.Location = new System.Drawing.Point(13, 19);
            this.dData.Name = "dData";
            this.dData.Size = new System.Drawing.Size(208, 20);
            this.dData.TabIndex = 30;
            // 
            // lvInformacoes
            // 
            this.lvInformacoes.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lvInformacoes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader,
            this.ColumnHeader7,
            this.ColumnHeader8,
            this.ColumnHeader9,
            this.ColumnHeader10});
            this.lvInformacoes.HideSelection = false;
            this.lvInformacoes.Location = new System.Drawing.Point(273, 36);
            this.lvInformacoes.Name = "lvInformacoes";
            this.lvInformacoes.Size = new System.Drawing.Size(528, 421);
            this.lvInformacoes.TabIndex = 28;
            this.lvInformacoes.UseCompatibleStateImageBehavior = false;
            this.lvInformacoes.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader
            // 
            this.ColumnHeader.Text = "PRIORIDADE";
            this.ColumnHeader.Width = 70;
            // 
            // ColumnHeader7
            // 
            this.ColumnHeader7.Text = "CATEGORIA";
            this.ColumnHeader7.Width = 100;
            // 
            // ColumnHeader8
            // 
            this.ColumnHeader8.Text = "TÍTULO";
            this.ColumnHeader8.Width = 100;
            // 
            // ColumnHeader9
            // 
            this.ColumnHeader9.Text = "DESCRIÇÃO";
            this.ColumnHeader9.Width = 190;
            // 
            // ColumnHeader10
            // 
            this.ColumnHeader10.Text = "DATA";
            this.ColumnHeader10.Width = 80;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-2, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(275, 452);
            this.listView1.TabIndex = 29;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnCancelar1
            // 
            this.btnCancelar1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCancelar1.Location = new System.Drawing.Point(17, 414);
            this.btnCancelar1.Name = "btnCancelar1";
            this.btnCancelar1.Size = new System.Drawing.Size(75, 24);
            this.btnCancelar1.TabIndex = 30;
            this.btnCancelar1.Text = "Cancelar";
            this.btnCancelar1.UseVisualStyleBackColor = false;
            this.btnCancelar1.Click += new System.EventHandler(this.btnCancelar1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox1.Location = new System.Drawing.Point(273, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(528, 40);
            this.textBox1.TabIndex = 31;
            // 
            // dateTimePickerFiltro
            // 
            this.dateTimePickerFiltro.CalendarForeColor = System.Drawing.SystemColors.Window;
            this.dateTimePickerFiltro.Location = new System.Drawing.Point(289, 10);
            this.dateTimePickerFiltro.Name = "dateTimePickerFiltro";
            this.dateTimePickerFiltro.Size = new System.Drawing.Size(178, 20);
            this.dateTimePickerFiltro.TabIndex = 32;
            this.dateTimePickerFiltro.ValueChanged += new System.EventHandler(this.dateTimePickerFiltro_ValueChanged);
            // 
            // cmbFiltrarPrioridade
            // 
            this.cmbFiltrarPrioridade.FormattingEnabled = true;
            this.cmbFiltrarPrioridade.Location = new System.Drawing.Point(499, 10);
            this.cmbFiltrarPrioridade.Name = "cmbFiltrarPrioridade";
            this.cmbFiltrarPrioridade.Size = new System.Drawing.Size(178, 21);
            this.cmbFiltrarPrioridade.TabIndex = 33;
            this.cmbFiltrarPrioridade.SelectedIndexChanged += new System.EventHandler(this.cmbFiltrarPrioridade_SelectedIndexChanged);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.SystemColors.Control;
            this.btnFiltrar.Location = new System.Drawing.Point(701, 8);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(78, 24);
            this.btnFiltrar.TabIndex = 34;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // tarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.cmbFiltrarPrioridade);
            this.Controls.Add(this.dateTimePickerFiltro);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCancelar1);
            this.Controls.Add(this.lvInformacoes);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "tarefas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tarefas";
            this.Load += new System.EventHandler(this.tarefas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.ComboBox cmbPrioridade;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListView lvDados;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.DateTimePicker dData;
        private System.Windows.Forms.ListView lvInformacoes;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ColumnHeader;
        private System.Windows.Forms.ColumnHeader ColumnHeader7;
        private System.Windows.Forms.ColumnHeader ColumnHeader8;
        private System.Windows.Forms.ColumnHeader ColumnHeader9;
        private System.Windows.Forms.ColumnHeader ColumnHeader10;
        private System.Windows.Forms.Button btnCancelar1;
        private System.Windows.Forms.ComboBox cmbPrioridade1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerFiltro;
        private System.Windows.Forms.ComboBox cmbFiltrarPrioridade;
        private System.Windows.Forms.Button btnFiltrar;
    }
}