using System;


public class FacebookInfluencer : Influencer {
    public FacebookInfluencer (string name) : base(name, "Facebook"){}
    
     public override void DoLiveStream(){
        Console.WriteLine("Doing livestream on Facebook, please send stars");
    }
}
