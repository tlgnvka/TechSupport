using System.ComponentModel;

namespace TechSupport.BusinessLogic.Models.UserModels;

public enum UserType
{
    [Description("Методист")]
    Admin,
    [Description("Воспитатель")]
    Employee
}