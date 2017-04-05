### CAN-Bus Controller on Beagle Bone Black
   
> The BeagleBoneBlack has two internal CAN-Bus controller which are called DCAN0 and DCAN1. DCAN0 shared with I2C-Bus and DCAN1 is multiplexed to pin 24 (CAN_RX) & 26 (CAN_TX)
   
```sh
 sudo modprobe can
 sudo modprobe can-dev
 sudo modprobe can-raw
```

```sh
sudo ip link set can1 up type can bitrate 500000
sudo ifconfig can1 up
```

```sh
debian@beaglebone:~# ifconfig
can1 Link encap:UNSPEC HWaddr 00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00
      UP RUNNING NOARP MTU:16 Metric:1
      RX packets:0 errors:0 dropped:0 overruns:0 frame:0
      TX packets:0 errors:0 dropped:0 overruns:0 carrier:0
      RX bytes:0 (0.0 B) TX bytes:0 (0.0 B)
      Interrupt:211
```
### Virtual CAN Devices

```sh
sudo modprobe vcan
sudo ip link add name vcan0 type vcan
sudo ifconfig vcan0 up
```
```sh
cansend vcan0 123#1122334455667788
candump vcan0
```
