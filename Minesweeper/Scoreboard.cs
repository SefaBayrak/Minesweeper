using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 


namespace Minesweeper
{
    public partial class Scoreboard : Form
    {
        private const string SCORE_FILE = "minesweeper_scores.txt";
        private const int MAX_SCORES = 10;
        private List<ScoreEntry> scores;

        public Scoreboard()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            LoadScores();
            DisplayScores();

        }
        private void LoadScores()
        {
            try
            {
                scores = new List<ScoreEntry>();
                if (File.Exists(SCORE_FILE))
                {
                    string[] lines = File.ReadAllLines(SCORE_FILE);
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 6)
                        {
                            scores.Add(new ScoreEntry
                            {
                                PlayerName = parts[0],
                                Score = int.Parse(parts[1]),
                                GridSize = int.Parse(parts[2]),
                                MineCount = int.Parse(parts[3]),
                                Time = int.Parse(parts[4]),
                                Date = DateTime.Parse(parts[5])
                            });
                        }
                    }
                }
            }
            catch (Exception)
            {
                scores = new List<ScoreEntry>();
            }
        }

        public void AddScore(string playerName, int score, int gridSize, int mineCount, int time)
        {
            scores.Add(new ScoreEntry
            {
                PlayerName = playerName,
                Score = score,
                GridSize = gridSize,
                MineCount = mineCount,
                Time = time,
                Date = DateTime.Now
            });

            scores = scores.OrderByDescending(s => s.Score)
                          .Take(MAX_SCORES)
                          .ToList();

            SaveScores();
            DisplayScores();
        }

        private void SaveScores()
        {
           
                List<string> lines = new List<string>();
                foreach (var score in scores)
                {
                   string line = $"{score.PlayerName},{score.Score},{score.GridSize}," +
                                 $"{score.MineCount},{score.Time},{score.Date}";
                    lines.Add(line);
                }
                File.WriteAllLines(SCORE_FILE, lines);
           
        }
        private void DisplayScores()
        {
            scoreListView.Items.Clear();
            int rank = 1;
            foreach (var score in scores)
            {
                ListViewItem item = new ListViewItem();

                item.Text = rank.ToString();
                item.SubItems.Add(score.PlayerName);
                item.SubItems.Add(score.Score.ToString());
                item.SubItems.Add(score.GridSize + "x" + score.GridSize);
                item.SubItems.Add(score.MineCount.ToString());
                item.SubItems.Add(score.Time + "s");
                item.SubItems.Add(score.Date.ToShortDateString());

                scoreListView.Items.Add(item);
                rank = rank + 1;
            }
        }





        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public class ScoreEntry
        {
            public string PlayerName { get; set; }
            public int Score { get; set; }
            public int GridSize { get; set; }
            public int MineCount { get; set; }
            public int Time { get; set; }
            public DateTime Date { get; set; }
        }
    }
}
