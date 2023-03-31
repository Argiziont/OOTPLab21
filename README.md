Develop a technical task. Show the decomposition of the task, where some of the tasks should be implemented using generative patterns:
- Prototype.
- Builder. 

Terms of reference.

The technical task: Exporting documents
A special report generator is required that can be used to create reports with different data sources, filters and visualizations. The system should be able to generate reports in various formats including CSV, PDF and HTML.
Requirements:
- The report generator must be implemented in C#.
- The generator should be developed using the Prototype and Builder templates.
- The system should be able to work with multiple data sources, including databases, spreadsheets and CSV files.
- The system should allow the user to specify one or more filters to be applied to the data before generating the report.
- The system should support multiple types of visualization, such as bar charts, line charts, and pie charts.
- The user should be able to select the format in which the report will be generated.
- The system should be able to generate reports in CSV, PDF and HTML formats.
- The system must have a user-friendly interface that guides the user through the report generation process.
Deliverables:
- C# code that implements the report generator using the Prototype and Builder templates.
- Unit tests that check the functionality of the report generator.


The code implements a customizable report generator using the Prototype and Builder templates. The report generator can be used to create reports with different data sources, filters, and visualizations. The system is designed to work with multiple data sources, including databases, spreadsheets, and CSV files.
The Builder template is used to create the ReportBuilder class, which is responsible for creating various parts of the report, such as the header, footer, and body. The Prototype template is used to create a prototype of a report object that can be cloned and customized to meet user specifications.
The code defines different classes for different types of data sources, filters, and visualizations. The user can choose which data source, filter, and visualization to use when creating a report. The user can also select the format in which the report will be generated, such as CSV, PDF, or HTML.
The code also contains unit tests that check the functionality of the report generator. The documentation explains how to use the report generator and how it was implemented using the Prototype and Builder templates.


Розробити технічне завдання. Показати декомпонування завдання, де частина завдань має бути реалізована з використанням породжуючих патернів:
-	Прототип (Prototype).
-	Будівельник (Builder). 

Технічне завдання

Технічне завдання: Експорт документів
Потрібен спеціальний генератор звітів, який можна використовувати для створення звітів з різними джерелами даних, фільтрами та візуалізаціями. Система повинна мати можливість створювати звіти в різних форматах, включаючи CSV, PDF і HTML.
Вимоги:
•	Генератор звітів повинен бути реалізований на C#.
•	Генератор має бути розроблений за допомогою шаблонів Prototype і Builder.
•	Система повинна мати можливість працювати з кількома джерелами даних, включаючи бази даних, електронні таблиці та файли CSV.
•	Система повинна дозволяти користувачеві вказати один або кілька фільтрів для застосування до даних перед створенням звіту.
•	Система повинна підтримувати декілька типів візуалізації, наприклад стовпчасті діаграми, лінійні та кругові діаграми.
•	Користувач повинен мати можливість вибрати формат, у якому буде створено звіт.
•	Система повинна мати можливість створювати звіти у форматах CSV, PDF і HTML.
•	Система повинна мати зручний інтерфейс, який веде користувача через процес формування звіту.
Результати роботи:
•	Код C#, який реалізує генератор звітів за допомогою шаблонів Prototype і Builder.
•	Модульні тести, які перевіряють функціональність генератора звітів.


Код реалізує настроюваний генератор звітів за допомогою шаблонів Prototype і Builder. Генератор звітів можна використовувати для створення звітів із різними джерелами даних, фільтрами та візуалізаціями. Система розроблена для роботи з кількома джерелами даних, включаючи бази даних, електронні таблиці та файли CSV.
Шаблон Builder використовується для створення класу ReportBuilder, який відповідає за створення різних частин звіту, таких як верхній колонтитул, нижній колонтитул і тіло. Шаблон прототипу використовується для створення прототипу об’єкта звіту, який можна клонувати та налаштовувати відповідно до специфікацій користувача.
Код визначає різні класи для різних типів джерел даних, фільтрів і візуалізацій. Користувач може вибрати, яке джерело даних, фільтр і візуалізацію використовувати під час створення звіту. Користувач також може вибрати формат, у якому буде створено звіт, наприклад CSV, PDF або HTML.
Код також містить модульні тести, які перевіряють функціональність генератора звітів. У документації пояснюється, як використовувати генератор звітів і як його було реалізовано за допомогою шаблонів Prototype і Builder.
