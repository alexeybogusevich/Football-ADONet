namespace Football_AdoNet
{
    partial class SearchTournamentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchTournamentsForm));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.footballDataSet1 = new Football_AdoNet.FootballDataSet();
            this.dtSearchTournamentsTableAdapter1 = new Football_AdoNet.FootballDataSetTableAdapters.DTSearchTournamentsTableAdapter();
            this.dataGridViewSearchTournaments = new System.Windows.Forms.DataGridView();
            this.TStextBoxType = new System.Windows.Forms.TextBox();
            this.TStextBoxAssociation = new System.Windows.Forms.TextBox();
            this.TStextBoxClub = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSearchTournaments = new System.Windows.Forms.Button();
            this.tNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tTNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tAssociationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.footballDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchTournaments)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "DTSearchTournaments";
            this.bindingSource1.DataSource = this.footballDataSet1;
            // 
            // footballDataSet1
            // 
            this.footballDataSet1.DataSetName = "FootballDataSet";
            this.footballDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtSearchTournamentsTableAdapter1
            // 
            this.dtSearchTournamentsTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridViewSearchTournaments
            // 
            this.dataGridViewSearchTournaments.AutoGenerateColumns = false;
            this.dataGridViewSearchTournaments.BackgroundColor = System.Drawing.Color.Navy;
            this.dataGridViewSearchTournaments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchTournaments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tNameDataGridViewTextBoxColumn,
            this.aNameDataGridViewTextBoxColumn,
            this.tTNameDataGridViewTextBoxColumn,
            this.tIDDataGridViewTextBoxColumn,
            this.tAssociationIDDataGridViewTextBoxColumn,
            this.tTypeIDDataGridViewTextBoxColumn,
            this.tTIDDataGridViewTextBoxColumn,
            this.aIDDataGridViewTextBoxColumn});
            this.dataGridViewSearchTournaments.DataSource = this.bindingSource1;
            this.dataGridViewSearchTournaments.Location = new System.Drawing.Point(12, 109);
            this.dataGridViewSearchTournaments.Name = "dataGridViewSearchTournaments";
            this.dataGridViewSearchTournaments.ReadOnly = true;
            this.dataGridViewSearchTournaments.RowHeadersWidth = 20;
            this.dataGridViewSearchTournaments.Size = new System.Drawing.Size(703, 329);
            this.dataGridViewSearchTournaments.TabIndex = 0;
            // 
            // TStextBoxType
            // 
            this.TStextBoxType.Location = new System.Drawing.Point(363, 50);
            this.TStextBoxType.Name = "TStextBoxType";
            this.TStextBoxType.Size = new System.Drawing.Size(140, 20);
            this.TStextBoxType.TabIndex = 1;
            // 
            // TStextBoxAssociation
            // 
            this.TStextBoxAssociation.Location = new System.Drawing.Point(188, 50);
            this.TStextBoxAssociation.Name = "TStextBoxAssociation";
            this.TStextBoxAssociation.Size = new System.Drawing.Size(140, 20);
            this.TStextBoxAssociation.TabIndex = 2;
            // 
            // TStextBoxClub
            // 
            this.TStextBoxClub.Location = new System.Drawing.Point(13, 50);
            this.TStextBoxClub.Name = "TStextBoxClub";
            this.TStextBoxClub.Size = new System.Drawing.Size(140, 20);
            this.TStextBoxClub.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(359, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "       Тип змагання";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(230, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Асоціація";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(65, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Клуб";
            // 
            // buttonSearchTournaments
            // 
            this.buttonSearchTournaments.BackColor = System.Drawing.Color.Navy;
            this.buttonSearchTournaments.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearchTournaments.ForeColor = System.Drawing.Color.White;
            this.buttonSearchTournaments.Location = new System.Drawing.Point(605, 10);
            this.buttonSearchTournaments.Name = "buttonSearchTournaments";
            this.buttonSearchTournaments.Size = new System.Drawing.Size(111, 91);
            this.buttonSearchTournaments.TabIndex = 7;
            this.buttonSearchTournaments.Text = "Знайти";
            this.buttonSearchTournaments.UseVisualStyleBackColor = false;
            this.buttonSearchTournaments.Click += new System.EventHandler(this.buttonSearchTournaments_Click);
            // 
            // tNameDataGridViewTextBoxColumn
            // 
            this.tNameDataGridViewTextBoxColumn.DataPropertyName = "T_Name";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F);
            this.tNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.tNameDataGridViewTextBoxColumn.HeaderText = "Назва турніру";
            this.tNameDataGridViewTextBoxColumn.Name = "tNameDataGridViewTextBoxColumn";
            this.tNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.tNameDataGridViewTextBoxColumn.Width = 227;
            // 
            // aNameDataGridViewTextBoxColumn
            // 
            this.aNameDataGridViewTextBoxColumn.DataPropertyName = "A_Name";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F);
            this.aNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.aNameDataGridViewTextBoxColumn.HeaderText = "Асоціація";
            this.aNameDataGridViewTextBoxColumn.Name = "aNameDataGridViewTextBoxColumn";
            this.aNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.aNameDataGridViewTextBoxColumn.Width = 227;
            // 
            // tTNameDataGridViewTextBoxColumn
            // 
            this.tTNameDataGridViewTextBoxColumn.DataPropertyName = "TT_Name";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F);
            this.tTNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.tTNameDataGridViewTextBoxColumn.HeaderText = "Тип змагання";
            this.tTNameDataGridViewTextBoxColumn.Name = "tTNameDataGridViewTextBoxColumn";
            this.tTNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.tTNameDataGridViewTextBoxColumn.Width = 227;
            // 
            // tIDDataGridViewTextBoxColumn
            // 
            this.tIDDataGridViewTextBoxColumn.DataPropertyName = "T_ID";
            this.tIDDataGridViewTextBoxColumn.HeaderText = "T_ID";
            this.tIDDataGridViewTextBoxColumn.Name = "tIDDataGridViewTextBoxColumn";
            this.tIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.tIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // tAssociationIDDataGridViewTextBoxColumn
            // 
            this.tAssociationIDDataGridViewTextBoxColumn.DataPropertyName = "T_AssociationID";
            this.tAssociationIDDataGridViewTextBoxColumn.HeaderText = "T_AssociationID";
            this.tAssociationIDDataGridViewTextBoxColumn.Name = "tAssociationIDDataGridViewTextBoxColumn";
            this.tAssociationIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.tAssociationIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // tTypeIDDataGridViewTextBoxColumn
            // 
            this.tTypeIDDataGridViewTextBoxColumn.DataPropertyName = "T_TypeID";
            this.tTypeIDDataGridViewTextBoxColumn.HeaderText = "T_TypeID";
            this.tTypeIDDataGridViewTextBoxColumn.Name = "tTypeIDDataGridViewTextBoxColumn";
            this.tTypeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.tTypeIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // tTIDDataGridViewTextBoxColumn
            // 
            this.tTIDDataGridViewTextBoxColumn.DataPropertyName = "TT_ID";
            this.tTIDDataGridViewTextBoxColumn.HeaderText = "TT_ID";
            this.tTIDDataGridViewTextBoxColumn.Name = "tTIDDataGridViewTextBoxColumn";
            this.tTIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.tTIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // aIDDataGridViewTextBoxColumn
            // 
            this.aIDDataGridViewTextBoxColumn.DataPropertyName = "A_ID";
            this.aIDDataGridViewTextBoxColumn.HeaderText = "A_ID";
            this.aIDDataGridViewTextBoxColumn.Name = "aIDDataGridViewTextBoxColumn";
            this.aIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.aIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // SearchTournamentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(728, 450);
            this.Controls.Add(this.buttonSearchTournaments);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TStextBoxClub);
            this.Controls.Add(this.TStextBoxAssociation);
            this.Controls.Add(this.TStextBoxType);
            this.Controls.Add(this.dataGridViewSearchTournaments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SearchTournamentsForm";
            this.Text = "Пошук змагань";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.footballDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchTournaments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FootballDataSet footballDataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private FootballDataSetTableAdapters.DTSearchTournamentsTableAdapter dtSearchTournamentsTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridViewSearchTournaments;
        private System.Windows.Forms.TextBox TStextBoxType;
        private System.Windows.Forms.TextBox TStextBoxAssociation;
        private System.Windows.Forms.TextBox TStextBoxClub;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSearchTournaments;
        private System.Windows.Forms.DataGridViewTextBoxColumn tNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tTNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tAssociationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aIDDataGridViewTextBoxColumn;
    }
}