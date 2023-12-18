using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ToDoList.Entities.Interfaces;

public interface ITaskButton
{
    void SetText(string text);
    event RoutedEventHandler Click;
}
