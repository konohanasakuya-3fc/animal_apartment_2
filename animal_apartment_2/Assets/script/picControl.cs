using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class picControl : MonoBehaviour
{
    public GameObject loading; 
    public GameObject score; 
    public SpriteRenderer control;
    public Sprite pointOn;
    public Sprite pointOff;
    // Start is called before the first frame update
    void Start()
    {
        control = gameObject.GetComponent<SpriteRenderer>();
        loading.SetActive(false);
        if (score!=null){
        score.SetActive(true);
        } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //カーソルが触れているときに実行
    public void OnMouseOver()
    {
        control.sprite = pointOn;
    }

    //カーソルが離れているときに実行
    public void OnMouseExit()
    {
        control.sprite = pointOff;
    }
}
