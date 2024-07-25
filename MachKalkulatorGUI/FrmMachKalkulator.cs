namespace MachKalkulatorGUI
{
    public partial class FrmMachKalkulator : Form
    {
        public FrmMachKalkulator()
        {
            InitializeComponent();
            btnSzamol.Click += BtnSzamol_Click;
        }

        private void BtnSzamol_Click(object? sender, EventArgs e)
        {
            try
            {
                double qc = double.Parse(tbxTorlo.Text.Replace('.', ','));
                double p0 = double.Parse(tbxStatikus.Text.Replace('.', ','));

                double ma = Math.Sqrt(5 * (Math.Pow(qc / p0 + 1, 2 / 7D) - 1));

                if (ma < 1)
                {
                    lsbEredmenyek.Items.Add($"qc={qc} p0={p0} Ma={ma}");
                    tbxTorlo.Clear();
                    tbxStatikus.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    caption: "HIBA!",
                    text: ex.Message,
                    icon: MessageBoxIcon.Error,
                    buttons: MessageBoxButtons.OK);
            }
        }
    }
}
