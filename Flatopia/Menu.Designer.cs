namespace Flatopia
{
    partial class Menu
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
            this.Play_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Play_Btn
            // 
            this.Play_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Play_Btn.Location = new System.Drawing.Point(148, 142);
            this.Play_Btn.Name = "Play_Btn";
            this.Play_Btn.Size = new System.Drawing.Size(125, 60);
            this.Play_Btn.TabIndex = 0;
            this.Play_Btn.Text = "Play";
            this.Play_Btn.UseVisualStyleBackColor = true;
            this.Play_Btn.Click += new System.EventHandler(this.Play_Btn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 473);
            this.Controls.Add(this.Play_Btn);
            this.Name = "Menu";
            this.Text = "Flatopia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Play_Btn;
    }
}