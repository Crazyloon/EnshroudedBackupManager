using EnshroudedBackupManager.Models;
using Newtonsoft.Json;

namespace EnshroudedBackupManager;

public partial class frmEnshroudedBackupManager : Form
{
    private List<string> _actionLogs = new List<string>(10);


    public frmEnshroudedBackupManager()
    {
        InitializeComponent();
    }

    private void frmEnshroudedBackupManager_Load(object sender, EventArgs e)
    {
        string charFile, charBackupDir, worldFiles, worldBackupDir;

        if (File.Exists(Path.Combine("Data", "filePaths.json")))
        {
            var filePathsJson = File.ReadAllText(Path.Combine("Data", "filePaths.json"));
            var filePaths = JsonConvert.DeserializeObject<FilePaths>(filePathsJson);

            if (filePaths == null)
            {
                setDefaultPaths();
                return;
            }

            txtCharFile.Text = filePaths.CharacterFilePath;
            txtCharBackupDir.Text = filePaths.CharacterBackupDirectory;
            txtWorldFiles.Text = filePaths.WorldFilePath;
            txtWorldBackupDir.Text = filePaths.WorldBackupDirectory;

            WriteActionLog("Paths Loaded from filePaths.json");
        }
        else
        {
            setDefaultPaths();
            WritePathsToJson();
        }

        void setDefaultPaths()
        {
            var usersPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

            charFile = Path.Combine(usersPath, "Saved Games", "Enshrouded", "characters");
            charBackupDir = Path.Combine(usersPath, "Saved Games", "Enshrouded", "Backup_Chars");

            var worldFilePaths = new List<string>();
            worldFilePaths.Add(Path.Combine(usersPath, "Saved Games", "Enshrouded", "3ad85aea"));
            worldFilePaths.Add(Path.Combine(usersPath, "Saved Games", "Enshrouded", "3ad85aea_info"));

            worldFiles = string.Join(",", worldFilePaths);
            worldBackupDir = Path.Combine(usersPath, "Saved Games", "Enshrouded", "Backup_World");

            txtCharFile.Text = charFile;
            txtCharBackupDir.Text = charBackupDir;
            txtWorldFiles.Text = worldFiles;
            txtWorldBackupDir.Text = worldBackupDir;

            WriteActionLog("Default paths Loaded");
        }
    }

    private void btnCharFile_Click(object sender, EventArgs e)
    {
        var result = ofdSelectCharFileDialog.ShowDialog();
        if (result == DialogResult.OK)
        {
            var file = ofdSelectCharFileDialog.FileName;
            txtCharFile.Text = file;

            WriteActionLog($"Character File Selected");
        }
    }

    private void btnCharDir_Click(object sender, EventArgs e)
    {
        var result = fbdCharacterBackupDir.ShowDialog();
        if (result == DialogResult.OK)
        {
            var dir = fbdCharacterBackupDir.SelectedPath;
            txtCharBackupDir.Text = dir;

            WriteActionLog("Character Backup Directory Selected");
        }
    }

    private void btnWorldFiles_Click(object sender, EventArgs e)
    {
        var result = ofdSelectWorldFiles.ShowDialog();
        if (result == DialogResult.OK)
        {
            var files = ofdSelectWorldFiles.FileNames;
            txtWorldFiles.Text = string.Join(",", files);

            WriteActionLog("World Files Selected");
        }
    }

    private void btnWorldBackupDir_Click(object sender, EventArgs e)
    {
        var result = fbdWorldBackupDir.ShowDialog();
        if (result == DialogResult.OK)
        {
            var dir = fbdWorldBackupDir.SelectedPath;
            txtWorldBackupDir.Text = dir;

            WriteActionLog("World Backup Directory Selected");
        }
    }

    private void btnBackupCharacter_Click(object sender, EventArgs e)
    {
        var charFile = txtCharFile.Text;
        var charBackupDir = txtCharBackupDir.Text;

        if (string.IsNullOrWhiteSpace(charFile))
        {
            WriteActionLog("ERROR: No Character File Selected");
            return;
        }

        if (string.IsNullOrWhiteSpace(charBackupDir))
        {
            WriteActionLog("ERROR: No Character Backup Directory Selected");
            return;
        }

        File.Copy(charFile, Path.Combine(charBackupDir, Path.GetFileName(charFile)), true);

        WriteActionLog("Character File Backed Up");
    }

