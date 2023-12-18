using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Entities.Interfaces;

public interface ITaskManagerFactory
{
    ITaskButton CreateTaskButton();
    ITaskTextBox CreateTaskTextBox();
    ITaskListBox CreateTaskListBox();
}