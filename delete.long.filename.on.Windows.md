## Delete a long filename on Windows using robocopy

1. mkdir empty_dir
2. robocopy empty_dir the_dir_to_delete /s /mir
3. rmdir empty_dir
4. rmdir the_dir_to_delete
