using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralDesignPatterns.CoR
{
    public class HREvalHandler : BaseHandler
    {
         void ToNext(JobApplication request)
        {
            if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(request);
            }
            else
            {
                request.Comments.AppendLine("End by hr handler");
            }
        }
        public override void HandleRequest(JobApplication request)
        {
            #region Handling 1
            //request.Comments.AppendLine("HR comment");

            //if (_nextHandler != null)
            //{
            //    _nextHandler.HandleRequest(request);
            //}
            //else
            //{
            //    request.Comments.AppendLine("End by hr handler");
            //}
            #endregion

            #region Handling 2
            //if (request.JobCode=="456")
            //{
            //    request.Comments.AppendLine("HR comment");
            //}
            //else
            //{
            //    if (_nextHandler != null)
            //    {
            //        _nextHandler.HandleRequest(request);
            //    }
            //    else
            //    {
            //        request.Comments.AppendLine("End by hr handler");
            //    }

            //}
            #endregion

            if (request.JobCode == "456")
            {
                request.Comments.AppendLine("HR comment");
                ToNext(request);              
            }
            else
            {
                ToNext(request);
            }


        }
    }
}
