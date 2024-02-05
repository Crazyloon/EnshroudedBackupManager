namespace EnshroudedBackupManager.Models;
internal class FilePaths
{
    public bool IsAskForDefaultDisabled { get; set; }

    // Backup Tab Info
    public string CharacterFilePath { get; set; }
    public string CharacterBackupDirectory { get; set; }
    public string WorldFilePath { get; set; }
    public string WorldBackupDirectory { get; set; }

}
