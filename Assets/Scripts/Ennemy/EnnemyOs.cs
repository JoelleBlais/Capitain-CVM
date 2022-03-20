using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyOs : MonoBehaviour
{
    [SerializeField]
    private float damage;

    [SerializeField]
    private float dieTime;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountDownTimer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            /*
            PlayerBehaviour pb = collision.gameObject.GetComponent<PlayerBehaviour>();
            if (pb != null)
                pb.CallEnnemyCollision();
                */
            GameManager.Instance.PlayerData.DecrEnergie();
            Destroy(gameObject);
        }
        if (collision.gameObject.tag.Equals("Tilemap"))
        {
            Destroy(gameObject);
        }
    }
    
    

    IEnumerator CountDownTimer()
    {
        yield return new WaitForSeconds(dieTime);

        Destroy(gameObject);
    }
}
