using HandyControl.Controls;
using HandyControl.Tools.Command;
using System.Collections.Generic;
using System.IO;
using System.Windows.Markup;
using TechSupport.UI.ViewModels;
using System.Windows.Input;
using System.Diagnostics;
using System.Text;
using TechSupport.BusinessLogic.Interfaces;


namespace TechSupport.UI.Views;

public partial class RequestsView : Window
{
    public RequestsView(RequestsViewModel context)
    {
        InitializeComponent();
        DataContext = context;
    }
}


