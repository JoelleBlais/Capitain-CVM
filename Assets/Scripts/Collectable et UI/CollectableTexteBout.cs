using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectableTexteBout : MonoBehaviour
{
    private TextMeshProUGUI texteBout;

    // Start is called before the first frame update
    void Start()
    {
        texteBout = GetComponent<TextMeshProUGUI>();
        texteBout.text = GameManager.Instance.PlayerData.Poison.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
