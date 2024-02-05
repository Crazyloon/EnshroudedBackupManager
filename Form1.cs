using EnshroudedBackupManager.Models;
using EnshroudedBackupManager.Utils;
using Newtonsoft.Json;
using System.IO.Compression;

namespace EnshroudedBackupManager;

public partial class frmEnshroudedBackupManager : Form
{
    private List<string> _backupActionLogs = new List<string>(10);
    private List<string> _importActionLogs = new List<string>(10);

    public frmEnshroudedBackupManager()
    {
        InitializeComponent();
        InitializeSaveSlots();
        InitializeSaveLocationsDialog();
    }

    private void frmEnshroudedBackupManager_Load(object sender, EventArgs e)
    {
        ofdImportCharacterFilePicker.InitialDirectory = SpecialFolder.Downloads;
        ofdImportCharacterFilePicker.InitialDirectory = SpecialFolder.Downloads;
    }

    private void btnCharFile_Click(object sender, EventArgs e)
    {
        var result = ofdSelectCharFileDialog.ShowDialog();
        if (result == DialogResult.OK)
        {
            var file = ofdSelectCharFileDialog.FileName;
            txtCharFile.Text = file;

            WriteActionLog($"Character File Selected", rtbBackupActionLog);
        }
    }

    private void btnCharDir_Click(object sender, EventArgs e)
    {
        var result = fbdCharacterBackupDir.ShowDialog();
        if (result == DialogResult.OK)
        {
            var dir = fbdCharacterBackupDir.SelectedPath;
            txtCharBackupDir.Text = dir;

            WriteActionLog("Character Backup Directory Selected", rtbBackupActionLog);
        }
    }

    private void btnWorldFiles_Click(object sender, EventArgs e)
    {
        var result = ofdSelectWorldFiles.ShowDialog();
        if (result == DialogResult.OK)
        {
            var files = ofdSelectWorldFiles.FileNames;
            txtWorldFiles.Text = string.Join(",", files);

            WriteActionLog("World Files Selected", rtbBackupActionLog);
        }
    }

    private void btnWorldBackupDir_Click(object sender, EventArgs e)
    {
        var result = fbdWorldBackupDir.ShowDialog();
        if (result == DialogResult.OK)
        {
            var dir = fbdWorldBackupDir.SelectedPath;
            txtWorldBackupDir.Text = dir;

            WriteActionLog("World Backup Directory Selected", rtbBackupActionLog);
        }
    }

    private void btnBackupCharacter_Click(object sender, EventArgs e)
    {
        var charFile = txtCharFile.Text;
        var charBackupDir = txtCharBackupDir.Text;

        if (string.IsNullOrWhiteSpace(charFile))
        {
            WriteActionLog("ERROR: No Character File Selected", rtbBackupActionLog);
            return;
        }

        if (string.IsNullOrWhiteSpace(charBackupDir))
        {
            WriteActionLog("ERROR: No Character Backup Directory Selected", rtbBackupActionLog);
            return;
        }

        if (!Directory.Exists(charBackupDir))
        {
            Directory.CreateDirectory(charBackupDir);
            WriteActionLog("Character Backup Directory Created", rtbBackupActionLog);
        }

        try
        {
            File.Copy(charFile, Path.Combine(charBackupDir, Path.GetFileName(charFile)), true);
        }
        catch (Exception err)
        {
            WriteActionLog("ERROR: " + err.Message, rtbBackupActionLog);
            return;
        }

        WriteActionLog("Character File Backed Up", rtbBackupActionLog);
    }

