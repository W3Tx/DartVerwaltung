using DartVerwaltung.Database;
using DartVerwaltung.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DartVerwaltung
{
    public partial class frmMitgliederliste : Form
    {
        private DataContext _dataContext = new DataContext();

        public frmMitgliederliste()
        {
            InitializeComponent();

            // Test, lädt die Database als Dataset(source)
            _dataContext.Members.Load<Member>();
            dgMemberComplete.DataSource = _dataContext.Members.Local.ToBindingList();
            // Entfernt das angegebene Column
            dgMemberComplete.Columns["Id"].Visible = false;
        }
    }
}
