﻿using QCheck.Domain.Entities.DoneTable;
using QCheck.Domain.Entities.Tabelneeded;

namespace QCheck.Domain.Events;

public class TodoItemDeletedEvent : BaseEvent
{
    public TodoItemDeletedEvent(TodoItem item)
    {
        Item = item;
    }

    public TodoItem Item { get; }
}
