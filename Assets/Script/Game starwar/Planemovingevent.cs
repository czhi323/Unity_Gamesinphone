using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Planemovingevent : MonoBehaviour {
    public static int score = 100;
    public AudioClip hitsound;
    public GameObject animation;

    AudioSource audioSource;
    // Use this for initialization
    void Start () {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit)  )
            {
                if (hit.transform.gameObject.tag == "Plane")
                {
                    Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
                    var position= Camera.main.ScreenToWorldPoint(mousePosition);
                    if(position.x>-4 && position.x<4 && position.y < 6 && position.y >-6)
                        hit.transform.position = position;
                    Debug.Log("catch"+ " X "+ hit.transform.position.x+" Y "+ hit.transform.position.y);
                }


            }
        
        }
        if (Input.touchCount > 0)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.gameObject.tag == "Plane")
                {
                    Vector3 touchPosition = new Vector3(Input.GetTouch(0).position.x, Input.GetTouch(0).position.y, 10);
                    var position = Camera.main.ScreenToWorldPoint(touchPosition);
                    if (position.x > -4 && position.x < 4 && position.y < 6 && position.y > -6)
                        hit.transform.position = position;
                    Debug.Log("catch" + " X " + hit.transform.position.x + " Y " + hit.transform.position.y);
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }
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
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collision to " + collision.gameObject.tag);
        if (collision.gameObject.tag == "rock")
        {
            score -= 10;
            Destroy(collision.gameObject);
            audioSource.PlayOneShot(hitsound, 1);
            Instantiate(animation, new Vector3(collision.gameObject.transform.position.x, collision.gameObject.transform.position.y, -1), Quaternion.identity);

        }

    }
}
