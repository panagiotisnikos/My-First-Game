using UnityEngine;

public class gameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void EndGame()
    {
        Debug.Log("Level Completed!");
        //Εδώ μπορούμε να προσθέσουμε κώδικα για να διαχειριστούμε το τέλος του επιπέδου,
        //όπως να εμφανίσουμε ένα μήνυμα, να σταματήσουμε την κίνηση του παίκτη κλπ.
    }
    public void EndLevel()
    {
        Scene scene = SceneManager.GetActiveScene();
        
        Debug.Log("You completed the level: " + scene.name);

        SceneManager.LoadScene(scene.name);
        //Εδώ μπορούμε να προσθέσουμε κώδικα για να διαχειριστούμε το τέλος του επιπέδου,
        //όπως να εμφανίσουμε ένα μήνυμα, να σταματήσουμε την κίνηση του παίκτη κλπ.
    }
}
