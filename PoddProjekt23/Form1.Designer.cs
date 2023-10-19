namespace PL
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CBKategori = new System.Windows.Forms.ComboBox();
            this.comboBoxFrekvens = new System.Windows.Forms.ComboBox();
            this.listBoxInfo = new System.Windows.Forms.ListBox();
            this.listBoxAvsnitt = new System.Windows.Forms.ListBox();
            this.listBoxPoddar = new System.Windows.Forms.ListBox();
            this.buttonKategori = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNamn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(38, 42);
            this.textBoxUrl.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(102, 20);
            this.textBoxUrl.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Namn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kategori";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Frekvens";
            // 
            // CBKategori
            // 
            this.CBKategori.FormattingEnabled = true;
            this.CBKategori.Location = new System.Drawing.Point(38, 141);
            this.CBKategori.Margin = new System.Windows.Forms.Padding(2);
            this.CBKategori.Name = "CBKategori";
            this.CBKategori.Size = new System.Drawing.Size(102, 21);
            this.CBKategori.TabIndex = 7;
            // 
            // comboBoxFrekvens
            // 
            this.comboBoxFrekvens.FormattingEnabled = true;
            this.comboBoxFrekvens.Location = new System.Drawing.Point(38, 185);
            this.comboBoxFrekvens.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxFrekvens.Name = "comboBoxFrekvens";
            this.comboBoxFrekvens.Size = new System.Drawing.Size(102, 21);
            this.comboBoxFrekvens.TabIndex = 8;
            // 
            // listBoxInfo
            // 
            this.listBoxInfo.FormattingEnabled = true;
            this.listBoxInfo.Location = new System.Drawing.Point(408, 42);
            this.listBoxInfo.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxInfo.Name = "listBoxInfo";
            this.listBoxInfo.Size = new System.Drawing.Size(354, 186);
            this.listBoxInfo.TabIndex = 9;
            // 
            // listBoxAvsnitt
            // 
            this.listBoxAvsnitt.FormattingEnabled = true;
            this.listBoxAvsnitt.Location = new System.Drawing.Point(554, 293);
            this.listBoxAvsnitt.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxAvsnitt.Name = "listBoxAvsnitt";
            this.listBoxAvsnitt.Size = new System.Drawing.Size(298, 277);
            this.listBoxAvsnitt.TabIndex = 10;
            // 
            // listBoxPoddar
            // 
            this.listBoxPoddar.FormattingEnabled = true;
            this.listBoxPoddar.Location = new System.Drawing.Point(28, 319);
            this.listBoxPoddar.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxPoddar.Name = "listBoxPoddar";
            this.listBoxPoddar.Size = new System.Drawing.Size(480, 251);
            this.listBoxPoddar.TabIndex = 11;
            // 
            // buttonKategori
            // 
            this.buttonKategori.Location = new System.Drawing.Point(221, 280);
            this.buttonKategori.Margin = new System.Windows.Forms.Padding(2);
            this.buttonKategori.Name = "buttonKategori";
            this.buttonKategori.Size = new System.Drawing.Size(84, 26);
            this.buttonKategori.TabIndex = 12;
            this.buttonKategori.Text = "Hämta podd";
            this.buttonKategori.UseVisualStyleBackColor = true;
            this.buttonKategori.Click += new System.EventHandler(this.buttonKategori_Click);
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Location = new System.Drawing.Point(832, 16);
            this.close.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(14, 13);
            this.close.TabIndex = 13;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Lägg till ny";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNamn
            // 
            this.txtNamn.Location = new System.Drawing.Point(38, 102);
            this.txtNamn.Name = "txtNamn";
            this.txtNamn.Size = new System.Drawing.Size(100, 20);
            this.txtNamn.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Url";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(320, 280);
            this.btnChange.Margin = new System.Windows.Forms.Padding(2);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(84, 26);
            this.btnChange.TabIndex = 18;
            this.btnChange.Text = "Ändra podd";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(424, 280);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 26);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Ta bort";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(863, 605);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNamn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.buttonKategori);
            this.Controls.Add(this.listBoxPoddar);
            this.Controls.Add(this.listBoxAvsnitt);
            this.Controls.Add(this.listBoxInfo);
            this.Controls.Add(this.comboBoxFrekvens);
            this.Controls.Add(this.CBKategori);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBKategori;
        private System.Windows.Forms.ComboBox comboBoxFrekvens;
        private System.Windows.Forms.ListBox listBoxInfo;
        private System.Windows.Forms.ListBox listBoxAvsnitt;
        private System.Windows.Forms.ListBox listBoxPoddar;
        private System.Windows.Forms.Button buttonKategori;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNamn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
    }
}

