# arestov_repo
репозиторий проекта по специализации
Описание решения:
Сначала мы объявляем массив, затем назначаем максимальную длину конечного массива. 
С помощью  метода resize меняем размер массива. 

Я не смог закомититть последующие изменения в файле program.cs и загрузил файлы с компьютера напрямую. Историю моих действий можно посмотреть в текстовом ниже. Sorry за неудобства. 

PS C:\Users\R\Desktop\arestov_project> git init
Initialized empty Git repository in C:/Users/R/Desktop/arestov_project/.git
PS C:\Users\R\Desktop\arestov_project> git add README.md
PS C:\Users\R\Desktop\arestov_project> git status

No commits yet

  (use "git rm --cached <file>..." to unstage)
PS C:\Users\R\Desktop\arestov_project> git commit -m "first commit"
 create mode 100644 README.md
* master
PS C:\Users\R\Desktop\arestov_project> git branch -m main
* main
PS C:\Users\R\Desktop\arestov_project> git remote add origin https://github
PS C:\Users\R\Desktop\arestov_project> git remote
origin
PS C:\Users\R\Desktop\arestov_project> git remote -v
origin  https://github.com/ruslanalex/arestov_repo (fetch)
origin  https://github.com/ruslanalex/arestov_repo (push)
PS C:\Users\R\Desktop\arestov_project> git push -u origin main
error: failed to push some refs to 'https://github.com/ruslanalex/arestov_r
hint: not have locally. This is usually caused by another repository pushin
hint: to the same ref. You may want to first integrate the remote changes
hint: See the 'Note about fast-forwards' in 'git push --help' for details.
* master
error: src refspec main does not match any
PS C:\Users\R\Desktop\arestov_project> git branch
* master
PS C:\Users\R\Desktop\arestov_project> git branch -m main
PS C:\Users\R\Desktop\arestov_project> git branch
* main
PS C:\Users\R\Desktop\arestov_project> git remote add origin https://github
error: remote origin already exists.
PS C:\Users\R\Desktop\arestov_project> git push -u origin main
 ! [rejected]        main -> main (fetch first)
error: failed to push some refs to 'https://github.com/ruslanalex/arestov_r
hint: Updates were rejected because the remote contains work that you do
hint: not have locally. This is usually caused by another repository pushin
hint: to the same ref. You may want to first integrate the remote changes
hint: (e.g., 'git pull ...') before pushing again.
hint: See the 'Note about fast-forwards' in 'git push --help' for details.
PS C:\Users\R\Desktop\arestov_project> git pull
remote: Enumerating objects: 3, done.
remote: Counting objects: 100% (3/3), done.
remote: Compressing objects: 100% (2/2), done.
remote: Total 3 (delta 0), reused 0 (delta 0), pack-reused 0
Unpacking objects: 100% (3/3), 658 bytes | 14.00 KiB/s, done.
From https://github.com/ruslanalex/arestov_repo
 * [new branch]      main       -> origin/main
There is no tracking information for the current branch.
Please specify which branch you want to merge with.

    git pull <remote> <branch>
If you wish to set tracking information for this branch you can do so with:

    git branch --set-upstream-to=origin/<branch> main

PS C:\Users\R\Desktop\arestov_project> git remote -v
origin  https://github.com/ruslanalex/arestov_repo (fetch)
origin  https://github.com/ruslanalex/arestov_repo (push)
PS C:\Users\R\Desktop\arestov_project> dotnet new console
Шаблон "Консольное приложение" успешно создан.

