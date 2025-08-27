using DartVerwaltung.Database.Entities;
using System.Drawing.Imaging;

namespace DartVerwaltung
{
    public partial class frmUserVerwaltung : Form
    {
        public frmUserVerwaltung()
        {
            InitializeComponent();
        }

        public DialogResult ShowAsDialog(Member member)
        {
            // Member Objekt wird dem Formular zugewiesen
            txtMemberVorname.Text = member.Vorname;
            txtMemberNachname.Text = member.Nachname;
            txtMemberNummer.Text = member.Nr.ToString();
            txtMemberTitel.Text = member.Titel;
            txtMemberStand.Text = member.Familienstand;
            dtpGeburtstag.Value = member.Geburtstag;
            txtMemberAlter.Text = GetAgeByBirthday(member.Geburtstag);
            dtpEintritt.Value = member.Eintrittsdatum;
            dtpAustritt.Value = member.Austrittsdatum;
            txtMemberBeruf.Text = member.Beruf;
            txtMemberInfo.Text = member.Informationen;
            if (!string.IsNullOrEmpty(member.Profilbild))
            {
                byte[] imageBytes = Convert.FromBase64String(member.Profilbild);
                using var ms = new MemoryStream(imageBytes);
                pcMember.Image = Image.FromStream(ms);
            }

            // Zeigt das Formular als modalen Dialog an
            DialogResult result = ShowDialog();
            if (result != DialogResult.OK)
            {
                return DialogResult.Cancel;
            }

            // Aktualisiert die Member-Eigenschaften mit den Werten aus den Textboxen
            member.Vorname = txtMemberVorname.Text;
            member.Nachname = txtMemberNachname.Text;
            member.Nr = Convert.ToInt32(txtMemberNummer.Text);
            member.Titel = txtMemberTitel.Text;
            member.Familienstand = txtMemberStand.Text;
            member.Geburtstag = dtpGeburtstag.Value;
            member.Eintrittsdatum = dtpEintritt.Value;
            member.Austrittsdatum = dtpAustritt.Value;
            member.Beruf = txtMemberBeruf.Text;
            member.Informationen = txtMemberInfo.Text;
            member.Profilbild = GetPictureFromPicturebox();

            // Gibt an, dass der Dialog mit OK beendet wurde
            return DialogResult.OK;
        }

        private string GetPictureFromPicturebox()
        {
            if (pcMember.Image == null)
            {
                return string.Empty;
            }

            ImageFormat image = pcMember.Image.RawFormat;

            if (image == null)
            {
                return string.Empty;
            }

            using var ms = new MemoryStream();
            using var clonedImage = new Bitmap(pcMember.Image);
            clonedImage.Save(ms, pcMember.Image.RawFormat);
            // pcMember.Image.Save(ms, pcMember.Image.RawFormat);
            byte[] imageBytes = ms.ToArray();

            return Convert.ToBase64String(imageBytes);
            //return string.Empty;
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

            if (currentDate.Month == geburtstag.Month &&
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

        private void btnMemberBLaden_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            fileDialog.ShowDialog();

            pcMember.Image = Image.FromFile(fileDialog.FileName);
        }

        private void btnMemberBLoeschen_Click(object sender, EventArgs e)
        {
            pcMember.Image = null;
        }
    }
}
