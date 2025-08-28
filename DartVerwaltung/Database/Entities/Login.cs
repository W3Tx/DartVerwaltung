using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartVerwaltung.Database.Entities
{
    public class Login
    {
        public int Id { get; set; }
        public string Benutzername { get; set; } = string.Empty;
        public string Passwort { get; set; } = string.Empty;
        public string Rolle { get; set; } = "User"; // Standardrolle ist "User"
    }
}
