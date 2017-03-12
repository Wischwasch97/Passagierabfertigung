namespace Passagierabfertigung
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.buchen = new System.Windows.Forms.Button();
            this.meinefluege = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buchen
            // 
            this.buchen.Location = new System.Drawing.Point(291, 407);
            this.buchen.Name = "buchen";
            this.buchen.Size = new System.Drawing.Size(273, 74);
            this.buchen.TabIndex = 0;
            this.buchen.Text = "Flug buchen";
            this.buchen.UseVisualStyleBackColor = true;
            this.buchen.Click += new System.EventHandler(this.buchen_Click);
            // 
            // meinefluege
            // 
            this.meinefluege.Location = new System.Drawing.Point(711, 407);
            this.meinefluege.Name = "meinefluege";
            this.meinefluege.Size = new System.Drawing.Size(273, 74);
            this.meinefluege.TabIndex = 1;
            this.meinefluege.Text = "Meine Flüge";
            this.meinefluege.UseVisualStyleBackColor = true;
            this.meinefluege.Click += new System.EventHandler(this.meinefluege_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(1188, 582);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 3;
            this.exit.Text = "Logout";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1275, 617);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.meinefluege);
            this.Controls.Add(this.buchen);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buchen;
        private System.Windows.Forms.Button meinefluege;
        private System.Windows.Forms.Button exit;
    }
}