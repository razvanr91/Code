namespace Packt.Shared;

public interface IPlayable
{
    void Play();

    void Pause();

    void Stop()
    {
        System.Console.WriteLine("Default implementation of Stop.");
    }
}