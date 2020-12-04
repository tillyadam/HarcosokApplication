namespace Adatbaziskezeles
{
    partial class Form_Adatbaziskezelo
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
            this.label_harcosLetrehozasa = new System.Windows.Forms.Label();
            this.label_harcosNeve = new System.Windows.Forms.Label();
            this.textBox_harcosNeve = new System.Windows.Forms.TextBox();
            this.button_letrehozas = new System.Windows.Forms.Button();
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.label_kepessegHozzaadasa = new System.Windows.Forms.Label();
            this.label_hasznalo = new System.Windows.Forms.Label();
            this.comboBox_hasznalo = new System.Windows.Forms.ComboBox();
            this.label_leiras = new System.Windows.Forms.Label();
            this.textBox_leiras = new System.Windows.Forms.TextBox();
            this.label_kepessegNeve = new System.Windows.Forms.Label();
            this.textBox_kepessegNeve = new System.Windows.Forms.TextBox();
            this.button_hozaad = new System.Windows.Forms.Button();
            this.label_harcosok = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox_harcosok = new System.Windows.Forms.ListBox();
            this.listBox_kepessegek = new System.Windows.Forms.ListBox();
            this.listBox_kepessegLeirasa = new System.Windows.Forms.ListBox();
            this.button_modosit = new System.Windows.Forms.Button();
            this.button_torles = new System.Windows.Forms.Button();
            this.label_vonal1 = new System.Windows.Forms.Label();
            this.label_vonal2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_harcosLetrehozasa
            // 
            this.label_harcosLetrehozasa.AutoSize = true;
            this.label_harcosLetrehozasa.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_harcosLetrehozasa.Location = new System.Drawing.Point(12, 9);
            this.label_harcosLetrehozasa.Name = "label_harcosLetrehozasa";
            this.label_harcosLetrehozasa.Size = new System.Drawing.Size(226, 22);
            this.label_harcosLetrehozasa.TabIndex = 0;
            this.label_harcosLetrehozasa.Text = "Harcos létrehozása";
            // 
            // label_harcosNeve
            // 
            this.label_harcosNeve.AutoSize = true;
            this.label_harcosNeve.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_harcosNeve.Location = new System.Drawing.Point(12, 48);
            this.label_harcosNeve.Name = "label_harcosNeve";
            this.label_harcosNeve.Size = new System.Drawing.Size(58, 22);
            this.label_harcosNeve.TabIndex = 1;
            this.label_harcosNeve.Text = "Név:";
            // 
            // textBox_harcosNeve
            // 
            this.textBox_harcosNeve.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_harcosNeve.Location = new System.Drawing.Point(86, 45);
            this.textBox_harcosNeve.Name = "textBox_harcosNeve";
            this.textBox_harcosNeve.Size = new System.Drawing.Size(246, 30);
            this.textBox_harcosNeve.TabIndex = 2;
            // 
            // button_letrehozas
            // 
            this.button_letrehozas.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_letrehozas.Location = new System.Drawing.Point(359, 49);
            this.button_letrehozas.Name = "button_letrehozas";
            this.button_letrehozas.Size = new System.Drawing.Size(103, 23);
            this.button_letrehozas.TabIndex = 3;
            this.button_letrehozas.Text = "Létrehozás";
            this.button_letrehozas.UseVisualStyleBackColor = true;
            // 
            // label_kepessegHozzaadasa
            // 
            this.label_kepessegHozzaadasa.AutoSize = true;
            this.label_kepessegHozzaadasa.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_kepessegHozzaadasa.Location = new System.Drawing.Point(12, 141);
            this.label_kepessegHozzaadasa.Name = "label_kepessegHozzaadasa";
            this.label_kepessegHozzaadasa.Size = new System.Drawing.Size(238, 22);
            this.label_kepessegHozzaadasa.TabIndex = 4;
            this.label_kepessegHozzaadasa.Text = "Képesség hozzáadása";
            // 
            // label_hasznalo
            // 
            this.label_hasznalo.AutoSize = true;
            this.label_hasznalo.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hasznalo.Location = new System.Drawing.Point(12, 178);
            this.label_hasznalo.Name = "label_hasznalo";
            this.label_hasznalo.Size = new System.Drawing.Size(118, 22);
            this.label_hasznalo.TabIndex = 5;
            this.label_hasznalo.Text = "Használó:";
            // 
            // comboBox_hasznalo
            // 
            this.comboBox_hasznalo.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Italic);
            this.comboBox_hasznalo.FormattingEnabled = true;
            this.comboBox_hasznalo.Location = new System.Drawing.Point(136, 175);
            this.comboBox_hasznalo.Name = "comboBox_hasznalo";
            this.comboBox_hasznalo.Size = new System.Drawing.Size(186, 31);
            this.comboBox_hasznalo.TabIndex = 6;
            // 
            // label_leiras
            // 
            this.label_leiras.AutoSize = true;
            this.label_leiras.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_leiras.Location = new System.Drawing.Point(355, 178);
            this.label_leiras.Name = "label_leiras";
            this.label_leiras.Size = new System.Drawing.Size(94, 22);
            this.label_leiras.TabIndex = 7;
            this.label_leiras.Text = "Leírás:";
            // 
            // textBox_leiras
            // 
            this.textBox_leiras.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Italic);
            this.textBox_leiras.Location = new System.Drawing.Point(455, 178);
            this.textBox_leiras.Multiline = true;
            this.textBox_leiras.Name = "textBox_leiras";
            this.textBox_leiras.Size = new System.Drawing.Size(333, 115);
            this.textBox_leiras.TabIndex = 8;
            // 
            // label_kepessegNeve
            // 
            this.label_kepessegNeve.AutoSize = true;
            this.label_kepessegNeve.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_kepessegNeve.Location = new System.Drawing.Point(12, 245);
            this.label_kepessegNeve.Name = "label_kepessegNeve";
            this.label_kepessegNeve.Size = new System.Drawing.Size(58, 22);
            this.label_kepessegNeve.TabIndex = 9;
            this.label_kepessegNeve.Text = "Név:";
            // 
            // textBox_kepessegNeve
            // 
            this.textBox_kepessegNeve.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Italic);
            this.textBox_kepessegNeve.Location = new System.Drawing.Point(86, 242);
            this.textBox_kepessegNeve.Name = "textBox_kepessegNeve";
            this.textBox_kepessegNeve.Size = new System.Drawing.Size(246, 30);
            this.textBox_kepessegNeve.TabIndex = 10;
            // 
            // button_hozaad
            // 
            this.button_hozaad.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_hozaad.Location = new System.Drawing.Point(16, 291);
            this.button_hozaad.Name = "button_hozaad";
            this.button_hozaad.Size = new System.Drawing.Size(114, 23);
            this.button_hozaad.TabIndex = 11;
            this.button_hozaad.Text = "Hozzáadás";
            this.button_hozaad.UseVisualStyleBackColor = true;
            // 
            // label_harcosok
            // 
            this.label_harcosok.AutoSize = true;
            this.label_harcosok.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_harcosok.Location = new System.Drawing.Point(12, 375);
            this.label_harcosok.Name = "label_harcosok";
            this.label_harcosok.Size = new System.Drawing.Size(118, 22);
            this.label_harcosok.TabIndex = 12;
            this.label_harcosok.Text = "Harcosok:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Képességei:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(494, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Képesség leírása";
            // 
            // listBox_harcosok
            // 
            this.listBox_harcosok.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Italic);
            this.listBox_harcosok.FormattingEnabled = true;
            this.listBox_harcosok.ItemHeight = 23;
            this.listBox_harcosok.Location = new System.Drawing.Point(16, 400);
            this.listBox_harcosok.Name = "listBox_harcosok";
            this.listBox_harcosok.Size = new System.Drawing.Size(200, 280);
            this.listBox_harcosok.TabIndex = 15;
            // 
            // listBox_kepessegek
            // 
            this.listBox_kepessegek.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Italic);
            this.listBox_kepessegek.FormattingEnabled = true;
            this.listBox_kepessegek.ItemHeight = 23;
            this.listBox_kepessegek.Location = new System.Drawing.Point(261, 400);
            this.listBox_kepessegek.Name = "listBox_kepessegek";
            this.listBox_kepessegek.Size = new System.Drawing.Size(200, 280);
            this.listBox_kepessegek.TabIndex = 16;
            // 
            // listBox_kepessegLeirasa
            // 
            this.listBox_kepessegLeirasa.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Italic);
            this.listBox_kepessegLeirasa.FormattingEnabled = true;
            this.listBox_kepessegLeirasa.ItemHeight = 23;
            this.listBox_kepessegLeirasa.Location = new System.Drawing.Point(498, 400);
            this.listBox_kepessegLeirasa.Name = "listBox_kepessegLeirasa";
            this.listBox_kepessegLeirasa.Size = new System.Drawing.Size(290, 165);
            this.listBox_kepessegLeirasa.TabIndex = 17;
            // 
            // button_modosit
            // 
            this.button_modosit.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_modosit.Location = new System.Drawing.Point(679, 586);
            this.button_modosit.Name = "button_modosit";
            this.button_modosit.Size = new System.Drawing.Size(109, 23);
            this.button_modosit.TabIndex = 18;
            this.button_modosit.Text = "Módosít";
            this.button_modosit.UseVisualStyleBackColor = true;
            // 
            // button_torles
            // 
            this.button_torles.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_torles.Location = new System.Drawing.Point(310, 698);
            this.button_torles.Name = "button_torles";
            this.button_torles.Size = new System.Drawing.Size(103, 23);
            this.button_torles.TabIndex = 19;
            this.button_torles.Text = "Törlés";
            this.button_torles.UseVisualStyleBackColor = true;
            // 
            // label_vonal1
            // 
            this.label_vonal1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_vonal1.Location = new System.Drawing.Point(14, 102);
            this.label_vonal1.Name = "label_vonal1";
            this.label_vonal1.Size = new System.Drawing.Size(773, 2);
            this.label_vonal1.TabIndex = 20;
            // 
            // label_vonal2
            // 
            this.label_vonal2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_vonal2.Location = new System.Drawing.Point(14, 350);
            this.label_vonal2.Name = "label_vonal2";
            this.label_vonal2.Size = new System.Drawing.Size(773, 2);
            this.label_vonal2.TabIndex = 21;
            // 
            // Form_Adatbaziskezelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 745);
            this.Controls.Add(this.label_vonal2);
            this.Controls.Add(this.label_vonal1);
            this.Controls.Add(this.button_torles);
            this.Controls.Add(this.button_modosit);
            this.Controls.Add(this.listBox_kepessegLeirasa);
            this.Controls.Add(this.listBox_kepessegek);
            this.Controls.Add(this.listBox_harcosok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_harcosok);
            this.Controls.Add(this.button_hozaad);
            this.Controls.Add(this.textBox_kepessegNeve);
            this.Controls.Add(this.label_kepessegNeve);
            this.Controls.Add(this.textBox_leiras);
            this.Controls.Add(this.label_leiras);
            this.Controls.Add(this.comboBox_hasznalo);
            this.Controls.Add(this.label_hasznalo);
            this.Controls.Add(this.label_kepessegHozzaadasa);
            this.Controls.Add(this.button_letrehozas);
            this.Controls.Add(this.textBox_harcosNeve);
            this.Controls.Add(this.label_harcosNeve);
            this.Controls.Add(this.label_harcosLetrehozasa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Adatbaziskezelo";
            this.Text = "Adatbázis";
            this.Load += new System.EventHandler(this.Form_Adatbaziskezelo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_harcosLetrehozasa;
        private System.Windows.Forms.Label label_harcosNeve;
        private System.Windows.Forms.TextBox textBox_harcosNeve;
        private System.Windows.Forms.Button button_letrehozas;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
        private System.Windows.Forms.Label label_kepessegHozzaadasa;
        private System.Windows.Forms.Label label_hasznalo;
        private System.Windows.Forms.ComboBox comboBox_hasznalo;
        private System.Windows.Forms.Label label_leiras;
        private System.Windows.Forms.TextBox textBox_leiras;
        private System.Windows.Forms.Label label_kepessegNeve;
        private System.Windows.Forms.TextBox textBox_kepessegNeve;
        private System.Windows.Forms.Button button_hozaad;
        private System.Windows.Forms.Label label_harcosok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox_harcosok;
        private System.Windows.Forms.ListBox listBox_kepessegek;
        private System.Windows.Forms.ListBox listBox_kepessegLeirasa;
        private System.Windows.Forms.Button button_modosit;
        private System.Windows.Forms.Button button_torles;
        private System.Windows.Forms.Label label_vonal1;
        private System.Windows.Forms.Label label_vonal2;
    }
}

