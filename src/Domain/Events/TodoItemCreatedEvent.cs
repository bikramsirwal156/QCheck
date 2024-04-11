using QCheck.Domain.Entities.DoneTable;
using QCheck.Domain.Entities.Tabelneeded;

namespace QCheck.Domain.Events;

public class TodoItemCreatedEvent : BaseEvent
{
    public TodoItemCreatedEvent(TodoItem item)
    {
        Item = item;
    }

    public TodoItem Item { get; }
}
