namespace EnshroudedBackupManager;

partial class frmEnshroudedBackupManager
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnshroudedBackupManager));
        ofdSelectCharFileDialog = new OpenFileDialog();
        fbdCharacterBackupDir = new FolderBrowserDialog();
        ofdSelectWorldFiles = new OpenFileDialog();
        fbdWorldBackupDir = new FolderBrowserDialog();
        tabsPageSelector = new TabControl();
        tabSaveFileBackup = new TabPage();
        pnlDefaultPathsDialog = new Panel();
        btnUseSavedPaths = new Button();
        chkDoNotAsk = new CheckBox();
        lblDefaultPathsLocatedInfo = new Label();
        btnDefaultPathsUseLocalSavedGames = new Button();
        btnDefaultPathsUseSteamCloud = new Button();
        lblDefaultPathsHeading = new Label();
        lblBackupActionLogs = new Label();
        rtbBackupActionLog = new RichTextBox();
        btnRestoreWorld = new Button();
        btnRestoreCharacter = new Button();
        btnBackupWorld = new Button();
        label4 = new Label();
        txtWorldBackupDir = new TextBox();
        btnWorldBackupDir = new Button();
        label3 = new Label();
        txtCharBackupDir = new TextBox();
        btnCharDir = new Button();
        btnBackupCharacter = new Button();
        label2 = new Label();
        txtWorldFiles = new TextBox();
        btnWorldFiles = new Button();
        label1 = new Label();
        txtCharFile = new TextBox();
        btnCharFile = new Button();
        tabImportSaveFiles = new TabPage();
        btnImportCharToLocal = new Button();
        btnImportCharToSteam = new Button();
        lblLocalDirectory = new Label();
        txtLocalDirectory = new TextBox();
        lblSteamRemoteDirectory = new Label();
        txtSteamRemoteDirectory = new TextBox();
        lblImportWorldAs = new Label();
        cbxSlotOverwrite = new ComboBox();
        btnImportWorldToLocal = new Button();
        btnImportWorldToSteam = new Button();
        lblWorldFilesToImport = new Label();
        txtImportWorldFiles = new TextBox();
        btnImportWorldsSelect = new Button();
        lblCharFileToImport = new Label();
        txtImportCharacterFile = new TextBox();
        btnImportCharSelect = new Button();
        lblImportActionLogs = new Label();
        rtbImportActionLog = new RichTextBox();
        ofdImportCharacterFilePicker = new OpenFileDialog();
        ofdImportWorldFilePicker = new OpenFileDialog();
        tabsPageSelector.SuspendLayout();
        tabSaveFileBackup.SuspendLayout();
        pnlDefaultPathsDialog.SuspendLayout();
        tabImportSaveFiles.SuspendLayout();
        SuspendLayout();
        // 
        // ofdSelectCharFileDialog
        // 
        ofdSelectCharFileDialog.FileName = "character";
        // 
        // ofdSelectWorldFiles
        // 
        ofdSelectWorldFiles.FileName = "3ad85aea";
        ofdSelectWorldFiles.Multiselect = true;
        // 
        // tabsPageSelector
        // 
        tabsPageSelector.Controls.Add(tabSaveFileBackup);
        tabsPageSelector.Controls.Add(tabImportSaveFiles);
        tabsPageSelector.Location = new Point(-4, 0);
        tabsPageSelector.Name = "tabsPageSelector";
        tabsPageSelector.SelectedIndex = 0;
        tabsPageSelector.Size = new Size(657, 946);
        tabsPageSelector.TabIndex = 19;
        // 
        // tabSaveFileBackup
        // 
        tabSaveFileBackup.BackColor = Color.FromArgb(0, 0, 18);
        tabSaveFileBackup.Controls.Add(pnlDefaultPathsDialog);
        tabSaveFileBackup.Controls.Add(lblBackupActionLogs);
        tabSaveFileBackup.Controls.Add(rtbBackupActionLog);
        tabSaveFileBackup.Controls.Add(btnRestoreWorld);
        tabSaveFileBackup.Controls.Add(btnRestoreCharacter);
        tabSaveFileBackup.Controls.Add(btnBackupWorld);
        tabSaveFileBackup.Controls.Add(label4);
        tabSaveFileBackup.Controls.Add(txtWorldBackupDir);
        tabSaveFileBackup.Controls.Add(btnWorldBackupDir);
        tabSaveFileBackup.Controls.Add(label3);
        tabSaveFileBackup.Controls.Add(txtCharBackupDir);
        tabSaveFileBackup.Controls.Add(btnCharDir);
        tabSaveFileBackup.Controls.Add(btnBackupCharacter);
        tabSaveFileBackup.Controls.Add(label2);
        tabSaveFileBackup.Controls.Add(txtWorldFiles);
        tabSaveFileBackup.Controls.Add(btnWorldFiles);
        tabSaveFileBackup.Controls.Add(label1);
        tabSaveFileBackup.Controls.Add(txtCharFile);
        tabSaveFileBackup.Controls.Add(btnCharFile);
        tabSaveFileBackup.Location = new Point(4, 24);
        tabSaveFileBackup.Name = "tabSaveFileBackup";
        tabSaveFileBackup.Padding = new Padding(3);
        tabSaveFileBackup.Size = new Size(649, 918);
        tabSaveFileBackup.TabIndex = 0;
        tabSaveFileBackup.Text = "Backup Save Files";
        // 
        // pnlDefaultPathsDialog
        // 
        pnlDefaultPathsDialog.Controls.Add(btnUseSavedPaths);
        pnlDefaultPathsDialog.Controls.Add(chkDoNotAsk);
        pnlDefaultPathsDialog.Controls.Add(lblDefaultPathsLocatedInfo);
        pnlDefaultPathsDialog.Controls.Add(btnDefaultPathsUseLocalSavedGames);
        pnlDefaultPathsDialog.Controls.Add(btnDefaultPathsUseSteamCloud);
        pnlDefaultPathsDialog.Controls.Add(lblDefaultPathsHeading);
        pnlDefaultPathsDialog.Location = new Point(643, 910);
        pnlDefaultPathsDialog.Name = "pnlDefaultPathsDialog";
        pnlDefaultPathsDialog.Size = new Size(648, 918);
        pnlDefaultPathsDialog.TabIndex = 20;
        // 
        // btnUseSavedPaths
        // 
        btnUseSavedPaths.Cursor = Cursors.Hand;
        btnUseSavedPaths.FlatAppearance.BorderColor = Color.FromArgb(115, 115, 140);
        btnUseSavedPaths.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 80);
        btnUseSavedPaths.FlatStyle = FlatStyle.Flat;
        btnUseSavedPaths.ForeColor = Color.FromArgb(0, 255, 185);
        btnUseSavedPaths.Location = new Point(241, 545);
        btnUseSavedPaths.Name = "btnUseSavedPaths";
        btnUseSavedPaths.Size = new Size(165, 40);
        btnUseSavedPaths.TabIndex = 30;
        btnUseSavedPaths.Text = "Use My Saved Paths";
        btnUseSavedPaths.UseVisualStyleBackColor = true;
        btnUseSavedPaths.Click += btnUseSavedPaths_Click;
        // 
        // chkDoNotAsk
        // 
        chkDoNotAsk.AutoSize = true;
        chkDoNotAsk.ForeColor = SystemColors.ControlLight;
        chkDoNotAsk.Location = new Point(256, 644);
        chkDoNotAsk.Name = "chkDoNotAsk";
        chkDoNotAsk.Size = new Size(134, 19);
        chkDoNotAsk.TabIndex = 29;
        chkDoNotAsk.Text = "Do not ask me again";
        chkDoNotAsk.UseVisualStyleBackColor = true;
        chkDoNotAsk.CheckedChanged += chkDoNotAsk_CheckedChanged;
        // 
        // lblDefaultPathsLocatedInfo
        // 
        lblDefaultPathsLocatedInfo.Anchor = AnchorStyles.None;
        lblDefaultPathsLocatedInfo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        lblDefaultPathsLocatedInfo.ForeColor = SystemColors.Info;
        lblDefaultPathsLocatedInfo.Location = new Point(89, 166);
        lblDefaultPathsLocatedInfo.Name = "lblDefaultPathsLocatedInfo";
        lblDefaultPathsLocatedInfo.Size = new Size(471, 150);
        lblDefaultPathsLocatedInfo.TabIndex = 28;
        lblDefaultPathsLocatedInfo.Text = "Saved files detected in:";
        lblDefaultPathsLocatedInfo.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // btnDefaultPathsUseLocalSavedGames
        // 
        btnDefaultPathsUseLocalSavedGames.Cursor = Cursors.Hand;
        btnDefaultPathsUseLocalSavedGames.FlatAppearance.BorderColor = Color.FromArgb(115, 115, 140);
        btnDefaultPathsUseLocalSavedGames.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 80);
        btnDefaultPathsUseLocalSavedGames.FlatStyle = FlatStyle.Flat;
        btnDefaultPathsUseLocalSavedGames.ForeColor = Color.FromArgb(0, 255, 185);
        btnDefaultPathsUseLocalSavedGames.Location = new Point(241, 449);
        btnDefaultPathsUseLocalSavedGames.Name = "btnDefaultPathsUseLocalSavedGames";
        btnDefaultPathsUseLocalSavedGames.Size = new Size(165, 40);
        btnDefaultPathsUseLocalSavedGames.TabIndex = 26;
        btnDefaultPathsUseLocalSavedGames.Text = "Use Local Saved Games";
        btnDefaultPathsUseLocalSavedGames.UseVisualStyleBackColor = true;
        btnDefaultPathsUseLocalSavedGames.Click += btnDefaultPathsUseLocalSavedGames_Click;
        // 
        // btnDefaultPathsUseSteamCloud
        // 
        btnDefaultPathsUseSteamCloud.Cursor = Cursors.Hand;
        btnDefaultPathsUseSteamCloud.FlatAppearance.BorderColor = Color.FromArgb(115, 115, 140);
        btnDefaultPathsUseSteamCloud.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 80);
        btnDefaultPathsUseSteamCloud.FlatStyle = FlatStyle.Flat;
        btnDefaultPathsUseSteamCloud.ForeColor = Color.FromArgb(0, 255, 185);
        btnDefaultPathsUseSteamCloud.Location = new Point(241, 353);
        btnDefaultPathsUseSteamCloud.Name = "btnDefaultPathsUseSteamCloud";
        btnDefaultPathsUseSteamCloud.Size = new Size(165, 40);
        btnDefaultPathsUseSteamCloud.TabIndex = 25;
        btnDefaultPathsUseSteamCloud.Text = "Use Steam Cloud";
        btnDefaultPathsUseSteamCloud.UseVisualStyleBackColor = true;
        btnDefaultPathsUseSteamCloud.Click += btnDefaultPathsUseSteamCloud_Click;
        // 
        // lblDefaultPathsHeading
        // 
        lblDefaultPathsHeading.Anchor = AnchorStyles.None;
        lblDefaultPathsHeading.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
        lblDefaultPathsHeading.ForeColor = SystemColors.ControlLight;
        lblDefaultPathsHeading.Location = new Point(89, 123);
        lblDefaultPathsHeading.Name = "lblDefaultPathsHeading";
        lblDefaultPathsHeading.Size = new Size(471, 43);
        lblDefaultPathsHeading.TabIndex = 0;
        lblDefaultPathsHeading.Text = "Where are your saved files located?";
        lblDefaultPathsHeading.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblBackupActionLogs
        // 
        lblBackupActionLogs.AutoSize = true;
        lblBackupActionLogs.ForeColor = SystemColors.Control;
        lblBackupActionLogs.Location = new Point(21, 570);
        lblBackupActionLogs.Name = "lblBackupActionLogs";
        lblBackupActionLogs.Size = new Size(70, 15);
        lblBackupActionLogs.TabIndex = 35;
        lblBackupActionLogs.Text = "Action Logs";
        // 
        // rtbBackupActionLog
        // 
        rtbBackupActionLog.BackColor = Color.FromArgb(10, 42, 73);
        rtbBackupActionLog.BorderStyle = BorderStyle.None;
        rtbBackupActionLog.ForeColor = SystemColors.Window;
        rtbBackupActionLog.Location = new Point(21, 588);
        rtbBackupActionLog.Name = "rtbBackupActionLog";
        rtbBackupActionLog.ReadOnly = true;
        rtbBackupActionLog.Size = new Size(605, 305);
        rtbBackupActionLog.TabIndex = 34;
        rtbBackupActionLog.Text = "";
        // 
        // btnRestoreWorld
        // 
        btnRestoreWorld.Cursor = Cursors.Hand;
        btnRestoreWorld.FlatAppearance.BorderColor = Color.FromArgb(115, 115, 140);
        btnRestoreWorld.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 80);
        btnRestoreWorld.FlatStyle = FlatStyle.Flat;
        btnRestoreWorld.ForeColor = Color.FromArgb(0, 255, 185);
        btnRestoreWorld.Location = new Point(371, 504);
        btnRestoreWorld.Name = "btnRestoreWorld";
        btnRestoreWorld.Size = new Size(165, 40);
        btnRestoreWorld.TabIndex = 33;
        btnRestoreWorld.Text = "Restore World";
        btnRestoreWorld.UseVisualStyleBackColor = true;
        btnRestoreWorld.Click += btnRestoreWorld_Click;
        // 
        // btnRestoreCharacter
        // 
        btnRestoreCharacter.Cursor = Cursors.Hand;
        btnRestoreCharacter.FlatAppearance.BorderColor = Color.FromArgb(115, 115, 140);
        btnRestoreCharacter.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 80);
        btnRestoreCharacter.FlatStyle = FlatStyle.Flat;
        btnRestoreCharacter.ForeColor = Color.FromArgb(0, 255, 185);
        btnRestoreCharacter.Location = new Point(371, 433);
        btnRestoreCharacter.Name = "btnRestoreCharacter";
        btnRestoreCharacter.Size = new Size(165, 40);
        btnRestoreCharacter.TabIndex = 32;
        btnRestoreCharacter.Text = "Restore Character";
        btnRestoreCharacter.UseVisualStyleBackColor = true;
        btnRestoreCharacter.Click += btnRestoreCharacter_Click;
        // 
        // btnBackupWorld
        // 
        btnBackupWorld.Cursor = Cursors.Hand;
        btnBackupWorld.FlatAppearance.BorderColor = Color.FromArgb(115, 115, 140);
        btnBackupWorld.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 80);
        btnBackupWorld.FlatStyle = FlatStyle.Flat;
        btnBackupWorld.ForeColor = Color.FromArgb(0, 255, 185);
        btnBackupWorld.Location = new Point(116, 504);
        btnBackupWorld.Name = "btnBackupWorld";
        btnBackupWorld.Size = new Size(165, 40);
        btnBackupWorld.TabIndex = 31;
        btnBackupWorld.Text = "Backup World";
        btnBackupWorld.UseVisualStyleBackColor = true;
        btnBackupWorld.Click += btnBackupWorld_Click;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.ForeColor = SystemColors.Control;
        label4.Location = new Point(22, 315);
        label4.Name = "label4";
        label4.Size = new Size(132, 15);
        label4.TabIndex = 30;
        label4.Text = "World Backup Directory";
        // 
        // txtWorldBackupDir
        // 
        txtWorldBackupDir.BackColor = Color.FromArgb(10, 42, 73);
        txtWorldBackupDir.BorderStyle = BorderStyle.FixedSingle;
        txtWorldBackupDir.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        txtWorldBackupDir.ForeColor = SystemColors.Window;
        txtWorldBackupDir.Location = new Point(22, 333);
        txtWorldBackupDir.Name = "txtWorldBackupDir";
        txtWorldBackupDir.Size = new Size(604, 25);
        txtWorldBackupDir.TabIndex = 29;
        txtWorldBackupDir.Leave += OnBackupInputBlur_Leave;
        // 
        // btnWorldBackupDir
        // 
        btnWorldBackupDir.Cursor = Cursors.Hand;
        btnWorldBackupDir.FlatAppearance.BorderColor = Color.FromArgb(115, 115, 140);
        btnWorldBackupDir.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 80);
        btnWorldBackupDir.FlatStyle = FlatStyle.Flat;
        btnWorldBackupDir.ForeColor = Color.FromArgb(0, 255, 185);
        btnWorldBackupDir.Location = new Point(22, 362);
        btnWorldBackupDir.Name = "btnWorldBackupDir";
        btnWorldBackupDir.Size = new Size(169, 23);
        btnWorldBackupDir.TabIndex = 28;
        btnWorldBackupDir.Text = "Select Backup Location";
        btnWorldBackupDir.UseVisualStyleBackColor = true;
        btnWorldBackupDir.Click += btnWorldBackupDir_Click;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.ForeColor = SystemColors.Control;
        label3.Location = new Point(22, 109);
        label3.Name = "label3";
        label3.Size = new Size(151, 15);
        label3.TabIndex = 27;
        label3.Text = "Character Backup Directory";
        // 
        // txtCharBackupDir
        // 
        txtCharBackupDir.BackColor = Color.FromArgb(10, 42, 73);
        txtCharBackupDir.BorderStyle = BorderStyle.FixedSingle;
        txtCharBackupDir.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        txtCharBackupDir.ForeColor = SystemColors.Window;
        txtCharBackupDir.Location = new Point(22, 127);
        txtCharBackupDir.Name = "txtCharBackupDir";
        txtCharBackupDir.Size = new Size(604, 25);
        txtCharBackupDir.TabIndex = 26;
        txtCharBackupDir.Leave += OnBackupInputBlur_Leave;
        // 
        // btnCharDir
        // 
        btnCharDir.Cursor = Cursors.Hand;
        btnCharDir.FlatAppearance.BorderColor = Color.FromArgb(115, 115, 140);
        btnCharDir.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 80);
        btnCharDir.FlatStyle = FlatStyle.Flat;
        btnCharDir.ForeColor = Color.FromArgb(0, 255, 185);
        btnCharDir.Location = new Point(22, 156);
        btnCharDir.Name = "btnCharDir";
        btnCharDir.Size = new Size(169, 23);
        btnCharDir.TabIndex = 25;
        btnCharDir.Text = "Select Backup Location";
        btnCharDir.UseVisualStyleBackColor = true;
        btnCharDir.Click += btnCharDir_Click;
        // 
        // btnBackupCharacter
        // 
        btnBackupCharacter.Cursor = Cursors.Hand;
        btnBackupCharacter.FlatAppearance.BorderColor = Color.FromArgb(115, 115, 140);
        btnBackupCharacter.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 80);
        btnBackupCharacter.FlatStyle = FlatStyle.Flat;
        btnBackupCharacter.ForeColor = Color.FromArgb(0, 255, 185);
        btnBackupCharacter.Location = new Point(116, 433);
        btnBackupCharacter.Name = "btnBackupCharacter";
        btnBackupCharacter.Size = new Size(165, 40);
        btnBackupCharacter.TabIndex = 24;
        btnBackupCharacter.Text = "Backup Character";
        btnBackupCharacter.UseVisualStyleBackColor = true;
        btnBackupCharacter.Click += btnBackupCharacter_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.ForeColor = SystemColors.Control;
        label2.Location = new Point(22, 223);
        label2.Name = "label2";
        label2.Size = new Size(65, 15);
        label2.TabIndex = 23;
        label2.Text = "World Files";
        // 
        // txtWorldFiles
        // 
        txtWorldFiles.BackColor = Color.FromArgb(10, 42, 73);
        txtWorldFiles.BorderStyle = BorderStyle.FixedSingle;
        txtWorldFiles.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        txtWorldFiles.ForeColor = SystemColors.Window;
        txtWorldFiles.Location = new Point(22, 241);
        txtWorldFiles.Name = "txtWorldFiles";
        txtWorldFiles.Size = new Size(604, 25);
        txtWorldFiles.TabIndex = 22;
        txtWorldFiles.Leave += OnBackupInputBlur_Leave;
        // 
        // btnWorldFiles
        // 
        btnWorldFiles.Cursor = Cursors.Hand;
        btnWorldFiles.FlatAppearance.BorderColor = Color.FromArgb(115, 115, 140);
        btnWorldFiles.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 80);
        btnWorldFiles.FlatStyle = FlatStyle.Flat;
        btnWorldFiles.ForeColor = Color.FromArgb(0, 255, 185);
        btnWorldFiles.Location = new Point(22, 270);
        btnWorldFiles.Name = "btnWorldFiles";
        btnWorldFiles.Size = new Size(169, 23);
        btnWorldFiles.TabIndex = 21;
        btnWorldFiles.Text = "Select World Files";
        btnWorldFiles.UseVisualStyleBackColor = true;
        btnWorldFiles.Click += btnWorldFiles_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.ForeColor = SystemColors.Control;
        label1.Location = new Point(22, 22);
        label1.Name = "label1";
        label1.Size = new Size(79, 15);
        label1.TabIndex = 20;
        label1.Text = "Character File";
        // 
        // txtCharFile
        // 
        txtCharFile.BackColor = Color.FromArgb(10, 42, 73);
        txtCharFile.BorderStyle = BorderStyle.FixedSingle;
        txtCharFile.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        txtCharFile.ForeColor = SystemColors.Window;
        txtCharFile.Location = new Point(22, 40);
        txtCharFile.Name = "txtCharFile";
        txtCharFile.Size = new Size(604, 25);
        txtCharFile.TabIndex = 19;
        txtCharFile.Leave += OnBackupInputBlur_Leave;
        // 
        // btnCharFile
        // 
        btnCharFile.Cursor = Cursors.Hand;
        btnCharFile.FlatAppearance.BorderColor = Color.FromArgb(115, 115, 140);
        btnCharFile.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 80);
        btnCharFile.FlatStyle = FlatStyle.Flat;
        btnCharFile.ForeColor = Color.FromArgb(0, 255, 185);
        btnCharFile.Location = new Point(22, 69);
        btnCharFile.Name = "btnCharFile";
        btnCharFile.Size = new Size(169, 23);
        btnCharFile.TabIndex = 18;
        btnCharFile.Text = "Select Char File";
        btnCharFile.UseVisualStyleBackColor = true;
        btnCharFile.Click += btnCharFile_Click;
        // 
        // tabImportSaveFiles
        // 
        tabImportSaveFiles.BackColor = Color.FromArgb(0, 0, 18);
        tabImportSaveFiles.Controls.Add(btnImportCharToLocal);
        tabImportSaveFiles.Controls.Add(btnImportCharToSteam);
        tabImportSaveFiles.Controls.Add(lblLocalDirectory);
        tabImportSaveFiles.Controls.Add(txtLocalDirectory);
        tabImportSaveFiles.Controls.Add(lblSteamRemoteDirectory);
        tabImportSaveFiles.Controls.Add(txtSteamRemoteDirectory);
        tabImportSaveFiles.Controls.Add(lblImportWorldAs);
        tabImportSaveFiles.Controls.Add(cbxSlotOverwrite);
        tabImportSaveFiles.Controls.Add(btnImportWorldToLocal);
        tabImportSaveFiles.Controls.Add(btnImportWorldToSteam);
        tabImportSaveFiles.Controls.Add(lblWorldFilesToImport);
        tabImportSaveFiles.Controls.Add(txtImportWorldFiles);
        tabImportSaveFiles.Controls.Add(btnImportWorldsSelect);
        tabImportSaveFiles.Controls.Add(lblCharFileToImport);
        tabImportSaveFiles.Controls.Add(txtImportCharacterFile);
        tabImportSaveFiles.Controls.Add(btnImportCharSelect);
        tabImportSaveFiles.Controls.Add(lblImportActionLogs);
        tabImportSaveFiles.Controls.Add(rtbImportActionLog);
        tabImportSaveFiles.Location = new Point(4, 24);
        tabImportSaveFiles.Name = "tabImportSaveFiles";
        tabImportSaveFiles.Padding = new Padding(3);
        tabImportSaveFiles.Size = new Size(649, 918);
        tabImportSaveFiles.TabIndex = 1;
        tabImportSaveFiles.Text = "Import Save Files";
        // 
        // btnImportCharToLocal
        // 
        btnImportCharToLocal.Cursor = Cursors.Hand;
        btnImportCharToLocal.FlatAppearance.BorderColor = Color.FromArgb(115, 115, 140);
        btnImportCharToLocal.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 80);
        btnImportCharToLocal.FlatStyle = FlatStyle.Flat;
        btnImportCharToLocal.ForeColor = Color.FromArgb(0, 255, 185);
        btnImportCharToLocal.Location = new Point(352, 120);
        btnImportCharToLocal.Name = "btnImportCharToLocal";
        btnImportCharToLocal.Size = new Size(200, 40);
        btnImportCharToLocal.TabIndex = 55;
        btnImportCharToLocal.Text = "Import Characters to Local Folder";
        btnImportCharToLocal.UseVisualStyleBackColor = true;
        btnImportCharToLocal.Click += btnImportCharToLocal_Click;
        // 
        // btnImportCharToSteam
        // 
        btnImportCharToSteam.Cursor = Cursors.Hand;
        btnImportCharToSteam.FlatAppearance.BorderColor = Color.FromArgb(115, 115, 140);
        btnImportCharToSteam.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 80);
        btnImportCharToSteam.FlatStyle = FlatStyle.Flat;
        btnImportCharToSteam.ForeColor = Color.FromArgb(0, 255, 185);
        btnImportCharToSteam.Location = new Point(96, 120);
        btnImportCharToSteam.Name = "btnImportCharToSteam";
        btnImportCharToSteam.Size = new Size(200, 40);
        btnImportCharToSteam.TabIndex = 54;
        btnImportCharToSteam.Text = "Import Characters to Steam Folder";
        btnImportCharToSteam.UseVisualStyleBackColor = true;
        btnImportCharToSteam.Click += btnImportCharToSteam_Click;
        // 
        // lblLocalDirectory
        // 
        lblLocalDirectory.AutoSize = true;
        lblLocalDirectory.ForeColor = SystemColors.Control;
        lblLocalDirectory.Location = new Point(22, 509);
        lblLocalDirectory.Name = "lblLocalDirectory";
        lblLocalDirectory.Size = new Size(134, 15);
        lblLocalDirectory.TabIndex = 53;
        lblLocalDirectory.Text = "Local Save File Directory";
        // 
        // txtLocalDirectory
        // 
        txtLocalDirectory.BackColor = Color.FromArgb(10, 42, 73);
        txtLocalDirectory.BorderStyle = BorderStyle.FixedSingle;
        txtLocalDirectory.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        txtLocalDirectory.ForeColor = SystemColors.Window;
        txtLocalDirectory.Location = new Point(22, 527);
        txtLocalDirectory.Name = "txtLocalDirectory";
        txtLocalDirectory.Size = new Size(605, 25);
        txtLocalDirectory.TabIndex = 52;
        // 
        // lblSteamRemoteDirectory
        // 
        lblSteamRemoteDirectory.AutoSize = true;
        lblSteamRemoteDirectory.ForeColor = SystemColors.Control;
        lblSteamRemoteDirectory.Location = new Point(22, 449);
        lblSteamRemoteDirectory.Name = "lblSteamRemoteDirectory";
        lblSteamRemoteDirectory.Size = new Size(174, 15);
        lblSteamRemoteDirectory.TabIndex = 51;
        lblSteamRemoteDirectory.Text = "Steam Cloud Save File Directory";
        // 
        // txtSteamRemoteDirectory
        // 
        txtSteamRemoteDirectory.BackColor = Color.FromArgb(10, 42, 73);
        txtSteamRemoteDirectory.BorderStyle = BorderStyle.FixedSingle;
        txtSteamRemoteDirectory.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        txtSteamRemoteDirectory.ForeColor = SystemColors.Window;
        txtSteamRemoteDirectory.Location = new Point(22, 467);
        txtSteamRemoteDirectory.Name = "txtSteamRemoteDirectory";
        txtSteamRemoteDirectory.Size = new Size(605, 25);
        txtSteamRemoteDirectory.TabIndex = 50;
        // 
        // lblImportWorldAs
        // 
        lblImportWorldAs.AutoSize = true;
        lblImportWorldAs.ForeColor = SystemColors.Control;
        lblImportWorldAs.Location = new Point(21, 283);
        lblImportWorldAs.Name = "lblImportWorldAs";
        lblImportWorldAs.Size = new Size(328, 30);
        lblImportWorldAs.TabIndex = 47;
        lblImportWorldAs.Text = "Select a Slot to overwrite or attempt to use the next open slot\r\n(If a save file is overwritten, a backup will be created for you)";
        // 
        // cbxSlotOverwrite
        // 
        cbxSlotOverwrite.BackColor = Color.FromArgb(10, 42, 73);
        cbxSlotOverwrite.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxSlotOverwrite.FlatStyle = FlatStyle.Flat;
        cbxSlotOverwrite.ForeColor = SystemColors.ControlLight;
        cbxSlotOverwrite.FormattingEnabled = true;
        cbxSlotOverwrite.Location = new Point(22, 316);
        cbxSlotOverwrite.Name = "cbxSlotOverwrite";
        cbxSlotOverwrite.Size = new Size(604, 23);
        cbxSlotOverwrite.TabIndex = 46;
        // 
        // btnImportWorldToLocal
        // 
        btnImportWorldToLocal.Cursor = Cursors.Hand;
        btnImportWorldToLocal.FlatAppearance.BorderColor = Color.FromArgb(115, 115, 140);
        btnImportWorldToLocal.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 80);
        btnImportWorldToLocal.FlatStyle = FlatStyle.Flat;
        btnImportWorldToLocal.ForeColor = Color.FromArgb(0, 255, 185);
        btnImportWorldToLocal.Location = new Point(352, 361);
        btnImportWorldToLocal.Name = "btnImportWorldToLocal";
        btnImportWorldToLocal.Size = new Size(200, 40);
        btnImportWorldToLocal.TabIndex = 45;
        btnImportWorldToLocal.Text = "Import World to Local Folder";
        btnImportWorldToLocal.UseVisualStyleBackColor = true;
        btnImportWorldToLocal.Click += btnImportWorldToLocal_Click;
        // 
        // btnImportWorldToSteam
        // 
        btnImportWorldToSteam.Cursor = Cursors.Hand;
        btnImportWorldToSteam.FlatAppearance.BorderColor = Color.FromArgb(115, 115, 140);
        btnImportWorldToSteam.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 80);
        btnImportWorldToSteam.FlatStyle = FlatStyle.Flat;
        btnImportWorldToSteam.ForeColor = Color.FromArgb(0, 255, 185);
        btnImportWorldToSteam.Location = new Point(96, 361);
        btnImportWorldToSteam.Name = "btnImportWorldToSteam";
        btnImportWorldToSteam.Size = new Size(200, 40);
        btnImportWorldToSteam.TabIndex = 44;
        btnImportWorldToSteam.Text = "Import World to Steam Folder";
        btnImportWorldToSteam.UseVisualStyleBackColor = true;
        btnImportWorldToSteam.Click += btnImportWorldToSteam_Click;
        // 
        // lblWorldFilesToImport
        // 
        lblWorldFilesToImport.AutoSize = true;
        lblWorldFilesToImport.ForeColor = SystemColors.Control;
        lblWorldFilesToImport.Location = new Point(22, 203);
        lblWorldFilesToImport.Name = "lblWorldFilesToImport";
        lblWorldFilesToImport.Size = new Size(323, 15);
        lblWorldFilesToImport.TabIndex = 43;
        lblWorldFilesToImport.Text = "World Files to Import (Only select files for one slot at a time)";
        // 
        // txtImportWorldFiles
        // 
        txtImportWorldFiles.BackColor = Color.FromArgb(10, 42, 73);
        txtImportWorldFiles.BorderStyle = BorderStyle.FixedSingle;
        txtImportWorldFiles.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        txtImportWorldFiles.ForeColor = SystemColors.Window;
        txtImportWorldFiles.Location = new Point(22, 221);
        txtImportWorldFiles.Name = "txtImportWorldFiles";
        txtImportWorldFiles.Size = new Size(604, 25);
        txtImportWorldFiles.TabIndex = 42;
        // 
        // btnImportWorldsSelect
        // 
        btnImportWorldsSelect.Cursor = Cursors.Hand;
        btnImportWorldsSelect.FlatAppearance.BorderColor = Color.FromArgb(115, 115, 140);
        btnImportWorldsSelect.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 80);
        btnImportWorldsSelect.FlatStyle = FlatStyle.Flat;
        btnImportWorldsSelect.ForeColor = Color.FromArgb(0, 255, 185);
        btnImportWorldsSelect.Location = new Point(22, 250);
        btnImportWorldsSelect.Name = "btnImportWorldsSelect";
        btnImportWorldsSelect.Size = new Size(169, 23);
        btnImportWorldsSelect.TabIndex = 41;
        btnImportWorldsSelect.Text = "Select World Files";
        btnImportWorldsSelect.UseVisualStyleBackColor = true;
        btnImportWorldsSelect.Click += btnImportWorldsSelect_Click;
        // 
        // lblCharFileToImport
        // 
        lblCharFileToImport.AutoSize = true;
        lblCharFileToImport.ForeColor = SystemColors.Control;
        lblCharFileToImport.Location = new Point(22, 22);
        lblCharFileToImport.Name = "lblCharFileToImport";
        lblCharFileToImport.Size = new Size(132, 15);
        lblCharFileToImport.TabIndex = 40;
        lblCharFileToImport.Text = "Character File to Import";
        // 
        // txtImportCharacterFile
        // 
        txtImportCharacterFile.BackColor = Color.FromArgb(10, 42, 73);
        txtImportCharacterFile.BorderStyle = BorderStyle.FixedSingle;
        txtImportCharacterFile.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        txtImportCharacterFile.ForeColor = SystemColors.Window;
        txtImportCharacterFile.Location = new Point(22, 40);
        txtImportCharacterFile.Name = "txtImportCharacterFile";
        txtImportCharacterFile.Size = new Size(604, 25);
        txtImportCharacterFile.TabIndex = 39;
        // 
        // btnImportCharSelect
        // 
        btnImportCharSelect.Cursor = Cursors.Hand;
        btnImportCharSelect.FlatAppearance.BorderColor = Color.FromArgb(115, 115, 140);
        btnImportCharSelect.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 80);
        btnImportCharSelect.FlatStyle = FlatStyle.Flat;
        btnImportCharSelect.ForeColor = Color.FromArgb(0, 255, 185);
        btnImportCharSelect.Location = new Point(22, 69);
        btnImportCharSelect.Name = "btnImportCharSelect";
        btnImportCharSelect.Size = new Size(169, 23);
        btnImportCharSelect.TabIndex = 38;
        btnImportCharSelect.Text = "Select Char File";
        btnImportCharSelect.UseVisualStyleBackColor = true;
        btnImportCharSelect.Click += btnImportCharSelect_Click;
        // 
        // lblImportActionLogs
        // 
        lblImportActionLogs.AutoSize = true;
        lblImportActionLogs.ForeColor = SystemColors.Control;
        lblImportActionLogs.Location = new Point(21, 570);
        lblImportActionLogs.Name = "lblImportActionLogs";
        lblImportActionLogs.Size = new Size(70, 15);
        lblImportActionLogs.TabIndex = 37;
        lblImportActionLogs.Text = "Action Logs";
        // 
        // rtbImportActionLog
        // 
        rtbImportActionLog.BackColor = Color.FromArgb(10, 42, 73);
        rtbImportActionLog.BorderStyle = BorderStyle.None;
        rtbImportActionLog.ForeColor = SystemColors.Window;
        rtbImportActionLog.Location = new Point(21, 588);
        rtbImportActionLog.Name = "rtbImportActionLog";
        rtbImportActionLog.ReadOnly = true;
        rtbImportActionLog.Size = new Size(605, 305);
        rtbImportActionLog.TabIndex = 36;
        rtbImportActionLog.Text = "";
        // 
        // ofdImportWorldFilePicker
        // 
        ofdImportWorldFilePicker.Multiselect = true;
        // 
        // frmEnshroudedBackupManager
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(0, 0, 18);
        ClientSize = new Size(648, 940);
        Controls.Add(tabsPageSelector);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "frmEnshroudedBackupManager";
        Text = "Enshrouded Backup Manager";
        Load += frmEnshroudedBackupManager_Load;
        tabsPageSelector.ResumeLayout(false);
        tabSaveFileBackup.ResumeLayout(false);
        tabSaveFileBackup.PerformLayout();
        pnlDefaultPathsDialog.ResumeLayout(false);
        pnlDefaultPathsDialog.PerformLayout();
        tabImportSaveFiles.ResumeLayout(false);
        tabImportSaveFiles.PerformLayout();
        ResumeLayout(false);
    }

    #endregion
    private OpenFileDialog ofdSelectCharFileDialog;
    private FolderBrowserDialog fbdCharacterBackupDir;
    private OpenFileDialog ofdSelectWorldFiles;
    private FolderBrowserDialog fbdWorldBackupDir;
    private Label lblSetDefaultPaths;
    private Button btnPathDefaultSteamCloud;
    private Label lblSteamSavesExplanation;
    private Button btnPathDefaultLocal;
    private TabControl tabsPageSelector;
    private TabPage tabSaveFileBackup;
    private Label lblBackupActionLogs;
    private RichTextBox rtbBackupActionLog;
    private Button btnRestoreWorld;
    private Button btnRestoreCharacter;
    private Button btnBackupWorld;
    private Label label4;
    private TextBox txtWorldBackupDir;
    private Button btnWorldBackupDir;
    private Label label3;
    private TextBox txtCharBackupDir;
    private Button btnCharDir;
    private Button btnBackupCharacter;
    private Label label2;
    private TextBox txtWorldFiles;
    private Button btnWorldFiles;
    private Label label1;
    private TextBox txtCharFile;
    private Button btnCharFile;
    private TabPage tabImportSaveFiles;
    private Label lblImportActionLogs;
    private RichTextBox rtbImportActionLog;
    private Label lblCharFileToImport;
    private TextBox txtImportCharacterFile;
    private Button btnImportCharSelect;
    private Label lblWorldFilesToImport;
    private TextBox txtImportWorldFiles;
    private Button btnImportWorldsSelect;
    private Button btnImportWorldToLocal;
    private Button btnImportWorldToSteam;
    private ComboBox cbxSlotOverwrite;
    private Label lblImportWorldAsInfo;
    private Label lblImportWorldAs;
    private Label lblDefaultPathsLocatedInfo;
    private OpenFileDialog ofdImportCharacterFilePicker;
    private Label lblLocalDirectory;
    private TextBox txtLocalDirectory;
    private Label lblSteamRemoteDirectory;
    private TextBox txtSteamRemoteDirectory;
    private Panel pnlDefaultPathsDialog;
    private Label lblDefaultPathsHeading;
    private Button btnDefaultPathsUseLocalSavedGames;
    private Button btnDefaultPathsUseSteamCloud;
    private CheckBox chkDoNotAsk;
    private Button btnUseSavedPaths;
    private OpenFileDialog ofdImportWorldFilePicker;
    private Button btnImportCharToLocal;
    private Button btnImportCharToSteam;
}
