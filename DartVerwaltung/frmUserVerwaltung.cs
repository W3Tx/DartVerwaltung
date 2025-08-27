using DartVerwaltung.Database.Entities;

namespace DartVerwaltung
{
    public partial class frmUserVerwaltung : Form
    {
        private Member? _member;


        public frmUserVerwaltung()
        {
            InitializeComponent();
        }

        public DialogResult ShowAsDialog(Member member)
        {
            // Member Objekt wird dem Formular zugewiesen
            _member = member;
            txtMemberVorname.Text = _member.Vorname;
            txtMemberNachname.Text = _member.Nachname;
            txtMemberNummer.Text = _member.Nr.ToString();
            txtMemberTitel.Text = _member.Titel;
            txtMemberStand.Text = _member.Familienstand;
            dtpGeburtstag.Value = _member.Geburtstag;
            txtMemberAlter.Text = GetAgeByBirthday(_member.Geburtstag);
            dtpEintritt.Value= _member.Eintrittsdatum;
            dtpAustritt.Value = _member.Austrittsdatum;
            txtMemberBeruf.Text = _member.Beruf;
            txtMemberInfo.Text = _member.Informationen;

            // Zeigt das Formular als modalen Dialog an
            DialogResult result = ShowDialog();
            if (result != DialogResult.OK)
            {
                return DialogResult.Cancel;
            }

            // Aktualisiert die Member-Eigenschaften mit den Werten aus den Textboxen
            _member.Vorname = txtMemberVorname.Text;
            _member.Nachname = txtMemberNachname.Text;
            _member.Nr = Convert.ToInt32(txtMemberNummer.Text);
            _member.Titel = txtMemberTitel.Text;
            _member.Familienstand = txtMemberStand.Text;
            _member.Geburtstag = dtpGeburtstag.Value;
            _member.Eintrittsdatum = dtpEintritt.Value;
            _member.Austrittsdatum = dtpAustritt.Value;
            _member.Beruf = txtMemberBeruf.Text;
            _member.Informationen = txtMemberInfo.Text;

            // Gibt an, dass der Dialog mit OK beendet wurde
            return DialogResult.OK;
        }

        private string GetAgeByBirthday(DateTime geburtstag)
        {
            // Berechnet das Alter basierend auf dem Geburtstag
            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - geburtstag.Year;
            if (currentDate.Month < geburtstag.Month)
            {
                age--;
                return age.ToString();
            }

            if(currentDate.Month == geburtstag.Month && 
                currentDate.Day < geburtstag.Day)
            {
                age--;
            }

            return age.ToString();
        }

        // Speichert oder bestätigt die Änderungen
        private void btnMemberSpeichern_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        // Cancelt die Änderungen
        private void btnMemberCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
