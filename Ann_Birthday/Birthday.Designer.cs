
namespace Ann_Birthday
{
    partial class Birthday
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Birthday));
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_search = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_open = new System.Windows.Forms.Button();
            this.lbl_record = new System.Windows.Forms.Label();
            this.testdate = new System.Windows.Forms.Label();
            this.datepicker = new System.Windows.Forms.DateTimePicker();
            this.selectday = new System.Windows.Forms.ComboBox();
            this.send = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_send = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.ll_attach = new System.Windows.Forms.LinkLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_subject = new System.Windows.Forms.Label();
            this.txt_subject = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_header = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_footer = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rtb_wishes_header = new System.Windows.Forms.RichTextBox();
            this.rtb_wishes_footer = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_topic = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.comboBox_month = new System.Windows.Forms.ComboBox();
            this.print = new System.Windows.Forms.Button();
            this.GVprint = new System.Windows.Forms.DataGridView();
            this.comboBox_Font = new System.Windows.Forms.ComboBox();
            this.lbl_font = new System.Windows.Forms.Label();
            this.lbl_month = new System.Windows.Forms.Label();
            this.lbl_color = new System.Windows.Forms.Label();
            this.comboBox_color = new System.Windows.Forms.ComboBox();
            this.combobox_content = new System.Windows.Forms.ComboBox();
            this.lbl_content = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_toast = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.lbl_attach = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVprint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Search.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Search.Location = new System.Drawing.Point(888, 81);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(117, 41);
            this.btn_Search.TabIndex = 0;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_search.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_search.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_search.Location = new System.Drawing.Point(364, 81);
            this.lbl_search.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(137, 30);
            this.lbl_search.TabIndex = 1;
            this.lbl_search.Text = "Search By :";
            this.lbl_search.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(360, 130);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(791, 480);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_open
            // 
            this.btn_open.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_open.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold);
            this.btn_open.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_open.Location = new System.Drawing.Point(47, 81);
            this.btn_open.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(117, 41);
            this.btn_open.TabIndex = 4;
            this.btn_open.Text = "Open File";
            this.btn_open.UseVisualStyleBackColor = false;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // lbl_record
            // 
            this.lbl_record.AutoSize = true;
            this.lbl_record.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_record.ForeColor = System.Drawing.Color.Blue;
            this.lbl_record.Location = new System.Drawing.Point(692, 579);
            this.lbl_record.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_record.Name = "lbl_record";
            this.lbl_record.Size = new System.Drawing.Size(142, 21);
            this.lbl_record.TabIndex = 5;
            this.lbl_record.Text = "Search  record:";
            this.lbl_record.Click += new System.EventHandler(this.lbl_record_Click);
            // 
            // testdate
            // 
            this.testdate.AutoSize = true;
            this.testdate.Location = new System.Drawing.Point(726, 54);
            this.testdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.testdate.Name = "testdate";
            this.testdate.Size = new System.Drawing.Size(0, 20);
            this.testdate.TabIndex = 7;
            this.testdate.Click += new System.EventHandler(this.testdate_Click);
            // 
            // datepicker
            // 
            this.datepicker.CalendarFont = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.datepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datepicker.Location = new System.Drawing.Point(678, 81);
            this.datepicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datepicker.Name = "datepicker";
            this.datepicker.Size = new System.Drawing.Size(180, 25);
            this.datepicker.TabIndex = 10;
            this.datepicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // selectday
            // 
            this.selectday.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectday.FormattingEnabled = true;
            this.selectday.Items.AddRange(new object[] {
            "Birthday",
            "Anniversaryday"});
            this.selectday.Location = new System.Drawing.Point(509, 81);
            this.selectday.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.selectday.Name = "selectday";
            this.selectday.Size = new System.Drawing.Size(143, 25);
            this.selectday.TabIndex = 11;
            this.selectday.Text = "Birthday";
            this.selectday.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // send
            // 
            this.send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.send.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold);
            this.send.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.send.Location = new System.Drawing.Point(888, 726);
            this.send.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(138, 58);
            this.send.TabIndex = 12;
            this.send.Text = "Gmail";
            this.send.UseVisualStyleBackColor = false;
            this.send.Visible = false;
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_reset.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold);
            this.btn_reset.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_reset.Location = new System.Drawing.Point(1034, 81);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(117, 41);
            this.btn_reset.TabIndex = 13;
            this.btn_reset.Text = "Reset File";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_send
            // 
            this.btn_send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_send.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold);
            this.btn_send.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_send.Location = new System.Drawing.Point(47, 615);
            this.btn_send.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(117, 41);
            this.btn_send.TabIndex = 14;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = false;
            this.btn_send.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(1422, 640);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(162, 166);
            this.dataGridView2.TabIndex = 15;
            this.dataGridView2.Visible = false;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            // 
            // ll_attach
            // 
            this.ll_attach.ActiveLinkColor = System.Drawing.Color.DarkViolet;
            this.ll_attach.AutoSize = true;
            this.ll_attach.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ll_attach.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ll_attach.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.ll_attach.LinkColor = System.Drawing.Color.Fuchsia;
            this.ll_attach.Location = new System.Drawing.Point(47, 140);
            this.ll_attach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ll_attach.Name = "ll_attach";
            this.ll_attach.Size = new System.Drawing.Size(101, 23);
            this.ll_attach.TabIndex = 16;
            this.ll_attach.TabStop = true;
            this.ll_attach.Text = "Attachment";
            this.ll_attach.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1252, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 17;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_subject
            // 
            this.lbl_subject.AutoSize = true;
            this.lbl_subject.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subject.Location = new System.Drawing.Point(47, 201);
            this.lbl_subject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_subject.Name = "lbl_subject";
            this.lbl_subject.Size = new System.Drawing.Size(80, 21);
            this.lbl_subject.TabIndex = 18;
            this.lbl_subject.Text = "Subject :";
            this.lbl_subject.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_subject
            // 
            this.txt_subject.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_subject.Location = new System.Drawing.Point(47, 227);
            this.txt_subject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_subject.Name = "txt_subject";
            this.txt_subject.Size = new System.Drawing.Size(276, 28);
            this.txt_subject.TabIndex = 19;
            this.txt_subject.TextChanged += new System.EventHandler(this.msgbox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 227);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 20;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.Location = new System.Drawing.Point(47, 271);
            this.lbl_header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(134, 21);
            this.lbl_header.TabIndex = 22;
            this.lbl_header.Text = "Wishes Header :";
            this.lbl_header.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 219);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 21;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbl_footer
            // 
            this.lbl_footer.AutoSize = true;
            this.lbl_footer.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_footer.Location = new System.Drawing.Point(47, 443);
            this.lbl_footer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_footer.Name = "lbl_footer";
            this.lbl_footer.Size = new System.Drawing.Size(129, 21);
            this.lbl_footer.TabIndex = 25;
            this.lbl_footer.Text = "Wishes Footer :";
            this.lbl_footer.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 346);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 24;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // rtb_wishes_header
            // 
            this.rtb_wishes_header.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.rtb_wishes_header.Location = new System.Drawing.Point(47, 296);
            this.rtb_wishes_header.Margin = new System.Windows.Forms.Padding(4);
            this.rtb_wishes_header.Name = "rtb_wishes_header";
            this.rtb_wishes_header.Size = new System.Drawing.Size(276, 143);
            this.rtb_wishes_header.TabIndex = 27;
            this.rtb_wishes_header.Text = "";
            this.rtb_wishes_header.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // rtb_wishes_footer
            // 
            this.rtb_wishes_footer.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.rtb_wishes_footer.Location = new System.Drawing.Point(47, 467);
            this.rtb_wishes_footer.Margin = new System.Windows.Forms.Padding(4);
            this.rtb_wishes_footer.Name = "rtb_wishes_footer";
            this.rtb_wishes_footer.Size = new System.Drawing.Size(276, 143);
            this.rtb_wishes_footer.TabIndex = 28;
            this.rtb_wishes_footer.Text = "";
            this.rtb_wishes_footer.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(47, 170);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 17);
            this.label9.TabIndex = 29;
            this.label9.Visible = false;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // lbl_topic
            // 
            this.lbl_topic.AutoSize = true;
            this.lbl_topic.BackColor = System.Drawing.Color.Gray;
            this.lbl_topic.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_topic.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_topic.Location = new System.Drawing.Point(277, 24);
            this.lbl_topic.Name = "lbl_topic";
            this.lbl_topic.Size = new System.Drawing.Size(755, 35);
            this.lbl_topic.TabIndex = 30;
            this.lbl_topic.Text = "NORDEX BIRTHDAY AND ANNIVERSARY DAY APPLICATION";
            this.lbl_topic.Click += new System.EventHandler(this.label10_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(365, 626);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 20);
            this.label12.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(47, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 20);
            this.label11.TabIndex = 33;
            // 
            // btn_Filter
            // 
            this.btn_Filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Filter.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Filter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Filter.Location = new System.Drawing.Point(1180, 216);
            this.btn_Filter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(117, 41);
            this.btn_Filter.TabIndex = 35;
            this.btn_Filter.Text = "Filter";
            this.btn_Filter.UseVisualStyleBackColor = false;
            this.btn_Filter.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // comboBox_month
            // 
            this.comboBox_month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_month.FormattingEnabled = true;
            this.comboBox_month.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.comboBox_month.Location = new System.Drawing.Point(1180, 159);
            this.comboBox_month.Name = "comboBox_month";
            this.comboBox_month.Size = new System.Drawing.Size(121, 28);
            this.comboBox_month.TabIndex = 36;
            // 
            // print
            // 
            this.print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.print.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.print.Location = new System.Drawing.Point(1034, 615);
            this.print.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(117, 41);
            this.print.TabIndex = 37;
            this.print.Text = "Print";
            this.print.UseVisualStyleBackColor = false;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // GVprint
            // 
            this.GVprint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVprint.Location = new System.Drawing.Point(1158, 535);
            this.GVprint.Name = "GVprint";
            this.GVprint.Size = new System.Drawing.Size(200, 121);
            this.GVprint.TabIndex = 38;
            this.GVprint.Visible = false;
            this.GVprint.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVprint_CellContentClick);
            // 
            // comboBox_Font
            // 
            this.comboBox_Font.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Font.FormattingEnabled = true;
            this.comboBox_Font.IntegralHeight = false;
            this.comboBox_Font.ItemHeight = 20;
            this.comboBox_Font.Items.AddRange(new object[] {
            "Garamond",
            "Monaco",
            "cursive",
            "Courier",
            "Times"});
            this.comboBox_Font.Location = new System.Drawing.Point(1180, 327);
            this.comboBox_Font.Name = "comboBox_Font";
            this.comboBox_Font.Size = new System.Drawing.Size(121, 28);
            this.comboBox_Font.TabIndex = 39;
            this.comboBox_Font.SelectedIndexChanged += new System.EventHandler(this.comboBox_Font_SelectedIndexChanged);
            // 
            // lbl_font
            // 
            this.lbl_font.AutoSize = true;
            this.lbl_font.ForeColor = System.Drawing.Color.Black;
            this.lbl_font.Location = new System.Drawing.Point(1180, 299);
            this.lbl_font.Name = "lbl_font";
            this.lbl_font.Size = new System.Drawing.Size(37, 20);
            this.lbl_font.TabIndex = 40;
            this.lbl_font.Text = "Font";
            // 
            // lbl_month
            // 
            this.lbl_month.AutoSize = true;
            this.lbl_month.Location = new System.Drawing.Point(1180, 118);
            this.lbl_month.Name = "lbl_month";
            this.lbl_month.Size = new System.Drawing.Size(48, 20);
            this.lbl_month.TabIndex = 41;
            this.lbl_month.Text = "Month";
            // 
            // lbl_color
            // 
            this.lbl_color.AutoSize = true;
            this.lbl_color.Location = new System.Drawing.Point(1180, 368);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(43, 20);
            this.lbl_color.TabIndex = 42;
            this.lbl_color.Text = "Color";
            // 
            // comboBox_color
            // 
            this.comboBox_color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_color.FormattingEnabled = true;
            this.comboBox_color.Items.AddRange(new object[] {
            "darkviolet",
            "black",
            "dodgerblue",
            "orangered",
            "darkslategray"});
            this.comboBox_color.Location = new System.Drawing.Point(1180, 400);
            this.comboBox_color.Name = "comboBox_color";
            this.comboBox_color.Size = new System.Drawing.Size(121, 28);
            this.comboBox_color.TabIndex = 43;
            this.comboBox_color.SelectedIndexChanged += new System.EventHandler(this.comboBox_color_SelectedIndexChanged);
            // 
            // combobox_content
            // 
            this.combobox_content.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_content.FormattingEnabled = true;
            this.combobox_content.Items.AddRange(new object[] {
            "Content 1",
            "Content 2",
            "Content 3"});
            this.combobox_content.Location = new System.Drawing.Point(1180, 477);
            this.combobox_content.Name = "combobox_content";
            this.combobox_content.Size = new System.Drawing.Size(121, 28);
            this.combobox_content.TabIndex = 45;
            this.combobox_content.SelectedIndexChanged += new System.EventHandler(this.bodycontent_cb_SelectedIndexChanged);
            // 
            // lbl_content
            // 
            this.lbl_content.AutoSize = true;
            this.lbl_content.Location = new System.Drawing.Point(1180, 445);
            this.lbl_content.Name = "lbl_content";
            this.lbl_content.Size = new System.Drawing.Size(92, 20);
            this.lbl_content.TabIndex = 44;
            this.lbl_content.Text = "Body Content";
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.CurrentChanged += new System.EventHandler(this.form1BindingSource_CurrentChanged);
            // 
            // programBindingSource
            // 
            this.programBindingSource.CurrentChanged += new System.EventHandler(this.programBindingSource_CurrentChanged);
            // 
            // lbl_toast
            // 
            this.lbl_toast.AutoSize = true;
            this.lbl_toast.Location = new System.Drawing.Point(566, 626);
            this.lbl_toast.Name = "lbl_toast";
            this.lbl_toast.Size = new System.Drawing.Size(100, 20);
            this.lbl_toast.TabIndex = 46;
            this.lbl_toast.Text = "Toast Message";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // lbl_attach
            // 
            this.lbl_attach.AutoSize = true;
            this.lbl_attach.Location = new System.Drawing.Point(47, 170);
            this.lbl_attach.Name = "lbl_attach";
            this.lbl_attach.Size = new System.Drawing.Size(18, 20);
            this.lbl_attach.TabIndex = 47;
            this.lbl_attach.Text = "...";
            // 
            // Birthday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ann_Birthday.Properties.Resources.final;
            this.ClientSize = new System.Drawing.Size(1370, 663);
            this.Controls.Add(this.lbl_attach);
            this.Controls.Add(this.lbl_toast);
            this.Controls.Add(this.combobox_content);
            this.Controls.Add(this.lbl_content);
            this.Controls.Add(this.comboBox_color);
            this.Controls.Add(this.lbl_color);
            this.Controls.Add(this.lbl_month);
            this.Controls.Add(this.lbl_font);
            this.Controls.Add(this.comboBox_Font);
            this.Controls.Add(this.GVprint);
            this.Controls.Add(this.print);
            this.Controls.Add(this.comboBox_month);
            this.Controls.Add(this.btn_Filter);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbl_topic);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rtb_wishes_footer);
            this.Controls.Add(this.rtb_wishes_header);
            this.Controls.Add(this.lbl_footer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_header);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_subject);
            this.Controls.Add(this.lbl_subject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ll_attach);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.send);
            this.Controls.Add(this.selectday);
            this.Controls.Add(this.datepicker);
            this.Controls.Add(this.testdate);
            this.Controls.Add(this.lbl_record);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.lbl_search);
            this.Controls.Add(this.btn_Search);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Birthday";
            this.Text = "Birthday Anniversaryday Application";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVprint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Label lbl_record;
        private System.Windows.Forms.Label testdate;
        private System.Windows.Forms.DateTimePicker datepicker;
        private System.Windows.Forms.ComboBox selectday;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.LinkLabel ll_attach;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_subject;
        private System.Windows.Forms.Label lbl_subject;
        private System.Windows.Forms.Label lbl_footer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtb_wishes_footer;
        private System.Windows.Forms.RichTextBox rtb_wishes_header;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_topic;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.ComboBox comboBox_month;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.DataGridView GVprint;
        private System.Windows.Forms.ComboBox comboBox_Font;
        private System.Windows.Forms.Label lbl_font;
        private System.Windows.Forms.Label lbl_month;
        private System.Windows.Forms.ComboBox comboBox_color;
        private System.Windows.Forms.Label lbl_color;
        private System.Windows.Forms.ComboBox combobox_content;
        private System.Windows.Forms.Label lbl_content;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lbl_toast;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label lbl_attach;
    }
}

