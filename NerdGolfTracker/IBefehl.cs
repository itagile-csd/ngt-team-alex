namespace NerdGolfTracker
{
    public interface IBefehl
    {
        IOperation Operation { get; }
        string Kommando { get; }
        string KurzKommando { get; }
        string Erklaerung { get; }
    }
}