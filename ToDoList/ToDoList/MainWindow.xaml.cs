using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace ToDoList;


using System.Windows;
using ToDoList.Entities.Classes;
using ToDoList.Entities.Interfaces;

public partial class MainWindow : Window
{
    private ITaskManagerFactory _factory;
    private StackPanel stackPanel;
    public MainWindow()
    {
        InitializeComponent();
        _factory = new ConcreteTaskManagerFactory();

        ITaskTextBox textBox = _factory.CreateTaskTextBox();
        ITaskButton addButton = _factory.CreateTaskButton();

        textBox.SetText(string.Empty);

        addButton.SetText("Add Task");
        addButton.Click += AddTask_Click;

        
    }
    private void InitializeUI()
    {
        stackPanel = new StackPanel();

        ITaskButton addButton = _factory.CreateTaskButton();
        addButton.SetText("Add Task");
        addButton.Click += AddTask_Click;

        

        this.Content = stackPanel;
    }


    private void AddTask_Click(object sender, RoutedEventArgs e)
    {
        string newTask = txtTaskName.Text;

        lstTasks.Items.Add(newTask);

        txtTaskName.Text = string.Empty;
    }


    private void RemoveTask_Click(object sender, RoutedEventArgs e)
    {
        if (lstTasks.SelectedItem != null)
        {
            string selectedTask = lstTasks.SelectedItem.ToString();

            lstTasks.Items.Remove(selectedTask);
        }
    }
}