    private void btnRestoreCharacter_Click(object sender, EventArgs e)
    {
        var charFile = txtCharFile.Text;
        var charBackupDir = txtCharBackupDir.Text;

        if (string.IsNullOrWhiteSpace(charFile))
        {
            WriteActionLog("ERROR: No Character File Selected", rtbBackupActionLog);
            return;
        }

        if (string.IsNullOrWhiteSpace(charBackupDir))
        {
            WriteActionLog("ERROR: No Character Backup Directory Selected", rtbBackupActionLog);
            return;
        }

        charBackupDir = Path.Combine(charBackupDir, Constants.FileNames.CHARACTERS);

        try
        {
            File.Copy(charBackupDir, charFile, true);
        }
        catch (Exception err)
        {
            WriteActionLog("ERROR: " + err.Message, rtbBackupActionLog);
            return;
        }

        WriteActionLog("Character File Restored", rtbBackupActionLog);
    }

    private void btnBackupWorld_Click(object sender, EventArgs e)
    {
        var worldFiles = txtWorldFiles.Text.Split(',');
        var worldBackupDir = txtWorldBackupDir.Text;

        if (worldFiles.Length <= 0)
        {
            WriteActionLog("ERROR: No World Files Selected", rtbBackupActionLog);
            return;
        }

        if (string.IsNullOrWhiteSpace(worldBackupDir))
        {
            WriteActionLog("ERROR: No World Backup Directory Selected", rtbBackupActionLog);
            return;
        }

        if (!Directory.Exists(worldBackupDir))
        {
            Directory.CreateDirectory(worldBackupDir);
            WriteActionLog("World Backup Directory Created", rtbBackupActionLog);
        }

        foreach (var file in worldFiles)
        {
            if (File.Exists(file))
            {
                File.Copy(file, Path.Combine(worldBackupDir, Path.GetFileName(file)), true);
            }
            else
            {
                WriteActionLog("ERROR: World File Not Found", rtbBackupActionLog);
                return;
            }
        }

        WriteActionLog("World Files Backed Up", rtbBackupActionLog);
    }

    private void btnRestoreWorld_Click(object sender, EventArgs e)
    {
        var worldFiles = txtWorldFiles.Text.Split(',');
        var worldBackupDir = txtWorldBackupDir.Text;

        if (worldFiles.Length <= 0)
        {
            WriteActionLog("ERROR: No World Files Selected", rtbBackupActionLog);
            return;
        }

        if (string.IsNullOrWhiteSpace(worldBackupDir))
        {
            WriteActionLog("ERROR: No World Backup Directory Selected", rtbBackupActionLog);
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
                WriteActionLog("ERROR: Enshrouded or Backup Directory Not Found", rtbBackupActionLog);
                return;
            }
        }

