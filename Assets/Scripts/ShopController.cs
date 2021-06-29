using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopController : MonoBehaviour
{
    GameObject itemTemplate;
    GameObject g;
    [SerializeField] Transform shopScrollView;

    public void ShowShopItems()
    {
        itemTemplate = shopScrollView.GetChild(0).gameObject;

        for (int i = 0; i <= 10; i++)
        {
            g = Instantiate(itemTemplate, shopScrollView);
        }

        Destroy(itemTemplate);
    }
}
