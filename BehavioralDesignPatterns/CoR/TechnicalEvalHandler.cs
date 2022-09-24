using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.CoR
{
    public class TechnicalEvalHandler : BaseHandler
    {
       void ToNext (JobApplication request) {
            if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(request);
            }
            else
            {
                request.Comments.AppendLine("End by tech handler");
            }
        }
        public override void HandleRequest(JobApplication request)
        {
            #region Handling 1
            //request.Comments.AppendLine("Tech comment");

            //if (_nextHandler != null)
            //{
            //    _nextHandler.HandleRequest(request);
            //}
            //else
            //{
            //    request.Comments.AppendLine("End by tech handler");
            //}
            #endregion

            #region Handling 2
            //if (request.JobCode=="123")
            //{
            //    request.Comments.AppendLine("Tech comment");
            //}
            //else
            //{
            //    if (_nextHandler != null)
            //    {
            //        _nextHandler.HandleRequest(request);
            //    }
            //    else
            //    {
            //        request.Comments.AppendLine("End by tech handler");
            //    }
            //}
            #endregion
            if (request.JobCode == "123")
            {
                request.Comments.AppendLine("Tech comment");
                ToNext(request);
            }
            else
            {
                ToNext(request);
            }
        }
    }
}
