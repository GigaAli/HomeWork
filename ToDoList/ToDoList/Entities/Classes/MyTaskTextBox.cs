using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using ToDoList.Entities.Interfaces;

namespace ToDoList.Entities.Classes;

public class MyTaskTextBox : ITaskTextBox
{
    private TextBox _textBox = new TextBox();

    public string GetText()
    {
        return _textBox.Text;
    }

    public void SetText(string text)
    {
        _textBox.Text = text;
    }
}
