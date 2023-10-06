import cv2

# =================================================================
# img = cv2.imread("image.jpg")
# print(img.shape)
#
# img = cv2.resize(img, (500, 500))
# print(img.shape)
#
# cv2.imshow('Result', img)
# cv2.waitKey(0)
# =================================================================
# face_cascades = cv2.CascadeClassifier(cv2.data.haarcascades + "haarcascade_frontalface_default.xml")
#
# img = cv2.imread("face.png")
# img_gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)
# faces = face_cascades.detectMultiScale(img_gray)
# print(faces)
#
# for (x, y, w, h) in faces:
#     cv2.rectangle(img, (x, y), (x + w, y + h), (0, 0, 255), 2)
# #  cv2.rectangle(исходная картика, (коор. начала), (коор. конца), (цвет рамки), толщина рамки)
#
# cv2.imshow('Result', img)
# cv2.waitKey(0)
# =================================================================
face_cascades = cv2.CascadeClassifier(cv2.data.haarcascades + "haarcascade_frontalface_default.xml")
cap = cv2.VideoCapture(0)

while True:
    success, frame = cap.read()
    img_gray = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)
    faces = face_cascades.detectMultiScale(img_gray)

    for (x, y, w, h) in faces:
        cv2.rectangle(frame, (x, y), (x + w, y + h), (0, 0, 255), 2)

    cv2.imshow('Result', frame)

    if cv2.waitKey(1) & 0xff == ord('q'):  # при нажатии на q останавливает цикл
        break
