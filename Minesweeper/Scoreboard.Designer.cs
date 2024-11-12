namespace Minesweeper
{
    partial class Scoreboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.scoreListView = new System.Windows.Forms.ListView();
            this.Rank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Player = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Score = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Grid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mines = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.title = new System.Windows.Forms.Label();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // scoreListView
            // 
            this.scoreListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Rank,
            this.Player,
            this.Score,
            this.Grid,
            this.Mines,
            this.Time,
            this.Date});
            this.scoreListView.GridLines = true;
            this.scoreListView.HideSelection = false;
            this.scoreListView.Location = new System.Drawing.Point(12, 84);
            this.scoreListView.Name = "scoreListView";
            this.scoreListView.Size = new System.Drawing.Size(658, 313);
            this.scoreListView.TabIndex = 0;
            this.scoreListView.UseCompatibleStateImageBehavior = false;
            this.scoreListView.View = System.Windows.Forms.View.Details;
            // 
            // Rank
            // 
            this.Rank.Text = "Rank";
            // 
            // Player
            // 
            this.Player.Text = "Player";
            this.Player.Width = 122;
            // 
            // Score
            // 
            this.Score.Text = "Score";
            this.Score.Width = 69;
            // 
            // Grid
            // 
            this.Grid.Text = "Grid";
            this.Grid.Width = 54;
            // 
            // Mines
            // 
            this.Mines.Text = "Mines";
            // 
            // Time
            // 
            this.Time.Text = "Time";
            // 
            // Date
            // 
            this.Date.Text = "Date";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.title.Location = new System.Drawing.Point(168, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(365, 69);
            this.title.TabIndex = 1;
            this.title.Text = "High Scores";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(288, 410);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ButtonClose.Size = new System.Drawing.Size(105, 38);
            this.ButtonClose.TabIndex = 2;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // Scoreboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.title);
            this.Controls.Add(this.scoreListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Scoreboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Scoreboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView scoreListView;
        private System.Windows.Forms.ColumnHeader Rank;
        private System.Windows.Forms.ColumnHeader Player;
        private System.Windows.Forms.ColumnHeader Score;
        private System.Windows.Forms.ColumnHeader Grid;
        private System.Windows.Forms.ColumnHeader Mines;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button ButtonClose;
    }
}