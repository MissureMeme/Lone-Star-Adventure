using UnityEngine.UI;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Health playerHealth;
    [SerializeField] private Image currenthealthBar;
    [SerializeField] private Image totalhealthBar;

    private void Start()
    {
        totalhealthBar.fillAmount = playerHealth.currentHealth / 4;
    }

    private void Update()
    {
        currenthealthBar.fillAmount = playerHealth.currentHealth / 4;
        
    }
}