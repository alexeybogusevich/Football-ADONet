namespace Football_AdoNet
{
    partial class SearchClubsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchClubsForm));
            this.footballDataSet1 = new Football_AdoNet.FootballDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dtSearchClubsTableAdapter1 = new Football_AdoNet.FootballDataSetTableAdapters.DTSearchClubsTableAdapter();
            this.dataGridViewSearchClubs = new System.Windows.Forms.DataGridView();
            this.cNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNTRYNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hCNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDateOfFoundationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHeadCoachIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPresidentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLeagueIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCityIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTCountryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNTRYIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hCIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CStextBoxCountry = new System.Windows.Forms.TextBox();
            this.CStextBoxTournament = new System.Windows.Forms.TextBox();
            this.CStextBoxDate = new System.Windows.Forms.TextBox();
            this.buttonSearchClubs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.footballDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchClubs)).BeginInit();
            this.SuspendLayout();
            // 
            // footballDataSet1
            // 
            this.footballDataSet1.DataSetName = "FootballDataSet";
            this.footballDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "DTSearchClubs";
            this.bindingSource1.DataSource = this.footballDataSet1;
            // 
            // dtSearchClubsTableAdapter1
            // 
            this.dtSearchClubsTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridViewSearchClubs
            // 
            this.dataGridViewSearchClubs.AutoGenerateColumns = false;
            this.dataGridViewSearchClubs.BackgroundColor = System.Drawing.Color.Navy;
            this.dataGridViewSearchClubs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchClubs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNameDataGridViewTextBoxColumn,
            this.cTNameDataGridViewTextBoxColumn,
            this.cNTRYNameDataGridViewTextBoxColumn,
            this.lNameDataGridViewTextBoxColumn,
            this.hCNameDataGridViewTextBoxColumn,
            this.prNameDataGridViewTextBoxColumn,
            this.cDateOfFoundationDataGridViewTextBoxColumn,
            this.cIDDataGridViewTextBoxColumn,
            this.cHeadCoachIDDataGridViewTextBoxColumn,
            this.cPresidentIDDataGridViewTextBoxColumn,
            this.cLeagueIDDataGridViewTextBoxColumn,
            this.cCityIDDataGridViewTextBoxColumn,
            this.cTCountryIDDataGridViewTextBoxColumn,
            this.cTIDDataGridViewTextBoxColumn,
            this.cNTRYIDDataGridViewTextBoxColumn,
            this.hCIDDataGridViewTextBoxColumn,
            this.prIDDataGridViewTextBoxColumn,
            this.lIDDataGridViewTextBoxColumn});
            this.dataGridViewSearchClubs.DataSource = this.bindingSource1;
            this.dataGridViewSearchClubs.Location = new System.Drawing.Point(13, 109);
            this.dataGridViewSearchClubs.Name = "dataGridViewSearchClubs";
            this.dataGridViewSearchClubs.ReadOnly = true;
            this.dataGridViewSearchClubs.RowHeadersWidth = 20;
            this.dataGridViewSearchClubs.Size = new System.Drawing.Size(703, 329);
            this.dataGridViewSearchClubs.TabIndex = 0;
            // 
            // cNameDataGridViewTextBoxColumn
            // 
            this.cNameDataGridViewTextBoxColumn.DataPropertyName = "C_Name";
            this.cNameDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.cNameDataGridViewTextBoxColumn.Name = "cNameDataGridViewTextBoxColumn";
            this.cNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cTNameDataGridViewTextBoxColumn
            // 
            this.cTNameDataGridViewTextBoxColumn.DataPropertyName = "CT_Name";
            this.cTNameDataGridViewTextBoxColumn.HeaderText = "Місто";
            this.cTNameDataGridViewTextBoxColumn.Name = "cTNameDataGridViewTextBoxColumn";
            this.cTNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cNTRYNameDataGridViewTextBoxColumn
            // 
            this.cNTRYNameDataGridViewTextBoxColumn.DataPropertyName = "CNTRY_Name";
            this.cNTRYNameDataGridViewTextBoxColumn.HeaderText = "Країна";
            this.cNTRYNameDataGridViewTextBoxColumn.Name = "cNTRYNameDataGridViewTextBoxColumn";
            this.cNTRYNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lNameDataGridViewTextBoxColumn
            // 
            this.lNameDataGridViewTextBoxColumn.DataPropertyName = "L_Name";
            this.lNameDataGridViewTextBoxColumn.HeaderText = "Ліга";
            this.lNameDataGridViewTextBoxColumn.Name = "lNameDataGridViewTextBoxColumn";
            this.lNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hCNameDataGridViewTextBoxColumn
            // 
            this.hCNameDataGridViewTextBoxColumn.DataPropertyName = "HC_Name";
            this.hCNameDataGridViewTextBoxColumn.HeaderText = "Тренер";
            this.hCNameDataGridViewTextBoxColumn.Name = "hCNameDataGridViewTextBoxColumn";
            this.hCNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prNameDataGridViewTextBoxColumn
            // 
            this.prNameDataGridViewTextBoxColumn.DataPropertyName = "Pr_Name";
            this.prNameDataGridViewTextBoxColumn.HeaderText = "Президент";
            this.prNameDataGridViewTextBoxColumn.Name = "prNameDataGridViewTextBoxColumn";
            this.prNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cDateOfFoundationDataGridViewTextBoxColumn
            // 
            this.cDateOfFoundationDataGridViewTextBoxColumn.DataPropertyName = "C_DateOfFoundation";
            this.cDateOfFoundationDataGridViewTextBoxColumn.HeaderText = "Рік заснування";
            this.cDateOfFoundationDataGridViewTextBoxColumn.Name = "cDateOfFoundationDataGridViewTextBoxColumn";
            this.cDateOfFoundationDataGridViewTextBoxColumn.ReadOnly = true;
            this.cDateOfFoundationDataGridViewTextBoxColumn.Width = 81;
            // 
            // cIDDataGridViewTextBoxColumn
            // 
            this.cIDDataGridViewTextBoxColumn.DataPropertyName = "C_ID";
            this.cIDDataGridViewTextBoxColumn.HeaderText = "C_ID";
            this.cIDDataGridViewTextBoxColumn.Name = "cIDDataGridViewTextBoxColumn";
            this.cIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cHeadCoachIDDataGridViewTextBoxColumn
            // 
            this.cHeadCoachIDDataGridViewTextBoxColumn.DataPropertyName = "C_HeadCoachID";
            this.cHeadCoachIDDataGridViewTextBoxColumn.HeaderText = "C_HeadCoachID";
            this.cHeadCoachIDDataGridViewTextBoxColumn.Name = "cHeadCoachIDDataGridViewTextBoxColumn";
            this.cHeadCoachIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cHeadCoachIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cPresidentIDDataGridViewTextBoxColumn
            // 
            this.cPresidentIDDataGridViewTextBoxColumn.DataPropertyName = "C_PresidentID";
            this.cPresidentIDDataGridViewTextBoxColumn.HeaderText = "C_PresidentID";
            this.cPresidentIDDataGridViewTextBoxColumn.Name = "cPresidentIDDataGridViewTextBoxColumn";
            this.cPresidentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPresidentIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cLeagueIDDataGridViewTextBoxColumn
            // 
            this.cLeagueIDDataGridViewTextBoxColumn.DataPropertyName = "C_LeagueID";
            this.cLeagueIDDataGridViewTextBoxColumn.HeaderText = "C_LeagueID";
            this.cLeagueIDDataGridViewTextBoxColumn.Name = "cLeagueIDDataGridViewTextBoxColumn";
            this.cLeagueIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cLeagueIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cCityIDDataGridViewTextBoxColumn
            // 
            this.cCityIDDataGridViewTextBoxColumn.DataPropertyName = "C_CityID";
            this.cCityIDDataGridViewTextBoxColumn.HeaderText = "C_CityID";
            this.cCityIDDataGridViewTextBoxColumn.Name = "cCityIDDataGridViewTextBoxColumn";
            this.cCityIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cCityIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cTCountryIDDataGridViewTextBoxColumn
            // 
            this.cTCountryIDDataGridViewTextBoxColumn.DataPropertyName = "CT_CountryID";
            this.cTCountryIDDataGridViewTextBoxColumn.HeaderText = "CT_CountryID";
            this.cTCountryIDDataGridViewTextBoxColumn.Name = "cTCountryIDDataGridViewTextBoxColumn";
            this.cTCountryIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cTCountryIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cTIDDataGridViewTextBoxColumn
            // 
            this.cTIDDataGridViewTextBoxColumn.DataPropertyName = "CT_ID";
            this.cTIDDataGridViewTextBoxColumn.HeaderText = "CT_ID";
            this.cTIDDataGridViewTextBoxColumn.Name = "cTIDDataGridViewTextBoxColumn";
            this.cTIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cTIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cNTRYIDDataGridViewTextBoxColumn
            // 
            this.cNTRYIDDataGridViewTextBoxColumn.DataPropertyName = "CNTRY_ID";
            this.cNTRYIDDataGridViewTextBoxColumn.HeaderText = "CNTRY_ID";
            this.cNTRYIDDataGridViewTextBoxColumn.Name = "cNTRYIDDataGridViewTextBoxColumn";
            this.cNTRYIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cNTRYIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // hCIDDataGridViewTextBoxColumn
            // 
            this.hCIDDataGridViewTextBoxColumn.DataPropertyName = "HC_ID";
            this.hCIDDataGridViewTextBoxColumn.HeaderText = "HC_ID";
            this.hCIDDataGridViewTextBoxColumn.Name = "hCIDDataGridViewTextBoxColumn";
            this.hCIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.hCIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // prIDDataGridViewTextBoxColumn
            // 
            this.prIDDataGridViewTextBoxColumn.DataPropertyName = "Pr_ID";
            this.prIDDataGridViewTextBoxColumn.HeaderText = "Pr_ID";
            this.prIDDataGridViewTextBoxColumn.Name = "prIDDataGridViewTextBoxColumn";
            this.prIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.prIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // lIDDataGridViewTextBoxColumn
            // 
            this.lIDDataGridViewTextBoxColumn.DataPropertyName = "L_ID";
            this.lIDDataGridViewTextBoxColumn.HeaderText = "L_ID";
            this.lIDDataGridViewTextBoxColumn.Name = "lIDDataGridViewTextBoxColumn";
            this.lIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.lIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // CStextBoxCountry
            // 
            this.CStextBoxCountry.Location = new System.Drawing.Point(13, 50);
            this.CStextBoxCountry.Name = "CStextBoxCountry";
            this.CStextBoxCountry.Size = new System.Drawing.Size(140, 20);
            this.CStextBoxCountry.TabIndex = 1;
            // 
            // CStextBoxTournament
            // 
            this.CStextBoxTournament.Location = new System.Drawing.Point(188, 50);
            this.CStextBoxTournament.Name = "CStextBoxTournament";
            this.CStextBoxTournament.Size = new System.Drawing.Size(140, 20);
            this.CStextBoxTournament.TabIndex = 2;
            // 
            // CStextBoxDate
            // 
            this.CStextBoxDate.Location = new System.Drawing.Point(363, 50);
            this.CStextBoxDate.Name = "CStextBoxDate";
            this.CStextBoxDate.Size = new System.Drawing.Size(140, 20);
            this.CStextBoxDate.TabIndex = 3;
            // 
            // buttonSearchClubs
            // 
            this.buttonSearchClubs.BackColor = System.Drawing.Color.Navy;
            this.buttonSearchClubs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearchClubs.ForeColor = System.Drawing.Color.White;
            this.buttonSearchClubs.Location = new System.Drawing.Point(605, 10);
            this.buttonSearchClubs.Name = "buttonSearchClubs";
            this.buttonSearchClubs.Size = new System.Drawing.Size(111, 91);
            this.buttonSearchClubs.TabIndex = 4;
            this.buttonSearchClubs.Text = "Знайти";
            this.buttonSearchClubs.UseVisualStyleBackColor = false;
            this.buttonSearchClubs.Click += new System.EventHandler(this.buttonSearchClubs_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(63, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Країна";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(235, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Турнір";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(360, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "      Рік заснування";
            // 
            // SearchClubsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(728, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSearchClubs);
            this.Controls.Add(this.CStextBoxDate);
            this.Controls.Add(this.CStextBoxTournament);
            this.Controls.Add(this.CStextBoxCountry);
            this.Controls.Add(this.dataGridViewSearchClubs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SearchClubsForm";
            this.Text = "Пошук клубів";
            ((System.ComponentModel.ISupportInitialize)(this.footballDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchClubs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FootballDataSet footballDataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private FootballDataSetTableAdapters.DTSearchClubsTableAdapter dtSearchClubsTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridViewSearchClubs;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNTRYNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hCNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDateOfFoundationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHeadCoachIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPresidentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLeagueIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCityIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTCountryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNTRYIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hCIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox CStextBoxCountry;
        private System.Windows.Forms.TextBox CStextBoxTournament;
        private System.Windows.Forms.TextBox CStextBoxDate;
        private System.Windows.Forms.Button buttonSearchClubs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}