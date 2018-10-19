namespace TrackerUI
{
    partial class CreateTournamentForm
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
            this.createTournamentLabel = new System.Windows.Forms.Label();
            this.tournamentNameValue = new System.Windows.Forms.TextBox();
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.entryFeeValue = new System.Windows.Forms.TextBox();
            this.entryFeeLabel = new System.Windows.Forms.Label();
            this.selectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.selectTeamLabel = new System.Windows.Forms.Label();
            this.createNewTeamLink = new System.Windows.Forms.LinkLabel();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.tournamentPlayerListBox = new System.Windows.Forms.ListBox();
            this.tournamentPlayersLabel = new System.Windows.Forms.Label();
            this.deleteSelectedPLayerButton = new System.Windows.Forms.Button();
            this.deleteSelectedPrizeButton = new System.Windows.Forms.Button();
            this.prizesLabel = new System.Windows.Forms.Label();
            this.prizesListBox = new System.Windows.Forms.ListBox();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createTournamentLabel
            // 
            this.createTournamentLabel.AutoSize = true;
            this.createTournamentLabel.Font = new System.Drawing.Font("Segoe UI Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createTournamentLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.createTournamentLabel.Location = new System.Drawing.Point(33, 30);
            this.createTournamentLabel.Name = "createTournamentLabel";
            this.createTournamentLabel.Size = new System.Drawing.Size(291, 47);
            this.createTournamentLabel.TabIndex = 1;
            this.createTournamentLabel.Text = "CreateTournament";
            // 
            // tournamentNameValue
            // 
            this.tournamentNameValue.Location = new System.Drawing.Point(42, 134);
            this.tournamentNameValue.Name = "tournamentNameValue";
            this.tournamentNameValue.Size = new System.Drawing.Size(282, 35);
            this.tournamentNameValue.TabIndex = 10;
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tournamentNameLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tournamentNameLabel.Location = new System.Drawing.Point(35, 94);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(236, 37);
            this.tournamentNameLabel.TabIndex = 9;
            this.tournamentNameLabel.Text = "Tournament Name";
            // 
            // entryFeeValue
            // 
            this.entryFeeValue.Location = new System.Drawing.Point(165, 198);
            this.entryFeeValue.Name = "entryFeeValue";
            this.entryFeeValue.Size = new System.Drawing.Size(100, 35);
            this.entryFeeValue.TabIndex = 12;
            this.entryFeeValue.Text = "0";
            // 
            // entryFeeLabel
            // 
            this.entryFeeLabel.AutoSize = true;
            this.entryFeeLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.entryFeeLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.entryFeeLabel.Location = new System.Drawing.Point(34, 196);
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Size = new System.Drawing.Size(125, 37);
            this.entryFeeLabel.TabIndex = 11;
            this.entryFeeLabel.Text = "Entry Fee";
            // 
            // selectTeamDropDown
            // 
            this.selectTeamDropDown.FormattingEnabled = true;
            this.selectTeamDropDown.Location = new System.Drawing.Point(42, 318);
            this.selectTeamDropDown.Name = "selectTeamDropDown";
            this.selectTeamDropDown.Size = new System.Drawing.Size(282, 38);
            this.selectTeamDropDown.TabIndex = 14;
            // 
            // selectTeamLabel
            // 
            this.selectTeamLabel.AutoSize = true;
            this.selectTeamLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectTeamLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.selectTeamLabel.Location = new System.Drawing.Point(34, 268);
            this.selectTeamLabel.Name = "selectTeamLabel";
            this.selectTeamLabel.Size = new System.Drawing.Size(156, 37);
            this.selectTeamLabel.TabIndex = 13;
            this.selectTeamLabel.Text = "Select Team";
            this.selectTeamLabel.Click += new System.EventHandler(this.roundLabel_Click);
            // 
            // createNewTeamLink
            // 
            this.createNewTeamLink.AutoSize = true;
            this.createNewTeamLink.Location = new System.Drawing.Point(219, 275);
            this.createNewTeamLink.Name = "createNewTeamLink";
            this.createNewTeamLink.Size = new System.Drawing.Size(114, 30);
            this.createNewTeamLink.TabIndex = 15;
            this.createNewTeamLink.TabStop = true;
            this.createNewTeamLink.Text = "create new";
            // 
            // addTeamButton
            // 
            this.addTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.addTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addTeamButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.addTeamButton.Location = new System.Drawing.Point(98, 371);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(182, 42);
            this.addTeamButton.TabIndex = 16;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = true;
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createPrizeButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.createPrizeButton.Location = new System.Drawing.Point(98, 428);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(182, 42);
            this.createPrizeButton.TabIndex = 17;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // tournamentPlayerListBox
            // 
            this.tournamentPlayerListBox.FormattingEnabled = true;
            this.tournamentPlayerListBox.ItemHeight = 30;
            this.tournamentPlayerListBox.Location = new System.Drawing.Point(419, 134);
            this.tournamentPlayerListBox.Name = "tournamentPlayerListBox";
            this.tournamentPlayerListBox.Size = new System.Drawing.Size(282, 154);
            this.tournamentPlayerListBox.TabIndex = 18;
            // 
            // tournamentPlayersLabel
            // 
            this.tournamentPlayersLabel.AutoSize = true;
            this.tournamentPlayersLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tournamentPlayersLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tournamentPlayersLabel.Location = new System.Drawing.Point(412, 94);
            this.tournamentPlayersLabel.Name = "tournamentPlayersLabel";
            this.tournamentPlayersLabel.Size = new System.Drawing.Size(198, 37);
            this.tournamentPlayersLabel.TabIndex = 19;
            this.tournamentPlayersLabel.Text = "Teams / Players";
            // 
            // deleteSelectedPLayerButton
            // 
            this.deleteSelectedPLayerButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedPLayerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.deleteSelectedPLayerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.deleteSelectedPLayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedPLayerButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteSelectedPLayerButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.deleteSelectedPLayerButton.Location = new System.Drawing.Point(731, 171);
            this.deleteSelectedPLayerButton.Name = "deleteSelectedPLayerButton";
            this.deleteSelectedPLayerButton.Size = new System.Drawing.Size(106, 74);
            this.deleteSelectedPLayerButton.TabIndex = 20;
            this.deleteSelectedPLayerButton.Text = "Delete Selected";
            this.deleteSelectedPLayerButton.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedPrizeButton
            // 
            this.deleteSelectedPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.deleteSelectedPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.deleteSelectedPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteSelectedPrizeButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.deleteSelectedPrizeButton.Location = new System.Drawing.Point(731, 383);
            this.deleteSelectedPrizeButton.Name = "deleteSelectedPrizeButton";
            this.deleteSelectedPrizeButton.Size = new System.Drawing.Size(106, 72);
            this.deleteSelectedPrizeButton.TabIndex = 23;
            this.deleteSelectedPrizeButton.Text = "Delete Selected";
            this.deleteSelectedPrizeButton.UseVisualStyleBackColor = true;
            // 
            // prizesLabel
            // 
            this.prizesLabel.AutoSize = true;
            this.prizesLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prizesLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.prizesLabel.Location = new System.Drawing.Point(412, 305);
            this.prizesLabel.Name = "prizesLabel";
            this.prizesLabel.Size = new System.Drawing.Size(198, 37);
            this.prizesLabel.TabIndex = 22;
            this.prizesLabel.Text = "Teams / Players";
            // 
            // prizesListBox
            // 
            this.prizesListBox.FormattingEnabled = true;
            this.prizesListBox.ItemHeight = 30;
            this.prizesListBox.Location = new System.Drawing.Point(419, 345);
            this.prizesListBox.Name = "prizesListBox";
            this.prizesListBox.Size = new System.Drawing.Size(282, 154);
            this.prizesListBox.TabIndex = 21;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createTournamentButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.createTournamentButton.Location = new System.Drawing.Point(315, 518);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(271, 60);
            this.createTournamentButton.TabIndex = 24;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(894, 615);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.deleteSelectedPrizeButton);
            this.Controls.Add(this.prizesLabel);
            this.Controls.Add(this.prizesListBox);
            this.Controls.Add(this.deleteSelectedPLayerButton);
            this.Controls.Add(this.tournamentPlayersLabel);
            this.Controls.Add(this.tournamentPlayerListBox);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.createNewTeamLink);
            this.Controls.Add(this.selectTeamDropDown);
            this.Controls.Add(this.selectTeamLabel);
            this.Controls.Add(this.entryFeeValue);
            this.Controls.Add(this.entryFeeLabel);
            this.Controls.Add(this.tournamentNameValue);
            this.Controls.Add(this.tournamentNameLabel);
            this.Controls.Add(this.createTournamentLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createTournamentLabel;
        private System.Windows.Forms.TextBox tournamentNameValue;
        private System.Windows.Forms.Label tournamentNameLabel;
        private System.Windows.Forms.TextBox entryFeeValue;
        private System.Windows.Forms.Label entryFeeLabel;
        private System.Windows.Forms.ComboBox selectTeamDropDown;
        private System.Windows.Forms.Label selectTeamLabel;
        private System.Windows.Forms.LinkLabel createNewTeamLink;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Button createPrizeButton;
        private System.Windows.Forms.ListBox tournamentPlayerListBox;
        private System.Windows.Forms.Label tournamentPlayersLabel;
        private System.Windows.Forms.Button deleteSelectedPLayerButton;
        private System.Windows.Forms.Button deleteSelectedPrizeButton;
        private System.Windows.Forms.Label prizesLabel;
        private System.Windows.Forms.ListBox prizesListBox;
        private System.Windows.Forms.Button createTournamentButton;
    }
}