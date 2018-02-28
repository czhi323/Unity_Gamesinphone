using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Touchevent : MonoBehaviour {
    Vector3 newPosition;
    private int score = 0;

    public GameObject animation;
    public AudioClip hitsound;
    AudioSource audioSource;
    // Use this for initialization
    void Start () {
        Debug.Log("touchevent start");
        newPosition = transform.position;

        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update () {
        if (Input.touchCount > 0)
        {
            Debug.Log(Input.GetTouch(0).rawPosition.x+" "+ Input.GetTouch(0).rawPosition.y);
            Vector3 pz = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            pz.z = 0;
            gameObject.transform.position = pz;
        }
        
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pz = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            pz.z = -5;
            gameObject.transform.position = pz;
            Debug.Log("X:" + pz.x + " Y:" + pz.y);
            Instantiate(animation, new Vector3(gameObject.transform.position.x+ (float)0.3, gameObject.transform.position.y+(float)1, -1), Quaternion.identity);
            audioSource.PlayOneShot(hitsound, 1);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "animal")
        {
            Destroy(collision.gameObject);
            score += 10;          
        }
        Debug.Log("collision to " + collision.gameObject.tag);
    }

    public Texture2D scoreTexture;
    private void OnGUI()
    {
        GUIStyle guiStyle = new GUIStyle();
        guiStyle.fontSize = 40;
        guiStyle.normal.textColor = Color.white;
        Rect rect_scoretexture = new Rect(20, 10, 300, 150);
        Rect rect_score = new Rect(180, 80, 200, 100);
        GUI.DrawTexture(rect_scoretexture, scoreTexture);
        GUI.Label(rect_score, score.ToString(), guiStyle);
    }

}
