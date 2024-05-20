using UnityEngine;
using UnityEngine.UI;

public class ClickButtons : MonoBehaviour
{
    public Button button;
    public GameObject enemy;
    private EnemyManager enemyManager;

    void Start()
    {
        if (button == null || enemy == null)
        {
            Debug.LogError("Button or Enemy reference is missing.");
            return;
        }

        enemyManager = FindObjectOfType<EnemyManager>();

        if (enemyManager == null)
        {
            Debug.LogError("EnemyManager not found in the scene.");
            return;
        }

        button.onClick.AddListener(() => KillEnemy());
    }

    void KillEnemy()
    {
        if (enemy != null && enemyManager != null)
        {
            enemyManager.KillEnemy(enemy);
        }
    }
}