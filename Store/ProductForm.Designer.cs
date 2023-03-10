namespace Store
{
    partial class ProductForm
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
            this.textBoxProdName = new System.Windows.Forms.TextBox();
            this.textBoxMeasureUnit = new System.Windows.Forms.TextBox();
            this.textBoxPriceWVAT = new System.Windows.Forms.TextBox();
            this.textBoxProdDescription = new System.Windows.Forms.TextBox();
            this.textBoxPriceNoVAT = new System.Windows.Forms.TextBox();
            this.comboBoxVatType = new System.Windows.Forms.ComboBox();
            this.vattypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_storeDataSet = new Store.db_storeDataSet();
            this.labelProdName = new System.Windows.Forms.Label();
            this.labelProdUnit = new System.Windows.Forms.Label();
            this.labelPriceWVAT = new System.Windows.Forms.Label();
            this.labelProdDescription = new System.Windows.Forms.Label();
            this.labelPriceNoVAT = new System.Windows.Forms.Label();
            this.labelVATCategory = new System.Windows.Forms.Label();
            this.buttonProdUpdate = new System.Windows.Forms.Button();
            this.vat_typesTableAdapter = new Store.db_storeDataSetTableAdapters.vat_typesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vattypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_storeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxProdName
            // 
            this.textBoxProdName.Location = new System.Drawing.Point(126, 28);
            this.textBoxProdName.Name = "textBoxProdName";
            this.textBoxProdName.Size = new System.Drawing.Size(121, 20);
            this.textBoxProdName.TabIndex = 0;
            this.textBoxProdName.TextChanged += new System.EventHandler(this.textBoxProdName_TextChanged);
            // 
            // textBoxMeasureUnit
            // 
            this.textBoxMeasureUnit.Location = new System.Drawing.Point(126, 54);
            this.textBoxMeasureUnit.Name = "textBoxMeasureUnit";
            this.textBoxMeasureUnit.Size = new System.Drawing.Size(121, 20);
            this.textBoxMeasureUnit.TabIndex = 1;
            // 
            // textBoxPriceWVAT
            // 
            this.textBoxPriceWVAT.Location = new System.Drawing.Point(126, 80);
            this.textBoxPriceWVAT.Name = "textBoxPriceWVAT";
            this.textBoxPriceWVAT.Size = new System.Drawing.Size(121, 20);
            this.textBoxPriceWVAT.TabIndex = 2;
            // 
            // textBoxProdDescription
            // 
            this.textBoxProdDescription.Location = new System.Drawing.Point(366, 28);
            this.textBoxProdDescription.Multiline = true;
            this.textBoxProdDescription.Name = "textBoxProdDescription";
            this.textBoxProdDescription.Size = new System.Drawing.Size(121, 42);
            this.textBoxProdDescription.TabIndex = 3;
            // 
            // textBoxPriceNoVAT
            // 
            this.textBoxPriceNoVAT.Enabled = false;
            this.textBoxPriceNoVAT.Location = new System.Drawing.Point(126, 108);
            this.textBoxPriceNoVAT.Name = "textBoxPriceNoVAT";
            this.textBoxPriceNoVAT.Size = new System.Drawing.Size(121, 20);
            this.textBoxPriceNoVAT.TabIndex = 4;
            this.textBoxPriceNoVAT.TextChanged += new System.EventHandler(this.textBoxPriceNoVAT_TextChanged);
            // 
            // comboBoxVatType
            // 
            this.comboBoxVatType.DataSource = this.vattypesBindingSource;
            this.comboBoxVatType.DisplayMember = "type";
            this.comboBoxVatType.FormattingEnabled = true;
            this.comboBoxVatType.Location = new System.Drawing.Point(126, 135);
            this.comboBoxVatType.Name = "comboBoxVatType";
            this.comboBoxVatType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVatType.TabIndex = 5;
            this.comboBoxVatType.ValueMember = "type";
            // 
            // vattypesBindingSource
            // 
            this.vattypesBindingSource.DataMember = "vat_types";
            this.vattypesBindingSource.DataSource = this.db_storeDataSet;
            // 
            // db_storeDataSet
            // 
            this.db_storeDataSet.DataSetName = "db_storeDataSet";
            this.db_storeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelProdName
            // 
            this.labelProdName.AutoSize = true;
            this.labelProdName.Location = new System.Drawing.Point(13, 31);
            this.labelProdName.Name = "labelProdName";
            this.labelProdName.Size = new System.Drawing.Size(52, 13);
            this.labelProdName.TabIndex = 6;
            this.labelProdName.Text = "Denumire";
            // 
            // labelProdUnit
            // 
            this.labelProdUnit.AutoSize = true;
            this.labelProdUnit.Location = new System.Drawing.Point(13, 57);
            this.labelProdUnit.Name = "labelProdUnit";
            this.labelProdUnit.Size = new System.Drawing.Size(93, 13);
            this.labelProdUnit.TabIndex = 7;
            this.labelProdUnit.Text = "Unitate de masura";
            // 
            // labelPriceWVAT
            // 
            this.labelPriceWVAT.AutoSize = true;
            this.labelPriceWVAT.Location = new System.Drawing.Point(13, 85);
            this.labelPriceWVAT.Name = "labelPriceWVAT";
            this.labelPriceWVAT.Size = new System.Drawing.Size(65, 13);
            this.labelPriceWVAT.TabIndex = 8;
            this.labelPriceWVAT.Text = "Pret cu TVA";
            // 
            // labelProdDescription
            // 
            this.labelProdDescription.AutoSize = true;
            this.labelProdDescription.Location = new System.Drawing.Point(289, 31);
            this.labelProdDescription.Name = "labelProdDescription";
            this.labelProdDescription.Size = new System.Drawing.Size(52, 13);
            this.labelProdDescription.TabIndex = 9;
            this.labelProdDescription.Text = "Descriere";
            // 
            // labelPriceNoVAT
            // 
            this.labelPriceNoVAT.AutoSize = true;
            this.labelPriceNoVAT.Location = new System.Drawing.Point(13, 111);
            this.labelPriceNoVAT.Name = "labelPriceNoVAT";
            this.labelPriceNoVAT.Size = new System.Drawing.Size(71, 13);
            this.labelPriceNoVAT.TabIndex = 10;
            this.labelPriceNoVAT.Text = "Pret fara TVA";
            // 
            // labelVATCategory
            // 
            this.labelVATCategory.AutoSize = true;
            this.labelVATCategory.Location = new System.Drawing.Point(13, 138);
            this.labelVATCategory.Name = "labelVATCategory";
            this.labelVATCategory.Size = new System.Drawing.Size(76, 13);
            this.labelVATCategory.TabIndex = 11;
            this.labelVATCategory.Text = "Categorie TVA";
            // 
            // buttonProdUpdate
            // 
            this.buttonProdUpdate.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonProdUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonProdUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProdUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProdUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonProdUpdate.Location = new System.Drawing.Point(366, 136);
            this.buttonProdUpdate.Name = "buttonProdUpdate";
            this.buttonProdUpdate.Size = new System.Drawing.Size(121, 43);
            this.buttonProdUpdate.TabIndex = 13;
            this.buttonProdUpdate.Text = "Salveaza";
            this.buttonProdUpdate.UseVisualStyleBackColor = false;
            this.buttonProdUpdate.Click += new System.EventHandler(this.buttonProdUpdate_Click);
            // 
            // vat_typesTableAdapter
            // 
            this.vat_typesTableAdapter.ClearBeforeFill = true;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 204);
            this.Controls.Add(this.buttonProdUpdate);
            this.Controls.Add(this.labelVATCategory);
            this.Controls.Add(this.labelPriceNoVAT);
            this.Controls.Add(this.labelProdDescription);
            this.Controls.Add(this.labelPriceWVAT);
            this.Controls.Add(this.labelProdUnit);
            this.Controls.Add(this.labelProdName);
            this.Controls.Add(this.comboBoxVatType);
            this.Controls.Add(this.textBoxPriceNoVAT);
            this.Controls.Add(this.textBoxProdDescription);
            this.Controls.Add(this.textBoxPriceWVAT);
            this.Controls.Add(this.textBoxMeasureUnit);
            this.Controls.Add(this.textBoxProdName);
            this.Name = "ProductForm";
            this.Text = "Editare Produs";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vattypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_storeDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxProdName;
        private System.Windows.Forms.TextBox textBoxMeasureUnit;
        private System.Windows.Forms.TextBox textBoxPriceWVAT;
        private System.Windows.Forms.TextBox textBoxProdDescription;
        private System.Windows.Forms.TextBox textBoxPriceNoVAT;
        private System.Windows.Forms.ComboBox comboBoxVatType;
        private System.Windows.Forms.Label labelProdName;
        private System.Windows.Forms.Label labelProdUnit;
        private System.Windows.Forms.Label labelPriceWVAT;
        private System.Windows.Forms.Label labelProdDescription;
        private System.Windows.Forms.Label labelPriceNoVAT;
        private System.Windows.Forms.Label labelVATCategory;
        private System.Windows.Forms.Button buttonProdUpdate;
        private db_storeDataSet db_storeDataSet;
        private System.Windows.Forms.BindingSource vattypesBindingSource;
        private db_storeDataSetTableAdapters.vat_typesTableAdapter vat_typesTableAdapter;
    }
}