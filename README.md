# Requete API

[![Main](https://github.com/umbrik/requete/actions/workflows/main.yml/badge.svg)](https://github.com/umbrik/requete/actions/workflows/main.yml)

## Описание

Requete - это веб-API приложение на ASP.NET Core 10.0, предназначенное для управления системой обучения. Проект предоставляет REST API для работы с курсами, пользователями, сессиями обучения и связанными данными.

## Технологии

- **Платформа**: .NET 10.0
- **Фреймворк**: ASP.NET Core
- **Базы данных**: Microsoft SQL Server, PostgreSQL
- **Кэширование**: Redis
- **ORM**: Entity Framework Core 10.0
- **Документация API**: OpenAPI (Swagger) с Scalar UI

## Основные компоненты

### Контроллеры API
- `CoursesController` - Управление курсами
- `LearningsController` - Управление процессом обучения
- `UsersController` - Управление пользователями
- `SessionController` - Управление сессиями
- `DefaultController` - Базовый контроллер

### Сервисы
- `CourseService` - Сервис для работы с курсами
- `LearningService` - Сервис для работы с обучением
- `UserService` - Сервис для работы с пользователями
- `RedisSessionService` - Сервис для управления сессиями через Redis

### Модели данных
Проект содержит обширную модель данных HCM (Human Capital Management) включающую:
- Управление пользователями и аккаунтами
- Системы обучения и курсов
- Управление оценками и сертификатами
- Календарные события и уведомления
- Блоги и статьи
- И многое другое

## Требования

- .NET 10.0 SDK
- SQL Server или PostgreSQL
- Redis (для кэширования и сессий)

## Установка и запуск

1. **Клонирование репозитория**
   ```bash
   git clone <repository-url>
   cd requete
   ```

2. **Настройка конфигурации**

   Отредактируйте `appsettings.json` и `appsettings.Development.json`:
   ```json
   {
     "Database": {
       "Provider": "SqlServer" // или "PostgreSQL"
     },
     "ConnectionStrings": {
       "DefaultConnection": "ваша_строка_подключения_sql_server",
       "PostgresConnection": "ваша_строка_подключения_postgres"
     }
   }
   ```

3. **Установка зависимостей**
   ```bash
   dotnet restore
   ```

4. **Применение миграций базы данных**
   ```bash
   dotnet ef database update
   ```

5. **Запуск приложения**
   ```bash
   dotnet run
   ```

## Конфигурация

### Поддерживаемые базы данных

Приложение поддерживает:
- **SQL Server** (по умолчанию)
- **PostgreSQL**

Выбор осуществляется через параметр `Database:Provider` в конфигурации.

### Redis

Redis используется для:
- Кэширования данных
- Управления пользовательскими сессиями

### Middleware

- `SessionAuthenticationMiddleware` - Middleware для аутентификации сессий

## API Документация

После запуска приложения документация API доступна по адресу:
- Scalar UI: `http://localhost:5000/scalar/v1`
- OpenAPI JSON: `http://localhost:5000/openapi/v1.json`

## Разработка

### Структура проекта

```
├── Controllers/          # API контроллеры
│   ├── Base/            # Базовые контроллеры
├── Data/                # Контексты Entity Framework
├── DTOs/                # Объекты передачи данных
│   └── Responses/       # DTO для ответов API
├── Extensions/          # Расширения для DI
├── Middleware/          # Пользовательские middleware
├── Models/              # Модели данных
│   └── HCM/            # Модели HCM системы
├── Services/            # Бизнес-логика
└── Resources/           # Ресурсы локализации
```

### Команды разработки

- **Форматирование кода**: `dotnet format`
- **Сборка проекта**: `dotnet build`

## Лицензия

Apache License 2.0