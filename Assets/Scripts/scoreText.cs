using UnityEngine;
using TMPro;
public class scoreText : MonoBehaviour
{
    public Transform player;
    public Transform startObject;
    public Transform finishObject;
    public TMP_Text sText;

    int score = 0;
    int distancetoFinish;
    // Update is called once per frame
    void Update()
    {
        //υπολογισμός σκορ με βάση την απόσταση που έχει διανύσει ο παίκτης
        score = Mathf.FloorToInt(player.transform.position.z - startObject.transform.position.z);
        sText.text = "Score: " + score.ToString() + "\nDistance to Finish: " + distancetoFinish.ToString();
        //υπολογισμός απόστασης μέχρι το τέρμα
        distancetoFinish = Mathf.FloorToInt(finishObject.transform.position.z - player.transform.position.z);
        //ο παίκτης έφτασε στο τέρμα, διαχείριση από τον gameManager
       // if (distancetoFinish <= 0) EndLevel();

    }
}
