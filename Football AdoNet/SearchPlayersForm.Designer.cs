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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchPlayersForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PStextBoxClub = new System.Windows.Forms.TextBox();
            this.PStextBoxPosition = new System.Windows.Forms.TextBox();
            this.PStextBoxCountry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSearchPlayers = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.footballDataSet1 = new Football_AdoNet.FootballDataSet();
            this.dtSearchPlayersTableAdapter1 = new Football_AdoNet.FootballDataSetTableAdapters.DTSearchPlayersTableAdapter();
            this.pNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNTRYNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOSNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pClubIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCountryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pPositionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOSIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.footballDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Navy;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pNameDataGridViewTextBoxColumn,
            this.pDateOfBirthDataGridViewTextBoxColumn,
            this.cNTRYNameDataGridViewTextBoxColumn,
            this.pOSNameDataGridViewTextBoxColumn,
            this.cNameDataGridViewTextBoxColumn,
            this.pNumberDataGridViewTextBoxColumn,
            this.lNameDataGridViewTextBoxColumn,
            this.lIDDataGridViewTextBoxColumn,
            this.cIDDataGridViewTextBoxColumn,
            this.pClubIDDataGridViewTextBoxColumn,
            this.pCountryIDDataGridViewTextBoxColumn,
            this.pIDDataGridViewTextBoxColumn,
            this.pPositionIDDataGridViewTextBoxColumn,
            this.pOSIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(13, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.Size = new System.Drawing.Size(703, 329);
            this.dataGridView1.TabIndex = 0;
            // 
            // PStextBoxClub
            // 
            this.PStextBoxClub.Location = new System.Drawing.Point(13, 50);
            this.PStextBoxClub.Name = "PStextBoxClub";
            this.PStextBoxClub.Size = new System.Drawing.Size(140, 20);
            this.PStextBoxClub.TabIndex = 1;
            // 
            // PStextBoxPosition
            // 
            this.PStextBoxPosition.Location = new System.Drawing.Point(188, 50);
            this.PStextBoxPosition.Name = "PStextBoxPosition";
            this.PStextBoxPosition.Size = new System.Drawing.Size(140, 20);
            this.PStextBoxPosition.TabIndex = 2;
            // 
            // PStextBoxCountry
            // 
            this.PStextBoxCountry.Location = new System.Drawing.Point(363, 50);
            this.PStextBoxCountry.Name = "PStextBoxCountry";
            this.PStextBoxCountry.Size = new System.Drawing.Size(140, 20);
            this.PStextBoxCountry.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(63, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Клуб";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(235, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Позиція";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(360, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "      Національність";
            // 
            // buttonSearchPlayers
            // 
            this.buttonSearchPlayers.BackColor = System.Drawing.Color.Navy;
            this.buttonSearchPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearchPlayers.ForeColor = System.Drawing.Color.White;
            this.buttonSearchPlayers.Location = new System.Drawing.Point(605, 10);
            this.buttonSearchPlayers.Name = "buttonSearchPlayers";
            this.buttonSearchPlayers.Size = new System.Drawing.Size(111, 91);
            this.buttonSearchPlayers.TabIndex = 7;
            this.buttonSearchPlayers.Text = "Знайти";
            this.buttonSearchPlayers.UseVisualStyleBackColor = false;
            this.buttonSearchPlayers.Click += new System.EventHandler(this.buttonSearchPlayers_Click);
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
            this.pDateOfBirthDataGridViewTextBoxColumn.HeaderText = "Вік";
            this.pDateOfBirthDataGridViewTextBoxColumn.Name = "pDateOfBirthDataGridViewTextBoxColumn";
            this.pDateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
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
            // cNameDataGridViewTextBoxColumn
            // 
            this.cNameDataGridViewTextBoxColumn.DataPropertyName = "C_Name";
            this.cNameDataGridViewTextBoxColumn.HeaderText = "Клуб";
            this.cNameDataGridViewTextBoxColumn.Name = "cNameDataGridViewTextBoxColumn";
            this.cNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pNumberDataGridViewTextBoxColumn
            // 
            this.pNumberDataGridViewTextBoxColumn.DataPropertyName = "P_Number";
            this.pNumberDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.pNumberDataGridViewTextBoxColumn.Name = "pNumberDataGridViewTextBoxColumn";
            this.pNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.pNumberDataGridViewTextBoxColumn.Width = 81;
            // 
            // lNameDataGridViewTextBoxColumn
            // 
            this.lNameDataGridViewTextBoxColumn.DataPropertyName = "L_Name";
            this.lNameDataGridViewTextBoxColumn.HeaderText = "Ліга";
            this.lNameDataGridViewTextBoxColumn.Name = "lNameDataGridViewTextBoxColumn";
            this.lNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lIDDataGridViewTextBoxColumn
            // 
            this.lIDDataGridViewTextBoxColumn.DataPropertyName = "L_ID";
            this.lIDDataGridViewTextBoxColumn.HeaderText = "L_ID";
            this.lIDDataGridViewTextBoxColumn.Name = "lIDDataGridViewTextBoxColumn";
            this.lIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.lIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cIDDataGridViewTextBoxColumn
            // 
            this.cIDDataGridViewTextBoxColumn.DataPropertyName = "C_ID";
            this.cIDDataGridViewTextBoxColumn.HeaderText = "C_ID";
            this.cIDDataGridViewTextBoxColumn.Name = "cIDDataGridViewTextBoxColumn";
            this.cIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cIDDataGridViewTextBoxColumn.Visible = false;
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
            // pIDDataGridViewTextBoxColumn
            // 
            this.pIDDataGridViewTextBoxColumn.DataPropertyName = "P_ID";
            this.pIDDataGridViewTextBoxColumn.HeaderText = "P_ID";
            this.pIDDataGridViewTextBoxColumn.Name = "pIDDataGridViewTextBoxColumn";
            this.pIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pPositionIDDataGridViewTextBoxColumn
            // 
            this.pPositionIDDataGridViewTextBoxColumn.DataPropertyName = "P_PositionID";
            this.pPositionIDDataGridViewTextBoxColumn.HeaderText = "P_PositionID";
            this.pPositionIDDataGridViewTextBoxColumn.Name = "pPositionIDDataGridViewTextBoxColumn";
            this.pPositionIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pPositionIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pOSIDDataGridViewTextBoxColumn
            // 
            this.pOSIDDataGridViewTextBoxColumn.DataPropertyName = "POS_ID";
            this.pOSIDDataGridViewTextBoxColumn.HeaderText = "POS_ID";
            this.pOSIDDataGridViewTextBoxColumn.Name = "pOSIDDataGridViewTextBoxColumn";
            this.pOSIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pOSIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // SearchPlayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(728, 450);
            this.Controls.Add(this.buttonSearchPlayers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PStextBoxCountry);
            this.Controls.Add(this.PStextBoxPosition);
            this.Controls.Add(this.PStextBoxClub);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
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
        private System.Windows.Forms.TextBox PStextBoxPosition;
        private System.Windows.Forms.TextBox PStextBoxCountry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSearchPlayers;
        private System.Windows.Forms.DataGridViewTextBoxColumn tNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tMCClubIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tMCTournamentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNTRYNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOSNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pClubIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCountryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pPositionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOSIDDataGridViewTextBoxColumn;
    }
}