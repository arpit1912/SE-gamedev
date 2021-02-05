using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class GridControl : MonoBehaviour
{
    private List<PlayerItem> playerInventory;

    [SerializeField] private GameObject[] buttonTemplate;
    [SerializeField] private GridLayoutGroup gridGroup;
    private Dictionary<string,int> templateCounts;
    private int InventorySize;
    [SerializeField] private Sprite[] iconSprites;
    void Start()
    {
        playerInventory = new List<PlayerItem>();
        templateCounts = new Dictionary<string, int>();
        
        
        InventorySize = 0;
        for (int i = 0; i < buttonTemplate.Length; i++)
        {        
            templateCounts.Add(buttonTemplate[i].name,PlayerPrefs.GetInt(buttonTemplate[i].name));
            //Debug.Log(buttonTemplate[i].name + "  "+ PlayerPrefs.GetInt(buttonTemplate[i].name));
            //Debug.Log(templateCounts[buttonTemplate[i].name]);
            InventorySize += templateCounts[buttonTemplate[i].name];
        }
        
        for (int i = 1; i < InventorySize; i++)
        {
            PlayerItem newItem = new PlayerItem();
            newItem.iconsprite = iconSprites[Random.Range(0, iconSprites.Length)];
            
            playerInventory.Add(newItem);
        }
        
        GenInventory();
    }
    
    void GenInventory()
    {
        if (playerInventory.Count < 8)
        {
            gridGroup.constraintCount = playerInventory.Count;
        }
        else
        {
            gridGroup.constraintCount = 7;
        }
        
        foreach (PlayerItem newItem in playerInventory)
        {
            int index = Random.Range(0, buttonTemplate.Length);
            //Debug.Log(index);
            while (templateCounts[buttonTemplate[index].name] <= 0)
            {
                index++;
                index = index % buttonTemplate.Length;
            }

            templateCounts[buttonTemplate[index].name] = templateCounts[buttonTemplate[index].name] - 1;
            
            GameObject newButton = Instantiate(buttonTemplate[index]) as GameObject;
            newButton.SetActive(true);

            //newButton.GetComponent<Image>().sprite = newItem.iconsprite;
            newButton.transform.SetParent(buttonTemplate[index].transform.parent,false);
        }
        
        
    }
    public class PlayerItem
    {
        public Sprite iconsprite;
    }
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
