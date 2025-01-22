using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IepfCAformat46
{
    public partial class iepfcacdsl46 : Form
    {
        public iepfcacdsl46()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                SqlConnection con = new SqlConnection("Data Source=192.168.0.138,1433;Initial Catalog=VCCIPL;User ID=sa;Password=Password123$;Integrated Security = true;");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Iepfcacdsl46hd " +
                    "(Record_Id,Rta_Id,Rtaint_Refno,Isin,Ca_Type,Bapr_Dt,Exec_Dt,Totdrqty," +
                    "Totdrqty_Lin,Filler01,Totcrqty,Totcrqty_Lin,Totdetrec,Filler02," +
                    "Cin_Bcin_No,Email_Co,Fywdivrel,Totnomamt_Shr,MasterUniqNo) " +


                    "values(@Record_Id,@Rta_Id,@Rtaint_Refno,@Isin,@Ca_Type,@Bapr_Dt,@Exec_Dt,@Totdrqty," +
                    "@Totdrqty_Lin,@Filler01,@Totcrqty,@Totcrqty_Lin,@Totdetrec,@Filler02," +
                    "@Cin_Bcin_No,@Email_Co,@Fywdivrel,@Totnomamt_Shr,@MasterUniqNo)", con);
                cmd.Parameters.AddWithValue("@Record_Id", txtRecid.Text);
                cmd.Parameters.AddWithValue("@Rta_Id", txtRtaid.Text);
                cmd.Parameters.AddWithValue("@Rtaint_Refno", txtIntrefno.Text);
                cmd.Parameters.AddWithValue("@Isin", txtIsin.Text);
                cmd.Parameters.AddWithValue("@Ca_Type", txtCaType01.Text);
                cmd.Parameters.AddWithValue("@Bapr_Dt", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@Exec_Dt", dateTimePicker2.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@Totdrqty", txtDrqty.Text);
                cmd.Parameters.AddWithValue("@Totdrqty_Lin", txtTotaldrqtyli.Text);
                cmd.Parameters.AddWithValue("@Filler01", txtFiller01.Text);
                cmd.Parameters.AddWithValue("@Totcrqty", txtTotcrqty.Text);
                cmd.Parameters.AddWithValue("@Totcrqty_Lin", txtCrqtylin.Text);
                cmd.Parameters.AddWithValue("@Totdetrec", txtTotdedrec.Text);
                cmd.Parameters.AddWithValue("@Filler02", txtFiller2.Text);
                cmd.Parameters.AddWithValue("@Cin_Bcin_No", txtCinBcinNo.Text);
                cmd.Parameters.AddWithValue("@Email_Co", txtCompanyEmailid.Text);
                cmd.Parameters.AddWithValue("@Fywdivrel", txtFyAmtRel.Text);
                cmd.Parameters.AddWithValue("@Totnomamt_Shr", txtTotNominalAmtShr.Text);
                cmd.Parameters.AddWithValue("@MasterUniqNo", txtMun01.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data has saved in Iepfcacdsl46hd Database");
        }

        private void btnView01_Click(object sender, EventArgs e)
        {
               //< add name = "ConnectionString" connectionString = "Data Source=192.168.0.82,1433;Network Library=DBMSSOCN;Initial Catalog=NewsAdvt;User ID=sa;Password=sql;" providerName = "System.Data.SqlClient" />
                SqlConnection con = new SqlConnection("Data Source=192.168.0.138,1433;Initial Catalog=VCCIPL;User ID=sa;Password=Password123$;Integrated Security = true;");
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Iepfcacdsl46hd", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnSave02_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=192.168.0.138,1433;Initial Catalog=VCCIPL;User ID=sa;Password=Password123$;Integrated Security = true;");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Iepfcacdsl46dt " +
                "(Record_Id,Rec_Lineno,Credit_Boid,Debit_Dpid,Debit_Clid,Dr_Qty,Dr_Qty_Lin,Dr_Lin_Code," +
                "Dr_Lin_Exp_Dt,Filler01,Cr_Qty,Cr_Qty_Lin,Cr_Lin_Code,Cr_Lin_Exp_Dt,Name1,Pan1,Name2,Pan2," +
                "Name3,Pan3,Gur_Name,Nom_Name,Fh_Name,Birth_Dt,Acc_type_Desc," +
                "Acc_stype_Desc,Occ,Cadd1,Cadd2,Cadd3,Cadd4,Caddpin,Padd1,Padd2,Padd3,Padd4,Paddpin," +
                "Tel1,Fax_No,Email_Id,Uid1,Uid2,Uid3,Filler09,MasterUniqNo) " +
                "values(@Record_Id,@Rec_Lineno,@Credit_Boid,@Debit_Dpid,@Debit_Clid,@Dr_Qty,@Dr_Qty_Lin,@Dr_Lin_Code," +
                "@Dr_Lin_Exp_Dt,@filler01,@Cr_Qty,@Cr_Qty_Lin,@Cr_Lin_Code,@Cr_Lin_Exp_Dt,@Name1,@Pan1,@Name2,@Pan2," +
                "@Name3,@Pan3,@Gur_Name,@Nom_Name,@Fh_Name,@Birth_Dt,@Acc_type_Desc," +
                "@Acc_stype_Desc,@Occ,@Cadd1,@Cadd2,@Cadd3,@Cadd4,@Caddpin,@Padd1,@Padd2,@Padd3,@Padd4," +
                "@Paddpin,@Tel1,@Fax_No,@Email_Id,@Uid1,@Uid2,@Uid3,@Filler09,@MasterUniqNo)", con);
            cmd.Parameters.AddWithValue("@Record_Id", txtRecid02.Text);
            cmd.Parameters.AddWithValue("@Rec_Lineno", txtDetrec02.Text);
            cmd.Parameters.AddWithValue("@Credit_Boid", txtCrBoid.Text);
            cmd.Parameters.AddWithValue("@Debit_Dpid", txtDpid.Text);
            cmd.Parameters.AddWithValue("@Debit_Clid", txtDrClid.Text);
            cmd.Parameters.AddWithValue("@Dr_Qty", txtDebitQty.Text);
            cmd.Parameters.AddWithValue("@Dr_Qty_Lin", txtDrlinqty.Text);
            var drlincode = comboBox9.Text.Substring(0, 2);
            cmd.Parameters.AddWithValue("@Dr_Lin_Code", drlincode);
            cmd.Parameters.AddWithValue("@Dr_Lin_Exp_Dt", dateTimePicker3.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@Filler01", txtFiller0201.Text);
            cmd.Parameters.AddWithValue("@Cr_Qty", txtCrQty.Text);
            cmd.Parameters.AddWithValue("@Cr_Qty_Lin", txtCrlinqty.Text);
            var crlincode = comboBox1.Text.Substring(0, 2);
            cmd.Parameters.AddWithValue("@Cr_Lin_Code", crlincode);
            cmd.Parameters.AddWithValue("@Cr_Lin_Exp_Dt", dateTimePicker4.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@Name1", txtName1.Text);
            cmd.Parameters.AddWithValue("@Pan1",  txtPan1.Text);
            cmd.Parameters.AddWithValue("@Name2", txtName2.Text);
            cmd.Parameters.AddWithValue("@Pan2", txtPan2.Text);
            cmd.Parameters.AddWithValue("@Name3", txtName3.Text);
            cmd.Parameters.AddWithValue("@Pan3", txtPan3.Text);
            cmd.Parameters.AddWithValue("@Gur_Name", txtGurName.Text);
            cmd.Parameters.AddWithValue("@Nom_Name", txtNomName.Text);
            cmd.Parameters.AddWithValue("@Fh_Name", txtFhName.Text);
            cmd.Parameters.AddWithValue("@Birth_Dt", dateTimePicker6.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@Acc_type_Desc", txtAcctypedesc.Text);
            cmd.Parameters.AddWithValue("@Acc_stype_Desc", txtAccstypedesc.Text);
            cmd.Parameters.AddWithValue("@Occ", txtOcc.Text);
            //  "Tel1,Fax_No,Email_Id,Uid1,Uid2,Uid3,Filler09
            cmd.Parameters.AddWithValue("@Cadd1",   txtCadd1.Text);
            cmd.Parameters.AddWithValue("@Cadd2",   txtCadd2.Text);
            cmd.Parameters.AddWithValue("@Cadd3",   txtCadd3.Text);
            cmd.Parameters.AddWithValue("@Cadd4",   txtCadd4.Text);
            cmd.Parameters.AddWithValue("@Caddpin", txtCaddpin.Text);
            cmd.Parameters.AddWithValue("@Padd1",   txtPadd1.Text);
            cmd.Parameters.AddWithValue("@Padd2",   txtPadd2.Text);
            cmd.Parameters.AddWithValue("@Padd3",   txtPadd3.Text);
            cmd.Parameters.AddWithValue("@Padd4",   txtPadd4.Text);
            cmd.Parameters.AddWithValue("@Paddpin", txtPaddpin.Text);
            cmd.Parameters.AddWithValue("@Tel1",    txtTel1.Text);
            cmd.Parameters.AddWithValue("@Fax_No",  txtFaxno.Text);
            cmd.Parameters.AddWithValue("@Email_Id",txtEmailid.Text);
            cmd.Parameters.AddWithValue("@Uid1",    txtUid1.Text);
            cmd.Parameters.AddWithValue("@Uid2",    txtUid2.Text);
            cmd.Parameters.AddWithValue("@Uid3",    txtUid3.Text);
            cmd.Parameters.AddWithValue("@Filler09",txtFiller09.Text);
            cmd.Parameters.AddWithValue("@MasterUniqNo", txtMUN02.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data has saved in Iepfcacdsl46dt Database");

        }

        private void btnView02_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=192.168.0.138,1433;Initial Catalog=VCCIPL;User ID=sa;Password=Password123$;Integrated Security = true;");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Iepfcacdsl46dt", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

    }
}

/*
Record_Id,Rta_Id,Rtaint_Refno,Isin,Ca_Type,Bapr_Dt,Exec_Dt,Totdrqty,Totdrqty_Lin,Filler01,Totcrqty,Totcrqty_Lin,Totdetrec,Filler02,Cin_Bcin_No,Email_Co,Fywdivrel,Totnomamt_Shr,Processedflag,MasterUniqNo,
--
Record_Id,@Rta_Id,@Rtaint_Refno,@Isin,@Ca_Type,@Bapr_Dt,@Exec_Dt,@Totdrqty,@Totdrqty_Lin,@Filler01,@Totcrqty,@Totcrqty_Lin,@Totdetrec,@Filler02,@Cin_Bcin_No,@Email_Co,@Fywdivrel,@Totnomamt_Shr,@Processedflag,@MasterUniqNo

*/

/*
Record_Id,Rec_Lineno,Credit_Boid,Debit_Dpid,Debit_Clid,Dr_Qty,Dr_Qty_Lin,Dr_Lin_Code,Dr_Lin_Exp_Dt,Filler01,Cr_Qty,Cr_Qty_Lin,Cr_Lin_Code,Cr_Lin_Exp_Dt,Name1,Pan1,Name2,Pan2,Name3,Pan3,Gur_Name,Filler02,Nom_Name,Filler03,Fh_Name,Filler04,Birth_Dt,Acc_type_Desc,Acc_stype_Desc,Occ,Filler05,Cadd1,Cadd2,Cadd3,Cadd4,Caddpin,Padd1,Padd2,Padd3,Padd4,Paddpin,Tel1,Filler06,Fax_No,Email_Id,Uid1,Uid2,Uid3,Filler07,Filler08,Filler09,Processedflag,MasterUniqNo,

Record_Id,@Rec_Lineno,@Credit_Boid,@Debit_Dpid,@Debit_Clid,@Dr_Qty,@Dr_Qty_Lin,@Dr_Lin_Code,@Dr_Lin_Exp_Dt,@Filler01,@Cr_Qty,@Cr_Qty_Lin,@Cr_Lin_Code,@Cr_Lin_Exp_Dt,@Name1,@Pan1,@Name2,@Pan2,@Name3,@Pan3,@Gur_Name,@Filler02,@Nom_Name,@Filler03,@Fh_Name,@Filler04,@Birth_Dt,@Acc_type_Desc,@Acc_stype_Desc,@Occ,@Filler05,@Cadd1,@Cadd2,@Cadd3,@Cadd4,@Caddpin,@Padd1,@Padd2,@Padd3,@Padd4,@Paddpin,@Tel1,@Filler06,@Fax_No,@Email_Id,@Uid1,@Uid2,@Uid3,@Filler07,@Filler08,@Filler09,@Processedflag,@MasterUniqNo,@

*/