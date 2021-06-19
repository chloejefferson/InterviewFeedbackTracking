using InterviewFeedbackTracking.Data;
using InterviewFeedbackTracking.Models.Interview;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewFeedbackTracking.Services
{
    public class InterviewService
    {
        private readonly Guid _userId;

        public InterviewService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateNewInterview(InterviewCreate interview)
        {
            var entity = new Interview()
            {
                //interview ID is created after method has ran, but company ID will already exist which is why its added here
                //not sure if it will be linked properly but we can make edits upon testing
                CompanyId = interview.CompanyId,
                Interviewer = interview.Interviewer,
                DateOfInterview = interview.DateOfInterview,
                CreatedDate = DateTime.Now,
                TypeOfInterview = interview.TypeOfInterview,
                InterviewLevel = interview.InterviewLevel,
                Comment = interview.Comment,
                Rating = interview.Rating

            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Interviews.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<InterviewListItem> GetInterviewListItems()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Interviews
                    .OrderBy(e => e.InterviewId)
                    .Select(
                        e =>
                        new InterviewListItem
                        {
                            CompanyName = e.Company.Name,
                            DateOfInterview = e.DateOfInterview,
                            TypeOfInterview = e.TypeOfInterview,
                            Comment = e.Comment,
                            Rating = e.Rating

                        }
                        );
                return query.ToArray();
            }
        }

        public InterviewDetail GetInterviewById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Interviews
                    .Single(e => e.InterviewId == id);
                return
                    new InterviewDetail
                    {
                        Company = entity.Company.Name,
                        Interviewer = entity.Interviewer,
                        CreatedDate = entity.CreatedDate,
                        DateOfInterview = entity.DateOfInterview,
                        ModifiedDate = entity.ModifiedDate,
                        TypeOfInterview = entity.TypeOfInterview,
                        InterviewLevel = entity.InterviewLevel,
                        Comment = entity.Comment,
                        Rating = entity.Rating
                    };
            }
        }

        public bool UpdateInterview(InterviewEdit interview)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx.Interviews
                    .Single(e => e.InterviewId == interview.InterviewId);
                entity.Interviewer = interview.Interviewer;
                entity.DateOfInterview = interview.DateOfInterview;
                entity.ModifiedDate = DateTime.Now;
                entity.TypeOfInterview = interview.TypeOfInterview;
                entity.InterviewLevel = interview.InterviewLevel;
                entity.Comment = interview.Comment;
                entity.Rating = interview.Rating;

                return ctx.SaveChanges() == 1;


            }
        }

        public bool DeleteInterview(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Interviews
                    .Single(e => e.InterviewId == id);

                ctx.Interviews.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }


}
