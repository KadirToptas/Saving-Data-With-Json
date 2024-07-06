[System.Serializable]

public class CharacterData
{
    public string Name = "";

    public string Element = "";

    public float Damage = 25;

    public float Health = 100;



    public CharacterData()
    {
        
    }


    public CharacterData(string name, string element, float damage, float health)
    {
        Name = name;
        Element = element;
        Damage = damage;
        Health = health;

    }
}

