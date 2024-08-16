using System.Collections.Generic;

namespace BeautifulToDoList.Models.ViewModels
{
    public class TodoViewModel
    {
            /*
                serves as a model specifically designed to
                 pass data between the controller and the view
            */
        public List<TodoItem> TodoList { get; set; }
        public TodoItem Todo { get; set; }
    }
}