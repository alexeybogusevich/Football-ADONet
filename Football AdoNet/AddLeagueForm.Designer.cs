namespace Football_AdoNet
{
    partial class AddLeagueForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddLeagueForm));
            this.footballDataSet1 = new Football_AdoNet.FootballDataSet();
            this.leaguesTableAdapter1 = new Football_AdoNet.FootballDataSetTableAdapters.LEAGUESTableAdapter();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lEAGUESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lCountryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.footballDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lEAGUESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // footballDataSet1
            // 
            this.footballDataSet1.DataSetName = "FootballDataSet";
            this.footballDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // leaguesTableAdapter1
            // 
            this.leaguesTableAdapter1.ClearBeforeFill = true;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(69, 16);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(80, 80);
            this.buttonSave.TabIndex = 0;
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
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Видалити";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lNameDataGridViewTextBoxColumn,
            this.lCountryIDDataGridViewTextBoxColumn,
            this.lIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lEAGUESBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(359, 242);
            this.dataGridView1.TabIndex = 2;
            // 
            // lEAGUESBindingSource
            // 
            this.lEAGUESBindingSource.DataMember = "LEAGUES";
            this.lEAGUESBindingSource.DataSource = this.footballDataSet1;
            // 
            // lNameDataGridViewTextBoxColumn
            // 
            this.lNameDataGridViewTextBoxColumn.DataPropertyName = "L_Name";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkOrange;
            this.lNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.lNameDataGridViewTextBoxColumn.HeaderText = "Назва ліги";
            this.lNameDataGridViewTextBoxColumn.Name = "lNameDataGridViewTextBoxColumn";
            this.lNameDataGridViewTextBoxColumn.Width = 316;
            // 
            // lCountryIDDataGridViewTextBoxColumn
            // 
            this.lCountryIDDataGridViewTextBoxColumn.DataPropertyName = "L_CountryID";
            this.lCountryIDDataGridViewTextBoxColumn.HeaderText = "L_CountryID";
            this.lCountryIDDataGridViewTextBoxColumn.Name = "lCountryIDDataGridViewTextBoxColumn";
            this.lCountryIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // lIDDataGridViewTextBoxColumn
            // 
            this.lIDDataGridViewTextBoxColumn.DataPropertyName = "L_ID";
            this.lIDDataGridViewTextBoxColumn.HeaderText = "L_ID";
            this.lIDDataGridViewTextBoxColumn.Name = "lIDDataGridViewTextBoxColumn";
            this.lIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.lIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // AddLeagueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddLeagueForm";
            this.Text = "AddLeagueForm";
            ((System.ComponentModel.ISupportInitialize)(this.footballDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lEAGUESBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FootballDataSet footballDataSet1;
        private FootballDataSetTableAdapters.LEAGUESTableAdapter leaguesTableAdapter1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource lEAGUESBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lCountryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lIDDataGridViewTextBoxColumn;
    }
}