using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Entities.Interfaces;

public interface ITaskTextBox
{
    string GetText();
    void SetText(string text);
}