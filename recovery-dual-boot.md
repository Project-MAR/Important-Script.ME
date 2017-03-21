### Recovery Dual Boot between UBUNTU and Windows 7

```sh
sudo apt-get install grub grub2 grub-common grub2-common
```
grub will automatic detect Windows partition and add a dual boot option.   
   
If not,   
Find partition number

```sh
sdo fdisk -l
```
It will print something like this

```sh
Disk /dev/sda: 320.1 GB, 320072933376 bytes, 625142448 sectors
 Units = sectors of 1 * 512 = 512 bytes
 Sector size (logical/physical): 512 bytes / 512 bytes
 I/O size (minimum/optimal): 512 bytes / 512 bytes
 Disk label type: dos
 Disk identifier: 0xcd8b1219

    Device Boot      Start         End      Blocks   Id  System
 /dev/sda1   *        2048     4194303     2096128    7  HPFS/NTFS/exFAT
 /dev/sda2         4194304   360402758   178104227+   7  HPFS/NTFS/exFAT
 /dev/sda3       360402942   625141759   132369409    5  Extended
 /dev/sda5       612595712   625141759     6273024   82  Linux swap / Solaris
 /dev/sda6       360407040   361431039      512000   83  Linux
 /dev/sda7       361433088   612589567   125578240   8e  Linux LV
```
> In this example, /dev/sda1 is the recovery partition, and /dev/sda2 is the Windows OS partition. Since partition indexes start at zero, the Windows OS partition will be `hd0,1` (a = 0, 2 = 1; or first disk, second partition) when we edit the Grub file. Make note of this.

```sh
cd  /etc/grub.d/
sudo nano 40_custom
```

Add

```sh
menuentry "Windows 7" {
         set root=(hd0,1)
         chainloader +1
         }
```

Then run
```sh
grub-mkconfig
```

#### Original from
[dareneiri.github.io](http://dareneiri.github.io/Configuring-Grub-2-on-CentOS-7/)
