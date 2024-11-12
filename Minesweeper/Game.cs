using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Game : Form
    {
        private GameCell[,] grid;
        private int gridSize;
        private int mineCount;
        private int moveCount;
        private string playerName;
        private System.Windows.Forms.Timer gameTimer;
        private int elapsedSeconds;
        private bool gameStarted;
        private bool gameEnded;
        private Scoreboard scoreboard;




        public Game()
        {


            InitializeComponent();
            scoreboard = new Scoreboard();
            this.MaximizeBox = false;
            InitializeGame();


        }

        private void UpdateStatusLabel()
        {
            statusLabel.AutoSize = false; // bu olmayınca uzun girdi gözükmüyor(ama kayıt alıyor hala)
            statusLabel.Width = 300; // üstteki devamı
            statusLabel.Text = $"Time: {elapsedSeconds}s | Moves: {moveCount}   {playerName}";
        }
        private void InitializeGame()
        {
            // değerleri al
            using (var setupForm = new GameStart())
            {
                if (setupForm.ShowDialog() == DialogResult.OK)
                {
                    playerName = setupForm.PlayerName;
                    gridSize = setupForm.GridSize;
                    mineCount = setupForm.MineCount;
                }
                else
                {
                    if (grid == null)
                        this.Close();
                    return;
                }
                
            }

            moveCount = 0;
            elapsedSeconds = 0;
            gameStarted = false;
            gameEnded = false;

            CreateGrid();
            InitializeTimer();

            ClientSize = new Size(gridSize * 25 + 20, gridSize * 25 + 60);
            UpdateStatusLabel();
        }
        private void CreateGrid()
        {
            grid = new GameCell[gridSize, gridSize];
            var gridPanel = new Panel
            {
                Location = new Point(10, 40),
                Size = new Size(gridSize * 25, gridSize * 25)
            };

            // cell oluşturma
            for (int row = 0; row < gridSize; row++)
            {
                for (int col = 0; col < gridSize; col++)
                {
                    var cell = new GameCell(row, col)
                    {
                        Location = new Point(col * 25, row * 25)
                    };

                    cell.MouseUp += Cell_MouseUp;
                    grid[row, col] = cell;
                    gridPanel.Controls.Add(cell);
                }
            }

            Controls.Add(gridPanel);
        }
        private void InitializeTimer()
        {
            if (gameTimer != null)
            {
                gameTimer.Stop();
                gameTimer.Dispose();
            }

            gameTimer = new System.Windows.Forms.Timer
            {
                Interval = 1000
            };
            gameTimer.Tick += (s, e) =>
            {
                elapsedSeconds++;
                UpdateStatusLabel();
            };
        }
        private void Cell_MouseUp(object sender, MouseEventArgs e)
        {
            if (gameEnded) return;

            var cell = (GameCell)sender;

            if (e.Button == MouseButtons.Left && !cell.IsFlagged)
            {
                if (!gameStarted)
                {
                    PlaceMines(cell.Row, cell.Column);
                    gameStarted = true;
                    gameTimer.Start();
                }

                RevealCell(cell);
            }
            else if (e.Button == MouseButtons.Right && !cell.IsRevealed)
            {
                cell.IsFlagged = !cell.IsFlagged;
                cell.Text = cell.IsFlagged ? "🚩" : "";

                CheckWinCondition();
            }

            moveCount++;
            UpdateStatusLabel();
        }
        private void PlaceMines(int firstClickRow, int firstClickCol)
        {
            var random = new Random();
            int placedMines = 0;

            while (placedMines < mineCount)
            {
                int row = random.Next(gridSize);
                int col = random.Next(gridSize);

                // ilk tıklanan yer bos 
                if ((row == firstClickRow && col == firstClickCol) || grid[row, col].HasMine)
                    continue;

                grid[row, col].HasMine = true;
                placedMines++;
            }

            // etrafdaki mayınlar
            for (int row = 0; row < gridSize; row++)
            {
                for (int col = 0; col < gridSize; col++)
                {
                    if (!grid[row, col].HasMine)
                    {
                        grid[row, col].AdjacentMines = CountAdjacentMines(row, col);
                    }
                }
            }
        }

        private int CountAdjacentMines(int row, int col)
        {
            int count = 0;
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    int newRow = row + i;
                    int newCol = col + j;

                    if (newRow >= 0 && newRow < gridSize &&
                        newCol >= 0 && newCol < gridSize &&
                        grid[newRow, newCol].HasMine)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        private void RevealCell(GameCell cell)
        {
            if (cell.IsRevealed || cell.IsFlagged) return;

            cell.IsRevealed = true;

            if (cell.HasMine)
            {
                GameOver(false);
                return;
            }

            if (cell.AdjacentMines == 0)
            {
                //  bitişik boş hücre
                for (int i = -1; i <= 1; i++)
                {
                    for (int j = -1; j <= 1; j++)
                    {
                        int newRow = cell.Row + i;
                        int newCol = cell.Column + j;

                        if (newRow >= 0 && newRow < gridSize &&
                            newCol >= 0 && newCol < gridSize)
                        {
                            RevealCell(grid[newRow, newCol]);
                        }
                    }
                }
                cell.BackColor = Color.LightGray;
                cell.FlatStyle = FlatStyle.Flat;
                cell.ForeColor = Color.LightGray;
            }
            else
            {
                cell.Text = cell.AdjacentMines.ToString();
                cell.ForeColor = GetNumberColor(cell.AdjacentMines);
            }

            CheckWinCondition();
        }
        private Color GetNumberColor(int number)
        {
            Color color;
            switch (number)
            {
                case 1:
                    color = Color.Blue;
                    break;
                case 2:
                    color = Color.Green;
                    break;
                case 3:
                    color = Color.Red;
                    break;
                case 4:
                    color = Color.DarkBlue;
                    break;
                case 5:
                    color = Color.DarkRed;
                    break;
                case 6:
                    color = Color.Teal;
                    break;
                case 7:
                    color = Color.Black;
                    break;
                case 8:
                    color = Color.Gray;
                    break;
                default:
                    color = Color.Empty;
                    break;
            }
            return color;
        }


        private void CheckWinCondition()
        {
            bool allMinesFlagged = true;
            bool allSafeCellsRevealed = true;

            for (int row = 0; row < gridSize; row++)
            {
                for (int col = 0; col < gridSize; col++)
                {
                    var cell = grid[row, col];
                    if (cell.HasMine && !cell.IsFlagged)
                        allMinesFlagged = false;
                    if (!cell.HasMine && !cell.IsRevealed)
                        allSafeCellsRevealed = false;
                }
            }

            if (allMinesFlagged && allSafeCellsRevealed)
            {
                GameOver(true);
            }
        }

        private void GameOver(bool won)
        {
            gameEnded = true;
            gameTimer.Stop();

            // Tüm hücreleri aç
            for (int row = 0; row < gridSize; row++)
            {
                for (int col = 0; col < gridSize; col++)
                {
                    var cell = grid[row, col];
                    if (cell.HasMine)
                    {
                        cell.ShowMine(); 
                    }
                }
            }

            if (won)
            {
                int score = CalculateScore();
                MessageBox.Show($"Congratulations! You won!\nTime: {elapsedSeconds} seconds\nScore: {score}",
                              "Game Over",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);

                SaveScore(score);
            }
            else
            {
                MessageBox.Show("Game Over! You hit a mine!",
                              "Game Over",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);

            }
            this.Close();
        }
        private int CalculateScore()
        {
            return (mineCount * 1000) / elapsedSeconds;
        }

        private void SaveScore(int score)
        {
            scoreboard.AddScore(playerName, score, gridSize, mineCount, elapsedSeconds);
            scoreboard.ShowDialog();
        }


    }
}
