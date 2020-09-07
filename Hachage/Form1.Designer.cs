namespace Hachage
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userHash = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.setting = new System.Windows.Forms.PictureBox();
            this.wordCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tentativeCount = new System.Windows.Forms.Label();
            this.noMatch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.setting)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tentative : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Temps ecoule: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saisir votre hachage ici :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mots dans le dictionnaire :";
            // 
            // userHash
            // 
            this.userHash.Location = new System.Drawing.Point(10, 68);
            this.userHash.Name = "userHash";
            this.userHash.Size = new System.Drawing.Size(173, 20);
            this.userHash.TabIndex = 4;
            this.userHash.TextChanged += new System.EventHandler(this.userHash_TextChanged);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(193, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 19);
            this.button1.TabIndex = 5;
            this.button1.Text = "Valider !";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(10, 11);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(120, 28);
            this.progressBar1.TabIndex = 6;
            // 
            // setting
            // 
            this.setting.Image = global::Hachage.Properties.Resources.setting_512;
            this.setting.Location = new System.Drawing.Point(12, 94);
            this.setting.Name = "setting";
            this.setting.Size = new System.Drawing.Size(23, 24);
            this.setting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.setting.TabIndex = 7;
            this.setting.TabStop = false;
            this.setting.Click += new System.EventHandler(this.setting_Click);
            // 
            // wordCount
            // 
            this.wordCount.AutoSize = true;
            this.wordCount.Location = new System.Drawing.Point(238, 102);
            this.wordCount.Name = "wordCount";
            this.wordCount.Size = new System.Drawing.Size(13, 13);
            this.wordCount.TabIndex = 8;
            this.wordCount.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "0m00s";
            // 
            // tentativeCount
            // 
            this.tentativeCount.AutoSize = true;
            this.tentativeCount.Location = new System.Drawing.Point(198, 9);
            this.tentativeCount.Name = "tentativeCount";
            this.tentativeCount.Size = new System.Drawing.Size(30, 13);
            this.tentativeCount.TabIndex = 10;
            this.tentativeCount.Text = "0 / 0";
            // 
            // noMatch
            // 
            this.noMatch.AutoSize = true;
            this.noMatch.ForeColor = System.Drawing.Color.Maroon;
            this.noMatch.Location = new System.Drawing.Point(136, 39);
            this.noMatch.Name = "noMatch";
            this.noMatch.Size = new System.Drawing.Size(169, 13);
            this.noMatch.TabIndex = 11;
            this.noMatch.Text = "Aucune correspondance trouvée !";
            this.noMatch.Visible = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 124);
            this.Controls.Add(this.noMatch);
            this.Controls.Add(this.tentativeCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.wordCount);
            this.Controls.Add(this.setting);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userHash);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Hash Finder";
            ((System.ComponentModel.ISupportInitialize)(this.setting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox userHash;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox setting;
        private System.Windows.Forms.Label wordCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label tentativeCount;
        private System.Windows.Forms.Label noMatch;
    }
}

