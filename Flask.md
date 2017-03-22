## Flask
Flask is a microframework for Python based

## Example
```python
from flask import Flask
app = Flask(__name__)

@app.route("/")
def hello():
    return "Hello World!"

if __name__ == "__main__":
    app.run()
```

> Run this script and see a result in Web browsers
> http://localhost:5000/

### Original
[Flask](http://flask.pocoo.org/)
