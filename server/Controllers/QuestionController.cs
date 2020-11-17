using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using server.Models;

namespace server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuestionController : Controller
    {
        private static ConcurrentBag<Question> Questions = new ConcurrentBag<Question>
        {
            new Question
            {
                Id = Guid.Parse("b00c58c0-df00-49ac-ae85-0a135f75e01b"),
                Title = "Welcome",
                Body = "Welcome to the _mini Stack Overflow_ rip-off!\nThis will help showcasing **SignalR** and its integration with **Vue**",
                PostedOn = DateTime.Now,
                Answers = new List<Answer>{ new Answer { Body = "Sample answer" }}
            }
        };

        [HttpGet]
        public IEnumerable GetQuestions()
        {
            return Questions.Select(q => new
            {
                Id = q.Id,
                Title = q.Title,
                Body = q.Body,
                Score = q.Score,
                PostedOn = q.PostedOn,
                Answers = q.Answers
            });
        }

        [HttpGet("{id}")]
        public ActionResult GetQuestion(Guid id)
        {
            var question = Questions.SingleOrDefault(x => x.Id == id);
            if (question == null) return NotFound();

            return new JsonResult(question);
        }
        
        [HttpPost]
        public Question AddQuestion([FromBody] Question question)
        {
            question.Id = Guid.NewGuid();
            question.Answers = new List<Answer>();
            Questions.Add(question);

            return question;
        }

        [HttpPost("{id}/answer")]
        public ActionResult AddAnswerAsync(Guid id, [FromBody] Answer answer)
        {
            var question = Questions.SingleOrDefault(x => x.Id == id);
            if (question == null) return NotFound();

            answer.Id = Guid.NewGuid();
            answer.QuestionId = question.Id;
            question.Answers.Add(answer);

            return new JsonResult(answer);
        }

        [HttpPatch("{id}/upvote")]
        public ActionResult UpVoteQuestionAsync(Guid id)
        {
            var question = Questions.SingleOrDefault(x => x.Id == id);
            if (question == null) return NotFound();

            question.Score++;
            return new JsonResult(question);
        }
    }
}
