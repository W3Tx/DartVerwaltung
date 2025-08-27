using DartVerwaltung.Database;

namespace DartVerwaltung
{
    public partial class frmClubStatistik : Form
    {
        private DataContext _dataContext;

        public frmClubStatistik(DataContext dataContext)
        {
            InitializeComponent();
            _dataContext = dataContext;
        }
    }
}