Идет обработка действий после создания...
Выполнение "dotnet restore" для C:\Users\R\Desktop\arestov_project\arestov_
  Определение проектов для восстановления...
  Восстановлен C:\Users\R\Desktop\arestov_project\arestov_project.csproj (з
Восстановление выполнено.


PS C:\Users\R\Desktop\arestov_project> dotnet run
C:\Users\R\Desktop\arestov_project\Program.cs(4,19): error CS0103: Имя "Russia" не существует в текущем контексте. [C:\Users\R\Desktop\arestov_p
roject\arestov_project.csproj]
C:\Users\R\Desktop\arestov_project\Program.cs(4,27): error CS0103: Имя "Denmark" не существует в текущем контексте. [C:\Users\R\Desktop\arestov_
project\arestov_project.csproj]
C:\Users\R\Desktop\arestov_project\Program.cs(4,36): error CS0103: Имя "Kazan" не существует в текущем контексте. [C:\Users\R\Desktop\arestov_pr
oject\arestov_project.csproj]
C:\Users\R\Desktop\arestov_project\Program.cs(9,10): error CS8112: Локальная функция "GetShortWordsArray(string[])" должна объявить тело, так ка
к она не помечена как "static extern". [C:\Users\R\Desktop\arestov_project\arestov_project.csproj]
C:\Users\R\Desktop\arestov_project\Program.cs(11,18): error CS0120: Для нестатического поля, метода или свойства "Array.Length" требуется ссылка 
 на объект. [C:\Users\R\Desktop\arestov_project\arestov_project.csproj]
C:\Users\R\Desktop\arestov_project\Program.cs(17,12): error CS0103: Имя "array" не существует в текущем контексте. [C:\Users\R\Desktop\arestov_p 
roject\arestov_project.csproj]
C:\Users\R\Desktop\arestov_project\Program.cs(17,31): error CS0103: Имя "MAX_WORD_LENGTH" не существует в текущем контексте. [C:\Users\R\Desktop 
\arestov_project\arestov_project.csproj]
C:\Users\R\Desktop\arestov_project\Program.cs(19,29): error CS0103: Имя "array" не существует в текущем контексте. [C:\Users\R\Desktop\arestov_p
roject\arestov_project.csproj]
C:\Users\R\Desktop\arestov_project\Program.cs(25,12): error CS0029: Не удается неявно преобразовать тип "string[]" в "int". [C:\Users\R\Desktop\ 
arestov_project\arestov_project.csproj]
C:\Users\R\Desktop\arestov_project\Program.cs(28,4): error CS0103: Имя "array" не существует в текущем контексте. [C:\Users\R\Desktop\arestov_pr 
oject\arestov_project.csproj]
C:\Users\R\Desktop\arestov_project\Program.cs(34,15): error CS0103: Имя "array" не существует в текущем контексте. [C:\Users\R\Desktop\arestov_p 
roject\arestov_project.csproj]
C:\Users\R\Desktop\arestov_project\Program.cs(50,6): error CS0128: Локальная переменная или функция с именем "PrintTask" уже определена в этой о 
бласти. [C:\Users\R\Desktop\arestov_project\arestov_project.csproj]
C:\Users\R\Desktop\arestov_project\Program.cs(53,5): error CS0103: Имя "PrintArray" не существует в текущем контексте. [C:\Users\R\Desktop\arest 
ov_project\arestov_project.csproj]
C:\Users\R\Desktop\arestov_project\Program.cs(55,69): error CS0103: Имя "MAX_WORD_LENGTH" не существует в текущем контексте. [C:\Users\R\Desktop
\arestov_project\arestov_project.csproj]
C:\Users\R\Desktop\arestov_project\Program.cs(56,5): error CS0103: Имя "PrintArray" не существует в текущем контексте. [C:\Users\R\Desktop\arest 
ov_project\arestov_project.csproj]
C:\Users\R\Desktop\arestov_project\Program.cs(59,11): error CS0103: Имя "arr" не существует в текущем контексте. [C:\Users\R\Desktop\arestov_pro 
ect.csproj]
C:\Users\R\Desktop\arestov_project\Program.cs(7,5): warning CS0219: Переменной "max_word_length" присвоено значенop\arestov_project\arestov_projие, но оно ни разу не использов
ано. [C:\Users\R\Desktop\arestov_project\arestov_project.csproj]                                                 ие, но оно ни разу не использов 
 но не используется. [C:\Users\R\De                                                                           но 
sktop\arestov_project\arestov_project.csproj]                                                                    не используется. [C:\Users\R\De 

Ошибка сборки. Устраните ошибки сборки и повторите попытку.
PS C:\Users\R\Desktop\arestov_project> dotnet run
C:\Users\R\Desktop\arestov_project\Program.cs(8,10): error CS8112: Локальная функция "GetShortWordsArray(str
ing[])" должна объявить тело, так как она не помечена как "static extern". [C:\Users\R\Desktop\arestov_proje 
ct\arestov_project.csproj]
C:\Users\R\Desktop\arestov_project\Program.cs(10,18): error CS0120: Для нестатического поля, метода или свой
ства "Array.Length" требуется ссылка на объект. [C:\Users\R\Desktop\arestov_project\arestov_project.csproj]  
C:\Users\R\Desktop\arestov_project\Program.cs(16,12): error CS0103: Имя "array" не существует в текущем конт 
ексте. [C:\Users\R\Desktop\arestov_project\arestov_project.csproj]
C:\Users\R\Desktop\arestov_project\Program.cs(16,31): error CS0103: Имя "MAX_WORD_LENGTH" не существует в те 
кущем контексте. [C:\Users\R\Desktop\arestov_project\arestov_project.csproj]
C:\Users\R\Desktop\arestov_project\Program.cs(18,29): error CS0103: Имя "array" не существует в текущем конт 
ексте. [C:\Users\R\Desktop\arestov_project\arestov_project.csproj]
C:\Users\R\Desktop\arestov_project\Program.cs(24,12): error CS0029: Не удается неявно преобразовать тип "str 
ing[]" в "int". [C:\Users\R\Desktop\arestov_project\arestov_project.csproj]
C:\Users\R\Desktop\arestov_project\Program.cs(27,4): error CS0103: Имя "array" не существует в текущем конте 
ксте. [C:\Users\R\Desktop\arestov_project\arestov_project.csproj]
C:\Users\R\Desktop\arestov_project\Program.cs(33,15): error CS0103: Имя "array" не существует в текущем конт
ексте. [C:\Users\R\Desktop\arestov_project\arestov_project.csproj]
C:\Users\R\Desktop\arestov_project\Program.cs(49,6): error CS0128: Локальная переменная или функция с именем 
 "PrintTask" уже определена в этой области. [C:\Users\R\Desktop\arestov_project\arestov_project.csproj]      
