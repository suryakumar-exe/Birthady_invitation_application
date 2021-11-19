using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Ann_Birthday
{
    public partial class Form1 : Form
    {
        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog() { Filter="Excel Workbook|*.xlsx",Multiselect=false})
            {
                if(ofd.ShowDialog()==DialogResult.OK)
                {

                    //Cursor.Current = Cursor.WaitCursor;
                    Cursor.Current = Cursors.WaitCursor;
                    DataTable dt = new DataTable();
                    using(XLWorkbook workbook = new XLWorkbook(ofd.FileName) )
                    {
                        bool isFirstRow = true;
                        var rows = workbook.Worksheet(1).RowsUsed();
                        foreach(var row in rows)
                        {
                            if (isFirstRow)
                            {
                                foreach (IXLCell cell in row.Cells())
                                    dt.Columns.Add(cell.Value.ToString());
                                isFirstRow = false;
                            }
                            else
                            {
                                dt.Rows.Add();
                                int i = 0;
                                foreach (IXLCell cell in row.Cells())
                                    dt.Rows[dt.Rows.Count - 1][i++] = cell.Value.ToString();

                            }
                        }
                        dataGridView1.DataSource = dt.DefaultView;
                       
                        lbl_record.Text = $"Total Records :{(dataGridView1.RowCount)-1}";
                        Cursor.Current = Cursors.Default;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Birthday")
            {
                try
                {

                    DataView dv = dataGridView1.DataSource as DataView;
                    if (dv != null)
                    {

                        //dv.RowFilter = txtSearch.Text;
                        String date = dateTimePicker1.Text.Substring(0, 5);
                        dv.RowFilter = "Birthday like'" + date + "%'";
                        lbl_record.Text = $"Total Records :{(dataGridView1.RowCount) - 1}";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(comboBox1.Text == "Anniversaryday")
            {
                try
                {

                    DataView dv = dataGridView1.DataSource as DataView;
                    if (dv != null)
                    {

                        //dv.RowFilter = txtSearch.Text;
                        String date = dateTimePicker1.Text.Substring(0,5);
                        dv.RowFilter = "Anniversaryday like'" + date + "%'";
                        lbl_record.Text = $"Total Records :{(dataGridView1.RowCount) - 1}";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnSearch.PerformClick();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void send_Click(object sender, EventArgs e)
        {

            for (int r = 0; r < (dataGridView1.RowCount - 1); r++)
            {
                login = new NetworkCredential("suryafandasydream11@gmail.com", "Surya@123");
                client = new SmtpClient("smtp.gmail.com");
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;

                client.Credentials = login;

                msg = new MailMessage { From = new MailAddress("suryafandasydream11@gmail.com", "Surya", Encoding.UTF8) };

                String addr = Convert.ToString(dataGridView1.Rows[r].Cells["email"].Value);
                //MessageBox.Show(addr);
                msg.To.Add(new MailAddress(addr));
                if (!string.IsNullOrEmpty(""))
                {
                    msg.To.Add(new MailAddress(""));
                }
                msg.Subject = "BIRTHDAY MAIL";
                msg.Body = "Wishes you all NORDEX TESTING :)";
                msg.BodyEncoding = Encoding.UTF8;
                msg.IsBodyHtml = true;
                msg.Priority = MailPriority.Normal;

                msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                string userstate = "Sending...";
                client.SendAsync(msg, userstate);
               //MessageBox.Show((dataGridView1.RowCount - 1));
                if (r.Equals(dataGridView1.RowCount - 2)) {
                    client.SendCompleted += new SendCompletedEventHandler(SendCompleteCallback);
                }
               
            }




        }
        private static void SendCompleteCallback(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
                MessageBox.Show(string.Format("{0} send cancelled.", e.UserState), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (e.Error != null)
                MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Your message sended successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbl_record_Click(object sender, EventArgs e)
         {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
