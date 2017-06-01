#### On PC Host
   1. Set internet sharing from PC's WIFI to BBB (Linux USB Ethernet)
   2. Set IP of BBB (Linux USB Ethernet) network interface to obtain an IP address automatically

#### On BBB
```sh
route add default gw 192.168.7.1
```

#### add nemeserver (if never done)
add this line to /etc/resolv.conf 
```sh
nameserver 8.8.8.8 
```

#### restart network interface
use
```sh
/etc/init.d/networking restart
```
