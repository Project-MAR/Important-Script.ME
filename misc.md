#### view port and process that use that port
```sh
sudo lsof -i
sudo netstat -lptu
sudo netstat -tulpn
```
---

#### Delete all files except folder
```sh
sudo find . -maxdepth 1 -type f -delete\
```
or
```sh
sudo find . -maxdepth 1 -type f -print0 | xargs -0 rm
```
---
