namespace Football_AdoNet
{
    partial class AddPresidentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPresidentForm));
            this.footballDataSet1 = new Football_AdoNet.FootballDataSet();
            this.presidentsTableAdapter1 = new Football_AdoNet.FootballDataSetTableAdapters.PRESIDENTSTableAdapter();
            this.queriesTableAdapter1 = new Football_AdoNet.FootballDataSetTableAdapters.QueriesTableAdapter();
            this.dataGridViewPresidents = new System.Windows.Forms.DataGridView();
            this.prNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prDateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRESIDENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hEADCOACHESTableAdapter = new Football_AdoNet.FootballDataSetTableAdapters.HEADCOACHESTableAdapter();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.footballDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPresidents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRESIDENTSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // footballDataSet1
            // 
            this.footballDataSet1.DataSetName = "FootballDataSet";
            this.footballDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // presidentsTableAdapter1
            // 
            this.presidentsTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridViewPresidents
            // 
            this.dataGridViewPresidents.AutoGenerateColumns = false;
            this.dataGridViewPresidents.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridViewPresidents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPresidents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prNameDataGridViewTextBoxColumn,
            this.prDateOfBirthDataGridViewTextBoxColumn,
            this.prIDDataGridViewTextBoxColumn});
            this.dataGridViewPresidents.DataSource = this.pRESIDENTSBindingSource;
            this.dataGridViewPresidents.Location = new System.Drawing.Point(12, 107);
            this.dataGridViewPresidents.Name = "dataGridViewPresidents";
            this.dataGridViewPresidents.Size = new System.Drawing.Size(359, 242);
            this.dataGridViewPresidents.TabIndex = 0;
            this.dataGridViewPresidents.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewPresidents_DataError);
            // 
            // prNameDataGridViewTextBoxColumn
            // 
            this.prNameDataGridViewTextBoxColumn.DataPropertyName = "Pr_Name";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkOrange;
            this.prNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.prNameDataGridViewTextBoxColumn.HeaderText = "ПІБ";
            this.prNameDataGridViewTextBoxColumn.Name = "prNameDataGridViewTextBoxColumn";
            this.prNameDataGridViewTextBoxColumn.Width = 158;
            // 
            // prDateOfBirthDataGridViewTextBoxColumn
            // 
            this.prDateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "Pr_DateOfBirth";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOrange;
            this.prDateOfBirthDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.prDateOfBirthDataGridViewTextBoxColumn.HeaderText = "Дата народження";
            this.prDateOfBirthDataGridViewTextBoxColumn.Name = "prDateOfBirthDataGridViewTextBoxColumn";
            this.prDateOfBirthDataGridViewTextBoxColumn.Width = 158;
            // 
            // prIDDataGridViewTextBoxColumn
            // 
            this.prIDDataGridViewTextBoxColumn.DataPropertyName = "Pr_ID";
            this.prIDDataGridViewTextBoxColumn.HeaderText = "Pr_ID";
            this.prIDDataGridViewTextBoxColumn.Name = "prIDDataGridViewTextBoxColumn";
            this.prIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.prIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pRESIDENTSBindingSource
            // 
            this.pRESIDENTSBindingSource.DataMember = "PRESIDENTS";
            this.pRESIDENTSBindingSource.DataSource = this.footballDataSet1;
            // 
            // hEADCOACHESTableAdapter
            // 
            this.hEADCOACHESTableAdapter.ClearBeforeFill = true;
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
            // AddPresidentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridViewPresidents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddPresidentForm";
            this.Text = "Президенти";
            this.Load += new System.EventHandler(this.AddPresidentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.footballDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPresidents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRESIDENTSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FootballDataSet footballDataSet1;
        private FootballDataSetTableAdapters.PRESIDENTSTableAdapter presidentsTableAdapter1;
        private FootballDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridViewPresidents;
        private FootballDataSetTableAdapters.HEADCOACHESTableAdapter hEADCOACHESTableAdapter;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn prNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prDateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pRESIDENTSBindingSource;
    }
}