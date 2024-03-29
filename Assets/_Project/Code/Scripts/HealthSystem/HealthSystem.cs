using UnityEngine;

public class HealthSystem : MonoBehaviour
{
  [Header("Config")]
  [SerializeField] int maxHealth = 100;
  [SerializeField] private EventChannel healthChannel;

  public bool IsDead => Health <= 0;

  public int Health { get; private set; }

  private void Awake()
  {
    Health = maxHealth;
  }

  public void TakeDamage(int damage)
  {
    Health = Mathf.Max(0, Health - damage);
    healthChannel?.Invoke(default);
  }

  public void Heal(int amount)
  {
    Health = Mathf.Min(maxHealth, Health + amount);
  }

  public void SetHealth(int health)
  {
    Health = Mathf.Clamp(health, 0, maxHealth);
  }
}
