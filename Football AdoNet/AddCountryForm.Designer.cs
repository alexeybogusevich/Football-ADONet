namespace Football_AdoNet
{
    partial class AddCountryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCountryForm));
            this.dataGridViewCountries = new System.Windows.Forms.DataGridView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.cOUNTRIESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.footballDataSet1 = new Football_AdoNet.FootballDataSet();
            this.countriesTableAdapter1 = new Football_AdoNet.FootballDataSetTableAdapters.COUNTRIESTableAdapter();
            this.queriesTableAdapter1 = new Football_AdoNet.FootballDataSetTableAdapters.QueriesTableAdapter();
            this.cNTRYNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNTRYIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOUNTRIESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.footballDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCountries
            // 
            this.dataGridViewCountries.AutoGenerateColumns = false;
            this.dataGridViewCountries.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridViewCountries.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridViewCountries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCountries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNTRYNameDataGridViewTextBoxColumn,
            this.cNTRYIDDataGridViewTextBoxColumn});
            this.dataGridViewCountries.DataSource = this.cOUNTRIESBindingSource;
            this.dataGridViewCountries.Location = new System.Drawing.Point(13, 107);
            this.dataGridViewCountries.Name = "dataGridViewCountries";
            this.dataGridViewCountries.Size = new System.Drawing.Size(359, 242);
            this.dataGridViewCountries.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
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
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(226, 16);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(80, 80);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Видалити";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // cOUNTRIESBindingSource
            // 
            this.cOUNTRIESBindingSource.DataMember = "COUNTRIES";
            this.cOUNTRIESBindingSource.DataSource = this.footballDataSet1;
            // 
            // footballDataSet1
            // 
            this.footballDataSet1.DataSetName = "FootballDataSet";
            this.footballDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // countriesTableAdapter1
            // 
            this.countriesTableAdapter1.ClearBeforeFill = true;
            // 
            // cNTRYNameDataGridViewTextBoxColumn
            // 
            this.cNTRYNameDataGridViewTextBoxColumn.DataPropertyName = "CNTRY_Name";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkOrange;
            this.cNTRYNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.cNTRYNameDataGridViewTextBoxColumn.HeaderText = "Назва країни";
            this.cNTRYNameDataGridViewTextBoxColumn.Name = "cNTRYNameDataGridViewTextBoxColumn";
            this.cNTRYNameDataGridViewTextBoxColumn.Width = 316;
            // 
            // cNTRYIDDataGridViewTextBoxColumn
            // 
            this.cNTRYIDDataGridViewTextBoxColumn.DataPropertyName = "CNTRY_ID";
            this.cNTRYIDDataGridViewTextBoxColumn.HeaderText = "CNTRY_ID";
            this.cNTRYIDDataGridViewTextBoxColumn.Name = "cNTRYIDDataGridViewTextBoxColumn";
            this.cNTRYIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cNTRYIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // AddCountryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridViewCountries);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddCountryForm";
            this.Text = "Країни";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOUNTRIESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.footballDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FootballDataSet footballDataSet1;
        private FootballDataSetTableAdapters.COUNTRIESTableAdapter countriesTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridViewCountries;
        private System.Windows.Forms.BindingSource cOUNTRIESBindingSource;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
        private FootballDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNTRYNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNTRYIDDataGridViewTextBoxColumn;
    }
}