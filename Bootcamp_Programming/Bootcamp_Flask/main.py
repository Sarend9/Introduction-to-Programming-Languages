from flask import Flask  # Объект


app = Flask(__name__)


@app.route('/')  # GET - по умолчнаию
def main():
    return "<h1>HELLO, WORLD!</h1>"


@app.route('/info')
def info():
    return '<h1>Меня создала компания GeekBrains</h1>'


@app.route('/summa/<x>/<y>')
def summa(x, y):
    return f'<h1>{x} + {y} = {int(x) + int(y)}</h1>'


if __name__ == '__main__':
    app.run()
