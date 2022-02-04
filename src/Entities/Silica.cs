namespace SwordArtOnline.src.Entities
{
    public class Silica : Hero
    {
        public Silica (string Name,int Lavel, string HeroType)
        {
            this.Name=Name;
            this.Lavel=Lavel;
            this.HeroType=HeroType;

        }
      
        public override string Attack()
        {
            return this.Name   + "  Lançou adaga   ";

        }
    public  string Attack(int Bonus)
    {
        if (Bonus>7){

                return this.Name   +   "    Lançou magia Grande dano de longo alcance com bonus de  "  + Bonus; // encapsulamento 
            }else{
                return this.Name   +  "   lançou magia com força fraca com bonus de" + Bonus;
        
    }
        
        
        
        }
    }
}
        
    
