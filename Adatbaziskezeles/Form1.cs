using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adatbaziskezeles
{
    public partial class Form_Adatbaziskezelo : Form
    {
        private void Form_Adatbaziskezelo_Load(object sender, EventArgs e)
        {

            connect();
            tablesCreate();
            listBoxHarcosokLoad();
            comboBoxHasznaloLoad();
            disconnect();
        }

        MySqlConnection conn = null;
        MySqlCommand sql = null;
        public Form_Adatbaziskezelo()
        {
            InitializeComponent();
        }

        private void connect()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "cs_harcosok";
            sb.CharacterSet = "utf8";

            conn = new MySqlConnection(sb.ToString());

            try
            {
                conn.Open();
                sql = conn.CreateCommand();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
        }

        private void tablesCreate()
        {
            try
            {
                sql.CommandText = @"CREATE TABLE IF NOT EXISTS `harcosok` ( 
                                    `id` INT NOT NULL AUTO_INCREMENT , 
                                    `nev` VARCHAR(255) NOT NULL , 
                                    `letrehozas` DATETIME NOT NULL ,
                                    PRIMARY KEY (`id`), 
                                    UNIQUE (`nev`));";

                sql.ExecuteNonQuery();

                sql.CommandText = @"CREATE TABLE IF NOT EXISTS `kepessegek` ( 
                                    `id` INT NOT NULL AUTO_INCREMENT , 
                                    `nev` VARCHAR(255) NOT NULL , 
                                    `leiras` VARCHAR(512) NOT NULL , 
                                    `harcos_id` INT NOT NULL , 
                                    PRIMARY KEY (`id`),
                                    FOREIGN KEY (`harcos_id`) REFERENCES harcosok(`id`));";

                sql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Connection Error :c");
                return;
            }
        }

        private void disconnect()
        {
            conn.Close();
        }

        private void listBoxHarcosokLoad()
        {
            listBox_harcosok.Items.Clear();
            sql.CommandText = "SELECT `nev` FROM `harcosok`;";

            using (MySqlDataReader dr = sql.ExecuteReader())
            {
                while (dr.Read())
                {
                    listBox_harcosok.Items.Add(dr.GetString("nev"));
                }
            }
        }

        private void comboBoxHasznaloLoad()
        {
            comboBox_hasznalo.Items.Clear();
            sql.CommandText = "SELECT `nev` FROM `harcosok`;";

            using (MySqlDataReader dr = sql.ExecuteReader())
            {
                while (dr.Read())
                {
                    comboBox_hasznalo.Items.Add(dr.GetString("nev"));
                }
            }
        }

        private void button_letrehozas_Click(object sender, EventArgs e)
        {
            connect();

            string nev = textBox_harcosNeve.Text.Trim();
            if (string.IsNullOrEmpty(nev))
            {
                MessageBox.Show("Adja meg a harcos nevét!");
                textBox_harcosNeve.Focus();
                return;
            }
            if (listBox_harcosok.Items.Contains(nev))
            {
                MessageBox.Show("Már van ilyen nevű harcos!");
                textBox_harcosNeve.Focus();
                return;
            }
            else
            {
                sql.CommandText = "INSERT INTO `harcosok`(" +
                                "`id`, `nev`, `letrehozas`) " +
                                "VALUES (null,'" + nev + "', NOW())";

                if (sql.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Successful!");
                    textBox_harcosNeve.Clear();

                }
                else
                {
                    MessageBox.Show("Error!");
                }

                comboBoxHasznaloLoad();
                listBoxHarcosokLoad();
            }
            
            disconnect();
        }

        private void button_hozaad_Click(object sender, EventArgs e)
        {
            connect();

            if (comboBox_hasznalo.SelectedIndex < 0)
            {
                MessageBox.Show("Válasszon felhasználót!");
                comboBox_hasznalo.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(textBox_kepessegNeve.Text.Trim()))
            {
                MessageBox.Show("Adjon meg nevet!");
                textBox_kepessegNeve.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(textBox_leiras.Text.Trim()))
            {
                MessageBox.Show("Adjon meg lerírást!");
                textBox_leiras.Focus();
                return;
            }

            sql.CommandText = @"INSERT INTO `kepessegek`(`nev`, `leiras`, `harcos_id`) 
                VALUES('" + textBox_kepessegNeve.Text.Trim() + "', '" + textBox_leiras.Text.Trim() + "', " +
                "(SELECT id FROM harcosok WHERE nev = '" + comboBox_hasznalo.SelectedItem + "'))";

            if (sql.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Successful!");
                listBoxHarcosokLoad();
                comboBox_hasznalo.SelectedIndex = -1;
                textBox_kepessegNeve.Text = "";
                textBox_leiras.Text = "";
            }
            else
            {
                MessageBox.Show("Error!");
            }

            disconnect();
        }

        private void listBoxKepessegekLoad()
        {
            if (listBox_harcosok.SelectedIndex < 0)
            {
                MessageBox.Show("Válasszon harcost!");
                listBox_harcosok.Focus();
                return;
            }
            textBox_kepessegLeirasa.Text = "";
            listBox_kepessegek.Items.Clear();
            string nev = listBox_harcosok.SelectedItem.ToString();
            sql.CommandText = @"SELECT `nev` FROM `kepessegek` WHERE `harcos_id` = 
                                (SELECT `id` FROM `harcosok` WHERE `nev` LIKE '" + nev + "')";

            using (MySqlDataReader dr = sql.ExecuteReader())
            {
                while (dr.Read())
                {
                    listBox_kepessegek.Items.Add(dr.GetString("nev"));
                }
            }
        }

        private void listBox_harcosok_SelectedIndexChanged(object sender, EventArgs e)
        {
            connect();
            listBoxKepessegekLoad();
            disconnect();
        }

        private void listBox_kepessegek_SelectedIndexChanged(object sender, EventArgs e)
        {
            connect();

            if (listBox_kepessegek.SelectedIndex < 0)
            {
                MessageBox.Show("Válasszon képességet!");
                listBox_kepessegek.Focus();
                return;
            }

            textBox_kepessegLeirasa.Text = "";
            sql.CommandText = @"SELECT `leiras` FROM `kepessegek` WHERE `nev` = '" + listBox_kepessegek.SelectedItem + "';";
            using (MySqlDataReader dr = sql.ExecuteReader())
            {
                while (dr.Read())
                {
                    textBox_kepessegLeirasa.Text = dr.GetString("leiras");
                }
            }

            disconnect();
        }

        private void button_modosit_Click(object sender, EventArgs e)
        {
            connect();

            if (listBox_harcosok.SelectedIndex < 0)
            {
                MessageBox.Show("Válasszon harcost!");
                listBox_harcosok.Focus();
                return;
            }
            else if (listBox_kepessegek.SelectedIndex < 0)
            {
                MessageBox.Show("Válasszon képességet!");
                listBox_kepessegek.Focus();
                return;
            }

            sql.CommandText = @"UPDATE `kepessegek` SET `leiras` = '" + textBox_kepessegLeirasa.Text +
                                "' WHERE `nev` = '" + listBox_kepessegek.SelectedItem + "'";

            if (sql.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Successful!");
                string nev = listBox_harcosok.SelectedItem.ToString();
                sql.CommandText = @"SELECT `nev` FROM `kepessegek` WHERE `harcos_id` = 
                                (SELECT `id` FROM `harcosok` WHERE `nev` LIKE '" + nev + "')";
                sql.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Error!");
            }

            disconnect();
        }

        private void button_torles_Click(object sender, EventArgs e)
        {
            connect();

            if (listBox_harcosok.SelectedIndex < 0)
            {
                MessageBox.Show("Válasszon harcost!");
                listBox_harcosok.Focus();
                return;
            }
            else if (listBox_kepessegek.SelectedIndex < 0)
            {
                MessageBox.Show("Válasszon képességet!");
                listBox_kepessegek.Focus();
                return;
            }

            sql.CommandText = @"DELETE FROM `kepessegek` 
                                WHERE `nev` = '" + listBox_kepessegek.SelectedItem + "'";
            if (sql.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Successful!");
                //string nev = listBox_harcosok.SelectedItem.ToString();
                //sql.CommandText = @"SELECT `nev` FROM `kepessegek` WHERE `harcos_id` = 
                //                (SELECT `id` FROM `harcosok` WHERE `nev` LIKE '" + nev + "')";
                //sql.ExecuteNonQuery();
                listBoxKepessegekLoad();
            }
            else
            {
                MessageBox.Show("Error!");
            }



            disconnect();
        }
    }
}
