using DartVerwaltung.Database.Entities;

namespace DartVerwaltung
{
    public partial class frmPlayTime : Form
    {
        private Random rng = new Random();
        private List<Member> _players;

        bool playedAB = false;
        bool playedCD = false;
        bool started = false;

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
            if(started)
            {
                lblUebersichtRundeBNameA.Text = lblUebersichtNameA.Text;
                lblUebersichtRundeCNameA.Text = lblUebersichtNameB.Text;
                playedAB = true;
            }
            
        }

        private void lblUebersichtNameB_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(started)
            {
                lblUebersichtRundeBNameA.Text = lblUebersichtNameB.Text;
                lblUebersichtRundeCNameA.Text = lblUebersichtNameA.Text;
                playedAB = true;
            }
            
        }

        private void lblUebersichtNameC_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (started && sender is Label label)
            {
                lblUebersichtRundeBNameB.Text = label.Text;

                if (label.Name == lblUebersichtNameC.Name)
                {
                    lblUebersichtRundeCNameB.Text = lblUebersichtNameD.Text;
                }
                else if (label.Name == lblUebersichtNameD.Name)
                {
                    lblUebersichtRundeCNameB.Text = lblUebersichtNameC.Text;
                }

                playedCD = true;
            }
        }

        private void lblUebersichtRundeCNameA_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (allPlayed())
            {
                lblUebersichtFinalNameC.Text = lblUebersichtRundeCNameA.Text;
            }
        }

        private void lblUebersichtRundeCNameB_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (allPlayed())
            {
                lblUebersichtFinalNameC.Text = lblUebersichtRundeCNameB.Text;
            }
        }

        private void lblUebersichtRundeBNameA_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (allPlayed())
            {
                lblUebersichtFinalNameB.Text = lblUebersichtRundeBNameA.Text;
            }
        }

        private void lblUebersichtRundeBNameB_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (allPlayed())
            {
                lblUebersichtFinalNameB.Text = lblUebersichtRundeBNameB.Text;
            }
        }

        private bool allPlayed()
        {
            return playedAB && playedCD;
        }

        private void btnUebersichtSpielen_Click(object sender, EventArgs e)
        {
            started = true;
        }
    }
}
