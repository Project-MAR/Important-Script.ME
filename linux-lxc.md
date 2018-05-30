## LXC

### Setup
```sh
sudo apt install lxc
sudo apt install lxctl lxc-templates
```
   
### Check lxc status
```sh
sudo lxc-checkconfig
```
   
### Template location
```sh
ls /usr/share/lxc/templates/
```
   
### Create container 
lxc-create -n <any user-defined container name> -t <template>
```sh
sudo lxc-create -n test-lxc-container -t /usr/share/lxc/templates/lxc-ubuntu
```
   
### Fix "Cannot set LC_ALL to default locale: No such file or directory"
```sh
export LC_ALL="en_US.UTF-8"
```
Or.
```sh
sudo locale-gen "en_US.UTF-8"
sudo dpkg-reconfigure locales

```
