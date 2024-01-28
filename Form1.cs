namespace EnshroudedBackupManager;

public partial class frmEnshroudedBackupManager : Form
{
    public frmEnshroudedBackupManager()
    {
        InitializeComponent();
    }

    private void frmEnshroudedBackupManager_Load(object sender, EventArgs e)
    {
        var usersPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

        var charFile = Path.Combine(usersPath, "Saved Games", "Enshrouded", "characters");
        var charBackupDir = Path.Combine(usersPath, "Saved Games", "Enshrouded", "Backup_Chars");

        var worldFilePaths = new List<string>();
        worldFilePaths.Add(Path.Combine(usersPath, "Saved Games", "Enshrouded", "3ad85aea"));
        worldFilePaths.Add(Path.Combine(usersPath, "Saved Games", "Enshrouded", "3ad85aea_info"));

        var worldFiles = string.Join(",", worldFilePaths);
        var worldBackupDir = Path.Combine(usersPath, "Saved Games", "Enshrouded", "Backup_World");


        txtCharFile.Text = charFile;
        txtCharBackupDir.Text = charBackupDir;
        txtWorldFiles.Text = worldFiles;
        txtWorldBackupDir.Text = worldBackupDir;
    }

    private void btnCharFile_Click(object sender, EventArgs e)
    {
        var result = ofdSelectCharFileDialog.ShowDialog();
        if (result == DialogResult.OK)
        {
            var file = ofdSelectCharFileDialog.FileName;
            txtCharFile.Text = file;
        }
    }

    private void btnCharDir_Click(object sender, EventArgs e)
    {
        var result = fbdCharacterBackupDir.ShowDialog();
        if (result == DialogResult.OK)
        {
            var dir = fbdCharacterBackupDir.SelectedPath;
            txtCharBackupDir.Text = dir;
        }
    }

    private void btnWorldFiles_Click(object sender, EventArgs e)
    {
        var result = ofdSelectWorldFiles.ShowDialog();
        if (result == DialogResult.OK)
        {
            var files = ofdSelectWorldFiles.FileNames;
            txtWorldFiles.Text = string.Join(",", files);
        }
    }

    private void btnWorldBackupDir_Click(object sender, EventArgs e)
    {
        var result = fbdWorldBackupDir.ShowDialog();
        if (result == DialogResult.OK)
        {
            var dir = fbdWorldBackupDir.SelectedPath;
            txtWorldBackupDir.Text = dir;
        }
    }

    private void btnBackupCharacter_Click(object sender, EventArgs e)
    {
        var charFile = txtCharFile.Text;
        var charBackupDir = txtCharBackupDir.Text;

        if (string.IsNullOrWhiteSpace(charFile))
        {
            return;
        }

        if (string.IsNullOrWhiteSpace(charBackupDir))
        {
            return;
        }

        File.Copy(charFile, Path.Combine(charBackupDir, Path.GetFileName(charFile)), true);
    }

    private void btnRestoreCharacter_Click(object sender, EventArgs e)
    {
        var charFile = txtCharFile.Text;
        var charBackupDir = txtCharBackupDir.Text;

        if (string.IsNullOrWhiteSpace(charFile))
        {
            return;
        }

        if (string.IsNullOrWhiteSpace(charBackupDir))
        {
            return;
        }

        charBackupDir = Path.Combine(charBackupDir, "characters");
        File.Copy(charBackupDir, charFile, true);
    }

    private void btnBackupWorld_Click(object sender, EventArgs e)
    {
        var worldFiles = txtWorldFiles.Text.Split(',');
        var worldBackupDir = txtWorldBackupDir.Text;

        if (worldFiles.Length <= 0)
        {
            return;
        }

        if (string.IsNullOrWhiteSpace(worldBackupDir))
        {
            return;
        }

        foreach (var file in worldFiles)
        {
            File.Copy(file, Path.Combine(worldBackupDir, Path.GetFileName(file)), true);

        }
    }

    private void btnRestoreWorld_Click(object sender, EventArgs e)
    {
        var worldFiles = txtWorldFiles.Text.Split(',');
        var worldBackupDir = txtWorldBackupDir.Text;

        if (worldFiles.Length <= 0)
        {
            return;
        }

        if (string.IsNullOrWhiteSpace(worldBackupDir))
        {
            return;
        }

        foreach (var file in worldFiles)
        {
            File.Copy(Path.Combine(worldBackupDir, Path.GetFileName(file)), file, true);
        }
    }
}
