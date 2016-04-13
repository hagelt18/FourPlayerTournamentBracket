namespace FourPlayerTournamentBracket
{
    partial class Main
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
            this.btnGo = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt4PVictors = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt3PVictors = new System.Windows.Forms.TextBox();
            this.cb3PMatches = new System.Windows.Forms.CheckBox();
            this.cb2PMatches = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPlayers = new System.Windows.Forms.TextBox();
            this.txtStartingPlayerGroups = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.Location = new System.Drawing.Point(455, 503);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(110, 37);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(115, 9);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(38, 20);
            this.txtTotal.TabIndex = 2;
            this.txtTotal.Text = "15";
            // 
            // txtResults
            // 
            this.txtResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtResults.Location = new System.Drawing.Point(10, 40);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(164, 261);
            this.txtResults.TabIndex = 3;
            this.txtResults.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Players";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Victors in 4p FFA:";
            // 
            // txt4PVictors
            // 
            this.txt4PVictors.Location = new System.Drawing.Point(115, 100);
            this.txt4PVictors.Name = "txt4PVictors";
            this.txt4PVictors.Size = new System.Drawing.Size(38, 20);
            this.txt4PVictors.TabIndex = 5;
            this.txt4PVictors.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Victors in 3p FFA:";
            // 
            // txt3PVictors
            // 
            this.txt3PVictors.Location = new System.Drawing.Point(115, 126);
            this.txt3PVictors.Name = "txt3PVictors";
            this.txt3PVictors.Size = new System.Drawing.Size(38, 20);
            this.txt3PVictors.TabIndex = 7;
            this.txt3PVictors.Text = "1";
            // 
            // cb3PMatches
            // 
            this.cb3PMatches.AutoSize = true;
            this.cb3PMatches.Checked = true;
            this.cb3PMatches.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb3PMatches.Location = new System.Drawing.Point(22, 67);
            this.cb3PMatches.Name = "cb3PMatches";
            this.cb3PMatches.Size = new System.Drawing.Size(110, 17);
            this.cb3PMatches.TabIndex = 9;
            this.cb3PMatches.Text = "Allow 3P matches";
            this.cb3PMatches.UseVisualStyleBackColor = true;
            // 
            // cb2PMatches
            // 
            this.cb2PMatches.AutoSize = true;
            this.cb2PMatches.Location = new System.Drawing.Point(22, 44);
            this.cb2PMatches.Name = "cb2PMatches";
            this.cb2PMatches.Size = new System.Drawing.Size(110, 17);
            this.cb2PMatches.TabIndex = 10;
            this.cb2PMatches.Text = "Allow 2P matches";
            this.cb2PMatches.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Round breakdown:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(285, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 49);
            this.label5.TabIndex = 12;
            this.label5.Text = "Players: (Optional)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPlayers
            // 
            this.txtPlayers.Location = new System.Drawing.Point(350, 9);
            this.txtPlayers.Multiline = true;
            this.txtPlayers.Name = "txtPlayers";
            this.txtPlayers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPlayers.Size = new System.Drawing.Size(214, 158);
            this.txtPlayers.TabIndex = 13;
            this.txtPlayers.WordWrap = false;
            this.txtPlayers.TextChanged += new System.EventHandler(this.txtPlayers_TextChanged);
            // 
            // txtStartingPlayerGroups
            // 
            this.txtStartingPlayerGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStartingPlayerGroups.Location = new System.Drawing.Point(180, 40);
            this.txtStartingPlayerGroups.Multiline = true;
            this.txtStartingPlayerGroups.Name = "txtStartingPlayerGroups";
            this.txtStartingPlayerGroups.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStartingPlayerGroups.Size = new System.Drawing.Size(362, 261);
            this.txtStartingPlayerGroups.TabIndex = 14;
            this.txtStartingPlayerGroups.WordWrap = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtStartingPlayerGroups);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtResults);
            this.panel1.Location = new System.Drawing.Point(12, 182);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 315);
            this.panel1.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(177, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Starting Player Groups:";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Gold;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(551, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Results";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 552);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtPlayers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb2PMatches);
            this.Controls.Add(this.cb3PMatches);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt3PVictors);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt4PVictors);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnGo);
            this.Name = "Main";
            this.Text = "Four Player Tournament Bracket";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt4PVictors;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt3PVictors;
        private System.Windows.Forms.CheckBox cb3PMatches;
        private System.Windows.Forms.CheckBox cb2PMatches;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPlayers;
        private System.Windows.Forms.TextBox txtStartingPlayerGroups;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

