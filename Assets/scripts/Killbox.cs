using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Killbox : MonoBehaviour
{
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
            SceneManager.LoadScene("Loss");
        }
        Destroy(other.gameObject);
    }
}
