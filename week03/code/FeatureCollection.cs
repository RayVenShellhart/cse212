using System.ComponentModel;

public class FeatureCollection
{
    // TODO Problem 5 - ADD YOUR CODE HERE
    // Create additional classes as necessary
    public List<Features> features { get; set; }

}

public class Features
{
    public Properties properties { get; set; }
}

public class Properties
{
    public double Mag { get; set; }
    public string Place { get; set; }   
    
}