from random import randint

from flask import Flask, render_template  # Объект

app = Flask(__name__)


@app.route('/')  # GET - по умолчнаию
def say_hello():
    context = {
        "title": "Главная страница",
        "name": "Боб",
        "number": randint(1, 6),
        "temp_list": ['Викула Y.P.', 'Роман V.W.', 'Анастасия X.A.', 'Александр U.J.', 'Антон F.P.', 'Дмитрий Y.J.', 'Алексей M.H.', 'Алексей T.Y.', 'Алексей R.T.', 'Екатерина K.T.', 'Ирина F.J.', 'Наталья I.S.', 'Максим Z.M.', 'Ольга L.U.', 'Светлана G.V.', 'Артем V.S.', 'Татьяна J.A.', 'Елена I.R.'],
    }

    return render_template('index.html', **context)


@app.route('/test/')
def say_start():
    return render_template('name.html')


if __name__ == '__main__':
    app.run()
