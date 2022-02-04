namespace SwordArtOnline.src.Entities
{
    public class Spiegel : Hero
    {
        public Spiegel (string Name,int Lavel, string HeroType)
        {
            this.Name=Name;
            this.Lavel=Lavel;
            this.HeroType=HeroType;

        }
      
        public override string Attack()
        {
            return this.Name   + "  Disparou com metraladora    ";

        }
    public  string Attack(int Bonus)
    {
        if (Bonus>7){

                return this.Name +   "   atingir vários inimigos simultaneamente em linha reta com bonus de  "  + Bonus; // encapsulamento 
            }else{
                return this.Name +  "   atacou com força fraca com bonus de" + Bonus; 
        
    }
        
        
        
        }
    }
}