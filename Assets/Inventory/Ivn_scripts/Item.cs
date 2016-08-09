using UnityEngine;
using System.Collections;
using System;

public enum ItemType {MAP,FLASHLIGHT};

public class Item : MonoBehaviour {
    public ItemType type;
    public Sprite spriteNeutral;
    public Sprite spriteHighlighted;
    public int maxSize;

    public void use()
    {
        switch(type)
        {
            case ItemType.MAP:
                Debug.Log("I just used a mana potion");
                break;
            case ItemType.FLASHLIGHT:
                Debug.Log("I just used a health potion");
                break;
        }
    }
   

}
