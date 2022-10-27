//Lerissa Lazar
//10-25-22
//Asking Questions
//This is a webapi that gets inputs and returns a sentence
//peer review: Mauricio Acosta- Functions great returns with my name and time

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LazarL_MiniChAskingQuestEndPoint.Controllers
{
    [Route("[controller]")]
    public class AskQuestionController : Controller
    {
        [HttpGet]
        [Route("Ask/{name}/{time}")]
        public string Ask(string name, string time)
        {
            return $"Their name is {name} and they woke up at {time}";
        }
    }
}