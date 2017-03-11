### picocom
```sh
sudo adduser $USER dialout
picocom -b 115200 /dev/ttyUSB0
```

---

### dd
```sh
sudo dd if=/dev/zero of=/dev/mmcblk0 bs=1M count=16
```
