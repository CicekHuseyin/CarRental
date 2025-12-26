using CarRental.Business.Abstract;
using CarRental.Business.Concrete;
using CarRental.Entities.Dtos;
using ScottPlot.WinForms;

namespace CarRental.WinFormsUI
{
    public partial class FrmReport : Form
    {
        private readonly IRentalService _rentalService;
        private FormsPlot _formsPlot;

        public FrmReport()
        {
            InitializeComponent();
            _rentalService = new RentalManager();
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            _formsPlot = new FormsPlot();
            _formsPlot.Dock = DockStyle.Fill;
            this.Controls.Add(_formsPlot);

            LoadVehicleRevenueChart();
        }

        private void LoadVehicleRevenueChart()
        {
            var data = _rentalService.GetVehicleRevenue();

            if (data == null || data.Count == 0)
                return;

            double[] values = data
                .Select(x => (double)x.TotalRevenue)
                .ToArray();

            string[] labels = data
                .Select(x => x.Plate)
                .ToArray();

            _formsPlot.Plot.Clear();

            // Bar chart
            var bar = _formsPlot.Plot.Add.Bars(values);

            // X ekseni etiketleri (ScottPlot v5)
            double[] positions = Enumerable.Range(0, labels.Length)
                                           .Select(i => (double)i)
                                           .ToArray();

            _formsPlot.Plot.Axes.Bottom.SetTicks(positions, labels);

            _formsPlot.Plot.Title("Araç Bazlı Ciro");
            _formsPlot.Plot.Axes.Left.Label.Text = "₺";

            _formsPlot.Refresh();
        }
    }
}
