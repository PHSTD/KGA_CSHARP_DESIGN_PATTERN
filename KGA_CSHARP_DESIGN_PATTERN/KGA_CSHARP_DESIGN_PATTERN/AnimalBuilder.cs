namespace KGA_CSHARP_DESIGN_PATTERN;

public class AnimalBuilder
{
    private string name;
    private string rank;
    private string sound;
    private string eatName;
    private string products;

    public AnimalBuilder(){

    }

    public AnimalBuilder(string name, string eatName)
    {
        this.name = name;
        // rank = "일반";
        // sound = "꼬끼오";
        this.eatName = eatName;
        // products = "알";
    }
    
    public Animal Build()
    {
        Animal animal = new Animal();
        switch (name)
        {
            case "닭":
                if(eatName == "일반사료")
                {
                    animal.name = "닭";
                    animal.rank = "일반";
                    animal.products = "알";
                    animal.eatName = eatName;
                    animal.sound = "꼬끼오";
                }
                else if(eatName == "황금사료")
                {
                    animal.name = "황금닭";
                    animal.rank = "전설";
                    animal.products = "황금알";
                    animal.eatName = eatName;
                    animal.sound = "꼬~끼~오~~";
                }
                break;
        }

        return animal;
    }

    public AnimalBuilder SetName(string name)
    {
        this.name = name;
        return this;
    }

    public AnimalBuilder SetEatName(string eatName)
    {
        this.eatName = eatName;
        return this;
    }


    public class Animal
    {
        public string name;
        public string rank;
        public string sound;
        public string eatName;
        public string products;
    }
}
