using System.Collections;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject[] enemies; 
    public GameObject[] lifeImages; 

    private int remainingEnemies;
    private int remainingLives;

    public GameObject teleportPad;
    public GameObject panel1;
    public GameObject panel2;

    void Start()
    {
        remainingEnemies = enemies.Length;
        remainingLives = lifeImages.Length;
        
        if (panel1 != null)
        {
            panel1.SetActive(true);
            StartCoroutine(HidePanelAfterDelay(4f));
        }
    }

    IEnumerator HidePanelAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        panel1.SetActive(false);
    }
    
    IEnumerator HidePanelAfterDelay2(float delay)
    {
        yield return new WaitForSeconds(delay);
        panel2.SetActive(false);
    }
    
    public void KillEnemy(GameObject enemy)
    {
        enemy.SetActive(false);
        remainingEnemies--;

        Debug.Log("Remaining enemies: " + remainingEnemies);
        
        if (remainingEnemies % 2 == 0 && remainingLives > 0)
        {
            HideLifeImage();
        }
    }

    private void HideLifeImage()
    {
        remainingLives--;

        if (remainingLives >= 0 && remainingLives < lifeImages.Length)
        {
            lifeImages[remainingLives].SetActive(false);
            Debug.Log("Hiding life image. Remaining lives: " + remainingLives);
        }

        if (remainingLives == 0)
        {
            teleportPad.SetActive(true);
            panel2.SetActive(true);
            StartCoroutine(HidePanelAfterDelay2(4f));
        }
    }
}