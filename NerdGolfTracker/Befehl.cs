namespace NerdGolfTracker
{
    public interface Befehl
    {
        string Kommando { get; }
        string KurzKommando { get; }
        Operation Operation { get; }
        string Erklaerung { get; }
    }
}