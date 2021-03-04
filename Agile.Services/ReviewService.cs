using Agile.Data;
using Agile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agile.Services
{
    public class ReviewService
    {
        private readonly Guid _userId;

        public ReviewService(Guid userId)
        {
            _userId = userId;
        }


        public bool CreateMovie(ReviewCreate model)
        {
            var entity =
                new Review()
                {
                    Summary = model.Summary,
                    MovieId = model.MovieId,
                    

                };
            using (var context = new ApplicationDbContext())
            {
                context.Reviews.Add(entity);
                return context.SaveChanges() == 1;
            }
        }
    }
}
