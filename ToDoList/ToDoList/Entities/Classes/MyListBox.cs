using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using ToDoList.Entities.Interfaces;

namespace ToDoList.Entities.Classes;

public class MyTaskListBox : ITaskListBox
{
    private ListBox _listBox = new ListBox();

    public void AddTask(string task)
    {
        _listBox.Items.Add(task);
    }

    public void RemoveTask(string task)
    {
        _listBox.Items.Remove(task);
    }
}
