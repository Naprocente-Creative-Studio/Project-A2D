using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopController : MonoBehaviour
{
    [System.Serializable] class ShopItem
    {
        public int name;
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
    Button buyBtt, selBtt;

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
            selBtt = g.transform.GetChild(4).GetComponent<Button>();
            buyBtt.interactable = !intToBool(PlayerPrefs.GetInt(ShopItemsList[i].name.ToString()));
            buyBtt.AddEventListener(i, OnShopItemBtnClicked);
            selBtt.AddEventListener(i, OnSelectItemBtnClicked);
            if (intToBool(PlayerPrefs.GetInt(ShopItemsList[i].name.ToString())) || ShopItemsList[i].isPurchased)
            {
                ShopItemsList[i].isPurchased = true;
                selBtt.gameObject.SetActive(true);
            }
            if (ShopItemsList[i].name == PlayerPrefs.GetInt("ShipIndex"))
            {
                buyBtt.gameObject.SetActive(false);
                selBtt.gameObject.SetActive(true);
                selBtt.interactable = false;
            }
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

            PlayerPrefs.SetInt(ShopItemsList[itemIndex].name.ToString(), boolToInt(ShopItemsList[itemIndex].isPurchased));

            shopScrollView.GetChild(itemIndex).GetChild(3).GetComponent<Button>().interactable = false;
            shopScrollView.GetChild(itemIndex).GetChild(4).gameObject.SetActive(true);
        }
        else
        {
            noMoneyAnim.SetTrigger("NoMoney");
            Debug.Log("Not enough Money");
        }
    }

    void OnSelectItemBtnClicked(int itemIndex)
    {
        if (ShopItemsList[itemIndex].isPurchased)
        {
            shopScrollView.GetChild(PlayerPrefs.GetInt("ShipIndex")).GetChild(3).gameObject.SetActive(true);
            shopScrollView.GetChild(PlayerPrefs.GetInt("ShipIndex")).GetChild(4).GetComponent<Button>().interactable = true;
            shopScrollView.GetChild(itemIndex).GetChild(4).GetComponent<Button>().interactable = false;
            shopScrollView.GetChild(itemIndex).GetChild(3).gameObject.SetActive(false);
            PlayerPrefs.SetInt("ShipIndex", ShopItemsList[itemIndex].name);
        }
        else Debug.Log("Can`t Select");
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

    bool intToBool(int var)
    {
        if (var == 1) return true;
        else return false;
    }

    int boolToInt(bool var)
    {
        if (var) return 1;
        else return 0;
    }
}
