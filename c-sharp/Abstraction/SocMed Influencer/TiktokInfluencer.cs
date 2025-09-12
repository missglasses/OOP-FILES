using System;


public class TiktokInfluencer : Influencer {
    public TiktokInfluencer(string name) : base(name, "Tiktok"){}
    
      public override void DoLiveStream(){
         Console.WriteLine("Doing livestream on Tiktok, please send love");
    }
}
