using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QRCoder;
using System.Data.OleDb;
using System.IO;

namespace Search_Case
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            comboBoxECC.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //search code

            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/BlackHammer/Desktop/final/Search_Case/serch_db.accdb");
            // OleDbCommand cmd =new OleDbCommand(sql, con);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("select qrcode from search_case where client_name='" + tclient_nm.Text + "' and case_type='" + tcase_type.Text + "' and case_number='" + tcase_num.Text + "' and mobile_number='" + tmob_num.Text + "'", con);

            //OleDbDataAdapter da = new OleDbDataAdapter(cmd.CommandText, con);
            //DataSet ds = new DataSet();
            // DataRow drw;
            OleDbDataReader dr=cmd.ExecuteReader();
            //OleDbDataReader dr=new OleDbDataReader();
            //da.Fill(ds);

            try
            {
                string base64String = dr["qrcode"].ToString();

                byte[] imageBytes = Convert.FromBase64String(base64String);



                // Convert byte[] to Image
                MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
                ms.Write(imageBytes, 0, imageBytes.Length);
                Image image = Image.FromStream(ms, true);
                pictureBox1.BackgroundImage = image;
                //textBox1.Text = dr["client_code"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            }    
                       
        

      

        private void renderQRCode()
        {
            string level = comboBoxECC.SelectedIndex.ToString();
            QRCodeGenerator.ECCLevel ecl = (QRCodeGenerator.ECCLevel)(level == "L" ? 0 : level == "M" ? 1 : level == "Q" ? 2 : 3);
            QRCodeGenerator qg = new QRCodeGenerator();

            string s;

            s = lclient_nm.Text + "=\t" + tclient_nm.Text + "\n\n" + lcase_type.Text + "=\t" + tcase_type.Text + "\n\n" + lcase_num.Text + "=\t" + tcase_num.Text + "\n\n" + lmobile_num.Text + "=\t" + tmob_num.Text + "\n\n";

            QRCodeData qd = qg.CreateQrCode(s, ecl);

            QRCode qc = new QRCode(qd);

            pictureBox1.BackgroundImage = qc.GetGraphic(3, Color.Black, Color.White, getIconBitmap());

        }
        private Bitmap getIconBitmap()
        {
            Bitmap img = null;
            return img;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
