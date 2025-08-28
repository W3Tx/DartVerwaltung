namespace DartVerwaltung.Database.Entities
{
    // Definiert die Member-Klasse, die eine Entität in der Datenbank darstellt
    public class Member
    {
        public int Id {  get; set; }
        public int Nr { get; set; }
        public string Profilbild { get; set; } = string.Empty;
        public string Titel { get; set; } = string.Empty;
        public string Vorname { get; set; } = string.Empty;   
        public string Nachname { get; set; } = string.Empty;
        public string Familienstand {  get; set; } = string.Empty;
        public DateTime Geburtstag { get; set; } = new DateTime(1990,1,1);
        public DateTime Eintrittsdatum { get; set; } = DateTime.Now;
        public DateTime Austrittsdatum { get; set; } = DateTime.Now;
        public string Beruf { get; set; } = string.Empty;
        public string Informationen {  get; set; } = string.Empty;
        public bool isPlayer { get; set; } = false;
    }
}
