namespace NerdGolfTracker
{
    public interface IBefehl
    {
        string Kommando { get; }
        string KurzKommando { get; }
        Operation Operation { get; }
        string Erklaerung { get; }
    }
}