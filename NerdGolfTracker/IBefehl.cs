namespace NerdGolfTracker
{
    public interface IBefehl
    {
        string Kommando { get; }
        string KurzKommando { get; }
        IOperation Operation { get; }
        string Erklaerung { get; }
    }
}