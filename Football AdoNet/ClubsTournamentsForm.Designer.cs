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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClubsTournamentsForm));
            this.dataGridViewTclubs = new System.Windows.Forms.DataGridView();
            this.tMCClubIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cLUBSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.footballDataSet1 = new Football_AdoNet.FootballDataSet();
            this.tMCTournamentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tOURNAMENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tMCIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTTournamentsClubsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.tCLUBSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_CLUBSTableAdapter1 = new Football_AdoNet.FootballDataSetTableAdapters.T_CLUBSTableAdapter();
            this.cLUBSTableAdapter = new Football_AdoNet.FootballDataSetTableAdapters.CLUBSTableAdapter();
            this.tOURNAMENTSTableAdapter = new Football_AdoNet.FootballDataSetTableAdapters.TOURNAMENTSTableAdapter();
            this.dTTournamentsClubsTableAdapter = new Football_AdoNet.FootballDataSetTableAdapters.DTTournamentsClubsTableAdapter();
            this.footballDataSet2 = new Football_AdoNet.FootballDataSet();
            this.comboBoxClubs = new System.Windows.Forms.ComboBox();
            this.cLUBSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTclubs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLUBSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.footballDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOURNAMENTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTTournamentsClubsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCLUBSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.footballDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLUBSBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTclubs
            // 
            this.dataGridViewTclubs.AutoGenerateColumns = false;
            this.dataGridViewTclubs.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTclubs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTclubs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tMCClubIDDataGridViewTextBoxColumn,
            this.tMCTournamentIDDataGridViewTextBoxColumn,
            this.tMCIDDataGridViewTextBoxColumn});
            this.dataGridViewTclubs.DataSource = this.dTTournamentsClubsBindingSource;
            this.dataGridViewTclubs.Location = new System.Drawing.Point(13, 107);
            this.dataGridViewTclubs.Name = "dataGridViewTclubs";
            this.dataGridViewTclubs.ReadOnly = true;
            this.dataGridViewTclubs.Size = new System.Drawing.Size(359, 242);
            this.dataGridViewTclubs.TabIndex = 0;
            this.dataGridViewTclubs.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewTclubs_DataError);
            // 
            // tMCClubIDDataGridViewTextBoxColumn
            // 
            this.tMCClubIDDataGridViewTextBoxColumn.DataPropertyName = "TMC_ClubID";
            this.tMCClubIDDataGridViewTextBoxColumn.DataSource = this.cLUBSBindingSource;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            this.tMCClubIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.tMCClubIDDataGridViewTextBoxColumn.DisplayMember = "C_Name";
            this.tMCClubIDDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tMCClubIDDataGridViewTextBoxColumn.HeaderText = "Назва клубу";
            this.tMCClubIDDataGridViewTextBoxColumn.Name = "tMCClubIDDataGridViewTextBoxColumn";
            this.tMCClubIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.tMCClubIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tMCClubIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tMCClubIDDataGridViewTextBoxColumn.ValueMember = "C_ID";
            this.tMCClubIDDataGridViewTextBoxColumn.Width = 158;
            // 
            // cLUBSBindingSource
            // 
            this.cLUBSBindingSource.DataMember = "CLUBS";
            this.cLUBSBindingSource.DataSource = this.footballDataSet1;
            // 
            // footballDataSet1
            // 
            this.footballDataSet1.DataSetName = "FootballDataSet";
            this.footballDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tMCTournamentIDDataGridViewTextBoxColumn
            // 
            this.tMCTournamentIDDataGridViewTextBoxColumn.DataPropertyName = "TMC_TournamentID";
            this.tMCTournamentIDDataGridViewTextBoxColumn.DataSource = this.tOURNAMENTSBindingSource;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            this.tMCTournamentIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.tMCTournamentIDDataGridViewTextBoxColumn.DisplayMember = "T_Name";
            this.tMCTournamentIDDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tMCTournamentIDDataGridViewTextBoxColumn.HeaderText = "Назва турніру";
            this.tMCTournamentIDDataGridViewTextBoxColumn.Name = "tMCTournamentIDDataGridViewTextBoxColumn";
            this.tMCTournamentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.tMCTournamentIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tMCTournamentIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tMCTournamentIDDataGridViewTextBoxColumn.ValueMember = "T_ID";
            this.tMCTournamentIDDataGridViewTextBoxColumn.Width = 158;
            // 
            // tOURNAMENTSBindingSource
            // 
            this.tOURNAMENTSBindingSource.DataMember = "TOURNAMENTS";
            this.tOURNAMENTSBindingSource.DataSource = this.footballDataSet1;
            // 
            // tMCIDDataGridViewTextBoxColumn
            // 
            this.tMCIDDataGridViewTextBoxColumn.DataPropertyName = "TMC_ID";
            this.tMCIDDataGridViewTextBoxColumn.HeaderText = "TMC_ID";
            this.tMCIDDataGridViewTextBoxColumn.Name = "tMCIDDataGridViewTextBoxColumn";
            this.tMCIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.tMCIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // dTTournamentsClubsBindingSource
            // 
            this.dTTournamentsClubsBindingSource.DataMember = "DTTournamentsClubs";
            this.dTTournamentsClubsBindingSource.DataSource = this.footballDataSet1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.White;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(12, 37);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(136, 37);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Додати";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.White;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(236, 37);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(136, 37);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Видалити";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // tCLUBSBindingSource
            // 
            this.tCLUBSBindingSource.DataMember = "T_CLUBS";
            this.tCLUBSBindingSource.DataSource = this.footballDataSet1;
            // 
            // t_CLUBSTableAdapter1
            // 
            this.t_CLUBSTableAdapter1.ClearBeforeFill = true;
            // 
            // cLUBSTableAdapter
            // 
            this.cLUBSTableAdapter.ClearBeforeFill = true;
            // 
            // tOURNAMENTSTableAdapter
            // 
            this.tOURNAMENTSTableAdapter.ClearBeforeFill = true;
            // 
            // dTTournamentsClubsTableAdapter
            // 
            this.dTTournamentsClubsTableAdapter.ClearBeforeFill = true;
            // 
            // footballDataSet2
            // 
            this.footballDataSet2.DataSetName = "FootballDataSet";
            this.footballDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxClubs
            // 
            this.comboBoxClubs.DataSource = this.cLUBSBindingSource1;
            this.comboBoxClubs.DisplayMember = "C_Name";
            this.comboBoxClubs.FormattingEnabled = true;
            this.comboBoxClubs.Location = new System.Drawing.Point(13, 80);
            this.comboBoxClubs.Name = "comboBoxClubs";
            this.comboBoxClubs.Size = new System.Drawing.Size(135, 21);
            this.comboBoxClubs.TabIndex = 3;
            this.comboBoxClubs.ValueMember = "C_ID";
            // 
            // cLUBSBindingSource1
            // 
            this.cLUBSBindingSource1.DataMember = "CLUBS";
            this.cLUBSBindingSource1.DataSource = this.footballDataSet1;
            // 
            // ClubsTournamentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.comboBoxClubs);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewTclubs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ClubsTournamentsForm";
            this.Text = "Команди-учасники";
            this.Load += new System.EventHandler(this.ClubsTournamentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTclubs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLUBSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.footballDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOURNAMENTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTTournamentsClubsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCLUBSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.footballDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLUBSBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FootballDataSetTableAdapters.T_CLUBSTableAdapter t_CLUBSTableAdapter1;
        private FootballDataSet footballDataSet1;
        private System.Windows.Forms.DataGridView dataGridViewTclubs;
        private System.Windows.Forms.BindingSource tCLUBSBindingSource;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.BindingSource cLUBSBindingSource;
        private FootballDataSetTableAdapters.CLUBSTableAdapter cLUBSTableAdapter;
        private System.Windows.Forms.BindingSource tOURNAMENTSBindingSource;
        private FootballDataSetTableAdapters.TOURNAMENTSTableAdapter tOURNAMENTSTableAdapter;
        private System.Windows.Forms.BindingSource dTTournamentsClubsBindingSource;
        private FootballDataSetTableAdapters.DTTournamentsClubsTableAdapter dTTournamentsClubsTableAdapter;
        private FootballDataSet footballDataSet2;
        private System.Windows.Forms.ComboBox comboBoxClubs;
        private System.Windows.Forms.BindingSource cLUBSBindingSource1;
        private System.Windows.Forms.DataGridViewComboBoxColumn tMCClubIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn tMCTournamentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tMCIDDataGridViewTextBoxColumn;
    }
}