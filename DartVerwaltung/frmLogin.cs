using BCrypt.Net;

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
            string enteredUsername = txtLoginBenutzername.Text;
            string enteredPassword = mtxtLoginPasswort.Text;

            /*using (var db = new Database.DataContextLogin())
            {
                var user = db.Logins
                    .FirstOrDefault(u => u.Benutzername == enteredUsername);
                if (user == null)
                {
                    MessageBox.Show("Benutzername oder Passwort ist falsch!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                string passwordHash = user.Passwort;
                bool isValid = BCrypt.Net.BCrypt.Verify(enteredPassword, passwordHash);
                
                if (!isValid)
                {
                    MessageBox.Show("Benutzername oder Passwort ist falsch!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
            }*/

            // Wenn die Anmeldedaten korrekt sind, öffne das Hauptformular
            frmStartseite frmStartseiten = new frmStartseite(this);
            frmStartseiten.Show();
            this.Hide();

            // Einfache Überprüfung der Anmeldedaten der Testbenutzer
            if (txtLoginBenutzername.Text != username || mtxtLoginPasswort.Text != password)
            {
                MessageBox.Show("Benutzername oder Passwort ist falsch!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnLoginRegistry_Click(object sender, EventArgs e)
        {
            using (var db = new Database.DataContextLogin())
            {
                var existingUser = db.Logins
                    .FirstOrDefault(u => u.Benutzername == txtLoginBenutzername.Text);

                if (existingUser != null)
                {
                    MessageBox.Show("Der Benutzername ist bereits vergeben!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (mtxtLoginPasswort.Text != mtxtLoginPasswortConfirm.Text)
                {
                    MessageBox.Show("Die Passwörter stimmen nicht überein!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Passwort hashen mit BCrypt
                string passwordHash = BCrypt.Net.BCrypt.HashPassword(mtxtLoginPasswort.Text);

                var newUser = new Database.Entities.Login
                {
                    Benutzername = txtLoginBenutzername.Text,
                    Passwort = passwordHash,
                    Rolle = "User"
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
