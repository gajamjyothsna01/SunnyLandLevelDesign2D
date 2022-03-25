using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyScript : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {/*if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            GameObject.Find("ScoreManager").GetComponent<ScoreManagerScript>().Score(10);

        }
        

    }*/
        
      /*  if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            GameObject.Find("ScoreManager").GetComponent<ScoreManagerScript>().Score(10);

        }*/

    }
}
