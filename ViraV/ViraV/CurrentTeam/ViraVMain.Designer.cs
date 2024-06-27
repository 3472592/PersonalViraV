namespace ViraV
{
    partial class ViraVMain
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
            this.LogOut = new System.Windows.Forms.Button();
            this.Virav = new System.Windows.Forms.TabControl();
            this.CEOPage = new System.Windows.Forms.TabPage();
            this.ToolsCheck = new System.Windows.Forms.Button();
            this.Connections = new System.Windows.Forms.Button();
            this.Ideas = new System.Windows.Forms.Button();
            this.Tempo = new System.Windows.Forms.Button();
            this.BalanceWorkRest = new System.Windows.Forms.Button();
            this.SendMSG = new System.Windows.Forms.Button();
            this.COOPage = new System.Windows.Forms.TabPage();
            this.ClientPage = new System.Windows.Forms.TabPage();
            this.BAPage = new System.Windows.Forms.TabPage();
            this.PMPage = new System.Windows.Forms.TabPage();
            this.QAPage = new System.Windows.Forms.TabPage();
            this.TechLeadPage = new System.Windows.Forms.TabPage();
            this.DevPage = new System.Windows.Forms.TabPage();
            this.Virav.SuspendLayout();
            this.CEOPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogOut
            // 
            this.LogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.LogOut.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogOut.ForeColor = System.Drawing.Color.White;
            this.LogOut.Location = new System.Drawing.Point(670, 380);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(118, 51);
            this.LogOut.TabIndex = 9;
            this.LogOut.Text = "Log Out";
            this.LogOut.UseVisualStyleBackColor = false;
            this.LogOut.Click += new System.EventHandler(this.Back_Click);
            // 
            // Virav
            // 
            this.Virav.Controls.Add(this.CEOPage);
            this.Virav.Controls.Add(this.COOPage);
            this.Virav.Controls.Add(this.ClientPage);
            this.Virav.Controls.Add(this.BAPage);
            this.Virav.Controls.Add(this.PMPage);
            this.Virav.Controls.Add(this.QAPage);
            this.Virav.Controls.Add(this.TechLeadPage);
            this.Virav.Controls.Add(this.DevPage);
            this.Virav.Location = new System.Drawing.Point(0, -4);
            this.Virav.Name = "Virav";
            this.Virav.SelectedIndex = 0;
            this.Virav.Size = new System.Drawing.Size(800, 378);
            this.Virav.TabIndex = 10;
            // 
            // CEOPage
            // 
            this.CEOPage.Controls.Add(this.ToolsCheck);
            this.CEOPage.Controls.Add(this.Connections);
            this.CEOPage.Controls.Add(this.Ideas);
            this.CEOPage.Controls.Add(this.Tempo);
            this.CEOPage.Controls.Add(this.BalanceWorkRest);
            this.CEOPage.Controls.Add(this.SendMSG);
            this.CEOPage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CEOPage.Location = new System.Drawing.Point(4, 24);
            this.CEOPage.Name = "CEOPage";
            this.CEOPage.Padding = new System.Windows.Forms.Padding(3);
            this.CEOPage.Size = new System.Drawing.Size(792, 350);
            this.CEOPage.TabIndex = 0;
            this.CEOPage.Text = "Me";
            this.CEOPage.UseVisualStyleBackColor = true;
            // 
            // ToolsCheck
            // 
            this.ToolsCheck.Location = new System.Drawing.Point(462, 6);
            this.ToolsCheck.Name = "ToolsCheck";
            this.ToolsCheck.Size = new System.Drawing.Size(82, 23);
            this.ToolsCheck.TabIndex = 5;
            this.ToolsCheck.Text = "Tools Check";
            this.ToolsCheck.UseVisualStyleBackColor = true;
            // 
            // Connections
            // 
            this.Connections.Location = new System.Drawing.Point(374, 6);
            this.Connections.Name = "Connections";
            this.Connections.Size = new System.Drawing.Size(82, 23);
            this.Connections.TabIndex = 4;
            this.Connections.Text = "Connections";
            this.Connections.UseVisualStyleBackColor = true;
            // 
            // Ideas
            // 
            this.Ideas.Location = new System.Drawing.Point(293, 6);
            this.Ideas.Name = "Ideas";
            this.Ideas.Size = new System.Drawing.Size(75, 23);
            this.Ideas.TabIndex = 3;
            this.Ideas.Text = "Ideas";
            this.Ideas.UseVisualStyleBackColor = true;
            // 
            // Tempo
            // 
            this.Tempo.Location = new System.Drawing.Point(212, 6);
            this.Tempo.Name = "Tempo";
            this.Tempo.Size = new System.Drawing.Size(75, 23);
            this.Tempo.TabIndex = 2;
            this.Tempo.Text = "Tempo";
            this.Tempo.UseVisualStyleBackColor = true;
            // 
            // BalanceWorkRest
            // 
            this.BalanceWorkRest.Location = new System.Drawing.Point(89, 6);
            this.BalanceWorkRest.Name = "BalanceWorkRest";
            this.BalanceWorkRest.Size = new System.Drawing.Size(117, 23);
            this.BalanceWorkRest.TabIndex = 1;
            this.BalanceWorkRest.Text = "Balance Work|Rest";
            this.BalanceWorkRest.UseVisualStyleBackColor = true;
            // 
            // SendMSG
            // 
            this.SendMSG.Location = new System.Drawing.Point(8, 6);
            this.SendMSG.Name = "SendMSG";
            this.SendMSG.Size = new System.Drawing.Size(75, 23);
            this.SendMSG.TabIndex = 0;
            this.SendMSG.Text = "Send MSG";
            this.SendMSG.UseVisualStyleBackColor = true;
            // 
            // COOPage
            // 
            this.COOPage.Location = new System.Drawing.Point(4, 24);
            this.COOPage.Name = "COOPage";
            this.COOPage.Padding = new System.Windows.Forms.Padding(3);
            this.COOPage.Size = new System.Drawing.Size(792, 422);
            this.COOPage.TabIndex = 1;
            this.COOPage.Text = "COO";
            this.COOPage.UseVisualStyleBackColor = true;
            // 
            // ClientPage
            // 
            this.ClientPage.Location = new System.Drawing.Point(4, 24);
            this.ClientPage.Name = "ClientPage";
            this.ClientPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClientPage.Size = new System.Drawing.Size(792, 422);
            this.ClientPage.TabIndex = 2;
            this.ClientPage.Text = "Client";
            this.ClientPage.UseVisualStyleBackColor = true;
            // 
            // BAPage
            // 
            this.BAPage.Location = new System.Drawing.Point(4, 24);
            this.BAPage.Name = "BAPage";
            this.BAPage.Padding = new System.Windows.Forms.Padding(3);
            this.BAPage.Size = new System.Drawing.Size(792, 422);
            this.BAPage.TabIndex = 3;
            this.BAPage.Text = "Business Analyst";
            this.BAPage.UseVisualStyleBackColor = true;
            // 
            // PMPage
            // 
            this.PMPage.Location = new System.Drawing.Point(4, 24);
            this.PMPage.Name = "PMPage";
            this.PMPage.Padding = new System.Windows.Forms.Padding(3);
            this.PMPage.Size = new System.Drawing.Size(792, 422);
            this.PMPage.TabIndex = 4;
            this.PMPage.Text = "Product Manager";
            this.PMPage.UseVisualStyleBackColor = true;
            // 
            // QAPage
            // 
            this.QAPage.Location = new System.Drawing.Point(4, 24);
            this.QAPage.Name = "QAPage";
            this.QAPage.Padding = new System.Windows.Forms.Padding(3);
            this.QAPage.Size = new System.Drawing.Size(792, 422);
            this.QAPage.TabIndex = 5;
            this.QAPage.Text = "Quality Assurance";
            this.QAPage.UseVisualStyleBackColor = true;
            // 
            // TechLeadPage
            // 
            this.TechLeadPage.Location = new System.Drawing.Point(4, 24);
            this.TechLeadPage.Name = "TechLeadPage";
            this.TechLeadPage.Padding = new System.Windows.Forms.Padding(3);
            this.TechLeadPage.Size = new System.Drawing.Size(792, 422);
            this.TechLeadPage.TabIndex = 6;
            this.TechLeadPage.Text = "Tech Lead";
            this.TechLeadPage.UseVisualStyleBackColor = true;
            // 
            // DevPage
            // 
            this.DevPage.Location = new System.Drawing.Point(4, 24);
            this.DevPage.Name = "DevPage";
            this.DevPage.Padding = new System.Windows.Forms.Padding(3);
            this.DevPage.Size = new System.Drawing.Size(792, 422);
            this.DevPage.TabIndex = 7;
            this.DevPage.Text = "Developer";
            this.DevPage.UseVisualStyleBackColor = true;
            // 
            // ViraVMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 443);
            this.Controls.Add(this.Virav);
            this.Controls.Add(this.LogOut);
            this.Name = "ViraVMain";
            this.Text = "ViraVMain";
            this.Virav.ResumeLayout(false);
            this.CEOPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button LogOut;
        private TabControl Virav;
        private TabPage CEOPage;
        private Button ToolsCheck;
        private Button Connections;
        private Button Ideas;
        private Button Tempo;
        private Button BalanceWorkRest;
        private Button SendMSG;
        private TabPage COOPage;
        private TabPage ClientPage;
        private TabPage BAPage;
        private TabPage PMPage;
        private TabPage QAPage;
        private TabPage TechLeadPage;
        private TabPage DevPage;
    }
}