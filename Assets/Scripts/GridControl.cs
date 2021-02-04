using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridControl : MonoBehaviour
{
    private List<PlayerItem> playerInventory;

    [SerializeField] private GameObject[] buttonTemplate;
    [SerializeField] private GridLayoutGroup gridGroup;

    [SerializeField] private Sprite[] iconSprites;
    void Start()
    {
        playerInventory = new List<PlayerItem>();
        
        for (int i = 1; i < 40; i++)
        {
            PlayerItem newItem = new PlayerItem();
            newItem.iconsprite = iconSprites[Random.Range(0, iconSprites.Length)];
            
            playerInventory.Add(newItem);
        }
        
        GenInventory();
    }

    void GenInventory()
    {
        if (playerInventory.Count < 6)
        {
            gridGroup.constraintCount = playerInventory.Count;
        }
        else
        {
            gridGroup.constraintCount = 5;
        }
        
        foreach (PlayerItem newItem in playerInventory)
        {
            int index = Random.Range(0, buttonTemplate.Length);
            //Debug.Log(index);
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
