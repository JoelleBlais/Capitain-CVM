using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectableText : MonoBehaviour
{
    private TextMeshProUGUI texteFlocon;

    // Start is called before the first frame update
    void Start()
    {
        texteFlocon = GetComponent<TextMeshProUGUI>();
        texteFlocon.text = GameManager.Instance.PlayerData.Flocons.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
