using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class ExceptionHelper
    {
        private List<Exception> _Exceptions;

        public ExceptionHelper()
        {
            _Exceptions = new List<Exception>();
        }
        public IEnumerator<Exception> GetExceptions() => _Exceptions.GetEnumerator();
        public Exception GetLastException() => _Exceptions.Last();
        public Exception[] GetLastExceptions(int count)
        {
            if (count > _Exceptions.Count) throw new ArgumentOutOfRangeException(nameof(count));
            List<Exception> result = new List<Exception>();
            for (int i = _Exceptions.Count - count; i < _Exceptions.Count; i++)
                result.Add(_Exceptions[i]);
            return result.ToArray();
        }
        public Exception GetException(int index)
        {
            if (index < 0 || index > _Exceptions.Count) throw new ArgumentOutOfRangeException(nameof(index));
            return _Exceptions[index];
        }
        public void OnEception(Exception exception) => _Exceptions.Add(exception);
    }
}
