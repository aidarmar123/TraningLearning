using System;
using TraningLayouts.Models;

namespace TraningLayouts.ViewModels;

public partial class HomeViewModel : ViewModelBase
{
    public StatCard[] Stats { get; } =
    [
        new("Проекты", 12, "Активных проектов"),
        new("Задачи", 48, "В работе"),
        new("Команда", 8, "Участников"),
        new("Сроки", 5, "Просрочено", Alert: true),
    ];

    public ProjectItem[] Projects => Data.Projects;
    public TaskItem[] Tasks => Data.Tasks;
    public DateTime Today { get; } = DateTime.Today;
}
