using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class moveScene : MonoBehaviour
{
    public GameObject load;
    public GameObject score;
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        load.SetActive(false);
    }


    public void OnMouseDown()
    {
        Debug.Log("move");
        StartCoroutine("move");
        //SceneManager.LoadScene(sceneName);
    }

    IEnumerator move()
    {
        if (score!=null){
        score.SetActive(false);
        }
        load.SetActive(true);
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene(sceneName);
    }
}
