using DartVerwaltung.Database.Entities;

namespace DartVerwaltung
{
    public partial class frmPlayTime : Form
    {
        private Random rng = new Random();
        private List<Member> _players;

        public frmPlayTime(List<Member> players)
        {
            if (players.Count != 4)
            {
                MessageBox.Show("Es werden genau 4 Spieler benötigt", "Ungültige Spieleranzahl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            InitializeComponent();
            _players = players;
        }

        private void btnPlayShuffle_Click(object sender, EventArgs e)
        {
            List<Member> players = new List<Member>();
            players.AddRange(_players);

            int firstCount = rng.Next(0, players.Count);
            Member memberA = players[firstCount];
            lblUebersichtNameA.Text = memberA.Vorname;
            players.Remove(memberA);

            int secondCount = rng.Next(0, players.Count);
            Member memberB = players[secondCount];
            lblUebersichtNameB.Text = memberB.Vorname;
            players.Remove(memberB);

            int thirdCount = rng.Next(0, players.Count);
            Member memberC = players[thirdCount];
            lblUebersichtNameC.Text = memberC.Vorname;
            players.Remove(memberC);

            Member memberD = players[0];
            lblUebersichtNameD.Text = memberD.Vorname;
        }

        private void lblUebersichtNameA_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lblUebersichtRundeBNameA.Text = lblUebersichtNameA.Text;
        }

        private void lblUebersichtNameB_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lblUebersichtRundeBNameB.Text = lblUebersichtNameB.Text;
        }

        private void lblUebersichtNameC_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if()
        }
    }
}
