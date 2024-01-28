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
        btnCharFile = new Button();
        txtCharFile = new TextBox();
        label1 = new Label();
        label2 = new Label();
        txtWorldFiles = new TextBox();
        btnWorldFiles = new Button();
        btnBackupCharacter = new Button();
        label3 = new Label();
        txtCharBackupDir = new TextBox();
        btnCharDir = new Button();
        label4 = new Label();
        txtWorldBackupDir = new TextBox();
        btnWorldBackupDir = new Button();
        btnBackupWorld = new Button();
        btnRestoreCharacter = new Button();
        btnRestoreWorld = new Button();
        ofdSelectCharFileDialog = new OpenFileDialog();
        fbdCharacterBackupDir = new FolderBrowserDialog();
        ofdSelectWorldFiles = new OpenFileDialog();
        fbdWorldBackupDir = new FolderBrowserDialog();
        SuspendLayout();
        // 
        // btnCharFile
        // 
        btnCharFile.Cursor = Cursors.Hand;
        btnCharFile.FlatAppearance.BorderColor = Color.FromArgb(115, 115, 140);
        btnCharFile.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 80);
        btnCharFile.FlatStyle = FlatStyle.Flat;
        btnCharFile.ForeColor = Color.FromArgb(0, 255, 185);
        btnCharFile.Location = new Point(26, 93);
        btnCharFile.Name = "btnCharFile";
        btnCharFile.Size = new Size(169, 23);
        btnCharFile.TabIndex = 0;
        btnCharFile.Text = "Select Char File";
        btnCharFile.UseVisualStyleBackColor = true;
        btnCharFile.Click += btnCharFile_Click;
        // 
        // txtCharFile
        // 
        txtCharFile.BackColor = Color.FromArgb(10, 42, 73);
        txtCharFile.BorderStyle = BorderStyle.FixedSingle;
        txtCharFile.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        txtCharFile.ForeColor = SystemColors.Window;
        txtCharFile.Location = new Point(26, 64);
        txtCharFile.Name = "txtCharFile";
        txtCharFile.Size = new Size(420, 25);
        txtCharFile.TabIndex = 1;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.ForeColor = SystemColors.Control;
        label1.Location = new Point(26, 46);
        label1.Name = "label1";
        label1.Size = new Size(79, 15);
        label1.TabIndex = 2;
        label1.Text = "Character File";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.ForeColor = SystemColors.Control;
        label2.Location = new Point(26, 247);
        label2.Name = "label2";
        label2.Size = new Size(65, 15);
        label2.TabIndex = 5;
        label2.Text = "World Files";
        // 
        // txtWorldFiles
        // 
        txtWorldFiles.BackColor = Color.FromArgb(10, 42, 73);
        txtWorldFiles.BorderStyle = BorderStyle.FixedSingle;
        txtWorldFiles.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        txtWorldFiles.ForeColor = SystemColors.Window;
        txtWorldFiles.Location = new Point(26, 265);
        txtWorldFiles.Name = "txtWorldFiles";
        txtWorldFiles.Size = new Size(420, 25);
        txtWorldFiles.TabIndex = 4;
        // 
        // btnWorldFiles
        // 
        btnWorldFiles.Cursor = Cursors.Hand;
        btnWorldFiles.FlatAppearance.BorderColor = Color.FromArgb(115, 115, 140);
        btnWorldFiles.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 80);
        btnWorldFiles.FlatStyle = FlatStyle.Flat;
        btnWorldFiles.ForeColor = Color.FromArgb(0, 255, 185);
        btnWorldFiles.Location = new Point(26, 294);
        btnWorldFiles.Name = "btnWorldFiles";
        btnWorldFiles.Size = new Size(169, 23);
        btnWorldFiles.TabIndex = 3;
        btnWorldFiles.Text = "Select World Files";
        btnWorldFiles.UseVisualStyleBackColor = true;
        btnWorldFiles.Click += btnWorldFiles_Click;
        // 
        // btnBackupCharacter
        // 
        btnBackupCharacter.Cursor = Cursors.Hand;
        btnBackupCharacter.FlatAppearance.BorderColor = Color.FromArgb(115, 115, 140);
        btnBackupCharacter.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 80);
        btnBackupCharacter.FlatStyle = FlatStyle.Flat;
        btnBackupCharacter.ForeColor = Color.FromArgb(0, 255, 185);
        btnBackupCharacter.Location = new Point(26, 462);
        btnBackupCharacter.Name = "btnBackupCharacter";
        btnBackupCharacter.Size = new Size(165, 40);
        btnBackupCharacter.TabIndex = 6;
        btnBackupCharacter.Text = "Backup Character";
        btnBackupCharacter.UseVisualStyleBackColor = true;
        btnBackupCharacter.Click += btnBackupCharacter_Click;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.ForeColor = SystemColors.Control;
        label3.Location = new Point(26, 133);
        label3.Name = "label3";
        label3.Size = new Size(151, 15);
        label3.TabIndex = 9;
        label3.Text = "Character Backup Directory";
        // 
        // txtCharBackupDir
        // 
        txtCharBackupDir.BackColor = Color.FromArgb(10, 42, 73);
        txtCharBackupDir.BorderStyle = BorderStyle.FixedSingle;
        txtCharBackupDir.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        txtCharBackupDir.ForeColor = SystemColors.Window;
        txtCharBackupDir.Location = new Point(26, 151);
        txtCharBackupDir.Name = "txtCharBackupDir";
        txtCharBackupDir.Size = new Size(420, 25);
        txtCharBackupDir.TabIndex = 8;
        // 
        // btnCharDir
        // 
        btnCharDir.Cursor = Cursors.Hand;
        btnCharDir.FlatAppearance.BorderColor = Color.FromArgb(115, 115, 140);
        btnCharDir.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 80);
        btnCharDir.FlatStyle = FlatStyle.Flat;
        btnCharDir.ForeColor = Color.FromArgb(0, 255, 185);
        btnCharDir.Location = new Point(26, 180);
        btnCharDir.Name = "btnCharDir";
        btnCharDir.Size = new Size(169, 23);
        btnCharDir.TabIndex = 7;
        btnCharDir.Text = "Select Backup Location";
        btnCharDir.UseVisualStyleBackColor = true;
        btnCharDir.Click += btnCharDir_Click;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.ForeColor = SystemColors.Control;
        label4.Location = new Point(26, 339);
        label4.Name = "label4";
        label4.Size = new Size(132, 15);
        label4.TabIndex = 12;
        label4.Text = "World Backup Directory";
        // 
        // txtWorldBackupDir
        // 
        txtWorldBackupDir.BackColor = Color.FromArgb(10, 42, 73);
        txtWorldBackupDir.BorderStyle = BorderStyle.FixedSingle;
        txtWorldBackupDir.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        txtWorldBackupDir.ForeColor = SystemColors.Window;
        txtWorldBackupDir.Location = new Point(26, 357);
        txtWorldBackupDir.Name = "txtWorldBackupDir";
        txtWorldBackupDir.Size = new Size(420, 25);
        txtWorldBackupDir.TabIndex = 11;
        // 
        // btnWorldBackupDir
        // 
        btnWorldBackupDir.Cursor = Cursors.Hand;
        btnWorldBackupDir.FlatAppearance.BorderColor = Color.FromArgb(115, 115, 140);
        btnWorldBackupDir.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 80);
        btnWorldBackupDir.FlatStyle = FlatStyle.Flat;
        btnWorldBackupDir.ForeColor = Color.FromArgb(0, 255, 185);
        btnWorldBackupDir.Location = new Point(26, 386);
        btnWorldBackupDir.Name = "btnWorldBackupDir";
        btnWorldBackupDir.Size = new Size(169, 23);
        btnWorldBackupDir.TabIndex = 10;
        btnWorldBackupDir.Text = "Select Backup Location";
        btnWorldBackupDir.UseVisualStyleBackColor = true;
        btnWorldBackupDir.Click += btnWorldBackupDir_Click;
        // 
        // btnBackupWorld
        // 
        btnBackupWorld.Cursor = Cursors.Hand;
        btnBackupWorld.FlatAppearance.BorderColor = Color.FromArgb(115, 115, 140);
        btnBackupWorld.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 80);
        btnBackupWorld.FlatStyle = FlatStyle.Flat;
        btnBackupWorld.ForeColor = Color.FromArgb(0, 255, 185);
        btnBackupWorld.Location = new Point(26, 533);
        btnBackupWorld.Name = "btnBackupWorld";
        btnBackupWorld.Size = new Size(165, 40);
        btnBackupWorld.TabIndex = 13;
        btnBackupWorld.Text = "Backup World";
        btnBackupWorld.UseVisualStyleBackColor = true;
        btnBackupWorld.Click += btnBackupWorld_Click;
        // 
        // btnRestoreCharacter
        // 
        btnRestoreCharacter.Cursor = Cursors.Hand;
        btnRestoreCharacter.FlatAppearance.BorderColor = Color.FromArgb(115, 115, 140);
        btnRestoreCharacter.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 80);
        btnRestoreCharacter.FlatStyle = FlatStyle.Flat;
        btnRestoreCharacter.ForeColor = Color.FromArgb(0, 255, 185);
        btnRestoreCharacter.Location = new Point(281, 462);
        btnRestoreCharacter.Name = "btnRestoreCharacter";
        btnRestoreCharacter.Size = new Size(165, 40);
        btnRestoreCharacter.TabIndex = 14;
        btnRestoreCharacter.Text = "Restore Character";
        btnRestoreCharacter.UseVisualStyleBackColor = true;
        btnRestoreCharacter.Click += btnRestoreCharacter_Click;
        // 
        // btnRestoreWorld
        // 
        btnRestoreWorld.Cursor = Cursors.Hand;
        btnRestoreWorld.FlatAppearance.BorderColor = Color.FromArgb(115, 115, 140);
        btnRestoreWorld.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 80);
        btnRestoreWorld.FlatStyle = FlatStyle.Flat;
        btnRestoreWorld.ForeColor = Color.FromArgb(0, 255, 185);
        btnRestoreWorld.Location = new Point(281, 533);
        btnRestoreWorld.Name = "btnRestoreWorld";
        btnRestoreWorld.Size = new Size(165, 40);
        btnRestoreWorld.TabIndex = 15;
        btnRestoreWorld.Text = "Restore World";
        btnRestoreWorld.UseVisualStyleBackColor = true;
        btnRestoreWorld.Click += btnRestoreWorld_Click;
        // 
        // ofdSelectCharFileDialog
        // 
        ofdSelectCharFileDialog.FileName = "character";
        ofdSelectCharFileDialog.InitialDirectory = "C:\\Users\\russd\\Saved Games\\Enshrouded";
        // 
        // ofdSelectWorldFiles
        // 
        ofdSelectWorldFiles.FileName = "3ad85aea";
        ofdSelectWorldFiles.InitialDirectory = "C:\\Users\\russd\\Saved Games\\Enshrouded";
        ofdSelectWorldFiles.Multiselect = true;
        // 
        // fbdWorldBackupDir
        // 
        fbdWorldBackupDir.InitialDirectory = "C:\\Users\\russd\\Saved Games\\Enshrouded\\wbRealWorld";
        // 
        // frmEnshroudedBackupManager
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(0, 0, 18);
        ClientSize = new Size(471, 602);
        Controls.Add(btnRestoreWorld);
        Controls.Add(btnRestoreCharacter);
        Controls.Add(btnBackupWorld);
        Controls.Add(label4);
        Controls.Add(txtWorldBackupDir);
        Controls.Add(btnWorldBackupDir);
        Controls.Add(label3);
        Controls.Add(txtCharBackupDir);
        Controls.Add(btnCharDir);
        Controls.Add(btnBackupCharacter);
        Controls.Add(label2);
        Controls.Add(txtWorldFiles);
        Controls.Add(btnWorldFiles);
        Controls.Add(label1);
        Controls.Add(txtCharFile);
        Controls.Add(btnCharFile);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "frmEnshroudedBackupManager";
        Text = "Enshrouded Backup Manager";
        Load += frmEnshroudedBackupManager_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnCharFile;
    private TextBox txtCharFile;
    private Label label1;
    private Label label2;
    private TextBox txtWorldFiles;
    private Button btnWorldFiles;
    private Button btnBackupCharacter;
    private Label label3;
    private TextBox txtCharBackupDir;
    private Button btnCharDir;
    private Label label4;
    private TextBox txtWorldBackupDir;
    private Button btnWorldBackupDir;
    private Button btnBackupWorld;
    private Button btnRestoreCharacter;
    private Button btnRestoreWorld;
    private OpenFileDialog ofdSelectCharFileDialog;
    private FolderBrowserDialog fbdCharacterBackupDir;
    private OpenFileDialog ofdSelectWorldFiles;
    private FolderBrowserDialog fbdWorldBackupDir;
}
