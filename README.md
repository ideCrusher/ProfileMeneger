# ProfileMeneger

При загрузке приложения выводится стартовое сообщение: “Выберите действие:”, нужно ввести команду для продолжения дальнейшей работы.

Список доступных команд:

cmd: -new_profile - Заполнить новую анкету

cmd: -save - Сохранить заполненную анкету

cmd: -goto_question <Номер вопроса> - Вернуться к указанному вопросу (Команда доступна только при заполнении анкеты, вводится вместо ответа на любой вопрос)

cmd: -goto_prev_question - Вернуться к предыдущему вопросу (Команда доступна только при заполнении анкеты, вводится вместо ответа на любой вопрос)

cmd: -restart_profile - Заполнить анкету заново (Команда доступна только при заполнении анкеты, вводится вместо ответа на любой вопрос)

cmd: -find <Имя файла анкеты> - Найти анкету и показать данные анкеты в консоль

cmd: -delete <Имя файла анкеты> - Удалить указанную анкету

cmd: -list - Показать список названий файлов всех сохранённых анкет

cmd: -help - Показать список доступных команд с описанием

cmd: -exit - Выйти из приложения

Заполнить новую анкету

В анкете 5 вопросов:

ФИО

Дата рождения (Формат ДД.ММ.ГГГГ)

Любимый язык программирования (Можно ввести только указанные варианты, иначе ошибка: PHP, JavaScript, C, C++, Java, C#, Python, Ruby)

Опыт программирования на указанном языке (Полных лет)

Мобильный телефон

Вопросы должны идти по очереди, после того как пользователь ввёл ответ, выводить следующий вопрос или ошибку.

Все вопросы обязательны для заполнения.

После заполнения всех вопросов, выводится сообщение: “Выберите действие:”, нужно ввести команду для продолжения дальнейшей работы.

Сохранить заполненную анкету

Анкета должна сохраняться в текстовом файле (txt) с именем, которое пользователь указал в ФИО, в каталоге с названием "Анкеты", который должен находится в каталоге приложения.

Структура текстового файла анкеты:

1. ФИО: <ФИО>
2. Дата рождения: <Дата рождения>
3. Любимый язык программирования: <Любимый язык программирования>
4. Опыт программирования на указанном языке: <Опыт программирования на указанном языке>
5. Мобильный телефон: <Мобильный телефон>

Анкета заполнена: <Дата заполнения анкеты>
