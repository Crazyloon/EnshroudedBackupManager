namespace EnshroudedBackupManager;
public static class Constants
{
    public static class Paths
    {
        public const string STEAM = "steam";
        public const string USERDATA = "userdata";
        public const string REMOTE = "remote";
        public const string SAVED_GAMES = "Saved Games";
        public const string ENSHROUDED = "Enshrouded";

        public const string DATA = "Data";
        public const string BACKUP_WORLD = "Backup_World";
        public const string BACKUP_CHARACTERS = "Backup_Chars";

    }

    public static class FileNames
    {
        public const string FILE_PATHS_JSON = "filePaths.json";
        public const string CHARACTERS = "characters";
        public const string NEXT_SLOT = "NEXT";
        public const string SLOT1 = "3ad85aea";
        public const string SLOT2 = "3bd85c7d";
        public const string SLOT3 = "38d857c4";
        public const string SLOT4 = "39d85957";
        public const string SLOT5 = "36d8549e";
        public const string SLOT6 = "37d85631";
        public const string SLOT7 = "34d85178";
        public const string SLOT8 = "35d8530b";
        public const string SLOT9 = "32d84e52";
        public const string SLOT10 = "33d84fe5";
    }

    public static readonly string[] AVAILABLE_SLOTS = new string[]
    {
        FileNames.SLOT1,
        FileNames.SLOT2,
        FileNames.SLOT3,
        FileNames.SLOT4,
        FileNames.SLOT5,
        FileNames.SLOT6,
        FileNames.SLOT7,
        FileNames.SLOT8,
        FileNames.SLOT9,
        FileNames.SLOT10
    };

    public const string ENSHROUDED_STEAM_ID = "1203620";
}