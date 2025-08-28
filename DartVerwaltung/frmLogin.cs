using BCrypt;

namespace DartVerwaltung
{
    public partial class frmLogin : Form
    {
        // Testbenutzer
        string username = "admin";
        string password = "password";

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLoginButton_Click(object sender, EventArgs e)
        {
            // Einfache Überprüfung der Anmeldedaten der Testbenutzer
            if (txtLoginBenutzername.Text != username || mtxtLoginPasswort.Text != password)
            {
                MessageBox.Show("Benutzername oder Passwort ist falsch!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                frmStartseite frmStartseiten = new frmStartseite();
                frmStartseiten.Show();
                this.Hide();
            }

            // Benutzer aus der Datenbank überprüfen

            // Passwort entschlüsseln (optional)

            // Passwort mit BCrypt vergleichen

            // Wenn die Anmeldedaten korrekt sind, öffne das Hauptformular
        }

        private void btnLoginRegistry_Click(object sender, EventArgs e)
        {
            using (var db = new Database.DataContextLogin())
            {
                // Benutzername bereits vergeben
                var existingUser = db.Logins
                    .FirstOrDefault(u => u.Benutzername == txtLoginBenutzername.Text);

                // Wenn der Benutzername bereits existiert, zeige eine Fehlermeldung an
                if (existingUser != null)
                {
                    MessageBox.Show("Der Benutzername ist bereits vergeben!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Gesetztes Passwort passen zusammen
                if (mtxtLoginPasswort.Text != mtxtLoginPasswortConfirm.Text)
                {
                    MessageBox.Show("Die Passwörter stimmen nicht überein!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    // Passwort verschlüsseln (optional)
                    // mtxtLoginPasswort.Text = Encode(mtxtLoginPasswort.Text);

                    // Or using BCrypt for hashing
                    string passwordHash = BCrypt.Net.BCrypt.HashPassword(mtxtLoginPasswort.Text);
                }

                // Benutzer eintragen
                var newUser = new Database.Entities.Login
                {
                    Benutzername = txtLoginBenutzername.Text,
                    Passwort = mtxtLoginPasswort.Text,
                    Rolle = "User" // Standardrolle ist "User"
                };

                if (string.IsNullOrWhiteSpace(newUser.Benutzername) || string.IsNullOrWhiteSpace(newUser.Passwort))
                {
                    MessageBox.Show("Benutzername und Passwort dürfen nicht leer sein!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                db.Logins.Add(newUser);
                db.SaveChanges();

                MessageBox.Show("Benutzer erfolgreich registriert!", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Simple Base64 Encoding/Decoding for demonstration purposes
        /*
        public string Encode(string str)
        {
            byte[] encbuff = System.Text.Encoding.UTF8.GetBytes(str);
            return Convert.ToBase64String(encbuff);
        }

        public string Decode(string str)
        {
            byte[] decbuff = Convert.FromBase64String(str);
            return System.Text.Encoding.UTF8.GetString(decbuff);
        }
        */
    }
}
