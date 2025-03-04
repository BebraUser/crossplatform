Для передачі аргументів використовувати таку команду:
```bash
dotnet run -- аргументи
```

Приклад:
```bash
dotnet run -- run lab1 --input ./inputs/INPUT.txt -o OUTPUT.txt
```
---

Файл .nupkg було створено через Visual Studio, через модифікаю файлу .csproj

Команда за якою було створено nuget пакунок:
```bash
dotnet nuget push dserhiichuk.1.0.0.nupkg -s http://localhost:5000/v3/index.json
```

Для створення віртуальних машин потрібно мати Virtual Box та Vagrant.
Перейдіть у папку vagrant, а далі оберіть папку, залежно від бажаної ОС.

Для створення ВМ потрібно запустити команду:
```bash
vagrant up
```
Якщо, під час створення, ви отримаєте запит: "Which interface should the network bridge to?", то введіть: 1

Після цього ВМ буде встановлена і буде мати dotnet 6.0 зі встановленим nuget пакунком

Для користування програмою, з пакунку, потрібно отримати доступ до ВМ:
* Через vagrant ssh
* Через Virtual Box

Після цього потрібно налаштувати INPUT.txt файл(и)

Для запуску програми потрібно ввести:
* Для Windows: Lab_4
* Для Linux: dotnet Lab_4 або dotnet tool run Lab_4

Дане завдання не було реалізовано для Mac OS через неможливість запустити ВМ