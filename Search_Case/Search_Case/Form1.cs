using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QRCoder;
using System.Data.OleDb;
using System.IO;



namespace Search_Case
{
    public partial class Form1 : Form
    {
        Bitmap image;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxECC.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string ss= renderQRCode();
        }
        private string renderQRCode()
        {
            string level = comboBoxECC.SelectedIndex.ToString();
            QRCodeGenerator.ECCLevel ecl = (QRCodeGenerator.ECCLevel)(level == "L" ? 0 : level == "M" ? 1 : level == "Q" ? 2 : 3);
            QRCodeGenerator qg = new QRCodeGenerator();
            
            string s;

            s = clnm.Text + "=\t"+ client_name.Text + "\n\n" + opnm.Text + "=\t" + opposite.Text + "\n\n" + C.Text + "=\t" + client_code.Text + "\n\n" + ctyp.Text + "=\t" +case_type.Text + "\n\n" + cnum.Text + "=\t" + case_number.Text + "\n\n" + client_mobile.Text + "=\t" + client_mob.Text + "\n\n" + cadv.Text + "\t" + advcode.Text + "\n\n" + year.Text + "=\t" + case_year.Text;

            QRCodeData qd = qg.CreateQrCode(s, ecl);

            QRCode qc = new QRCode(qd);

            pictureBox1.BackgroundImage = qc.GetGraphic(3, Color.Black, Color.White, getIconBitmap());
            image = qc.GetGraphic(3, Color.Black, Color.White, getIconBitmap());
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                byte[] imageBytes = ms.ToArray();

                // Convert byte[] to Base64 String

                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

    
        private Bitmap getIconBitmap()
        {
            Bitmap img = null;
            return img;
        }

        private void cmobno_TextChanged(object sender, EventArgs e)
        {
            
            }

        private void button1_Click_1(object sender, EventArgs e)

        {
          
           // String sql="insert into search_case (case_id,client_name,client_code,case_type,case_number,advocate_code,opposite_name,year,mobile_number,qr-code) values (1,'"+client_name.Text +"','"+client_code.Text+"','"+case_type.Text+"','"+case_number.Text+"','"+advcode.Text+"','"+opposite.Text+"','"+year.Text+"','"+client_mobile.Text+"','qrcode' );";
           OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/BlackHammer/Desktop/final/Search_Case/serch_db.accdb");
           // OleDbCommand cmd =new OleDbCommand(sql, con);
           OleDbCommand cmd = new OleDbCommand("insert into search_case (client_name,client_code,case_type,case_number,advocate_code,mobile_number,opposite_name,case_year,qrcode) values('" + client_name.Text + "','" + client_code.Text + "','" + case_type.Text + "','" + case_number.Text + "','" + advcode.Text + "','" + client_mob.Text + "','" + opposite.Text + "','" + case_year.Text + "','"+renderQRCode()+"')", con);

                con.Open();
            try{
                int i = cmd.ExecuteNonQuery(); ;
                     
                     if (i == 1){MessageBox.Show("Success");

                        }
                      else{MessageBox.Show("Invalid User Name or Password");

                          }

                 }
            catch (Exception ex){MessageBox.Show(ex.Message);

                }
           finally{
                con.Close();
            }
        }
  
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        
        }

        private void client_TextChanged(object sender, EventArgs e)
        {

        }

        private void ccod_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Search s1 = new Search();
            s1.Show();
        }
        }

        
    }

