using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    public static int coinCount = 0;
        

    // Start is called before the first frame update
    void Start()
    {
        coinCount++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") == true)
        {
            coinCount--;
            Debug.Log("Quedan " + coinCount + " monedas por recolectar.");
            Destroy(gameObject);

            if(coinCount == 0)
            {
                Debug.Log("Enhorabuena, has recogido todas las monedas!!");

                GameObject gameManager = GameObject.Find("GameManager");
                Destroy(gameManager);

                GameObject [] fireworksSystem = GameObject.FindGameObjectsWithTag("Fireworks");
                foreach (GameObject firework in fireworksSystem)
                {
                    firework.GetComponent<ParticleSystem>().Play();
                }
            }
        }
    }
}
