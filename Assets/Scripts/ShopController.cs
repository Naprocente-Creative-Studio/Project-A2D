using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopController : MonoBehaviour
{
    [System.Serializable] class ShopItem
    {
        public Sprite image;
        public int price;
        public bool isPurchased = false;
    }

    [SerializeField] List<ShopItem> ShopItemsList;
    GameObject itemTemplate;
    GameObject g;
    public GameObject controller;
    [SerializeField] Transform shopScrollView;
    [SerializeField] Animator noMoneyAnim;
    Button buyBtt;

    public void ShowShopItems()
    {
        itemTemplate = shopScrollView.GetChild(0).gameObject;
        int len = ShopItemsList.Count;

        for (int i = 0; i < len; i++)
        {
            g = Instantiate(itemTemplate, shopScrollView);
            g.transform.GetChild(0).GetComponent<Image>().sprite = ShopItemsList[i].image;
            g.transform.GetChild(2).GetComponent<Text>().text = ShopItemsList[i].price.ToString();
            buyBtt = g.transform.GetChild(3).GetComponent<Button>();
            buyBtt.interactable = !ShopItemsList[i].isPurchased;
            buyBtt.AddEventListener(i, OnShopItemBtnClicked);
        }

        Destroy(itemTemplate);
    }

    void OnShopItemBtnClicked(int itemIndex)
    {
        if (HasEnoughMoney(ShopItemsList[itemIndex].price))
        {
            UseMoney(ShopItemsList[itemIndex].price);

            controller.GetComponent<MainMenuController>().ShowMoney(controller.GetComponent<MainMenuController>().moneyShopTxt);

            ShopItemsList[itemIndex].isPurchased = true;

            shopScrollView.GetChild(itemIndex).GetChild(3).GetComponent<Button>().interactable = false;
        }
        else
        {
            noMoneyAnim.SetTrigger("NoMoney");
            Debug.Log("Not enough Money");
        }
    }

    private bool HasEnoughMoney(int price)
    {
        if (PlayerPrefs.GetInt("Money") >= price) return true;
        else return false;
    }

    private void UseMoney(int price)
    {
        int tmp = PlayerPrefs.GetInt("Money");
        PlayerPrefs.SetInt("Money", tmp - price);
    }
}
