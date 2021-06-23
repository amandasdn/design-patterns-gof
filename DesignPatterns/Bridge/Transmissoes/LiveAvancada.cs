using Bridge.Plataformas;
using System;

namespace Bridge.Transmissoes
{
    class LiveAvancada : Live
    {
        public LiveAvancada(IPlataforma plataforma) : base(plataforma)
        {

        }

        public void Legenda()
        {
            Console.WriteLine($"[{nameof(LiveAvancada)}] Legendas ativadas.");
        }

        public void Comentarios()
        {
            Console.WriteLine($"[{nameof(LiveAvancada)}] Comentários liberados.");
        }
    }
}
