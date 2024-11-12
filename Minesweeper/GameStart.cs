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
    public partial class GameStart : Form
    {


        
        public string PlayerName { get; private set; }
        public int GridSize { get; private set; }
        public int MineCount { get; private set; }

        public GameStart()
        {
            InitializeComponent();
            SetupForm();
            this.MaximizeBox = false;
           


        }


        private void SetupForm()
        {
            gridSizeUpDown.Value = 10;
    
            gridSizeUpDown.ValueChanged += GridSize_ValueChanged;
            
            UpdateMineCountLimits();
        }
       
        private void GridSize_ValueChanged(object sender, EventArgs e)
        {
            UpdateMineCountLimits();
        }
        private void UpdateMineCountLimits()
        {
            int maxMines = (int)((double)gridSizeUpDown.Value * (double)gridSizeUpDown.Value -1);
            mineCountUpDown.Maximum = maxMines;
            mineCountUpDown.Value = Math.Min(mineCountUpDown.Value, maxMines);
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                MessageBox.Show("Please enter a player name.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // değerleri al
            PlayerName = nameTextBox.Text.Trim();
            GridSize = (int)gridSizeUpDown.Value;
            MineCount = (int)mineCountUpDown.Value;

           
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        
    }
}
