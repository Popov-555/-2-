﻿# Лабораторная работа
<table style="width: 100%;">
  <tr>
    <td style="text-align: center; border: none;">
    Министерство образования и науки РФ<br>
Государственное бюджетное профессиональное образовательное учреждение Республики Марий Эл<br>
Йошкар-Олинский технологический колледж
</td>
  </tr>
  <tr>
    <td style="text-align: center; border: none; height: 15em;">
    <h2 style="font-size:3em;">Отчет</h2>
      <h3>по лабораторной работе<br><br> по дисциплине "Основы алгоритмизации и программирования"<br><br> Тема:<b> "Типы файлов: CSV, XML, JSON."<b> </h3></td>
   </tr>
  <tr>
    <br><br><td style="text-align: right; border: none; height: 20em;">
      Разработал:<br/>
      Попов Илья<br>
      Группа: И-21<br>
      Преподаватель:<br>
      Колесников Евгений Иванович
    </td>
  </tr>
  <tr>
    <td style="text-align: center; border: none; height: 5em;">
    г.Йошкар-Ола,<br> 2021</td>
  </tr>
</table>
  

<div style="page-break-after: always;"></div>

# Цели и задачи:

1: Используя примеры из лекции Форматы файлов реализовать слежующий функционал:

2: Используя класс StringReader создать поток с CSV данными, приведенными ниже:

3: Считать данные из созданного потока в список используя класс TextFieldParser

4: Сохранить полученный список в файл в формате XML используя сериализацию

5: В отдельной функции считать ранее созданный XML-файл и сохранить данные в файл в формате JSON используя сериализацию.
# Краткий материал.

Для удобного сохранения и извлечения объектов из файлов xml может использоваться класс XmlSerializer.

Во-первых, XmlSerializer предполагает некоторые ограничения. Например, класс, подлежащий сериализации, должен иметь стандартный конструктор без параметров. Также сериализации подлежат только открытые члены. Если в классе есть поля или свойства с модификатором private, то при сериализации они будут игнорироваться.

Для того чтобы сериализация объекта стала возможна он должен быть отмечен атрибутом DataContract, а его члены подлежащие сериализации атрибутом DataMember.

Сериализация (Преобразование объекта в JSON-строку)
# Вывод
Используя примеры из лекции Форматы файлов реализовать слежующий функционал: Используя класс StringReader создал поток с CSV данными, приведенными, считал данные из созданного потока в список используя класс TextFieldParser, сохранил полученный список в файл в формате XML используя сериализацию,в отдельной функции считал ранее созданный XML-файл и сохранил данные в файл в формате JSON используя сериализацию.