C:\Users\R\Desktop\arestov_project\Program.cs(52,5): error CS0103: Имя "PrintArray" не существует в текущем  
контексте. [C:\Users\R\Desktop\arestov_project\arestov_project.csproj]
C:\Users\R\Desktop\arestov_project\Program.cs(54,69): error CS0103: Имя "MAX_WORD_LENGTH" не существует в те
кущем контексте. [C:\Users\R\Desktop\arestov_project\arestov_project.csproj]
C:\Users\R\Desktop\arestov_project\Program.cs(55,5): error CS0103: Имя "PrintArray" не существует в текущем  
контексте. [C:\Users\R\Desktop\arestov_project\arestov_project.csproj]
C:\Users\R\Desktop\arestov_project\Program.cs(58,11): error CS0103: Имя "arr" не существует в текущем контек 
сте. [C:\Users\R\Desktop\arestov_project\arestov_project.csproj]
C:\Users\R\Desktop\arestov_project\Program.cs(27,1): warning CS0162: Обнаружен недостижимый код [C:\Users\R\
Desktop\arestov_project\arestov_project.csproj]
C:\Users\R\Desktop\arestov_project\Program.cs(3,7): warning CS0168: Переменная "myArray" объявлена, но ни ра 
зу не использована. [C:\Users\R\Desktop\arestov_project\arestov_project.csproj]
C:\Users\R\Desktop\arestov_project\Program.cs(6,5): warning CS0219: Переменной "max_word_length" присвоено з 
C:\Users\R\Desktop\arestov_project\Program.cs(49,6): warning CS8321: Локальная функция "PrintTask" объявлена 
, но не используется. [C:\Users\R\Desktop\arestov_project\arestov_project.csproj]