        WriteActionLog("World Files Restored", rtbBackupActionLog);
    }

    private void WriteActionLog(string action, RichTextBox rtbActionLog)
    {
        var log = rtbActionLog.Name == rtbBackupActionLog.Name ? _backupActionLogs : _importActionLogs;
        var actionLog = $"{DateTime.Now.ToString("HH:mm:ss")}: {action}";
        log.Add(actionLog);

        // if more than 10 logs are stored in _actionLogs, remove the oldest one
        if (log.Count() > 10)
        {
            log = log.Skip(1).ToList();
        }

        // copy the _actionLogs list to a new list so that it can be reversed
        var reversed_actionLogs = log.ToList();
        reversed_actionLogs.Reverse();

        rtbActionLog.Text = string.Join(Environment.NewLine, reversed_actionLogs);
    }

    private void WritePathsToJson()
    {
        // create the Data directory if it doesn't exist
        if (!Directory.Exists(Constants.Paths.DATA))
        {
            Directory.CreateDirectory(Constants.Paths.DATA);
            WriteActionLog("Data Directory Created", rtbBackupActionLog);
        }

        var filePaths = LoadSavedPaths();
        if (filePaths is null)
        {
            filePaths = new FilePaths
            {
                CharacterFilePath = txtCharFile.Text,
                CharacterBackupDirectory = txtCharBackupDir.Text,
                WorldFilePath = txtWorldFiles.Text,
                WorldBackupDirectory = txtWorldBackupDir.Text
            };
        }
        else
        {
            filePaths.CharacterFilePath = txtCharFile.Text;
            filePaths.CharacterBackupDirectory = txtCharBackupDir.Text;
            filePaths.WorldFilePath = txtWorldFiles.Text;
            filePaths.WorldBackupDirectory = txtWorldBackupDir.Text;
            filePaths.IsAskForDefaultDisabled = filePaths.IsAskForDefaultDisabled;
        }


        var filePathsJson = JsonConvert.SerializeObject(filePaths, Formatting.Indented);
        File.WriteAllText(Path.Combine(Constants.Paths.DATA, Constants.FileNames.FILE_PATHS_JSON), filePathsJson);

        WriteActionLog($"Paths written to {Constants.FileNames.FILE_PATHS_JSON}", rtbBackupActionLog);
    }

    private void OnBackupInputBlur_Leave(object sender, EventArgs e)
    {
        WritePathsToJson();
    }

    private void btnImportCharSelect_Click(object sender, EventArgs e)
    {
        var result = ofdImportCharacterFilePicker.ShowDialog();
        ofdImportCharacterFilePicker.InitialDirectory = SpecialFolder.Downloads;
        if (result == DialogResult.OK)
        {
            var file = ofdImportCharacterFilePicker.FileName;
            txtImportCharacterFile.Text = file;

            WriteActionLog($"Character File to Import Selected", rtbImportActionLog);
        }
    }

    private void btnImportWorldsSelect_Click(object sender, EventArgs e)
    {
        var result = ofdImportWorldFilePicker.ShowDialog();
        ofdImportWorldFilePicker.InitialDirectory = SpecialFolder.Downloads;
        if (result == DialogResult.OK)
        {
            var files = ofdImportWorldFilePicker.FileNames;
            txtImportWorldFiles.Text = string.Join(",", files);

            WriteActionLog("World Files to Import Selected", rtbImportActionLog);
        }
    }

    private void btnImportCharToSteam_Click(object sender, EventArgs e)
    {
        var importFile = txtImportCharacterFile.Text;
        var steamCloudPath = GetSteamCloudPath();

        if (string.IsNullOrEmpty(steamCloudPath))
        {
            WriteActionLog("ERROR: Failed to Import; Directory Not Found", rtbImportActionLog);
            return;
        }

        // Check the file name of the file being imported
        if (!string.IsNullOrEmpty(importFile))
        {
            ImportCharacterFile(importFile, steamCloudPath);
        }
    }

    private void btnImportCharToLocal_Click(object sender, EventArgs e)
    {
        var importFile = txtImportCharacterFile.Text;
        var localSaveGamePath = GetLocalSavePath();

        if (string.IsNullOrEmpty(localSaveGamePath))
        {
            WriteActionLog("ERROR: Failed to Import; Directory Not Found", rtbImportActionLog);
            return;
        }

        // Check the file name of the file being imported
        if (!string.IsNullOrEmpty(importFile))
        {
            ImportCharacterFile(importFile, localSaveGamePath);
        }
    }

    private void btnImportWorldToLocal_Click(object sender, EventArgs e)
    {
        if (cbxSlotOverwrite.SelectedValue is null || string.IsNullOrEmpty(cbxSlotOverwrite.SelectedValue.ToString()))
        {
            MessageBox.Show("Select a Slot to Overwrite", "Slot Selction Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            return;
        }

        var importWorldFiles = txtImportWorldFiles.Text;
        var localSaveGamePath = GetLocalSavePath();

        if (string.IsNullOrEmpty(localSaveGamePath))
        {
            WriteActionLog("ERROR: Failed to Import; Directory Not Found", rtbImportActionLog);
            return;
        }

        if (!string.IsNullOrEmpty(importWorldFiles) && cbxSlotOverwrite.SelectedValue is not null)
        {
            ImportWorldFiles(importWorldFiles.Split(','), localSaveGamePath, cbxSlotOverwrite.SelectedValue.ToString());
        }
    }

    private void btnImportWorldToSteam_Click(object sender, EventArgs e)
    {
        if (cbxSlotOverwrite.SelectedValue is null || string.IsNullOrEmpty(cbxSlotOverwrite.SelectedValue.ToString()))
        {
            MessageBox.Show("Select a Slot to Overwrite", "Slot Selction Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            return;
        }

        var importWorldFiles = txtImportWorldFiles.Text;
        var steamCloudPath = GetSteamCloudPath();

        if (string.IsNullOrEmpty(steamCloudPath))
        {
            WriteActionLog("ERROR: Failed to Import; Steam Cloud Directory Not Found", rtbImportActionLog);
            return;
        }

        if (!string.IsNullOrEmpty(importWorldFiles))
        {
            if (cbxSlotOverwrite.SelectedValue.ToString() == Constants.FileNames.NEXT_SLOT)
            {
                MessageBox.Show("ERROR: Steam requires overriding an existing world slot to import correctly", "Slot Selction Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ImportWorldFiles(importWorldFiles.Split(','), steamCloudPath, cbxSlotOverwrite.SelectedValue.ToString());
        }

    }

    private void ImportWorldFiles(string[] importWorldFiles, string importDestination, string slot)
    {
        if (!IsAllFilesSameWorldFile(importWorldFiles))
        {
            WriteActionLog("ERROR: All World Files Must Be the Same Slot", rtbImportActionLog);
            return;
        }

        if (slot == Constants.FileNames.NEXT_SLOT)
        {
            slot = GetNextAvailableSlotForOverwrite(importDestination);
        }

        // if world file exists in the destination, backup the existing files
        if (File.Exists(Path.Combine(importDestination, slot)) || File.Exists(Path.Combine(importDestination, $"{slot}_info")))
        {
            BackupExistingWorldFiles(importDestination, slot);
        }

        foreach (var sourceFile in importWorldFiles)
        {
            if (sourceFile.Contains(".backup"))
            {
                WriteActionLog($"File Skipped: {sourceFile}", rtbImportActionLog);
                continue;
            }

            try
            {
                var postfix = sourceFile.Contains("_info") ? "_info" : "";
                var destination = Path.Combine(importDestination, $"{slot}{postfix}");
                File.Copy(sourceFile, destination, true);
                WriteActionLog($"File Imported: {destination}", rtbImportActionLog);
            }
            catch (Exception err)
            {
                WriteActionLog("ERROR: " + err.Message, rtbImportActionLog);
                return;
            }

        }
    }

    private string GetNextAvailableSlotForOverwrite(string importDestination)
    {
        string slot;
        WriteActionLog("Searching for Next Available Slot", rtbImportActionLog);
        // find next available slot in the directory
        DirectoryInfo di = new DirectoryInfo(importDestination);
        var files = di.GetFiles();
        var availableSlots = Constants.AVAILABLE_SLOTS.Except(files.Select(f => f.Name)).ToList();

        if (availableSlots.Count > 0)
        {
            slot = availableSlots[0];
        }
        else
        {
            slot = Constants.FileNames.SLOT1;
            WriteActionLog($"No Available Slots Found Overwriting Slot 1 {Constants.FileNames.SLOT1}", rtbImportActionLog);
        }

        return slot;
    }

    private void BackupExistingWorldFiles(string baseWorldPath, string slot)
    {
        var backupDir = Path.Combine(baseWorldPath, Constants.Paths.BACKUP_WORLD);
        if (!Directory.Exists(backupDir))
        {
            Directory.CreateDirectory(backupDir);
            WriteActionLog($"Backup Directory Created for World Files at:\n\t{backupDir}", rtbImportActionLog);
        }

        var tempDir = Path.Combine(baseWorldPath, $"world_{DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")}");
        Directory.CreateDirectory(tempDir);

        // move the existing world files to the temp dir
        foreach (var file in Directory.GetFiles(baseWorldPath))
        {
            if (file.Contains(slot))
            {
                File.Move(file, Path.Combine(tempDir, Path.GetFileName(file)));
            }
        }

        ZipFile.CreateFromDirectory(tempDir, Path.Combine(backupDir, $"world_{DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")}.zip"));
        Directory.Delete(tempDir, true);
    }

    private void ImportCharacterFile(string importFile, string importDestination)
    {
        var fileName = Path.GetFileName(importFile);
        if (fileName == Constants.FileNames.CHARACTERS)
        {
            if (string.IsNullOrWhiteSpace(importDestination))
            {
                WriteActionLog("ERROR: Directory Not Found", rtbImportActionLog);
                return;
            }

            if (File.Exists(Path.Combine(importDestination, Constants.FileNames.CHARACTERS)))
            {
                BackupExistingCharacterFile(importDestination);
            }

            File.Copy(importFile, Path.Combine(importDestination, Constants.FileNames.CHARACTERS), true);
            WriteActionLog("Character File Imported", rtbImportActionLog);
        }
        else
        {
            WriteActionLog("ERROR: Invalid Character File Selected", rtbImportActionLog);
        }
    }

    private void BackupExistingCharacterFile(string baseCharPath)
    {
        // backup the existing characters file
        var backupDir = Path.Combine(baseCharPath, Constants.Paths.BACKUP_CHARACTERS);
        if (!Directory.Exists(backupDir))
        {
            Directory.CreateDirectory(backupDir);
            WriteActionLog($"Backup Directory Created for Characters at:\n\t{backupDir}", rtbImportActionLog);
        }

        // Create a temporaray directory for the chars file to be zipped
        var tempDir = Path.Combine(baseCharPath, $"{Constants.FileNames.CHARACTERS}_{DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")}");
        Directory.CreateDirectory(tempDir);

        // move the existing characters file to the backupDir
        File.Move(Path.Combine(baseCharPath, Constants.FileNames.CHARACTERS), Path.Combine(tempDir, Constants.FileNames.CHARACTERS));

        // zip the existing characters file and place it in the backupDir
        ZipFile.CreateFromDirectory(tempDir, Path.Combine(backupDir, $"{Constants.FileNames.CHARACTERS}_{DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")}.zip"));

        // Delete the tempdir
        Directory.Delete(tempDir, true);
    }



    private void InitializeSaveSlots()
    {
        var saveSlots = GetSelectableSaveSlots();
        cbxSlotOverwrite.DataSource = new BindingSource(saveSlots, null);
        cbxSlotOverwrite.DisplayMember = "Key";
        cbxSlotOverwrite.ValueMember = "Value";
    }

    private void InitializeSaveLocationsDialog()
    {
        var filePaths = LoadSavedPaths();
        if (filePaths is not null && filePaths.IsAskForDefaultDisabled)
        {
            UseSavedPaths(filePaths);
            chkDoNotAsk.Checked = filePaths.IsAskForDefaultDisabled;
            pnlDefaultPathsDialog.Visible = false;
        }

        pnlDefaultPathsDialog.Location = new Point(0, 0);
        pnlDefaultPathsDialog.Dock = DockStyle.Fill;


        var foundPaths = lblDefaultPathsLocatedInfo.Text;
        // Get the default paths for the Steam Cloud and Local Save Directories
        var steamCloudPath = GetSteamCloudPath();
        var localSavePath = GetLocalSavePath();

        if (!string.IsNullOrEmpty(steamCloudPath))
        {
            foundPaths = foundPaths + $"\n\nSteam Cloud Directory:\n{steamCloudPath}";
        }

        if (!string.IsNullOrEmpty(localSavePath))
        {
            foundPaths = foundPaths + $"\n\nLocal Save Directory:\n{localSavePath}";
        }

        lblDefaultPathsLocatedInfo.Text = foundPaths;

        txtSteamRemoteDirectory.Text = steamCloudPath;
        txtLocalDirectory.Text = localSavePath;
    }

    private Dictionary<string, string> GetSelectableSaveSlots()
    {
        return new Dictionary<string, string>()
        {
            { "Select a Slot", ""},
            { "Use Next Available Slot", Constants.FileNames.NEXT_SLOT},
            { $"Slot 1: {Constants.FileNames.SLOT1}", Constants.FileNames.SLOT1 },
            { $"Slot 2: {Constants.FileNames.SLOT2}", Constants.FileNames.SLOT2 },
            { $"Slot 3: {Constants.FileNames.SLOT3}", Constants.FileNames.SLOT3 },
            { $"Slot 4: {Constants.FileNames.SLOT4}", Constants.FileNames.SLOT4 },
            { $"Slot 5: {Constants.FileNames.SLOT5}", Constants.FileNames.SLOT5 },
            { $"Slot 6: {Constants.FileNames.SLOT6}", Constants.FileNames.SLOT6 },
            { $"Slot 7: {Constants.FileNames.SLOT7}", Constants.FileNames.SLOT7 },
            { $"Slot 8: {Constants.FileNames.SLOT8}", Constants.FileNames.SLOT8 },
            { $"Slot 9: {Constants.FileNames.SLOT9}", Constants.FileNames.SLOT9 },
            { $"Slot 10: {Constants.FileNames.SLOT10}", Constants.FileNames.SLOT10 }
        };
    }

    private string GetSteamCloudPath()
    {
        WriteActionLog("Searching for Saves in Steam Cloud Directory...", rtbImportActionLog);

        var remoteDir = "";
        try
        {
            var programFilesX86 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            var userData = Path.Combine(programFilesX86, Constants.Paths.STEAM, Constants.Paths.USERDATA);
            var userDirectories = Directory.GetDirectories(userData);
            var userDirectory = userDirectories[0];
            remoteDir = Path.Combine(userDirectory, Constants.ENSHROUDED_STEAM_ID, Constants.Paths.REMOTE);

            DirectoryInfo di = new DirectoryInfo(remoteDir);
            if (di.Exists && di.GetFiles().Length > 0)
            {
                var remoteDirFileInfo = di.GetFiles();
                // Create a string with all of the files names in the remoteDir
                var remoteDirFiles = "";
                foreach (var file in remoteDirFileInfo)
                {
                    remoteDirFiles += $"\n\t{file.Name}";
                }

                WriteActionLog($"Steam Cloud Directory Found With Saved Files:{remoteDirFiles}", rtbImportActionLog);
            }
            else if (di.Exists && di.GetFiles().Length == 0)
            {
                WriteActionLog("Steam Cloud Directory Found, but Contained No Save Files", rtbImportActionLog);
            }
            else
            {
                WriteActionLog("Steam Cloud Directory Not Found", rtbImportActionLog);
            }
        }
        catch (Exception)
        {
            WriteActionLog("Error: Steam Cloud Directory Not Found", rtbImportActionLog);
        }

        return remoteDir;
    }

    private string GetLocalSavePath()
    {
        WriteActionLog("Searching for Saves in Local Directory...", rtbImportActionLog);

        var saveSlotPath = "";
        try
        {
            var usersPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            saveSlotPath = Path.Combine(usersPath, Constants.Paths.SAVED_GAMES, Constants.Paths.ENSHROUDED);

            DirectoryInfo di = new DirectoryInfo(saveSlotPath);
            if (di.Exists && di.GetFiles().Length > 0)
            {
                var saveSlotPathFileInfo = di.GetFiles();
                // Create a string with all of the files names in the remoteDir
                var saveSlotPathFiles = "";
                foreach (var file in saveSlotPathFileInfo)
                {
                    saveSlotPathFiles += $"\n\t{file.Name}";
                }

                WriteActionLog($"Local Directory Found with Save Files:{saveSlotPathFiles}", rtbImportActionLog);
            }
            else if (di.Exists && di.GetFiles().Length == 0)
            {
                WriteActionLog("Local Directory Found, but Contained No Save Files", rtbImportActionLog);
            }
            else
            {
                WriteActionLog("Local Directory Not Found or Contained No Save Files", rtbImportActionLog);
            }
        }
        catch (Exception)
        {
            WriteActionLog("Error: Local Directory Not Found", rtbImportActionLog);
        }

        return saveSlotPath;
    }

    private void btnDefaultPathsUseSteamCloud_Click(object sender, EventArgs e)
    {
        pnlDefaultPathsDialog.Visible = false;

        var isSteamDirFound = false;

        WriteActionLog("Searching for Saves in Steam Cloud Directory", rtbBackupActionLog);

        // get the path to Program Files (x86)
        var programFilesX86 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);

        // check the remote directory for steam cloud saves
        var userData = Path.Combine(programFilesX86, Constants.Paths.STEAM, Constants.Paths.USERDATA);
        var remoteDir = "";
        if (Directory.Exists(userData))
        {
            var userDirectories = Directory.GetDirectories(userData);
            if (userDirectories.Length > 0)
            {
                var userDirectory = userDirectories[0];
                remoteDir = Path.Combine(userDirectory, Constants.ENSHROUDED_STEAM_ID, Constants.Paths.REMOTE);

                if (Directory.Exists(remoteDir))
                {

                    var worldFilePaths = new List<string>
                    {
                        Path.Combine(remoteDir, Constants.FileNames.SLOT1),
                        Path.Combine(remoteDir, $"{Constants.FileNames.SLOT1}_info")
                    };

                    txtCharFile.Text = Path.Combine(remoteDir, Constants.FileNames.CHARACTERS);
                    txtCharBackupDir.Text = Path.Combine(remoteDir, Constants.Paths.BACKUP_CHARACTERS);
                    txtWorldFiles.Text = string.Join(",", worldFilePaths);
                    txtWorldBackupDir.Text = Path.Combine(remoteDir, Constants.Paths.BACKUP_WORLD);

                    WriteActionLog("Steam Cloud Paths Loaded", rtbBackupActionLog);
                    isSteamDirFound = true;
                }
                else
                {
                    WriteActionLog("Steam Cloud: Remote Directory Not Found", rtbBackupActionLog);
                }
            }
            else
            {
                WriteActionLog("ERROR: User Directory Not Found", rtbBackupActionLog);
            }
        }
        else
        {
            WriteActionLog("ERROR: User Data Directory Not Found", rtbBackupActionLog);
        }

        if (!isSteamDirFound)
        {
            MessageBox.Show("Steam Cloud save directory not found. Please search manually.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private FilePaths LoadSavedPaths()
    {
        if (!File.Exists(Path.Combine(Constants.Paths.DATA, Constants.FileNames.FILE_PATHS_JSON)))
        {
            return null;
        }

        var filePathsJson = File.ReadAllText(Path.Combine(Constants.Paths.DATA, Constants.FileNames.FILE_PATHS_JSON));
        return JsonConvert.DeserializeObject<FilePaths>(filePathsJson);
    }

    private void btnDefaultPathsUseLocalSavedGames_Click(object sender, EventArgs e)
    {
        pnlDefaultPathsDialog.Visible = false;

        string charFile, charBackupDir, worldFiles, worldBackupDir;

        var usersPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        var enshroudedDir = Path.Combine(usersPath, Constants.Paths.SAVED_GAMES, Constants.Paths.ENSHROUDED);
        var fileCount = Directory.GetFiles(enshroudedDir).Length;

        charFile = Path.Combine(usersPath, Constants.Paths.SAVED_GAMES, Constants.Paths.ENSHROUDED, Constants.FileNames.CHARACTERS);
        charBackupDir = Path.Combine(usersPath, Constants.Paths.SAVED_GAMES, Constants.Paths.ENSHROUDED, Constants.Paths.BACKUP_CHARACTERS);

        var worldFilePaths = new List<string>
        {
            Path.Combine(usersPath, Constants.Paths.SAVED_GAMES, Constants.Paths.ENSHROUDED, Constants.FileNames.SLOT1),
            Path.Combine(usersPath, Constants.Paths.SAVED_GAMES, Constants.Paths.ENSHROUDED, $"{Constants.FileNames.SLOT1}_info")
        };

        worldFiles = string.Join(",", worldFilePaths);
        worldBackupDir = Path.Combine(usersPath, Constants.Paths.SAVED_GAMES, Constants.Paths.ENSHROUDED, Constants.Paths.BACKUP_WORLD);

        txtCharFile.Text = charFile;
        txtCharBackupDir.Text = charBackupDir;
        txtWorldFiles.Text = worldFiles;
        txtWorldBackupDir.Text = worldBackupDir;

        if (!Directory.Exists(enshroudedDir) || fileCount <= 0)
        {
            MessageBox.Show("Enshrouded save directory not found, or has no save files. Ensure you have a character or world file, saved, or find them manually.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            WriteActionLog("Default paths Loaded, but no files found", rtbBackupActionLog);
        }
        else
        {
            WriteActionLog("Default paths Loaded", rtbBackupActionLog);
        }

    }

    private void chkDoNotAsk_CheckedChanged(object sender, EventArgs e)
    {
        var enabled = chkDoNotAsk.Checked;

        var filePathsJson = Path.Combine(Constants.Paths.DATA, Constants.FileNames.FILE_PATHS_JSON);

        var filePaths = LoadSavedPaths();
        if (filePaths is not null)
        {
            filePaths.IsAskForDefaultDisabled = enabled;
            var filePathsText = JsonConvert.SerializeObject(filePaths, Formatting.Indented);
            File.WriteAllText(Path.Combine(Constants.Paths.DATA, Constants.FileNames.FILE_PATHS_JSON), filePathsText);
        }
        else
        {
            Directory.CreateDirectory(Constants.Paths.DATA);

            // Create default paths file
            var defaultPaths = new FilePaths
            {
                IsAskForDefaultDisabled = enabled
            };
            var defaultPathsText = JsonConvert.SerializeObject(defaultPaths, Formatting.Indented);
            File.WriteAllText(Path.Combine(Constants.Paths.DATA, Constants.FileNames.FILE_PATHS_JSON), defaultPathsText);
        }
    }

    private void btnUseSavedPaths_Click(object sender, EventArgs e)
    {
        pnlDefaultPathsDialog.Visible = false;

        var filePaths = LoadSavedPaths();
        UseSavedPaths(filePaths);
    }

    private void UseSavedPaths(FilePaths filePaths)
    {
        if (filePaths is not null)
        {
            txtCharFile.Text = filePaths.CharacterFilePath;
            txtCharBackupDir.Text = filePaths.CharacterBackupDirectory;
            txtWorldFiles.Text = filePaths.WorldFilePath;
            txtWorldBackupDir.Text = filePaths.WorldBackupDirectory;

            WriteActionLog($"Paths Loaded from {Constants.FileNames.FILE_PATHS_JSON}", rtbBackupActionLog);
        }
        else
        {
            WriteActionLog("No Saved Paths Found", rtbBackupActionLog);
        }
    }

    private bool IsAllFilesSameWorldFile(string[] worldFiles)
    {
        var fileNames = worldFiles.Select(f => Path.GetFileName(f)).ToList();

        // check if each file name matches the same slot
        var slot = fileNames[0].Substring(0, 8);

        foreach (var file in fileNames)
        {
            if (!file.Contains(slot))
            {
                return false;
            }
        }

        return true;
    }
}
