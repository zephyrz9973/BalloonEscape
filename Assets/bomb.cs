using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bomb : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.Find("boom").gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision) {
    	if (collision.gameObject.CompareTag("Player")) {
    		gameObject.transform.Find("boom").gameObject.SetActive(true);
    		StartCoroutine(ExecuteAfterTime(1));
    	}

    }

    IEnumerator ExecuteAfterTime(float time)
     {
         yield return new WaitForSeconds(time);
     
         GameObject.Find("character_balloon").SetActive(false);
    	 gameObject.SetActive(false);
    	 SceneManager.LoadScene(5);


     }
}
