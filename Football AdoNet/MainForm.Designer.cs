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
            this.buttonNeural.Text = "Додатково";
            this.buttonNeural.UseVisualStyleBackColor = false;
            this.buttonNeural.Click += new System.EventHandler(this.buttonNeural_Click);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFormFootball;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonNeural;
    }
}