try:
    from datetime import datetime, timedelta
    now = datetime.now()
    updated_time = now + timedelta(hours=1)
    vkusno="Вкусно"
    print("Доступные пиццы:")
    print("1.Маргарита")
    print("2.Пепперони")
    print("3.Грибная")
    print("4.Четыре сыра")
    print("5.Капричоза")
    order = int(input("Какую пиццу вы хотите заказать? (Введите номер)"))
    if order>= 5:
        print("Ошибка: Номер пиццы отсутствует. Пожуалйста, выберите номер из списка.")
    count = int(input("Сколько пицц вы хотите заказать? (Введите количество)"))
    if order==1:
        rezult="Маргарита"
    elif order==2:
        rezult="Пепперони"
    elif order==3:
        rezult="Грибная"
    elif order==4:
        rezult="Четыре сыра"
    elif order==5:
        rezult="Капричоза"
    print(f'Вы заказали {count} пицц {rezult}')
    quetion = (input("Готовы ли вы оставить отзыв? (да/нет):"))
    if quetion=="нет":
        print("Спасибо, что воспользовались нашим сервисом!")
    elif quetion=="да":
        vopros = input("Введите ваш отзыв:")
        index = vopros.find(vkusno.lower())
    if index != -1:
        print("Спасибо за положительный отзыв! Получите пиццу в подарок:")
        print("Доступные пиццы:")
        print("1.Маргарита")
        print("2.Пепперони")
        print("3.Грибная")
        print("4.Четыре сыра")
        print("5.Капричоза")
    else:
        print("Спаибо за ваш отзыв!")
    print(f'Заказ от {now} принят. Наш курьер подъедет к вам в течении часа (до {updated_time})')
except ValueError as e:
    print("Ошибка: Ввод должен быть числом.")


