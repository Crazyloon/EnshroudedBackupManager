# Enshrouded Backup Manager
This is a simple utility that allows you to quickly back up and restore saved character and world files.

![image](https://github.com/Crazyloon/EnshroudedBackupManager/assets/8146917/36ce10a0-779a-42a6-8c65-2b45f193cc43)

![image](https://github.com/Crazyloon/EnshroudedBackupManager/assets/8146917/3850dcdb-f53f-451f-b13f-e1cb7daa3567)

![image](https://github.com/Crazyloon/EnshroudedBackupManager/assets/8146917/c5df21fa-c270-406c-a1f6-9b7928e2abe3)

## How it works

### Backup
When the app starts, the Backup Save Files tab will ask you where your saved files are located, so you can set default values for the backup/restore paths. By default the game saves files in the Steam folder, so select that if you haven't turned cloud saves off for Enshrouded.

### Import Save Files
You can import either characters or world files. The app will attempt to locate both your .../steam/../remote and your .../Saved Games/Enshrouded directories and fill out that info for you in their respective text boxes.

To import a `characters` file, select the file to import using the `Select Char File` button. Then, click Import Characters to either your Steam or Local Folder. If the folder you attempt to import the file into already contains a `characters` file. The application will automatically create a backup of that file and place it in the same directory in a folder called Backup_Chars, the zip file within will be dated with the current date and time.

To import world files, select the file or files to import using the `Select World Files` button. Next, select the slot you would like to import this file as. In most cases, the name of the file and the slot to import should match, but sometimes you need to change the name of the file you're importing. If you're importing locally, you can select `Next Available Slot` and let the app choose the file name for you, this does not work in the remote directory, due to the way it detects save files. Once you're satisifed with the files to import and the slot name you will give them, click Import World to either your Steam or Local Folder. As with the `characters` files, a backup will be made of any file that already exists. You can only import a world file with a slot name that matches slots 1-10 or a world's `_info` file, all other files will be ignored/skipped during the import.

## Dangers
**You must be absolutely sure you are pressing the correct button when backing up and restoring files. If you back up a file 10 hours ago, and reload it, any progress since then will be overwritten. Be careful! It's very easy to click the wrong button at the wrong time.**

**I take no responsibility for your actions when using this tool.**

## Where are my saved Files?
If you have Steam cloud saves ON (This is the default), your files will be in: `C:\Program Files (x86)\Steam\userdata\YOUR_USER_ID\1203620\remote`

If you want to manage your files locally (recommended).
Go to Steam > Library > Enshrouded > Properties > General > Then toggle Steam Cloud off

If you have turned Steam Cloud OFF
Your files will be in: `C:/Users/YOUR_USERNAME/Saved Games/Enshrouded`
