using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using planejador_financeiroCS.Services;

namespace planejador_financeiroCS
{

    public partial class ucDia : UserControl
    {
        // null = célula vazia (preenchimento antes do dia 1)
        private readonly DateTime? _date;

        // disparado quando um lançamento é salvo neste dia
        public event EventHandler? LancamentosAlterados;

        private bool IsHoje => _date == DateTime.Today;

        public ucDia(DateTime? date)
        {
            InitializeComponent();
            _date = date;
        }

        private void celula_Click(object sender, EventArgs e)
        {
            if (_date == null) return;
            using (var eventform = new EventoForm(_date.Value))
            {
                if (eventform.ShowDialog(this) != DialogResult.OK) return;
            }
            displayEvents();
            LancamentosAlterados?.Invoke(this, EventArgs.Empty);
        }

        private void celula_MouseEnter(object sender, EventArgs e)
        {
            if (_date == null) return;
            panel1.BackColor = Tema.DestaqueClaro;
        }

        private void celula_MouseLeave(object sender, EventArgs e)
        {
            // o mouse pode só ter passado do painel para um label dentro dele
            if (panel1.ClientRectangle.Contains(panel1.PointToClient(Cursor.Position))) return;
            aplicarCores();
        }

        // desenha a borda da célula; o dia de hoje ganha borda grossa na cor de destaque
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (_date == null) return;
            var largura = IsHoje ? 2 : 1;
            using var pen = new Pen(IsHoje ? Tema.Destaque : Tema.Borda, largura);
            var r = panel1.ClientRectangle;
            e.Graphics.DrawRectangle(pen, r.X + largura / 2, r.Y + largura / 2, r.Width - largura, r.Height - largura);
        }

        //Modifica as cores da célula (vazia, hoje, domingo)
        private void aplicarCores()
        {
            if (_date == null)
            {
                panel1.BackColor = Tema.Fundo;
                return;
            }
            panel1.BackColor = Tema.Superficie;
            if (IsHoje)
                lblDia.ForeColor = Tema.Destaque;
            else if (_date.Value.DayOfWeek == DayOfWeek.Sunday)
                lblDia.ForeColor = Tema.Domingo;
            else
                lblDia.ForeColor = Tema.Texto;
        }

        private void ucDia_Load(object sender, EventArgs e)
        {
            aplicarCores();
            if (_date != null)
            {
                panel1.Cursor = Cursors.Hand;
                lblDia.Cursor = lblNomes.Cursor = lblSaldo.Cursor = Cursors.Hand;
            }
            displayEvents();
        }

        private void displayEvents()
        {
            lblDia.Text = string.Empty;
            lblNomes.Text = string.Empty;
            lblSaldo.Text = string.Empty;
            if (_date == null) return;

            var date = _date.Value;
            lblDia.Text = date.Day.ToString();
            try
            {
                var lanc = LancamentoStore.Instance.GetLancamentosForMonth(date.Month, date.Year)
                    .Where(l => l.Date.Day == date.Day)
                    .ToList();
                if (lanc.Count == 0) return;

                // nomes cortados com "..." pelo AutoEllipsis do label
                lblNomes.Text = string.Join(", ", lanc.Select(l => l.Name));
                var saldo = lanc.Sum(l => l.ValorComSinal);
                lblSaldo.Text = Tema.MoedaComSinal(saldo);
                lblSaldo.ForeColor = Tema.CorDoValor(saldo);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}
