namespace Football_AdoNet
{
    partial class AddHeadcoachForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddHeadcoachForm));
            this.footballDataSet1 = new Football_AdoNet.FootballDataSet();
            this.headcoachesTableAdapter1 = new Football_AdoNet.FootballDataSetTableAdapters.HEADCOACHESTableAdapter();
            this.queriesTableAdapter1 = new Football_AdoNet.FootballDataSetTableAdapters.QueriesTableAdapter();
            this.dataGridViewHeadcoaches = new System.Windows.Forms.DataGridView();
            this.hCNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hCBirthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hCIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hEADCOACHESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.footballDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHeadcoaches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hEADCOACHESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // footballDataSet1
            // 
            this.footballDataSet1.DataSetName = "FootballDataSet";
            this.footballDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // headcoachesTableAdapter1
            // 
            this.headcoachesTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridViewHeadcoaches
            // 
            this.dataGridViewHeadcoaches.AutoGenerateColumns = false;
            this.dataGridViewHeadcoaches.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridViewHeadcoaches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHeadcoaches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hCNameDataGridViewTextBoxColumn,
            this.hCBirthdayDataGridViewTextBoxColumn,
            this.hCIDDataGridViewTextBoxColumn});
            this.dataGridViewHeadcoaches.DataSource = this.hEADCOACHESBindingSource;
            this.dataGridViewHeadcoaches.Location = new System.Drawing.Point(13, 107);
            this.dataGridViewHeadcoaches.Name = "dataGridViewHeadcoaches";
            this.dataGridViewHeadcoaches.Size = new System.Drawing.Size(359, 242);
            this.dataGridViewHeadcoaches.TabIndex = 0;
            this.dataGridViewHeadcoaches.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewHeadcoaches_DataError);
            // 
            // hCNameDataGridViewTextBoxColumn
            // 
            this.hCNameDataGridViewTextBoxColumn.DataPropertyName = "HC_Name";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkOrange;
            this.hCNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.hCNameDataGridViewTextBoxColumn.HeaderText = "ПІБ";
            this.hCNameDataGridViewTextBoxColumn.Name = "hCNameDataGridViewTextBoxColumn";
            this.hCNameDataGridViewTextBoxColumn.Width = 158;
            // 
            // hCBirthdayDataGridViewTextBoxColumn
            // 
            this.hCBirthdayDataGridViewTextBoxColumn.DataPropertyName = "HC_Birthday";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOrange;
            this.hCBirthdayDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.hCBirthdayDataGridViewTextBoxColumn.HeaderText = "Дата народження";
            this.hCBirthdayDataGridViewTextBoxColumn.Name = "hCBirthdayDataGridViewTextBoxColumn";
            this.hCBirthdayDataGridViewTextBoxColumn.Width = 158;
            // 
            // hCIDDataGridViewTextBoxColumn
            // 
            this.hCIDDataGridViewTextBoxColumn.DataPropertyName = "HC_ID";
            this.hCIDDataGridViewTextBoxColumn.HeaderText = "HC_ID";
            this.hCIDDataGridViewTextBoxColumn.Name = "hCIDDataGridViewTextBoxColumn";
            this.hCIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.hCIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // hEADCOACHESBindingSource
            // 
            this.hEADCOACHESBindingSource.DataMember = "HEADCOACHES";
            this.hEADCOACHESBindingSource.DataSource = this.footballDataSet1;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.DarkOrange;
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
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(226, 16);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(80, 80);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Видалити";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // AddHeadcoachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridViewHeadcoaches);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddHeadcoachForm";
            this.Text = "Тренери";
            ((System.ComponentModel.ISupportInitialize)(this.footballDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHeadcoaches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hEADCOACHESBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FootballDataSet footballDataSet1;
        private FootballDataSetTableAdapters.HEADCOACHESTableAdapter headcoachesTableAdapter1;
        private FootballDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridViewHeadcoaches;
        private System.Windows.Forms.BindingSource hEADCOACHESBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn hCNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hCBirthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hCIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
    }
}