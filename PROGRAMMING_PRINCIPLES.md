# Принципи програмування, використані у проєкті

## 1. Модульність (Modularity)

У проєкті реалізовано поділ на окремі модулі.  
Бібліотеки класів містять логіку роботи з файлами, архівацією та кодуванням, а Windows Forms застосунок відповідає за взаємодію з користувачем.

Клас [MyFile](https://github.com/ipz242ksyu-lab/kpz_lab_1/blob/master/MyFile/Class1.cs)  містить метод [Save()](https://github.com/ipz242ksyu-lab/kpz_lab_1/blob/master/MyFile/Class1.cs) для збереження файлів 
Клас [ZippingUnzipping](https://github.com/ipz242ksyu-lab/kpz_lab_1/blob/master/ClassLibrary2/Class1.cs) містить методи [Zipping()](https://github.com/ipz242ksyu-lab/kpz_lab_1/blob/master/ClassLibrary2/Class1.cs
), [Unzipping()](https://github.com/ipz242ksyu-lab/kpz_lab_1/blob/master/ClassLibrary2/Class1.cs
) та [RemoveDirectory()(](https://github.com/ipz242ksyu-lab/kpz_lab_1/blob/master/ClassLibrary2/Class1.cs
)


Клас EncodingDecoding містить методи Encoding() та Decoding():
https://github.com/ipz242ksyu-lab/kpz_lab_1/blob/master/ClassLibrary1/Class1.cs

Форма Form1 містить методи роботи з інтерфейсом користувача:
OpenFileToolStripMenuItem_Click(),
SaveAsToolStripMenuItem_Click(),
EncodingToolStripMenuItem_Click(),
DecodingToolStripMenuItem_Click():
https://github.com/ipz242ksyu-lab/kpz_lab_1/blob/master/WindowsForms/Form1.cs

Такий поділ дозволяє відокремити логіку програми від графічного інтерфейсу.

---

## 2. Абстракція (Abstraction)

У проєкті реалізовано приховування внутрішньої логіки роботи з файлами та архівами.

Клас EncodingDecoding приховує логіку кодування та декодування файлів у методах:
Encoding() та Decoding():
https://github.com/ipz242ksyu-lab/kpz_lab_1/blob/master/ClassLibrary1/Class1.cs

Клас ZippingUnzipping приховує логіку архівації та розархівації у методах:
Zipping() та Unzipping():
https://github.com/ipz242ksyu-lab/kpz_lab_1/blob/master/ClassLibrary2/Class1.cs

Користувач програми викликає готові методи без необхідності знати деталі їх реалізації.

---

## 3. Інкапсуляція (Encapsulation)

У проєкті використовується інкапсуляція даних шляхом об’єднання полів та методів у межах окремих класів.

Клас MyFile об’єднує поля:
Name,
Bytes,
Path

та метод Save() для роботи з файлами:
https://github.com/ipz242ksyu-lab/kpz_lab_1/blob/master/MyFile/Class1.cs

Клас EncodingDecoding працює з об’єктами MyFile через методи:
Encoding() та Decoding():
https://github.com/ipz242ksyu-lab/kpz_lab_1/blob/master/ClassLibrary1/Class1.cs

Це дозволяє контролювати роботу з даними через методи класів.

---

## 4. Принцип єдиної відповідальності (Single Responsibility Principle)

Кожен клас у проєкті відповідає лише за одну задачу.

Клас MyFile відповідає за збереження та зчитування файлів:
https://github.com/ipz242ksyu-lab/kpz_lab_1/blob/master/MyFile/Class1.cs

Клас EncodingDecoding відповідає лише за кодування та декодування файлів через методи:
Encoding() та Decoding():
https://github.com/ipz242ksyu-lab/kpz_lab_1/blob/master/ClassLibrary1/Class1.cs

Клас ZippingUnzipping відповідає за архівацію через методи:
Zipping(),
Unzipping(),
RemoveDirectory():
https://github.com/ipz242ksyu-lab/kpz_lab_1/blob/master/ClassLibrary2/Class1.cs

Форма Form1 відповідає лише за взаємодію з користувачем та обробку подій:
OpenFileToolStripMenuItem_Click(),
SaveAsToolStripMenuItem_Click(),
listView_DragDrop():
https://github.com/ipz242ksyu-lab/kpz_lab_1/blob/master/WindowsForms/Form1.cs

---

## 5. Принцип DRY (Don't Repeat Yourself)

У проєкті використовується повторне використання методів без дублювання коду.

У Form1 для додавання файлів використовуються окремі методи:
AddFile(string path)
та
AddFile(MyFile file):
https://github.com/ipz242ksyu-lab/kpz_lab_1/blob/master/WindowsForms/Form1.cs

Замість повторення однакової логіки кодування та декодування використовується один алгоритм XOR у методах:
Encoding() та Decoding():
https://github.com/ipz242ksyu-lab/kpz_lab_1/blob/master/ClassLibrary1/Class1.cs

Це зменшує дублювання коду та покращує підтримку проєкту.
