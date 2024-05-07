using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHP = 1000;
    private int currentHP;

    public Text hpText;

    public Animator animator;

    void Start()
    {
        currentHP = maxHP;
        UpdateUI();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(10);
        }
    }

    public void TakeDamage(int amount)
    {
        currentHP -= amount;
        currentHP = Mathf.Clamp(currentHP, 0, maxHP);
        UpdateUI();

        if (currentHP <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("DEad");
        animator.SetBool("Death", true);
    }

    void UpdateUI()
    {
        hpText.text = "HP: " + currentHP.ToString(); 
    }
}