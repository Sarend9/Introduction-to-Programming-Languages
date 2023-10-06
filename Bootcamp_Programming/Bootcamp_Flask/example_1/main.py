from flask import Flask, render_template  # Объект


app = Flask(__name__)


@app.route('/')  # GET - по умолчнаию
def main():
    # list (список)
    names = ['Викула C.F.', 'Роман I.Y.', 'Анастасия O.G.',
             'Александр R.F.', 'Антон B.X.', 'Дмитрий R.T.',
             'Алексей Z.Y.', 'Алексей C.X.', 'Алексей U.D.',
             'Екатерина I.M.', 'Ирина J.W.', 'Наталья N.F.',
             'Максим A.I.', 'Ольга J.O.', 'Светлана A.U.',
             'Артем W.M.', 'Татьяна B.O.', 'Елена U.I.']


    return render_template('base.html',
                           title="bootcamp",
                           names=names, )


@app.route('/students')
def students():
    names = ['Викула C.F.', 'Роман I.Y.', 'Анастасия O.G.',
             'Александр R.F.', 'Антон B.X.', 'Дмитрий R.T.',
             'Алексей Z.Y.', 'Алексей C.X.', 'Алексей U.D.',
             'Екатерина I.M.', 'Ирина J.W.', 'Наталья N.F.',
             'Максим A.I.', 'Ольга J.O.', 'Светлана A.U.',
             'Артем W.M.', 'Татьяна B.O.', 'Елена U.I.']

    return render_template('students.html',
                           title="Список всех студентов",
                           names=names, )


@app.route('/summa/<x>/<y>')
def summa(x, y):
    return f'<h1>{x} + {y} = {int(x) + int(y)}</h1>'


if __name__ == '__main__':
    app.run()
