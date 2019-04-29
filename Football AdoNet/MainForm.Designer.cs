namespace Football_AdoNet
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonFormFootball = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonNeural = new System.Windows.Forms.Button();
            this.footballDataSet1 = new Football_AdoNet.FootballDataSet();
            this.associationsTableAdapter1 = new Football_AdoNet.FootballDataSetTableAdapters.ASSOCIATIONSTableAdapter();
            this.citiesTableAdapter1 = new Football_AdoNet.FootballDataSetTableAdapters.CITIESTableAdapter();
            this.clubsTableAdapter1 = new Football_AdoNet.FootballDataSetTableAdapters.CLUBSTableAdapter();
            this.countriesTableAdapter1 = new Football_AdoNet.FootballDataSetTableAdapters.COUNTRIESTableAdapter();
            this.fifA_RATINGSTableAdapter1 = new Football_AdoNet.FootballDataSetTableAdapters.FIFA_RATINGSTableAdapter();
            this.headcoachesTableAdapter1 = new Football_AdoNet.FootballDataSetTableAdapters.HEADCOACHESTableAdapter();
            this.leaguesTableAdapter1 = new Football_AdoNet.FootballDataSetTableAdapters.LEAGUESTableAdapter();
            this.playersTableAdapter1 = new Football_AdoNet.FootballDataSetTableAdapters.PLAYERSTableAdapter();
            this.positionsTableAdapter1 = new Football_AdoNet.FootballDataSetTableAdapters.POSITIONSTableAdapter();
            this.presidentsTableAdapter1 = new Football_AdoNet.FootballDataSetTableAdapters.PRESIDENTSTableAdapter();
            this.t_CLUBSTableAdapter1 = new Football_AdoNet.FootballDataSetTableAdapters.T_CLUBSTableAdapter();
            this.t_TYPESTableAdapter1 = new Football_AdoNet.FootballDataSetTableAdapters.T_TYPESTableAdapter();
            this.tournamentsTableAdapter1 = new Football_AdoNet.FootballDataSetTableAdapters.TOURNAMENTSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.footballDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFormFootball
            // 
            this.buttonFormFootball.BackColor = System.Drawing.Color.Navy;
            this.buttonFormFootball.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFormFootball.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFormFootball.ForeColor = System.Drawing.Color.White;
            this.buttonFormFootball.Location = new System.Drawing.Point(-1, 95);
            this.buttonFormFootball.Name = "buttonFormFootball";
            this.buttonFormFootball.Size = new System.Drawing.Size(250, 60);
            this.buttonFormFootball.TabIndex = 0;
            this.buttonFormFootball.Text = "Розпочати роботу";
            this.buttonFormFootball.UseVisualStyleBackColor = false;
            this.buttonFormFootball.Click += new System.EventHandler(this.buttonFormFootball_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.BackColor = System.Drawing.Color.Navy;
            this.buttonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInfo.ForeColor = System.Drawing.Color.White;
            this.buttonInfo.Location = new System.Drawing.Point(-1, 180);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(250, 60);
            this.buttonInfo.TabIndex = 1;
            this.buttonInfo.Text = "Довідка";
            this.buttonInfo.UseVisualStyleBackColor = false;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // buttonNeural
            // 
            this.buttonNeural.BackColor = System.Drawing.Color.Navy;
            this.buttonNeural.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNeural.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNeural.ForeColor = System.Drawing.Color.White;
            this.buttonNeural.Location = new System.Drawing.Point(-1, 265);
            this.buttonNeural.Name = "buttonNeural";
            this.buttonNeural.Size = new System.Drawing.Size(250, 60);
            this.buttonNeural.TabIndex = 2;
            this.buttonNeural.Text = "XML";
            this.buttonNeural.UseVisualStyleBackColor = false;
            this.buttonNeural.Click += new System.EventHandler(this.buttonNeural_Click);
            // 
            // footballDataSet1
            // 
            this.footballDataSet1.DataSetName = "FootballDataSet";
            this.footballDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // associationsTableAdapter1
            // 
            this.associationsTableAdapter1.ClearBeforeFill = true;
            // 
            // citiesTableAdapter1
            // 
            this.citiesTableAdapter1.ClearBeforeFill = true;
            // 
            // clubsTableAdapter1
            // 
            this.clubsTableAdapter1.ClearBeforeFill = true;
            // 
            // countriesTableAdapter1
            // 
            this.countriesTableAdapter1.ClearBeforeFill = true;
            // 
            // fifA_RATINGSTableAdapter1
            // 
            this.fifA_RATINGSTableAdapter1.ClearBeforeFill = true;
            // 
            // headcoachesTableAdapter1
            // 
            this.headcoachesTableAdapter1.ClearBeforeFill = true;
            // 
            // leaguesTableAdapter1
            // 
            this.leaguesTableAdapter1.ClearBeforeFill = true;
            // 
            // playersTableAdapter1
            // 
            this.playersTableAdapter1.ClearBeforeFill = true;
            // 
            // positionsTableAdapter1
            // 
            this.positionsTableAdapter1.ClearBeforeFill = true;
            // 
            // presidentsTableAdapter1
            // 
            this.presidentsTableAdapter1.ClearBeforeFill = true;
            // 
            // t_CLUBSTableAdapter1
            // 
            this.t_CLUBSTableAdapter1.ClearBeforeFill = true;
            // 
            // t_TYPESTableAdapter1
            // 
            this.t_TYPESTableAdapter1.ClearBeforeFill = true;
            // 
            // tournamentsTableAdapter1
            // 
            this.tournamentsTableAdapter1.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 411);
            this.Controls.Add(this.buttonNeural);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonFormFootball);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Головна";
            ((System.ComponentModel.ISupportInitialize)(this.footballDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFormFootball;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonNeural;
        private FootballDataSet footballDataSet1;
        private FootballDataSetTableAdapters.ASSOCIATIONSTableAdapter associationsTableAdapter1;
        private FootballDataSetTableAdapters.CITIESTableAdapter citiesTableAdapter1;
        private FootballDataSetTableAdapters.CLUBSTableAdapter clubsTableAdapter1;
        private FootballDataSetTableAdapters.COUNTRIESTableAdapter countriesTableAdapter1;
        private FootballDataSetTableAdapters.FIFA_RATINGSTableAdapter fifA_RATINGSTableAdapter1;
        private FootballDataSetTableAdapters.HEADCOACHESTableAdapter headcoachesTableAdapter1;
        private FootballDataSetTableAdapters.LEAGUESTableAdapter leaguesTableAdapter1;
        private FootballDataSetTableAdapters.PLAYERSTableAdapter playersTableAdapter1;
        private FootballDataSetTableAdapters.POSITIONSTableAdapter positionsTableAdapter1;
        private FootballDataSetTableAdapters.PRESIDENTSTableAdapter presidentsTableAdapter1;
        private FootballDataSetTableAdapters.T_CLUBSTableAdapter t_CLUBSTableAdapter1;
        private FootballDataSetTableAdapters.T_TYPESTableAdapter t_TYPESTableAdapter1;
        private FootballDataSetTableAdapters.TOURNAMENTSTableAdapter tournamentsTableAdapter1;
    }
}