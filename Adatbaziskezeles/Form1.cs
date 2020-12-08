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

        private void disconnect()
        {
            conn.Close();
        }

        private void Form_Adatbaziskezelo_Load(object sender, EventArgs e)
        {
            try
            {
                connect();

                sql.CommandText = @"CREATE TABLE IF NOT EXISTS `harcosok` ( 
                                    `id` INT NOT NULL AUTO_INCREMENT , 
                                    `nev` VARCHAR(255) NOT NULL , 
                                    `letrehozas` DATETIME NOT NULL ,
                                    PRIMARY KEY (`id`), 
                                    UNIQUE (`nev`));";

                sql.ExecuteNonQuery();

                sql.CommandText= @"CREATE TABLE IF NOT EXISTS `kepessegek` ( 
                                    `id` INT NOT NULL AUTO_INCREMENT , 
                                    `nev` VARCHAR(255) NOT NULL , 
                                    `leiras` VARCHAR(512) NOT NULL , 
                                    `harcos_id` INT NOT NULL , 
                                    PRIMARY KEY (`id`),
                                    FOREIGN KEY (`harcos_id`) REFERENCES harcosok(`id`));";

                sql.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message,"Connection Error :c");
                return;
            }

            disconnect();
        }

        private void Form_Adatbaziskezelo_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
