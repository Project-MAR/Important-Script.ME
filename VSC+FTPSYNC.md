### Visual Studio Code with ftp-sync

#### Setup FTP Server (Beagle Bone Black)
Original source from [htpcguides.com](https://www.htpcguides.com/install-configure-ftp-server-debian-linux-raspberry-pi/)

- Install FTP Server (vsftpd)
```sh
sudo apt-get install vsftpd -y
```
   
- Configure FTP Server
edit /etc/vsftpd.conf
 ```sh
 anonymous_enable=NO
 local_enable=YES
 write_enable=YES
 ```
- Enable FTP Root User
    - edit /etc/ftpusers
    - comment root user(uncomment == disable)
 
- restart FTP Server
```sh
sudo systemctl restart vsftpd.service
```

- test with browser
```sh
ftp://192.168.137.186/
```
   
If FTP Server run correctly, we can proceed next step.
   
---

#### Setup ftp-sync in Visual Studio Code
 - Install plunig
 - open cmd line (F1) then type "ftp-sync init:"
 - ftp-sync.json should be open
 - edit that file
 
 ```json
 {
    "remotePath": "/home/path/to/your/directory",
    "host": "FTP Server IP Address",
    "username": "user",
    "password": "pass",
    "port": 21,
    "secure": false,
    "protocol": "ftp",
    "uploadOnSave": true,
    "passive": false,
    "debug": false,
    "privateKeyPath": null,
    "passphrase": null,
    "ignore": [
        "\\.vscode",
        "\\.git",
        "\\.DS_Store"
    ]
}
 ```
 ---
   
#### It will be sync automatically every times after you save files.
### Enjoy :)
 
