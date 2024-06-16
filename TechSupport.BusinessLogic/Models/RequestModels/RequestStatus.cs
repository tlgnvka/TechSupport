using System.ComponentModel;

namespace TechSupport.BusinessLogic.Models.RequestModels;

public enum RequestStatus
{
    [Description("Создано")]
    Created,
    [Description("Принято")]
    InProgress,
    [Description("В работе")]
    Paused,
    [Description("Завершено")]
    Completed
}