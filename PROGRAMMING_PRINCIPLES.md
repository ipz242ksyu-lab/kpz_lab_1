# Принципи програмування. Запахи коду.

## Криворука Софія ІПЗ-24-2

У проєкті використовується повторне використання методів замість дублювання коду. Наприклад, метод `Add File()` використовується для додавання файлів у різних місцях програми.

Приклад:

        private void AddFile(string path)
        {
            var file = new MyFile(path);
            FileList.Add(file);
            listView.Items.Add(new ListViewItem(new string[] { (listView.Items.Count + 1).ToString(), file.Name }));
        }

        private void AddFile(MyFile file)
        {
            FileList.Add(file);
            listView.Items.Add(new ListViewItem(new string[] { (listView.Items.Count + 1).ToString(), file.Name }));
        }

## Single Responsibility Principle

Кожен клас виконує окрему задачу:
- `EncodingDecoding` відповідає за кодування та декодування файлів.
- `MyFile` відповідає за роботу з файлами.
- `Form1` відповідає за графічний інтерфейс.

Приклад:
- ClassLibrary1/Class1.cs
- MyFile/Class1.cs
- WindowsForms/Form1.cs

## Encapsulation

Дані файлів інкапсульовані у класі `MyFile`. Робота з даними відбувається через методи класу, а не напряму.

Приклад:
- MyFile/Class1.cs

## Modularity

Проєкт поділений на декілька бібліотек класів:
- `ClassLibrary1`
- `ClassLibrary2`
- `MyFile`
- `WindowsForms`

Це дозволяє розділити логіку програми на незалежні модулі.

## Readability

У коді використовуються зрозумілі назви класів і методів:
- `Encoding`
- `Decoding`
- `AddFile`
- `Save`

Це покращує читабельність та підтримку коду.
