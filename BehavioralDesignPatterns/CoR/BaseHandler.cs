using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.CoR
{
   public abstract class BaseHandler
    {
        protected BaseHandler _nextHandler;
        public void SetNext(BaseHandler handler)
        {
            _nextHandler = handler;
        }
        public abstract void HandleRequest(JobApplication request);
    }
}
