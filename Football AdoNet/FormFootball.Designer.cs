﻿namespace Football_AdoNet
{
    partial class FormFootball
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFootball));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PLAYERS = new System.Windows.Forms.TabPage();
            this.buttonSearchPlayers = new System.Windows.Forms.Button();
            this.buttonDeletePlayers = new System.Windows.Forms.Button();
            this.buttonSavePlayers = new System.Windows.Forms.Button();
            this.dataGridViewPlayers = new System.Windows.Forms.DataGridView();
            this.pIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_ClubID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cLUBSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.footballDataSet = new Football_AdoNet.FootballDataSet();
            this.pNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_CountryID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cOUNTRIESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.P_PositionID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pOSITIONSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pCountryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pClubIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pPositionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLAYERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CLUBS = new System.Windows.Forms.TabPage();
            this.buttonSearchClubs = new System.Windows.Forms.Button();
            this.buttonDeleteClubs = new System.Windows.Forms.Button();
            this.buttonSaveClubs = new System.Windows.Forms.Button();
            this.dataGridViewClubs = new System.Windows.Forms.DataGridView();
            this.cNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_CityID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cITIESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cStadiumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_HeadCoachID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.hEADCOACHESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.C_PresidentID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pRESIDENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cDateOfFoundationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBudgetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_LeagueID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.lEAGUESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cCityIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHeadCoachIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLeagueIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPresidentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOURNAMENTS = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridViewTournaments = new System.Windows.Forms.DataGridView();
            this.tNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T_TypeID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tTYPESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.T_AssociationID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.aSSOCIATIONSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tAssociationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOURNAMENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pLAYERSTableAdapter = new Football_AdoNet.FootballDataSetTableAdapters.PLAYERSTableAdapter();
            this.cOUNTRIESTableAdapter = new Football_AdoNet.FootballDataSetTableAdapters.COUNTRIESTableAdapter();
            this.cLUBSTableAdapter = new Football_AdoNet.FootballDataSetTableAdapters.CLUBSTableAdapter();
            this.pOSITIONSTableAdapter = new Football_AdoNet.FootballDataSetTableAdapters.POSITIONSTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.queriesTableAdapter1 = new Football_AdoNet.FootballDataSetTableAdapters.QueriesTableAdapter();
            this.cITIESTableAdapter = new Football_AdoNet.FootballDataSetTableAdapters.CITIESTableAdapter();
            this.hEADCOACHESTableAdapter = new Football_AdoNet.FootballDataSetTableAdapters.HEADCOACHESTableAdapter();
            this.lEAGUESTableAdapter = new Football_AdoNet.FootballDataSetTableAdapters.LEAGUESTableAdapter();
            this.pRESIDENTSTableAdapter = new Football_AdoNet.FootballDataSetTableAdapters.PRESIDENTSTableAdapter();
            this.tOURNAMENTSTableAdapter = new Football_AdoNet.FootballDataSetTableAdapters.TOURNAMENTSTableAdapter();
            this.aSSOCIATIONSTableAdapter = new Football_AdoNet.FootballDataSetTableAdapters.ASSOCIATIONSTableAdapter();
            this.t_TYPESTableAdapter = new Football_AdoNet.FootballDataSetTableAdapters.T_TYPESTableAdapter();
            this.associationsTableAdapter1 = new Football_AdoNet.FootballDataSetTableAdapters.ASSOCIATIONSTableAdapter();
            this.footballDataSet1 = new Football_AdoNet.FootballDataSet();
            this.tabControl1.SuspendLayout();
            this.PLAYERS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLUBSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.footballDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOUNTRIESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSITIONSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLAYERSBindingSource)).BeginInit();
            this.CLUBS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClubs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cITIESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hEADCOACHESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRESIDENTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lEAGUESBindingSource)).BeginInit();
            this.TOURNAMENTS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTournaments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTYPESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSSOCIATIONSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOURNAMENTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.footballDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PLAYERS);
            this.tabControl1.Controls.Add(this.CLUBS);
            this.tabControl1.Controls.Add(this.TOURNAMENTS);
            this.tabControl1.Location = new System.Drawing.Point(12, 84);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(704, 354);
            this.tabControl1.TabIndex = 0;
            // 
            // PLAYERS
            // 
            this.PLAYERS.Controls.Add(this.buttonSearchPlayers);
            this.PLAYERS.Controls.Add(this.buttonDeletePlayers);
            this.PLAYERS.Controls.Add(this.buttonSavePlayers);
            this.PLAYERS.Controls.Add(this.dataGridViewPlayers);
            this.PLAYERS.Location = new System.Drawing.Point(4, 22);
            this.PLAYERS.Name = "PLAYERS";
            this.PLAYERS.Padding = new System.Windows.Forms.Padding(3);
            this.PLAYERS.Size = new System.Drawing.Size(696, 328);
            this.PLAYERS.TabIndex = 0;
            this.PLAYERS.Text = "Гравці";
            this.PLAYERS.UseVisualStyleBackColor = true;
            // 
            // buttonSearchPlayers
            // 
            this.buttonSearchPlayers.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonSearchPlayers.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchPlayers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonSearchPlayers.Location = new System.Drawing.Point(523, 13);
            this.buttonSearchPlayers.Name = "buttonSearchPlayers";
            this.buttonSearchPlayers.Size = new System.Drawing.Size(95, 38);
            this.buttonSearchPlayers.TabIndex = 3;
            this.buttonSearchPlayers.Text = "Пошук";
            this.buttonSearchPlayers.UseVisualStyleBackColor = false;
            this.buttonSearchPlayers.Click += new System.EventHandler(this.buttonSearchPlayers_Click);
            // 
            // buttonDeletePlayers
            // 
            this.buttonDeletePlayers.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonDeletePlayers.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeletePlayers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonDeletePlayers.Location = new System.Drawing.Point(295, 13);
            this.buttonDeletePlayers.Name = "buttonDeletePlayers";
            this.buttonDeletePlayers.Size = new System.Drawing.Size(95, 38);
            this.buttonDeletePlayers.TabIndex = 2;
            this.buttonDeletePlayers.Text = "Видалити";
            this.buttonDeletePlayers.UseVisualStyleBackColor = false;
            this.buttonDeletePlayers.Click += new System.EventHandler(this.buttonDeletePlayers_Click);
            // 
            // buttonSavePlayers
            // 
            this.buttonSavePlayers.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonSavePlayers.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSavePlayers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonSavePlayers.Location = new System.Drawing.Point(61, 13);
            this.buttonSavePlayers.Name = "buttonSavePlayers";
            this.buttonSavePlayers.Size = new System.Drawing.Size(95, 38);
            this.buttonSavePlayers.TabIndex = 1;
            this.buttonSavePlayers.Text = "Зберегти";
            this.buttonSavePlayers.UseVisualStyleBackColor = false;
            this.buttonSavePlayers.Click += new System.EventHandler(this.buttonSavePlayers_Click);
            // 
            // dataGridViewPlayers
            // 
            this.dataGridViewPlayers.AutoGenerateColumns = false;
            this.dataGridViewPlayers.BackgroundColor = System.Drawing.Color.Navy;
            this.dataGridViewPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pIDDataGridViewTextBoxColumn,
            this.pNameDataGridViewTextBoxColumn,
            this.pDateOfBirthDataGridViewTextBoxColumn,
            this.P_ClubID,
            this.pNumberDataGridViewTextBoxColumn,
            this.P_CountryID,
            this.P_PositionID,
            this.pCountryIDDataGridViewTextBoxColumn,
            this.pClubIDDataGridViewTextBoxColumn,
            this.pPositionIDDataGridViewTextBoxColumn});
            this.dataGridViewPlayers.DataSource = this.pLAYERSBindingSource;
            this.dataGridViewPlayers.Location = new System.Drawing.Point(0, 63);
            this.dataGridViewPlayers.Name = "dataGridViewPlayers";
            this.dataGridViewPlayers.RowHeadersWidth = 20;
            this.dataGridViewPlayers.Size = new System.Drawing.Size(696, 265);
            this.dataGridViewPlayers.TabIndex = 0;
            // 
            // pIDDataGridViewTextBoxColumn
            // 
            this.pIDDataGridViewTextBoxColumn.DataPropertyName = "P_ID";
            this.pIDDataGridViewTextBoxColumn.HeaderText = "P_ID";
            this.pIDDataGridViewTextBoxColumn.Name = "pIDDataGridViewTextBoxColumn";
            this.pIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pNameDataGridViewTextBoxColumn
            // 
            this.pNameDataGridViewTextBoxColumn.DataPropertyName = "P_Name";
            this.pNameDataGridViewTextBoxColumn.HeaderText = "ПІБ";
            this.pNameDataGridViewTextBoxColumn.Name = "pNameDataGridViewTextBoxColumn";
            // 
            // pDateOfBirthDataGridViewTextBoxColumn
            // 
            this.pDateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "P_DateOfBirth";
            this.pDateOfBirthDataGridViewTextBoxColumn.HeaderText = "Дата народження";
            this.pDateOfBirthDataGridViewTextBoxColumn.Name = "pDateOfBirthDataGridViewTextBoxColumn";
            // 
            // P_ClubID
            // 
            this.P_ClubID.DataPropertyName = "P_ClubID";
            this.P_ClubID.DataSource = this.cLUBSBindingSource;
            this.P_ClubID.DisplayMember = "C_Name";
            this.P_ClubID.HeaderText = "Клуб";
            this.P_ClubID.Name = "P_ClubID";
            this.P_ClubID.ValueMember = "C_ID";
            // 
            // cLUBSBindingSource
            // 
            this.cLUBSBindingSource.DataMember = "CLUBS";
            this.cLUBSBindingSource.DataSource = this.footballDataSet;
            // 
            // footballDataSet
            // 
            this.footballDataSet.DataSetName = "FootballDataSet";
            this.footballDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pNumberDataGridViewTextBoxColumn
            // 
            this.pNumberDataGridViewTextBoxColumn.DataPropertyName = "P_Number";
            this.pNumberDataGridViewTextBoxColumn.HeaderText = "Ігровий номер";
            this.pNumberDataGridViewTextBoxColumn.Name = "pNumberDataGridViewTextBoxColumn";
            // 
            // P_CountryID
            // 
            this.P_CountryID.DataPropertyName = "P_CountryID";
            this.P_CountryID.DataSource = this.cOUNTRIESBindingSource;
            this.P_CountryID.DisplayMember = "CNTRY_Name";
            this.P_CountryID.HeaderText = "Національність";
            this.P_CountryID.Name = "P_CountryID";
            this.P_CountryID.ValueMember = "CNTRY_ID";
            // 
            // cOUNTRIESBindingSource
            // 
            this.cOUNTRIESBindingSource.DataMember = "COUNTRIES";
            this.cOUNTRIESBindingSource.DataSource = this.footballDataSet;
            // 
            // P_PositionID
            // 
            this.P_PositionID.DataPropertyName = "P_PositionID";
            this.P_PositionID.DataSource = this.pOSITIONSBindingSource;
            this.P_PositionID.DisplayMember = "POS_Name";
            this.P_PositionID.HeaderText = "Позиція";
            this.P_PositionID.Name = "P_PositionID";
            this.P_PositionID.ValueMember = "POS_ID";
            // 
            // pOSITIONSBindingSource
            // 
            this.pOSITIONSBindingSource.DataMember = "POSITIONS";
            this.pOSITIONSBindingSource.DataSource = this.footballDataSet;
            // 
            // pCountryIDDataGridViewTextBoxColumn
            // 
            this.pCountryIDDataGridViewTextBoxColumn.DataPropertyName = "P_CountryID";
            this.pCountryIDDataGridViewTextBoxColumn.HeaderText = "P_CountryID";
            this.pCountryIDDataGridViewTextBoxColumn.Name = "pCountryIDDataGridViewTextBoxColumn";
            this.pCountryIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pClubIDDataGridViewTextBoxColumn
            // 
            this.pClubIDDataGridViewTextBoxColumn.DataPropertyName = "P_ClubID";
            this.pClubIDDataGridViewTextBoxColumn.HeaderText = "P_ClubID";
            this.pClubIDDataGridViewTextBoxColumn.Name = "pClubIDDataGridViewTextBoxColumn";
            this.pClubIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pPositionIDDataGridViewTextBoxColumn
            // 
            this.pPositionIDDataGridViewTextBoxColumn.DataPropertyName = "P_PositionID";
            this.pPositionIDDataGridViewTextBoxColumn.HeaderText = "P_PositionID";
            this.pPositionIDDataGridViewTextBoxColumn.Name = "pPositionIDDataGridViewTextBoxColumn";
            this.pPositionIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pLAYERSBindingSource
            // 
            this.pLAYERSBindingSource.DataMember = "PLAYERS";
            this.pLAYERSBindingSource.DataSource = this.footballDataSet;
            // 
            // CLUBS
            // 
            this.CLUBS.Controls.Add(this.buttonSearchClubs);
            this.CLUBS.Controls.Add(this.buttonDeleteClubs);
            this.CLUBS.Controls.Add(this.buttonSaveClubs);
            this.CLUBS.Controls.Add(this.dataGridViewClubs);
            this.CLUBS.Location = new System.Drawing.Point(4, 22);
            this.CLUBS.Name = "CLUBS";
            this.CLUBS.Padding = new System.Windows.Forms.Padding(3);
            this.CLUBS.Size = new System.Drawing.Size(696, 328);
            this.CLUBS.TabIndex = 1;
            this.CLUBS.Text = "Клуби";
            this.CLUBS.UseVisualStyleBackColor = true;
            // 
            // buttonSearchClubs
            // 
            this.buttonSearchClubs.AutoEllipsis = true;
            this.buttonSearchClubs.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonSearchClubs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonSearchClubs.Location = new System.Drawing.Point(523, 13);
            this.buttonSearchClubs.Name = "buttonSearchClubs";
            this.buttonSearchClubs.Size = new System.Drawing.Size(95, 38);
            this.buttonSearchClubs.TabIndex = 3;
            this.buttonSearchClubs.Text = "Пошук";
            this.buttonSearchClubs.UseVisualStyleBackColor = false;
            this.buttonSearchClubs.Click += new System.EventHandler(this.buttonSearchClubs_Click);
            // 
            // buttonDeleteClubs
            // 
            this.buttonDeleteClubs.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonDeleteClubs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonDeleteClubs.Location = new System.Drawing.Point(295, 13);
            this.buttonDeleteClubs.Name = "buttonDeleteClubs";
            this.buttonDeleteClubs.Size = new System.Drawing.Size(95, 38);
            this.buttonDeleteClubs.TabIndex = 2;
            this.buttonDeleteClubs.Text = "Видалити";
            this.buttonDeleteClubs.UseVisualStyleBackColor = false;
            this.buttonDeleteClubs.Click += new System.EventHandler(this.buttonDeleteClubs_Click);
            // 
            // buttonSaveClubs
            // 
            this.buttonSaveClubs.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonSaveClubs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonSaveClubs.Location = new System.Drawing.Point(61, 13);
            this.buttonSaveClubs.Name = "buttonSaveClubs";
            this.buttonSaveClubs.Size = new System.Drawing.Size(95, 38);
            this.buttonSaveClubs.TabIndex = 1;
            this.buttonSaveClubs.Text = "Зберегти";
            this.buttonSaveClubs.UseVisualStyleBackColor = false;
            this.buttonSaveClubs.Click += new System.EventHandler(this.buttonSaveClubs_Click);
            // 
            // dataGridViewClubs
            // 
            this.dataGridViewClubs.AutoGenerateColumns = false;
            this.dataGridViewClubs.BackgroundColor = System.Drawing.Color.Navy;
            this.dataGridViewClubs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClubs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNameDataGridViewTextBoxColumn,
            this.C_CityID,
            this.cStadiumDataGridViewTextBoxColumn,
            this.C_HeadCoachID,
            this.C_PresidentID,
            this.cDateOfFoundationDataGridViewTextBoxColumn,
            this.cBudgetDataGridViewTextBoxColumn,
            this.C_LeagueID,
            this.cCityIDDataGridViewTextBoxColumn,
            this.cHeadCoachIDDataGridViewTextBoxColumn,
            this.cLeagueIDDataGridViewTextBoxColumn,
            this.cPresidentIDDataGridViewTextBoxColumn,
            this.cIDDataGridViewTextBoxColumn});
            this.dataGridViewClubs.DataSource = this.cLUBSBindingSource;
            this.dataGridViewClubs.Location = new System.Drawing.Point(0, 63);
            this.dataGridViewClubs.Name = "dataGridViewClubs";
            this.dataGridViewClubs.RowHeadersWidth = 20;
            this.dataGridViewClubs.Size = new System.Drawing.Size(693, 265);
            this.dataGridViewClubs.TabIndex = 0;
            // 
            // cNameDataGridViewTextBoxColumn
            // 
            this.cNameDataGridViewTextBoxColumn.DataPropertyName = "C_Name";
            this.cNameDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.cNameDataGridViewTextBoxColumn.Name = "cNameDataGridViewTextBoxColumn";
            // 
            // C_CityID
            // 
            this.C_CityID.DataPropertyName = "C_CityID";
            this.C_CityID.DataSource = this.cITIESBindingSource;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.C_CityID.DefaultCellStyle = dataGridViewCellStyle1;
            this.C_CityID.DisplayMember = "CT_Name";
            this.C_CityID.HeaderText = "Місто";
            this.C_CityID.Name = "C_CityID";
            this.C_CityID.ValueMember = "CT_ID";
            // 
            // cITIESBindingSource
            // 
            this.cITIESBindingSource.DataMember = "CITIES";
            this.cITIESBindingSource.DataSource = this.footballDataSet;
            // 
            // cStadiumDataGridViewTextBoxColumn
            // 
            this.cStadiumDataGridViewTextBoxColumn.DataPropertyName = "C_Stadium";
            this.cStadiumDataGridViewTextBoxColumn.HeaderText = "Стадіон";
            this.cStadiumDataGridViewTextBoxColumn.Name = "cStadiumDataGridViewTextBoxColumn";
            // 
            // C_HeadCoachID
            // 
            this.C_HeadCoachID.DataPropertyName = "C_HeadCoachID";
            this.C_HeadCoachID.DataSource = this.hEADCOACHESBindingSource;
            this.C_HeadCoachID.DisplayMember = "HC_Name";
            this.C_HeadCoachID.HeaderText = "Головний наставник";
            this.C_HeadCoachID.Name = "C_HeadCoachID";
            this.C_HeadCoachID.ValueMember = "HC_ID";
            // 
            // hEADCOACHESBindingSource
            // 
            this.hEADCOACHESBindingSource.DataMember = "HEADCOACHES";
            this.hEADCOACHESBindingSource.DataSource = this.footballDataSet;
            // 
            // C_PresidentID
            // 
            this.C_PresidentID.DataPropertyName = "C_PresidentID";
            this.C_PresidentID.DataSource = this.pRESIDENTSBindingSource;
            this.C_PresidentID.DisplayMember = "Pr_Name";
            this.C_PresidentID.HeaderText = "Президент";
            this.C_PresidentID.Name = "C_PresidentID";
            this.C_PresidentID.ValueMember = "Pr_ID";
            // 
            // pRESIDENTSBindingSource
            // 
            this.pRESIDENTSBindingSource.DataMember = "PRESIDENTS";
            this.pRESIDENTSBindingSource.DataSource = this.footballDataSet;
            // 
            // cDateOfFoundationDataGridViewTextBoxColumn
            // 
            this.cDateOfFoundationDataGridViewTextBoxColumn.DataPropertyName = "C_DateOfFoundation";
            this.cDateOfFoundationDataGridViewTextBoxColumn.HeaderText = "Дата заснування";
            this.cDateOfFoundationDataGridViewTextBoxColumn.Name = "cDateOfFoundationDataGridViewTextBoxColumn";
            // 
            // cBudgetDataGridViewTextBoxColumn
            // 
            this.cBudgetDataGridViewTextBoxColumn.DataPropertyName = "C_Budget";
            this.cBudgetDataGridViewTextBoxColumn.HeaderText = "Бюджет";
            this.cBudgetDataGridViewTextBoxColumn.Name = "cBudgetDataGridViewTextBoxColumn";
            // 
            // C_LeagueID
            // 
            this.C_LeagueID.DataPropertyName = "C_LeagueID";
            this.C_LeagueID.DataSource = this.lEAGUESBindingSource;
            this.C_LeagueID.DisplayMember = "L_Name";
            this.C_LeagueID.HeaderText = "Ліга";
            this.C_LeagueID.Name = "C_LeagueID";
            this.C_LeagueID.ValueMember = "L_ID";
            // 
            // lEAGUESBindingSource
            // 
            this.lEAGUESBindingSource.DataMember = "LEAGUES";
            this.lEAGUESBindingSource.DataSource = this.footballDataSet;
            // 
            // cCityIDDataGridViewTextBoxColumn
            // 
            this.cCityIDDataGridViewTextBoxColumn.DataPropertyName = "C_CityID";
            this.cCityIDDataGridViewTextBoxColumn.HeaderText = "C_CityID";
            this.cCityIDDataGridViewTextBoxColumn.Name = "cCityIDDataGridViewTextBoxColumn";
            this.cCityIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cHeadCoachIDDataGridViewTextBoxColumn
            // 
            this.cHeadCoachIDDataGridViewTextBoxColumn.DataPropertyName = "C_HeadCoachID";
            this.cHeadCoachIDDataGridViewTextBoxColumn.HeaderText = "C_HeadCoachID";
            this.cHeadCoachIDDataGridViewTextBoxColumn.Name = "cHeadCoachIDDataGridViewTextBoxColumn";
            this.cHeadCoachIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cLeagueIDDataGridViewTextBoxColumn
            // 
            this.cLeagueIDDataGridViewTextBoxColumn.DataPropertyName = "C_LeagueID";
            this.cLeagueIDDataGridViewTextBoxColumn.HeaderText = "C_LeagueID";
            this.cLeagueIDDataGridViewTextBoxColumn.Name = "cLeagueIDDataGridViewTextBoxColumn";
            this.cLeagueIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cPresidentIDDataGridViewTextBoxColumn
            // 
            this.cPresidentIDDataGridViewTextBoxColumn.DataPropertyName = "C_PresidentID";
            this.cPresidentIDDataGridViewTextBoxColumn.HeaderText = "C_PresidentID";
            this.cPresidentIDDataGridViewTextBoxColumn.Name = "cPresidentIDDataGridViewTextBoxColumn";
            this.cPresidentIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cIDDataGridViewTextBoxColumn
            // 
            this.cIDDataGridViewTextBoxColumn.DataPropertyName = "C_ID";
            this.cIDDataGridViewTextBoxColumn.HeaderText = "C_ID";
            this.cIDDataGridViewTextBoxColumn.Name = "cIDDataGridViewTextBoxColumn";
            this.cIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // TOURNAMENTS
            // 
            this.TOURNAMENTS.Controls.Add(this.button1);
            this.TOURNAMENTS.Controls.Add(this.button2);
            this.TOURNAMENTS.Controls.Add(this.button3);
            this.TOURNAMENTS.Controls.Add(this.dataGridViewTournaments);
            this.TOURNAMENTS.Location = new System.Drawing.Point(4, 22);
            this.TOURNAMENTS.Name = "TOURNAMENTS";
            this.TOURNAMENTS.Size = new System.Drawing.Size(696, 328);
            this.TOURNAMENTS.TabIndex = 2;
            this.TOURNAMENTS.Text = "Турніри";
            this.TOURNAMENTS.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BlueViolet;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(523, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Пошук";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.BlueViolet;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(295, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 38);
            this.button2.TabIndex = 5;
            this.button2.Text = "Видалити";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.BlueViolet;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button3.Location = new System.Drawing.Point(61, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 38);
            this.button3.TabIndex = 4;
            this.button3.Text = "Зберегти";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridViewTournaments
            // 
            this.dataGridViewTournaments.AutoGenerateColumns = false;
            this.dataGridViewTournaments.BackgroundColor = System.Drawing.Color.Navy;
            this.dataGridViewTournaments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTournaments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tNameDataGridViewTextBoxColumn,
            this.T_TypeID,
            this.T_AssociationID,
            this.tAssociationIDDataGridViewTextBoxColumn,
            this.tTypeIDDataGridViewTextBoxColumn,
            this.tIDDataGridViewTextBoxColumn});
            this.dataGridViewTournaments.DataSource = this.tOURNAMENTSBindingSource;
            this.dataGridViewTournaments.Location = new System.Drawing.Point(0, 63);
            this.dataGridViewTournaments.Name = "dataGridViewTournaments";
            this.dataGridViewTournaments.RowHeadersWidth = 20;
            this.dataGridViewTournaments.Size = new System.Drawing.Size(696, 265);
            this.dataGridViewTournaments.TabIndex = 0;
            // 
            // tNameDataGridViewTextBoxColumn
            // 
            this.tNameDataGridViewTextBoxColumn.DataPropertyName = "T_Name";
            this.tNameDataGridViewTextBoxColumn.HeaderText = "Назва ";
            this.tNameDataGridViewTextBoxColumn.Name = "tNameDataGridViewTextBoxColumn";
            // 
            // T_TypeID
            // 
            this.T_TypeID.DataPropertyName = "T_TypeID";
            this.T_TypeID.DataSource = this.tTYPESBindingSource;
            this.T_TypeID.DisplayMember = "TT_Name";
            this.T_TypeID.HeaderText = "Формат";
            this.T_TypeID.Name = "T_TypeID";
            this.T_TypeID.ValueMember = "TT_ID";
            // 
            // tTYPESBindingSource
            // 
            this.tTYPESBindingSource.DataMember = "T_TYPES";
            this.tTYPESBindingSource.DataSource = this.footballDataSet;
            // 
            // T_AssociationID
            // 
            this.T_AssociationID.DataPropertyName = "T_AssociationID";
            this.T_AssociationID.DataSource = this.aSSOCIATIONSBindingSource;
            this.T_AssociationID.DisplayMember = "A_Name";
            this.T_AssociationID.HeaderText = "Асоціація";
            this.T_AssociationID.Name = "T_AssociationID";
            this.T_AssociationID.ValueMember = "A_ID";
            // 
            // aSSOCIATIONSBindingSource
            // 
            this.aSSOCIATIONSBindingSource.DataMember = "ASSOCIATIONS";
            this.aSSOCIATIONSBindingSource.DataSource = this.footballDataSet;
            // 
            // tAssociationIDDataGridViewTextBoxColumn
            // 
            this.tAssociationIDDataGridViewTextBoxColumn.DataPropertyName = "T_AssociationID";
            this.tAssociationIDDataGridViewTextBoxColumn.HeaderText = "T_AssociationID";
            this.tAssociationIDDataGridViewTextBoxColumn.Name = "tAssociationIDDataGridViewTextBoxColumn";
            this.tAssociationIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // tTypeIDDataGridViewTextBoxColumn
            // 
            this.tTypeIDDataGridViewTextBoxColumn.DataPropertyName = "T_TypeID";
            this.tTypeIDDataGridViewTextBoxColumn.HeaderText = "T_TypeID";
            this.tTypeIDDataGridViewTextBoxColumn.Name = "tTypeIDDataGridViewTextBoxColumn";
            this.tTypeIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // tIDDataGridViewTextBoxColumn
            // 
            this.tIDDataGridViewTextBoxColumn.DataPropertyName = "T_ID";
            this.tIDDataGridViewTextBoxColumn.HeaderText = "T_ID";
            this.tIDDataGridViewTextBoxColumn.Name = "tIDDataGridViewTextBoxColumn";
            this.tIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.tIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // tOURNAMENTSBindingSource
            // 
            this.tOURNAMENTSBindingSource.DataMember = "TOURNAMENTS";
            this.tOURNAMENTSBindingSource.DataSource = this.footballDataSet;
            // 
            // pLAYERSTableAdapter
            // 
            this.pLAYERSTableAdapter.ClearBeforeFill = true;
            // 
            // cOUNTRIESTableAdapter
            // 
            this.cOUNTRIESTableAdapter.ClearBeforeFill = true;
            // 
            // cLUBSTableAdapter
            // 
            this.cLUBSTableAdapter.ClearBeforeFill = true;
            // 
            // pOSITIONSTableAdapter
            // 
            this.pOSITIONSTableAdapter.ClearBeforeFill = true;
            // 
            // cITIESTableAdapter
            // 
            this.cITIESTableAdapter.ClearBeforeFill = true;
            // 
            // hEADCOACHESTableAdapter
            // 
            this.hEADCOACHESTableAdapter.ClearBeforeFill = true;
            // 
            // lEAGUESTableAdapter
            // 
            this.lEAGUESTableAdapter.ClearBeforeFill = true;
            // 
            // pRESIDENTSTableAdapter
            // 
            this.pRESIDENTSTableAdapter.ClearBeforeFill = true;
            // 
            // tOURNAMENTSTableAdapter
            // 
            this.tOURNAMENTSTableAdapter.ClearBeforeFill = true;
            // 
            // aSSOCIATIONSTableAdapter
            // 
            this.aSSOCIATIONSTableAdapter.ClearBeforeFill = true;
            // 
            // t_TYPESTableAdapter
            // 
            this.t_TYPESTableAdapter.ClearBeforeFill = true;
            // 
            // associationsTableAdapter1
            // 
            this.associationsTableAdapter1.ClearBeforeFill = true;
            // 
            // footballDataSet1
            // 
            this.footballDataSet1.DataSetName = "FootballDataSet";
            this.footballDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormFootball
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(728, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormFootball";
            this.Text = "Футбол";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.PLAYERS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLUBSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.footballDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOUNTRIESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSITIONSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLAYERSBindingSource)).EndInit();
            this.CLUBS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClubs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cITIESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hEADCOACHESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRESIDENTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lEAGUESBindingSource)).EndInit();
            this.TOURNAMENTS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTournaments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTYPESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSSOCIATIONSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOURNAMENTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.footballDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PLAYERS;
        private System.Windows.Forms.TabPage CLUBS;
        private System.Windows.Forms.Button buttonSearchPlayers;
        private System.Windows.Forms.Button buttonDeletePlayers;
        private System.Windows.Forms.Button buttonSavePlayers;
        private System.Windows.Forms.DataGridView dataGridViewPlayers;
        private FootballDataSet footballDataSet;
        private System.Windows.Forms.BindingSource pLAYERSBindingSource;
        private FootballDataSetTableAdapters.PLAYERSTableAdapter pLAYERSTableAdapter;
        private System.Windows.Forms.BindingSource cOUNTRIESBindingSource;
        private FootballDataSetTableAdapters.COUNTRIESTableAdapter cOUNTRIESTableAdapter;
        private System.Windows.Forms.BindingSource cLUBSBindingSource;
        private FootballDataSetTableAdapters.CLUBSTableAdapter cLUBSTableAdapter;
        private System.Windows.Forms.BindingSource pOSITIONSBindingSource;
        private FootballDataSetTableAdapters.POSITIONSTableAdapter pOSITIONSTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private FootballDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.Button buttonSearchClubs;
        private System.Windows.Forms.Button buttonDeleteClubs;
        private System.Windows.Forms.Button buttonSaveClubs;
        private System.Windows.Forms.DataGridView dataGridViewClubs;
        private System.Windows.Forms.BindingSource cITIESBindingSource;
        private FootballDataSetTableAdapters.CITIESTableAdapter cITIESTableAdapter;
        private System.Windows.Forms.BindingSource hEADCOACHESBindingSource;
        private FootballDataSetTableAdapters.HEADCOACHESTableAdapter hEADCOACHESTableAdapter;
        private System.Windows.Forms.BindingSource lEAGUESBindingSource;
        private FootballDataSetTableAdapters.LEAGUESTableAdapter lEAGUESTableAdapter;
        private System.Windows.Forms.BindingSource pRESIDENTSBindingSource;
        private FootballDataSetTableAdapters.PRESIDENTSTableAdapter pRESIDENTSTableAdapter;
        private System.Windows.Forms.TabPage TOURNAMENTS;
        private System.Windows.Forms.DataGridView dataGridViewTournaments;
        private System.Windows.Forms.BindingSource tOURNAMENTSBindingSource;
        private FootballDataSetTableAdapters.TOURNAMENTSTableAdapter tOURNAMENTSTableAdapter;
        private System.Windows.Forms.BindingSource aSSOCIATIONSBindingSource;
        private FootballDataSetTableAdapters.ASSOCIATIONSTableAdapter aSSOCIATIONSTableAdapter;
        private System.Windows.Forms.BindingSource tTYPESBindingSource;
        private FootballDataSetTableAdapters.T_TYPESTableAdapter t_TYPESTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private FootballDataSetTableAdapters.ASSOCIATIONSTableAdapter associationsTableAdapter1;
        private FootballDataSet footballDataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn P_ClubID;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn P_CountryID;
        private System.Windows.Forms.DataGridViewComboBoxColumn P_PositionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCountryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pClubIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pPositionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn C_CityID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStadiumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn C_HeadCoachID;
        private System.Windows.Forms.DataGridViewComboBoxColumn C_PresidentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDateOfFoundationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBudgetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn C_LeagueID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCityIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHeadCoachIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLeagueIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPresidentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn T_TypeID;
        private System.Windows.Forms.DataGridViewComboBoxColumn T_AssociationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tAssociationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIDDataGridViewTextBoxColumn;
    }
}

