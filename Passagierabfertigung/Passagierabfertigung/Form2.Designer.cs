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
            this.buchen = new System.Windows.Forms.Button();
            this.meinefluege = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buchen
            // 
            this.buchen.Location = new System.Drawing.Point(12, 148);
            this.buchen.Name = "buchen";
            this.buchen.Size = new System.Drawing.Size(87, 35);
            this.buchen.TabIndex = 0;
            this.buchen.Text = "Flug buchen";
            this.buchen.UseVisualStyleBackColor = true;
            this.buchen.Click += new System.EventHandler(this.buchen_Click);
            // 
            // meinefluege
            // 
            this.meinefluege.Location = new System.Drawing.Point(177, 148);
            this.meinefluege.Name = "meinefluege";
            this.meinefluege.Size = new System.Drawing.Size(95, 35);
            this.meinefluege.TabIndex = 1;
            this.meinefluege.Text = "Meine Flüge";
            this.meinefluege.UseVisualStyleBackColor = true;
            this.meinefluege.Click += new System.EventHandler(this.meinefluege_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "hier soll noch das logo hin";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(177, 226);
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
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.meinefluege);
            this.Controls.Add(this.buchen);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buchen;
        private System.Windows.Forms.Button meinefluege;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exit;
    }
}