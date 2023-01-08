using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ItemCollector : MonoBehaviour
{
    private int Bones = 0;

    [SerializeField] private Text bonesText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bone"))
        {
            Destroy(collision.gameObject);
            Bones++;
            bonesText.text = "Bones " + Bones;
        }
        
        if (Bones == 10)
        {
            SceneManager.LoadScene("Victory");
        }
    }
}
