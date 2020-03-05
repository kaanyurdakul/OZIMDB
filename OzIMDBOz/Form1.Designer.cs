using System;

namespace OzIMDBOz
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
            this.btnYeniFilm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFilmId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gboPuan = new System.Windows.Forms.GroupBox();
            this.rbPuanYok = new System.Windows.Forms.RadioButton();
            this.rbPuan1 = new System.Windows.Forms.RadioButton();
            this.rbPuan5 = new System.Windows.Forms.RadioButton();
            this.rbPuan2 = new System.Windows.Forms.RadioButton();
            this.rbPuan4 = new System.Windows.Forms.RadioButton();
            this.rbPuan3 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilmAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pboFoto = new System.Windows.Forms.PictureBox();
            this.lstFilmler = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.gboPuan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYeniFilm
            // 
            this.btnYeniFilm.Location = new System.Drawing.Point(13, 13);
            this.btnYeniFilm.Margin = new System.Windows.Forms.Padding(4);
            this.btnYeniFilm.Name = "btnYeniFilm";
            this.btnYeniFilm.Size = new System.Drawing.Size(176, 36);
            this.btnYeniFilm.TabIndex = 0;
            this.btnYeniFilm.Text = "Yeni Film Ekle";
            this.btnYeniFilm.UseVisualStyleBackColor = true;
            this.btnYeniFilm.Click += new System.EventHandler(this.btnYeniFilm_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFilmId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.gboPuan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFilmAd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pboFoto);
            this.groupBox1.Location = new System.Drawing.Point(13, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(421, 428);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Film Detayları";
            // 
            // txtFilmId
            // 
            this.txtFilmId.Location = new System.Drawing.Point(7, 43);
            this.txtFilmId.Name = "txtFilmId";
            this.txtFilmId.ReadOnly = true;
            this.txtFilmId.Size = new System.Drawing.Size(95, 24);
            this.txtFilmId.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Film No";
            // 
            // gboPuan
            // 
            this.gboPuan.Controls.Add(this.rbPuanYok);
            this.gboPuan.Controls.Add(this.rbPuan1);
            this.gboPuan.Controls.Add(this.rbPuan5);
            this.gboPuan.Controls.Add(this.rbPuan2);
            this.gboPuan.Controls.Add(this.rbPuan4);
            this.gboPuan.Controls.Add(this.rbPuan3);
            this.gboPuan.Location = new System.Drawing.Point(7, 132);
            this.gboPuan.Name = "gboPuan";
            this.gboPuan.Size = new System.Drawing.Size(157, 205);
            this.gboPuan.TabIndex = 10;
            this.gboPuan.TabStop = false;
            this.gboPuan.Text = "Puan";
            // 
            // rbPuanYok
            // 
            this.rbPuanYok.AutoSize = true;
            this.rbPuanYok.Location = new System.Drawing.Point(13, 28);
            this.rbPuanYok.Name = "rbPuanYok";
            this.rbPuanYok.Size = new System.Drawing.Size(124, 22);
            this.rbPuanYok.TabIndex = 9;
            this.rbPuanYok.TabStop = true;
            this.rbPuanYok.Text = "Puan Verilmedi";
            this.rbPuanYok.UseVisualStyleBackColor = true;
            this.rbPuanYok.CheckedChanged += new System.EventHandler(this.rbPuanYok_CheckedChanged);
            // 
            // rbPuan1
            // 
            this.rbPuan1.AutoSize = true;
            this.rbPuan1.Location = new System.Drawing.Point(13, 56);
            this.rbPuan1.Name = "rbPuan1";
            this.rbPuan1.Size = new System.Drawing.Size(110, 22);
            this.rbPuan1.TabIndex = 4;
            this.rbPuan1.TabStop = true;
            this.rbPuan1.Tag = "1";
            this.rbPuan1.Text = "1 - Çok Kötü";
            this.rbPuan1.UseVisualStyleBackColor = true;
            this.rbPuan1.CheckedChanged += new System.EventHandler(this.rbPuanYok_CheckedChanged);
            // 
            // rbPuan5
            // 
            this.rbPuan5.AutoSize = true;
            this.rbPuan5.Location = new System.Drawing.Point(13, 168);
            this.rbPuan5.Name = "rbPuan5";
            this.rbPuan5.Size = new System.Drawing.Size(92, 22);
            this.rbPuan5.TabIndex = 8;
            this.rbPuan5.TabStop = true;
            this.rbPuan5.Tag = "5";
            this.rbPuan5.Text = "5 - Çok İyi";
            this.rbPuan5.UseVisualStyleBackColor = true;
            this.rbPuan5.CheckedChanged += new System.EventHandler(this.rbPuanYok_CheckedChanged);
            // 
            // rbPuan2
            // 
            this.rbPuan2.AutoSize = true;
            this.rbPuan2.Location = new System.Drawing.Point(13, 84);
            this.rbPuan2.Name = "rbPuan2";
            this.rbPuan2.Size = new System.Drawing.Size(78, 22);
            this.rbPuan2.TabIndex = 5;
            this.rbPuan2.TabStop = true;
            this.rbPuan2.Tag = "2";
            this.rbPuan2.Text = "2 - Kötü";
            this.rbPuan2.UseVisualStyleBackColor = true;
            this.rbPuan2.CheckedChanged += new System.EventHandler(this.rbPuanYok_CheckedChanged);
            // 
            // rbPuan4
            // 
            this.rbPuan4.AutoSize = true;
            this.rbPuan4.Location = new System.Drawing.Point(13, 140);
            this.rbPuan4.Name = "rbPuan4";
            this.rbPuan4.Size = new System.Drawing.Size(60, 22);
            this.rbPuan4.TabIndex = 7;
            this.rbPuan4.TabStop = true;
            this.rbPuan4.Tag = "4";
            this.rbPuan4.Text = "4 - İyi";
            this.rbPuan4.UseVisualStyleBackColor = true;
            this.rbPuan4.CheckedChanged += new System.EventHandler(this.rbPuanYok_CheckedChanged);
            // 
            // rbPuan3
            // 
            this.rbPuan3.AutoSize = true;
            this.rbPuan3.Location = new System.Drawing.Point(13, 112);
            this.rbPuan3.Name = "rbPuan3";
            this.rbPuan3.Size = new System.Drawing.Size(76, 22);
            this.rbPuan3.TabIndex = 6;
            this.rbPuan3.TabStop = true;
            this.rbPuan3.Tag = "3";
            this.rbPuan3.Text = "3 - Orta";
            this.rbPuan3.UseVisualStyleBackColor = true;
            this.rbPuan3.CheckedChanged += new System.EventHandler(this.rbPuanYok_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(221, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "(Resmi Değiştirmek İçin Tıklayınız)";
            // 
            // txtFilmAd
            // 
            this.txtFilmAd.Location = new System.Drawing.Point(7, 94);
            this.txtFilmAd.Name = "txtFilmAd";
            this.txtFilmAd.Size = new System.Drawing.Size(392, 24);
            this.txtFilmAd.TabIndex = 2;
            this.txtFilmAd.TextChanged += new System.EventHandler(this.txtFilmAd_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fİlm Adı";
            // 
            // pboFoto
            // 
            this.pboFoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pboFoto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pboFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pboFoto.Location = new System.Drawing.Point(214, 132);
            this.pboFoto.Margin = new System.Windows.Forms.Padding(4);
            this.pboFoto.Name = "pboFoto";
            this.pboFoto.Size = new System.Drawing.Size(185, 205);
            this.pboFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboFoto.TabIndex = 0;
            this.pboFoto.TabStop = false;
            this.pboFoto.Click += new System.EventHandler(this.pboFoto_Click);
            // 
            // lstFilmler
            // 
            this.lstFilmler.DisplayMember = "FilmAd";
            this.lstFilmler.FormattingEnabled = true;
            this.lstFilmler.ItemHeight = 18;
            this.lstFilmler.Location = new System.Drawing.Point(455, 12);
            this.lstFilmler.Margin = new System.Windows.Forms.Padding(4);
            this.lstFilmler.Name = "lstFilmler";
            this.lstFilmler.Size = new System.Drawing.Size(252, 472);
            this.lstFilmler.TabIndex = 2;
            this.lstFilmler.ValueMember = "Id";
            this.lstFilmler.SelectedValueChanged += new System.EventHandler(this.lstFilmler_SelectedValueChanged);
            this.lstFilmler.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstFilmler_KeyDown);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 497);
            this.Controls.Add(this.lstFilmler);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnYeniFilm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gboPuan.ResumeLayout(false);
            this.gboPuan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboFoto)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Button btnYeniFilm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbPuan5;
        private System.Windows.Forms.RadioButton rbPuan4;
        private System.Windows.Forms.RadioButton rbPuan3;
        private System.Windows.Forms.RadioButton rbPuan2;
        private System.Windows.Forms.RadioButton rbPuan1;
        private System.Windows.Forms.TextBox txtFilmAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pboFoto;
        private System.Windows.Forms.ListBox lstFilmler;
        private System.Windows.Forms.GroupBox gboPuan;
        private System.Windows.Forms.TextBox txtFilmId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbPuanYok;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

