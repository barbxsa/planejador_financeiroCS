namespace planejador_financeiroCS
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblSegunda = new Label();
            lblTerca = new Label();
            lblQuarta = new Label();
            lblQuinta = new Label();
            lblSexta = new Label();
            lblSabado = new Label();
            lblDomingo = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblMes = new Label();
            btnBack = new Button();
            btnNext = new Button();
            btnHoje = new Button();
            panelResumo = new Panel();
            lblResumoTitulo = new Label();
            lblReceitasTitulo = new Label();
            lblReceitas = new Label();
            lblDespesasTitulo = new Label();
            lblDespesas = new Label();
            panelDivisor = new Panel();
            lblSaldoTitulo = new Label();
            lblSaldo = new Label();
            btnMensal = new Button();
            btnExplorador = new Button();
            panelResumo.SuspendLayout();
            SuspendLayout();
            //
            // lblSegunda
            //
            lblSegunda.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSegunda.ForeColor = Color.FromArgb(107, 114, 128);
            lblSegunda.Location = new Point(15, 62);
            lblSegunda.Name = "lblSegunda";
            lblSegunda.Size = new Size(104, 20);
            lblSegunda.TabIndex = 4;
            lblSegunda.Text = "Seg";
            lblSegunda.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblTerca
            //
            lblTerca.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTerca.ForeColor = Color.FromArgb(107, 114, 128);
            lblTerca.Location = new Point(125, 62);
            lblTerca.Name = "lblTerca";
            lblTerca.Size = new Size(104, 20);
            lblTerca.TabIndex = 5;
            lblTerca.Text = "Ter";
            lblTerca.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblQuarta
            //
            lblQuarta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblQuarta.ForeColor = Color.FromArgb(107, 114, 128);
            lblQuarta.Location = new Point(235, 62);
            lblQuarta.Name = "lblQuarta";
            lblQuarta.Size = new Size(104, 20);
            lblQuarta.TabIndex = 6;
            lblQuarta.Text = "Qua";
            lblQuarta.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblQuinta
            //
            lblQuinta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblQuinta.ForeColor = Color.FromArgb(107, 114, 128);
            lblQuinta.Location = new Point(345, 62);
            lblQuinta.Name = "lblQuinta";
            lblQuinta.Size = new Size(104, 20);
            lblQuinta.TabIndex = 7;
            lblQuinta.Text = "Qui";
            lblQuinta.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblSexta
            //
            lblSexta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSexta.ForeColor = Color.FromArgb(107, 114, 128);
            lblSexta.Location = new Point(455, 62);
            lblSexta.Name = "lblSexta";
            lblSexta.Size = new Size(104, 20);
            lblSexta.TabIndex = 8;
            lblSexta.Text = "Sex";
            lblSexta.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblSabado
            //
            lblSabado.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSabado.ForeColor = Color.FromArgb(107, 114, 128);
            lblSabado.Location = new Point(565, 62);
            lblSabado.Name = "lblSabado";
            lblSabado.Size = new Size(104, 20);
            lblSabado.TabIndex = 9;
            lblSabado.Text = "Sáb";
            lblSabado.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblDomingo
            //
            lblDomingo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDomingo.ForeColor = Color.FromArgb(239, 68, 68);
            lblDomingo.Location = new Point(675, 62);
            lblDomingo.Name = "lblDomingo";
            lblDomingo.Size = new Size(104, 20);
            lblDomingo.TabIndex = 10;
            lblDomingo.Text = "Dom";
            lblDomingo.TextAlign = ContentAlignment.MiddleCenter;
            //
            // flowLayoutPanel1
            //
            flowLayoutPanel1.Location = new Point(12, 86);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(776, 470);
            flowLayoutPanel1.TabIndex = 11;
            //
            // btnBack
            //
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBack.ForeColor = Color.FromArgb(31, 41, 55);
            btnBack.Location = new Point(15, 14);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(40, 36);
            btnBack.TabIndex = 0;
            btnBack.Text = "◀";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            //
            // lblMes
            //
            lblMes.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblMes.ForeColor = Color.FromArgb(31, 41, 55);
            lblMes.Location = new Point(61, 14);
            lblMes.Name = "lblMes";
            lblMes.Size = new Size(554, 36);
            lblMes.TabIndex = 1;
            lblMes.Text = "Mês";
            lblMes.TextAlign = ContentAlignment.MiddleCenter;
            //
            // btnNext
            //
            btnNext.Cursor = Cursors.Hand;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNext.ForeColor = Color.FromArgb(31, 41, 55);
            btnNext.Location = new Point(621, 14);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(40, 36);
            btnNext.TabIndex = 2;
            btnNext.Text = "▶";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            //
            // btnHoje
            //
            btnHoje.BackColor = Color.White;
            btnHoje.Cursor = Cursors.Hand;
            btnHoje.FlatAppearance.BorderColor = Color.FromArgb(229, 231, 235);
            btnHoje.FlatStyle = FlatStyle.Flat;
            btnHoje.ForeColor = Color.FromArgb(31, 41, 55);
            btnHoje.Location = new Point(679, 17);
            btnHoje.Name = "btnHoje";
            btnHoje.Size = new Size(100, 30);
            btnHoje.TabIndex = 3;
            btnHoje.Text = "Hoje";
            btnHoje.UseVisualStyleBackColor = false;
            btnHoje.Click += btnHoje_Click;
            //
            // panelResumo
            //
            panelResumo.BackColor = Color.White;
            panelResumo.Controls.Add(lblResumoTitulo);
            panelResumo.Controls.Add(lblReceitasTitulo);
            panelResumo.Controls.Add(lblReceitas);
            panelResumo.Controls.Add(lblDespesasTitulo);
            panelResumo.Controls.Add(lblDespesas);
            panelResumo.Controls.Add(panelDivisor);
            panelResumo.Controls.Add(lblSaldoTitulo);
            panelResumo.Controls.Add(lblSaldo);
            panelResumo.Controls.Add(btnMensal);
            panelResumo.Controls.Add(btnExplorador);
            panelResumo.Location = new Point(800, 14);
            panelResumo.Name = "panelResumo";
            panelResumo.Size = new Size(188, 542);
            panelResumo.TabIndex = 12;
            //
            // lblResumoTitulo
            //
            lblResumoTitulo.AutoSize = true;
            lblResumoTitulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblResumoTitulo.ForeColor = Color.FromArgb(107, 114, 128);
            lblResumoTitulo.Location = new Point(16, 16);
            lblResumoTitulo.Name = "lblResumoTitulo";
            lblResumoTitulo.Size = new Size(104, 15);
            lblResumoTitulo.TabIndex = 0;
            lblResumoTitulo.Text = "RESUMO DO MÊS";
            //
            // lblReceitasTitulo
            //
            lblReceitasTitulo.AutoSize = true;
            lblReceitasTitulo.ForeColor = Color.FromArgb(107, 114, 128);
            lblReceitasTitulo.Location = new Point(16, 52);
            lblReceitasTitulo.Name = "lblReceitasTitulo";
            lblReceitasTitulo.Size = new Size(50, 15);
            lblReceitasTitulo.TabIndex = 1;
            lblReceitasTitulo.Text = "Receitas";
            //
            // lblReceitas
            //
            lblReceitas.AutoEllipsis = true;
            lblReceitas.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblReceitas.ForeColor = Color.FromArgb(22, 163, 74);
            lblReceitas.Location = new Point(16, 70);
            lblReceitas.Name = "lblReceitas";
            lblReceitas.Size = new Size(164, 28);
            lblReceitas.TabIndex = 2;
            lblReceitas.Text = "R$ 0,00";
            //
            // lblDespesasTitulo
            //
            lblDespesasTitulo.AutoSize = true;
            lblDespesasTitulo.ForeColor = Color.FromArgb(107, 114, 128);
            lblDespesasTitulo.Location = new Point(16, 112);
            lblDespesasTitulo.Name = "lblDespesasTitulo";
            lblDespesasTitulo.Size = new Size(55, 15);
            lblDespesasTitulo.TabIndex = 3;
            lblDespesasTitulo.Text = "Despesas";
            //
            // lblDespesas
            //
            lblDespesas.AutoEllipsis = true;
            lblDespesas.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblDespesas.ForeColor = Color.FromArgb(220, 38, 38);
            lblDespesas.Location = new Point(16, 130);
            lblDespesas.Name = "lblDespesas";
            lblDespesas.Size = new Size(164, 28);
            lblDespesas.TabIndex = 4;
            lblDespesas.Text = "R$ 0,00";
            //
            // panelDivisor
            //
            panelDivisor.BackColor = Color.FromArgb(229, 231, 235);
            panelDivisor.Location = new Point(16, 174);
            panelDivisor.Name = "panelDivisor";
            panelDivisor.Size = new Size(156, 1);
            panelDivisor.TabIndex = 5;
            //
            // lblSaldoTitulo
            //
            lblSaldoTitulo.AutoSize = true;
            lblSaldoTitulo.ForeColor = Color.FromArgb(107, 114, 128);
            lblSaldoTitulo.Location = new Point(16, 188);
            lblSaldoTitulo.Name = "lblSaldoTitulo";
            lblSaldoTitulo.Size = new Size(36, 15);
            lblSaldoTitulo.TabIndex = 6;
            lblSaldoTitulo.Text = "Saldo";
            //
            // lblSaldo
            //
            lblSaldo.AutoEllipsis = true;
            lblSaldo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblSaldo.ForeColor = Color.FromArgb(31, 41, 55);
            lblSaldo.Location = new Point(16, 206);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(164, 28);
            lblSaldo.TabIndex = 7;
            lblSaldo.Text = "R$ 0,00";
            //
            // btnMensal
            //
            btnMensal.BackColor = Color.FromArgb(37, 99, 235);
            btnMensal.Cursor = Cursors.Hand;
            btnMensal.FlatAppearance.BorderSize = 0;
            btnMensal.FlatStyle = FlatStyle.Flat;
            btnMensal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMensal.ForeColor = Color.White;
            btnMensal.Location = new Point(16, 446);
            btnMensal.Name = "btnMensal";
            btnMensal.Size = new Size(156, 36);
            btnMensal.TabIndex = 8;
            btnMensal.Text = "Visão mensal";
            btnMensal.UseVisualStyleBackColor = false;
            btnMensal.Click += btnMensal_Click;
            //
            // btnExplorador
            //
            btnExplorador.BackColor = Color.White;
            btnExplorador.Cursor = Cursors.Hand;
            btnExplorador.FlatAppearance.BorderColor = Color.FromArgb(229, 231, 235);
            btnExplorador.FlatStyle = FlatStyle.Flat;
            btnExplorador.ForeColor = Color.FromArgb(31, 41, 55);
            btnExplorador.Location = new Point(16, 490);
            btnExplorador.Name = "btnExplorador";
            btnExplorador.Size = new Size(156, 36);
            btnExplorador.TabIndex = 9;
            btnExplorador.Text = "Explorador";
            btnExplorador.UseVisualStyleBackColor = false;
            btnExplorador.Click += btnExplorador_Click;
            //
            // frmMenuPrincipal
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            ClientSize = new Size(1000, 568);
            Controls.Add(btnBack);
            Controls.Add(lblMes);
            Controls.Add(btnNext);
            Controls.Add(btnHoje);
            Controls.Add(lblSegunda);
            Controls.Add(lblTerca);
            Controls.Add(lblQuarta);
            Controls.Add(lblQuinta);
            Controls.Add(lblSexta);
            Controls.Add(lblSabado);
            Controls.Add(lblDomingo);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panelResumo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Planejador Financeiro";
            Load += frmMenuPrincipal_Load;
            panelResumo.ResumeLayout(false);
            panelResumo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblSegunda;
        private Label lblTerca;
        private Label lblQuarta;
        private Label lblQuinta;
        private Label lblSexta;
        private Label lblSabado;
        private Label lblDomingo;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblMes;
        private Button btnBack;
        private Button btnNext;
        private Button btnHoje;
        private Panel panelResumo;
        private Label lblResumoTitulo;
        private Label lblReceitasTitulo;
        private Label lblReceitas;
        private Label lblDespesasTitulo;
        private Label lblDespesas;
        private Panel panelDivisor;
        private Label lblSaldoTitulo;
        private Label lblSaldo;
        private Button btnMensal;
        private Button btnExplorador;
    }
}
