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
            this.CBKategori = new System.Windows.Forms.ComboBox();
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
            this.CBKategori1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(51, 52);
            this.textBoxUrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(135, 22);
            this.textBoxUrl.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Namn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kategori";
            // 
            // CBKategori
            // 
            this.CBKategori.FormattingEnabled = true;
            this.CBKategori.Location = new System.Drawing.Point(51, 174);
            this.CBKategori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBKategori.Name = "CBKategori";
            this.CBKategori.Size = new System.Drawing.Size(135, 24);
            this.CBKategori.TabIndex = 7;
            // 
            // listBoxInfo
            // 
            this.listBoxInfo.FormattingEnabled = true;
            this.listBoxInfo.ItemHeight = 16;
            this.listBoxInfo.Location = new System.Drawing.Point(544, 52);
            this.listBoxInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxInfo.Name = "listBoxInfo";
            this.listBoxInfo.Size = new System.Drawing.Size(592, 196);
            this.listBoxInfo.TabIndex = 9;
            // 
            // listBoxAvsnitt
            // 
            this.listBoxAvsnitt.FormattingEnabled = true;
            this.listBoxAvsnitt.ItemHeight = 16;
            this.listBoxAvsnitt.Location = new System.Drawing.Point(855, 393);
            this.listBoxAvsnitt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxAvsnitt.Name = "listBoxAvsnitt";
            this.listBoxAvsnitt.Size = new System.Drawing.Size(396, 340);
            this.listBoxAvsnitt.TabIndex = 10;
            // 
            // listBoxPoddar
            // 
            this.listBoxPoddar.FormattingEnabled = true;
            this.listBoxPoddar.ItemHeight = 16;
            this.listBoxPoddar.Location = new System.Drawing.Point(37, 393);
            this.listBoxPoddar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxPoddar.Name = "listBoxPoddar";
            this.listBoxPoddar.Size = new System.Drawing.Size(639, 308);
            this.listBoxPoddar.TabIndex = 11;
            this.listBoxPoddar.SelectedIndexChanged += new System.EventHandler(this.listBoxPoddar_SelectedIndexChanged);
            // 
            // buttonKategori
            // 
            this.buttonKategori.Location = new System.Drawing.Point(295, 345);
            this.buttonKategori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonKategori.Name = "buttonKategori";
            this.buttonKategori.Size = new System.Drawing.Size(112, 32);
            this.buttonKategori.TabIndex = 12;
            this.buttonKategori.Text = "Hämta podd";
            this.buttonKategori.UseVisualStyleBackColor = true;
            this.buttonKategori.Click += new System.EventHandler(this.buttonKategori_Click);
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Location = new System.Drawing.Point(1361, 11);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(15, 16);
            this.close.TabIndex = 13;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 171);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 28);
            this.button1.TabIndex = 14;
            this.button1.Text = "Lägg till ny";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNamn
            // 
            this.txtNamn.Location = new System.Drawing.Point(51, 126);
            this.txtNamn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNamn.Name = "txtNamn";
            this.txtNamn.Size = new System.Drawing.Size(132, 22);
            this.txtNamn.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Url";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(427, 345);
            this.btnChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(112, 32);
            this.btnChange.TabIndex = 18;
            this.btnChange.Text = "Ändra podd";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(565, 345);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 32);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Ta bort";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // CBKategori1
            // 
            this.CBKategori1.FormattingEnabled = true;
            this.CBKategori1.Location = new System.Drawing.Point(344, 171);
            this.CBKategori1.Name = "CBKategori1";
            this.CBKategori1.Size = new System.Drawing.Size(121, 24);
            this.CBKategori1.TabIndex = 20;
            this.CBKategori1.SelectedIndexChanged += new System.EventHandler(this.CBKategori1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1411, 826);
            this.Controls.Add(this.CBKategori1);
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
            this.Controls.Add(this.CBKategori);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBKategori;
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
        private System.Windows.Forms.ComboBox CBKategori1;
    }
}

