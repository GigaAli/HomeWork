using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using ToDoList.Entities.Interfaces;

namespace ToDoList.Entities.Classes;

public class MyTaskButton : ITaskButton
{
    private Button _button = new Button();

    public void SetText(string text)
    {
        _button.Content = text;
    }

    public event RoutedEventHandler Click
    {
        add { _button.Click += value; }
        remove { _button.Click -= value; }
    }
}
