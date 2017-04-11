### VSFTP (Very Secure FTP Daemon)
   
Setup
```sh
sudo apt get install vsftpd
```

Check with netstat
```sh
sudo netstat -npl
```
Config /etc/vsftpd.conf
 - write_enable=YES

Restart service
```
systemctl restart vsftpd.service
````

---
original from [debian](https://wiki.debian.org/vsftpd)
