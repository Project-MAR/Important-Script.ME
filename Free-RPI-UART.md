## Free RPi UART from Serial Console

Backup cmdline.txt
```sh
sudo cp /boot/cmdline.txt /boot/cmdline_bp.txt
```
Edit with nano, remove parameters containing 'ttyAMA0' and REBOOT RPi
