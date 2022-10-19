using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeStart;
    public Text textBox;
    Player playerScript;
    
    // Start is called before the first frame update
    void Start()
    {
        textBox.text = timeStart.ToString("F2");
        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerScript.health > 0) {
            timeStart += Time.deltaTime;
            textBox.text = timeStart.ToString("F2");
        }
    }
}
