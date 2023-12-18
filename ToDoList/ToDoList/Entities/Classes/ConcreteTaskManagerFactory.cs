using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Entities.Interfaces;

namespace ToDoList.Entities.Classes;

public class ConcreteTaskManagerFactory : ITaskManagerFactory
{
    public ITaskButton CreateTaskButton()
    {
        return new MyTaskButton();
    }

    public ITaskTextBox CreateTaskTextBox()
    {
        return new MyTaskTextBox();
    }

    public ITaskListBox CreateTaskListBox()
    {
        return new MyTaskListBox();
    }
}