using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace _2001210642_TuanHuy_29_11_2023
{
    public partial class Form1 : Form
    {
        KetNoi kn = new KetNoi();
        SqlConnection connsql;
        public Form1()
        {
            InitializeComponent();
            connsql = kn.connect;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            try
            {
                if (connsql.State == ConnectionState.Closed)
                {
                    connsql.Open();
                }
                string Table="SinhVien";
                string insertString = "insert into SinhVien(hoTen) values('"+txtHoTen.Text+ "')";
                
                //Command
                SqlCommand cmd = new SqlCommand(insertString, connsql);
                cmd.ExecuteNonQuery();

                //Kiem tra ket noi truoc khi dong
                if (connsql.State == ConnectionState.Open)
                {
                    connsql.Close();
                }
                MessageBox.Show("Thanh cong");
            }
            catch (Exception ex)
            {
               
                MessageBox.Show("That Bai");
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                if (connsql.State == ConnectionState.Closed)
                {
                    connsql.Open();
                }
                string Table = "SinhVien";
                string search = "select maSV, hoTen from SinhVien where SinhVien.maSV ='" + txtMaSV.Text + "' and SinhVien.hoTen ='" + txtHoTen.Text+"'";
                //Command
                SqlCommand cmd = new SqlCommand(search, connsql);
                SqlDataReader src = cmd.ExecuteReader();
                src.Read();
                listBox1.Items.Add("Ma Sinh Vien: " + src["maSV"].ToString() + " " + "Ho ten:" + src["hoTen"].ToString());
                src.Close();
                //Kiem tra ket noi truoc khi dong
                if (connsql.State == ConnectionState.Open)
                {
                    connsql.Close();
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("That Bai");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (connsql.State == ConnectionState.Closed)
                {
                    connsql.Open();
                }
                string Table = "SinhVien";
                string delete = "delete SinhVien where SinhVien.maSV = '"+txtMaSV.Text+"'";
                //Command
                SqlCommand cmd = new SqlCommand(delete, connsql);
                cmd.ExecuteNonQuery();
                
                //Kiem tra ket noi truoc khi dong
                if (connsql.State == ConnectionState.Open)
                {
                    connsql.Close();
                }
                MessageBox.Show("Da Xoa");
            }
            catch (Exception ex)
            {

                MessageBox.Show("That Bai");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
             try
            {
                if (connsql.State == ConnectionState.Closed)
                {
                    connsql.Open();
                }
                string search = "select maSV, hoTen from SinhVien where SinhVien.maSV ='" + txtMaSV.Text + "'";
                SqlCommand searchcmd = new SqlCommand(search, connsql);
                SqlDataReader read = searchcmd.ExecuteReader();
                read.Read();

                string Table = "SinhVien";
                string update="";
                 using(Edit edit = new Edit())
                 {
                     edit.txtMaSV.Text = read["maSV"].ToString();
                     edit.txtHoTen.Text = read["hoTen"].ToString();
                     if(edit.ShowDialog() == DialogResult.OK)
                     {
                         
                         update += "update SinhVien set hoTen ='" + edit.txtHoTen.Text + "' where SinhVien.maSV = '" + edit.txtMaSV.Text + "'";
                     }
                 }
                 read.Close();
                //Command
                SqlCommand cmd = new SqlCommand(update, connsql);
                cmd.ExecuteNonQuery();
                
                //Kiem tra ket noi truoc khi dong
                if (connsql.State == ConnectionState.Open)
                {
                    connsql.Close();
                }
                MessageBox.Show("Da Chinh sua thanh cong");
            }
            catch (Exception ex)
            {

                MessageBox.Show("That Bai");
            }
        }

      
    }
}
