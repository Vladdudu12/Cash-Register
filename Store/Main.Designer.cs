namespace Store
{
    partial class mainForm
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.textBoxCloseDayInfo = new System.Windows.Forms.TextBox();
            this.buttonCloseDayLink = new System.Windows.Forms.Button();
            this.textBoxHomeInfo = new System.Windows.Forms.TextBox();
            this.buttonNewReceipt = new System.Windows.Forms.Button();
            this.tabProduse = new System.Windows.Forms.TabPage();
            this.buttonEditProd = new System.Windows.Forms.Button();
            this.buttonDeleteProd = new System.Windows.Forms.Button();
            this.buttonAddProd = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabReports = new System.Windows.Forms.TabPage();
            this.textBoxCloseDayAlert = new System.Windows.Forms.TextBox();
            this.buttonCloseDay = new System.Windows.Forms.Button();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.labelLoggedinUser = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.tabProduse.SuspendLayout();
            this.tabReports.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabHome);
            this.tabControlMain.Controls.Add(this.tabProduse);
            this.tabControlMain.Controls.Add(this.tabReports);
            this.tabControlMain.Controls.Add(this.tabSettings);
            this.tabControlMain.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabControlMain.Location = new System.Drawing.Point(12, 52);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(825, 437);
            this.tabControlMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlMain.TabIndex = 0;
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.textBoxCloseDayInfo);
            this.tabHome.Controls.Add(this.buttonCloseDayLink);
            this.tabHome.Controls.Add(this.textBoxHomeInfo);
            this.tabHome.Controls.Add(this.buttonNewReceipt);
            this.tabHome.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabHome.Location = new System.Drawing.Point(4, 22);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(817, 411);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Pagina Principala";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // textBoxCloseDayInfo
            // 
            this.textBoxCloseDayInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCloseDayInfo.BackColor = System.Drawing.Color.White;
            this.textBoxCloseDayInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCloseDayInfo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxCloseDayInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCloseDayInfo.Location = new System.Drawing.Point(378, 307);
            this.textBoxCloseDayInfo.Multiline = true;
            this.textBoxCloseDayInfo.Name = "textBoxCloseDayInfo";
            this.textBoxCloseDayInfo.ReadOnly = true;
            this.textBoxCloseDayInfo.Size = new System.Drawing.Size(255, 81);
            this.textBoxCloseDayInfo.TabIndex = 2;
            this.textBoxCloseDayInfo.Text = "Pentru inchidere zi, apasati pe butonul rosu. Veti fi directionat catre o pagina " +
    "de unde puteti elibera raportul zilnic si inchide ziua.";
            // 
            // buttonCloseDayLink
            // 
            this.buttonCloseDayLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCloseDayLink.BackColor = System.Drawing.Color.Red;
            this.buttonCloseDayLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseDayLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseDayLink.ForeColor = System.Drawing.Color.White;
            this.buttonCloseDayLink.Location = new System.Drawing.Point(639, 276);
            this.buttonCloseDayLink.Name = "buttonCloseDayLink";
            this.buttonCloseDayLink.Size = new System.Drawing.Size(172, 129);
            this.buttonCloseDayLink.TabIndex = 1;
            this.buttonCloseDayLink.Text = "Inchidere zi si eliberare raport";
            this.buttonCloseDayLink.UseVisualStyleBackColor = false;
            // 
            // textBoxHomeInfo
            // 
            this.textBoxHomeInfo.BackColor = System.Drawing.Color.White;
            this.textBoxHomeInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxHomeInfo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxHomeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHomeInfo.Location = new System.Drawing.Point(185, 30);
            this.textBoxHomeInfo.Multiline = true;
            this.textBoxHomeInfo.Name = "textBoxHomeInfo";
            this.textBoxHomeInfo.ReadOnly = true;
            this.textBoxHomeInfo.Size = new System.Drawing.Size(255, 81);
            this.textBoxHomeInfo.TabIndex = 1;
            this.textBoxHomeInfo.Text = "Pentru a incepe adaugarea produselor in cosul de cumparaturi, apasati pe butonul " +
    "Bon Nou";
            // 
            // buttonNewReceipt
            // 
            this.buttonNewReceipt.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonNewReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNewReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewReceipt.ForeColor = System.Drawing.Color.White;
            this.buttonNewReceipt.Location = new System.Drawing.Point(6, 6);
            this.buttonNewReceipt.Name = "buttonNewReceipt";
            this.buttonNewReceipt.Size = new System.Drawing.Size(173, 129);
            this.buttonNewReceipt.TabIndex = 0;
            this.buttonNewReceipt.Text = "Bon Nou";
            this.buttonNewReceipt.UseVisualStyleBackColor = false;
            // 
            // tabProduse
            // 
            this.tabProduse.Controls.Add(this.labelSearch);
            this.tabProduse.Controls.Add(this.textBoxSearch);
            this.tabProduse.Controls.Add(this.buttonEditProd);
            this.tabProduse.Controls.Add(this.buttonDeleteProd);
            this.tabProduse.Controls.Add(this.buttonAddProd);
            this.tabProduse.Controls.Add(this.listView1);
            this.tabProduse.Location = new System.Drawing.Point(4, 22);
            this.tabProduse.Name = "tabProduse";
            this.tabProduse.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduse.Size = new System.Drawing.Size(817, 411);
            this.tabProduse.TabIndex = 1;
            this.tabProduse.Text = "Lista Produse";
            this.tabProduse.UseVisualStyleBackColor = true;
            // 
            // buttonEditProd
            // 
            this.buttonEditProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditProd.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonEditProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditProd.Location = new System.Drawing.Point(657, 130);
            this.buttonEditProd.Name = "buttonEditProd";
            this.buttonEditProd.Size = new System.Drawing.Size(154, 56);
            this.buttonEditProd.TabIndex = 3;
            this.buttonEditProd.Text = "Modificare";
            this.buttonEditProd.UseVisualStyleBackColor = false;
            this.buttonEditProd.Click += new System.EventHandler(this.buttonEditProd_Click);
            // 
            // buttonDeleteProd
            // 
            this.buttonDeleteProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteProd.BackColor = System.Drawing.Color.Firebrick;
            this.buttonDeleteProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteProd.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteProd.Location = new System.Drawing.Point(657, 68);
            this.buttonDeleteProd.Name = "buttonDeleteProd";
            this.buttonDeleteProd.Size = new System.Drawing.Size(154, 56);
            this.buttonDeleteProd.TabIndex = 2;
            this.buttonDeleteProd.Text = "Stergere";
            this.buttonDeleteProd.UseVisualStyleBackColor = false;
            // 
            // buttonAddProd
            // 
            this.buttonAddProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddProd.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonAddProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddProd.ForeColor = System.Drawing.Color.White;
            this.buttonAddProd.Location = new System.Drawing.Point(657, 6);
            this.buttonAddProd.Name = "buttonAddProd";
            this.buttonAddProd.Size = new System.Drawing.Size(154, 56);
            this.buttonAddProd.TabIndex = 1;
            this.buttonAddProd.Text = "Produs Nou";
            this.buttonAddProd.UseVisualStyleBackColor = false;
            this.buttonAddProd.Click += new System.EventHandler(this.buttonAddProd_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 3);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(651, 399);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tabReports
            // 
            this.tabReports.Controls.Add(this.textBoxCloseDayAlert);
            this.tabReports.Controls.Add(this.buttonCloseDay);
            this.tabReports.Location = new System.Drawing.Point(4, 22);
            this.tabReports.Name = "tabReports";
            this.tabReports.Padding = new System.Windows.Forms.Padding(3);
            this.tabReports.Size = new System.Drawing.Size(817, 411);
            this.tabReports.TabIndex = 2;
            this.tabReports.Text = "Rapoarte";
            this.tabReports.UseVisualStyleBackColor = true;
            // 
            // textBoxCloseDayAlert
            // 
            this.textBoxCloseDayAlert.BackColor = System.Drawing.Color.White;
            this.textBoxCloseDayAlert.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCloseDayAlert.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxCloseDayAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCloseDayAlert.Location = new System.Drawing.Point(9, 18);
            this.textBoxCloseDayAlert.Multiline = true;
            this.textBoxCloseDayAlert.Name = "textBoxCloseDayAlert";
            this.textBoxCloseDayAlert.ReadOnly = true;
            this.textBoxCloseDayAlert.Size = new System.Drawing.Size(201, 66);
            this.textBoxCloseDayAlert.TabIndex = 2;
            this.textBoxCloseDayAlert.Text = "ATENTIE!\r\nApasarea butonului de mai jos nu este reversibila!";
            // 
            // buttonCloseDay
            // 
            this.buttonCloseDay.BackColor = System.Drawing.Color.Red;
            this.buttonCloseDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseDay.ForeColor = System.Drawing.Color.White;
            this.buttonCloseDay.Location = new System.Drawing.Point(9, 90);
            this.buttonCloseDay.Name = "buttonCloseDay";
            this.buttonCloseDay.Size = new System.Drawing.Size(201, 61);
            this.buttonCloseDay.TabIndex = 1;
            this.buttonCloseDay.Text = "Inchidere zi si generare raport";
            this.buttonCloseDay.UseVisualStyleBackColor = false;
            // 
            // tabSettings
            // 
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(817, 411);
            this.tabSettings.TabIndex = 3;
            this.tabSettings.Text = "Setari";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // labelLoggedinUser
            // 
            this.labelLoggedinUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLoggedinUser.AutoSize = true;
            this.labelLoggedinUser.Location = new System.Drawing.Point(578, 28);
            this.labelLoggedinUser.Name = "labelLoggedinUser";
            this.labelLoggedinUser.Size = new System.Drawing.Size(162, 13);
            this.labelLoggedinUser.TabIndex = 1;
            this.labelLoggedinUser.Text = "Sunteti autentificat ca: username";
            // 
            // buttonLogout
            // 
            this.buttonLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogout.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.ForeColor = System.Drawing.Color.Black;
            this.buttonLogout.Location = new System.Drawing.Point(746, 23);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(87, 23);
            this.buttonLogout.TabIndex = 2;
            this.buttonLogout.Text = "Deconectare";
            this.buttonLogout.UseVisualStyleBackColor = false;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Location = new System.Drawing.Point(657, 220);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(154, 20);
            this.textBoxSearch.TabIndex = 4;
            // 
            // labelSearch
            // 
            this.labelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(677, 197);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(120, 20);
            this.labelSearch.TabIndex = 5;
            this.labelSearch.Text = "Cautare Produs";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 501);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.labelLoggedinUser);
            this.Controls.Add(this.tabControlMain);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "mainForm";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControlMain.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            this.tabProduse.ResumeLayout(false);
            this.tabProduse.PerformLayout();
            this.tabReports.ResumeLayout(false);
            this.tabReports.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.Button buttonNewReceipt;
        private System.Windows.Forms.TabPage tabProduse;
        private System.Windows.Forms.TextBox textBoxHomeInfo;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonEditProd;
        private System.Windows.Forms.Button buttonDeleteProd;
        private System.Windows.Forms.Button buttonAddProd;
        private System.Windows.Forms.TabPage tabReports;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.TextBox textBoxCloseDayInfo;
        private System.Windows.Forms.Button buttonCloseDayLink;
        private System.Windows.Forms.TextBox textBoxCloseDayAlert;
        private System.Windows.Forms.Button buttonCloseDay;
        private System.Windows.Forms.Label labelLoggedinUser;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
    }
}