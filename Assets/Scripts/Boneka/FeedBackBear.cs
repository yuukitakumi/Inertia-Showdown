using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FeedBackBear : MonoBehaviour
{
    public GameObject feedback;
    public string scene;
    bool selesai = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void cek()
    {
        for (int i = 0; i < 5; i++)
        {
            if (transform.GetChild(i).GetComponent<DragBear>().on_tempel)
            {
                selesai = true;
            }
            else
            {
                selesai = false;
                i = 5;
            }
        }
        if (selesai)
        {
            SceneManager.LoadScene(scene);

        }

    }

    // Update is called once per frame
    void Update()
    {
        if (!selesai)
        {
            cek();
        }
    }
}
