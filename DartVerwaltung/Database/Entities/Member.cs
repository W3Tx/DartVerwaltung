namespace DartVerwaltung.Database.Entities
{
    // Definiert die Member-Klasse, die eine Entität in der Datenbank darstellt
    public class Member
    {
        public int Id {  get; set; }
        public int Nr { get; set; }
        public string Vorname { get; set; } = string.Empty;   
        public string Nachname { get; set; } = string.Empty;
        public string Titel { get; set; } = string.Empty;
        public string Familienstand {  get; set; } = string.Empty;
        public DateTime Geburtstag { get; set; } = new DateTime(1753,1,1);
        public DateTime Eintrittsdatum { get; set; } = new DateTime(1753, 1, 1);
        public DateTime Austrittsdatum { get; set; } = new DateTime(1753,1,1);
        public string Beruf { get; set; } = string.Empty;
        public string Informationen {  get; set; } = string.Empty;
        public string Profilbild {  get; set; } = string.Empty;
    }
}
