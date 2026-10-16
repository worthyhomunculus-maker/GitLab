# Проверка функции A

## Назначение

Отбор узлов, у которых Available == false.

## Основной набор

Входные данные:
- nodeA / true
- nodeB / false
- nodeC / true
- nodeD / false

Ожидаемый результат:
DOWN: nodeB
DOWN: nodeD

Фактический результат:
DOWN: nodeB
DOWN: nodeD

## Проверка отсутствия недоступных узлов

Для набора, в котором все Available == true,
метод Selection.Apply должен вернуть пустой массив.

Ожидаемый результат: 0 строк.