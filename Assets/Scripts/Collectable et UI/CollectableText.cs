using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectableText : MonoBehaviour
{
    private TextMeshProUGUI texteFlocon;
    private int nbrFlocons;

    // Start is called before the first frame update
    void Start()
    {
        nbrFlocons = GameManager.Instance.PlayerData.Flocons;
        texteFlocon = GetComponent<TextMeshProUGUI>();
        texteFlocon.text = nbrFlocons.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
