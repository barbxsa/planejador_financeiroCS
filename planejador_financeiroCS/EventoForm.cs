using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using planejador_financeiroCS.Services;

namespace planejador_financeiroCS
{
    public partial class EventoForm : Form
    {
        private readonly DateTime _data;

        public EventoForm(DateTime data)
        {
            InitializeComponent();
            _data = data.Date;
        }

        private void EventoForm_Load(object sender, EventArgs e)
        {
            // ex.: "segunda-feira, 26 de outubro de 2026"
            lblDataValor.Text = _data.ToString("D", Tema.Cultura);
            Text = "Novo lançamento – " + _data.ToString("dd/MM/yyyy");
            comboBoxTipo.SelectedItem = "Despesa";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text.Trim();
            if (nome.Length == 0)
            {
                MessageBox.Show("Informe o nome do lançamento.", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxNome.Focus();
                return;
            }
            if (numValor.Value <= 0)
            {
                MessageBox.Show("Informe um valor maior que zero.", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numValor.Focus();
                return;
            }

            try
            {
                var tipo = comboBoxTipo.SelectedItem?.ToString() ?? string.Empty;
                if (checkBoxRecurring.Checked)
                {
                    LancamentoStore.Instance.AddRecurringMonthly(nome, numValor.Value, tipo, _data);
                }
                else
                {
                    LancamentoStore.Instance.AddOneTime(nome, numValor.Value, tipo, _data);
                }

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
