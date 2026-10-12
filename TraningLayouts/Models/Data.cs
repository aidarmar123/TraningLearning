using System;
using Avalonia.Media;

namespace TraningLayouts.Models;

// Полупрозрачный фон тега одинаково смотрится в светлой и тёмной теме
public record Tag(string Name, IBrush Background, IBrush Foreground)
{
    public static readonly Tag Design = new("Дизайн", Brush.Parse("#305b3fd1"), Brush.Parse("#7b61ff"));
    public static readonly Tag Dev = new("Разработка", Brush.Parse("#303b6fd8"), Brush.Parse("#4f8ef7"));
    public static readonly Tag Marketing = new("Маркетинг", Brush.Parse("#302e9b4a"), Brush.Parse("#3fb860"));
}

public record StatCard(string Title, int Value, string Caption, bool Alert = false);

public record ProjectItem(string Name, Tag Tag, int Progress, IBrush Accent);

public record TaskItem(string Title, Tag Tag, DateTime Date);

// Данные приложения без базы данных
public static class Data
{
    public static readonly ProjectItem[] Projects =
    [
        new("Avalonia UI Redesign", Tag.Design, 65, Brush.Parse("#5b3fd1")),
        new("Мобильное приложение", Tag.Dev, 40, Brush.Parse("#3b6fd8")),
        new("Корпоративный сайт", Tag.Dev, 80, Brush.Parse("#2e9b4a")),
    ];

    public static readonly TaskItem[] Tasks =
    [
        new("Разработать макет главной страницы", Tag.Design, new DateTime(2024, 5, 15)),
        new("Реализовать авторизацию", Tag.Dev, new DateTime(2024, 5, 14)),
        new("Подготовить презентацию", Tag.Marketing, new DateTime(2024, 5, 13)),
    ];
}
