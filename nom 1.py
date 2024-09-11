from datetime import datetime, timedelta
try:
    now = datetime.today().date()
    day_uslovie = datetime(2024,7,20).date()
    date_yours =(input("Введите дату заказа (гггг-мм-дд:)"))
    if now == day_uslovie:
        print("С днем рождения Гарри! Вечеринка сегодня!")
    elif now <= day_uslovie:
        print("Вечереника еще впереди. Осталось :", {now - day_uslovie})
    elif now >= day_uslovie:
        print(f"Вечеринка уже прошла. Остлось: {365-(now-day_uslovie).days} ")
except ValueError as e:
    print("Некорректный ввод данных")