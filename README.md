# Простой шифратор и дешифратор

## Задание
Напишите программу шифрования и расшифрования текстового файла с использованием ключа, заданного строкой символов. При шифровании к коду каждого символа строки исходного файла следует прибавить код очередного символа ключа и вычесть порядковый номер символа в строке. В выходной файл символы зашифрованной строки запишите в обратном порядке.


## Описание алгоритма
1.	Шифрование
В поля для ввода текста вводится ключ. При нажатии кнопки “Зашифровать” пользователь выбирает сначала файл, который нужно зашифровать, затем выбирается файл, в который будет сохранен зашифрованный текст ( или выбирается опция создания нового файла). Программа проверяет, введен ли ключ. Если ключ не введен то программа показывает всплывающее окно с ошибкой. Если ключ введен, то программа читает текст, который предстоит зашифровать, из файла, шифрует его (добавляет к коду очередного символа из текста код очередного символа из ключа и вычитает номер исходного символа в строке), записывает зашифрованный текст в файл.
2.	Дешифрование
В поля для ввода текста вводится ключ. При нажатии кнопки “Дешифровать” пользователь выбирает сначала файл, который нужно расшифровать, затем выбирается файл, в который будет сохранен зашифрованный текст ( или выбирается опция создания нового файла). Программа проверяет, введен ли ключ. Если ключ не введен то программа показывает всплывающее окно с ошибкой. Если ключ введен, то программа читает текст, который предстоит расшифровать, из файла, дешифрует его (вычитает из кода очередного символа из текста код очередного символа из ключа и прибавляет номер исходного символа в строке), записывает дешифрованный текст в файл.

## Работа программы
![изображение](https://github.com/Maritornez/SimpleCrypterAndDecrypter/assets/62441435/a6f29582-df24-4798-aa29-c6fc657dcfb2)

Рисунок 1 — Главное окно

![изображение](https://github.com/Maritornez/SimpleCrypterAndDecrypter/assets/62441435/77d1cf92-06e3-47b6-a78f-a3d6c25acbcb)

Рисунок 2 — Открытие файла с зашифрованным текстом

![изображение](https://github.com/Maritornez/SimpleCrypterAndDecrypter/assets/62441435/1719628a-682f-462a-b4c9-3f4c36492939)

Рисунок 2 — Выбор файла, куда будет сохранен зашифрованный текст

![изображение](https://github.com/Maritornez/SimpleCrypterAndDecrypter/assets/62441435/73f988d1-d991-4fac-9a87-4b9bb71f520a)

Рисунок 3 — Исходный текст

![изображение](https://github.com/Maritornez/SimpleCrypterAndDecrypter/assets/62441435/c6bbe3b0-b3eb-4bb1-839a-c9eaac9255b3)

Рисунок 3 — Исходный текст

![изображение](https://github.com/Maritornez/SimpleCrypterAndDecrypter/assets/62441435/d8bd74bc-2e87-4379-bdaa-4b09421a72b0)

Рисунок 3 — Зашифрованный текст

![изображение](https://github.com/Maritornez/SimpleCrypterAndDecrypter/assets/62441435/09c6a0ec-ac64-414a-a420-2180c2192cd9)

Рисунок 3 — Расшифрованный текст
