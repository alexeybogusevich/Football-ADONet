namespace Football_AdoNet
{
    partial class AddCityForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCityForm));
            this.footballDataSet1 = new Football_AdoNet.FootballDataSet();
            this.queriesTableAdapter1 = new Football_AdoNet.FootballDataSetTableAdapters.QueriesTableAdapter();
            this.citiesTableAdapter1 = new Football_AdoNet.FootballDataSetTableAdapters.CITIESTableAdapter();
            this.dataGridViewAddCity = new System.Windows.Forms.DataGridView();
            this.cTNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTCountryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cOUNTRIESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cITIESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.cOUNTRIESTableAdapter = new Football_AdoNet.FootballDataSetTableAdapters.COUNTRIESTableAdapter();
            this.buttonAddCities = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.footballDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOUNTRIESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cITIESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // footballDataSet1
            // 
            this.footballDataSet1.DataSetName = "FootballDataSet";
            this.footballDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // citiesTableAdapter1
            // 
            this.citiesTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridViewAddCity
            // 
            this.dataGridViewAddCity.AutoGenerateColumns = false;
            this.dataGridViewAddCity.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridViewAddCity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddCity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cTNameDataGridViewTextBoxColumn,
            this.cTCountryIDDataGridViewTextBoxColumn,
            this.cTIDDataGridViewTextBoxColumn});
            this.dataGridViewAddCity.DataSource = this.cITIESBindingSource;
            this.dataGridViewAddCity.Location = new System.Drawing.Point(13, 107);
            this.dataGridViewAddCity.Name = "dataGridViewAddCity";
            this.dataGridViewAddCity.Size = new System.Drawing.Size(359, 242);
            this.dataGridViewAddCity.TabIndex = 0;
            this.dataGridViewAddCity.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewAddCity_DataError);
            // 
            // cTNameDataGridViewTextBoxColumn
            // 
            this.cTNameDataGridViewTextBoxColumn.DataPropertyName = "CT_Name";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkOrange;
            this.cTNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.cTNameDataGridViewTextBoxColumn.HeaderText = "Назва міста";
            this.cTNameDataGridViewTextBoxColumn.Name = "cTNameDataGridViewTextBoxColumn";
            this.cTNameDataGridViewTextBoxColumn.Width = 159;
            // 
            // cTCountryIDDataGridViewTextBoxColumn
            // 
            this.cTCountryIDDataGridViewTextBoxColumn.DataPropertyName = "CT_CountryID";
            this.cTCountryIDDataGridViewTextBoxColumn.DataSource = this.cOUNTRIESBindingSource;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOrange;
            this.cTCountryIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.cTCountryIDDataGridViewTextBoxColumn.DisplayMember = "CNTRY_Name";
            this.cTCountryIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.cTCountryIDDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cTCountryIDDataGridViewTextBoxColumn.HeaderText = "Країна";
            this.cTCountryIDDataGridViewTextBoxColumn.Name = "cTCountryIDDataGridViewTextBoxColumn";
            this.cTCountryIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cTCountryIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cTCountryIDDataGridViewTextBoxColumn.ValueMember = "CNTRY_ID";
            this.cTCountryIDDataGridViewTextBoxColumn.Width = 157;
            // 
            // cOUNTRIESBindingSource
            // 
            this.cOUNTRIESBindingSource.DataMember = "COUNTRIES";
            this.cOUNTRIESBindingSource.DataSource = this.footballDataSet1;
            // 
            // cTIDDataGridViewTextBoxColumn
            // 
            this.cTIDDataGridViewTextBoxColumn.DataPropertyName = "CT_ID";
            this.cTIDDataGridViewTextBoxColumn.HeaderText = "CT_ID";
            this.cTIDDataGridViewTextBoxColumn.Name = "cTIDDataGridViewTextBoxColumn";
            this.cTIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cTIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cITIESBindingSource
            // 
            this.cITIESBindingSource.DataMember = "CITIES";
            this.cITIESBindingSource.DataSource = this.footballDataSet1;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(69, 16);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(80, 80);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Зберегти";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(226, 16);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(80, 80);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Видалити";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // cOUNTRIESTableAdapter
            // 
            this.cOUNTRIESTableAdapter.ClearBeforeFill = true;
            // 
            // buttonAddCities
            // 
            this.buttonAddCities.BackColor = System.Drawing.Color.White;
            this.buttonAddCities.FlatAppearance.BorderSize = 0;
            this.buttonAddCities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddCities.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddCities.Location = new System.Drawing.Point(353, 109);
            this.buttonAddCities.Name = "buttonAddCities";
            this.buttonAddCities.Size = new System.Drawing.Size(18, 18);
            this.buttonAddCities.TabIndex = 5;
            this.buttonAddCities.Text = "+";
            this.buttonAddCities.UseVisualStyleBackColor = false;
            this.buttonAddCities.Click += new System.EventHandler(this.buttonAddCities_Click);
            // 
            // AddCityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.buttonAddCities);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridViewAddCity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddCityForm";
            this.Text = "AddCityForm";
            this.Load += new System.EventHandler(this.AddCityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.footballDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOUNTRIESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cITIESBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FootballDataSet footballDataSet1;
        private FootballDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private FootballDataSetTableAdapters.CITIESTableAdapter citiesTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridViewAddCity;
        private System.Windows.Forms.BindingSource cITIESBindingSource;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.BindingSource cOUNTRIESBindingSource;
        private FootballDataSetTableAdapters.COUNTRIESTableAdapter cOUNTRIESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn cTCountryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonAddCities;
    }
}