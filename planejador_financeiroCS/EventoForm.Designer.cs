namespace planejador_financeiroCS
{
    partial class EventoForm
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
            lblTitulo = new Label();
            lblDataValor = new Label();
            lblEvento = new Label();
            textBoxNome = new TextBox();
            lblValor = new Label();
            numValor = new NumericUpDown();
            lblTipo = new Label();
            comboBoxTipo = new ComboBox();
            checkBoxRecurring = new CheckBox();
            btnCancelar = new Button();
            btnSalvar = new Button();
            ((System.ComponentModel.ISupportInitialize)numValor).BeginInit();
            SuspendLayout();
            //
            // lblTitulo
            //
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(31, 41, 55);
            lblTitulo.Location = new Point(20, 16);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(152, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Novo lançamento";
            //
            // lblDataValor
            //
            lblDataValor.AutoSize = true;
            lblDataValor.ForeColor = Color.FromArgb(107, 114, 128);
            lblDataValor.Location = new Point(20, 44);
            lblDataValor.Name = "lblDataValor";
            lblDataValor.Size = new Size(31, 15);
            lblDataValor.TabIndex = 1;
            lblDataValor.Text = "Data";
            //
            // lblEvento
            //
            lblEvento.AutoSize = true;
            lblEvento.ForeColor = Color.FromArgb(31, 41, 55);
            lblEvento.Location = new Point(20, 80);
            lblEvento.Name = "lblEvento";
            lblEvento.Size = new Size(40, 15);
            lblEvento.TabIndex = 2;
            lblEvento.Text = "Nome";
            //
            // textBoxNome
            //
            textBoxNome.Location = new Point(20, 100);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(280, 23);
            textBoxNome.TabIndex = 3;
            //
            // lblValor
            //
            lblValor.AutoSize = true;
            lblValor.ForeColor = Color.FromArgb(31, 41, 55);
            lblValor.Location = new Point(20, 136);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(58, 15);
            lblValor.TabIndex = 4;
            lblValor.Text = "Valor (R$)";
            //
            // numValor
            //
            numValor.DecimalPlaces = 2;
            numValor.Location = new Point(20, 156);
            numValor.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numValor.Name = "numValor";
            numValor.Size = new Size(130, 23);
            numValor.TabIndex = 5;
            numValor.TextAlign = HorizontalAlignment.Right;
            numValor.ThousandsSeparator = true;
            //
            // lblTipo
            //
            lblTipo.AutoSize = true;
            lblTipo.ForeColor = Color.FromArgb(31, 41, 55);
            lblTipo.Location = new Point(170, 136);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(30, 15);
            lblTipo.TabIndex = 6;
            lblTipo.Text = "Tipo";
            //
            // comboBoxTipo
            //
            comboBoxTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Items.AddRange(new object[] { "Receita", "Despesa" });
            comboBoxTipo.Location = new Point(170, 156);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(130, 23);
            comboBoxTipo.TabIndex = 7;
            //
            // checkBoxRecurring
            //
            checkBoxRecurring.AutoSize = true;
            checkBoxRecurring.ForeColor = Color.FromArgb(31, 41, 55);
            checkBoxRecurring.Location = new Point(20, 196);
            checkBoxRecurring.Name = "checkBoxRecurring";
            checkBoxRecurring.Size = new Size(209, 19);
            checkBoxRecurring.TabIndex = 8;
            checkBoxRecurring.Text = "Repetir todo mês neste mesmo dia";
            checkBoxRecurring.UseVisualStyleBackColor = true;
            //
            // btnCancelar
            //
            btnCancelar.BackColor = Color.White;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(229, 231, 235);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.FromArgb(31, 41, 55);
            btnCancelar.Location = new Point(110, 240);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 34);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            //
            // btnSalvar
            //
            btnSalvar.BackColor = Color.FromArgb(37, 99, 235);
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(210, 240);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(90, 34);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            //
            // EventoForm
            //
            AcceptButton = btnSalvar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnCancelar;
            ClientSize = new Size(320, 294);
            Controls.Add(lblTitulo);
            Controls.Add(lblDataValor);
            Controls.Add(lblEvento);
            Controls.Add(textBoxNome);
            Controls.Add(lblValor);
            Controls.Add(numValor);
            Controls.Add(lblTipo);
            Controls.Add(comboBoxTipo);
            Controls.Add(checkBoxRecurring);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EventoForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Novo lançamento";
            Load += EventoForm_Load;
            ((System.ComponentModel.ISupportInitialize)numValor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblDataValor;
        private Label lblEvento;
        private TextBox textBoxNome;
        private Label lblValor;
        private NumericUpDown numValor;
        private Label lblTipo;
        private ComboBox comboBoxTipo;
        private CheckBox checkBoxRecurring;
        private Button btnCancelar;
        private Button btnSalvar;
    }
}
