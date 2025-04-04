namespace KGA_CSHARP_DESIGN_PATTERN;

public class WeaponFactory
{
    public string name;
    public float power;
    public float range;
    public string rank;
    public float rate;

    public WeaponFactory Create(string name, string rank = "NORMAL")
    {
        WeaponFactory weaponFactory;

        switch (name)
        {
            case "철검":
                weaponFactory = new WeaponFactory("철검", 15.0f, 30.0f);
                break;
            case "나무창":
                weaponFactory = new WeaponFactory("나무창", 5.0f, 50.0f);
                break;
            case "쇠도끼":
                weaponFactory = new WeaponFactory("쇠도끼", 20.0f, 20.0f);
                break;
            default:
                return null;
        }
        
        switch (rank)
        {
            case "RARE":
                weaponFactory.power = (int)weaponFactory.power * 1.0f ;
                break;
            case "LEGENDARY": 
                weaponFactory.power = (int)weaponFactory.power * 1.1f;
                break;
            default:
                weaponFactory.power = (int)weaponFactory.power * 1.2f;
                break;
        }

        return weaponFactory;
    }
    
    public WeaponFactory(){
        
    }

    public WeaponFactory(string name, float power, float range)
    {
        this.name = name;
        this.power = power;
        this.range = range;
    }
}