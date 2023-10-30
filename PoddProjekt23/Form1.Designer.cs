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
            this.CBKategori = new System.Windows.Forms.ComboBox();
            this.listBoxAvsnitt = new System.Windows.Forms.ListBox();
            this.listBoxPoddar = new System.Windows.Forms.ListBox();
            this.buttonKategori = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNamn = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.CBKategori1 = new System.Windows.Forms.ComboBox();
            this.listBoxInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(165, 188);
            this.textBoxUrl.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(167, 20);
            this.textBoxUrl.TabIndex = 0;
            // 
            // CBKategori
            // 
            this.CBKategori.FormattingEnabled = true;
            this.CBKategori.Location = new System.Drawing.Point(219, 319);
            this.CBKategori.Margin = new System.Windows.Forms.Padding(2);
            this.CBKategori.Name = "CBKategori";
            this.CBKategori.Size = new System.Drawing.Size(113, 21);
            this.CBKategori.TabIndex = 7;
            // 
            // listBoxAvsnitt
            // 
            this.listBoxAvsnitt.FormattingEnabled = true;
            this.listBoxAvsnitt.Location = new System.Drawing.Point(581, 431);
            this.listBoxAvsnitt.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxAvsnitt.Name = "listBoxAvsnitt";
            this.listBoxAvsnitt.Size = new System.Drawing.Size(262, 381);
            this.listBoxAvsnitt.TabIndex = 10;
            this.listBoxAvsnitt.SelectedIndexChanged += new System.EventHandler(this.listBoxAvsnitt_SelectedIndexChanged);
            // 
            // listBoxPoddar
            // 
            this.listBoxPoddar.FormattingEnabled = true;
            this.listBoxPoddar.Location = new System.Drawing.Point(111, 561);
            this.listBoxPoddar.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxPoddar.Name = "listBoxPoddar";
            this.listBoxPoddar.Size = new System.Drawing.Size(430, 251);
            this.listBoxPoddar.TabIndex = 11;
            this.listBoxPoddar.SelectedIndexChanged += new System.EventHandler(this.listBoxPoddar_SelectedIndexChanged);
            // 
            // buttonKategori
            // 
            this.buttonKategori.BackColor = System.Drawing.Color.Transparent;
            this.buttonKategori.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonKategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKategori.ForeColor = System.Drawing.Color.White;
            this.buttonKategori.Location = new System.Drawing.Point(239, 530);
            this.buttonKategori.Margin = new System.Windows.Forms.Padding(2);
            this.buttonKategori.Name = "buttonKategori";
            this.buttonKategori.Size = new System.Drawing.Size(118, 27);
            this.buttonKategori.TabIndex = 12;
            this.buttonKategori.Text = "Hämta podd";
            this.buttonKategori.UseVisualStyleBackColor = false;
            this.buttonKategori.Click += new System.EventHandler(this.buttonKategori_Click);
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(827, 54);
            this.close.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(31, 29);
            this.close.TabIndex = 13;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(361, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 39);
            this.button1.TabIndex = 14;
            this.button1.Text = "Lägg till ny";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNamn
            // 
            this.txtNamn.Location = new System.Drawing.Point(192, 253);
            this.txtNamn.Name = "txtNamn";
            this.txtNamn.Size = new System.Drawing.Size(140, 20);
            this.txtNamn.TabIndex = 16;
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.Transparent;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.ForeColor = System.Drawing.Color.White;
            this.btnChange.Location = new System.Drawing.Point(361, 530);
            this.btnChange.Margin = new System.Windows.Forms.Padding(2);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(81, 27);
            this.btnChange.TabIndex = 18;
            this.btnChange.Text = "Ändra";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Location = new System.Drawing.Point(446, 530);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 27);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Ta bort";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // CBKategori1
            // 
            this.CBKategori1.FormattingEnabled = true;
            this.CBKategori1.Location = new System.Drawing.Point(111, 418);
            this.CBKategori1.Name = "CBKategori1";
            this.CBKategori1.Size = new System.Drawing.Size(221, 21);
            this.CBKategori1.TabIndex = 21;
            this.CBKategori1.SelectedIndexChanged += new System.EventHandler(this.CBKategori1_SelectedIndexChanged);
            // 
            // listBoxInfo
            // 
            this.listBoxInfo.Location = new System.Drawing.Point(521, 204);
            this.listBoxInfo.Multiline = true;
            this.listBoxInfo.Name = "listBoxInfo";
            this.listBoxInfo.Size = new System.Drawing.Size(337, 142);
            this.listBoxInfo.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(952, 888);
            this.Controls.Add(this.listBoxInfo);
            this.Controls.Add(this.CBKategori1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.txtNamn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.buttonKategori);
            this.Controls.Add(this.listBoxPoddar);
            this.Controls.Add(this.listBoxAvsnitt);
            this.Controls.Add(this.CBKategori);
            this.Controls.Add(this.textBoxUrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.ComboBox CBKategori;
        private System.Windows.Forms.ListBox listBoxAvsnitt;
        private System.Windows.Forms.ListBox listBoxPoddar;
        private System.Windows.Forms.Button buttonKategori;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNamn;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox CBKategori1;
        private System.Windows.Forms.TextBox listBoxInfo;
    }
}

