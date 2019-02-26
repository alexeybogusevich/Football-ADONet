namespace Football_AdoNet
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PLAYERS = new System.Windows.Forms.TabPage();
            this.CLUBS = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSavePlayers = new System.Windows.Forms.Button();
            this.buttonDeletePlayers = new System.Windows.Forms.Button();
            this.buttonSearchPlayers = new System.Windows.Forms.Button();
            this.footballDataSet = new Football_AdoNet.FootballDataSet();
            this.pLAYERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pLAYERSTableAdapter = new Football_AdoNet.FootballDataSetTableAdapters.PLAYERSTableAdapter();
            this.cOUNTRIESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOUNTRIESTableAdapter = new Football_AdoNet.FootballDataSetTableAdapters.COUNTRIESTableAdapter();
            this.cLUBSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLUBSTableAdapter = new Football_AdoNet.FootballDataSetTableAdapters.CLUBSTableAdapter();
            this.pOSITIONSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOSITIONSTableAdapter = new Football_AdoNet.FootballDataSetTableAdapters.POSITIONSTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_ClubID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_CountryID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.P_PositionID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pCountryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pClubIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pPositionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.PLAYERS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.footballDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLAYERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOUNTRIESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLUBSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSITIONSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PLAYERS);
            this.tabControl1.Controls.Add(this.CLUBS);
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(530, 451);
            this.tabControl1.TabIndex = 0;
            // 
            // PLAYERS
            // 
            this.PLAYERS.Controls.Add(this.buttonSearchPlayers);
            this.PLAYERS.Controls.Add(this.buttonDeletePlayers);
            this.PLAYERS.Controls.Add(this.buttonSavePlayers);
            this.PLAYERS.Controls.Add(this.dataGridView1);
            this.PLAYERS.Location = new System.Drawing.Point(4, 22);
            this.PLAYERS.Name = "PLAYERS";
            this.PLAYERS.Padding = new System.Windows.Forms.Padding(3);
            this.PLAYERS.Size = new System.Drawing.Size(522, 425);
            this.PLAYERS.TabIndex = 0;
            this.PLAYERS.Text = "PLAYERS";
            this.PLAYERS.UseVisualStyleBackColor = true;
            // 
            // CLUBS
            // 
            this.CLUBS.Location = new System.Drawing.Point(4, 22);
            this.CLUBS.Name = "CLUBS";
            this.CLUBS.Padding = new System.Windows.Forms.Padding(3);
            this.CLUBS.Size = new System.Drawing.Size(522, 350);
            this.CLUBS.TabIndex = 1;
            this.CLUBS.Text = "CLUBS";
            this.CLUBS.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView1.DataSource = this.pLAYERSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(522, 374);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonSavePlayers
            // 
            this.buttonSavePlayers.Location = new System.Drawing.Point(53, 16);
            this.buttonSavePlayers.Name = "buttonSavePlayers";
            this.buttonSavePlayers.Size = new System.Drawing.Size(75, 23);
            this.buttonSavePlayers.TabIndex = 1;
            this.buttonSavePlayers.Text = "SAVE";
            this.buttonSavePlayers.UseVisualStyleBackColor = true;
            this.buttonSavePlayers.Click += new System.EventHandler(this.buttonSavePlayers_Click);
            // 
            // buttonDeletePlayers
            // 
            this.buttonDeletePlayers.Location = new System.Drawing.Point(230, 16);
            this.buttonDeletePlayers.Name = "buttonDeletePlayers";
            this.buttonDeletePlayers.Size = new System.Drawing.Size(75, 23);
            this.buttonDeletePlayers.TabIndex = 2;
            this.buttonDeletePlayers.Text = "DELETE";
            this.buttonDeletePlayers.UseVisualStyleBackColor = true;
            // 
            // buttonSearchPlayers
            // 
            this.buttonSearchPlayers.Location = new System.Drawing.Point(419, 16);
            this.buttonSearchPlayers.Name = "buttonSearchPlayers";
            this.buttonSearchPlayers.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchPlayers.TabIndex = 3;
            this.buttonSearchPlayers.Text = "SEARCH";
            this.buttonSearchPlayers.UseVisualStyleBackColor = true;
            // 
            // footballDataSet
            // 
            this.footballDataSet.DataSetName = "FootballDataSet";
            this.footballDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pLAYERSBindingSource
            // 
            this.pLAYERSBindingSource.DataMember = "PLAYERS";
            this.pLAYERSBindingSource.DataSource = this.footballDataSet;
            // 
            // pLAYERSTableAdapter
            // 
            this.pLAYERSTableAdapter.ClearBeforeFill = true;
            // 
            // cOUNTRIESBindingSource
            // 
            this.cOUNTRIESBindingSource.DataMember = "COUNTRIES";
            this.cOUNTRIESBindingSource.DataSource = this.footballDataSet;
            // 
            // cOUNTRIESTableAdapter
            // 
            this.cOUNTRIESTableAdapter.ClearBeforeFill = true;
            // 
            // cLUBSBindingSource
            // 
            this.cLUBSBindingSource.DataMember = "CLUBS";
            this.cLUBSBindingSource.DataSource = this.footballDataSet;
            // 
            // cLUBSTableAdapter
            // 
            this.cLUBSTableAdapter.ClearBeforeFill = true;
            // 
            // pOSITIONSBindingSource
            // 
            this.pOSITIONSBindingSource.DataMember = "POSITIONS";
            this.pOSITIONSBindingSource.DataSource = this.footballDataSet;
            // 
            // pOSITIONSTableAdapter
            // 
            this.pOSITIONSTableAdapter.ClearBeforeFill = true;
            // 
            // pIDDataGridViewTextBoxColumn
            // 
            this.pIDDataGridViewTextBoxColumn.DataPropertyName = "P_ID";
            this.pIDDataGridViewTextBoxColumn.HeaderText = "P_ID";
            this.pIDDataGridViewTextBoxColumn.Name = "pIDDataGridViewTextBoxColumn";
            this.pIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pNameDataGridViewTextBoxColumn
            // 
            this.pNameDataGridViewTextBoxColumn.DataPropertyName = "P_Name";
            this.pNameDataGridViewTextBoxColumn.HeaderText = "P_Name";
            this.pNameDataGridViewTextBoxColumn.Name = "pNameDataGridViewTextBoxColumn";
            // 
            // pDateOfBirthDataGridViewTextBoxColumn
            // 
            this.pDateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "P_DateOfBirth";
            this.pDateOfBirthDataGridViewTextBoxColumn.HeaderText = "P_DateOfBirth";
            this.pDateOfBirthDataGridViewTextBoxColumn.Name = "pDateOfBirthDataGridViewTextBoxColumn";
            // 
            // P_ClubID
            // 
            this.P_ClubID.DataPropertyName = "P_ClubID";
            this.P_ClubID.DataSource = this.cLUBSBindingSource;
            this.P_ClubID.DisplayMember = "C_Name";
            this.P_ClubID.HeaderText = "P_ClubID";
            this.P_ClubID.Name = "P_ClubID";
            this.P_ClubID.ValueMember = "C_ID";
            // 
            // pNumberDataGridViewTextBoxColumn
            // 
            this.pNumberDataGridViewTextBoxColumn.DataPropertyName = "P_Number";
            this.pNumberDataGridViewTextBoxColumn.HeaderText = "P_Number";
            this.pNumberDataGridViewTextBoxColumn.Name = "pNumberDataGridViewTextBoxColumn";
            // 
            // P_CountryID
            // 
            this.P_CountryID.DataPropertyName = "P_CountryID";
            this.P_CountryID.DataSource = this.cOUNTRIESBindingSource;
            this.P_CountryID.DisplayMember = "CNTRY_Name";
            this.P_CountryID.HeaderText = "P_CountryID";
            this.P_CountryID.Name = "P_CountryID";
            this.P_CountryID.ValueMember = "CNTRY_ID";
            // 
            // P_PositionID
            // 
            this.P_PositionID.DataPropertyName = "P_PositionID";
            this.P_PositionID.DataSource = this.pOSITIONSBindingSource;
            this.P_PositionID.DisplayMember = "POS_Name";
            this.P_PositionID.HeaderText = "P_PositionID";
            this.P_PositionID.Name = "P_PositionID";
            this.P_PositionID.ValueMember = "POS_ID";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.PLAYERS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.footballDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLAYERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOUNTRIESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLUBSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSITIONSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PLAYERS;
        private System.Windows.Forms.TabPage CLUBS;
        private System.Windows.Forms.Button buttonSearchPlayers;
        private System.Windows.Forms.Button buttonDeletePlayers;
        private System.Windows.Forms.Button buttonSavePlayers;
        private System.Windows.Forms.DataGridView dataGridView1;
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
    }
}

