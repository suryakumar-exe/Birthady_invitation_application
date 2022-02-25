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
using System.IO;
using Outlook = Microsoft.Office.Interop.Outlook;
using DGVPrinterHelper;
using Tulpep.NotificationWindow;
using Excel = Microsoft.Office.Interop.Excel;
using System.Web.UI.WebControls;
using Unipluss.Sign.ExternalContract.Entities;
using static DGVPrinterHelper.DGVPrinter;
using System.Diagnostics;
using System.Threading;

namespace Ann_Birthday
{
    public partial class Birthday : Form
    {

        String file_name = @"D:\Wishes\birthday_anniversary2.xlsx";

        string Anni_imageSrc = "";
        string imageSrc = "";

        int birthday_count = 0;
        int aniver_count = 0;
        Outlook._Application _app;

        string bday1, bday2, bday3;
        string aday1, aday2, aday3;
        public Birthday()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx", Multiselect = false })

            {

                if (ofd.ShowDialog() == DialogResult.OK)
                {

                    //Cursor.Current = Cursor.WaitCursor;
                    Cursor.Current = Cursors.WaitCursor;
                    DataTable dt = new DataTable();
                    file_name = ofd.FileName;
                    using (XLWorkbook workbook = new XLWorkbook(ofd.FileName))
                    {
                        bool isFirstRow = true;
                        var rows = workbook.Worksheet(1).RowsUsed();
                        foreach (var row in rows)
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
                        //dataGridView2.DataSource = dt.DefaultView;
                        label12.Text = $"Total Records :{(dataGridView1.RowCount) - 1}";
                        Cursor.Current = Cursors.Default;
                        //  dt2.Columns.Add("name") = 


                    }
                }

                Cursor.Current = Cursors.WaitCursor;
                DataTable dt1 = new DataTable();

                using (XLWorkbook workbook = new XLWorkbook(ofd.FileName))
                {
                    bool isFirstRow = true;
                    var rows = workbook.Worksheet(1).RowsUsed();

                    foreach (var row in rows)
                    {
                        if (isFirstRow)
                        {
                            foreach (IXLCell cell in row.Cells())
                                dt1.Columns.Add(cell.Value.ToString());
                            isFirstRow = false;
                        }
                        else
                        {
                            dt1.Rows.Add();
                            int i = 0;
                            foreach (IXLCell cell in row.Cells())
                                dt1.Rows[dt1.Rows.Count - 1][i++] = cell.Value.ToString();

                        }
                    }

                    dataGridView2.DataSource = dt1.DefaultView;


                    /* lbl_record.Text = $"Total Records :{(dataGridView1.RowCount) - 1}";*/
                    Cursor.Current = Cursors.Default;
                    //}
                }
                //}
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectday.Text == "Birthday")
            {
                try
                {
                    
                    DataView dv = dataGridView1.DataSource as DataView;
                    var main_bconent = new List<string>();
                    bday1 = "May this happy day in your life be the beginning of a year filled  with joy, good health and great success. Enjoy it to the fullest because today is your day 1. ";
                    main_bconent.Add(bday1);
                    bday2 = "May this happy day,May the coming year of your life bring loads of happiness and wonderful memories to cherish. Warm greetings on your birthday! ";
                    main_bconent.Add(bday2);
                    bday3 = "Here's wishing a very Happy Birthday to a wonderful colleague and a great friend! May God bless you with health, success and happiness!";
                    main_bconent.Add(bday3);
                    Random rn = new Random();
                    int f_content = rn.Next(0, 3);
                    if (dv != null)
                    {

                        //dv.RowFilter = txtSearch.Text;
                        String date = datepicker.Text.Substring(0, 5);
                        dv.RowFilter = "DOB like'" + date + "%'";

                        if (((dataGridView1.RowCount) - 1) > 0)
                        {
                            // MessageBox.Show("NO DATA FOUND");
                            label12.Text = $"Total Records :{(dataGridView1.RowCount) - 1}";
                            txt_subject.Text = "BIRTHDAY MAIL";
                            rtb_wishes_header.Text = main_bconent[f_content];
                            rtb_wishes_footer.Text = "Happy Birthday & have a great year ahead!";
                        }
                        else
                        {
                            MessageBox.Show("NO BIRTHDAY FOUND");
                            Cursor.Current = Cursors.WaitCursor;
                            DataTable dt = new DataTable();
                            using (XLWorkbook workbook = new XLWorkbook(file_name))
                            {
                                bool isFirstRow = true;
                                var rows = workbook.Worksheet(1).RowsUsed();
                                foreach (var row in rows)
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

                                label12.Text = $"Total Records :{(dataGridView1.RowCount) - 1}";
                                Cursor.Current = Cursors.Default;

                            }
                        }
                    }
                    if (dv == null)
                    {
                        MessageBox.Show("NO DATA FOUND");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (selectday.Text == "Anniversaryday")
            {
                try
                {

                    DataView dv = dataGridView1.DataSource as DataView;
                    if (dv != null)
                    {
                        var main_aconent = new List<string>();
                        aday1 = "We extend our heartiest congratulations to you on setting a milestone in the enjoyable journey of your professional life .We wish you a Very Happy Work Anniversary and looking for many more achievements in the upcoming years too!";
                        main_aconent.Add(aday1);
                        aday2 = "This is to remind you that you have come a long way, and your contributions have continued to inspire us. I wish you a very Happy Work Anniversary!";
                        main_aconent.Add(aday2);
                        aday3 = "We extend our heartiest congratulations to you on setting yet another milestone in the journey of your professional life. IWewish you a very happy work anniversary!";
                        main_aconent.Add(aday3);
                        Random rn1 = new Random();
                        int a_content = rn1.Next(0, 3);
                        //dv.RowFilter = txtSearch.Text;
                        String date = datepicker.Text.Substring(0, 5);
                        dv.RowFilter = "DOJ like'" + date + "%'";
                        if (((dataGridView1.RowCount) - 1) > 0)
                        {
                            label12.Text = $"Total Records :{(dataGridView1.RowCount) - 1}";
                            txt_subject.Text = "WORK ANNIVERSARY MAIL";
                            rtb_wishes_header.Text = main_aconent[a_content];
                            // rtb_wishes_header.Text = "On this blissful and charming day of your Corporate anniversary.. may you continue the journey of success with pride! ...Congratulations on your corporate anniversary!";
                            rtb_wishes_footer.Text = "Happy Anniversary day & have a great year ahead!";


                        }
                        else
                        {
                            MessageBox.Show("NO ANNIVERSARY FOUND");
                            Cursor.Current = Cursors.WaitCursor;
                            DataTable dt = new DataTable();
                            using (XLWorkbook workbook = new XLWorkbook(file_name))
                            {
                                bool isFirstRow = true;
                                var rows = workbook.Worksheet(1).RowsUsed();
                                foreach (var row in rows)
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

                                label12.Text = $"Total Records :{(dataGridView1.RowCount) - 1}";
                                Cursor.Current = Cursors.Default;

                            }
                        }
                    }
                    if (dv == null)
                    {
                        MessageBox.Show("NO DATA FOUND");
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
                btn_Search.PerformClick();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            datepicker.Format = DateTimePickerFormat.Custom;
            datepicker.CustomFormat = "MM/dd/yyyy";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            lbl_month.BackColor = System.Drawing.Color.Transparent;
            lbl_topic.BackColor = System.Drawing.Color.Transparent;
            ll_attach.BackColor = System.Drawing.Color.Transparent;
            lbl_search.BackColor = System.Drawing.Color.Transparent;
            lbl_content.BackColor = System.Drawing.Color.Transparent;
            lbl_color.BackColor = System.Drawing.Color.Transparent;
            lbl_font.BackColor = System.Drawing.Color.Transparent;
            lbl_subject.BackColor = System.Drawing.Color.Transparent;
            lbl_header.BackColor = System.Drawing.Color.Transparent;
            lbl_footer.BackColor = System.Drawing.Color.Transparent;
            lbl_attach.BackColor = System.Drawing.Color.Transparent;
            //label11.Visible = true;
            var Font_Arr = new List<string>();
            Font_Arr.Add("Garamond");
            Font_Arr.Add("Monaco");
            Font_Arr.Add("cursive");
            Font_Arr.Add("Courier");
            Font_Arr.Add("Times");
            var Color_Arr = new List<string>();
            Color_Arr.Add("darkviolet");
            Color_Arr.Add("black");
            Color_Arr.Add("dodgerblue");
            Color_Arr.Add("orangered");
            Color_Arr.Add("darkslategray");
            var Content_Arr = new List<string>();
            Content_Arr.Add("Content 1");
            Content_Arr.Add("Content 2");
            Content_Arr.Add("Content 3");



            DateTime dtime = DateTime.Now;
            int present_month = dtime.Month;
            if (present_month < 10)
            {
                comboBox_month.SelectedItem = "0" + present_month.ToString();
            }
            else
            {
                comboBox_month.SelectedItem = present_month.ToString();
            }






            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"D:\Wishes\birthday_anniversary2.xlsx");
            Excel._Worksheet xlWorksheet = (Excel._Worksheet)xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;
            int rowCount = xlRange.SpecialCells(Excel.XlCellType.xlCellTypeVisible).Rows.Count;
            int colCount = xlRange.Columns.Count;



            DateTime aDate = DateTime.Now;
            string sub_date = aDate.ToString("MM/dd/yyyy");
            datepicker.Text = sub_date;
            string system_date = sub_date.Substring(0, 5);


            foreach (Excel.Range row in xlRange.SpecialCells(Excel.XlCellType.xlCellTypeVisible).Rows)
            {


                Excel.Range DIE = (Excel.Range)row.Cells[1, 1];
                Excel.Range ANI = (Excel.Range)row.Cells[1, 2];

                if (((DIE.Text != "") && (ANI.Text != "")) && ((DIE.Text != null) && (ANI.Text != null)))
                {
                    string s = DIE.Text;
                    string ani = ANI.Text;
                    if (s == "DOB")
                    {
                        continue;
                    }
                    else
                    {
                        string birthday_date = s.Substring(0, 5);
                        string aniverary_day = ani.Substring(0, 5);
                        if (system_date == birthday_date)
                        {
                            birthday_count += 1;
                        }
                        if (system_date == aniverary_day)
                        {
                            aniver_count += 1;
                        }

                    }

                }
                else
                {
                    break;
                }

            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            xlWorkbook.Close(false);
            xlApp.Quit();

            PopupNotifier popup = new PopupNotifier();
            popup.TitleText = "Notification";
            popup.ContentText = "Birthday - " + birthday_count.ToString() + " and Anniversary Day - " + aniver_count.ToString();
            popup.Popup();





            Cursor.Current = Cursors.WaitCursor;
            DataTable dt = new DataTable();

            using (XLWorkbook workbook = new XLWorkbook(file_name))
            {
                bool isFirstRow = true;
                var rows = workbook.Worksheet(1).RowsUsed();
                foreach (var row in rows)
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
                        {
                            dt.Rows[dt.Rows.Count - 1][i++] = cell.Value.ToString();

                        }

                    }
                }
                dataGridView1.DataSource = dt.DefaultView;

                label12.Text = $"Total Records :{(dataGridView1.RowCount) - 1}";
                Cursor.Current = Cursors.Default;

            }
            Cursor.Current = Cursors.WaitCursor;
            DataTable dt1 = new DataTable();

            using (XLWorkbook workbook = new XLWorkbook(file_name))
            {
                bool isFirstRow = true;
                var rows = workbook.Worksheet(1).RowsUsed();

                foreach (var row in rows)
                {
                    if (isFirstRow)
                    {
                        foreach (IXLCell cell in row.Cells())
                            dt1.Columns.Add(cell.Value.ToString());
                        isFirstRow = false;
                    }
                    else
                    {
                        dt1.Rows.Add();
                        int i = 0;
                        foreach (IXLCell cell in row.Cells())
                            dt1.Rows[dt1.Rows.Count - 1][i++] = cell.Value.ToString();

                    }
                }

                dataGridView2.DataSource = dt1.DefaultView;


                /* lbl_record.Text = $"Total Records :{(dataGridView1.RowCount) - 1}";*/
                Cursor.Current = Cursors.Default;
                //}
            }

            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    if (birthday_count > 0)
                    {

                        Random rnd = new Random();
                        int font = rnd.Next(0, 5);
                        comboBox_Font.SelectedItem = Font_Arr[font];

                        int color = rnd.Next(0, 5);
                        comboBox_color.SelectedItem = Color_Arr[color];

                        int content = rnd.Next(0, 3);
                        combobox_content.SelectedItem = Content_Arr[content];

                        Random rg = new Random();
                        int birth_image = rg.Next(0, 3);


                        var Birth_Arr = new List<string>();
                        string ad = @"D:\Wishes\Birthday Images\1 birthday.jpg";
                        imageSrc = ad;
                        Birth_Arr.Add(ad);
                        string ad1 = @"D:\Wishes\Birthday Images\2 birthday.jpg";
                        imageSrc = ad1;
                        Birth_Arr.Add(ad1);
                        string ad3 = @"D:\Wishes\Birthday Images\3 birthday.jpg";
                        imageSrc = ad3;
                        Birth_Arr.Add(ad3);
                        imageSrc = Birth_Arr[birth_image];
                        btn_Search.PerformClick();
                        btn_send.PerformClick();

                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    if (aniver_count > 0)
                    {
                        Random rnd = new Random();
                        int font = rnd.Next(0, 5);
                        comboBox_Font.SelectedItem = Font_Arr[font];

                        int color = rnd.Next(0, 5);
                        comboBox_color.SelectedItem = Color_Arr[color];

                        int content = rnd.Next(0, 3);
                        combobox_content.SelectedItem = Content_Arr[content];

                        lbl_attach.Text = Anni_imageSrc;
                        selectday.Text = "Anniversaryday";
                        btn_Search.PerformClick();
                        btn_send.PerformClick();
                        
                        Thread.Sleep(30000);
                        _app.Quit();
                        this.Close();
                    }
                    else
                    { 
                 
                        this.Close();

                    }
                }
            }

        }


        private void label1_Click(object sender, EventArgs e)
        {

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


            //Cursor.Current = Cursor.WaitCursor;
            Cursor.Current = Cursors.WaitCursor;
            DataTable dt = new DataTable();
            using (XLWorkbook workbook = new XLWorkbook(file_name))
            {
                bool isFirstRow = true;
                var rows = workbook.Worksheet(1).RowsUsed();
                foreach (var row in rows)
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

                label12.Text = $"Total Records :{(dataGridView1.RowCount) - 1}";
                Cursor.Current = Cursors.Default;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selectday.Text == "Birthday")
            {

                try
                {
                    string birthdayForOne = "";
                    _app = new Outlook.Application();
                    Outlook.MailItem mail = (Outlook.MailItem)_app.CreateItem(Outlook.OlItemType.olMailItem);


                    //Subject
                    mail.Subject = txt_subject.Text;
                    //Body
                    string mailbody = "";
                    if (birthday_count == 1)
                    {
                        for (int r = 0; r < (dataGridView1.RowCount - 1); r++)
                        {

                            String name = Convert.ToString(dataGridView1.Rows[r].Cells["Name"].Value);
                            birthdayForOne = name;
                            String dep = Convert.ToString(dataGridView1.Rows[r].Cells["Department"].Value);
                            mailbody += (r + 1) + "." + name + " - " + dep + "<br>";
                        }
                    }
                    else
                    {
                        for (int r = 0; r < (dataGridView1.RowCount - 1); r++)
                        {

                            String name = Convert.ToString(dataGridView1.Rows[r].Cells["Name"].Value);
                            String dep = Convert.ToString(dataGridView1.Rows[r].Cells["Department"].Value);
                            mailbody += (r + 1) + "." + name + " - " + dep + "<br>";
                        }
                    }
                    //mail.Body = mailbody;
                    //To
                    Outlook.Recipients oRecips = mail.Recipients;

                    for (int r = 0; r < (dataGridView1.RowCount - 1); r++)
                    {
                        String addr = Convert.ToString(dataGridView1.Rows[r].Cells["Mail"].Value);


                        Outlook.Recipient oRecip = oRecips.Add(addr);
                        oRecip.Resolve();
                    }





                    //cc
                    for (int r = 0; r < (dataGridView2.RowCount - 1); r++)
                    {
                        String ccaddr = Convert.ToString(dataGridView2.Rows[r].Cells["Mail"].Value);
                        Outlook.Recipient recipCc = mail.Recipients.Add(ccaddr);
                        recipCc.Type = (int)Outlook.OlMailRecipientType.olCC;

                    }

                    //Attachment
                    String attachmentDisplayName = "MyAttachment";

                    foreach (string filename in openFileDialog1.FileNames)
                    {
                        if (File.Exists(filename))
                        {
                            imageSrc = filename;
                        }
                    }
                    Outlook.Attachment oAttach = mail.Attachments.Add(imageSrc, Outlook.OlAttachmentType.olByValue, null, attachmentDisplayName);
                    string imageContentid = "someimage.jpg";
                    oAttach.PropertyAccessor.SetProperty("http://schemas.microsoft.com/mapi/proptag/0x3712001E", imageContentid);


                    String wishes_header = rtb_wishes_header.Text;
                    String wishes_footer = rtb_wishes_footer.Text;
                    string font = comboBox_Font.SelectedItem.ToString();
                    string color = comboBox_color.SelectedItem.ToString();
                    /* mail.Body = mailbody;*/
                    //HTML Body
                    if (birthday_count == 1)
                    {
                        mail.HTMLBody = String.Format(
                  "<body> " +
                  "<h2 style='font-family:" + font + "; font-size: 20px;color:" + color + ";'>Hi! " + birthdayForOne + "</h2>" +

                  "<h2 style='font-family:" + font + "; font-size: 20px;color:" + color + ";  '>Greetings! </h2>" +

                  "<h2 style='font-family: " + font + ";font-size: 20px;color:" + color + ";'>{0}</h2>" +
                  "<br>" +
                  "<h2 style='font-family: " + font + ";'>{1}</h2> " +
                  "<br>" +
                  "<img src=\"cid:{2}\"><br><h1 style='font-family:" + font + "; font-size: 20px;color:" + color + "'>{3}</h1>" +
                  "<h2 style='font-family:" + font + "; font-size: 20px;color:" + color + "'>Regards,<br>Nordex P&C</h2></body>", wishes_header, mailbody,
                  imageContentid, wishes_footer);
                    }
                    else
                    {
                        mail.HTMLBody = String.Format(
                  "<body> " +
                  "<h2 style='font-family:" + font + "; font-size: 20px;color:" + color + ";'>Hi!</h2>" 
                  +
                  "<h2 style='font-family:" + font + "; font-size: 20px;color:" + color + ";  '>Greetings! </h2>" +

                  "<h2 style='font-family: " + font + ";font-size: 20px;color:" + color + ";'>{0}</h2>" +
                  "<br>" +
                  "<h2 style='font-family: " + font + ";'>{1}</h2> " +
                  "<br>" +
                  "<img src=\"cid:{2}\"><br><h1 style='font-family:" + font + "; font-size: 20px;color:" + color + "'>{3}</h1>" +
                  "<h2 style='font-family:" + font + "; font-size: 20px;color:" + color + "'>Regards,<br>Nordex P&C</h2></body>", wishes_header, mailbody,
                  imageContentid, wishes_footer);
                    }

                    mail.Importance = Outlook.OlImportance.olImportanceNormal;
                    mail.Send();
                    lbl_toast.Text = "Birthday Wishes Sended Successfully";
                    //MessageBox.Show("Message sended successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else if (selectday.Text == "Anniversaryday")
            {
                try
                {
                    string AnniverasryForOne = "";
                    _app = new Outlook.Application();
                    _app.ActiveWindow();
                    Outlook.MailItem mail = (Outlook.MailItem)_app.CreateItem(Outlook.OlItemType.olMailItem);
                    
                    mail.Subject = txt_subject.Text;
                    string mailbody = "";
                    for (int r = 0; r < (dataGridView1.RowCount - 1); r++)
                    {
                        String name;
                        if (aniver_count == 1)
                        {
                            name = Convert.ToString(dataGridView1.Rows[r].Cells["Name"].Value);
                            AnniverasryForOne = name;
                        }
                        else
                        {
                            name = Convert.ToString(dataGridView1.Rows[r].Cells["Name"].Value);
                        }

                        String dep = Convert.ToString(dataGridView1.Rows[r].Cells["Department"].Value);
                        string exp = Convert.ToString(dataGridView1.Rows[r].Cells["Experience"].Value);

                        if (aniver_count == 1)
                        {
                            if (exp == "1")
                            {
                                Anni_imageSrc = @"D:\Wishes\Anniversary Images\1st year Anniversary.jpg";
                            }
                            else if (exp == "2")
                            {
                                Anni_imageSrc = @"D:\Wishes\Anniversary Images\2nd year Anniversary.jpg";
                            }
                            else if (exp == "3")
                            {
                                Anni_imageSrc = @"D:\Wishes\Anniversary Images\3rd year Anniversary.jpg";
                            }
                            else if (exp == "4")
                            {
                                Anni_imageSrc = @"D:\Wishes\Anniversary Images\4th year Anniversary.jpg";
                            }
                            else if (exp == "5")
                            {
                                Anni_imageSrc = @"D:\Wishes\Anniversary Images\5th year Anniversary.jpg";
                            }
                            else
                            {
                                Anni_imageSrc = @"D:\Wishes\Anniversary Images\default Anniversary.jpg";
                            }
                        }
                        else
                        {
                            Anni_imageSrc = @"D:\Wishes\Anniversary Images\default Anniversary.jpg";
                        }

                        if (exp == "1")
                        {
                            mailbody += (r + 1) + ". " + name + " - " + dep + " - " + exp + "st year Anniversary" + "<br>";
                        }
                        else if (exp == "2")
                        {
                            mailbody += (r + 1) + ". " + name + " - " + dep + " - " + exp + "nd year Anniversary" + "<br>";
                        }
                        else if (exp == "3")
                        {
                            mailbody += (r + 1) + ". " + name + " - " + dep + " - " + exp + "rd year Anniversary" + "<br>";
                        }
                        else
                        {
                            mailbody += (r + 1) + ". " + name + " - " + dep + " - " + exp + "th year Anniversary" + "<br>";
                        }
                    }
                    //mail.Body = mailbody;
                    Outlook.Recipients oRecips = mail.Recipients;
                    for (int r = 0; r < (dataGridView1.RowCount - 1); r++)
                    {
                        String addr = Convert.ToString(dataGridView1.Rows[r].Cells["Mail"].Value);
                        Outlook.Recipient oRecip = oRecips.Add(addr);
                        oRecip.Resolve();
                    }



                    for (int r = 0; r < (dataGridView2.RowCount - 1); r++)
                    {
                        String ccaddr = Convert.ToString(dataGridView2.Rows[r].Cells["Mail"].Value);
                        Outlook.Recipient recipCc = mail.Recipients.Add(ccaddr);
                        recipCc.Type = (int)Outlook.OlMailRecipientType.olCC;

                    }

                    //Attachment
                    String attachmentDisplayName = "MyAttachment";


                    foreach (string filename in openFileDialog1.FileNames)
                    {
                        if (File.Exists(filename))
                        {
                            Anni_imageSrc = filename;
                        }
                    }
                    Outlook.Attachment oAttach = mail.Attachments.Add(Anni_imageSrc, Outlook.OlAttachmentType.olByValue, null, attachmentDisplayName);
                    string imageContentid = "someimage.jpg";
                    oAttach.PropertyAccessor.SetProperty("http://schemas.microsoft.com/mapi/proptag/0x3712001E", imageContentid);
                    String wishes_header = rtb_wishes_header.Text;
                    String wishes_footer = "Very Happy Work Anniversary & have a great year ahead!";
                    /* mail.Body = mailbody;*/
                    string font = comboBox_Font.SelectedItem.ToString();
                    string color = comboBox_color.SelectedItem.ToString();
                    /* mail.Body = mailbody;*/
                    //HTML Body
                    if (aniver_count == 1)
                    {
                        mail.HTMLBody = String.Format(
                "<body> " +
                "<h2 style='font-family:" + font + "; font-size: 20px;color:" + color + ";  '>Dear " + AnniverasryForOne + "</h2>" +

                "<h2 style='font-family:" + font + "; font-size: 20px;color:" + color + ";  '>On behalf of Nordex Group </h2>" +

                "<h2 style='font-family: " + font + ";font-size: 20px;color:" + color + ";'>{0}</h2>" +
                "<br>" +
                "<h2 style='font-family: " + font + ";'>{1}</h2> " +
                "<br>" +
                "<img src=\"cid:{2}\"><br><h1 style='font-family:" + font + "; font-size: 20px;color:" + color + "'>{3}</h1>" +
                "<h2 style='font-family:" + font + "; font-size: 20px;color:" + color + "'>Regards,<br>Nordex P&C</h2></body>", wishes_header, mailbody,
                imageContentid, wishes_footer);
                    }
                    else
                    {
                        mail.HTMLBody = String.Format(
                "<body> " +
                "<h2 style='font-family:" + font + "; font-size: 20px;color:" + color + ";  '>On behalf of Nordex Group </h2>" +
                "<br>" +
                "<h2 style='font-family: " + font + ";font-size: 20px;color:" + color + ";'>{0}</h2>" +

                "<h2 style='font-family: " + font + ";'>{1}</h2> " +
                "<br>" +
                "<img src=\"cid:{2}\"><br><h1 style='font-family:" + font + "; font-size: 20px;color:" + color + "'>{3}</h1>" +
                "<h2 style='font-family:" + font + "; font-size: 20px;color:" + color + "'>Regards,<br>Nordex P&C</h2></body>", wishes_header, mailbody,
                imageContentid, wishes_footer);
                    }



                    mail.Importance = Outlook.OlImportance.olImportanceNormal;

                   

                    mail.Send();
 
                    lbl_toast.Text = "Aniiversary Day Wishes Sended Successfully";



                    //MessageBox.Show("Message sended successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
        }

        private MailMessage MailMessage()
        {
            throw new NotImplementedException();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.ShowDialog();
            foreach (string filename in openFileDialog1.FileNames)
            {
                //label2.Text = filename.ToString();
                lbl_attach.Text = filename.ToString();
            }
        }

        private void msgbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void testdate_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void form1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void programBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {

                DataView dv = dataGridView1.DataSource as DataView;

                if (dv != null)
                {

                    //dv.RowFilter = txtSearch.Text;
                    String date = comboBox_month.Text;
                    dv.RowFilter = "DOB like'" + date + "%'";
                    if (((dataGridView1.RowCount) - 1) > 0)
                    {
                        label12.Text = $"Total Records :{(dataGridView1.RowCount) - 1}";
                    }
                    else
                    {

                        MessageBox.Show("NO MATCH FOUND");
                        Cursor.Current = Cursors.WaitCursor;
                        DataTable dt = new DataTable();
                        using (XLWorkbook workbook = new XLWorkbook(file_name))
                        {
                            bool isFirstRow = true;
                            var rows = workbook.Worksheet(1).RowsUsed();
                            foreach (var row in rows)
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

                            label12.Text = $"Total Records :{(dataGridView1.RowCount) - 1}";
                            Cursor.Current = Cursors.Default;

                        }
                    }
                    /*msgbox.Text = "BirthDay Mail";
                    richTextBox1.Text = "May this happy day in your life be the beginning of a year filled  with joy, good health and great success. Enjoy it to the fullest because today is your day. ";
                    richTextBox2.Text = "Happy Birthday & have a great year ahead!";*/
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public enum Month
        {
            NotSet = 0,
            January = 1,
            February = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12
        }

        private void print_Click(object sender, EventArgs e)
        {

            string date = comboBox_month.Text;
            int d = Int32.Parse(date);
            DataTable dt = new DataTable();
            dt.Columns.Add("S.No");
            dt.Columns.Add("Name of Employee");
            dt.Columns.Add("Department");
            dt.Columns.Add("Born Date");
            for (int j = 0; j < (dataGridView1.RowCount - 1); j++)
            {
                DataRow dr = dt.NewRow();
                dr["S.No"] = j + 1;
                dr["Name of Employee"] = dataGridView1.Rows[j].Cells[3].Value.ToString();
                dr["Department"] = dataGridView1.Rows[j].Cells[4].Value.ToString();
                string day = dataGridView1.Rows[j].Cells[0].Value.ToString().Substring(3, 5).Substring(0, 2);
                //(Month)d
                Enum month = (Month)d;
                dr["Born Date"] = month.ToString().Substring(0, 3) + ", " + day;
                dt.Rows.Add(dr);
            }

            GVprint.DataSource = dt.DefaultView;
            DGVPrinter printer = new DGVPrinter();
            Bitmap bitmap1 = new Bitmap(@"D:\\bdayi.jpg");
            ImbeddedImage img1 = new ImbeddedImage();

            img1.theImage = bitmap1;

            img1.ImageX = 150;

            img1.ImageY = 1000;
            img1.ImageAlignment = Alignment.Center;
            printer.ImbeddedImageList.Add(img1);

            printer.Title = " Nordex acciona";
            printer.TitleColor = Color.Red;

            printer.SubTitle = (Month)d + " Born Babies";
            printer.SubTitleColor = Color.Gray;
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;

            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "HAVE A GREAT YEAR AHEAD";
            printer.FooterColor = Color.LightGray;
            printer.FooterSpacing = 15;

            printer.PrintDataGridView(GVprint);



        }

        private void comboBox_Font_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_color_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bodycontent_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectday.Text == "Birthday")
            {
                if (combobox_content.SelectedItem.ToString() == "Content 1")
                {
                    txt_subject.Text = "HAPPY BIRTHDAY";
                    rtb_wishes_header.Text= "May this happy day in your life be the beginning of a year filled  with joy, good health and great success. Enjoy it to the fullest because today is your day. ";
                    rtb_wishes_footer.Text = "Happy Birthday & have a great year ahead!";
                }
                else if (combobox_content.SelectedItem.ToString() == "Content 2")
                {
                    txt_subject.Text = "HAPPY BIRTHDAY";
                    rtb_wishes_header.Text = "May this happy day,.May the coming year of your life bring loads of happiness and wonderful memories to cherish. Warm greetings on your birthday! ";
                    rtb_wishes_footer.Text = "Happy Birthday & have a great year ahead!";
                }
                else if (combobox_content.SelectedItem.ToString() == "Content 3")
                {
                    txt_subject.Text = "HAPPY BIRTHDAY";
                    rtb_wishes_header.Text = "Here's wishing a very Happy Birthday to a wonderful colleague and a great friend! May God bless you with health, success and happiness!";
                    rtb_wishes_footer.Text = "Happy Birthday & have a great year ahead!";
                }
            }
            else
            {
                if (combobox_content.SelectedItem.ToString() == "Content 1")
                {
                    txt_subject.Text = "HAPPY ANNIVERSARY 1";
                    rtb_wishes_header.Text = "May this happy day in your life be the beginning of a year filled  with joy, good health and great success. Enjoy it to the fullest because today is your day. ";
                    rtb_wishes_footer.Text = "Happy Birthday & have a great year ahead!";
                }
                else if (combobox_content.SelectedItem.ToString() == "Content 2")
                {
                    txt_subject.Text = "HAPPY ANNIVERSARY 2";
                    rtb_wishes_header.Text = "May this happy dayMay the coming year of your life bring loads of happiness and wonderful memories to cherish. Warm greetings on your birthday! ";
                    rtb_wishes_footer.Text = "Happy Birthday & have a great year ahead!";
                }
                else if (combobox_content.SelectedItem.ToString() == "Content 3")
                {
                    txt_subject.Text = "HAPPY ANNIVERSARY 3";
                    rtb_wishes_header.Text = "Here's wishing a very Happy Birthday to a wonderful colleague and a great friend! May God bless you with health, success and happiness!";
                    rtb_wishes_footer.Text = "Happy Birthday & have a great year ahead!";
                }
            }

        }

        private void GVprint_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
