### Python Create List with Condition

#### Read read text file then create a list of line, Also Remove '\n' from the end of each line.
```python
with open('testFile1.txt' , 'r') as f:
    CaniLogList = [line[0:len(line) - 1] for line in f]
```

#### Read read text file then create a list of line, Select only line that contain string 'Apple'. Also Remove '\n' from the end of each line.
```python
with open('testFile1.txt' , 'r') as f:
    CanoeLogList = [line[0:len(line) - 1] for line in f if 'Apple' in line]
```

### Decode UTF-16-LE + Split each line into list
```python
        with open(testFile , 'rb') as f:
            text = f.read().decode('utf-16-le')
        
        self.testFileList = [line for line in text.split('\r\n')]
```
