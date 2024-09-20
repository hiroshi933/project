import random
try:
    zaklinaniya = int(input("Сколько заклинаний вы пременили?"))
    name_perviy = input("Как вас зовут?")
    vtoroy = input("Вы разгадали задачу?")
    polosa = input("Вы прошли полосу препятствий?")
    name_2 = input("Как вас зовут?")
    vtoroy_2 = input("Вы разгадали задачу?")
    polosa_2 = input("Вы прошли полосу препятствий?")
    x = random.randint(3,60)
    y = random.randint(30, 50)
    tree_etap = 40
    nol = 0
    #perviy_etap
    perviy_etap = (x * zaklinaniya)
    print("За первый этап у вас:", perviy_etap)
    #vtoroy_etap
    if vtoroy == "True":
        print("За второй этап у вас:", y)
    elif vtoroy == "False":
        print("За второй этап у вас:", nol)
    #tretiy_etap
    if polosa == "True":
        print("За третий этап у вас:", tree_etap)
    elif polosa == "False":
        print("За третий этап у вас:", nol)
    summa = vtoroy + polosa + perviy_etap
        print("У первого игрока:", summa)
except ValueError as e:
    print("Некорректный ввод данных")