using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class GameCell : Button
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public bool HasMine { get; set; }
        public bool IsRevealed { get; set; }
        public bool IsFlagged { get; set; }
        public int AdjacentMines { get; set; }

        public GameCell(int row, int column)
        {
            Row = row;
            Column = column;
            HasMine = false;
            IsRevealed = false;
            IsFlagged = false;
            AdjacentMines = 0;

            // Button ozellikleri
            Width = 25;
            Height = 25;
            Font = new Font("Arial", 10f, FontStyle.Bold);
            UseVisualStyleBackColor = true;
            BackgroundImageLayout = ImageLayout.Stretch; // Resim hucreye sığmıyor bu yokken
        }

        // adından belli ne olduğu
        public void ShowMine()
        {
            string mineImagePath = "..\\..\\Images\\mine.png";
            if (File.Exists(mineImagePath))
            {
                BackgroundImage = Image.FromFile(mineImagePath);
            }
            else
            {
                MessageBox.Show("hata");
            }
        }
    
    }
}
