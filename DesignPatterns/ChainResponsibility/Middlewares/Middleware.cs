using System;

namespace ChainResponsibility.Middlewares
{
    abstract class Middleware
    {
        private Middleware _next;

        public Middleware LinkWith(Middleware next)
        {
            _next = next;

            return next;
        }

        public abstract Boolean Check(string email, string senha);

        protected Boolean CheckNext(string email, string senha)
        {
            if (_next == null)
            {
                return true;
            }

            return _next.Check(email, senha);
        }
    }
}
