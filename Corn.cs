using UnityEngine;
public class Corn : MonoBehaviour
{
    public static Corn singleton;
    public int health;

    public int initHealth;

    public int healthPerUpgrade;

    public int crystals;

    private void Awake()
    {
        crystals = PlayerPrefs.GetInt("Crystals", crystals);

        singleton = this;
    }

    public void TakeDamage()
    {
        if(health > 0)
        {
            health--;
        }
    }

    public void AddCrystals(int newCrystals)
    {
        crystals += newCrystals;

        GameController.SaveCrystals();
    }

    public void DecCrystals(int decCrystals)
    {
        crystals -= decCrystals;

        GameController.SaveCrystals();
    }
}
