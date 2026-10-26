namespace planejador_financeiroCS
{
    partial class ucDia
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblSaldo = new Label();
            lblNomes = new Label();
            lblDia = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            //
            // panel1
            //
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblSaldo);
            panel1.Controls.Add(lblNomes);
            panel1.Controls.Add(lblDia);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(104, 72);
            panel1.TabIndex = 0;
            panel1.Click += celula_Click;
            panel1.Paint += panel1_Paint;
            panel1.MouseEnter += celula_MouseEnter;
            panel1.MouseLeave += celula_MouseLeave;
            //
            // lblSaldo
            //
            lblSaldo.AutoEllipsis = true;
            lblSaldo.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            lblSaldo.Location = new Point(5, 50);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(94, 16);
            lblSaldo.TabIndex = 2;
            lblSaldo.Click += celula_Click;
            lblSaldo.MouseEnter += celula_MouseEnter;
            lblSaldo.MouseLeave += celula_MouseLeave;
            //
            // lblNomes
            //
            lblNomes.AutoEllipsis = true;
            lblNomes.Font = new Font("Segoe UI", 8F);
            lblNomes.ForeColor = Color.FromArgb(107, 114, 128);
            lblNomes.Location = new Point(5, 30);
            lblNomes.Name = "lblNomes";
            lblNomes.Size = new Size(94, 16);
            lblNomes.TabIndex = 1;
            lblNomes.Click += celula_Click;
            lblNomes.MouseEnter += celula_MouseEnter;
            lblNomes.MouseLeave += celula_MouseLeave;
            //
            // lblDia
            //
            lblDia.AutoSize = true;
            lblDia.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDia.ForeColor = Color.FromArgb(31, 41, 55);
            lblDia.Location = new Point(5, 5);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(23, 19);
            lblDia.TabIndex = 0;
            lblDia.Text = "00";
            lblDia.Click += celula_Click;
            lblDia.MouseEnter += celula_MouseEnter;
            lblDia.MouseLeave += celula_MouseLeave;
            //
            // ucDia
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "ucDia";
            Size = new Size(104, 72);
            Load += ucDia_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblDia;
        private Label lblNomes;
        private Label lblSaldo;
    }
}
