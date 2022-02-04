namespace SwordArtOnline.src.Entities
{
    public  abstract class Hero
    {
        public Hero (string Name, int Lavel,string HeroType)
        {
            this.Name=Name;
            this.Lavel=Lavel;
            this.HeroType=HeroType;
          

        }
        public string Name;
        public int Lavel;
        public string HeroType;

        public Hero(){

        }
        public virtual string Attack(){
            return this.Name + "Atacou com a sua espada";
        }
        public override string ToString(){
            return this.Name + "  " + this.Lavel + "  " + this.HeroType;
            
        }
          
    }
}