namespace FrogWorldOOP
{
    partial class FrogWorld
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cmdNewFrog = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Frog",
            "HoverFrog",
            "UndergroundFrog"});
            this.comboBox1.Location = new System.Drawing.Point(561, 67);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // cmdNewFrog
            // 
            this.cmdNewFrog.Location = new System.Drawing.Point(561, 23);
            this.cmdNewFrog.Name = "cmdNewFrog";
            this.cmdNewFrog.Size = new System.Drawing.Size(75, 23);
            this.cmdNewFrog.TabIndex = 2;
            this.cmdNewFrog.Text = "Create";
            this.cmdNewFrog.UseVisualStyleBackColor = true;
            this.cmdNewFrog.Click += new System.EventHandler(this.cmdNewFrog_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Green;
            this.pictureBox2.Location = new System.Drawing.Point(0, 193);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(710, 100);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // FrogWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(707, 289);
            this.Controls.Add(this.cmdNewFrog);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "FrogWorld";
            this.Text = "Frog World";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

 
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button cmdNewFrog;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

