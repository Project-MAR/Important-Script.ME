## Beagle Bone Black with Buildroot

### SD-Card Prepare

#### Caution: Change sdb1, sdb2 to your SD-Card mount point !!!

- Umount all partition of your SD-Card
```sh
sudo umount /dev/sdb1
sudo umount /dev/sdb2
```

- Format SD-Card. (Use)
```sh
sudo dd if=/dev/zero of=/dev/mmcblk0 bs=1M count=16
```

- Create 2 Partitions
     - Partition 1 : 32 MB, primary, type e (S95 FAT16), SET BOOT FLAG
     - Partition 2 : The rest of avalable space, type 83 (linux)
```sh
sudo cfdisk /dev/sdb
```

- Format SD-Card
```sh
sudo mkfs.vfat -F 16 -n boot /dev/sdb1
sudo mkfs.ext4 -L rootfs -E nodiscard /dev/sdb2
```

-Remove SD-Card and insert again. Tow partition should be mounted automatically.

- Copy these files to boot
    - am335x-boneblack.dtb
    - MLO
    - uBoot.img
    - zImage
    - Add uEnv.txt
       ```sh
      bootdir=
      bootpart=0:1
      uenvcmd=run loadimage;run loadramdisk;run findfdt;run loadfdt;run mmcloados
      ```

- extract rootfs to rootfs
```sh
sudo tar -C /PATH/TO/rootfs.tar -xf /PATH/TO/rootfs
```
---

### TTT

