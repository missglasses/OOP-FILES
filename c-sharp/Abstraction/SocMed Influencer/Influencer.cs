using System;

public abstract class Influencer{
    private string name;
    private string platform;
    
    public Influencer(string name, string platform){
        this.name=name;
        this.platform=platform;
    }
    
    public override string ToString(){
        return $"Superclass:\nName: {name}\nPlatform {platform}";
    }
    
    public abstract void DoLiveStream();
    
}
