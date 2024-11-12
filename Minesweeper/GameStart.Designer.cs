namespace Minesweeper
{
    partial class GameStart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel linePanel;


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
            this.linePanel = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.gridSizeLabel = new System.Windows.Forms.Label();
            this.gridSizeUpDown = new System.Windows.Forms.NumericUpDown();
            this.mineCountLabel = new System.Windows.Forms.Label();
            this.mineCountUpDown = new System.Windows.Forms.NumericUpDown();
            this.startButton = new System.Windows.Forms.Button();
            this.designer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridSizeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mineCountUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // linePanel
            // 
            this.linePanel.BackColor = System.Drawing.Color.Black;
            this.linePanel.Location = new System.Drawing.Point(0, 220);
            this.linePanel.Name = "linePanel";
            this.linePanel.Size = new System.Drawing.Size(300, 5);
            this.linePanel.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(20, 20);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(89, 16);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Player Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(20, 45);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(240, 22);
            this.nameTextBox.TabIndex = 1;
            // 
            // gridSizeLabel
            // 
            this.gridSizeLabel.AutoSize = true;
            this.gridSizeLabel.Location = new System.Drawing.Point(20, 75);
            this.gridSizeLabel.Name = "gridSizeLabel";
            this.gridSizeLabel.Size = new System.Drawing.Size(107, 16);
            this.gridSizeLabel.TabIndex = 2;
            this.gridSizeLabel.Text = "Grid Size (10-30):";
            // 
            // gridSizeUpDown
            // 
            this.gridSizeUpDown.Location = new System.Drawing.Point(20, 100);
            this.gridSizeUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.gridSizeUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.gridSizeUpDown.Name = "gridSizeUpDown";
            this.gridSizeUpDown.Size = new System.Drawing.Size(240, 22);
            this.gridSizeUpDown.TabIndex = 3;
            this.gridSizeUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // mineCountLabel
            // 
            this.mineCountLabel.AutoSize = true;
            this.mineCountLabel.Location = new System.Drawing.Point(20, 130);
            this.mineCountLabel.Name = "mineCountLabel";
            this.mineCountLabel.Size = new System.Drawing.Size(111, 16);
            this.mineCountLabel.TabIndex = 4;
            this.mineCountLabel.Text = "Number of mines:";
            // 
            // mineCountUpDown
            // 
            this.mineCountUpDown.Location = new System.Drawing.Point(20, 155);
            this.mineCountUpDown.Maximum = new decimal(new int[] {
            899,
            0,
            0,
            0});
            this.mineCountUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.mineCountUpDown.Name = "mineCountUpDown";
            this.mineCountUpDown.Size = new System.Drawing.Size(240, 22);
            this.mineCountUpDown.TabIndex = 5;
            this.mineCountUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(90, 185);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 30);
            this.startButton.TabIndex = 7;
            this.startButton.Text = "Start Game";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // designer
            // 
            this.designer.AutoSize = true;
            this.designer.Location = new System.Drawing.Point(54, 228);
            this.designer.Name = "designer";
            this.designer.Size = new System.Drawing.Size(227, 16);
            this.designer.TabIndex = 8;
            this.designer.Text = "Designed by Sefa Bayrak 230229023";
            // 
            // GameStart
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.linePanel);
            this.Controls.Add(this.designer);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.mineCountUpDown);
            this.Controls.Add(this.mineCountLabel);
            this.Controls.Add(this.gridSizeUpDown);
            this.Controls.Add(this.gridSizeLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "GameStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Game";
            ((System.ComponentModel.ISupportInitialize)(this.gridSizeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mineCountUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label gridSizeLabel;
        private System.Windows.Forms.NumericUpDown gridSizeUpDown;
        private System.Windows.Forms.Label mineCountLabel;
        private System.Windows.Forms.NumericUpDown mineCountUpDown;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label designer;
    }
}