using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FeedbackZirah : MonoBehaviour
{
    public GameObject feedback;
    bool selesai = false;
    public string scene;
    // Start is called before the first frame update

    public void cek()
    {
        for (int i = 0; i < 6; i++)
        {
            if (transform.GetChild(i).GetComponent<DragZirah>().on_tempel)
            {
                selesai = true;
            }
            else
            {
                selesai = false;
                i = 6;
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