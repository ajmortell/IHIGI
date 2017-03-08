using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ItemList<MailItem>
{

    MailItem[] items = new MailItem[1];
    int count;

    public void Add(MailItem item)
    {
        if (count == items.Length)
            Array.Resize(ref items, items.Length * 2);
        items[count++] = item;
    }

    public IEnumerable<MailItem> GetEnumerator()
    {
        for (int i = 0; i < count; i++)
            yield return items[i];
    }
}
