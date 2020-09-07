namespace Dictionaire
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
            this.upDownMin = new System.Windows.Forms.NumericUpDown();
            this.upDownMax = new System.Windows.Forms.NumericUpDown();
            this.generateBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.alphaMin = new System.Windows.Forms.CheckBox();
            this.alphaCaps = new System.Windows.Forms.CheckBox();
            this.numeral = new System.Windows.Forms.CheckBox();
            this.usedChar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.upDownMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownMax)).BeginInit();
            this.SuspendLayout();
            // 
            // upDownMin
            // 
            this.upDownMin.Location = new System.Drawing.Point(313, 9);
            this.upDownMin.Name = "upDownMin";
            this.upDownMin.Size = new System.Drawing.Size(38, 20);
            this.upDownMin.TabIndex = 3;
            this.upDownMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.upDownMin.ValueChanged += new System.EventHandler(this.upDownMin_ValueChanged);
            // 
            // upDownMax
            // 
            this.upDownMax.Location = new System.Drawing.Point(313, 37);
            this.upDownMax.Name = "upDownMax";
            this.upDownMax.Size = new System.Drawing.Size(38, 20);
            this.upDownMax.TabIndex = 4;
            this.upDownMax.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.upDownMax.ValueChanged += new System.EventHandler(this.upDownMax_ValueChanged);
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(224, 95);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(127, 36);
            this.generateBtn.TabIndex = 5;
            this.generateBtn.Text = "Generate !";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = " Longueur minimale";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = " Longueur maximal";
            // 
            // alphaMin
            // 
            this.alphaMin.AutoSize = true;
            this.alphaMin.Location = new System.Drawing.Point(12, 12);
            this.alphaMin.Name = "alphaMin";
            this.alphaMin.Size = new System.Drawing.Size(113, 17);
            this.alphaMin.TabIndex = 8;
            this.alphaMin.Text = "Lettres minuscules";
            this.alphaMin.UseVisualStyleBackColor = true;
            this.alphaMin.CheckStateChanged += new System.EventHandler(this.alphaMin_CheckStateChanged);
            // 
            // alphaCaps
            // 
            this.alphaCaps.AutoSize = true;
            this.alphaCaps.Location = new System.Drawing.Point(12, 35);
            this.alphaCaps.Name = "alphaCaps";
            this.alphaCaps.Size = new System.Drawing.Size(108, 17);
            this.alphaCaps.TabIndex = 9;
            this.alphaCaps.Text = "Lettres majuscule";
            this.alphaCaps.UseVisualStyleBackColor = true;
            this.alphaCaps.CheckStateChanged += new System.EventHandler(this.alphaCaps_CheckStateChanged);
            // 
            // numeral
            // 
            this.numeral.AutoSize = true;
            this.numeral.Location = new System.Drawing.Point(12, 58);
            this.numeral.Name = "numeral";
            this.numeral.Size = new System.Drawing.Size(87, 17);
            this.numeral.TabIndex = 10;
            this.numeral.Text = "Numero (0-9)";
            this.numeral.UseVisualStyleBackColor = true;
            this.numeral.CheckStateChanged += new System.EventHandler(this.numeral_CheckStateChanged);
            // 
            // usedChar
            // 
            this.usedChar.Location = new System.Drawing.Point(12, 96);
            this.usedChar.Multiline = true;
            this.usedChar.Name = "usedChar";
            this.usedChar.Size = new System.Drawing.Size(206, 35);
            this.usedChar.TabIndex = 11;
            this.usedChar.TextChanged += new System.EventHandler(this.usedChar_TextChanged);
            this.usedChar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.usedChar_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Personnaliser ...";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(224, 96);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(127, 35);
            this.progressBar.TabIndex = 13;
            this.progressBar.Visible = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.generateBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 135);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usedChar);
            this.Controls.Add(this.numeral);
            this.Controls.Add(this.alphaCaps);
            this.Controls.Add(this.alphaMin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.upDownMax);
            this.Controls.Add(this.upDownMin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Dictionary generator";
            ((System.ComponentModel.ISupportInitialize)(this.upDownMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown upDownMin;
        private System.Windows.Forms.NumericUpDown upDownMax;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox alphaMin;
        private System.Windows.Forms.CheckBox alphaCaps;
        private System.Windows.Forms.CheckBox numeral;
        private System.Windows.Forms.TextBox usedChar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

