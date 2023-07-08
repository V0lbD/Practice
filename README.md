# Practice
Летняя практика 2023, группа: C#

## [Задание 1](Lab1).
Реализовать класс Student, хранящий информацию о студенте. Хранимые данные: 
- **ФИО** (как отдельные поля);
- **учебная группа** (в формате M[Номер института]O-[Номер группы][Б,М,А]-[Год поступления]; строку считаем априори валидной);
- **выбранный курс для прохождения практики** (C#, Go, Yandex, Сбор и разметка данных, Инфраструктурная деятельность, etc.).

Реализуйте конструктор объекта класса, позволяющий заполнить поля объекта (для ссылок на объекты строк не допускаются значения null в
качестве параметров конструктора - при возникновении такой ситуации
генерируйте исключительную ситуацию типа
```System.ArgumentNullException```; исключительная ситуация также должна
быть перехвачена в вызывающем коде). 

Реализуйте свойства, позволяющие запрашивать значения отдельных полей объекта класса. Также реализуйте
свойство, позволяющее получить номер курса по учебной группе.

Переопределите методы ```object.ToString```, ```object.Equals```, ```object.GetHashCode```.

В классе реализуйте интерфейс ```System.IEquatable<Student>```.

Продемонстрируйте взаимодействие с объектами класса.

---
## [Задание 2](Lab2). 
Реализовать класс, предоставляющий три метода расширения для обобщённого интерфейса ```IEnumerable<T>```:
- Генерация всех возможных сочетаний из n (кол-во элементов перечисления) по k (с точностью до порядка, элементы могут повторяться) из элементов входного перечисления: \
Входное перечисление: [1, 2, 3]; k == 2 \
Выходное перечисление: [ [1, 1], [1, 2], [1, 3], [2, 2], [2, 3], [3, 3] ] 
- Генерация всех возможных подмножеств (без повторений) из элементов входного перечисления: \
Входное перечисление: [1, 2] &emsp; \
Выходное перечисление: [ [], [1], [2], [1, 2] ] 
- Генерация всех возможных перестановок (без повторений) из элементов входного перечисления: \
Входное перечисление: [1, 2, 3] \
Выходное перечисление: [ [1, 2, 3], [1, 3, 2], [2, 1, 3], [2, 3, 1], [3, 1, 2], [3, 2, 1] ] 

Для каждого из методов требуется проверка элементов входного перечисления на предмет попарного неравенства по отношению эквивалентности, 
передаваемому в метод в виде реализации обобщённого интерфейса ```IEqualityComparer<T>``` 
(если нашлись два равных по переданному отношению эквивалентности элемента, то должна быть сгенерирована исключительная ситуация 
типа ```ArgumentException``` для входного перечисления). 

Продемонстрировать работу реализованных методов.

---
## [Задание 3](Lab3). 
Реализуйте набор перегруженных методов расширения для сортировки обобщённых массивов данных. 
В качестве первого параметра методы получают на вход коллекцию сортируемых данных типа ```T[]```.

В качестве второго - порядок сортировки (по возрастанию, по убыванию) - в виде значения собственного перечислимого типа (```enum```).

Третий параметр - алгоритм сортировки (вставками, выбором, пирамидальная, быстрая, слиянием).


Методы перегружены засчёт четвёртого параметра: 
- его нет (должен быть обеспечено ограничение внутренней сравнимости на предмет отношения порядка элементов массива); 
- значение типа ```IComparer<T>```, задающее внешнее правило отношения порядка на пространстве элементов типа T; 
- значение типа ```Comparer<T>```, задающее внешнее правило отношения порядка на пространстве элементов типа T; 
- делегат ```Comparison<T>```, на объект которого подписан метод, задающий внешнее отношение порядка на пространстве элементов типа T. 

Возвращаемое значение метода типа ```T[]``` - отсортированный массив.

---
