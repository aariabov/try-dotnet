Не работает Console.ReadLine()
Не понятно, как работает
Позволяет клиенту писать и исполнять C# код в браузере.

1. установить dotnet try. Можно следовать инструкции https://github.com/dotnet/try/blob/main/DotNetTryLocal.md
```
dotnet tool update -g Microsoft.dotnet-try
```
2. Запустить
```
dotnet try
```

Кусок кода, который написал клиент, отправляется на сервак, и там выполняется метод `Main`