Ошибка сборки. Устраните ошибки сборки и повторите попытку.
PS C:\Users\R\Desktop\arestov_project> dotnet run
C:\Users\R\Desktop\arestov_project\Program.cs(55,2): error CS1022: Требуется определение типа или пространст
C:\Users\R\Desktop\arestov_project\Program.cs(56,1): error CS1022: Требуется определение типа или пространст 
ва имен, либо признак конца файла. [C:\Users\R\Desktop\arestov_project\arestov_project.csproj]

Ошибка сборки. Устраните ошибки сборки и повторите попытку.
PS C:\Users\R\Desktop\arestov_project> dotnet run
C:\Users\R\Desktop\arestov_project\Program.cs(26,4): error CS0176: Доступ к члену "Array.Resize<string>(ref 
string[]?, int)" через ссылку на экземпляр невозможен; вместо этого уточните его, указав имя типа. [C:\Users 
\R\Desktop\arestov_project\arestov_project.csproj]
C:\Users\R\Desktop\arestov_project\Program.cs(39,5): error CS0176: Доступ к члену "Array.ForEach<string>(str 
ing[], Action<string>)" через ссылку на экземпляр невозможен; вместо этого уточните его, указав имя типа. [C 
:\Users\R\Desktop\arestov_project\arestov_project.csproj]
C:\Users\R\Desktop\arestov_project\Program.cs(54,3): error CS0165: Использование локальной переменной "Array 
C:\Users\R\Desktop\arestov_project\Program.cs(6,5): warning CS0219: Переменной "max_word_length" присвоено з 
начение, но оно ни разу не использовано. [C:\Users\R\Desktop\arestov_project\arestov_project.csproj]

Ошибка сборки. Устраните ошибки сборки и повторите попытку.
PS C:\Users\R\Desktop\arestov_project> dotnet run
C:\Users\R\Desktop\arestov_project\Program.cs(26,4): error CS0176: Доступ к члену "Array.Resize<string>(ref 
string[]?, int)" через ссылку на экземпляр невозможен; вместо этого уточните его, указав имя типа. [C:\Users 
\R\Desktop\arestov_project\arestov_project.csproj]
C:\Users\R\Desktop\arestov_project\Program.cs(39,5): error CS0176: Доступ к члену "Array.ForEach<string>(str 
ing[], Action<string>)" через ссылку на экземпляр невозможен; вместо этого уточните его, указав имя типа. [C 
:\Users\R\Desktop\arestov_project\arestov_project.csproj]
C:\Users\R\Desktop\arestov_project\Program.cs(54,13): error CS0103: Имя "arr1" не существует в текущем конте 
ксте. [C:\Users\R\Desktop\arestov_project\arestov_project.csproj]
C:\Users\R\Desktop\arestov_project\Program.cs(54,3): error CS0165: Использование локальной переменной "Array 
C:\Users\R\Desktop\arestov_project\Program.cs(6,5): warning CS0219: Переменной "max_word_length" присвоено з 
начение, но оно ни разу не использовано. [C:\Users\R\Desktop\arestov_project\arestov_project.csproj]

Ошибка сборки. Устраните ошибки сборки и повторите попытку.
PS C:\Users\R\Desktop\arestov_project> git commit
On branch main
Changes not staged for commit:
  (use "git add <file>..." to update what will be committed)
  (use "git restore <file>..." to discard changes in working directory)
        modified:   README.md

Untracked files:
  (use "git add <file>..." to include in what will be committed)
        obj/

no changes added to commit (use "git add" and/or "git commit -a")
PS C:\Users\R\Desktop\arestov_project> git add Program.cs
git: 'remone' is not a git command. See 'git --help'.

        remote
PS C:\Users\R\Desktop\arestov_project> git remote -v
origin  https://github.com/ruslanalex/arestov_repo (fetch)
PS C:\Users\R\Desktop\arestov_project> git commit -m Program.cs 
[main 7b31131] Program.cs
 1 file changed, 54 insertions(+)
 create mode 100644 Program.cs
