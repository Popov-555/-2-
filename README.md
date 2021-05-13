</td>
  </tr>
  <tr>
    <td style="text-align: center; border: none; height: 15em;">
    <td style="text-align: center; border: none; height: 16em;">
    <h2 style="font-size:3em;">Отчет</h2>
      <h3>по лабораторной работе<br><br> по дисциплине "Основы алгоритмизации и программирования"<br><br> Тема:<b> "Лабораторная работа "Создание WPF-приложения. Знакомство с компоновкой""<b> </h3></td>
     
  </tr>
  <tr>
    <br><br><td style="text-align: right; border: none; height: 20em;">
      Разработал:<br/>
     Попов Илья<br>

      Группа: И-21<br>
      Преподаватель:<br>
      Колесников Евгений Иванович
@@ -30,60 +30,32 @@

# Цели и задачи:

1: Создать приложение WPF .NET Framework
2: Исследовать контейнеры

Grid: создать сетку с разными типами выравнивания (auto, фискированное, динамическое)
StackPanel: создать панели с разной ориентацией и выравниванием вложенных эелементов
WrapPanel

3: Результаты оформить в формате MarkDown с использованием примеров разметки



# Что делал

1) ```GRID
Title="MainWindow" Height="450" Width="800">
    <Grid Margin="0,1,0,-1" RenderTransformOrigin="0.505,0.525">
        <Grid.RowDefinitions>
            <RowDefinition Height="auto"/>
            <RowDefinition Height="299"/>
        </Grid.RowDefinitions>
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="auto"/>
            <ColumnDefinition Width="*"/>
            <ColumnDefinition Width="*"/>
        </Grid.ColumnDefinitions>
      
        <Button 
            Grid.Column="1" 
            Grid.Row="1" 
            Content="Строка " Margin="50,33,156,201"  />
        <Button Content="Button" Grid.Column="1" HorizontalAlignment="Left" Margin="40,55,0,0" VerticalAlignment="Top" Width="80" Height="35"/>
    </Grid>
</Window>
```
[Снимок1.PNG](C:\Users\User\Desktop\Новая папка (4) ) в JSON-строку)
# Вывод
Научился работать с GRID
