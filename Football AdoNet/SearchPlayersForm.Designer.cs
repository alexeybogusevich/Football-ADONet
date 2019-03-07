namespace Football_AdoNet
{
    partial class SearchPlayersForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PStextBoxClub = new System.Windows.Forms.TextBox();
            this.PStextBoxAge = new System.Windows.Forms.TextBox();
            this.PStextBoxCountry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSearchPlayers = new System.Windows.Forms.Button();
            this.pNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNTRYNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOSNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pClubIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCountryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOSIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pPositionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tMCClubIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tMCTournamentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.footballDataSet1 = new Football_AdoNet.FootballDataSet();
            this.dtSearchPlayersTableAdapter1 = new Football_AdoNet.FootballDataSetTableAdapters.DTSearchPlayersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.footballDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pNameDataGridViewTextBoxColumn,
            this.pDateOfBirthDataGridViewTextBoxColumn,
            this.pNumberDataGridViewTextBoxColumn,
            this.cNameDataGridViewTextBoxColumn,
            this.cNTRYNameDataGridViewTextBoxColumn,
            this.pOSNameDataGridViewTextBoxColumn,
            this.tNameDataGridViewTextBoxColumn,
            this.pClubIDDataGridViewTextBoxColumn,
            this.pCountryIDDataGridViewTextBoxColumn,
            this.pOSIDDataGridViewTextBoxColumn,
            this.tIDDataGridViewTextBoxColumn,
            this.pPositionIDDataGridViewTextBoxColumn,
            this.cIDDataGridViewTextBoxColumn,
            this.tMCClubIDDataGridViewTextBoxColumn,
            this.tMCTournamentIDDataGridViewTextBoxColumn,
            this.pIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(13, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.Size = new System.Drawing.Size(703, 347);
            this.dataGridView1.TabIndex = 0;
            // 
            // PStextBoxClub
            // 
            this.PStextBoxClub.Location = new System.Drawing.Point(13, 42);
            this.PStextBoxClub.Name = "PStextBoxClub";
            this.PStextBoxClub.Size = new System.Drawing.Size(100, 20);
            this.PStextBoxClub.TabIndex = 1;
            // 
            // PStextBoxAge
            // 
            this.PStextBoxAge.Location = new System.Drawing.Point(169, 42);
            this.PStextBoxAge.Name = "PStextBoxAge";
            this.PStextBoxAge.Size = new System.Drawing.Size(100, 20);
            this.PStextBoxAge.TabIndex = 2;
            // 
            // PStextBoxCountry
            // 
            this.PStextBoxCountry.Location = new System.Drawing.Point(333, 42);
            this.PStextBoxCountry.Name = "PStextBoxCountry";
            this.PStextBoxCountry.Size = new System.Drawing.Size(100, 20);
            this.PStextBoxCountry.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Клуб";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Вік";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Національність";
            // 
            // buttonSearchPlayers
            // 
            this.buttonSearchPlayers.Location = new System.Drawing.Point(580, 32);
            this.buttonSearchPlayers.Name = "buttonSearchPlayers";
            this.buttonSearchPlayers.Size = new System.Drawing.Size(95, 38);
            this.buttonSearchPlayers.TabIndex = 7;
            this.buttonSearchPlayers.Text = "Знайти";
            this.buttonSearchPlayers.UseVisualStyleBackColor = true;
            this.buttonSearchPlayers.Click += new System.EventHandler(this.buttonSearchPlayers_Click);
            // 
            // pNameDataGridViewTextBoxColumn
            // 
            this.pNameDataGridViewTextBoxColumn.DataPropertyName = "P_Name";
            this.pNameDataGridViewTextBoxColumn.HeaderText = "ПІБ";
            this.pNameDataGridViewTextBoxColumn.Name = "pNameDataGridViewTextBoxColumn";
            this.pNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pDateOfBirthDataGridViewTextBoxColumn
            // 
            this.pDateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "P_DateOfBirth";
            this.pDateOfBirthDataGridViewTextBoxColumn.HeaderText = "Дата народження";
            this.pDateOfBirthDataGridViewTextBoxColumn.Name = "pDateOfBirthDataGridViewTextBoxColumn";
            this.pDateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pNumberDataGridViewTextBoxColumn
            // 
            this.pNumberDataGridViewTextBoxColumn.DataPropertyName = "P_Number";
            this.pNumberDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.pNumberDataGridViewTextBoxColumn.Name = "pNumberDataGridViewTextBoxColumn";
            this.pNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.pNumberDataGridViewTextBoxColumn.Width = 81;
            // 
            // cNameDataGridViewTextBoxColumn
            // 
            this.cNameDataGridViewTextBoxColumn.DataPropertyName = "C_Name";
            this.cNameDataGridViewTextBoxColumn.HeaderText = "Поточний клуб";
            this.cNameDataGridViewTextBoxColumn.Name = "cNameDataGridViewTextBoxColumn";
            this.cNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cNTRYNameDataGridViewTextBoxColumn
            // 
            this.cNTRYNameDataGridViewTextBoxColumn.DataPropertyName = "CNTRY_Name";
            this.cNTRYNameDataGridViewTextBoxColumn.HeaderText = "Національність";
            this.cNTRYNameDataGridViewTextBoxColumn.Name = "cNTRYNameDataGridViewTextBoxColumn";
            this.cNTRYNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pOSNameDataGridViewTextBoxColumn
            // 
            this.pOSNameDataGridViewTextBoxColumn.DataPropertyName = "POS_Name";
            this.pOSNameDataGridViewTextBoxColumn.HeaderText = "Позиція";
            this.pOSNameDataGridViewTextBoxColumn.Name = "pOSNameDataGridViewTextBoxColumn";
            this.pOSNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tNameDataGridViewTextBoxColumn
            // 
            this.tNameDataGridViewTextBoxColumn.DataPropertyName = "T_Name";
            this.tNameDataGridViewTextBoxColumn.HeaderText = "Турнір";
            this.tNameDataGridViewTextBoxColumn.Name = "tNameDataGridViewTextBoxColumn";
            this.tNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pClubIDDataGridViewTextBoxColumn
            // 
            this.pClubIDDataGridViewTextBoxColumn.DataPropertyName = "P_ClubID";
            this.pClubIDDataGridViewTextBoxColumn.HeaderText = "P_ClubID";
            this.pClubIDDataGridViewTextBoxColumn.Name = "pClubIDDataGridViewTextBoxColumn";
            this.pClubIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pClubIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pCountryIDDataGridViewTextBoxColumn
            // 
            this.pCountryIDDataGridViewTextBoxColumn.DataPropertyName = "P_CountryID";
            this.pCountryIDDataGridViewTextBoxColumn.HeaderText = "P_CountryID";
            this.pCountryIDDataGridViewTextBoxColumn.Name = "pCountryIDDataGridViewTextBoxColumn";
            this.pCountryIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pCountryIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pOSIDDataGridViewTextBoxColumn
            // 
            this.pOSIDDataGridViewTextBoxColumn.DataPropertyName = "POS_ID";
            this.pOSIDDataGridViewTextBoxColumn.HeaderText = "POS_ID";
            this.pOSIDDataGridViewTextBoxColumn.Name = "pOSIDDataGridViewTextBoxColumn";
            this.pOSIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pOSIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // tIDDataGridViewTextBoxColumn
            // 
            this.tIDDataGridViewTextBoxColumn.DataPropertyName = "T_ID";
            this.tIDDataGridViewTextBoxColumn.HeaderText = "T_ID";
            this.tIDDataGridViewTextBoxColumn.Name = "tIDDataGridViewTextBoxColumn";
            this.tIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.tIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pPositionIDDataGridViewTextBoxColumn
            // 
            this.pPositionIDDataGridViewTextBoxColumn.DataPropertyName = "P_PositionID";
            this.pPositionIDDataGridViewTextBoxColumn.HeaderText = "P_PositionID";
            this.pPositionIDDataGridViewTextBoxColumn.Name = "pPositionIDDataGridViewTextBoxColumn";
            this.pPositionIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pPositionIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cIDDataGridViewTextBoxColumn
            // 
            this.cIDDataGridViewTextBoxColumn.DataPropertyName = "C_ID";
            this.cIDDataGridViewTextBoxColumn.HeaderText = "C_ID";
            this.cIDDataGridViewTextBoxColumn.Name = "cIDDataGridViewTextBoxColumn";
            this.cIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // tMCClubIDDataGridViewTextBoxColumn
            // 
            this.tMCClubIDDataGridViewTextBoxColumn.DataPropertyName = "TMC_ClubID";
            this.tMCClubIDDataGridViewTextBoxColumn.HeaderText = "TMC_ClubID";
            this.tMCClubIDDataGridViewTextBoxColumn.Name = "tMCClubIDDataGridViewTextBoxColumn";
            this.tMCClubIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.tMCClubIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // tMCTournamentIDDataGridViewTextBoxColumn
            // 
            this.tMCTournamentIDDataGridViewTextBoxColumn.DataPropertyName = "TMC_TournamentID";
            this.tMCTournamentIDDataGridViewTextBoxColumn.HeaderText = "TMC_TournamentID";
            this.tMCTournamentIDDataGridViewTextBoxColumn.Name = "tMCTournamentIDDataGridViewTextBoxColumn";
            this.tMCTournamentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.tMCTournamentIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pIDDataGridViewTextBoxColumn
            // 
            this.pIDDataGridViewTextBoxColumn.DataPropertyName = "P_ID";
            this.pIDDataGridViewTextBoxColumn.HeaderText = "P_ID";
            this.pIDDataGridViewTextBoxColumn.Name = "pIDDataGridViewTextBoxColumn";
            this.pIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "DTSearchPlayers";
            this.bindingSource1.DataSource = this.footballDataSet1;
            // 
            // footballDataSet1
            // 
            this.footballDataSet1.DataSetName = "FootballDataSet";
            this.footballDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtSearchPlayersTableAdapter1
            // 
            this.dtSearchPlayersTableAdapter1.ClearBeforeFill = true;
            // 
            // SearchPlayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 450);
            this.Controls.Add(this.buttonSearchPlayers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PStextBoxCountry);
            this.Controls.Add(this.PStextBoxAge);
            this.Controls.Add(this.PStextBoxClub);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SearchPlayersForm";
            this.Text = "Пошук гравців";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.footballDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private FootballDataSet footballDataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private FootballDataSetTableAdapters.DTSearchPlayersTableAdapter dtSearchPlayersTableAdapter1;
        private System.Windows.Forms.TextBox PStextBoxClub;
        private System.Windows.Forms.TextBox PStextBoxAge;
        private System.Windows.Forms.TextBox PStextBoxCountry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSearchPlayers;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNTRYNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOSNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pClubIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCountryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOSIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pPositionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tMCClubIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tMCTournamentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIDDataGridViewTextBoxColumn;
    }
}