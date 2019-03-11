namespace Football_AdoNet
{
    partial class ClubsTournamentsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClubsTournamentsForm));
            this.t_CLUBSTableAdapter1 = new Football_AdoNet.FootballDataSetTableAdapters.T_CLUBSTableAdapter();
            this.footballDataSet1 = new Football_AdoNet.FootballDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tCLUBSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.cLUBSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLUBSTableAdapter = new Football_AdoNet.FootballDataSetTableAdapters.CLUBSTableAdapter();
            this.tOURNAMENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tOURNAMENTSTableAdapter = new Football_AdoNet.FootballDataSetTableAdapters.TOURNAMENTSTableAdapter();
            this.tMCClubIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tMCTournamentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tMCIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.footballDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCLUBSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLUBSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOURNAMENTSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // t_CLUBSTableAdapter1
            // 
            this.t_CLUBSTableAdapter1.ClearBeforeFill = true;
            // 
            // footballDataSet1
            // 
            this.footballDataSet1.DataSetName = "FootballDataSet";
            this.footballDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tMCClubIDDataGridViewTextBoxColumn,
            this.tMCTournamentIDDataGridViewTextBoxColumn,
            this.tMCIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tCLUBSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(359, 242);
            this.dataGridView1.TabIndex = 0;
            // 
            // tCLUBSBindingSource
            // 
            this.tCLUBSBindingSource.DataMember = "T_CLUBS";
            this.tCLUBSBindingSource.DataSource = this.footballDataSet1;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.White;
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
            this.buttonDelete.BackColor = System.Drawing.Color.White;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(226, 16);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(80, 80);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Видалити";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // cLUBSBindingSource
            // 
            this.cLUBSBindingSource.DataMember = "CLUBS";
            this.cLUBSBindingSource.DataSource = this.footballDataSet1;
            // 
            // cLUBSTableAdapter
            // 
            this.cLUBSTableAdapter.ClearBeforeFill = true;
            // 
            // tOURNAMENTSBindingSource
            // 
            this.tOURNAMENTSBindingSource.DataMember = "TOURNAMENTS";
            this.tOURNAMENTSBindingSource.DataSource = this.footballDataSet1;
            // 
            // tOURNAMENTSTableAdapter
            // 
            this.tOURNAMENTSTableAdapter.ClearBeforeFill = true;
            // 
            // tMCClubIDDataGridViewTextBoxColumn
            // 
            this.tMCClubIDDataGridViewTextBoxColumn.DataPropertyName = "TMC_ClubID";
            this.tMCClubIDDataGridViewTextBoxColumn.DataSource = this.cLUBSBindingSource;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
            this.tMCClubIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.tMCClubIDDataGridViewTextBoxColumn.DisplayMember = "C_Name";
            this.tMCClubIDDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tMCClubIDDataGridViewTextBoxColumn.HeaderText = "Клуб";
            this.tMCClubIDDataGridViewTextBoxColumn.Name = "tMCClubIDDataGridViewTextBoxColumn";
            this.tMCClubIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tMCClubIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tMCClubIDDataGridViewTextBoxColumn.ValueMember = "C_ID";
            this.tMCClubIDDataGridViewTextBoxColumn.Width = 158;
            // 
            // tMCTournamentIDDataGridViewTextBoxColumn
            // 
            this.tMCTournamentIDDataGridViewTextBoxColumn.DataPropertyName = "TMC_TournamentID";
            this.tMCTournamentIDDataGridViewTextBoxColumn.DataSource = this.tOURNAMENTSBindingSource;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
            this.tMCTournamentIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.tMCTournamentIDDataGridViewTextBoxColumn.DisplayMember = "T_Name";
            this.tMCTournamentIDDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tMCTournamentIDDataGridViewTextBoxColumn.HeaderText = "Турнір";
            this.tMCTournamentIDDataGridViewTextBoxColumn.Name = "tMCTournamentIDDataGridViewTextBoxColumn";
            this.tMCTournamentIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tMCTournamentIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tMCTournamentIDDataGridViewTextBoxColumn.ValueMember = "T_ID";
            this.tMCTournamentIDDataGridViewTextBoxColumn.Width = 158;
            // 
            // tMCIDDataGridViewTextBoxColumn
            // 
            this.tMCIDDataGridViewTextBoxColumn.DataPropertyName = "TMC_ID";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.IndianRed;
            this.tMCIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.tMCIDDataGridViewTextBoxColumn.HeaderText = "TMC_ID";
            this.tMCIDDataGridViewTextBoxColumn.Name = "tMCIDDataGridViewTextBoxColumn";
            this.tMCIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // ClubsTournamentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ClubsTournamentsForm";
            this.Text = "ClubsTournamentsForm";
            this.Load += new System.EventHandler(this.ClubsTournamentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.footballDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCLUBSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLUBSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOURNAMENTSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FootballDataSetTableAdapters.T_CLUBSTableAdapter t_CLUBSTableAdapter1;
        private FootballDataSet footballDataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tCLUBSBindingSource;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.BindingSource cLUBSBindingSource;
        private FootballDataSetTableAdapters.CLUBSTableAdapter cLUBSTableAdapter;
        private System.Windows.Forms.BindingSource tOURNAMENTSBindingSource;
        private FootballDataSetTableAdapters.TOURNAMENTSTableAdapter tOURNAMENTSTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn tMCClubIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn tMCTournamentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tMCIDDataGridViewTextBoxColumn;
    }
}