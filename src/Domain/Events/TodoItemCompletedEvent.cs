﻿using QCheck.Domain.Entities.DoneTable;
using QCheck.Domain.Entities.Tabelneeded;

namespace QCheck.Domain.Events;

public class TodoItemCompletedEvent : BaseEvent
{
    public TodoItemCompletedEvent(TodoItem item)
    {
        Item = item;
    }

    public TodoItem Item { get; }
}
