namespace Flatopia
{
    partial class GameScreen
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
            this.components = new System.ComponentModel.Container();
            this.GameClock = new System.Windows.Forms.Timer(this.components);
            this.GameBoard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GameBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // GameClock
            // 
            this.GameClock.Tick += new System.EventHandler(this.GameClock_Tick);
            // 
            // GameBoard
            // 
            this.GameBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GameBoard.Location = new System.Drawing.Point(0, 0);
            this.GameBoard.Name = "GameBoard";
            this.GameBoard.Size = new System.Drawing.Size(495, 470);
            this.GameBoard.TabIndex = 0;
            this.GameBoard.TabStop = false;
            // 
            // GameScreen
            // 
            this.ClientSize = new System.Drawing.Size(496, 473);
            this.Controls.Add(this.GameBoard);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "GameScreen";
            this.Text = "Flatopia";
            this.Load += new System.EventHandler(this.GameScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GameBoard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer GameClock;
        private System.Windows.Forms.PictureBox GameBoard;
    }
}

