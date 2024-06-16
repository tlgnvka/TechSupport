﻿using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using HandyControl.Controls;
using HandyControl.Tools.Extension;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Input;
using TechSupport.UI.Models;
using TechSupport.UI.ViewModels.Base;
using TechSupport.UI.Views;

namespace TechSupport.UI.ViewModels;

/// <summary>
/// Меню пользователя на UI
/// </summary>
public class MainViewModel : BaseItemsViewModel<ViewItem>
{
    private readonly IServiceProvider _serviceProvider;

    public override string Title => "Меню методиста";

    public ICommand OpenViewCommand { get; }

    public MainViewModel(ViewItem[] viewItems, IServiceProvider serviceProvider)
    {
        _items.AddRange(viewItems);
        _serviceProvider = serviceProvider;

        OpenViewCommand = new DelegateCommand<ViewItem>(OpenView);
    }

    // Отображение окна, соответствующего выбранному пункту меню
    private void OpenView(ViewItem viewItem)
    {
        IsUploading = true;

        // Скрыть меню пользователя
        var view = _serviceProvider.GetRequiredService(viewItem.ViewType) as Window;
        // Отобразить выбранный пункт меню
        view.ShowDialog();

        IsUploading = false;
    }
}