PS C:\Users\R\Desktop\arestov_project> git pull
There is no tracking information for the current branch.
Please specify which branch you want to merge with.
See git-pull(1) for details.

    git pull <remote> <branch>
If you wish to set tracking information for this branch you can do so with:

    git branch --set-upstream-to=origin/<branch> main

PS C:\Users\R\Desktop\arestov_project> git push -u origin main
To https://github.com/ruslanalex/arestov_repo
 ! [rejected]        main -> main (non-fast-forward)
hint: Updates were rejected because the tip of your current branch is behind
hint: its remote counterpart. Integrate the remote changes (e.g.
hint: See the 'Note about fast-forwards' in 'git push --help' for details.
PS C:\Users\R\Desktop\arestov_project> git commit -am "добавили блок=схему"
[main 3590b17] добавили блок=схему
 1 file changed, 1 insertion(+)
PS C:\Users\R\Desktop\arestov_project> git pull
remote: Enumerating objects: 4, done.
remote: Counting objects: 100% (4/4), done.
remote: Compressing objects: 100% (3/3), done.
remote: Total 3 (delta 0), reused 0 (delta 0), pack-reused 0
Unpacking objects: 100% (3/3), 1.26 KiB | 19.00 KiB/s, done.
From https://github.com/ruslanalex/arestov_repo
   5e063e2..267be17  main       -> origin/main
There is no tracking information for the current branch.
Please specify which branch you want to merge with.
See git-pull(1) for details.

    git pull <remote> <branch>
If you wish to set tracking information for this branch you can do so with:
    git branch --set-upstream-to=origin/<branch> main

PS C:\Users\R\Desktop\arestov_project> git branch
* main
PS C:\Users\R\Desktop\arestov_project> git push
fatal: The current branch main has no upstream branch.
To push the current branch and set the remote as upstream, use


To have this happen automatically for branches without a tracking
upstream, see 'push.autoSetupRemote' in 'git help config'.

PS C:\Users\R\Desktop\arestov_project> git commit
On branch main
Untracked files:
  (use "git add <file>..." to include in what will be committed)
        "\320\261\320\273\320\276\320\272 \321\201\321\205\320\265\320\274\320\260.drawio"

nothing added to commit but untracked files present (use "git add" to track)
PS C:\Users\R\Desktop\arestov_project> git add "блок схема.drawio"
PS C:\Users\R\Desktop\arestov_project> пше ыефегы
пше : Имя "пше" не распознано как имя командлета, функции, файла сценария или выполняемой программы. Проверь
те правильность написания имени, а также наличие и правильность пути, после чего повторите попытку.
строка:1 знак:1
+ ~~~
    + CategoryInfo          : ObjectNotFound: (пше:String) [], CommandNotFoundException
    + FullyQualifiedErrorId : CommandNotFoundException
 
PS C:\Users\R\Desktop\arestov_project> git status
On branch main
Changes to be committed:
  (use "git restore --staged <file>..." to unstage)
        new file:   "\320\261\320\273\320\276\320\272 \321\201\321\205\320\265\320\274\320\260.drawio"

  (use "git add <file>..." to include in what will be committed)
        arestov_project.csproj
        obj/
PS C:\Users\R\Desktop\arestov_project> git commit -m "Написали решение"
[main 713f6df] Написали решение
 1 file changed, 1 insertion(+)
 create mode 100644 "\320\261\320\273\320\276\320\272 \321\201\321\205\320\265\320\274\320\260.drawio"       
PS C:\Users\R\Desktop\arestov_project> git status
On branch main
Untracked files:
        obj/

nothing added to commit but untracked files present (use "git add" to track)
PS C:\Users\R\Desktop\arestov_project> git add Program.cs
PS C:\Users\R\Desktop\arestov_project> git status
On branch main
Untracked files:
  (use "git add <file>..." to include in what will be committed)
        arestov_project.csproj
        obj/

nothing added to commit but untracked files present (use "git add" to track)
PS C:\Users\R\Desktop\arestov_project>
  
  
  PS C:\Users\R\Desktop\arestov_project> git init
PS C:\Users\R\Desktop\arestov_project> git add Program.cs
PS C:\Users\R\Desktop\arestov_project> git remote add origin https://github.com/ruslanalex/arestov_repo.git
error: remote origin already exists.
PS C:\Users\R\Desktop\arestov_project> git commit -m "добавили программу" 
On branch main
Changes not staged for commit:
  (use "git add <file>..." to update what will be committed)
  (use "git restore <file>..." to discard changes in working directory)
        modified:   README.md

Untracked files:
        obj/

PS C:\Users\R\Desktop\arestov_project> git add Program.cs
* main
repo.git
error: remote origin already exists.
origin
PS C:\Users\R\Desktop\arestov_project> git remote -v
origin  https://github.com/ruslanalex/arestov_repo (fetch)
origin  https://github.com/ruslanalex/arestov_repo (push)
PS C:\Users\R\Desktop\arestov_project> git push -u origin main
To https://github.com/ruslanalex/arestov_repo
 ! [rejected]        main -> main (fetch first)
error: failed to push some refs to 'https://github.com/ruslanalex/arestov_repo'
hint: not have locally. This is usually caused by another repository pushing
hint: to the same ref. You may want to first integrate the remote changes
hint: (e.g., 'git pull ...') before pushing again.
hint: See the 'Note about fast-forwards' in 'git push --help' for details.
PS C:\Users\R\Desktop\arestov_project> git pull
remote: Enumerating objects: 4, done.
remote: Counting objects: 100% (4/4), done.
remote: Compressing objects: 100% (3/3), done.
remote: Total 3 (delta 0), reused 0 (delta 0), pack-reused 0
Unpacking objects: 100% (3/3), 2.14 KiB | 46.00 KiB/s, done.
From https://github.com/ruslanalex/arestov_repo
   267be17..4bdfbb1  main       -> origin/main
There is no tracking information for the current branch.
Please specify which branch you want to merge with.
See git-pull(1) for details.

    git pull <remote> <branch>
If you wish to set tracking information for this branch you can do so with:

    git branch --set-upstream-to=origin/<branch> main

PS C:\Users\R\Desktop\arestov_project> git commit -m "добавили программу"
On branch main
Changes not staged for commit:
  (use "git add <file>..." to update what will be committed)
  (use "git restore <file>..." to discard changes in working directory)
        modified:   README.md

Untracked files:
        arestov_project.csproj
        obj/

no changes added to commit (use "git add" and/or "git commit -a")
PS C:\Users\R\Desktop\arestov_project> git push
fatal: The current branch main has no upstream branch.
To push the current branch and set the remote as upstream, use


To have this happen automatically for branches without a tracking
upstream, see 'push.autoSetupRemote' in 'git help config'.

PS C:\Users\R\Desktop\arestov_project> git push --set-upstream origin main
To https://github.com/ruslanalex/arestov_repo
 ! [rejected]        main -> main (non-fast-forward)
hint: Updates were rejected because the tip of your current branch is behind
hint: 'git pull ...') before pushing again.
hint: See the 'Note about fast-forwards' in 'git push --help' for details.
PS C:\Users\R\Desktop\arestov_project> git pull origin master
fatal: couldn't find remote ref master
PS C:\Users\R\Desktop\arestov_project> git pull git push --set-upstream origin main
fatal: Could not read from remote repository.

Please make sure you have the correct access rights
and the repository exists.
PS C:\Users\R\Desktop\arestov_project> git pull https://github.com/ruslanalex/arestov_repo.git     
From https://github.com/ruslanalex/arestov_repo
 * branch            HEAD       -> FETCH_HEAD
fatal: refusing to merge unrelated histories
PS C:\Users\R\Desktop\arestov_project>
