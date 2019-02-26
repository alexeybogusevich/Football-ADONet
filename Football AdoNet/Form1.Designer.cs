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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PLAYERS = new System.Windows.Forms.TabPage();
            this.CLUBS = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSavePlayers = new System.Windows.Forms.Button();
            this.buttonDeletePlayers = new System.Windows.Forms.Button();
            this.buttonSearchPlayers = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.PLAYERS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.PLAYERS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    }
}

