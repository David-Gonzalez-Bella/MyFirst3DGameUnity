using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    public float maxTime = 90.0f; //La pongo publica por si la queremos cambiar en el interfaz

    private float countdown = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        countdown = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        Debug.Log(countdown);

        if (countdown <= 0.0f)
        {
            Debug.Log("Fin del tiempo!!");

            Coin.coinCount = 0;
            SceneManager.LoadScene("SampleScene"); // ó SceneManager.LoadScene(0);, para ver las sobrecargas dale, con el cursor dentro del parentresis, a "Ctrl + Shft + Espacio"

        }
    }
}
