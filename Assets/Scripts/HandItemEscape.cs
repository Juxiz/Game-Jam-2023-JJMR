using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public enum Item {nothing, tomato, hay, cookie, coffee, pizza, muffin, flower}
public static class HandItemEscape
{
    public static int ItemToNumber(Item item)
    {
        return (int)item;
    }
    public static Item IntToItem(int i) {
        return (Item)i;
    }
    public static void SaveItem(Item item)
    {
        PlayerPrefs.SetInt("item", ItemToNumber(item));
    }
    public static Item LoadItem() {
        return IntToItem(PlayerPrefs.GetInt("item"));
    }
    public static void Clearitem()
    {
        SaveItem(Item.nothing);
    }
}

public class hand
{
    public Item heldItem = Item.nothing;

    public void Save()
    {
        HandItemEscape.SaveItem(heldItem);
    }
}