    private void btnRestoreCharacter_Click(object sender, EventArgs e)
    {
        var charFile = txtCharFile.Text;
        var charBackupDir = txtCharBackupDir.Text;

        if (string.IsNullOrWhiteSpace(charFile))
        {
            WriteActionLog("ERROR: No Character File Selected");
            return;
        }

        if (string.IsNullOrWhiteSpace(charBackupDir))
        {
            WriteActionLog("ERROR: No Character Backup Directory Selected");
            return;
        }

        charBackupDir = Path.Combine(charBackupDir, "characters");
        File.Copy(charBackupDir, charFile, true);

        WriteActionLog("Character File Restored");
    }

    private void btnBackupWorld_Click(object sender, EventArgs e)
    {
        var worldFiles = txtWorldFiles.Text.Split(',');
        var worldBackupDir = txtWorldBackupDir.Text;

        if (worldFiles.Length <= 0)
        {
            WriteActionLog("ERROR: No World Files Selected");
            return;
        }

        if (string.IsNullOrWhiteSpace(worldBackupDir))
        {
            WriteActionLog("ERROR: No World Backup Directory Selected");
            return;
        }

        if (!Directory.Exists(worldBackupDir))
        {
            Directory.CreateDirectory(worldBackupDir);
            WriteActionLog("World Backup Directory Created");
        }

        foreach (var file in worldFiles)
        {
            if (File.Exists(file))
            {
                File.Copy(file, Path.Combine(worldBackupDir, Path.GetFileName(file)), true);
            }
            else
            {
                WriteActionLog("ERROR: World File Not Found");
            }
        }

        WriteActionLog("World Files Backed Up");
    }

    private void btnRestoreWorld_Click(object sender, EventArgs e)
    {
        var worldFiles = txtWorldFiles.Text.Split(',');
        var worldBackupDir = txtWorldBackupDir.Text;

        if (worldFiles.Length <= 0)
        {
            WriteActionLog("ERROR: No World Files Selected");
            return;
        }

        if (string.IsNullOrWhiteSpace(worldBackupDir))
        {
            WriteActionLog("ERROR: No World Backup Directory Selected");
            return;
        }

        foreach (var file in worldFiles)
        {
            if (File.Exists(file) && Directory.Exists(worldBackupDir))
            {
                File.Copy(Path.Combine(worldBackupDir, Path.GetFileName(file)), file, true);
            }
            else
            {
                WriteActionLog("ERROR: Enshrouded or Backup Directory Not Found");
                return;
            }
        }

        WriteActionLog("World Files Restored");
    }

    private void WriteActionLog(string action)
    {
        var actionLog = $"{DateTime.Now.ToString("HH:mm:ss")}: {action}";
        _actionLogs.Add(actionLog);

        // if more than 10 logs are stored in _actionLogs, remove the oldest one
        if (_actionLogs.Count() > 10)
        {
            _actionLogs = _actionLogs.Skip(1).ToList();
        }

        // copy the _actionLogs list to a new list so that it can be reversed
        var reversed_actionLogs = _actionLogs.ToList();
        reversed_actionLogs.Reverse();

        rtbActionLog.Text = string.Join(Environment.NewLine, reversed_actionLogs);
    }

    private void WritePathsToJson()
    {
        // create the Data directory if it doesn't exist
        if (!Directory.Exists("./Data"))
        {
            Directory.CreateDirectory("./Data");
            WriteActionLog("Data Directory Created");
        }

        var filePaths = new FilePaths
        {
            CharacterFilePath = txtCharFile.Text,
            CharacterBackupDirectory = txtCharBackupDir.Text,
            WorldFilePath = txtWorldFiles.Text,
            WorldBackupDirectory = txtWorldBackupDir.Text
        };

        var filePathsJson = JsonConvert.SerializeObject(filePaths, Formatting.Indented);
        File.WriteAllText(Path.Combine("Data", "filePaths.json"), filePathsJson);

        WriteActionLog("Paths written to filePaths.json");
    }

    private void txtCharFile_Leave(object sender, EventArgs e)
    {
        WritePathsToJson();
    }
}
